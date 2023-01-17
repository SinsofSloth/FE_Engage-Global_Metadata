// Namespace: App
public class GodGrowthData : StructDataArray<GodGrowthData> // TypeDefIndex: 9913
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28AAA0 Offset: 0x28ABA1 VA: 0x28AAA0
	private string <Ggid>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28AAB0 Offset: 0x28ABB1 VA: 0x28AAB0
	private byte <Level>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28AAC0 Offset: 0x28ABC1 VA: 0x28AAC0
	private string[] <InheritanceSkills>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28AAD0 Offset: 0x28ABD1 VA: 0x28AAD0
	private string[] <SynchroSkills>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28AAE0 Offset: 0x28ABE1 VA: 0x28AAE0
	private string[] <EngageSkills>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28AAF0 Offset: 0x28ABF1 VA: 0x28AAF0
	private string[] <EngageItems>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28AB00 Offset: 0x28AC01 VA: 0x28AB00
	private string[] <EngageCooperations>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x28AB10 Offset: 0x28AC11 VA: 0x28AB10
	private string[] <EngageHorses>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x28AB20 Offset: 0x28AC21 VA: 0x28AB20
	private string[] <EngageCoverts>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28AB30 Offset: 0x28AC31 VA: 0x28AB30
	private string[] <EngageHeavys>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28AB40 Offset: 0x28AC41 VA: 0x28AB40
	private string[] <EngageFlys>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x28AB50 Offset: 0x28AC51 VA: 0x28AB50
	private string[] <EngageMagics>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x28AB60 Offset: 0x28AC61 VA: 0x28AB60
	private string[] <EngagePranas>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x28AB70 Offset: 0x28AC71 VA: 0x28AB70
	private string[] <EngageDragons>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x28AB80 Offset: 0x28AC81 VA: 0x28AB80
	private WeaponMask <Aptitude>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x28AB90 Offset: 0x28AC91 VA: 0x28AB90
	private ushort <AptitudeCostNone>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x28ABA0 Offset: 0x28ACA1 VA: 0x28ABA0
	private ushort <AptitudeCostSword>k__BackingField; // 0xA2
	[CompilerGeneratedAttribute] // RVA: 0x28ABB0 Offset: 0x28ACB1 VA: 0x28ABB0
	private ushort <AptitudeCostLance>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x28ABC0 Offset: 0x28ACC1 VA: 0x28ABC0
	private ushort <AptitudeCostAxe>k__BackingField; // 0xA6
	[CompilerGeneratedAttribute] // RVA: 0x28ABD0 Offset: 0x28ACD1 VA: 0x28ABD0
	private ushort <AptitudeCostBow>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x28ABE0 Offset: 0x28ACE1 VA: 0x28ABE0
	private ushort <AptitudeCostDagger>k__BackingField; // 0xAA
	[CompilerGeneratedAttribute] // RVA: 0x28ABF0 Offset: 0x28ACF1 VA: 0x28ABF0
	private ushort <AptitudeCostMagic>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x28AC00 Offset: 0x28AD01 VA: 0x28AC00
	private ushort <AptitudeCostRod>k__BackingField; // 0xAE
	[CompilerGeneratedAttribute] // RVA: 0x28AC10 Offset: 0x28AD11 VA: 0x28AC10
	private ushort <AptitudeCostFist>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x28AC20 Offset: 0x28AD21 VA: 0x28AC20
	private ushort <AptitudeCostSpecial>k__BackingField; // 0xB2
	[CompilerGeneratedAttribute] // RVA: 0x28AC30 Offset: 0x28AD31 VA: 0x28AC30
	private ushort[] <AptitudeCosts>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x28AC40 Offset: 0x28AD41 VA: 0x28AC40
	private GodGrowthData.FlagField <Flag>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x28AC50 Offset: 0x28AD51 VA: 0x28AC50
	private SkillArray <SynchroSkillArray>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x28AC60 Offset: 0x28AD61 VA: 0x28AC60
	private SkillArray <EngageSkillArray>k__BackingField; // 0xD0
	private GodGrowthData.StyleItems m_StyleEngageItems; // 0xD8
	private static Dictionary<string, List<GodGrowthData.LevelData>> s_LevelLists; // 0x0

	// Properties
	public string Ggid { get; set; }
	public byte Level { get; set; }
	public string[] InheritanceSkills { get; set; }
	public string[] SynchroSkills { get; set; }
	public string[] EngageSkills { get; set; }
	public string[] EngageItems { get; set; }
	public string[] EngageCooperations { get; set; }
	public string[] EngageHorses { get; set; }
	public string[] EngageCoverts { get; set; }
	public string[] EngageHeavys { get; set; }
	public string[] EngageFlys { get; set; }
	public string[] EngageMagics { get; set; }
	public string[] EngagePranas { get; set; }
	public string[] EngageDragons { get; set; }
	public WeaponMask Aptitude { get; set; }
	public ushort AptitudeCostNone { get; set; }
	public ushort AptitudeCostSword { get; set; }
	public ushort AptitudeCostLance { get; set; }
	public ushort AptitudeCostAxe { get; set; }
	public ushort AptitudeCostBow { get; set; }
	public ushort AptitudeCostDagger { get; set; }
	public ushort AptitudeCostMagic { get; set; }
	public ushort AptitudeCostRod { get; set; }
	public ushort AptitudeCostFist { get; set; }
	public ushort AptitudeCostSpecial { get; set; }
	public ushort[] AptitudeCosts { get; set; }
	public GodGrowthData.FlagField Flag { get; set; }
	public SkillArray SynchroSkillArray { get; set; }
	public SkillArray EngageSkillArray { get; set; }

	// Methods

	// RVA: 0x27A4640 Offset: 0x27A4741 VA: 0x27A4640
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B73F0 Offset: 0x2B74F1 VA: 0x2B73F0
	// RVA: 0x27A46F0 Offset: 0x27A47F1 VA: 0x27A46F0
	public string get_Ggid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7400 Offset: 0x2B7501 VA: 0x2B7400
	// RVA: 0x27A4700 Offset: 0x27A4801 VA: 0x27A4700
	private void set_Ggid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7410 Offset: 0x2B7511 VA: 0x2B7410
	// RVA: 0x27A4710 Offset: 0x27A4811 VA: 0x27A4710
	public byte get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7420 Offset: 0x2B7521 VA: 0x2B7420
	// RVA: 0x27A4720 Offset: 0x27A4821 VA: 0x27A4720
	private void set_Level(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7430 Offset: 0x2B7531 VA: 0x2B7430
	// RVA: 0x27A4730 Offset: 0x27A4831 VA: 0x27A4730
	public string[] get_InheritanceSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7440 Offset: 0x2B7541 VA: 0x2B7440
	// RVA: 0x27A4740 Offset: 0x27A4841 VA: 0x27A4740
	private void set_InheritanceSkills(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7450 Offset: 0x2B7551 VA: 0x2B7450
	// RVA: 0x27A4750 Offset: 0x27A4851 VA: 0x27A4750
	public string[] get_SynchroSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7460 Offset: 0x2B7561 VA: 0x2B7460
	// RVA: 0x27A4760 Offset: 0x27A4861 VA: 0x27A4760
	private void set_SynchroSkills(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7470 Offset: 0x2B7571 VA: 0x2B7470
	// RVA: 0x27A4770 Offset: 0x27A4871 VA: 0x27A4770
	public string[] get_EngageSkills() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7480 Offset: 0x2B7581 VA: 0x2B7480
	// RVA: 0x27A4780 Offset: 0x27A4881 VA: 0x27A4780
	private void set_EngageSkills(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7490 Offset: 0x2B7591 VA: 0x2B7490
	// RVA: 0x27A4790 Offset: 0x27A4891 VA: 0x27A4790
	public string[] get_EngageItems() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B74A0 Offset: 0x2B75A1 VA: 0x2B74A0
	// RVA: 0x27A47A0 Offset: 0x27A48A1 VA: 0x27A47A0
	private void set_EngageItems(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B74B0 Offset: 0x2B75B1 VA: 0x2B74B0
	// RVA: 0x27A47B0 Offset: 0x27A48B1 VA: 0x27A47B0
	public string[] get_EngageCooperations() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B74C0 Offset: 0x2B75C1 VA: 0x2B74C0
	// RVA: 0x27A47C0 Offset: 0x27A48C1 VA: 0x27A47C0
	private void set_EngageCooperations(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B74D0 Offset: 0x2B75D1 VA: 0x2B74D0
	// RVA: 0x27A47D0 Offset: 0x27A48D1 VA: 0x27A47D0
	public string[] get_EngageHorses() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B74E0 Offset: 0x2B75E1 VA: 0x2B74E0
	// RVA: 0x27A47E0 Offset: 0x27A48E1 VA: 0x27A47E0
	private void set_EngageHorses(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B74F0 Offset: 0x2B75F1 VA: 0x2B74F0
	// RVA: 0x27A47F0 Offset: 0x27A48F1 VA: 0x27A47F0
	public string[] get_EngageCoverts() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7500 Offset: 0x2B7601 VA: 0x2B7500
	// RVA: 0x27A4800 Offset: 0x27A4901 VA: 0x27A4800
	private void set_EngageCoverts(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7510 Offset: 0x2B7611 VA: 0x2B7510
	// RVA: 0x27A4810 Offset: 0x27A4911 VA: 0x27A4810
	public string[] get_EngageHeavys() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7520 Offset: 0x2B7621 VA: 0x2B7520
	// RVA: 0x27A4820 Offset: 0x27A4921 VA: 0x27A4820
	private void set_EngageHeavys(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7530 Offset: 0x2B7631 VA: 0x2B7530
	// RVA: 0x27A4830 Offset: 0x27A4931 VA: 0x27A4830
	public string[] get_EngageFlys() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7540 Offset: 0x2B7641 VA: 0x2B7540
	// RVA: 0x27A4840 Offset: 0x27A4941 VA: 0x27A4840
	private void set_EngageFlys(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7550 Offset: 0x2B7651 VA: 0x2B7550
	// RVA: 0x27A4850 Offset: 0x27A4951 VA: 0x27A4850
	public string[] get_EngageMagics() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7560 Offset: 0x2B7661 VA: 0x2B7560
	// RVA: 0x27A4860 Offset: 0x27A4961 VA: 0x27A4860
	private void set_EngageMagics(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7570 Offset: 0x2B7671 VA: 0x2B7570
	// RVA: 0x27A4870 Offset: 0x27A4971 VA: 0x27A4870
	public string[] get_EngagePranas() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7580 Offset: 0x2B7681 VA: 0x2B7580
	// RVA: 0x27A4880 Offset: 0x27A4981 VA: 0x27A4880
	private void set_EngagePranas(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7590 Offset: 0x2B7691 VA: 0x2B7590
	// RVA: 0x27A4890 Offset: 0x27A4991 VA: 0x27A4890
	public string[] get_EngageDragons() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B75A0 Offset: 0x2B76A1 VA: 0x2B75A0
	// RVA: 0x27A48A0 Offset: 0x27A49A1 VA: 0x27A48A0
	private void set_EngageDragons(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B75B0 Offset: 0x2B76B1 VA: 0x2B75B0
	// RVA: 0x27A48B0 Offset: 0x27A49B1 VA: 0x27A48B0
	public WeaponMask get_Aptitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B75C0 Offset: 0x2B76C1 VA: 0x2B75C0
	// RVA: 0x27A48C0 Offset: 0x27A49C1 VA: 0x27A48C0
	private void set_Aptitude(WeaponMask value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B75D0 Offset: 0x2B76D1 VA: 0x2B75D0
	// RVA: 0x27A48D0 Offset: 0x27A49D1 VA: 0x27A48D0
	public ushort get_AptitudeCostNone() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B75E0 Offset: 0x2B76E1 VA: 0x2B75E0
	// RVA: 0x27A48E0 Offset: 0x27A49E1 VA: 0x27A48E0
	private void set_AptitudeCostNone(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B75F0 Offset: 0x2B76F1 VA: 0x2B75F0
	// RVA: 0x27A48F0 Offset: 0x27A49F1 VA: 0x27A48F0
	public ushort get_AptitudeCostSword() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7600 Offset: 0x2B7701 VA: 0x2B7600
	// RVA: 0x27A4900 Offset: 0x27A4A01 VA: 0x27A4900
	private void set_AptitudeCostSword(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7610 Offset: 0x2B7711 VA: 0x2B7610
	// RVA: 0x27A4910 Offset: 0x27A4A11 VA: 0x27A4910
	public ushort get_AptitudeCostLance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7620 Offset: 0x2B7721 VA: 0x2B7620
	// RVA: 0x27A4920 Offset: 0x27A4A21 VA: 0x27A4920
	private void set_AptitudeCostLance(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7630 Offset: 0x2B7731 VA: 0x2B7630
	// RVA: 0x27A4930 Offset: 0x27A4A31 VA: 0x27A4930
	public ushort get_AptitudeCostAxe() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7640 Offset: 0x2B7741 VA: 0x2B7640
	// RVA: 0x27A4940 Offset: 0x27A4A41 VA: 0x27A4940
	private void set_AptitudeCostAxe(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7650 Offset: 0x2B7751 VA: 0x2B7650
	// RVA: 0x27A4950 Offset: 0x27A4A51 VA: 0x27A4950
	public ushort get_AptitudeCostBow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7660 Offset: 0x2B7761 VA: 0x2B7660
	// RVA: 0x27A4960 Offset: 0x27A4A61 VA: 0x27A4960
	private void set_AptitudeCostBow(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7670 Offset: 0x2B7771 VA: 0x2B7670
	// RVA: 0x27A4970 Offset: 0x27A4A71 VA: 0x27A4970
	public ushort get_AptitudeCostDagger() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7680 Offset: 0x2B7781 VA: 0x2B7680
	// RVA: 0x27A4980 Offset: 0x27A4A81 VA: 0x27A4980
	private void set_AptitudeCostDagger(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7690 Offset: 0x2B7791 VA: 0x2B7690
	// RVA: 0x27A4990 Offset: 0x27A4A91 VA: 0x27A4990
	public ushort get_AptitudeCostMagic() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B76A0 Offset: 0x2B77A1 VA: 0x2B76A0
	// RVA: 0x27A49A0 Offset: 0x27A4AA1 VA: 0x27A49A0
	private void set_AptitudeCostMagic(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B76B0 Offset: 0x2B77B1 VA: 0x2B76B0
	// RVA: 0x27A49B0 Offset: 0x27A4AB1 VA: 0x27A49B0
	public ushort get_AptitudeCostRod() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B76C0 Offset: 0x2B77C1 VA: 0x2B76C0
	// RVA: 0x27A49C0 Offset: 0x27A4AC1 VA: 0x27A49C0
	private void set_AptitudeCostRod(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B76D0 Offset: 0x2B77D1 VA: 0x2B76D0
	// RVA: 0x27A49D0 Offset: 0x27A4AD1 VA: 0x27A49D0
	public ushort get_AptitudeCostFist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B76E0 Offset: 0x2B77E1 VA: 0x2B76E0
	// RVA: 0x27A49E0 Offset: 0x27A4AE1 VA: 0x27A49E0
	private void set_AptitudeCostFist(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B76F0 Offset: 0x2B77F1 VA: 0x2B76F0
	// RVA: 0x27A49F0 Offset: 0x27A4AF1 VA: 0x27A49F0
	public ushort get_AptitudeCostSpecial() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7700 Offset: 0x2B7801 VA: 0x2B7700
	// RVA: 0x27A4A00 Offset: 0x27A4B01 VA: 0x27A4A00
	private void set_AptitudeCostSpecial(ushort value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7710 Offset: 0x2B7811 VA: 0x2B7710
	// RVA: 0x27A4A10 Offset: 0x27A4B11 VA: 0x27A4A10
	public ushort[] get_AptitudeCosts() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7720 Offset: 0x2B7821 VA: 0x2B7720
	// RVA: 0x27A4A20 Offset: 0x27A4B21 VA: 0x27A4A20
	private void set_AptitudeCosts(ushort[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7730 Offset: 0x2B7831 VA: 0x2B7730
	// RVA: 0x27A4A30 Offset: 0x27A4B31 VA: 0x27A4A30
	public GodGrowthData.FlagField get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7740 Offset: 0x2B7841 VA: 0x2B7740
	// RVA: 0x27A4A40 Offset: 0x27A4B41 VA: 0x27A4A40
	private void set_Flag(GodGrowthData.FlagField value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7750 Offset: 0x2B7851 VA: 0x2B7750
	// RVA: 0x27A4A50 Offset: 0x27A4B51 VA: 0x27A4A50
	public SkillArray get_SynchroSkillArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7760 Offset: 0x2B7861 VA: 0x2B7760
	// RVA: 0x27A4A60 Offset: 0x27A4B61 VA: 0x27A4A60
	private void set_SynchroSkillArray(SkillArray value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7770 Offset: 0x2B7871 VA: 0x2B7770
	// RVA: 0x27A4A70 Offset: 0x27A4B71 VA: 0x27A4A70
	public SkillArray get_EngageSkillArray() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B7780 Offset: 0x2B7881 VA: 0x2B7780
	// RVA: 0x27A4A80 Offset: 0x27A4B81 VA: 0x27A4A80
	private void set_EngageSkillArray(SkillArray value) { }

	// RVA: 0x27A4A90 Offset: 0x27A4B91 VA: 0x27A4A90
	private void AddEnageItems(BattleStyle.Types style, string[] items) { }

	// RVA: 0x27A4C80 Offset: 0x27A4D81 VA: 0x27A4C80 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x27A5E00 Offset: 0x27A5F01 VA: 0x27A5E00 Slot: 6
	public override void OnCompletedEnd() { }

	// RVA: 0x27A62C0 Offset: 0x27A63C1 VA: 0x27A62C0
	public static bool TryGetLevelData(string name, int level, out GodGrowthData.LevelData data) { }

	// RVA: 0x27A63F0 Offset: 0x27A64F1 VA: 0x27A63F0
	public List<ItemData> GetStyleEngageItems(BattleStyle.Types style) { }

	// RVA: 0x27A6430 Offset: 0x27A6531 VA: 0x27A6430
	public int GetStyleEngageItemsTotalCount() { }

	// RVA: 0x27A6440 Offset: 0x27A6541 VA: 0x27A6440
	public static List<GodGrowthData> TryGetFromGodData(GodData god) { }

	// RVA: 0x27A64D0 Offset: 0x27A65D1 VA: 0x27A64D0
	public static List<GodGrowthData> TryGetFromGgid(string ggid) { }

	// RVA: 0x27A6570 Offset: 0x27A6671 VA: 0x27A6570
	public static void EachInheritanceSkill(GodData god, Action<int, string> func) { }

	// RVA: 0x27A65F0 Offset: 0x27A66F1 VA: 0x27A65F0
	public static void EachInheritanceSkill(string ggid, Action<int, string> func) { }

	// RVA: 0x27A67E0 Offset: 0x27A68E1 VA: 0x27A67E0
	public static void EachInheritance(GodData god, Action<int, string> skillFunc, Action<int, ItemData.Kinds, int> aptitudeFunc) { }

	// RVA: 0x27A6870 Offset: 0x27A6971 VA: 0x27A6870
	public static void EachInheritance(string ggid, Action<int, string> skillFunc, Action<int, ItemData.Kinds, int> aptitudeFunc) { }

	// RVA: 0x27A6C50 Offset: 0x27A6D51 VA: 0x27A6C50 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x27A6CC0 Offset: 0x27A6DC1 VA: 0x27A6CC0
	public void .ctor() { }

	// RVA: 0x27A6E10 Offset: 0x27A6F11 VA: 0x27A6E10
	private static void .cctor() { }
}

