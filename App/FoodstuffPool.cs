// Namespace: App
public class FoodstuffPool : SingletonClass<FoodstuffPool> // TypeDefIndex: 13521
{
	// Fields
	private FoodData m_Food; // 0x20
	private List<FoodstuffData> m_FoodstuffList; // 0x28
	private int AddableFoodstuffNum; // 0x30

	// Properties
	public int TypeCount { get; }

	// Methods

	// RVA: 0x2A00610 Offset: 0x2A00711 VA: 0x2A00610
	public FoodstuffData[] GetFoodstuffs() { }

	// RVA: 0x2A00670 Offset: 0x2A00771 VA: 0x2A00670
	public FoodstuffData[] GetNormalFoodstuffs() { }

	// RVA: 0x2A00860 Offset: 0x2A00961 VA: 0x2A00860
	public int GetNormalFoodstuffCount() { }

	// RVA: 0x2A009D0 Offset: 0x2A00AD1 VA: 0x2A009D0
	public FoodstuffData GetRareFoodstuff() { }

	// RVA: 0x2A00B60 Offset: 0x2A00C61 VA: 0x2A00B60
	public void Reset(FoodData food) { }

	// RVA: 0x2A00BE0 Offset: 0x2A00CE1 VA: 0x2A00BE0
	public int get_TypeCount() { }

	// RVA: 0x2A00C50 Offset: 0x2A00D51 VA: 0x2A00C50
	private bool IsIncludeRaiseReliance() { }

	// RVA: 0x2A00DF0 Offset: 0x2A00EF1 VA: 0x2A00DF0
	public int Count(FoodstuffData data) { }

	// RVA: 0x2A00F10 Offset: 0x2A01011 VA: 0x2A00F10
	private int CountExceptForRaiseReliance() { }

	// RVA: 0x2A00F70 Offset: 0x2A01071 VA: 0x2A00F70
	public bool CanAddItem(FoodstuffData data) { }

	// RVA: 0x2A01060 Offset: 0x2A01161 VA: 0x2A01060
	public bool TryAddItem(FoodstuffData data) { }

	// RVA: 0x2A010F0 Offset: 0x2A011F1 VA: 0x2A010F0
	public bool TryRemoveItem(FoodstuffData data) { }

	// RVA: 0x2A01180 Offset: 0x2A01281 VA: 0x2A01180
	public bool TryRemoveLastNormalItem(out FoodstuffData removedData) { }

	// RVA: 0x2A012F0 Offset: 0x2A013F1 VA: 0x2A012F0
	public bool TryRemoveRareItem(out FoodstuffData removedData) { }

	// RVA: 0x2A013A0 Offset: 0x2A014A1 VA: 0x2A013A0
	private Dictionary<FoodstuffData, int> GetNormalFoodstuffAndCount() { }

	// RVA: 0x2A01530 Offset: 0x2A01631 VA: 0x2A01530
	private int GetNormalFoodstuffMostCount() { }

	// RVA: 0x2A015D0 Offset: 0x2A016D1 VA: 0x2A015D0
	private bool IsAccept(FoodstuffData data, out FoodstuffData acceptData) { }

	// RVA: 0x2A01770 Offset: 0x2A01871 VA: 0x2A01770
	public void .ctor() { }
}

