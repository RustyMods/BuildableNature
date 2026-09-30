using System.Text;
using UnityEngine;

namespace BuildableNature;

public class BeamToggle : MonoBehaviour, Interactable, Hoverable
{
    public GameObject m_beam;
    public ZNetView m_nview;
    public Piece m_piece;
    public EffectList m_disableEffects = new EffectList();
    public EffectList m_enableEffects = new EffectList();
    public string m_name = "";
    public void Awake()
    {
        m_nview = GetComponent<ZNetView>();
        m_piece = GetComponent<Piece>();
        m_beam = Utils.FindChild(transform, "BellHolder_Beam").gameObject;
        if (!m_nview.IsValid()) return;
        m_nview.Register<bool>(nameof(RPC_ToggleBeam), RPC_ToggleBeam);
    }

    public void RPC_ToggleBeam(long sender, bool enable)
    {
        m_beam.SetActive(enable);
    }
    
    public bool Interact(Humanoid user, bool hold, bool alt)
    {
        bool isBeamActive = m_beam.activeSelf;
        if (isBeamActive)
        {
            m_disableEffects.Create(transform.position, transform.rotation, transform);
        }
        m_nview.InvokeRPC(ZNetView.Everybody,  nameof(RPC_ToggleBeam), !isBeamActive);
        return true;
    }

    public bool UseItem(Humanoid user, ItemDrop.ItemData item) => false;
    
    public string GetHoverText()
    {
        if (!PrivateArea.CheckAccess(transform.position, flash: false))
        {
            return Localization.instance.Localize(m_name + "\n$piece_noaccess");
        }
        return Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_Use</b></color>] $piece_use");
    }

    public string GetHoverName() => m_piece.m_name;

    public float GetHoverOffset() => 0f;
}