// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget // TypeDefIndex: 4713
{
	// Fields
	public Text nameLabel; // 0x58
	public Toggle valueToggle; // 0x60
	public Image checkmarkImage; // 0x68
	public Func<int, bool> getter; // 0x70
	public Action<int, bool> setter; // 0x78
	internal int index; // 0x80

	// Methods

	// RVA: 0x1A0A540 Offset: 0x1A0A641 VA: 0x1A0A540
	public void Init() { }

	// RVA: 0x1A0A610 Offset: 0x1A0A711 VA: 0x1A0A610 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0A670 Offset: 0x1A0A771 VA: 0x1A0A670 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0A6C0 Offset: 0x1A0A7C1 VA: 0x1A0A6C0 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1A0A550 Offset: 0x1A0A651 VA: 0x1A0A550
	internal void UpdateValueLabel() { }

	// RVA: 0x1A0A750 Offset: 0x1A0A851 VA: 0x1A0A750
	public void .ctor() { }
}

