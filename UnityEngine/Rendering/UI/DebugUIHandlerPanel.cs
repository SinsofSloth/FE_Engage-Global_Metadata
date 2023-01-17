// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerPanel : MonoBehaviour // TypeDefIndex: 4715
{
	// Fields
	public Text nameLabel; // 0x18
	public ScrollRect scrollRect; // 0x20
	public RectTransform viewport; // 0x28
	private RectTransform m_ScrollTransform; // 0x30
	private RectTransform m_ContentTransform; // 0x38
	private RectTransform m_MaskTransform; // 0x40
	protected internal DebugUI.Panel m_Panel; // 0x48

	// Methods

	// RVA: 0x1A0ACD0 Offset: 0x1A0ADD1 VA: 0x1A0ACD0
	private void OnEnable() { }

	// RVA: 0x1A0ADB0 Offset: 0x1A0AEB1 VA: 0x1A0ADB0
	internal void SetPanel(DebugUI.Panel panel) { }

	// RVA: 0x1A0AE60 Offset: 0x1A0AF61 VA: 0x1A0AE60
	internal DebugUI.Panel GetPanel() { }

	// RVA: 0x1A0AE70 Offset: 0x1A0AF71 VA: 0x1A0AE70
	internal void ScrollTo(DebugUIHandlerWidget target) { }

	// RVA: 0x1A0B000 Offset: 0x1A0B101 VA: 0x1A0B000
	private float GetYPosInScroll(RectTransform target) { }

	// RVA: 0x1A0B100 Offset: 0x1A0B201 VA: 0x1A0B100
	internal DebugUIHandlerWidget GetFirstItem() { }

	// RVA: 0x1A0B160 Offset: 0x1A0B261 VA: 0x1A0B160
	public void .ctor() { }
}

