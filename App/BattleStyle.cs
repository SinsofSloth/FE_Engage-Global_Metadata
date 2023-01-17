// Namespace: App
public class BattleStyle : StructData<BattleStyle> // TypeDefIndex: 9812
{
	// Fields
	public static BattleStyle.Types Begin; // 0x0
	public static BattleStyle.Types End; // 0x4
	public static int Count; // 0x8
	private static readonly string[] Names; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2885A0 Offset: 0x2886A1 VA: 0x2885A0
	private string <Style>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2885B0 Offset: 0x2886B1 VA: 0x2885B0
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2885C0 Offset: 0x2886C1 VA: 0x2885C0
	private string <Help>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2885D0 Offset: 0x2886D1 VA: 0x2885D0
	private string[] <Skills>k__BackingField; // 0x38

	// Properties
	public string Style { get; set; }
	public string Name { get; set; }
	public string Help { get; set; }
	public string[] Skills { get; set; }

	// Methods

	// RVA: 0x2260BF0 Offset: 0x2260CF1 VA: 0x2260BF0
	public static void Load() { }

	// RVA: 0x2260CA0 Offset: 0x2260DA1 VA: 0x2260CA0
	public static BattleStyle.Types GetStyle(string name) { }

	// RVA: 0x2260DA0 Offset: 0x2260EA1 VA: 0x2260DA0
	public static string GetName(BattleStyle.Types style) { }

	// RVA: 0x2260E30 Offset: 0x2260F31 VA: 0x2260E30
	public static string[] GetSkills(BattleStyle.Types style) { }

	// RVA: 0x2260ED0 Offset: 0x2260FD1 VA: 0x2260ED0
	public static string GetStyleName(BattleStyle.Types style) { }

	// RVA: 0x2260FC0 Offset: 0x22610C1 VA: 0x2260FC0
	public static string GetHelp(BattleStyle.Types style) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2990 Offset: 0x2B2A91 VA: 0x2B2990
	// RVA: 0x2261060 Offset: 0x2261161 VA: 0x2261060
	public string get_Style() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B29A0 Offset: 0x2B2AA1 VA: 0x2B29A0
	// RVA: 0x2261070 Offset: 0x2261171 VA: 0x2261070
	private void set_Style(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B29B0 Offset: 0x2B2AB1 VA: 0x2B29B0
	// RVA: 0x2261080 Offset: 0x2261181 VA: 0x2261080
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B29C0 Offset: 0x2B2AC1 VA: 0x2B29C0
	// RVA: 0x2261090 Offset: 0x2261191 VA: 0x2261090
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B29D0 Offset: 0x2B2AD1 VA: 0x2B29D0
	// RVA: 0x22610A0 Offset: 0x22611A1 VA: 0x22610A0
	public string get_Help() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B29E0 Offset: 0x2B2AE1 VA: 0x2B29E0
	// RVA: 0x22610B0 Offset: 0x22611B1 VA: 0x22610B0
	private void set_Help(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B29F0 Offset: 0x2B2AF1 VA: 0x2B29F0
	// RVA: 0x22610C0 Offset: 0x22611C1 VA: 0x22610C0
	public string[] get_Skills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B2A00 Offset: 0x2B2B01 VA: 0x2B2A00
	// RVA: 0x22610D0 Offset: 0x22611D1 VA: 0x22610D0
	private void set_Skills(string[] value) { }

	// RVA: 0x22610E0 Offset: 0x22611E1 VA: 0x22610E0 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x22610F0 Offset: 0x22611F1 VA: 0x22610F0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2261100 Offset: 0x2261201 VA: 0x2261100
	public void .ctor() { }

	// RVA: 0x2261180 Offset: 0x2261281 VA: 0x2261180
	private static void .cctor() { }
}

