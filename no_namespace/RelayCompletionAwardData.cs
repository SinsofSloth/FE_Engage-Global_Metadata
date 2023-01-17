// Namespace: 
[FlagsAttribute] // RVA: 0x276450 Offset: 0x276551 VA: 0x276450
public enum RelayCompletionAwardData.Flags // TypeDefIndex: 10026
{
	// Fields
	public int value__; // 0x0
	public const RelayCompletionAwardData.Flags Show = 1;
}

// Namespace: 
public sealed class RelayCompletionAwardData.FlagField : BitFieldTemplate32<RelayCompletionAwardData.Flags> // TypeDefIndex: 10027
{
	// Methods

	// RVA: 0x1F3DEF0 Offset: 0x1F3DFF1 VA: 0x1F3DEF0
	public void .ctor(int f) { }

	// RVA: 0x1F3DF50 Offset: 0x1F3E051 VA: 0x1F3DF50
	public void .ctor(RelayCompletionAwardData.Flags f) { }

	// RVA: 0x1F3DFB0 Offset: 0x1F3E0B1 VA: 0x1F3DFB0 Slot: 5
	protected override int ToInt(RelayCompletionAwardData.Flags value) { }
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
public class RelayCompletionAwardData.CalcResult // TypeDefIndex: 10029
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28CB40 Offset: 0x28CC41 VA: 0x28CB40
	private List<RelayCompletionAwardData.CalcResult.Item> <MainItems>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28CB50 Offset: 0x28CC51 VA: 0x28CB50
	private List<RelayCompletionAwardData.CalcResult.Item> <SubItems>k__BackingField; // 0x18

	// Properties
	public List<RelayCompletionAwardData.CalcResult.Item> MainItems { get; set; }
	public List<RelayCompletionAwardData.CalcResult.Item> SubItems { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BB530 Offset: 0x2BB631 VA: 0x2BB530
	// RVA: 0x1F3DDE0 Offset: 0x1F3DEE1 VA: 0x1F3DDE0
	public List<RelayCompletionAwardData.CalcResult.Item> get_MainItems() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB540 Offset: 0x2BB641 VA: 0x2BB540
	// RVA: 0x1F3DDF0 Offset: 0x1F3DEF1 VA: 0x1F3DDF0
	private void set_MainItems(List<RelayCompletionAwardData.CalcResult.Item> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB550 Offset: 0x2BB651 VA: 0x2BB550
	// RVA: 0x1F3DE00 Offset: 0x1F3DF01 VA: 0x1F3DE00
	public List<RelayCompletionAwardData.CalcResult.Item> get_SubItems() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB560 Offset: 0x2BB661 VA: 0x2BB560
	// RVA: 0x1F3DE10 Offset: 0x1F3DF11 VA: 0x1F3DE10
	private void set_SubItems(List<RelayCompletionAwardData.CalcResult.Item> value) { }

	// RVA: 0x1F3DE20 Offset: 0x1F3DF21 VA: 0x1F3DE20
	public void .ctor(int mainMaxCount, int subMaxCount) { }
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
private abstract class RelayCompletionAwardData.ComparerBase // TypeDefIndex: 10031
{
	// Methods

	// RVA: 0x1F3DDB0 Offset: 0x1F3DEB1 VA: 0x1F3DDB0
	protected int CompareItemData(ItemData a, ItemData b) { }

	// RVA: 0x1F3DDD0 Offset: 0x1F3DED1 VA: 0x1F3DDD0
	protected void .ctor() { }
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
private class RelayCompletionAwardData.CalcComparer : RelayCompletionAwardData.ComparerBase, IComparer<RelayCompletionAwardData.CalcResult.Item> // TypeDefIndex: 10033
{
	// Methods

	// RVA: 0x1F3DD90 Offset: 0x1F3DE91 VA: 0x1F3DD90 Slot: 4
	public int Compare(RelayCompletionAwardData.CalcResult.Item a, RelayCompletionAwardData.CalcResult.Item b) { }

	// RVA: 0x1F3DDC0 Offset: 0x1F3DEC1 VA: 0x1F3DDC0
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276470 Offset: 0x276571 VA: 0x276470
[Serializable]
private sealed class RelayCompletionAwardData.<>c // TypeDefIndex: 10035
{
	// Fields
	public static readonly RelayCompletionAwardData.<>c <>9; // 0x0
	public static Comparison<RelayCompletionAwardData> <>9__38_0; // 0x8

	// Methods

	// RVA: 0x1F3DC50 Offset: 0x1F3DD51 VA: 0x1F3DC50
	private static void .cctor() { }

	// RVA: 0x1F3DCC0 Offset: 0x1F3DDC1 VA: 0x1F3DCC0
	public void .ctor() { }

	// RVA: 0x1F3DCD0 Offset: 0x1F3DDD1 VA: 0x1F3DCD0
	internal int <Replenish>b__38_0(RelayCompletionAwardData a, RelayCompletionAwardData b) { }
}

