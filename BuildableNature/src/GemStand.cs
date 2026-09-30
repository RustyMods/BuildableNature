using System.Collections.Generic;
using UnityEngine;

namespace BuildableNature;

public class GemStand : MonoBehaviour, Interactable, Hoverable
{
    public ZNetView m_nview;
    public string m_name = "";
    public Transform m_attachOther;
    public Transform m_dropSpawnPoint;
    public bool m_canBeRemoved = true;
    public bool m_autoAttach;
    public float m_hoverOffset;
    public List<ItemDrop> m_supportedItems = [];
    public EffectList m_effects = new();
    public EffectList m_destroyEffects = new();
    public int m_visualHash;
    public GameObject m_visualItem;
    public string m_currentItemName = "";
    public ItemDrop.ItemData m_queuedItem;
    public ItemDrop m_visualItemDrop;
    public int m_updateCount;

    public void Awake()
    {
        m_nview = GetComponent<ZNetView>();
        if (m_nview.GetZDO() == null) return;
        if (TryGetComponent(out WearNTear component))
        {
            component.m_onDestroyed += OnDestroyed;
        }
        m_nview.Register(nameof(RPC_DropItem), RPC_DropItem);
        m_nview.Register(nameof(RPC_UpdateVisual), RPC_UpdateVisual);
        m_nview.Register(nameof(RPC_RequestOwn), RPC_RequestOwn);
        m_nview.Register(nameof(RPC_DestroyAttachment), RPC_DestroyAttachment);
        m_nview.Register<int>(nameof(RPC_SetVisualItem), RPC_SetVisualItem);
        InvokeRepeating(nameof(UpdateVisual), 1f, 4f);
    }

    public void OnDestroyed()
    {
        if (!m_nview.IsOwner()) return;
        DropItem();
    }

    public void DropItem()
    {
        if (!HaveAttachment()) return;
        GameObject itemPrefab = ObjectDB.instance.GetItemPrefab(m_nview.GetZDO().GetInt(ZDOVars.s_item));
        if (itemPrefab)
        {
            Vector3 vector3 = Vector3.zero;
            Quaternion quaternion = Quaternion.identity;
            Transform t = itemPrefab.transform.Find("attach");
            if (itemPrefab.transform.Find("attachobj") && t)
            {
                quaternion = t.localRotation;
                vector3 = t.localPosition;
            }
            GameObject go = Instantiate(itemPrefab, m_dropSpawnPoint.position + vector3, m_dropSpawnPoint.rotation * quaternion);
            go.GetComponent<ItemDrop>().LoadFromExternalZDO(m_nview.GetZDO());
            go.GetComponent<Rigidbody>().linearVelocity = Vector3.up * 4f;
            m_effects.Create(m_dropSpawnPoint.position, Quaternion.identity);
        }

        m_nview.GetZDO().Set(ZDOVars.s_item, 0);
        m_nview.InvokeRPC(ZNetView.Everybody, nameof(RPC_SetVisualItem), 0);
    }

    public Transform GetAttach(ItemDrop.ItemData item) => m_attachOther;
    

    public void RPC_DropItem(long sender)
    {
        if (!m_nview.IsOwner() || !m_canBeRemoved) return;
        DropItem();
    }

    public void RPC_UpdateVisual(long sender) => UpdateVisual();

    public void RPC_RequestOwn(long sender)
    {
        if (!m_nview.IsOwner()) return;
        m_nview.GetZDO().SetOwner(sender);
    }

    public void DestroyAttachment() => m_nview.InvokeRPC(nameof(RPC_DestroyAttachment));

    public void RPC_DestroyAttachment(long sender)
    {
        if (!m_nview.IsOwner() || !HaveAttachment()) return;
        m_nview.GetZDO().Set(ZDOVars.s_item, 0);
        m_nview.InvokeRPC(ZNetView.Everybody, nameof(RPC_SetVisualItem), 0);
        m_destroyEffects.Create(m_dropSpawnPoint.position, Quaternion.identity);
    }

    public void RPC_SetVisualItem(long sender, int hash)
    {
        SetVisualItem(hash);
    }

    public void SetVisualItem(int hash)
    {
        if (m_visualHash == hash) return;
        if (m_visualItem)
        {
            Destroy(m_visualItem);
        }

        m_visualHash = hash;
        m_currentItemName = "";
        if (m_visualHash != 0)
        {
            GameObject itemPrefab = ObjectDB.instance.GetItemPrefab(hash);
            if (itemPrefab == null)
            {
                ZLog.LogWarning("Missing item prefab " + hash);
            }
            else
            {
                GameObject attachPrefab = ItemStand.GetAttachPrefab(itemPrefab);
                if (attachPrefab == null)
                {
                    ZLog.LogWarning("Failed to get attach prefab for item " + hash);
                }
                else
                {
                    m_visualItemDrop = itemPrefab.GetComponent<ItemDrop>();
                    m_currentItemName = m_visualItemDrop.m_itemData.m_shared.m_name;
                    Transform attach = GetAttach(m_visualItemDrop.m_itemData);
                    m_visualItem = Instantiate(
                        attachPrefab, 
                        attach.position,
                        attach.rotation, 
                        attach);
                    
                    if (itemPrefab.name.StartsWith("Ancient"))
                    {
                        m_visualItem.transform.localPosition = Vector3.zero;
                        m_visualItem.transform.localRotation = Quaternion.identity;
                    }
                    else
                    {
                        m_visualItem.transform.localPosition = new Vector3(-0.01100007f, 0.2200019f, 0.1340035f);
                        m_visualItem.transform.localRotation = Quaternion.Euler(45f, 0f, 180f);
                        m_visualItem.transform.localScale = new Vector3(2f, 2f, 2f);
                    }
                    
                    if (m_updateCount > 0)
                    {
                        m_effects.Create(attach.transform.position, Quaternion.identity);
                    }
                }
            }
        }
    }

