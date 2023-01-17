// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273D40 Offset: 0x273E41 VA: 0x273D40
public sealed class CharacterBuilder : CharacterAssetForm // TypeDefIndex: 8592
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x282380 Offset: 0x282481 VA: 0x282380
	private GameObject <Body>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x282390 Offset: 0x282491 VA: 0x282390
	private GameObject <Dress>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x2823A0 Offset: 0x2824A1 VA: 0x2823A0
	private GameObject <Head>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x2823B0 Offset: 0x2824B1 VA: 0x2823B0
	private GameObject <Hair>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x2823C0 Offset: 0x2824C1 VA: 0x2823C0
	private GameObject <Left>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x2823D0 Offset: 0x2824D1 VA: 0x2823D0
	private GameObject <Right>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x2823E0 Offset: 0x2824E1 VA: 0x2823E0
	private GameObject <Ride>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x2823F0 Offset: 0x2824F1 VA: 0x2823F0
	private GameObject <Ridress>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x282400 Offset: 0x282501 VA: 0x282400
	private AnimatorOverrideController <BodyAOC>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x282410 Offset: 0x282511 VA: 0x282410
	private AnimatorOverrideController <RideAOC>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x282420 Offset: 0x282521 VA: 0x282420
	private LaunchBehaviour <Magic>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x282430 Offset: 0x282531 VA: 0x282430
	private PrivateEffectCatalog <PrivateEffectCatalog>k__BackingField; // 0x90
	private DressUtility dressUt; // 0x98
	private List<Renderer> m_CachedRenderers; // 0xA0
	private List<Renderer> m_CachedShadowRenderers; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x282440 Offset: 0x282541 VA: 0x282440
	private ItemData.Kinds <WeaponKind>k__BackingField; // 0xB0
	private string weaponName; // 0xB8
	private bool m_bVisible; // 0xC0

	// Properties
	public GameObject Body { get; set; }
	public GameObject Dress { get; set; }
	public GameObject Head { get; set; }
	public GameObject Hair { get; set; }
	public GameObject Left { get; set; }
	public GameObject Right { get; set; }
	public GameObject Ride { get; set; }
	public GameObject Ridress { get; set; }
	public AnimatorOverrideController BodyAOC { get; set; }
	public AnimatorOverrideController RideAOC { get; set; }
	public LaunchBehaviour Magic { get; set; }
	public PrivateEffectCatalog PrivateEffectCatalog { get; set; }
	public GameObject MainWeapon { get; }
	public Transform MainHand { get; }
	public ItemData.Kinds WeaponKind { get; set; }
	public string WeaponName { get; set; }
	public bool IsBrawl { get; }
	public bool IsFlying { get; }
	public bool IsVisible { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AA670 Offset: 0x2AA771 VA: 0x2AA670
	// RVA: 0x2B6B1F0 Offset: 0x2B6B2F1 VA: 0x2B6B1F0
	public GameObject get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA680 Offset: 0x2AA781 VA: 0x2AA680
	// RVA: 0x2B6B200 Offset: 0x2B6B301 VA: 0x2B6B200
	private void set_Body(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA690 Offset: 0x2AA791 VA: 0x2AA690
	// RVA: 0x2B6B210 Offset: 0x2B6B311 VA: 0x2B6B210
	public GameObject get_Dress() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA6A0 Offset: 0x2AA7A1 VA: 0x2AA6A0
	// RVA: 0x2B6B220 Offset: 0x2B6B321 VA: 0x2B6B220
	private void set_Dress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA6B0 Offset: 0x2AA7B1 VA: 0x2AA6B0
	// RVA: 0x2B6B230 Offset: 0x2B6B331 VA: 0x2B6B230
	public GameObject get_Head() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA6C0 Offset: 0x2AA7C1 VA: 0x2AA6C0
	// RVA: 0x2B6B240 Offset: 0x2B6B341 VA: 0x2B6B240
	private void set_Head(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA6D0 Offset: 0x2AA7D1 VA: 0x2AA6D0
	// RVA: 0x2B6B250 Offset: 0x2B6B351 VA: 0x2B6B250
	public GameObject get_Hair() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA6E0 Offset: 0x2AA7E1 VA: 0x2AA6E0
	// RVA: 0x2B6B260 Offset: 0x2B6B361 VA: 0x2B6B260
	private void set_Hair(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA6F0 Offset: 0x2AA7F1 VA: 0x2AA6F0
	// RVA: 0x2B6B270 Offset: 0x2B6B371 VA: 0x2B6B270
	public GameObject get_Left() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA700 Offset: 0x2AA801 VA: 0x2AA700
	// RVA: 0x2B6B280 Offset: 0x2B6B381 VA: 0x2B6B280
	private void set_Left(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA710 Offset: 0x2AA811 VA: 0x2AA710
	// RVA: 0x2B6B290 Offset: 0x2B6B391 VA: 0x2B6B290
	public GameObject get_Right() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA720 Offset: 0x2AA821 VA: 0x2AA720
	// RVA: 0x2B6B2A0 Offset: 0x2B6B3A1 VA: 0x2B6B2A0
	private void set_Right(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA730 Offset: 0x2AA831 VA: 0x2AA730
	// RVA: 0x2B6B2B0 Offset: 0x2B6B3B1 VA: 0x2B6B2B0
	public GameObject get_Ride() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA740 Offset: 0x2AA841 VA: 0x2AA740
	// RVA: 0x2B6B2C0 Offset: 0x2B6B3C1 VA: 0x2B6B2C0
	private void set_Ride(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA750 Offset: 0x2AA851 VA: 0x2AA750
	// RVA: 0x2B6B2D0 Offset: 0x2B6B3D1 VA: 0x2B6B2D0
	public GameObject get_Ridress() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA760 Offset: 0x2AA861 VA: 0x2AA760
	// RVA: 0x2B6B2E0 Offset: 0x2B6B3E1 VA: 0x2B6B2E0
	private void set_Ridress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA770 Offset: 0x2AA871 VA: 0x2AA770
	// RVA: 0x2B6B2F0 Offset: 0x2B6B3F1 VA: 0x2B6B2F0
	public AnimatorOverrideController get_BodyAOC() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA780 Offset: 0x2AA881 VA: 0x2AA780
	// RVA: 0x2B6B300 Offset: 0x2B6B401 VA: 0x2B6B300
	private void set_BodyAOC(AnimatorOverrideController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA790 Offset: 0x2AA891 VA: 0x2AA790
	// RVA: 0x2B6B310 Offset: 0x2B6B411 VA: 0x2B6B310
	public AnimatorOverrideController get_RideAOC() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA7A0 Offset: 0x2AA8A1 VA: 0x2AA7A0
	// RVA: 0x2B6B320 Offset: 0x2B6B421 VA: 0x2B6B320
	private void set_RideAOC(AnimatorOverrideController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA7B0 Offset: 0x2AA8B1 VA: 0x2AA7B0
	// RVA: 0x2B6B330 Offset: 0x2B6B431 VA: 0x2B6B330
	public LaunchBehaviour get_Magic() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA7C0 Offset: 0x2AA8C1 VA: 0x2AA7C0
	// RVA: 0x2B6B340 Offset: 0x2B6B441 VA: 0x2B6B340
	private void set_Magic(LaunchBehaviour value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA7D0 Offset: 0x2AA8D1 VA: 0x2AA7D0
	// RVA: 0x2B6B350 Offset: 0x2B6B451 VA: 0x2B6B350
	public PrivateEffectCatalog get_PrivateEffectCatalog() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA7E0 Offset: 0x2AA8E1 VA: 0x2AA7E0
	// RVA: 0x2B6B360 Offset: 0x2B6B461 VA: 0x2B6B360
	private void set_PrivateEffectCatalog(PrivateEffectCatalog value) { }

	// RVA: 0x2B6B370 Offset: 0x2B6B471 VA: 0x2B6B370
	private void OnDestroy() { }

	// RVA: 0x2B6B380 Offset: 0x2B6B481 VA: 0x2B6B380
	public GameObject get_MainWeapon() { }

	// RVA: 0x2B6B410 Offset: 0x2B6B511 VA: 0x2B6B410
	public Transform get_MainHand() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA7F0 Offset: 0x2AA8F1 VA: 0x2AA7F0
	// RVA: 0x2B6B4C0 Offset: 0x2B6B5C1 VA: 0x2B6B4C0
	public ItemData.Kinds get_WeaponKind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA800 Offset: 0x2AA901 VA: 0x2AA800
	// RVA: 0x2B6B4D0 Offset: 0x2B6B5D1 VA: 0x2B6B4D0
	private void set_WeaponKind(ItemData.Kinds value) { }

	// RVA: 0x2B6B4E0 Offset: 0x2B6B5E1 VA: 0x2B6B4E0
	public string get_WeaponName() { }

	// RVA: 0x2B6B600 Offset: 0x2B6B701 VA: 0x2B6B600
	public void set_WeaponName(string value) { }

	// RVA: 0x2B6B820 Offset: 0x2B6B921 VA: 0x2B6B820
	public bool get_IsBrawl() { }

	// RVA: 0x2B6B830 Offset: 0x2B6B931 VA: 0x2B6B830
	public bool get_IsFlying() { }

	// RVA: 0x2B6B840 Offset: 0x2B6B941 VA: 0x2B6B840
	public float GetTall() { }

	// RVA: 0x2B6B850 Offset: 0x2B6B951 VA: 0x2B6B850
	public bool get_IsVisible() { }

	// RVA: 0x2B6A2A0 Offset: 0x2B6A3A1 VA: 0x2B6A2A0
	public void set_IsVisible(bool value) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AA810 Offset: 0x2AA911 VA: 0x2AA810
	// RVA: 0x2B6BD10 Offset: 0x2B6BE11 VA: 0x2B6BD10 Slot: 5
	protected override IEnumerator CoBuildHierarchy() { }

	// RVA: 0x2B6BD90 Offset: 0x2B6BE91 VA: 0x2B6BD90 Slot: 4
	protected override void BuildHierarchy() { }

	// RVA: 0x2B6BFF0 Offset: 0x2B6C0F1 VA: 0x2B6BFF0
	private void BuildBaseHierarchy() { }

	// RVA: 0x2B6D4A0 Offset: 0x2B6D5A1 VA: 0x2B6D4A0
	public void SetupAnimatorWithDAOC() { }

	// RVA: 0x2B6D0B0 Offset: 0x2B6D1B1 VA: 0x2B6D0B0
	private void SetupAnimatorWithAOC() { }

	// RVA: 0x2B6C330 Offset: 0x2B6C431 VA: 0x2B6C330
	private void AttachHeadHairAndWeapons() { }

	// RVA: 0x2B6DAC0 Offset: 0x2B6DBC1 VA: 0x2B6DAC0 Slot: 7
	public override void UnloadD(Transform chr) { }

	// RVA: 0x2B6CDB0 Offset: 0x2B6CEB1 VA: 0x2B6CDB0
	private void Others() { }

	// RVA: 0x2B6CF90 Offset: 0x2B6D091 VA: 0x2B6CF90
	private GameObject GetGO(CharacterAsset asset) { }

	// RVA: 0x2B6BFE0 Offset: 0x2B6C0E1 VA: 0x2B6BFE0
	private void RepairAOC() { }

	// RVA: 0x2B6C950 Offset: 0x2B6CA51 VA: 0x2B6C950
	private void AttachRidress() { }

	// RVA: 0x2B6CB30 Offset: 0x2B6CC31 VA: 0x2B6CB30
	private void AttachDress() { }

	// RVA: 0x2B6DDE0 Offset: 0x2B6DEE1 VA: 0x2B6DDE0
	private void BuildProportion() { }

	// RVA: 0x2B6DB00 Offset: 0x2B6DC01 VA: 0x2B6DB00
	private void AttachAccessory(int i) { }

	// RVA: 0x2B6D700 Offset: 0x2B6D801 VA: 0x2B6D700
	private static void Validate(AnimatorOverrideController aoc) { }

	// RVA: 0x2B6D990 Offset: 0x2B6DA91 VA: 0x2B6D990
	private static void ReplaceGOName(GameObject go, string src, string dst) { }

	// RVA: 0x2B6D770 Offset: 0x2B6D871 VA: 0x2B6D770
	private static void SetupBaseAnimator(GameObject srcGO, GameObject dstGO, AnimatorOverrideController aoc, bool needListener) { }

	// RVA: 0x2B6D8C0 Offset: 0x2B6D9C1 VA: 0x2B6D8C0
	private static void SetupRiderAnimator(GameObject go, AnimatorOverrideController aoc, bool needListener) { }

	// RVA: 0x2B6B860 Offset: 0x2B6B961 VA: 0x2B6B860
	public void SetVisibleForced(bool value) { }

	// RVA: 0x2B6F230 Offset: 0x2B6F331 VA: 0x2B6F230
	private void MakeCachedRenderersList() { }

	// RVA: 0x2B6BF80 Offset: 0x2B6C081 VA: 0x2B6BF80
	private void InvalidateCachedRenderersList() { }

	// RVA: 0x2B6F370 Offset: 0x2B6F471 VA: 0x2B6F370
	public void .ctor() { }
}

