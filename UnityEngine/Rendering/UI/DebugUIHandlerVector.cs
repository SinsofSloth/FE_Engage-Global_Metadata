// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerVector2 : DebugUIHandlerWidget // TypeDefIndex: 4725
{
	// Fields
	public Text nameLabel; // 0x58
	public UIFoldout valueToggle; // 0x60
	public DebugUIHandlerIndirectFloatField fieldX; // 0x68
	public DebugUIHandlerIndirectFloatField fieldY; // 0x70
	private DebugUI.Vector2Field m_Field; // 0x78
	private DebugUIHandlerContainer m_Container; // 0x80

	// Methods

	// RVA: 0x1A0CFC0 Offset: 0x1A0D0C1 VA: 0x1A0CFC0 Slot: 5
	internal override void SetWidget(DebugUI.Widget widget) { }

	// RVA: 0x1A0D380 Offset: 0x1A0D481 VA: 0x1A0D380
	private void SetValue(float v, bool x = False, bool y = False) { }

	// RVA: 0x1A0D230 Offset: 0x1A0D331 VA: 0x1A0D230
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	// RVA: 0x1A0D420 Offset: 0x1A0D521 VA: 0x1A0D420 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0D500 Offset: 0x1A0D601 VA: 0x1A0D500 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0D520 Offset: 0x1A0D621 VA: 0x1A0D520 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1A0D530 Offset: 0x1A0D631 VA: 0x1A0D530 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1A0D540 Offset: 0x1A0D641 VA: 0x1A0D540 Slot: 8
	public override void OnAction() { }

	// RVA: 0x1A0D560 Offset: 0x1A0D661 VA: 0x1A0D560 Slot: 12
	public override DebugUIHandlerWidget Next() { }

	// RVA: 0x1A0D640 Offset: 0x1A0D741 VA: 0x1A0D640
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DF90 Offset: 0x3E091 VA: 0x3DF90
	// RVA: 0x1A0D6F0 Offset: 0x1A0D7F1 VA: 0x1A0D6F0
	private float <SetWidget>b__6_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DFA0 Offset: 0x3E0A1 VA: 0x3DFA0
	// RVA: 0x1A0D750 Offset: 0x1A0D851 VA: 0x1A0D750
	private void <SetWidget>b__6_1(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DFB0 Offset: 0x3E0B1 VA: 0x3DFB0
	// RVA: 0x1A0D7E0 Offset: 0x1A0D8E1 VA: 0x1A0D7E0
	private float <SetWidget>b__6_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DFC0 Offset: 0x3E0C1 VA: 0x3DFC0
	// RVA: 0x1A0D840 Offset: 0x1A0D941 VA: 0x1A0D840
	private void <SetWidget>b__6_3(float x) { }

	[CompilerGeneratedAttribute] // RVA: 0x3DFD0 Offset: 0x3E0D1 VA: 0x3DFD0
	// RVA: 0x1A0D8D0 Offset: 0x1A0D9D1 VA: 0x1A0D8D0
	private float <SetupSettings>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DFE0 Offset: 0x3E0E1 VA: 0x3DFE0
	// RVA: 0x1A0D8E0 Offset: 0x1A0D9E1 VA: 0x1A0D8E0
	private float <SetupSettings>b__8_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x3DFF0 Offset: 0x3E0F1 VA: 0x3DFF0
	// RVA: 0x1A0D8F0 Offset: 0x1A0D9F1 VA: 0x1A0D8F0
	private float <SetupSettings>b__8_2() { }
}

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

