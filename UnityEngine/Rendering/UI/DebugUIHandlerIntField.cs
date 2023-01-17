// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerIntField : DebugUIHandlerWidget // TypeDefIndex: 4714
{
	// Fields
	public Text nameLabel; // 0x58
	public Text valueLabel; // 0x60
	private DebugUI.IntField m_Field; // 0x68

	// Methods

	// RVA: 0x1A0A800 Offset: 0x1A0A901 VA: 0x1A0A800 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A0A980 Offset: 0x1A0AA81 VA: 0x1A0A980 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0A9E0 Offset: 0x1A0AAE1 VA: 0x1A0A9E0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0AA30 Offset: 0x1A0AB31 VA: 0x1A0AA30 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1A0AB80 Offset: 0x1A0AC81 VA: 0x1A0AB80 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1A0AAD0 Offset: 0x1A0ABD1 VA: 0x1A0AAD0
	private void ChangeValue(bool fast, int multiplier) { }

	// RVA: 0x1A0A8A0 Offset: 0x1A0A9A1 VA: 0x1A0A8A0
	private void UpdateValueLabel() { }

	// RVA: 0x1A0AC20 Offset: 0x1A0AD21 VA: 0x1A0AC20
	public void .ctor() { }
}

