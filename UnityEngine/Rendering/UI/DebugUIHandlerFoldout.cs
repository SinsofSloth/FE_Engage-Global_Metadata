// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerFoldout : DebugUIHandlerWidget // TypeDefIndex: 4709
{
	// Fields
	public Text nameLabel; // 0x58
	public UIFoldout valueToggle; // 0x60
	private DebugUI.Foldout m_Field; // 0x68
	private DebugUIHandlerContainer m_Container; // 0x70
	private const float xDecal = 60;
	private const float xDecalInit = 230;

	// Methods

	// RVA: 0x1A09310 Offset: 0x1A09411 VA: 0x1A09310 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A096B0 Offset: 0x1A097B1 VA: 0x1A096B0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A09790 Offset: 0x1A09891 VA: 0x1A09790 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A097B0 Offset: 0x1A098B1 VA: 0x1A097B0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1A097D0 Offset: 0x1A098D1 VA: 0x1A097D0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1A097F0 Offset: 0x1A098F1 VA: 0x1A097F0 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1A09690 Offset: 0x1A09791 VA: 0x1A09690
	private void UpdateValue() { }

	// RVA: 0x1A09820 Offset: 0x1A09921 VA: 0x1A09820 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x1A09A30 Offset: 0x1A09B31 VA: 0x1A09A30
	public void .ctor() { }
}

