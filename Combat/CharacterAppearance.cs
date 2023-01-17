// Namespace: Combat
[DefaultMemberAttribute] // RVA: 0x273BF0 Offset: 0x273CF1 VA: 0x273BF0
[Serializable]
public sealed class CharacterAppearance : IDisposable // TypeDefIndex: 8581
{
	// Fields
	private static float s_StencilValue; // 0x0
	[SerializeField] // RVA: 0x282190 Offset: 0x282291 VA: 0x282190
	private CharacterAsset[] assets; // 0x10
	public List<string> AnimsetNames; // 0x18
	[SerializeField] // RVA: 0x2821A0 Offset: 0x2822A1 VA: 0x2821A0
	private string[] accTargets; // 0x20
	public Color MaskColor100; // 0x28
	public Color MaskColor075; // 0x38
	public Color MaskColor050; // 0x48
	public Color MaskColor025; // 0x58
	public Color SkinColor; // 0x68
	public Color GradColor; // 0x78
	public Color HairColor; // 0x88
	public Color ToonShadowColor; // 0x98
	public AssetTable.Sound Sound; // 0xA8
	public ProportionParameters Proportion; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x2821B0 Offset: 0x2822B1 VA: 0x2821B0
	private CharacterAnimset <AnimSet>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x2821C0 Offset: 0x2822C1 VA: 0x2821C0
	private WeaponStyle <WeaponStyle>k__BackingField; // 0xD0
	private List<Material> m_InstancedMaterials; // 0xD8
	private GameParam.Holder m_HolderLoadSimultaneous; // 0xE0
	private GameParam.Holder m_CharaTallWalk; // 0xE8
	private GameParam.Holder m_CharaTallHorse; // 0xF0
	private GameParam.Holder m_CharaTallWolf; // 0xF8
	private GameParam.Holder m_CharaTallPegasus; // 0x100
	private GameParam.Holder m_CharaTallDragon; // 0x108
	private GameParam.Holder m_CharaTallGriffon; // 0x110
	private GameParam.Holder m_CharaTallEngage; // 0x118
	private GameParam.Holder m_CharaTallSombronHuman; // 0x120
	private GameParam.Holder m_CharaTallSombronDragon; // 0x128
	private static readonly int hash_BaseColor; // 0x4
	private static readonly int hash_StencilGroup; // 0x8
	private static readonly int hash_GradationColor; // 0xC
	private static readonly int hash_ToonShadowColor; // 0x10
	private static readonly int hash_MaskColor100; // 0x14
	private static readonly int hash_MaskColor075; // 0x18
	private static readonly int hash_MaskColor050; // 0x1C
	private static readonly int hash_MaskColor025; // 0x20
	private static readonly string[] Conditions; // 0x28

	// Properties
	public CharacterAnimset AnimSet { get; set; }
	public WeaponStyle WeaponStyle { get; set; }
	public CharacterAsset Item { get; }
	public CharacterAsset Item { get; }
	public string[] AccTargets { get; }
	public AnimName.Race Race { get; }
	public bool IsRide { get; }
	public bool IsFlying { get; }
	public bool IsCorruptAnimal { get; }
	public bool IsBigDragon { get; }
	public bool IsWyrm { get; }
	public bool IsBrawl { get; }
	public bool HasRod { get; }
	public CharacterAsset MainHandModel { get; }
	public bool IsHighClass { get; }
	public bool Is異形 { get; }
	public bool IsLastBoss { get; }
	public float BackwardCancelPosition { get; }

	// Methods

