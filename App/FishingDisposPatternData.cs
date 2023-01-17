// Namespace: App
public class FishingDisposPatternData : StructData<FishingDisposPatternData> // TypeDefIndex: 10583
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x292A70 Offset: 0x292B71 VA: 0x292A70
	private string <ID>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x292A80 Offset: 0x292B81 VA: 0x292A80
	private string <StickType>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x292A90 Offset: 0x292B91 VA: 0x292A90
	private int <Time>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x292AA0 Offset: 0x292BA1 VA: 0x292AA0
	private int <PositionNum>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x292AB0 Offset: 0x292BB1 VA: 0x292AB0
	private int <LotteryParam>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x292AC0 Offset: 0x292BC1 VA: 0x292AC0
	private string <FishID>k__BackingField; // 0x40

	// Properties
	public string ID { get; set; }
	public string StickType { get; set; }
	public int Time { get; set; }
	public int PositionNum { get; set; }
	public int LotteryParam { get; set; }
	public string FishID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF530 Offset: 0x2BF631 VA: 0x2BF530
	// RVA: 0x2EF4710 Offset: 0x2EF4811 VA: 0x2EF4710
	public string get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF540 Offset: 0x2BF641 VA: 0x2BF540
	// RVA: 0x2EF4720 Offset: 0x2EF4821 VA: 0x2EF4720
	private void set_ID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF550 Offset: 0x2BF651 VA: 0x2BF550
	// RVA: 0x2EF4730 Offset: 0x2EF4831 VA: 0x2EF4730
	public string get_StickType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF560 Offset: 0x2BF661 VA: 0x2BF560
	// RVA: 0x2EF4740 Offset: 0x2EF4841 VA: 0x2EF4740
	private void set_StickType(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF570 Offset: 0x2BF671 VA: 0x2BF570
	// RVA: 0x2EF4750 Offset: 0x2EF4851 VA: 0x2EF4750
	public int get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF580 Offset: 0x2BF681 VA: 0x2BF580
	// RVA: 0x2EF4760 Offset: 0x2EF4861 VA: 0x2EF4760
	private void set_Time(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF590 Offset: 0x2BF691 VA: 0x2BF590
	// RVA: 0x2EF4770 Offset: 0x2EF4871 VA: 0x2EF4770
	public int get_PositionNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF5A0 Offset: 0x2BF6A1 VA: 0x2BF5A0
	// RVA: 0x2EF4780 Offset: 0x2EF4881 VA: 0x2EF4780
	private void set_PositionNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF5B0 Offset: 0x2BF6B1 VA: 0x2BF5B0
	// RVA: 0x2EF4790 Offset: 0x2EF4891 VA: 0x2EF4790
	public int get_LotteryParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF5C0 Offset: 0x2BF6C1 VA: 0x2BF5C0
	// RVA: 0x2EF47A0 Offset: 0x2EF48A1 VA: 0x2EF47A0
	private void set_LotteryParam(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF5D0 Offset: 0x2BF6D1 VA: 0x2BF5D0
	// RVA: 0x2EF47B0 Offset: 0x2EF48B1 VA: 0x2EF47B0
	public string get_FishID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF5E0 Offset: 0x2BF6E1 VA: 0x2BF5E0
	// RVA: 0x2EF47C0 Offset: 0x2EF48C1 VA: 0x2EF47C0
	private void set_FishID(string value) { }

	// RVA: 0x2EF47D0 Offset: 0x2EF48D1 VA: 0x2EF47D0
	public void .ctor() { }

	// RVA: 0x2EF4850 Offset: 0x2EF4951 VA: 0x2EF4850
	public static void Load() { }

	// RVA: 0x2EF4900 Offset: 0x2EF4A01 VA: 0x2EF4900 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x2EF4910 Offset: 0x2EF4A11 VA: 0x2EF4910
	public static void GetForecastList(StickType type, int time, ref List<ForecastFishData> outList) { }

	// RVA: 0x2EF4EA0 Offset: 0x2EF4FA1 VA: 0x2EF4EA0
	public static void GetForecastListBestSix(StickType type, int time, ref List<ForecastFishData> outList) { }

	// RVA: 0x2EF5460 Offset: 0x2EF5561 VA: 0x2EF5460
	public static void GetForecastListByPosition(StickType type, int time, int posNum, ref List<ForecastFishData> outList) { }

	// RVA: 0x2EF5760 Offset: 0x2EF5861 VA: 0x2EF5760
	public static void GetRipplesList(StickType type, int time, int posNum, ref List<int> outList) { }
}

