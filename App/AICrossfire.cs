// Namespace: App
public class AICrossfire // TypeDefIndex: 9252
{
	// Fields
	private const int PositionMax = 32;
	private const int RangeFar = 10;
	private static readonly ReadOnlyCollection<AICrossfire.PositionTable> aPositionTable; // 0x0
	private AICrossfire.Crossfire[] m_aCrossfire; // 0x10
	private int m_Num; // 0x18
	private AICrossfire.Ahead m_Ahead; // 0x1C
	private AIBattleSimulator m_SimulatorForAhead; // 0x28

	// Methods

	// RVA: 0x1CA21C0 Offset: 0x1CA22C1 VA: 0x1CA21C0
	public void .ctor() { }

	// RVA: 0x1CA2420 Offset: 0x1CA2521 VA: 0x1CA2420
	public bool Think() { }

	// RVA: 0x1CA8EC0 Offset: 0x1CA8FC1 VA: 0x1CA8EC0
	private void Calculate() { }

	// RVA: 0x1CA9210 Offset: 0x1CA9311 VA: 0x1CA9210
	private void CalculateAhead(Unit actor, Unit target, int x, int z) { }

	// RVA: 0x1CA98E0 Offset: 0x1CA99E1 VA: 0x1CA98E0
	private bool IsPermission(Unit unit) { }

	// RVA: 0x1CA9C70 Offset: 0x1CA9D71 VA: 0x1CA9C70
	private int GetAttackRange(Unit unit, out ulong bit, bool far) { }

	// RVA: 0x1CAA3A0 Offset: 0x1CAA4A1 VA: 0x1CAA3A0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE910 Offset: 0x2AEA11 VA: 0x2AE910
	// RVA: 0x1CAAA60 Offset: 0x1CAAB61 VA: 0x1CAAA60
	private void <Calculate>b__14_0(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE920 Offset: 0x2AEA21 VA: 0x2AE920
	// RVA: 0x1CAAD80 Offset: 0x1CAAE81 VA: 0x1CAAD80
	private void <Calculate>b__14_1(Unit unit) { }
}

