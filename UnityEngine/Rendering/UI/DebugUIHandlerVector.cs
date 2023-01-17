// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerVector3 : DebugUIHandlerWidget // TypeDefIndex: 4726
{
	// Fields
	public Text nameLabel; // 0x58
	public UIFoldout valueToggle; // 0x60
	public DebugUIHandlerIndirectFloatField fieldX; // 0x68
	public DebugUIHandlerIndirectFloatField fieldY; // 0x70
	public DebugUIHandlerIndirectFloatField fieldZ; // 0x78
	private DebugUI.Vector3Field m_Field; // 0x80
	private DebugUIHandlerContainer m_Container; // 0x88

	// Methods

	// RVA: 0x1A0D900 Offset: 0x1A0DA01 VA: 0x1A0D900 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A0DD70 Offset: 0x1A0DE71 VA: 0x1A0DD70
	private void SetValue(float v, bool x = False, bool y = False, bool z = False) { }

	// RVA: 0x1A0DC20 Offset: 0x1A0DD21 VA: 0x1A0DC20
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x1A0DE30 Offset: 0x1A0DF31 VA: 0x1A0DE30 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0DF10 Offset: 0x1A0E011 VA: 0x1A0DF10 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0DF30 Offset: 0x1A0E031 VA: 0x1A0DF30 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1A0DF40 Offset: 0x1A0E041 VA: 0x1A0DF40 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1A0DF50 Offset: 0x1A0E051 VA: 0x1A0DF50 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1A0DF70 Offset: 0x1A0E071 VA: 0x1A0DF70 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x1A0E050 Offset: 0x1A0E151 VA: 0x1A0E050
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E000 Offset: 0x3E101 VA: 0x3E000
	// RVA: 0x1A0E100 Offset: 0x1A0E201 VA: 0x1A0E100
	private float <SetWidget>b__7_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E010 Offset: 0x3E111 VA: 0x3E010
	// RVA: 0x1A0E160 Offset: 0x1A0E261 VA: 0x1A0E160
	private void <SetWidget>b__7_1(float v) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E020 Offset: 0x3E121 VA: 0x3E020
	// RVA: 0x1A0E1F0 Offset: 0x1A0E2F1 VA: 0x1A0E1F0
	private float <SetWidget>b__7_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E030 Offset: 0x3E131 VA: 0x3E030
	// RVA: 0x1A0E250 Offset: 0x1A0E351 VA: 0x1A0E250
	private void <SetWidget>b__7_3(float v) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E040 Offset: 0x3E141 VA: 0x3E040
	// RVA: 0x1A0E2E0 Offset: 0x1A0E3E1 VA: 0x1A0E2E0
	private float <SetWidget>b__7_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E050 Offset: 0x3E151 VA: 0x3E050
	// RVA: 0x1A0E340 Offset: 0x1A0E441 VA: 0x1A0E340
	private void <SetWidget>b__7_5(float v) { }

	[CompilerGeneratedAttribute] // RVA: 0x3E060 Offset: 0x3E161 VA: 0x3E060
	// RVA: 0x1A0E3D0 Offset: 0x1A0E4D1 VA: 0x1A0E3D0
	private float <SetupSettings>b__9_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E070 Offset: 0x3E171 VA: 0x3E070
	// RVA: 0x1A0E3E0 Offset: 0x1A0E4E1 VA: 0x1A0E3E0
	private float <SetupSettings>b__9_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x3E080 Offset: 0x3E181 VA: 0x3E080
	// RVA: 0x1A0E3F0 Offset: 0x1A0E4F1 VA: 0x1A0E3F0
	private float <SetupSettings>b__9_2() { }
}

