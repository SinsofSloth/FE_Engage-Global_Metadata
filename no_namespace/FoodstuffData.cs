// Namespace: 
[FlagsAttribute] // RVA: 0x276050 Offset: 0x276151 VA: 0x276050
public enum FoodstuffData.Flags // TypeDefIndex: 9851
{
	// Fields
	public int value__; // 0x0
	public const FoodstuffData.Flags IsCategory = 1;
	public const FoodstuffData.Flags AddToAnything = 2;
	public const FoodstuffData.Flags NotAffect = 4;
	public const FoodstuffData.Flags RaiseReliance = 8;
}

// Namespace: 
public sealed class FoodstuffData.FlagField : BitFieldTemplate32<FoodstuffData.Flags> // TypeDefIndex: 9852
{
	// Methods

	// RVA: 0x22DEAD0 Offset: 0x22DEBD1 VA: 0x22DEAD0
	public void .ctor(int f) { }

	// RVA: 0x22DEB30 Offset: 0x22DEC31 VA: 0x22DEB30
	public void .ctor(FoodstuffData.Flags f) { }

	// RVA: 0x22DEB90 Offset: 0x22DEC91 VA: 0x22DEB90 Slot: 5
	protected override int ToInt(FoodstuffData.Flags value) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276060 Offset: 0x276161 VA: 0x276060
private sealed class FoodstuffData.<>c__DisplayClass29_0 // TypeDefIndex: 9853
{
	// Fields
	public FoodstuffData <>4__this; // 0x10
	public int count; // 0x18

	// Methods

	// RVA: 0x22DE9D0 Offset: 0x22DEAD1 VA: 0x22DE9D0
	public void .ctor() { }

	// RVA: 0x22DE9E0 Offset: 0x22DEAE1 VA: 0x22DE9E0
	internal void <GetCountInventory>b__0(FoodstuffData foodstuff) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276070 Offset: 0x276171 VA: 0x276070
private sealed class FoodstuffData.<>c__DisplayClass30_0 // TypeDefIndex: 9854
{
	// Fields
	public string iid; // 0x10
	public List<FoodstuffData> list; // 0x18

	// Methods

	// RVA: 0x22DEA40 Offset: 0x22DEB41 VA: 0x22DEA40
	public void .ctor() { }

	// RVA: 0x22DEA50 Offset: 0x22DEB51 VA: 0x22DEA50
	internal void <GetCategoryFoodstuffs>b__0(FoodstuffData item) { }
}

