// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x2764A0 Offset: 0x2765A1 VA: 0x2764A0
public class RewardData : StructDataArray<RewardData> // TypeDefIndex: 10048
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28CD60 Offset: 0x28CE61 VA: 0x28CD60
	private string <Iid>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28CD70 Offset: 0x28CE71 VA: 0x28CD70
	private float <Ratio>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28CD80 Offset: 0x28CE81 VA: 0x28CD80
	private float <Factor>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x28CD90 Offset: 0x28CE91 VA: 0x28CD90
	private float <Min>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28CDA0 Offset: 0x28CEA1 VA: 0x28CDA0
	private float <Max>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x28CDB0 Offset: 0x28CEB1 VA: 0x28CDB0
	private bool <IsShow>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28CDC0 Offset: 0x28CEC1 VA: 0x28CDC0
	private string <Condition>k__BackingField; // 0x48

	// Properties
	public string Iid { get; set; }
	public float Ratio { get; set; }
	public float Factor { get; set; }
	public float Min { get; set; }
	public float Max { get; set; }
	public bool IsShow { get; set; }
	public string Condition { get; set; }

	// Methods

	// RVA: 0x24D2500 Offset: 0x24D2601 VA: 0x24D2500
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB970 Offset: 0x2BBA71 VA: 0x2BB970
	// RVA: 0x24D25B0 Offset: 0x24D26B1 VA: 0x24D25B0
	public string get_Iid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB980 Offset: 0x2BBA81 VA: 0x2BB980
	// RVA: 0x24D25C0 Offset: 0x24D26C1 VA: 0x24D25C0
	private void set_Iid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB990 Offset: 0x2BBA91 VA: 0x2BB990
	// RVA: 0x24D25D0 Offset: 0x24D26D1 VA: 0x24D25D0
	public float get_Ratio() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB9A0 Offset: 0x2BBAA1 VA: 0x2BB9A0
	// RVA: 0x24D25E0 Offset: 0x24D26E1 VA: 0x24D25E0
	private void set_Ratio(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB9B0 Offset: 0x2BBAB1 VA: 0x2BB9B0
	// RVA: 0x24D25F0 Offset: 0x24D26F1 VA: 0x24D25F0
	public float get_Factor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB9C0 Offset: 0x2BBAC1 VA: 0x2BB9C0
	// RVA: 0x24D2600 Offset: 0x24D2701 VA: 0x24D2600
	private void set_Factor(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB9D0 Offset: 0x2BBAD1 VA: 0x2BB9D0
	// RVA: 0x24D2610 Offset: 0x24D2711 VA: 0x24D2610
	public float get_Min() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB9E0 Offset: 0x2BBAE1 VA: 0x2BB9E0
	// RVA: 0x24D2620 Offset: 0x24D2721 VA: 0x24D2620
	private void set_Min(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB9F0 Offset: 0x2BBAF1 VA: 0x2BB9F0
	// RVA: 0x24D2630 Offset: 0x24D2731 VA: 0x24D2630
	public float get_Max() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA00 Offset: 0x2BBB01 VA: 0x2BBA00
	// RVA: 0x24D2640 Offset: 0x24D2741 VA: 0x24D2640
	private void set_Max(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA10 Offset: 0x2BBB11 VA: 0x2BBA10
	// RVA: 0x24D2650 Offset: 0x24D2751 VA: 0x24D2650
	public bool get_IsShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA20 Offset: 0x2BBB21 VA: 0x2BBA20
	// RVA: 0x24D2660 Offset: 0x24D2761 VA: 0x24D2660
	private void set_IsShow(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA30 Offset: 0x2BBB31 VA: 0x2BBA30
	// RVA: 0x24D2670 Offset: 0x24D2771 VA: 0x24D2670
	public string get_Condition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BBA40 Offset: 0x2BBB41 VA: 0x2BBA40
	// RVA: 0x24D2680 Offset: 0x24D2781 VA: 0x24D2680
	private void set_Condition(string value) { }

	// RVA: 0x24D2690 Offset: 0x24D2791 VA: 0x24D2690
	public ItemData GetItem() { }

	// RVA: 0x24D2720 Offset: 0x24D2821 VA: 0x24D2720 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x24D2730 Offset: 0x24D2831 VA: 0x24D2730
	public static bool IsCondition(string condition) { }

	// RVA: 0x24D2850 Offset: 0x24D2951 VA: 0x24D2850
	public float GetPercent(int level) { }

	// RVA: 0x24D28B0 Offset: 0x24D29B1 VA: 0x24D28B0
	public static int GetExpFormChallenge(int sortieCount, int difficultyDiff) { }

	// RVA: 0x24D2920 Offset: 0x24D2A21 VA: 0x24D2920
	private static List<RewardData> CalcRewardsImpl(StructDataArrayList<RewardData> array, Random random, int level, bool isDump) { }

	// RVA: 0x24D2D90 Offset: 0x24D2E91 VA: 0x24D2D90
	public static List<ItemData> CalcRewards(string name, Random random, int level, bool isDump = False) { }

	// RVA: 0x24D3010 Offset: 0x24D3111 VA: 0x24D3010
	public static List<ItemData> CalcRewards(string name) { }

	// RVA: 0x24D3270 Offset: 0x24D3371 VA: 0x24D3270
	public static List<ItemData> CalcGameClearRewards(Difficulty difficulty) { }

	// RVA: 0x24D3300 Offset: 0x24D3401 VA: 0x24D3300
	public void .ctor() { }
}

