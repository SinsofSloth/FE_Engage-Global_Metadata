// Namespace: 
private struct AIInterruptAttack.AttackScoreResult // TypeDefIndex: 9258
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286E70 Offset: 0x286F71 VA: 0x286E70
	private uint <Score>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x286E80 Offset: 0x286F81 VA: 0x286E80
	private int <MoveX>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x286E90 Offset: 0x286F91 VA: 0x286E90
	private int <MoveZ>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x286EA0 Offset: 0x286FA1 VA: 0x286EA0
	private int <AttackX>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0x286EB0 Offset: 0x286FB1 VA: 0x286EB0
	private int <AttackZ>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x286EC0 Offset: 0x286FC1 VA: 0x286EC0
	private int <ItemIndex>k__BackingField; // 0x14

	// Properties
	public uint Score { get; set; }
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public int ItemIndex { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2AEB70 Offset: 0x2AEC71 VA: 0x2AEB70
	[CompilerGeneratedAttribute] // RVA: 0x2AEB70 Offset: 0x2AEC71 VA: 0x2AEB70
	// RVA: 0x2F31180 Offset: 0x2F31281 VA: 0x2F31180
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEBB0 Offset: 0x2AECB1 VA: 0x2AEBB0
	// RVA: 0x2F31190 Offset: 0x2F31291 VA: 0x2F31190
	public void set_Score(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AEBC0 Offset: 0x2AECC1 VA: 0x2AEBC0
	[CompilerGeneratedAttribute] // RVA: 0x2AEBC0 Offset: 0x2AECC1 VA: 0x2AEBC0
	// RVA: 0x2F311A0 Offset: 0x2F312A1 VA: 0x2F311A0
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEC00 Offset: 0x2AED01 VA: 0x2AEC00
	// RVA: 0x2F311B0 Offset: 0x2F312B1 VA: 0x2F311B0
	public void set_MoveX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEC10 Offset: 0x2AED11 VA: 0x2AEC10
	[IsReadOnlyAttribute] // RVA: 0x2AEC10 Offset: 0x2AED11 VA: 0x2AEC10
	// RVA: 0x2F311C0 Offset: 0x2F312C1 VA: 0x2F311C0
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEC50 Offset: 0x2AED51 VA: 0x2AEC50
	// RVA: 0x2F311D0 Offset: 0x2F312D1 VA: 0x2F311D0
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEC60 Offset: 0x2AED61 VA: 0x2AEC60
	[IsReadOnlyAttribute] // RVA: 0x2AEC60 Offset: 0x2AED61 VA: 0x2AEC60
	// RVA: 0x2F311E0 Offset: 0x2F312E1 VA: 0x2F311E0
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AECA0 Offset: 0x2AEDA1 VA: 0x2AECA0
	// RVA: 0x2F311F0 Offset: 0x2F312F1 VA: 0x2F311F0
	public void set_AttackX(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x2AECB0 Offset: 0x2AEDB1 VA: 0x2AECB0
	[CompilerGeneratedAttribute] // RVA: 0x2AECB0 Offset: 0x2AEDB1 VA: 0x2AECB0
	// RVA: 0x2F31200 Offset: 0x2F31301 VA: 0x2F31200
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AECF0 Offset: 0x2AEDF1 VA: 0x2AECF0
	// RVA: 0x2F31210 Offset: 0x2F31311 VA: 0x2F31210
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AED00 Offset: 0x2AEE01 VA: 0x2AED00
	[IsReadOnlyAttribute] // RVA: 0x2AED00 Offset: 0x2AEE01 VA: 0x2AED00
	// RVA: 0x2F31220 Offset: 0x2F31321 VA: 0x2F31220
	public int get_ItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AED40 Offset: 0x2AEE41 VA: 0x2AED40
	// RVA: 0x2F31230 Offset: 0x2F31331 VA: 0x2F31230
	public void set_ItemIndex(int value) { }

	// RVA: 0x2F31240 Offset: 0x2F31341 VA: 0x2F31240
	public void Clear() { }
}

// Namespace: 
private class AIInterruptAttack.Candidate // TypeDefIndex: 9259
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286ED0 Offset: 0x286FD1 VA: 0x286ED0
	private Unit <Unit>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x286EE0 Offset: 0x286FE1 VA: 0x286EE0
	private bool <IsThinkBreak>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x286EF0 Offset: 0x286FF1 VA: 0x286EF0
	private bool <IsThinkChain>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x286F00 Offset: 0x287001 VA: 0x286F00
	private int <Dist>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x286F10 Offset: 0x287011 VA: 0x286F10
	private int <BulletPattern>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x286F20 Offset: 0x287021 VA: 0x286F20
	private int <MoveX>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x286F30 Offset: 0x287031 VA: 0x286F30
	private int <MoveZ>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x286F40 Offset: 0x287041 VA: 0x286F40
	private int <AttackX>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x286F50 Offset: 0x287051 VA: 0x286F50
	private int <AttackZ>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x286F60 Offset: 0x287061 VA: 0x286F60
	private int <ItemIndex>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x286F70 Offset: 0x287071 VA: 0x286F70
	private uint <Score>k__BackingField; // 0x38

	// Properties
	public Unit Unit { get; set; }
	public bool IsThinkBreak { get; set; }
	public bool IsThinkChain { get; set; }
	public int Dist { get; set; }
	public int BulletPattern { get; set; }
	public int MoveX { get; set; }
	public int MoveZ { get; set; }
	public int AttackX { get; set; }
	public int AttackZ { get; set; }
	public int ItemIndex { get; set; }
	public uint Score { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AED50 Offset: 0x2AEE51 VA: 0x2AED50
	// RVA: 0x2F31260 Offset: 0x2F31361 VA: 0x2F31260
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AED60 Offset: 0x2AEE61 VA: 0x2AED60
	// RVA: 0x2F31270 Offset: 0x2F31371 VA: 0x2F31270
	public void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AED70 Offset: 0x2AEE71 VA: 0x2AED70
	// RVA: 0x2F31280 Offset: 0x2F31381 VA: 0x2F31280
	public bool get_IsThinkBreak() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AED80 Offset: 0x2AEE81 VA: 0x2AED80
	// RVA: 0x2F31290 Offset: 0x2F31391 VA: 0x2F31290
	public void set_IsThinkBreak(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AED90 Offset: 0x2AEE91 VA: 0x2AED90
	// RVA: 0x2F312A0 Offset: 0x2F313A1 VA: 0x2F312A0
	public bool get_IsThinkChain() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEDA0 Offset: 0x2AEEA1 VA: 0x2AEDA0
	// RVA: 0x2F312B0 Offset: 0x2F313B1 VA: 0x2F312B0
	public void set_IsThinkChain(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEDB0 Offset: 0x2AEEB1 VA: 0x2AEDB0
	// RVA: 0x2F312C0 Offset: 0x2F313C1 VA: 0x2F312C0
	public int get_Dist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEDC0 Offset: 0x2AEEC1 VA: 0x2AEDC0
	// RVA: 0x2F312D0 Offset: 0x2F313D1 VA: 0x2F312D0
	public void set_Dist(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEDD0 Offset: 0x2AEED1 VA: 0x2AEDD0
	// RVA: 0x2F312E0 Offset: 0x2F313E1 VA: 0x2F312E0
	public int get_BulletPattern() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEDE0 Offset: 0x2AEEE1 VA: 0x2AEDE0
	// RVA: 0x2F312F0 Offset: 0x2F313F1 VA: 0x2F312F0
	public void set_BulletPattern(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEDF0 Offset: 0x2AEEF1 VA: 0x2AEDF0
	// RVA: 0x2F31300 Offset: 0x2F31401 VA: 0x2F31300
	public int get_MoveX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE00 Offset: 0x2AEF01 VA: 0x2AEE00
	// RVA: 0x2F31310 Offset: 0x2F31411 VA: 0x2F31310
	public void set_MoveX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE10 Offset: 0x2AEF11 VA: 0x2AEE10
	// RVA: 0x2F31320 Offset: 0x2F31421 VA: 0x2F31320
	public int get_MoveZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE20 Offset: 0x2AEF21 VA: 0x2AEE20
	// RVA: 0x2F31330 Offset: 0x2F31431 VA: 0x2F31330
	public void set_MoveZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE30 Offset: 0x2AEF31 VA: 0x2AEE30
	// RVA: 0x2F31340 Offset: 0x2F31441 VA: 0x2F31340
	public int get_AttackX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE40 Offset: 0x2AEF41 VA: 0x2AEE40
	// RVA: 0x2F31350 Offset: 0x2F31451 VA: 0x2F31350
	public void set_AttackX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE50 Offset: 0x2AEF51 VA: 0x2AEE50
	// RVA: 0x2F31360 Offset: 0x2F31461 VA: 0x2F31360
	public int get_AttackZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE60 Offset: 0x2AEF61 VA: 0x2AEE60
	// RVA: 0x2F31370 Offset: 0x2F31471 VA: 0x2F31370
	public void set_AttackZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE70 Offset: 0x2AEF71 VA: 0x2AEE70
	// RVA: 0x2F31380 Offset: 0x2F31481 VA: 0x2F31380
	public int get_ItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE80 Offset: 0x2AEF81 VA: 0x2AEE80
	// RVA: 0x2F31390 Offset: 0x2F31491 VA: 0x2F31390
	public void set_ItemIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEE90 Offset: 0x2AEF91 VA: 0x2AEE90
	// RVA: 0x2F313A0 Offset: 0x2F314A1 VA: 0x2F313A0
	public uint get_Score() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AEEA0 Offset: 0x2AEFA1 VA: 0x2AEEA0
	// RVA: 0x2F313B0 Offset: 0x2F314B1 VA: 0x2F313B0
	public void set_Score(uint value) { }

	// RVA: 0x2F313C0 Offset: 0x2F314C1 VA: 0x2F313C0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275380 Offset: 0x275481 VA: 0x275380
[Serializable]
private sealed class AIInterruptAttack.CandidateList.<>c // TypeDefIndex: 9260
{
	// Fields
	public static readonly AIInterruptAttack.CandidateList.<>c <>9; // 0x0
	public static Comparison<AIInterruptAttack.Candidate> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1DBD080 Offset: 0x1DBD181 VA: 0x1DBD080
	private static void .cctor() { }

	// RVA: 0x1DBD0F0 Offset: 0x1DBD1F1 VA: 0x1DBD0F0
	public void .ctor() { }

	// RVA: 0x1DBD100 Offset: 0x1DBD201 VA: 0x1DBD100
	internal int <Sort>b__4_0(AIInterruptAttack.Candidate a, AIInterruptAttack.Candidate b) { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x275340 Offset: 0x275441 VA: 0x275340
private class AIInterruptAttack.CandidateList // TypeDefIndex: 9261
{
	// Fields
	private List<AIInterruptAttack.Candidate> m_Pool; // 0x10
	private List<AIInterruptAttack.Candidate> m_List; // 0x18

	// Properties
	public int Count { get; }
	public AIInterruptAttack.Candidate Item { get; }

	// Methods

	// RVA: 0x2F313D0 Offset: 0x2F314D1 VA: 0x2F313D0
	public void .ctor() { }

	// RVA: 0x2F30F30 Offset: 0x2F31031 VA: 0x2F30F30
	public void Add(Unit unit, bool isThinkBreak, bool isThinkChain, int dist) { }

	// RVA: 0x2F31610 Offset: 0x2F31711 VA: 0x2F31610
	public void Sort() { }

	// RVA: 0x2F31740 Offset: 0x2F31841 VA: 0x2F31740
	public void Clear() { }

	// RVA: 0x2F31810 Offset: 0x2F31911 VA: 0x2F31810
	public bool HasAttacker() { }

	// RVA: 0x2F31890 Offset: 0x2F31991 VA: 0x2F31890
	public AIInterruptAttack.Candidate GetAttacker() { }

	// RVA: 0x2F31950 Offset: 0x2F31A51 VA: 0x2F31950
	public int get_Count() { }

	// RVA: 0x2F319A0 Offset: 0x2F31AA1 VA: 0x2F319A0
	public AIInterruptAttack.Candidate get_Item(int index) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275390 Offset: 0x275491 VA: 0x275390
private sealed class AIInterruptAttack.<>c__DisplayClass28_0 // TypeDefIndex: 9262
{
	// Fields
	public AIInterruptAttack <>4__this; // 0x10
	public bool isOriginalThinkBreak; // 0x18
	public bool isOriginalThinkChain; // 0x19

	// Methods

	// RVA: 0x2F30D10 Offset: 0x2F30E11 VA: 0x2F30D10
	public void .ctor() { }

	// RVA: 0x2F30D20 Offset: 0x2F30E21 VA: 0x2F30D20
	internal void <EnumerateCandidates>b__0(Unit unit) { }
}

