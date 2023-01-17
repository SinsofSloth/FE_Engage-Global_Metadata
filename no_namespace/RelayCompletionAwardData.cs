// Namespace: 
[FlagsAttribute] // RVA: 0x276450 Offset: 0x276551 VA: 0x276450
public enum RelayCompletionAwardData.Flags // TypeDefIndex: 10026
{
	// Fields
	public int value__; // 0x0
	public const RelayCompletionAwardData.Flags Show = 1;
}

// Namespace: 
public class RelayCompletionAwardData.CalcResult.Item // TypeDefIndex: 10028
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28CB60 Offset: 0x28CC61 VA: 0x28CB60
	private ItemData <Data>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28CB70 Offset: 0x28CC71 VA: 0x28CB70
	private int <Count>k__BackingField; // 0x18

	// Properties
	public ItemData Data { get; set; }
	public int Count { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BB570 Offset: 0x2BB671 VA: 0x2BB570
	// RVA: 0x21F4A70 Offset: 0x21F4B71 VA: 0x21F4A70
	public ItemData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB580 Offset: 0x2BB681 VA: 0x2BB580
	// RVA: 0x21F4A80 Offset: 0x21F4B81 VA: 0x21F4A80
	private void set_Data(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB590 Offset: 0x2BB691 VA: 0x2BB590
	// RVA: 0x21F4A90 Offset: 0x21F4B91 VA: 0x21F4A90
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB5A0 Offset: 0x2BB6A1 VA: 0x2BB5A0
	// RVA: 0x21F4AA0 Offset: 0x21F4BA1 VA: 0x21F4AA0
	private void set_Count(int value) { }

	// RVA: 0x21F4AB0 Offset: 0x21F4BB1 VA: 0x21F4AB0
	public void .ctor(ItemData data) { }

	// RVA: 0x21F4AF0 Offset: 0x21F4BF1 VA: 0x21F4AF0
	public void Add() { }
}

// Namespace: 
private struct RelayCompletionAwardData.CalcWork // TypeDefIndex: 10030
{
	// Fields
	public List<RelayCompletionAwardData.CalcResult.Item> results; // 0x0
	public List<RelayCompletionAwardData> awards; // 0x8
	public int maxCount; // 0x10
	public int minCount; // 0x14
	public int count; // 0x18
	public bool isCopied; // 0x1C
	public Random random; // 0x20
}

// Namespace: 
private class RelayCompletionAwardData.ShowComparer : RelayCompletionAwardData.ComparerBase, IComparer<ItemData> // TypeDefIndex: 10032
{
	// Methods

	// RVA: 0x1F3DFC0 Offset: 0x1F3E0C1 VA: 0x1F3DFC0 Slot: 4
	public int Compare(ItemData a, ItemData b) { }

	// RVA: 0x1F3DFD0 Offset: 0x1F3E0D1 VA: 0x1F3DFD0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276460 Offset: 0x276561 VA: 0x276460
private sealed class RelayCompletionAwardData.<>c__DisplayClass37_0 // TypeDefIndex: 10034
{
	// Fields
	public ItemData data; // 0x10

	// Methods

	// RVA: 0x1F3DD60 Offset: 0x1F3DE61 VA: 0x1F3DD60
	public void .ctor() { }

	// RVA: 0x1F3DD70 Offset: 0x1F3DE71 VA: 0x1F3DD70
	internal bool <AddItem>b__0(RelayCompletionAwardData.CalcResult.Item item) { }
}

