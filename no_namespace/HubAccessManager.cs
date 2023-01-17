// Namespace: 
public enum HubAccessManager.MaterialCalculator.Type // TypeDefIndex: 10646
{
	// Fields
	public int value__; // 0x0
	public const HubAccessManager.MaterialCalculator.Type Iron = 0;
	public const HubAccessManager.MaterialCalculator.Type Steel = 1;
	public const HubAccessManager.MaterialCalculator.Type Silver = 2;
}

// Namespace: 
private class HubAccessManager.MaterialCalculator // TypeDefIndex: 10647
{
	// Methods

	// RVA: 0x1FAC1E0 Offset: 0x1FAC2E1 VA: 0x1FAC1E0
	public static List<ValueTuple<HubAccessManager.MaterialCalculator.Type, int>> Eval(int num, int divnum) { }

	// RVA: 0x1FAC340 Offset: 0x1FAC441 VA: 0x1FAC340
	private static List<ValueTuple<HubAccessManager.MaterialCalculator.Type, int>> DivMaterials(Dictionary<HubAccessManager.MaterialCalculator.Type, int> materials, int divnum) { }

	// RVA: 0x1FAC230 Offset: 0x1FAC331 VA: 0x1FAC230
	private static Dictionary<HubAccessManager.MaterialCalculator.Type, int> GenerateHigherMaterials(int num) { }

	// RVA: 0x1FAC890 Offset: 0x1FAC991 VA: 0x1FAC890
	private static HubAccessManager.MaterialCalculator.Type GetValidHigherMateriaslType(Dictionary<HubAccessManager.MaterialCalculator.Type, int> materials) { }

	// RVA: 0x1FAC960 Offset: 0x1FACA61 VA: 0x1FAC960
	private static HubAccessManager.MaterialCalculator.Type ConvertToLowerMaterialType(HubAccessManager.MaterialCalculator.Type type) { }

	// RVA: 0x1FAC770 Offset: 0x1FAC871 VA: 0x1FAC770
	private static void FilterLowerMaterials(Dictionary<HubAccessManager.MaterialCalculator.Type, int> materials) { }

	// RVA: 0x1FAC5B0 Offset: 0x1FAC6B1 VA: 0x1FAC5B0
	private static List<ValueTuple<HubAccessManager.MaterialCalculator.Type, int>> CreateResultFromMaterials(Dictionary<HubAccessManager.MaterialCalculator.Type, int> materials) { }

	// RVA: 0x1FAC980 Offset: 0x1FACA81 VA: 0x1FAC980
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276FF0 Offset: 0x2770F1 VA: 0x276FF0
[Serializable]
private sealed class HubAccessManager.<>c // TypeDefIndex: 10648
{
	// Fields
	public static readonly HubAccessManager.<>c <>9; // 0x0
	public static Comparison<HubDisposData> <>9__25_0; // 0x8
	public static Predicate<HubAccessData> <>9__26_0; // 0x10
	[TupleElementNamesAttribute] // RVA: 0x293260 Offset: 0x293361 VA: 0x293260
	public static Comparison<ValueTuple<string, int, int, int>> <>9__40_0; // 0x18

	// Methods

	// RVA: 0x1FAC100 Offset: 0x1FAC201 VA: 0x1FAC100
	private static void .cctor() { }

	// RVA: 0x1FAC170 Offset: 0x1FAC271 VA: 0x1FAC170
	public void .ctor() { }

	// RVA: 0x1FAC180 Offset: 0x1FAC281 VA: 0x1FAC180
	internal int <Setup>b__25_0(HubDisposData a, HubDisposData b) { }

	// RVA: 0x1FAC190 Offset: 0x1FAC291 VA: 0x1FAC190
	internal bool <ConfirmContent>b__26_0(HubAccessData access) { }

	// RVA: 0x1FAC1A0 Offset: 0x1FAC2A1 VA: 0x1FAC1A0
	internal int <GetChooseID>b__40_0(ValueTuple<string, int, int, int> a, ValueTuple<string, int, int, int> b) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277000 Offset: 0x277101 VA: 0x277000
private sealed class HubAccessManager.<>c__DisplayClass32_0 // TypeDefIndex: 10649
{
	// Fields
	public string locator; // 0x10

	// Methods

	// RVA: 0x1FAC1B0 Offset: 0x1FAC2B1 VA: 0x1FAC1B0
	public void .ctor() { }

	// RVA: 0x1FAC1C0 Offset: 0x1FAC2C1 VA: 0x1FAC1C0
	internal bool <AddNewLocator>b__0(HubDisposData data) { }
}

