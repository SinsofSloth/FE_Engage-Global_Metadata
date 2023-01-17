// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerUIntField : DebugUIHandlerWidget // TypeDefIndex: 4722
{
	// Fields
	public Text nameLabel; // 0x58
	public Text valueLabel; // 0x60
	private DebugUI.UIntField m_Field; // 0x68

	// Methods

	// RVA: 0x1A0C550 Offset: 0x1A0C651 VA: 0x1A0C550 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A0C6D0 Offset: 0x1A0C7D1 VA: 0x1A0C6D0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0C730 Offset: 0x1A0C831 VA: 0x1A0C730 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0C780 Offset: 0x1A0C881 VA: 0x1A0C780 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1A0C8F0 Offset: 0x1A0C9F1 VA: 0x1A0C8F0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1A0C820 Offset: 0x1A0C921 VA: 0x1A0C820
	private void ChangeValue(bool fast, int multiplier) { }

	// RVA: 0x1A0C5F0 Offset: 0x1A0C6F1 VA: 0x1A0C5F0
	private void UpdateValueLabel() { }

	// RVA: 0x1A0C9A0 Offset: 0x1A0CAA1 VA: 0x1A0C9A0
	public void .ctor() { }
}

