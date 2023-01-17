// Namespace: App
public class ItemRefineData : StructDataArray<ItemRefineData> // TypeDefIndex: 9961
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28BC60 Offset: 0x28BD61 VA: 0x28BC60
	private ushort <Iron>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28BC70 Offset: 0x28BD71 VA: 0x28BC70
	private ushort <Steel>k__BackingField; // 0x2A
	[CompilerGeneratedAttribute] // RVA: 0x28BC80 Offset: 0x28BD81 VA: 0x28BC80
	private ushort <Silver>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x28BC90 Offset: 0x28BD91 VA: 0x28BC90
	private ushort <Price>k__BackingField; // 0x2E
	[CompilerGeneratedAttribute] // RVA: 0x28BCA0 Offset: 0x28BDA1 VA: 0x28BCA0
	private sbyte <Power>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28BCB0 Offset: 0x28BDB1 VA: 0x28BCB0
	private sbyte <Weight>k__BackingField; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x28BCC0 Offset: 0x28BDC1 VA: 0x28BCC0
	private sbyte <Hit>k__BackingField; // 0x32
	[CompilerGeneratedAttribute] // RVA: 0x28BCD0 Offset: 0x28BDD1 VA: 0x28BCD0
	private sbyte <Critical>k__BackingField; // 0x33

	// Properties
	public ushort Iron { get; set; }
	public ushort Steel { get; set; }
	public ushort Silver { get; set; }
	public ushort Price { get; set; }
	public sbyte Power { get; set; }
	public sbyte Weight { get; set; }
	public sbyte Hit { get; set; }
	public sbyte Critical { get; set; }

	// Methods

	// RVA: 0x2455360 Offset: 0x2455461 VA: 0x2455360
	public static void Load() { }

	// RVA: 0x2455410 Offset: 0x2455511 VA: 0x2455410
	public static List<ItemRefineData> TryGetFromIid(string iid) { }

	// RVA: 0x2455580 Offset: 0x2455681 VA: 0x2455580
	public static List<ItemRefineData> TryGetFromItem(ItemData item) { }

	// RVA: 0x2455500 Offset: 0x2455601 VA: 0x2455500
	public static string Iid2Rid(string iid) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9700 Offset: 0x2B9801 VA: 0x2B9700
	// RVA: 0x2455690 Offset: 0x2455791 VA: 0x2455690
	public ushort get_Iron() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9710 Offset: 0x2B9811 VA: 0x2B9710
	// RVA: 0x24556A0 Offset: 0x24557A1 VA: 0x24556A0
	private void set_Iron(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9720 Offset: 0x2B9821 VA: 0x2B9720
	// RVA: 0x24556B0 Offset: 0x24557B1 VA: 0x24556B0
	public ushort get_Steel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9730 Offset: 0x2B9831 VA: 0x2B9730
	// RVA: 0x24556C0 Offset: 0x24557C1 VA: 0x24556C0
	private void set_Steel(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9740 Offset: 0x2B9841 VA: 0x2B9740
	// RVA: 0x24556D0 Offset: 0x24557D1 VA: 0x24556D0
	public ushort get_Silver() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9750 Offset: 0x2B9851 VA: 0x2B9750
	// RVA: 0x24556E0 Offset: 0x24557E1 VA: 0x24556E0
	private void set_Silver(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9760 Offset: 0x2B9861 VA: 0x2B9760
	// RVA: 0x24556F0 Offset: 0x24557F1 VA: 0x24556F0
	public ushort get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9770 Offset: 0x2B9871 VA: 0x2B9770
	// RVA: 0x2455700 Offset: 0x2455801 VA: 0x2455700
	private void set_Price(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9780 Offset: 0x2B9881 VA: 0x2B9780
	// RVA: 0x2455710 Offset: 0x2455811 VA: 0x2455710
	public sbyte get_Power() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B9790 Offset: 0x2B9891 VA: 0x2B9790
	// RVA: 0x2455720 Offset: 0x2455821 VA: 0x2455720
	private void set_Power(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B97A0 Offset: 0x2B98A1 VA: 0x2B97A0
	// RVA: 0x2455730 Offset: 0x2455831 VA: 0x2455730
	public sbyte get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B97B0 Offset: 0x2B98B1 VA: 0x2B97B0
	// RVA: 0x2455740 Offset: 0x2455841 VA: 0x2455740
	private void set_Weight(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B97C0 Offset: 0x2B98C1 VA: 0x2B97C0
	// RVA: 0x2455750 Offset: 0x2455851 VA: 0x2455750
	public sbyte get_Hit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B97D0 Offset: 0x2B98D1 VA: 0x2B97D0
	// RVA: 0x2455760 Offset: 0x2455861 VA: 0x2455760
	private void set_Hit(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B97E0 Offset: 0x2B98E1 VA: 0x2B97E0
	// RVA: 0x2455770 Offset: 0x2455871 VA: 0x2455770
	public sbyte get_Critical() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B97F0 Offset: 0x2B98F1 VA: 0x2B97F0
	// RVA: 0x2455780 Offset: 0x2455881 VA: 0x2455780
	private void set_Critical(sbyte value) { }

	// RVA: 0x2455790 Offset: 0x2455891 VA: 0x2455790 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2455820 Offset: 0x2455921 VA: 0x2455820
	public void .ctor() { }
}

