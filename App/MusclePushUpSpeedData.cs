// Namespace: App
public class MusclePushUpSpeedData : StructData<MusclePushUpSpeedData> // TypeDefIndex: 11291
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2976F0 Offset: 0x2977F1 VA: 0x2976F0
	private string <ID>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x297700 Offset: 0x297801 VA: 0x297700
	private int <Level>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x297710 Offset: 0x297811 VA: 0x297710
	private float <SpeedMin>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x297720 Offset: 0x297821 VA: 0x297720
	private float <SpeedMax>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x297730 Offset: 0x297831 VA: 0x297730
	private int <LevelUpCount>k__BackingField; // 0x34

	// Properties
	public string ID { get; set; }
	public int Level { get; set; }
	public float SpeedMin { get; set; }
	public float SpeedMax { get; set; }
	public int LevelUpCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C4790 Offset: 0x2C4891 VA: 0x2C4790
	// RVA: 0x2287940 Offset: 0x2287A41 VA: 0x2287940
	public string get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C47A0 Offset: 0x2C48A1 VA: 0x2C47A0
	// RVA: 0x2287950 Offset: 0x2287A51 VA: 0x2287950
	private void set_ID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C47B0 Offset: 0x2C48B1 VA: 0x2C47B0
	// RVA: 0x2287960 Offset: 0x2287A61 VA: 0x2287960
	public int get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C47C0 Offset: 0x2C48C1 VA: 0x2C47C0
	// RVA: 0x2287970 Offset: 0x2287A71 VA: 0x2287970
	private void set_Level(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C47D0 Offset: 0x2C48D1 VA: 0x2C47D0
	// RVA: 0x2287980 Offset: 0x2287A81 VA: 0x2287980
	public float get_SpeedMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C47E0 Offset: 0x2C48E1 VA: 0x2C47E0
	// RVA: 0x2287990 Offset: 0x2287A91 VA: 0x2287990
	private void set_SpeedMin(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C47F0 Offset: 0x2C48F1 VA: 0x2C47F0
	// RVA: 0x22879A0 Offset: 0x2287AA1 VA: 0x22879A0
	public float get_SpeedMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4800 Offset: 0x2C4901 VA: 0x2C4800
	// RVA: 0x22879B0 Offset: 0x2287AB1 VA: 0x22879B0
	private void set_SpeedMax(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4810 Offset: 0x2C4911 VA: 0x2C4810
	// RVA: 0x22879C0 Offset: 0x2287AC1 VA: 0x22879C0
	public int get_LevelUpCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4820 Offset: 0x2C4921 VA: 0x2C4820
	// RVA: 0x22879D0 Offset: 0x2287AD1 VA: 0x22879D0
	private void set_LevelUpCount(int value) { }

	// RVA: 0x22879E0 Offset: 0x2287AE1 VA: 0x22879E0
	public void .ctor() { }

	// RVA: 0x2287A60 Offset: 0x2287B61 VA: 0x2287A60
	public static void Load() { }

	// RVA: 0x2287B10 Offset: 0x2287C11 VA: 0x2287B10 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x2287B20 Offset: 0x2287C21 VA: 0x2287B20
	public static void GetSpeedList(int level, ref List<MusclePushUpSpeedData> setList) { }
}

