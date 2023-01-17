// Namespace: App
public class FishingTargetListData : StructData<FishingTargetListData> // TypeDefIndex: 10622
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x292F10 Offset: 0x293011 VA: 0x292F10
	private string <ID>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x292F20 Offset: 0x293021 VA: 0x292F20
	private string <FishID>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x292F30 Offset: 0x293031 VA: 0x292F30
	private int <Priority>k__BackingField; // 0x30

	// Properties
	public string ID { get; set; }
	public string FishID { get; set; }
	public int Priority { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BFEA0 Offset: 0x2BFFA1 VA: 0x2BFEA0
	// RVA: 0x29F6B80 Offset: 0x29F6C81 VA: 0x29F6B80
	public string get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFEB0 Offset: 0x2BFFB1 VA: 0x2BFEB0
	// RVA: 0x29F6B90 Offset: 0x29F6C91 VA: 0x29F6B90
	private void set_ID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFEC0 Offset: 0x2BFFC1 VA: 0x2BFEC0
	// RVA: 0x29F6BA0 Offset: 0x29F6CA1 VA: 0x29F6BA0
	public string get_FishID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFED0 Offset: 0x2BFFD1 VA: 0x2BFED0
	// RVA: 0x29F6BB0 Offset: 0x29F6CB1 VA: 0x29F6BB0
	private void set_FishID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFEE0 Offset: 0x2BFFE1 VA: 0x2BFEE0
	// RVA: 0x29F6BC0 Offset: 0x29F6CC1 VA: 0x29F6BC0
	public int get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFEF0 Offset: 0x2BFFF1 VA: 0x2BFEF0
	// RVA: 0x29F6BD0 Offset: 0x29F6CD1 VA: 0x29F6BD0
	private void set_Priority(int value) { }

	// RVA: 0x29F6BE0 Offset: 0x29F6CE1 VA: 0x29F6BE0
	public void .ctor() { }

	// RVA: 0x29F6C60 Offset: 0x29F6D61 VA: 0x29F6C60
	public static void Load() { }

	// RVA: 0x29F6D10 Offset: 0x29F6E11 VA: 0x29F6D10 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x29F6D20 Offset: 0x29F6E21 VA: 0x29F6D20
	public static void GetTargetList(bool EnableStickA, bool EnableStickB, bool EnableStickC, ref List<string> outFishList, ref List<int> outPriorityList) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFF00 Offset: 0x2C0001 VA: 0x2BFF00
	// RVA: 0x29F73B0 Offset: 0x29F74B1 VA: 0x29F73B0
	internal static void <GetTargetList>g__AddFishList|15_0(string id, int pri, int stickNum, ref FishingTargetListData.<>c__DisplayClass15_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFF10 Offset: 0x2C0011 VA: 0x2BFF10
	// RVA: 0x29F7240 Offset: 0x29F7341 VA: 0x29F7240
	internal static bool <GetTargetList>g__IsForecastFish|15_1(string fishID, ref FishingTargetListData.<>c__DisplayClass15_0 ) { }
}