    public void UpdateVisual()
    {
        if (m_nview == null || !m_nview.IsValid()) return;
        SetVisualItem(m_nview.GetZDO().GetInt(ZDOVars.s_item));
        ++m_updateCount;
    }

    public void UpdateAttach()
    {
        if (!m_nview.IsOwner()) return;
        CancelInvoke(nameof(UpdateAttach));
        if (m_queuedItem != null && 
            Player.m_localPlayer &&
            Player.m_localPlayer.GetInventory().ContainsItem(m_queuedItem) && 
            !HaveAttachment())
        {
            ItemDrop.ItemData itemData = m_queuedItem.Clone();
            itemData.m_stack = 1;
            int stableHashCode = m_queuedItem.m_dropPrefab.name.GetStableHashCode();
            m_nview.GetZDO().Set(ZDOVars.s_item, stableHashCode);
            ItemDrop.SaveToZDO(itemData, m_nview.GetZDO());
            Player.m_localPlayer.UnequipItem(m_queuedItem);
            Player.m_localPlayer.GetInventory().RemoveOneItem(m_queuedItem);
            m_nview.InvokeRPC(ZNetView.Everybody, nameof(RPC_SetVisualItem), stableHashCode);
            Game.instance.IncrementPlayerStat(PlayerStatType.ItemStandUses);
        }

        m_queuedItem = null;
    }

    public bool HaveAttachment()
    {
        return m_nview.IsValid() && m_nview.GetZDO().GetInt(ZDOVars.s_item) != 0;
    }
    
    
    public bool Interact(Humanoid user, bool hold, bool alt)
    {
        if (!PrivateArea.CheckAccess(transform.position)) return true;
        if (!HaveAttachment())
        {
            user.Message(MessageHud.MessageType.Center, "$piece_itemstand_missingitem");
            return false;
        }

        if (m_canBeRemoved & hold)
        {
            m_nview.InvokeRPC(nameof(RPC_DropItem));
            return true;
        }

        return false;
    }

    public bool UseItem(Humanoid user, ItemDrop.ItemData item)
    {
        if (HaveAttachment()) return false;
        if (!CanAttach(item))
        {
            user.Message(MessageHud.MessageType.Center, "$piece_itemstand_cantattach");
            return true;
        }

        if (!m_nview.IsOwner())
        {
            m_nview.InvokeRPC(nameof(RPC_RequestOwn));
        }
        
        m_queuedItem = item;
        CancelInvoke(nameof(UpdateAttach));
        InvokeRepeating(nameof(UpdateAttach), 0.0f, 0.1f);
        return true;
    }

    public bool CanAttach(ItemDrop.ItemData item)
    {
        return ItemStand.GetAttachPrefab(item.m_dropPrefab) != null && IsSupported(item);
    }

    public bool IsSupported(ItemDrop.ItemData item)
    {
        if (m_supportedItems.Count == 0) return true;
        for (int i = 0; i < m_supportedItems.Count; ++i)
        {
            var supported =  m_supportedItems[i];
            if (supported.m_itemData.m_shared.m_name == item.m_shared.m_name) return true;
        }

        return false;
    }
    public string GetHoverText()
    {
        if (!Player.m_localPlayer) return "";
        if (!PrivateArea.CheckAccess(transform.position, flash: false))
        {
            return Localization.instance.Localize(m_name + "\n$piece_noaccess");
        }

        if (HaveAttachment())
        {
            if (!m_canBeRemoved) return "";
            string text = !ZInput.IsGamepadActive() ? 
                $"{m_name} ( {m_currentItemName} )\n[<color=yellow><b>$ui_hold $KEY_Use</b></color>] $piece_itemstand_take" : 
                $"{m_name} ( {m_currentItemName} )\n<b>$ui_hold $KEY_Use</b> $piece_itemstand_take";
            return Localization.instance.Localize(text);
        }
        return m_autoAttach && m_supportedItems.Count == 1 ? 
            Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_Use</b></color>] $piece_itemstand_attach") : 
            Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_HotbarUse</b></color>] $piece_itemstand_attach");

    }

    public string GetHoverName() => m_name;

    public float GetHoverOffset() => m_hoverOffset;
}