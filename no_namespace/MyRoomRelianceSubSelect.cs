// Namespace: 
private enum MyRoomRelianceSubSelect.MyRoomRelianceCallSequence.Label // TypeDefIndex: 11319
{
	// Fields
	public int value__; // 0x0
	public const MyRoomRelianceSubSelect.MyRoomRelianceCallSequence.Label Entry = 0;
	public const MyRoomRelianceSubSelect.MyRoomRelianceCallSequence.Label Main = 1;
	public const MyRoomRelianceSubSelect.MyRoomRelianceCallSequence.Label End = 2;
}

// Namespace: 
public class MyRoomRelianceSubSelect.MyRoomRelianceCallSequence : StackProcInst<MyRoomRelianceSubSelect.MyRoomRelianceCallSequence> // TypeDefIndex: 11320
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297A40 Offset: 0x297B41 VA: 0x297A40
	private Unit <Self>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x297A50 Offset: 0x297B51 VA: 0x297A50
	private Unit <Target>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x297A60 Offset: 0x297B61 VA: 0x297A60
	private RelianceData.Level <Level>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x297A70 Offset: 0x297B71 VA: 0x297A70
	private GodUnit <GodTarget>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x297A80 Offset: 0x297B81 VA: 0x297A80
	private GodData <GodTargetData>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x297A90 Offset: 0x297B91 VA: 0x297A90
	private GodData.RelianceLevel <NextRelianceLevel>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x297AA0 Offset: 0x297BA1 VA: 0x297AA0
	private int <PrevLevel>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x297AB0 Offset: 0x297BB1 VA: 0x297AB0
	private int <NextLevel>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x297AC0 Offset: 0x297BC1 VA: 0x297AC0
	private Action <EntryCallback>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x297AD0 Offset: 0x297BD1 VA: 0x297AD0
	private Action <ExitCallback>k__BackingField; // 0xB0
	private bool m_bind; // 0xB8
	private Camera m_camera; // 0xC0

	// Properties
	public Unit Self { get; set; }
	public Unit Target { get; set; }
	public RelianceData.Level Level { get; set; }
	public GodUnit GodTarget { get; set; }
	public GodData GodTargetData { get; set; }
	public GodData.RelianceLevel NextRelianceLevel { get; set; }
	public int PrevLevel { get; set; }
	public int NextLevel { get; set; }
	public Action EntryCallback { get; set; }
	public Action ExitCallback { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C4E30 Offset: 0x2C4F31 VA: 0x2C4E30
	// RVA: 0x26E0800 Offset: 0x26E0901 VA: 0x26E0800
	public Unit get_Self() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4E40 Offset: 0x2C4F41 VA: 0x2C4E40
	// RVA: 0x26E0810 Offset: 0x26E0911 VA: 0x26E0810
	public void set_Self(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4E50 Offset: 0x2C4F51 VA: 0x2C4E50
	// RVA: 0x26E0820 Offset: 0x26E0921 VA: 0x26E0820
	public Unit get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4E60 Offset: 0x2C4F61 VA: 0x2C4E60
	// RVA: 0x26E0830 Offset: 0x26E0931 VA: 0x26E0830
	public void set_Target(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4E70 Offset: 0x2C4F71 VA: 0x2C4E70
	// RVA: 0x26E0840 Offset: 0x26E0941 VA: 0x26E0840
	public RelianceData.Level get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4E80 Offset: 0x2C4F81 VA: 0x2C4E80
	// RVA: 0x26E0850 Offset: 0x26E0951 VA: 0x26E0850
	public void set_Level(RelianceData.Level value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4E90 Offset: 0x2C4F91 VA: 0x2C4E90
	// RVA: 0x26E0860 Offset: 0x26E0961 VA: 0x26E0860
	public GodUnit get_GodTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4EA0 Offset: 0x2C4FA1 VA: 0x2C4EA0
	// RVA: 0x26E0870 Offset: 0x26E0971 VA: 0x26E0870
	public void set_GodTarget(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4EB0 Offset: 0x2C4FB1 VA: 0x2C4EB0
	// RVA: 0x26E0880 Offset: 0x26E0981 VA: 0x26E0880
	public GodData get_GodTargetData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4EC0 Offset: 0x2C4FC1 VA: 0x2C4EC0
	// RVA: 0x26E0890 Offset: 0x26E0991 VA: 0x26E0890
	public void set_GodTargetData(GodData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4ED0 Offset: 0x2C4FD1 VA: 0x2C4ED0
	// RVA: 0x26E08A0 Offset: 0x26E09A1 VA: 0x26E08A0
	public GodData.RelianceLevel get_NextRelianceLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4EE0 Offset: 0x2C4FE1 VA: 0x2C4EE0
	// RVA: 0x26E08B0 Offset: 0x26E09B1 VA: 0x26E08B0
	public void set_NextRelianceLevel(GodData.RelianceLevel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4EF0 Offset: 0x2C4FF1 VA: 0x2C4EF0
	// RVA: 0x26E08C0 Offset: 0x26E09C1 VA: 0x26E08C0
	public int get_PrevLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F00 Offset: 0x2C5001 VA: 0x2C4F00
	// RVA: 0x26E08D0 Offset: 0x26E09D1 VA: 0x26E08D0
	public void set_PrevLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F10 Offset: 0x2C5011 VA: 0x2C4F10
	// RVA: 0x26E08E0 Offset: 0x26E09E1 VA: 0x26E08E0
	public int get_NextLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F20 Offset: 0x2C5021 VA: 0x2C4F20
	// RVA: 0x26E08F0 Offset: 0x26E09F1 VA: 0x26E08F0
	public void set_NextLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F30 Offset: 0x2C5031 VA: 0x2C4F30
	// RVA: 0x26E0900 Offset: 0x26E0A01 VA: 0x26E0900
	public Action get_EntryCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F40 Offset: 0x2C5041 VA: 0x2C4F40
	// RVA: 0x26E0910 Offset: 0x26E0A11 VA: 0x26E0910
	public void set_EntryCallback(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F50 Offset: 0x2C5051 VA: 0x2C4F50
	// RVA: 0x26E0920 Offset: 0x26E0A21 VA: 0x26E0920
	public Action get_ExitCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F60 Offset: 0x2C5061 VA: 0x2C4F60
	// RVA: 0x26E0930 Offset: 0x26E0A31 VA: 0x26E0930
	public void set_ExitCallback(Action value) { }

	// RVA: 0x26E0940 Offset: 0x26E0A41 VA: 0x26E0940
	public static void CreateBind(ProcInst super, Unit self, Unit target, RelianceData.Level level, int preLevel = 0, int nextLevel = 0) { }

	// RVA: 0x26E12B0 Offset: 0x26E13B1 VA: 0x26E12B0
	public static void CreateBind(ProcInst super, Unit self, GodUnit target, GodData.RelianceLevel nextRelianceLevel, int prevLevel = 0, int nextLevel = 0, Action entryCallback, Action exitCallback, GodData godData) { }

	// RVA: 0x26E0B10 Offset: 0x26E0C11 VA: 0x26E0B10
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x26E1430 Offset: 0x26E1531 VA: 0x26E1430
	private void Entry() { }

	// RVA: 0x26E1A80 Offset: 0x26E1B81 VA: 0x26E1A80
	private void Main() { }

	// RVA: 0x26E1D70 Offset: 0x26E1E71 VA: 0x26E1D70
	private void Exit() { }

	// RVA: 0x26E2400 Offset: 0x26E2501 VA: 0x26E2400
	private void UpdateAchive(Unit a, Unit b, RelianceData.Level level) { }

	// RVA: 0x26E2570 Offset: 0x26E2671 VA: 0x26E2570
	private void LevelUp() { }

	// RVA: 0x26E27D0 Offset: 0x26E28D1 VA: 0x26E27D0
	private void LevelUpAfter() { }

	// RVA: 0x26E2990 Offset: 0x26E2A91 VA: 0x26E2990
	private void AmiiboBenefit() { }

	// RVA: 0x26E2A90 Offset: 0x26E2B91 VA: 0x26E2A90
	public void FadeIn() { }

	// RVA: 0x26E1AA0 Offset: 0x26E1BA1 VA: 0x26E1AA0
	private void CreateReliance() { }

	// RVA: 0x26E1C30 Offset: 0x26E1D31 VA: 0x26E1C30
	private void CreateRelianceGod() { }

	// RVA: 0x26E0A80 Offset: 0x26E0B81 VA: 0x26E0A80
	public void .ctor() { }
}

// Namespace: 
public class MyRoomRelianceSubSelect.MyRoomRelianceSubSelectItem : BasicMenuItem // TypeDefIndex: 11321
{
	// Fields
	private Unit m_UnitL; // 0x68
	private Unit m_UnitR; // 0x70
	private GodUnit m_GodUnit; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x297AE0 Offset: 0x297BE1 VA: 0x297AE0
	private bool <IsSelected>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x297AF0 Offset: 0x297BF1 VA: 0x297AF0
	private bool <IsTalk>k__BackingField; // 0x81

	// Properties
	public bool IsSelected { get; set; }
	public bool IsTalk { get; set; }
	public MyRoomRelianceSelectRoot.CursorTop Cursor { get; }
	public bool IsBlank { get; }
	public bool IsAPlus { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C4F70 Offset: 0x2C5071 VA: 0x2C4F70
	// RVA: 0x26E2B00 Offset: 0x26E2C01 VA: 0x26E2B00
	public bool get_IsSelected() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F80 Offset: 0x2C5081 VA: 0x2C4F80
	// RVA: 0x26E2B10 Offset: 0x26E2C11 VA: 0x26E2B10
	public void set_IsSelected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4F90 Offset: 0x2C5091 VA: 0x2C4F90
	// RVA: 0x26E2B20 Offset: 0x26E2C21 VA: 0x26E2B20
	public bool get_IsTalk() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4FA0 Offset: 0x2C50A1 VA: 0x2C4FA0
	// RVA: 0x26E2B30 Offset: 0x26E2C31 VA: 0x26E2B30
	private void set_IsTalk(bool value) { }

	// RVA: 0x26E2B40 Offset: 0x26E2C41 VA: 0x26E2B40
	public MyRoomRelianceSelectRoot.CursorTop get_Cursor() { }

	// RVA: 0x26E2BC0 Offset: 0x26E2CC1 VA: 0x26E2BC0
	public bool get_IsBlank() { }

	// RVA: 0x26E2BF0 Offset: 0x26E2CF1 VA: 0x26E2BF0
	public bool get_IsAPlus() { }

	// RVA: 0x26DFD20 Offset: 0x26DFE21 VA: 0x26DFD20
	public int GetSortOrder() { }

	// RVA: 0x26E2CA0 Offset: 0x26E2DA1 VA: 0x26E2CA0
	public Color GetCommandColor() { }

	// RVA: 0x26E2C30 Offset: 0x26E2D31 VA: 0x26E2C30
	public int GetOpenCount() { }

	// RVA: 0x26E2D20 Offset: 0x26E2E21 VA: 0x26E2D20
	public void .ctor(Unit unitL, Unit unitR) { }

	// RVA: 0x26E2EC0 Offset: 0x26E2FC1 VA: 0x26E2EC0
	public void .ctor(Unit unitL, GodUnit godUnit) { }

	// RVA: 0x26E2D80 Offset: 0x26E2E81 VA: 0x26E2D80
	public void UpdateTalk() { }

	// RVA: 0x26E2F20 Offset: 0x26E3021 VA: 0x26E2F20 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26E3110 Offset: 0x26E3211 VA: 0x26E3110 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x26E3230 Offset: 0x26E3331 VA: 0x26E3230
	private int GetPlayerGodLevel(Unit unitL, Unit unitR) { }

	// RVA: 0x26E32D0 Offset: 0x26E33D1 VA: 0x26E32D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x26E3990 Offset: 0x26E3A91 VA: 0x26E3990 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x26E3AC0 Offset: 0x26E3BC1 VA: 0x26E3AC0
	public Unit GetUnitL() { }

	// RVA: 0x26E3AD0 Offset: 0x26E3BD1 VA: 0x26E3AD0
	public Unit GetUnitR() { }

	// RVA: 0x26E3AE0 Offset: 0x26E3BE1 VA: 0x26E3AE0
	public GodUnit GetGodUnit() { }
}

// Namespace: 
private class MyRoomRelianceSubSelect.AmiiboBenefitSequence : ProcInst // TypeDefIndex: 11322
{
	// Fields
	private GodUnit m_GodUnit; // 0x70
	private int m_PieceCount; // 0x78

	// Methods

	// RVA: 0x26DFDD0 Offset: 0x26DFED1 VA: 0x26DFDD0
	private void .ctor(GodUnit godUnit) { }

	// RVA: 0x26DFE10 Offset: 0x26DFF11 VA: 0x26DFE10
	private void Accessory() { }

	// RVA: 0x26E00A0 Offset: 0x26E01A1 VA: 0x26E00A0
	private void Music() { }

	// RVA: 0x26E0410 Offset: 0x26E0511 VA: 0x26E0410
	private void PieceOfBond() { }

	// RVA: 0x26DFF60 Offset: 0x26E0061 VA: 0x26DFF60
	private void Message(GodUnit godUnit, string spriteName, string itemName) { }

	// RVA: 0x26E04E0 Offset: 0x26E05E1 VA: 0x26E04E0
	public static void CreateBind(ProcInst super, Unit unit, GodUnit godUnit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2774E0 Offset: 0x2775E1 VA: 0x2774E0
[Serializable]
private sealed class MyRoomRelianceSubSelect.<>c // TypeDefIndex: 11323
{
	// Fields
	public static readonly MyRoomRelianceSubSelect.<>c <>9; // 0x0
	public static Comparison<BasicMenuItem> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x26DFAC0 Offset: 0x26DFBC1 VA: 0x26DFAC0
	private static void .cctor() { }

	// RVA: 0x26DFB30 Offset: 0x26DFC31 VA: 0x26DFB30
	public void .ctor() { }

	// RVA: 0x26DFB40 Offset: 0x26DFC41 VA: 0x26DFB40
	internal int <CreateMenuList>b__3_0(BasicMenuItem a, BasicMenuItem b) { }
}

