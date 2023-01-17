// Namespace: 
public enum Cooking.Quality // TypeDefIndex: 13509
{
	// Fields
	public int value__; // 0x0
	public const Cooking.Quality Special1 = 0;
	public const Cooking.Quality Special2 = 1;
	public const Cooking.Quality Special3 = 2;
	public const Cooking.Quality Common = 3;
	public const Cooking.Quality Bad = 4;
	public const Cooking.Quality Num = 5;
	public const Cooking.Quality None = 6;
}

// Namespace: 
public enum Cooking.ConversationType // TypeDefIndex: 13510
{
	// Fields
	public int value__; // 0x0
	public const Cooking.ConversationType AboutDelicious = 0;
	public const Cooking.ConversationType Monologue = 1;
	public const Cooking.ConversationType Dialogue = 2;
	public const Cooking.ConversationType Num = 3;
}

// Namespace: 
public class Cooking.Probability // TypeDefIndex: 13511
{
	// Fields
	private static readonly float[] BaseProbability; // 0x0
	private static readonly float[][] ProbabilityCorrections; // 0x8
	private static readonly float[][] ProbabilityFromFoodstuff; // 0x10

	// Methods

	// RVA: 0x1E0BD20 Offset: 0x1E0BE21 VA: 0x1E0BD20
	public static List<float> GetProbabilities(CookData.Difficulty difficulty, FoodstuffData[] foodstuffs) { }

	// RVA: 0x1E0BF00 Offset: 0x1E0C001 VA: 0x1E0BF00
	public void .ctor() { }

	// RVA: 0x1E0BF10 Offset: 0x1E0C011 VA: 0x1E0BF10
	private static void .cctor() { }
}

// Namespace: 
public enum Cooking.Order // TypeDefIndex: 13512
{
	// Fields
	public int value__; // 0x0
	public const Cooking.Order Before = 0;
	public const Cooking.Order After = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278ED0 Offset: 0x278FD1 VA: 0x278ED0
[Serializable]
private sealed class Cooking.<>c // TypeDefIndex: 13513
{
	// Fields
	public static readonly Cooking.<>c <>9; // 0x0
	public static Func<TasteData, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x1E0B880 Offset: 0x1E0B981 VA: 0x1E0B880
	private static void .cctor() { }

	// RVA: 0x1E0B8F0 Offset: 0x1E0B9F1 VA: 0x1E0B8F0
	public void .ctor() { }

	// RVA: 0x1E0B900 Offset: 0x1E0BA01 VA: 0x1E0B900
	internal bool <DetermineTaste>b__6_0(TasteData data) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278EE0 Offset: 0x278FE1 VA: 0x278EE0
private sealed class Cooking.<>c__DisplayClass10_0 // TypeDefIndex: 13514
{
	// Fields
	public string bentoName; // 0x10
	public int count; // 0x18

	// Methods

	// RVA: 0x1E0B960 Offset: 0x1E0BA61 VA: 0x1E0B960
	public void .ctor() { }

	// RVA: 0x1E0B970 Offset: 0x1E0BA71 VA: 0x1E0B970
	internal void <ThrowAwayBento>b__0(Unit unit) { }
}

