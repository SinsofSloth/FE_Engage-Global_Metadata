// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x275F60 Offset: 0x276061 VA: 0x275F60
public class ChallengeData : StructData<ChallengeData> // TypeDefIndex: 9834
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2890C0 Offset: 0x2891C1 VA: 0x2890C0
	private string <Cid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2890D0 Offset: 0x2891D1 VA: 0x2890D0
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2890E0 Offset: 0x2891E1 VA: 0x2890E0
	private string[] <Stage1>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2890F0 Offset: 0x2891F1 VA: 0x2890F0
	private string[] <Stage2>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x289100 Offset: 0x289201 VA: 0x289100
	private string[] <Stage3>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x289110 Offset: 0x289211 VA: 0x289110
	private string <Reward>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x289120 Offset: 0x289221 VA: 0x289120
	private string <UnlockCid>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x289130 Offset: 0x289231 VA: 0x289130
	private int <SortieCount>k__BackingField; // 0x58
	private string FlagNameTurn; // 0x60
	private string FlagNameLevel; // 0x68
	public const int MaxStage = 3;

	// Properties
	public string Cid { get; set; }
	public string Name { get; set; }
	public string[] Stage1 { get; set; }
	public string[] Stage2 { get; set; }
	public string[] Stage3 { get; set; }
	public string Reward { get; set; }
	public string UnlockCid { get; set; }
	public int SortieCount { get; set; }
	public int BestTurn { get; set; }
	public int BestLevel { get; set; }

	// Methods

	// RVA: 0x29AD0E0 Offset: 0x29AD1E1 VA: 0x29AD0E0
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B3FD0 Offset: 0x2B40D1 VA: 0x2B3FD0
	// RVA: 0x29AD190 Offset: 0x29AD291 VA: 0x29AD190
	public string get_Cid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B3FE0 Offset: 0x2B40E1 VA: 0x2B3FE0
	// RVA: 0x29AD1A0 Offset: 0x29AD2A1 VA: 0x29AD1A0
	private void set_Cid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B3FF0 Offset: 0x2B40F1 VA: 0x2B3FF0
	// RVA: 0x29AD1B0 Offset: 0x29AD2B1 VA: 0x29AD1B0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4000 Offset: 0x2B4101 VA: 0x2B4000
	// RVA: 0x29AD1C0 Offset: 0x29AD2C1 VA: 0x29AD1C0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4010 Offset: 0x2B4111 VA: 0x2B4010
	// RVA: 0x29AD1D0 Offset: 0x29AD2D1 VA: 0x29AD1D0
	public string[] get_Stage1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4020 Offset: 0x2B4121 VA: 0x2B4020
	// RVA: 0x29AD1E0 Offset: 0x29AD2E1 VA: 0x29AD1E0
	private void set_Stage1(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4030 Offset: 0x2B4131 VA: 0x2B4030
	// RVA: 0x29AD1F0 Offset: 0x29AD2F1 VA: 0x29AD1F0
	public string[] get_Stage2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4040 Offset: 0x2B4141 VA: 0x2B4040
	// RVA: 0x29AD200 Offset: 0x29AD301 VA: 0x29AD200
	private void set_Stage2(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4050 Offset: 0x2B4151 VA: 0x2B4050
	// RVA: 0x29AD210 Offset: 0x29AD311 VA: 0x29AD210
	public string[] get_Stage3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4060 Offset: 0x2B4161 VA: 0x2B4060
	// RVA: 0x29AD220 Offset: 0x29AD321 VA: 0x29AD220
	private void set_Stage3(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4070 Offset: 0x2B4171 VA: 0x2B4070
	// RVA: 0x29AD230 Offset: 0x29AD331 VA: 0x29AD230
	public string get_Reward() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4080 Offset: 0x2B4181 VA: 0x2B4080
	// RVA: 0x29AD240 Offset: 0x29AD341 VA: 0x29AD240
	private void set_Reward(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B4090 Offset: 0x2B4191 VA: 0x2B4090
	// RVA: 0x29AD250 Offset: 0x29AD351 VA: 0x29AD250
	public string get_UnlockCid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B40A0 Offset: 0x2B41A1 VA: 0x2B40A0
	// RVA: 0x29AD260 Offset: 0x29AD361 VA: 0x29AD260
	private void set_UnlockCid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B40B0 Offset: 0x2B41B1 VA: 0x2B40B0
	// RVA: 0x29AD270 Offset: 0x29AD371 VA: 0x29AD270
	public int get_SortieCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B40C0 Offset: 0x2B41C1 VA: 0x2B40C0
	// RVA: 0x29AD280 Offset: 0x29AD381 VA: 0x29AD280
	private void set_SortieCount(int value) { }

	// RVA: 0x29AD290 Offset: 0x29AD391 VA: 0x29AD290
	public string GetName() { }

	// RVA: 0x29AD300 Offset: 0x29AD401 VA: 0x29AD300 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x29AD310 Offset: 0x29AD411 VA: 0x29AD310 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x29AD3F0 Offset: 0x29AD4F1 VA: 0x29AD3F0 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x29AD400 Offset: 0x29AD501 VA: 0x29AD400 Slot: 7
	public override void OnRelease() { }

	// RVA: 0x29AD410 Offset: 0x29AD511 VA: 0x29AD410
	public StructDataArrayList<RewardData> GetRewardList() { }

	// RVA: 0x29AD4A0 Offset: 0x29AD5A1 VA: 0x29AD4A0
	private static bool TrySetStage(List<ChapterData> list, Random random, string[] stages) { }

	// RVA: 0x29AD600 Offset: 0x29AD701 VA: 0x29AD600
	public List<ChapterData> GetStageList(Random random) { }

	// RVA: 0x29AD6C0 Offset: 0x29AD7C1 VA: 0x29AD6C0
	public bool CanSelect() { }

	// RVA: 0x29AD830 Offset: 0x29AD931 VA: 0x29AD830
	public static void RegistGlobalFlags() { }

	// RVA: 0x29ADA00 Offset: 0x29ADB01 VA: 0x29ADA00
	public int get_BestTurn() { }

	// RVA: 0x29ADAE0 Offset: 0x29ADBE1 VA: 0x29ADAE0
	public void set_BestTurn(int value) { }

	// RVA: 0x29ADCB0 Offset: 0x29ADDB1 VA: 0x29ADCB0
	public int get_BestLevel() { }

	// RVA: 0x29ADD90 Offset: 0x29ADE91 VA: 0x29ADD90
	public void set_BestLevel(int value) { }

	// RVA: 0x29ADF60 Offset: 0x29AE061 VA: 0x29ADF60
	public bool IsNew() { }

	// RVA: 0x29AE070 Offset: 0x29AE171 VA: 0x29AE070
	public void SawNewAccess() { }

	// RVA: 0x29AE140 Offset: 0x29AE241 VA: 0x29AE140
	public void .ctor() { }
}

