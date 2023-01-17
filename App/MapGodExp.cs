// Namespace: App
public class MapGodExp : SingletonClass<MapGodExp> // TypeDefIndex: 12024
{
	// Fields
	private BitField32 m_AddFlag; // 0x20
	private Unit m_CommitUnit; // 0x28
	private GodUnit m_CommitGodUnit; // 0x30
	private int m_Exp; // 0x38
	private int m_Dirty; // 0x3C
	private static readonly MapGodExp.KindDesc[] KindDescs; // 0x0
	private const string EngageParamNameSuffix = "ENG";
	private static readonly MapGodExp.KindDesc[] RingDirtyKindDescs; // 0x8

	// Methods

	// RVA: 0x21C7D40 Offset: 0x21C7E41 VA: 0x21C7D40
	public void .ctor() { }

	// RVA: 0x21C7E80 Offset: 0x21C7F81 VA: 0x21C7E80
	public void AddBattle(BattleCalculator calculator) { }

	// RVA: 0x21C83D0 Offset: 0x21C84D1 VA: 0x21C83D0
	public void AddCommandSkill() { }

	// RVA: 0x21C8490 Offset: 0x21C8591 VA: 0x21C8490
	public void AddEngageAttack() { }

	// RVA: 0x21C8540 Offset: 0x21C8641 VA: 0x21C8540
	public static float GetMultiplier(GodUnit godUnit) { }

	// RVA: 0x21C8630 Offset: 0x21C8731 VA: 0x21C8630
	public void TryCommit(ProcInst super) { }

	// RVA: 0x21C7E30 Offset: 0x21C7F31 VA: 0x21C7E30
	public void Reset() { }

	// RVA: 0x21C81D0 Offset: 0x21C82D1 VA: 0x21C81D0
	private void Add(MapGodExp.Kinds kind) { }

	// RVA: 0x21C87B0 Offset: 0x21C88B1 VA: 0x21C87B0
	private int GetExp(MapGodExp.Kinds kind, bool isEngage) { }

	// RVA: 0x21C8730 Offset: 0x21C8831 VA: 0x21C8730
	private Unit GetCurrentUnit() { }

	// RVA: 0x21C8090 Offset: 0x21C8191 VA: 0x21C8090
	private bool IsValidCommon() { }

	// RVA: 0x21C88D0 Offset: 0x21C89D1 VA: 0x21C88D0
	private int GetDirty(MapGodExp.Kinds kind, bool isEngage) { }

	// RVA: 0x21C89F0 Offset: 0x21C8AF1 VA: 0x21C89F0
	private static void .cctor() { }
}

