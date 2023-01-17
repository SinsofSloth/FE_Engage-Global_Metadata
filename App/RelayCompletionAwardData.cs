// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276410 Offset: 0x276511 VA: 0x276410
public class RelayCompletionAwardData : StructDataArray<RelayCompletionAwardData> // TypeDefIndex: 10036
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28CAE0 Offset: 0x28CBE1 VA: 0x28CAE0
	private string <Iid>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28CAF0 Offset: 0x28CBF1 VA: 0x28CAF0
	private float <Rate>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28CB00 Offset: 0x28CC01 VA: 0x28CB00
	private int <MinCount>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x28CB10 Offset: 0x28CC11 VA: 0x28CB10
	private int <MaxCount>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28CB20 Offset: 0x28CC21 VA: 0x28CB20
	private RelayCompletionAwardData.FlagField <Flag>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28CB30 Offset: 0x28CC31 VA: 0x28CB30
	private string <Condition>k__BackingField; // 0x48
	private static RelayCompletionAwardData.ShowComparer s_ShowComparer; // 0x0
	private static RelayCompletionAwardData.CalcComparer s_CalcComparer; // 0x8

	// Properties
	public string Iid { get; set; }
	public float Rate { get; set; }
	public int MinCount { get; set; }
	public int MaxCount { get; set; }
	public RelayCompletionAwardData.FlagField Flag { get; set; }
	public string Condition { get; set; }

	// Methods

	// RVA: 0x253FB00 Offset: 0x253FC01 VA: 0x253FB00
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB470 Offset: 0x2BB571 VA: 0x2BB470
	// RVA: 0x253FBB0 Offset: 0x253FCB1 VA: 0x253FBB0
	public string get_Iid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB480 Offset: 0x2BB581 VA: 0x2BB480
	// RVA: 0x253FBC0 Offset: 0x253FCC1 VA: 0x253FBC0
	private void set_Iid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB490 Offset: 0x2BB591 VA: 0x2BB490
	// RVA: 0x253FBD0 Offset: 0x253FCD1 VA: 0x253FBD0
	public float get_Rate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB4A0 Offset: 0x2BB5A1 VA: 0x2BB4A0
	// RVA: 0x253FBE0 Offset: 0x253FCE1 VA: 0x253FBE0
	private void set_Rate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB4B0 Offset: 0x2BB5B1 VA: 0x2BB4B0
	// RVA: 0x253FBF0 Offset: 0x253FCF1 VA: 0x253FBF0
	public int get_MinCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB4C0 Offset: 0x2BB5C1 VA: 0x2BB4C0
	// RVA: 0x253FC00 Offset: 0x253FD01 VA: 0x253FC00
	private void set_MinCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB4D0 Offset: 0x2BB5D1 VA: 0x2BB4D0
	// RVA: 0x253FC10 Offset: 0x253FD11 VA: 0x253FC10
	public int get_MaxCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB4E0 Offset: 0x2BB5E1 VA: 0x2BB4E0
	// RVA: 0x253FC20 Offset: 0x253FD21 VA: 0x253FC20
	private void set_MaxCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB4F0 Offset: 0x2BB5F1 VA: 0x2BB4F0
	// RVA: 0x253FC30 Offset: 0x253FD31 VA: 0x253FC30
	public RelayCompletionAwardData.FlagField get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB500 Offset: 0x2BB601 VA: 0x2BB500
	// RVA: 0x253FC40 Offset: 0x253FD41 VA: 0x253FC40
	private void set_Flag(RelayCompletionAwardData.FlagField value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB510 Offset: 0x2BB611 VA: 0x2BB510
	// RVA: 0x253FC50 Offset: 0x253FD51 VA: 0x253FC50
	public string get_Condition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BB520 Offset: 0x2BB621 VA: 0x2BB520
	// RVA: 0x253FC60 Offset: 0x253FD61 VA: 0x253FC60
	private void set_Condition(string value) { }

	// RVA: 0x253FC70 Offset: 0x253FD71 VA: 0x253FC70 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x253FC80 Offset: 0x253FD81 VA: 0x253FC80
	private float GetRate() { }

	// RVA: 0x253FDE0 Offset: 0x253FEE1 VA: 0x253FDE0
	public static List<ItemData> GetForShow(string name, List<ItemData> results) { }

	// RVA: 0x2540070 Offset: 0x2540171 VA: 0x2540070
	public static RelayCompletionAwardData.CalcResult Calc(string mainName, string subName, Random random) { }

	// RVA: 0x25404F0 Offset: 0x25405F1 VA: 0x25404F0
	private static void CalcMain(ref RelayCompletionAwardData.CalcWork work) { }

	// RVA: 0x2540570 Offset: 0x2540671 VA: 0x2540570
	private static void CalcSub(ref RelayCompletionAwardData.CalcWork work) { }

	// RVA: 0x2540680 Offset: 0x2540781 VA: 0x2540680
	private static void CalcCommon(ref RelayCompletionAwardData.CalcWork work, int tryCount) { }

	// RVA: 0x2540790 Offset: 0x2540891 VA: 0x2540790
	private static void CalcCommonOne(ref RelayCompletionAwardData.CalcWork work, bool isFirstTry) { }

	// RVA: 0x2540CB0 Offset: 0x2540DB1 VA: 0x2540CB0
	private static void AddItem(ref RelayCompletionAwardData.CalcWork work, ItemData data) { }

	// RVA: 0x25409F0 Offset: 0x2540AF1 VA: 0x25409F0
	private static void Replenish(ref RelayCompletionAwardData.CalcWork work) { }

	// RVA: 0x2540E60 Offset: 0x2540F61 VA: 0x2540E60
	public void .ctor() { }

	// RVA: 0x2540EE0 Offset: 0x2540FE1 VA: 0x2540EE0
	private static void .cctor() { }
}

