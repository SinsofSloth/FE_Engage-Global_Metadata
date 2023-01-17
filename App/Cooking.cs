// Namespace: App
public class Cooking // TypeDefIndex: 13515
{
	// Methods

	// RVA: 0x23BFC60 Offset: 0x23BFD61 VA: 0x23BFC60
	public static Dish Cook(Unit unit, FoodData foodData, FoodstuffData[] foodstuffs) { }

	// RVA: 0x23BFD70 Offset: 0x23BFE71 VA: 0x23BFD70
	public static CookData.Difficulty GetDifficulty(Unit unit, FoodData foodData) { }

	// RVA: 0x23BFE10 Offset: 0x23BFF11 VA: 0x23BFE10
	private static Cooking.Quality DetermineQuality(CookData.Difficulty difficulty, FoodstuffData[] foodstuffs) { }

	// RVA: 0x23BFFE0 Offset: 0x23C00E1 VA: 0x23BFFE0
	private static TasteData DetermineTaste(Unit unit, Cooking.Quality quality) { }

	// RVA: 0x23C0400 Offset: 0x23C0501 VA: 0x23C0400
	public static string TryGetDialogueMid(Unit unit, Unit toUnit, Cooking.Order order) { }

	// RVA: 0x23C0660 Offset: 0x23C0761 VA: 0x23C0660
	public static bool TryGetNameType(Unit from, Unit to, out NameTypeData.Type type, out string suffix) { }

	// RVA: 0x23C07A0 Offset: 0x23C08A1 VA: 0x23C07A0
	public static void ThrowAwayBento(ProcInst super) { }

	// RVA: 0x23C0CC0 Offset: 0x23C0DC1 VA: 0x23C0CC0
	public void .ctor() { }
}

