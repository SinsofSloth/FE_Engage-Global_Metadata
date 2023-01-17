// Namespace: 
private struct AICrossfire.PositionTable // TypeDefIndex: 9243
{
	// Fields
	public sbyte m_X; // 0x0
	public sbyte m_Z; // 0x1
	public sbyte m_Range; // 0x2

	// Methods

	// RVA: 0x2F30420 Offset: 0x2F30521 VA: 0x2F30420
	public void .ctor(sbyte x, sbyte z, sbyte range) { }

	// RVA: 0x2F30180 Offset: 0x2F30281 VA: 0x2F30180
	public bool IsFar() { }
}

// Namespace: 
public enum AICrossfire.Fire.Type // TypeDefIndex: 9244
{
	// Fields
	public int value__; // 0x0
	public const AICrossfire.Fire.Type None = -1;
	public const AICrossfire.Fire.Type Direct = 0;
	public const AICrossfire.Fire.Type Indirect = 1;
	public const AICrossfire.Fire.Type Indirect3 = 2;
	public const AICrossfire.Fire.Type Far = 3;
	public const AICrossfire.Fire.Type Num = 4;
}

// Namespace: 
private class AICrossfire.Fire // TypeDefIndex: 9245
{
	// Fields
	private Unit m_Unit; // 0x10
	private uint m_Mask; // 0x18
	private AIBattleSimulator[] m_aSimulator; // 0x20
	private sbyte[] m_aItemIndex; // 0x28
	private AICrossfire.Fire.Type m_Strongest; // 0x30

	// Properties
	public Unit Unit { get; set; }
	public uint Mask { get; set; }
	public uint StrongestScore { get; }

	// Methods

	// RVA: 0x2F301D0 Offset: 0x2F302D1 VA: 0x2F301D0
	public Unit get_Unit() { }

	// RVA: 0x2F301E0 Offset: 0x2F302E1 VA: 0x2F301E0
	public void set_Unit(Unit value) { }

	// RVA: 0x2F301F0 Offset: 0x2F302F1 VA: 0x2F301F0
	public uint get_Mask() { }

	// RVA: 0x2F30200 Offset: 0x2F30301 VA: 0x2F30200
	public void set_Mask(uint value) { }

	// RVA: 0x2F30210 Offset: 0x2F30311 VA: 0x2F30210
	public uint get_StrongestScore() { }

	// RVA: 0x2F30190 Offset: 0x2F30291 VA: 0x2F30190
	public AIBattleSimulator Simulator(AICrossfire.Fire.Type type) { }

	// RVA: 0x2F30270 Offset: 0x2F30371 VA: 0x2F30270
	public int ItemIndex(int index) { }

	// RVA: 0x2F30130 Offset: 0x2F30231 VA: 0x2F30130
	public uint Score(AICrossfire.Fire.Type type) { }

	// RVA: 0x2F2F930 Offset: 0x2F2FA31 VA: 0x2F2F930
	public void .ctor() { }

	// RVA: 0x2F2EDB0 Offset: 0x2F2EEB1 VA: 0x2F2EDB0
	public void CalculateSimulator(AICrossfire.Fire.Type type, Unit actor, Unit target) { }

	// RVA: 0x2F30110 Offset: 0x2F30211 VA: 0x2F30110
	public static AICrossfire.Fire.Type RangeToType(int range) { }

	// RVA: 0x2F302C0 Offset: 0x2F303C1 VA: 0x2F302C0
	public static int TypeToRange(AICrossfire.Fire.Type type) { }
}

// Namespace: 
private class AICrossfire.FireComparer : IComparer<AICrossfire.Fire> // TypeDefIndex: 9246
{
	// Methods

	// RVA: 0x2F302D0 Offset: 0x2F303D1 VA: 0x2F302D0 Slot: 4
	public int Compare(AICrossfire.Fire x, AICrossfire.Fire y) { }

