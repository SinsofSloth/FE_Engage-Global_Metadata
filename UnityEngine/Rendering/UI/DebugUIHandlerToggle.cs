// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerToggle : DebugUIHandlerWidget // TypeDefIndex: 4719
{
	// Fields
	public Text nameLabel; // 0x58
	public Toggle valueToggle; // 0x60
	public Image checkmarkImage; // 0x68
	protected internal DebugUI.BoolField m_Field; // 0x70

	// Methods

	// RVA: 0x1A0BAA0 Offset: 0x1A0BBA1 VA: 0x1A0BAA0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A0BB50 Offset: 0x1A0BC51 VA: 0x1A0BB50 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0BBB0 Offset: 0x1A0BCB1 VA: 0x1A0BBB0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0BC00 Offset: 0x1A0BD01 VA: 0x1A0BC00 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1A0BC90 Offset: 0x1A0BD91 VA: 0x1A0BC90 Slot: 13
	protected internal virtual void UpdateValueLabel() { }

	// RVA: 0x1A0BD50 Offset: 0x1A0BE51 VA: 0x1A0BD50
	public void .ctor() { }
}

