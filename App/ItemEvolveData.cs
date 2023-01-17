// Namespace: App
public class ItemEvolveData : StructDataArray<ItemEvolveData> // TypeDefIndex: 9960
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28BC00 Offset: 0x28BD01 VA: 0x28BC00
	private string <Iid>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28BC10 Offset: 0x28BD11 VA: 0x28BC10
	private ushort <Iron>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28BC20 Offset: 0x28BD21 VA: 0x28BC20
	private ushort <Steel>k__BackingField; // 0x32
	[CompilerGeneratedAttribute] // RVA: 0x28BC30 Offset: 0x28BD31 VA: 0x28BC30
	private ushort <Silver>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x28BC40 Offset: 0x28BD41 VA: 0x28BC40
	private ushort <Price>k__BackingField; // 0x36
	[CompilerGeneratedAttribute] // RVA: 0x28BC50 Offset: 0x28BD51 VA: 0x28BC50
	private byte <RefineLevel>k__BackingField; // 0x38

	// Properties
	public string Iid { get; set; }
	public ushort Iron { get; set; }
	public ushort Steel { get; set; }
	public ushort Silver { get; set; }
	public ushort Price { get; set; }
	public byte RefineLevel { get; set; }

	// Methods

	// RVA: 0x2449930 Offset: 0x2449A31 VA: 0x2449930
	public static void Load() { }

	// RVA: 0x24499E0 Offset: 0x2449AE1 VA: 0x24499E0
	public static List<ItemEvolveData> TryGetFromIid(string iid) { }

	// RVA: 0x2449B50 Offset: 0x2449C51 VA: 0x2449B50
	public static List<ItemEvolveData> TryGetFromItem(ItemData item) { }

	// RVA: 0x2449AD0 Offset: 0x2449BD1 VA: 0x2449AD0
	public static string Iid2Eid(string iid) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9640 Offset: 0x2B9741 VA: 0x2B9640
	// RVA: 0x2449C60 Offset: 0x2449D61 VA: 0x2449C60
	public string get_Iid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9650 Offset: 0x2B9751 VA: 0x2B9650
	// RVA: 0x2449C70 Offset: 0x2449D71 VA: 0x2449C70
	private void set_Iid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9660 Offset: 0x2B9761 VA: 0x2B9660
	// RVA: 0x2449C80 Offset: 0x2449D81 VA: 0x2449C80
	public ushort get_Iron() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9670 Offset: 0x2B9771 VA: 0x2B9670
	// RVA: 0x2449C90 Offset: 0x2449D91 VA: 0x2449C90
	private void set_Iron(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9680 Offset: 0x2B9781 VA: 0x2B9680
	// RVA: 0x2449CA0 Offset: 0x2449DA1 VA: 0x2449CA0
	public ushort get_Steel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9690 Offset: 0x2B9791 VA: 0x2B9690
	// RVA: 0x2449CB0 Offset: 0x2449DB1 VA: 0x2449CB0
	private void set_Steel(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B96A0 Offset: 0x2B97A1 VA: 0x2B96A0
	// RVA: 0x2449CC0 Offset: 0x2449DC1 VA: 0x2449CC0
	public ushort get_Silver() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B96B0 Offset: 0x2B97B1 VA: 0x2B96B0
	// RVA: 0x2449CD0 Offset: 0x2449DD1 VA: 0x2449CD0
	private void set_Silver(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B96C0 Offset: 0x2B97C1 VA: 0x2B96C0
	// RVA: 0x2449CE0 Offset: 0x2449DE1 VA: 0x2449CE0
	public ushort get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B96D0 Offset: 0x2B97D1 VA: 0x2B96D0
	// RVA: 0x2449CF0 Offset: 0x2449DF1 VA: 0x2449CF0
	private void set_Price(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B96E0 Offset: 0x2B97E1 VA: 0x2B96E0
	// RVA: 0x2449D00 Offset: 0x2449E01 VA: 0x2449D00
	public byte get_RefineLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B96F0 Offset: 0x2B97F1 VA: 0x2B96F0
	// RVA: 0x2449D10 Offset: 0x2449E11 VA: 0x2449D10
	private void set_RefineLevel(byte value) { }

	// RVA: 0x2449D20 Offset: 0x2449E21 VA: 0x2449D20 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2449DB0 Offset: 0x2449EB1 VA: 0x2449DB0
	public string GetFlagName() { }

	// RVA: 0x2449EA0 Offset: 0x2449FA1 VA: 0x2449EA0
	public static void RegistGlobalFlags() { }

	// RVA: 0x244A080 Offset: 0x244A181 VA: 0x244A080
	public bool IsOnceEvolved() { }

	// RVA: 0x244A170 Offset: 0x244A271 VA: 0x244A170
	public void SetEvolved(bool evolved) { }

	// RVA: 0x244A480 Offset: 0x244A581 VA: 0x244A480
	public void .ctor() { }
}