	// RVA: 0x2F30410 Offset: 0x2F30511 VA: 0x2F30410
	public void .ctor() { }
}

// Namespace: 
private class AICrossfire.Crossfire // TypeDefIndex: 9247
{
	// Fields
	private Unit m_Target; // 0x10
	private AICrossfire.Fire[] m_aFire; // 0x18
	private int m_Num; // 0x20
	private int m_ActorFireIndex; // 0x24
	private int m_ActorPositionIndex; // 0x28
	private int m_Times; // 0x2C

	// Properties
	public Unit Target { get; set; }
	public int Num { get; set; }
	public int ActorFireIndex { get; }
	public int ActorPositionIndex { get; }

	// Methods

	// RVA: 0x2F2F720 Offset: 0x2F2F821 VA: 0x2F2F720
	public Unit get_Target() { }

	// RVA: 0x2F2F730 Offset: 0x2F2F831 VA: 0x2F2F730
	public void set_Target(Unit value) { }

	// RVA: 0x2F2F740 Offset: 0x2F2F841 VA: 0x2F2F740
	public int get_Num() { }

	// RVA: 0x2F2F750 Offset: 0x2F2F851 VA: 0x2F2F750
	public void set_Num(int value) { }

	// RVA: 0x2F2F760 Offset: 0x2F2F861 VA: 0x2F2F760
	public int get_ActorFireIndex() { }

	// RVA: 0x2F2F770 Offset: 0x2F2F871 VA: 0x2F2F770
	public int get_ActorPositionIndex() { }

	// RVA: 0x2F2ED60 Offset: 0x2F2EE61 VA: 0x2F2ED60
	public AICrossfire.Fire GetFire(int index) { }

	// RVA: 0x2F2F780 Offset: 0x2F2F881 VA: 0x2F2F780
	public void .ctor() { }

	// RVA: 0x2F2FAD0 Offset: 0x2F2FBD1 VA: 0x2F2FAD0
	public int CalculateScore(AICrossfire.FireComparer fireComparer) { }
}

// Namespace: 
private struct AICrossfire.Ahead // TypeDefIndex: 9248
{
	// Fields
	public float Kill; // 0x0
	public int X; // 0x4
	public int Z; // 0x8
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275310 Offset: 0x275411 VA: 0x275310
private sealed class AICrossfire.<>c__DisplayClass12_0 // TypeDefIndex: 9249
{
	// Fields
	public int num; // 0x10

	// Methods

	// RVA: 0x2F2EB30 Offset: 0x2F2EC31 VA: 0x2F2EB30
	public void .ctor() { }

	// RVA: 0x2F2EB40 Offset: 0x2F2EC41 VA: 0x2F2EB40
	internal void <.ctor>b__0(Force.Type forceType) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275320 Offset: 0x275421 VA: 0x275320
private sealed class AICrossfire.<>c__DisplayClass14_0 // TypeDefIndex: 9250
{
	// Fields
	public AIDeploy deploy; // 0x10
	public MapImage image; // 0x18
	public Unit unit; // 0x20

	// Methods

	// RVA: 0x2F2EBA0 Offset: 0x2F2ECA1 VA: 0x2F2EBA0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275330 Offset: 0x275431 VA: 0x275330
private sealed class AICrossfire.<>c__DisplayClass14_1 // TypeDefIndex: 9251
{
	// Fields
	public AICrossfire.Fire fire; // 0x10
	public AICrossfire.Crossfire cf; // 0x18
	public int posIndex; // 0x20
	public Unit target; // 0x28
	public ulong rangeBit; // 0x30
	public AICrossfire.<>c__DisplayClass14_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x2F2EBB0 Offset: 0x2F2ECB1 VA: 0x2F2EBB0
	public void .ctor() { }

	// RVA: 0x2F2EBC0 Offset: 0x2F2ECC1 VA: 0x2F2EBC0
	internal MapFor.Return <Calculate>b__2(int x, int z, int range) { }
}

