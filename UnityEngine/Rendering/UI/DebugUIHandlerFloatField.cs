// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerFloatField : DebugUIHandlerWidget // TypeDefIndex: 4708
{
	// Fields
	public Text nameLabel; // 0x58
	public Text valueLabel; // 0x60
	private DebugUI.FloatField m_Field; // 0x68

	// Methods

	// RVA: 0x1B3C670 Offset: 0x1B3C771 VA: 0x1B3C670 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1B3C7D0 Offset: 0x1B3C8D1 VA: 0x1B3C7D0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1B3C830 Offset: 0x1B3C931 VA: 0x1B3C830 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1B3C880 Offset: 0x1B3C981 VA: 0x1B3C880 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1B3C9D0 Offset: 0x1B3CAD1 VA: 0x1B3C9D0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1B3C920 Offset: 0x1B3CA21 VA: 0x1B3C920
	private void ChangeValue(bool fast, float multiplier) { }

	// RVA: 0x1B3C710 Offset: 0x1B3C811 VA: 0x1B3C710
	private void UpdateValueLabel() { }

	// RVA: 0x1B3CA70 Offset: 0x1B3CB71 VA: 0x1B3CA70
	public void .ctor() { }
}