	// RVA: 0x2E265A0 Offset: 0x2E266A1 VA: 0x2E265A0
	public static bool op_Implicit(CharacterAppearance a) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA2D0 Offset: 0x2AA3D1 VA: 0x2AA2D0
	// RVA: 0x2E265B0 Offset: 0x2E266B1 VA: 0x2E265B0
	public CharacterAnimset get_AnimSet() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA2E0 Offset: 0x2AA3E1 VA: 0x2AA2E0
	// RVA: 0x2E265C0 Offset: 0x2E266C1 VA: 0x2E265C0
	private void set_AnimSet(CharacterAnimset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA2F0 Offset: 0x2AA3F1 VA: 0x2AA2F0
	// RVA: 0x2E265D0 Offset: 0x2E266D1 VA: 0x2E265D0
	public WeaponStyle get_WeaponStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA300 Offset: 0x2AA401 VA: 0x2AA300
	// RVA: 0x2E265E0 Offset: 0x2E266E1 VA: 0x2E265E0
	private void set_WeaponStyle(WeaponStyle value) { }

	// RVA: 0x2E265F0 Offset: 0x2E266F1 VA: 0x2E265F0
	public CharacterAsset get_Item(int index) { }

	// RVA: 0x2E255A0 Offset: 0x2E256A1 VA: 0x2E255A0
	public CharacterAsset get_Item(AssetType type) { }

	// RVA: 0x2E26630 Offset: 0x2E26731 VA: 0x2E26630
	public string[] get_AccTargets() { }

	// RVA: 0x2E1B290 Offset: 0x2E1B391 VA: 0x2E1B290
	public AnimName.Race get_Race() { }

	// RVA: 0x2E1FCF0 Offset: 0x2E1FDF1 VA: 0x2E1FCF0
	public bool get_IsRide() { }

	// RVA: 0x2E26640 Offset: 0x2E26741 VA: 0x2E26640
	public bool get_IsFlying() { }

	// RVA: 0x2E266B0 Offset: 0x2E267B1 VA: 0x2E266B0
	public bool get_IsCorruptAnimal() { }

	// RVA: 0x2E1C240 Offset: 0x2E1C341 VA: 0x2E1C240
	public bool get_IsBigDragon() { }

	// RVA: 0x2E1C2D0 Offset: 0x2E1C3D1 VA: 0x2E1C2D0
	public bool get_IsWyrm() { }

	// RVA: 0x2E26730 Offset: 0x2E26831 VA: 0x2E26730
	public bool get_IsBrawl() { }

	// RVA: 0x2E26740 Offset: 0x2E26841 VA: 0x2E26740
	public bool get_HasRod() { }

	// RVA: 0x2E26820 Offset: 0x2E26921 VA: 0x2E26820
	public CharacterAsset get_MainHandModel() { }

	// RVA: 0x2E26930 Offset: 0x2E26A31 VA: 0x2E26930
	public bool get_IsHighClass() { }

	// RVA: 0x2E20260 Offset: 0x2E20361 VA: 0x2E20260
	public bool get_Is異形() { }

	// RVA: 0x2E1C1C0 Offset: 0x2E1C2C1 VA: 0x2E1C1C0
	public bool get_IsLastBoss() { }

	// RVA: 0x2E1B690 Offset: 0x2E1B791 VA: 0x2E1B690
	public float get_BackwardCancelPosition() { }

	// RVA: 0x2E269A0 Offset: 0x2E26AA1 VA: 0x2E269A0
	public void .ctor() { }

	// RVA: 0x2E26E30 Offset: 0x2E26F31 VA: 0x2E26E30
	public void .ctor(CharacterAppearance rhs, WeaponStyle weaponStyle) { }

	// RVA: 0x2E27570 Offset: 0x2E27671 VA: 0x2E27570 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E27830 Offset: 0x2E27931 VA: 0x2E27830 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E278C0 Offset: 0x2E279C1 VA: 0x2E278C0
	public void SetDefaultName() { }

	// RVA: 0x2E27A10 Offset: 0x2E27B11 VA: 0x2E27A10
	public string Dump() { }

	// RVA: 0x2E27B30 Offset: 0x2E27C31 VA: 0x2E27B30
	public void LoadAsync() { }

	// RVA: 0x2E27C60 Offset: 0x2E27D61 VA: 0x2E27C60
	public void LoadAnimSetAsync() { }

	// RVA: 0x2E27CB0 Offset: 0x2E27DB1 VA: 0x2E27CB0
	public bool IsLoading() { }

	// RVA: 0x2E27E80 Offset: 0x2E27F81 VA: 0x2E27E80
	public StringBuilder GetUnfoundAssetNamesD() { }

	// RVA: 0x2E280B0 Offset: 0x2E281B1 VA: 0x2E280B0
	public void ReplaceBodyAnimForEditor(CharacterAsset a) { }

	// RVA: 0x2E28120 Offset: 0x2E28221 VA: 0x2E28120
	public void CreateAnimSetForViewerPreview(int mapDistance) { }

	// RVA: 0x2E283F0 Offset: 0x2E284F1 VA: 0x2E283F0
	public float GetTall() { }

	// RVA: 0x2E285E0 Offset: 0x2E286E1 VA: 0x2E285E0
	public float GetBodySize() { }

	// RVA: 0x2E286F0 Offset: 0x2E287F1 VA: 0x2E286F0
	public void ModifyColors(GameObject go) { }

	// RVA: 0x2E29010 Offset: 0x2E29111 VA: 0x2E29010
	private bool HasMaterialToModify(Material[] mats) { }

	// RVA: 0x2E27670 Offset: 0x2E27771 VA: 0x2E27670
	private void DestroyInstancedMaterials() { }

	// RVA: 0x2E1C010 Offset: 0x2E1C111 VA: 0x2E1C010
	public void Verification(string title) { }

	// RVA: 0x2E29540 Offset: 0x2E29641 VA: 0x2E29540
	public string SerializeToString() { }

	// RVA: 0x2E29C30 Offset: 0x2E29D31 VA: 0x2E29C30
	public void DeserializeFromString(string contents) { }

	// RVA: 0x2E2A170 Offset: 0x2E2A271 VA: 0x2E2A170
	public static CharacterAppearance CreateFromGameStatus(CharacterGameStatus gameStatus, int mapDistance = 1, string[] conditions) { }

	// RVA: 0x2E2AAF0 Offset: 0x2E2ABF1 VA: 0x2E2AAF0
	public static CharacterAppearance CreateForSound(Unit unit) { }

	// RVA: 0x2E2AC10 Offset: 0x2E2AD11 VA: 0x2E2AC10
	public static CharacterAppearance CreateFromGodUnit(GodUnit gunit, string[] conditions) { }

	// RVA: 0x2E2ACA0 Offset: 0x2E2ADA1 VA: 0x2E2ACA0
	public static CharacterAppearance CreateFromPreset(string name) { }

	// RVA: 0x2E2A280 Offset: 0x2E2A381 VA: 0x2E2A280
	private static string[] GetConstions(string[] conditions) { }

	// RVA: 0x2E2A4E0 Offset: 0x2E2A5E1 VA: 0x2E2A4E0
	public static CharacterAppearance CreateFromResult(AssetTable.Result result, int mapDistance_1or2 = 1) { }

	// RVA: 0x2E28240 Offset: 0x2E28341 VA: 0x2E28240
	public WeaponStyle CalcWeaponStyle(int mapDistance = 1) { }

	// RVA: 0x2E2AD20 Offset: 0x2E2AE21 VA: 0x2E2AD20
	public static bool IsSameCharacter(CharacterAppearance l, CharacterAppearance r) { }

	// RVA: 0x2E2AE10 Offset: 0x2E2AF11 VA: 0x2E2AE10
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA310 Offset: 0x2AA411 VA: 0x2AA310
	// RVA: 0x2E29A40 Offset: 0x2E29B41 VA: 0x2E29A40
	internal static string <SerializeToString>g__ctos|92_0(Color c) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA320 Offset: 0x2AA421 VA: 0x2AA320
	// RVA: 0x2E2A020 Offset: 0x2E2A121 VA: 0x2E2A020
	internal static Color <DeserializeFromString>g__stoc|93_0(string s) { }
}

