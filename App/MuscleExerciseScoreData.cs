// Namespace: App
public class MuscleExerciseScoreData : StructData<MuscleExerciseScoreData> // TypeDefIndex: 11287
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2975F0 Offset: 0x2976F1 VA: 0x2975F0
	private string <ID>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x297600 Offset: 0x297701 VA: 0x297600
	private int <ExerciseType>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x297610 Offset: 0x297711 VA: 0x297610
	private int <Level>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x297620 Offset: 0x297721 VA: 0x297620
	private int <GoodScore>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x297630 Offset: 0x297731 VA: 0x297630
	private int <PerfectScore>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x297640 Offset: 0x297741 VA: 0x297640
	private int <TargetScore>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x297650 Offset: 0x297751 VA: 0x297650
	private int <EndlessGoalCount>k__BackingField; // 0x3C

	// Properties
	public string ID { get; set; }
	public int ExerciseType { get; set; }
	public int Level { get; set; }
	public int GoodScore { get; set; }
	public int PerfectScore { get; set; }
	public int TargetScore { get; set; }
	public int EndlessGoalCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C4590 Offset: 0x2C4691 VA: 0x2C4590
	// RVA: 0x22837D0 Offset: 0x22838D1 VA: 0x22837D0
	public string get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C45A0 Offset: 0x2C46A1 VA: 0x2C45A0
	// RVA: 0x22837E0 Offset: 0x22838E1 VA: 0x22837E0
	private void set_ID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C45B0 Offset: 0x2C46B1 VA: 0x2C45B0
	// RVA: 0x22837F0 Offset: 0x22838F1 VA: 0x22837F0
	public int get_ExerciseType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C45C0 Offset: 0x2C46C1 VA: 0x2C45C0
	// RVA: 0x2283800 Offset: 0x2283901 VA: 0x2283800
	private void set_ExerciseType(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C45D0 Offset: 0x2C46D1 VA: 0x2C45D0
	// RVA: 0x2283810 Offset: 0x2283911 VA: 0x2283810
	public int get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C45E0 Offset: 0x2C46E1 VA: 0x2C45E0
	// RVA: 0x2283820 Offset: 0x2283921 VA: 0x2283820
	private void set_Level(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C45F0 Offset: 0x2C46F1 VA: 0x2C45F0
	// RVA: 0x2283830 Offset: 0x2283931 VA: 0x2283830
	public int get_GoodScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4600 Offset: 0x2C4701 VA: 0x2C4600
	// RVA: 0x2283840 Offset: 0x2283941 VA: 0x2283840
	private void set_GoodScore(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4610 Offset: 0x2C4711 VA: 0x2C4610
	// RVA: 0x2283850 Offset: 0x2283951 VA: 0x2283850
	public int get_PerfectScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4620 Offset: 0x2C4721 VA: 0x2C4620
	// RVA: 0x2283860 Offset: 0x2283961 VA: 0x2283860
	private void set_PerfectScore(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4630 Offset: 0x2C4731 VA: 0x2C4630
	// RVA: 0x2283870 Offset: 0x2283971 VA: 0x2283870
	public int get_TargetScore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4640 Offset: 0x2C4741 VA: 0x2C4640
	// RVA: 0x2283880 Offset: 0x2283981 VA: 0x2283880
	private void set_TargetScore(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4650 Offset: 0x2C4751 VA: 0x2C4650
	// RVA: 0x2283890 Offset: 0x2283991 VA: 0x2283890
	public int get_EndlessGoalCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4660 Offset: 0x2C4761 VA: 0x2C4660
	// RVA: 0x22838A0 Offset: 0x22839A1 VA: 0x22838A0
	private void set_EndlessGoalCount(int value) { }

	// RVA: 0x22838B0 Offset: 0x22839B1 VA: 0x22838B0
	public void .ctor() { }

	// RVA: 0x2283930 Offset: 0x2283A31 VA: 0x2283930
	public static void Load() { }

	// RVA: 0x22839E0 Offset: 0x2283AE1 VA: 0x22839E0 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x22839F0 Offset: 0x2283AF1 VA: 0x22839F0
	public static void GetScoreParam(int type, int level, ref int good, ref int perf, ref int target, ref int endlessGoal) { }
}

