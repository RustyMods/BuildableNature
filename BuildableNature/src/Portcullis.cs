using UnityEngine;

namespace BuildableNature;

public class Portcullis : MonoBehaviour, Interactable, Hoverable
{
    public ZNetView m_nview;
    public string m_name = "Portcullis";
    public Transform m_gate;
    public Vector3 m_closedPosition;
    public Vector3 m_openPosition;
    public float m_speed = 1.5f;
    public EffectList m_openEffects = new();
    public EffectList m_closedEffects = new();
    public void Awake()
    {
        m_nview = GetComponent<ZNetView>();
        m_closedPosition = m_gate.transform.localPosition;
        if (m_nview == null || m_nview.GetZDO() == null) return;
        m_nview.Register(nameof(RPC_UseDoor), RPC_UseDoor);

        if (m_nview.GetZDO().GetInt(ZDOVars.s_state) != 0)
        {
            m_openEffects.Create(transform.position, transform.rotation);
        }
    }

    public void FixedUpdate()
    {
        if (!m_nview.IsValid()) return;
        bool open = m_nview.GetZDO().GetInt(ZDOVars.s_state) != 0;
        
        var target = open ? 
            m_openPosition : 
            m_closedPosition;
        
        if (m_gate.transform.localPosition == target) return;
        
        m_gate.transform.localPosition = Vector3.MoveTowards(
            m_gate.transform.localPosition, 
            target, 
            m_speed * Time.deltaTime);
    }

    public bool Interact(Humanoid user, bool hold, bool alt)
    {
        if (!PrivateArea.CheckAccess(transform.position, flash: false))
        {
            return true;
        }
        m_nview.InvokeRPC(nameof(RPC_UseDoor));
        return true;
    }

    public void RPC_UseDoor(long sender)
    {
        var current = m_nview.GetZDO().GetInt(ZDOVars.s_state);
        if (current == 0)
        {
            m_nview.GetZDO().Set(ZDOVars.s_state, 1);
            m_openEffects.Create(transform.position, transform.rotation, transform);    
        }
        else
        {
            m_nview.GetZDO().Set(ZDOVars.s_state, 0);
            m_closedEffects.Create(transform.position, transform.rotation);
        }
    }
    
    public bool UseItem(Humanoid user, ItemDrop.ItemData item) => false;

    public string GetHoverText()
    {
        if (!m_nview.IsValid()) return "";
        if (!PrivateArea.CheckAccess(transform.position, flash: false))
        {
            return Localization.instance.Localize(m_name + "\n$piece_noaccess");
        }
        var state = m_nview.GetZDO().GetInt(ZDOVars.s_state);
        return Localization.instance.Localize($"{m_name}\n[<color=yellow><b>$KEY_Use</b></color>] {(state != 0 ? "$piece_door_close" : "$piece_door_open")}");
    }

    public string GetHoverName() => m_name;

    public float GetHoverOffset() => 0f;
}