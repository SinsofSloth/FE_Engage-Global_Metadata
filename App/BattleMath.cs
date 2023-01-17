// Namespace: App
public class BattleMath // TypeDefIndex: 9514
{
	// Fields
	private static BattleMath.Probability s_CurrentProbability100; // 0x0
	private static BattleMath.Probability s_CurrentProbabilityHit; // 0x8
	private static BattleMath.Probability s_Probability100; // 0x10
	private static BattleMath.Probability s_ProbabilityHit; // 0x18
	private static BattleMath.Probability s_ProbabilityTrue; // 0x20
	private static BattleMath.Probability s_ProbabilityFalse; // 0x28
	private static Stack<RandomSeed> s_RandomSeed; // 0x30
	private static int s_Simulationed; // 0x38

	// Methods

	// RVA: 0x225AEB0 Offset: 0x225AFB1 VA: 0x225AEB0
	private static bool _IsProbability100(int ratio) { }

	// RVA: 0x225AEE0 Offset: 0x225AFE1 VA: 0x225AEE0
	private static bool _IsProbabilityHit(int ratio) { }

	// RVA: 0x225B0C0 Offset: 0x225B1C1 VA: 0x225B0C0
	private static bool _IsProbabilityTrue(int ratio) { }

	// RVA: 0x225B0D0 Offset: 0x225B1D1 VA: 0x225B0D0
	private static bool _IsProbabilityFalse(int ratio) { }

	// RVA: 0x225B0E0 Offset: 0x225B1E1 VA: 0x225B0E0
	private static void SetSimulation(bool enable) { }

	// RVA: 0x225B1A0 Offset: 0x225B2A1 VA: 0x225B1A0
	public static bool RandomCheck100(int percent) { }

	// RVA: 0x224C3B0 Offset: 0x224C4B1 VA: 0x224C3B0
	public static void PushRandomSeed() { }

	// RVA: 0x224CFA0 Offset: 0x224D0A1 VA: 0x224CFA0
	public static void PopRandomSeed() { }

	// RVA: 0x224C440 Offset: 0x224C541 VA: 0x224C440
	public static void PushSimulation() { }

	// RVA: 0x224D040 Offset: 0x224D141 VA: 0x224D040
	public static void PopSimulation() { }

	// RVA: 0x225B220 Offset: 0x225B321 VA: 0x225B220
	public static bool RandomCheckHit(int ratio) { }

	// RVA: 0x225B000 Offset: 0x225B101 VA: 0x225B000
	private static int GetHitRatio10000(int ratio) { }

	// RVA: 0x225B2A0 Offset: 0x225B3A1 VA: 0x225B2A0
	public static float GetHitRealRatio(int ratio) { }

	// RVA: 0x225B3B0 Offset: 0x225B4B1 VA: 0x225B3B0
	public static int GetRandom(int num) { }

	// RVA: 0x225B3E0 Offset: 0x225B4E1 VA: 0x225B3E0
	public static int GetRandom(int min, int max) { }

	// RVA: 0x225B420 Offset: 0x225B521 VA: 0x225B420
	public void .ctor() { }

	// RVA: 0x225B430 Offset: 0x225B531 VA: 0x225B430
	private static void .cctor() { }
}

