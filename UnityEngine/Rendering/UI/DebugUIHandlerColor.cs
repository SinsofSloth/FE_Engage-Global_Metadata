// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerColor : DebugUIHandlerWidget // TypeDefIndex: 4702
{
	// Fields
	public Text nameLabel; // 0x58
	public UIFoldout valueToggle; // 0x60
	public Image colorImage; // 0x68
	public DebugUIHandlerIndirectFloatField fieldR; // 0x70
	public DebugUIHandlerIndirectFloatField fieldG; // 0x78
	public DebugUIHandlerIndirectFloatField fieldB; // 0x80
	public DebugUIHandlerIndirectFloatField fieldA; // 0x88
	private DebugUI.ColorField m_Field; // 0x90
	private DebugUIHandlerContainer m_Container; // 0x98

	// Methods

	// RVA: 0x1B3A930 Offset: 0x1B3AA31 VA: 0x1B3A930 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1B3AF50 Offset: 0x1B3B051 VA: 0x1B3AF50
	private void SetValue(float x, bool r = False, bool g = False, bool b = False, bool a = False) { }

	// RVA: 0x1B3AD40 Offset: 0x1B3AE41 VA: 0x1B3AD40
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x1B3B020 Offset: 0x1B3B121 VA: 0x1B3B020 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1B3B1B0 Offset: 0x1B3B2B1 VA: 0x1B3B1B0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1B3B1D0 Offset: 0x1B3B2D1 VA: 0x1B3B1D0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1B3B1E0 Offset: 0x1B3B2E1 VA: 0x1B3B1E0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1B3B1F0 Offset: 0x1B3B2F1 VA: 0x1B3B1F0 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1B3AE90 Offset: 0x1B3AF91 VA: 0x1B3AE90
	internal void UpdateColor() { }

	// RVA: 0x1B3B210 Offset: 0x1B3B311 VA: 0x1B3B210 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x1B3B350 Offset: 0x1B3B451 VA: 0x1B3B350
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DD60 Offset: 0x3DE61 VA: 0x3DD60
	// RVA: 0x1B3B360 Offset: 0x1B3B461 VA: 0x1B3B360
	private float <SetWidget>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DD70 Offset: 0x3DE71 VA: 0x3DD70
	// RVA: 0x1B3B3C0 Offset: 0x1B3B4C1 VA: 0x1B3B3C0
	private void <SetWidget>b__9_1(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DD80 Offset: 0x3DE81 VA: 0x3DD80
	// RVA: 0x1B3B450 Offset: 0x1B3B551 VA: 0x1B3B450
	private float <SetWidget>b__9_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DD90 Offset: 0x3DE91 VA: 0x3DD90
	// RVA: 0x1B3B4B0 Offset: 0x1B3B5B1 VA: 0x1B3B4B0
	private void <SetWidget>b__9_3(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DDA0 Offset: 0x3DEA1 VA: 0x3DDA0
	// RVA: 0x1B3B540 Offset: 0x1B3B641 VA: 0x1B3B540
	private float <SetWidget>b__9_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DDB0 Offset: 0x3DEB1 VA: 0x3DDB0
	// RVA: 0x1B3B5A0 Offset: 0x1B3B6A1 VA: 0x1B3B5A0
	private void <SetWidget>b__9_5(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DDC0 Offset: 0x3DEC1 VA: 0x3DDC0
	// RVA: 0x1B3B630 Offset: 0x1B3B731 VA: 0x1B3B630
	private float <SetWidget>b__9_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DDD0 Offset: 0x3DED1 VA: 0x3DDD0
	// RVA: 0x1B3B690 Offset: 0x1B3B791 VA: 0x1B3B690
	private void <SetWidget>b__9_7(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DDE0 Offset: 0x3DEE1 VA: 0x3DDE0
	// RVA: 0x1B3B720 Offset: 0x1B3B821 VA: 0x1B3B720
	private float <SetupSettings>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DDF0 Offset: 0x3DEF1 VA: 0x3DDF0
	// RVA: 0x1B3B730 Offset: 0x1B3B831 VA: 0x1B3B730
	private float <SetupSettings>b__11_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DE00 Offset: 0x3DF01 VA: 0x3DE00
	// RVA: 0x1B3B740 Offset: 0x1B3B841 VA: 0x1B3B740
	private float <SetupSettings>b__11_2() { }
}

