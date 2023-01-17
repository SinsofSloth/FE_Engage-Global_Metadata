// Namespace: 
public sealed class GodGrowthData.FlagField : BitFieldTemplate32<GodGrowthData.Flags> // TypeDefIndex: 9910
{
	// Methods

	// RVA: 0x1FA01C0 Offset: 0x1FA02C1 VA: 0x1FA01C0
	public void .ctor() { }

	// RVA: 0x1FA0220 Offset: 0x1FA0321 VA: 0x1FA0220
	public void .ctor(int f) { }

	// RVA: 0x1FA0280 Offset: 0x1FA0381 VA: 0x1FA0280
	public void .ctor(GodGrowthData.Flags f) { }

	// RVA: 0x1FA02E0 Offset: 0x1FA03E1 VA: 0x1FA02E0 Slot: 5
	protected override int ToInt(GodGrowthData.Flags value) { }
}

// Namespace: 
public class GodGrowthData.LevelData // TypeDefIndex: 9912
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28AC70 Offset: 0x28AD71 VA: 0x28AC70
	private SkillArray <SynchroSkills>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28AC80 Offset: 0x28AD81 VA: 0x28AC80
	private SkillArray <EngagedSkills>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28AC90 Offset: 0x28AD91 VA: 0x28AC90
	private SkillArray <EngageSkills>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28ACA0 Offset: 0x28ADA1 VA: 0x28ACA0
	private GodGrowthData.StyleItems <StyleEngageItems>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28ACB0 Offset: 0x28ADB1 VA: 0x28ACB0
	private WeaponMask <Aptitude>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28ACC0 Offset: 0x28ADC1 VA: 0x28ACC0
	private GodGrowthData.FlagField <Flags>k__BackingField; // 0x38

	// Properties
	public SkillArray SynchroSkills { get; set; }
	public SkillArray EngagedSkills { get; set; }
	public SkillArray EngageSkills { get; set; }
	public GodGrowthData.StyleItems StyleEngageItems { get; set; }
	public WeaponMask Aptitude { get; set; }
	public GodGrowthData.FlagField Flags { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2B7790 Offset: 0x2B7891 VA: 0x2B7790
	// RVA: 0x1FA02F0 Offset: 0x1FA03F1 VA: 0x1FA02F0
	public SkillArray get_SynchroSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B77A0 Offset: 0x2B78A1 VA: 0x2B77A0
	// RVA: 0x1FA0300 Offset: 0x1FA0401 VA: 0x1FA0300
	private void set_SynchroSkills(SkillArray value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B77B0 Offset: 0x2B78B1 VA: 0x2B77B0
	// RVA: 0x1FA0310 Offset: 0x1FA0411 VA: 0x1FA0310
	public SkillArray get_EngagedSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B77C0 Offset: 0x2B78C1 VA: 0x2B77C0
	// RVA: 0x1FA0320 Offset: 0x1FA0421 VA: 0x1FA0320
	private void set_EngagedSkills(SkillArray value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B77D0 Offset: 0x2B78D1 VA: 0x2B77D0
	// RVA: 0x1FA0330 Offset: 0x1FA0431 VA: 0x1FA0330
	public SkillArray get_EngageSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B77E0 Offset: 0x2B78E1 VA: 0x2B77E0
	// RVA: 0x1FA0340 Offset: 0x1FA0441 VA: 0x1FA0340
	private void set_EngageSkills(SkillArray value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B77F0 Offset: 0x2B78F1 VA: 0x2B77F0
	// RVA: 0x1FA0350 Offset: 0x1FA0451 VA: 0x1FA0350
	public GodGrowthData.StyleItems get_StyleEngageItems() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7800 Offset: 0x2B7901 VA: 0x2B7800
	// RVA: 0x1FA0360 Offset: 0x1FA0461 VA: 0x1FA0360
	private void set_StyleEngageItems(GodGrowthData.StyleItems value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7810 Offset: 0x2B7911 VA: 0x2B7810
	// RVA: 0x1FA0370 Offset: 0x1FA0471 VA: 0x1FA0370
	public WeaponMask get_Aptitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7820 Offset: 0x2B7921 VA: 0x2B7820
	// RVA: 0x1FA0380 Offset: 0x1FA0481 VA: 0x1FA0380
	private void set_Aptitude(WeaponMask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7830 Offset: 0x2B7931 VA: 0x2B7830
	// RVA: 0x1FA0390 Offset: 0x1FA0491 VA: 0x1FA0390
	public GodGrowthData.FlagField get_Flags() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7840 Offset: 0x2B7941 VA: 0x2B7840
	// RVA: 0x1FA03A0 Offset: 0x1FA04A1 VA: 0x1FA03A0
	private void set_Flags(GodGrowthData.FlagField value) { }

	// RVA: 0x1FA03B0 Offset: 0x1FA04B1 VA: 0x1FA03B0
	public void .ctor() { }

	// RVA: 0x1FA06E0 Offset: 0x1FA07E1 VA: 0x1FA06E0
	public void .ctor(GodGrowthData.LevelData src) { }

	// RVA: 0x1FA10E0 Offset: 0x1FA11E1 VA: 0x1FA10E0
	public void Add(GodGrowthData data) { }
}

