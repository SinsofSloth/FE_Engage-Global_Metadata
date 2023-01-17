// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerVector4 : DebugUIHandlerWidget // TypeDefIndex: 4727
{
	// Fields
	public Text nameLabel; // 0x58
	public UIFoldout valueToggle; // 0x60
	public DebugUIHandlerIndirectFloatField fieldX; // 0x68
	public DebugUIHandlerIndirectFloatField fieldY; // 0x70
	public DebugUIHandlerIndirectFloatField fieldZ; // 0x78
	public DebugUIHandlerIndirectFloatField fieldW; // 0x80
	private DebugUI.Vector4Field m_Field; // 0x88
	private DebugUIHandlerContainer m_Container; // 0x90

	// Methods

	// RVA: 0x1A0E400 Offset: 0x1A0E501 VA: 0x1A0E400 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A0E920 Offset: 0x1A0EA21 VA: 0x1A0E920
	private void SetValue(float v, bool x = False, bool y = False, bool z = False, bool w = False) { }

	// RVA: 0x1A0E7D0 Offset: 0x1A0E8D1 VA: 0x1A0E7D0
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x1A0E9E0 Offset: 0x1A0EAE1 VA: 0x1A0E9E0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0EAC0 Offset: 0x1A0EBC1 VA: 0x1A0EAC0 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0EAE0 Offset: 0x1A0EBE1 VA: 0x1A0EAE0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1A0EAF0 Offset: 0x1A0EBF1 VA: 0x1A0EAF0 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1A0EB00 Offset: 0x1A0EC01 VA: 0x1A0EB00 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1A0EB20 Offset: 0x1A0EC21 VA: 0x1A0EB20 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x1A0EC00 Offset: 0x1A0ED01 VA: 0x1A0EC00
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E090 Offset: 0x3E191 VA: 0x3E090
	// RVA: 0x1A0ECB0 Offset: 0x1A0EDB1 VA: 0x1A0ECB0
	private float <SetWidget>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E0A0 Offset: 0x3E1A1 VA: 0x3E0A0
	// RVA: 0x1A0ED10 Offset: 0x1A0EE11 VA: 0x1A0ED10
	private void <SetWidget>b__8_1(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E0B0 Offset: 0x3E1B1 VA: 0x3E0B0
	// RVA: 0x1A0EDA0 Offset: 0x1A0EEA1 VA: 0x1A0EDA0
	private float <SetWidget>b__8_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E0C0 Offset: 0x3E1C1 VA: 0x3E0C0
	// RVA: 0x1A0EE00 Offset: 0x1A0EF01 VA: 0x1A0EE00
	private void <SetWidget>b__8_3(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E0D0 Offset: 0x3E1D1 VA: 0x3E0D0
	// RVA: 0x1A0EE90 Offset: 0x1A0EF91 VA: 0x1A0EE90
	private float <SetWidget>b__8_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E0E0 Offset: 0x3E1E1 VA: 0x3E0E0
	// RVA: 0x1A0EEF0 Offset: 0x1A0EFF1 VA: 0x1A0EEF0
	private void <SetWidget>b__8_5(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E0F0 Offset: 0x3E1F1 VA: 0x3E0F0
	// RVA: 0x1A0EF80 Offset: 0x1A0F081 VA: 0x1A0EF80
	private float <SetWidget>b__8_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E100 Offset: 0x3E201 VA: 0x3E100
	// RVA: 0x1A0EFE0 Offset: 0x1A0F0E1 VA: 0x1A0EFE0
	private void <SetWidget>b__8_7(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E110 Offset: 0x3E211 VA: 0x3E110
	// RVA: 0x1A0F070 Offset: 0x1A0F171 VA: 0x1A0F070
	private float <SetupSettings>b__10_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E120 Offset: 0x3E221 VA: 0x3E120
	// RVA: 0x1A0F080 Offset: 0x1A0F181 VA: 0x1A0F080
	private float <SetupSettings>b__10_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E130 Offset: 0x3E231 VA: 0x3E130
	// RVA: 0x1A0F090 Offset: 0x1A0F191 VA: 0x1A0F090
	private float <SetupSettings>b__10_2() { }
}

