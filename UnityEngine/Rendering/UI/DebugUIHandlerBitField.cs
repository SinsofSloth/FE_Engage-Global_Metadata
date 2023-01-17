// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerBitField : DebugUIHandlerWidget // TypeDefIndex: 4696
{
	// Fields
	public Text nameLabel; // 0x58
	public UIFoldout valueToggle; // 0x60
	public List<DebugUIHandlerIndirectToggle> toggles; // 0x68
	private DebugUI.BitField m_Field; // 0x70
	private DebugUIHandlerContainer m_Container; // 0x78

	// Methods

	// RVA: 0x1B37C10 Offset: 0x1B37D11 VA: 0x1B37C10 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1B37FB0 Offset: 0x1B380B1 VA: 0x1B37FB0
	private bool GetValue(int index) { }

	// RVA: 0x1B38070 Offset: 0x1B38171 VA: 0x1B38070
	private void SetValue(int index, bool value) { }

	// RVA: 0x1B382E0 Offset: 0x1B383E1 VA: 0x1B382E0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1B38620 Offset: 0x1B38721 VA: 0x1B38620 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1B38640 Offset: 0x1B38741 VA: 0x1B38640 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1B38650 Offset: 0x1B38751 VA: 0x1B38650 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1B38660 Offset: 0x1B38761 VA: 0x1B38660 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1B38680 Offset: 0x1B38781 VA: 0x1B38680 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x1B38840 Offset: 0x1B38941 VA: 0x1B38840
	public void .ctor() { }
}

