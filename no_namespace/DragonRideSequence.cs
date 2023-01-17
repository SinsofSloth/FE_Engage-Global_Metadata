// Namespace: 
public enum DragonRideSequence.Label // TypeDefIndex: 10531
{
	// Fields
	public int value__; // 0x0
	public const DragonRideSequence.Label None = 0;
	public const DragonRideSequence.Label Init = 1;
	public const DragonRideSequence.Label CheckTest = 2;
	public const DragonRideSequence.Label ReadyMenu = 3;
	public const DragonRideSequence.Label PlaySelect = 4;
	public const DragonRideSequence.Label CheckNewDifficult = 5;
	public const DragonRideSequence.Label AnnounceNewDifficult = 6;
	public const DragonRideSequence.Label DifficultSelect = 7;
	public const DragonRideSequence.Label ReadyGame = 8;
	public const DragonRideSequence.Label ExecuteGame = 9;
	public const DragonRideSequence.Label PrizeTalk = 10;
	public const DragonRideSequence.Label PrizeBond = 11;
	public const DragonRideSequence.Label PrizeItem = 12;
	public const DragonRideSequence.Label Exit = 13;
}

// Namespace: 
public class DragonRideSequence.PrizeData // TypeDefIndex: 10532
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28F470 Offset: 0x28F571 VA: 0x28F470
	private string <ID>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28F480 Offset: 0x28F581 VA: 0x28F480
	private ItemData <item>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28F490 Offset: 0x28F591 VA: 0x28F490
	private int <num>k__BackingField; // 0x20

	// Properties
	public string ID { get; set; }
	public ItemData item { get; set; }
	public int num { get; set; }

	// Methods

	// RVA: 0x1F013E0 Offset: 0x1F014E1 VA: 0x1F013E0
	public void .ctor() { }

	// RVA: 0x1F013F0 Offset: 0x1F014F1 VA: 0x1F013F0
	public void .ctor(ItemData setItem, int setNum) { }

	// RVA: 0x1F01450 Offset: 0x1F01551 VA: 0x1F01450
	public void AddNum(int add) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF040 Offset: 0x2BF141 VA: 0x2BF040
	// RVA: 0x1F01460 Offset: 0x1F01561 VA: 0x1F01460
	public string get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF050 Offset: 0x2BF151 VA: 0x2BF050
	// RVA: 0x1F01470 Offset: 0x1F01571 VA: 0x1F01470
	private void set_ID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF060 Offset: 0x2BF161 VA: 0x2BF060
	// RVA: 0x1F01480 Offset: 0x1F01581 VA: 0x1F01480
	public ItemData get_item() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF070 Offset: 0x2BF171 VA: 0x2BF070
	// RVA: 0x1F01490 Offset: 0x1F01591 VA: 0x1F01490
	private void set_item(ItemData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF080 Offset: 0x2BF181 VA: 0x2BF080
	// RVA: 0x1F014A0 Offset: 0x1F015A1 VA: 0x1F014A0
	public int get_num() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF090 Offset: 0x2BF191 VA: 0x2BF090
	// RVA: 0x1F014B0 Offset: 0x1F015B1 VA: 0x1F014B0
	private void set_num(int value) { }
}

