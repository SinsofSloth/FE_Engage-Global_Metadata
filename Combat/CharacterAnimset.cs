// Namespace: Combat
public sealed class CharacterAnimset : IDisposable // TypeDefIndex: 8580
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x282180 Offset: 0x282281 VA: 0x282180
	private PreloadAnims <PreloadAnims>k__BackingField; // 0x10
	private AnimatorOverrideController BodyDAOC; // 0x18
	private AnimatorOverrideController RideDAOC; // 0x20
	private AnimAsset Attack1; // 0x28
	private AnimAsset Attack1R; // 0x30
	private AnimAsset Attack2; // 0x38
	private AnimAsset Attack2R; // 0x40
	private AnimAsset Attack3; // 0x48
	private AnimAsset Attack3R; // 0x50
	private AnimAsset Attack4; // 0x58
	private AnimAsset Attack4R; // 0x60
	private AnimAsset Attack5; // 0x68
	private AnimAsset Attack5R; // 0x70
	private AnimAsset AttackC; // 0x78
	private AnimAsset AttackCR; // 0x80
	private AnimAsset AttackT; // 0x88
	private AnimAsset AttackTR; // 0x90
	private AnimAsset DamageHigh; // 0x98
	private AnimAsset DamageHighR; // 0xA0
	private AnimAsset DamageMidB; // 0xA8
	private AnimAsset DamageMidBR; // 0xB0
	private AnimAsset DamageMidDU; // 0xB8
	private AnimAsset DamageMidDUR; // 0xC0
	private AnimAsset DamageMidUD; // 0xC8
	private AnimAsset DamageMidUDR; // 0xD0
	private AnimAsset DieB; // 0xD8
	private AnimAsset DieBR; // 0xE0
	private AnimAsset DieL; // 0xE8
	private AnimAsset DieLR; // 0xF0
	private AnimAsset DieR; // 0xF8
	private AnimAsset DieRR; // 0x100
	private AnimAsset Dive; // 0x108
	private AnimAsset DiveR; // 0x110
	private AnimAsset Engage1; // 0x118
	private AnimAsset Engage1R; // 0x120
	private AnimAsset Engage2; // 0x128
	private AnimAsset Engage2R; // 0x130
	private AnimAsset Engage3; // 0x138
	private AnimAsset Engage3R; // 0x140
	private AnimAsset EvasionB; // 0x148
	private AnimAsset EvasionBR; // 0x150
	private AnimAsset EvasionL; // 0x158
	private AnimAsset EvasionLR; // 0x160
	private AnimAsset EvasionR; // 0x168
	private AnimAsset EvasionRR; // 0x170
	private AnimAsset Guard; // 0x178
	private AnimAsset GuardR; // 0x180
	private AnimAsset HoveringLoop; // 0x188
	private AnimAsset HoveringLoopR; // 0x190
	private AnimAsset IdleDying; // 0x198
	private AnimAsset IdleDyingR; // 0x1A0
	private AnimAsset IdleNormal; // 0x1A8
	private AnimAsset IdleNormalR; // 0x1B0
	private AnimAsset ParryL; // 0x1B8
	private AnimAsset ParryLR; // 0x1C0
	private AnimAsset ParryR; // 0x1C8
	private AnimAsset ParryRR; // 0x1D0
	private AnimAsset Ready; // 0x1D8
	private AnimAsset ReadyR; // 0x1E0
	private AnimAsset RelaxLoop; // 0x1E8
	private AnimAsset RelaxLoopR; // 0x1F0
	private AnimAsset Repelled; // 0x1F8
	private AnimAsset RepelledR; // 0x200
	private AnimAsset RunLoop; // 0x208
	private AnimAsset RunLoopR; // 0x210
	private AnimAsset RunStart; // 0x218
	private AnimAsset RunStartR; // 0x220
	private AnimAsset Special1; // 0x228
	private AnimAsset Special1R; // 0x230
	private AnimAsset Start; // 0x238
	private AnimAsset StartR; // 0x240
	private AnimAsset Win; // 0x248
	private AnimAsset WinR; // 0x250
	private AnimAsset WinLoop; // 0x258
	private AnimAsset WinLoopR; // 0x260

	// Properties
	public PreloadAnims PreloadAnims { get; set; }
	public bool HasWinAsStandingDie { get; }
	public bool CanBeSmashed { get; }

	// Methods

	// RVA: 0x2E1D9B0 Offset: 0x2E1DAB1 VA: 0x2E1D9B0
	public static bool op_Implicit(CharacterAnimset a) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA270 Offset: 0x2AA371 VA: 0x2AA270
	// RVA: 0x2E20900 Offset: 0x2E20A01 VA: 0x2E20900
	public PreloadAnims get_PreloadAnims() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA280 Offset: 0x2AA381 VA: 0x2AA280
	// RVA: 0x2E20910 Offset: 0x2E20A11 VA: 0x2E20910
	public void set_PreloadAnims(PreloadAnims value) { }

	// RVA: 0x2E20920 Offset: 0x2E20A21 VA: 0x2E20920 Slot: 4
	public void Dispose() { }

	// RVA: 0x2E21D30 Offset: 0x2E21E31 VA: 0x2E21D30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E21DA0 Offset: 0x2E21EA1 VA: 0x2E21DA0
	public void .ctor() { }

	// RVA: 0x2E21DB0 Offset: 0x2E21EB1 VA: 0x2E21DB0
	public void .ctor(List<string> animsetNames, WeaponStyle weaponStyle) { }

	// RVA: 0x2E22B90 Offset: 0x2E22C91 VA: 0x2E22B90
	public static bool IsInDB(string animsetName) { }

	// RVA: 0x2E223E0 Offset: 0x2E224E1 VA: 0x2E223E0
	public void Override(string animsetName) { }

	// RVA: 0x2E22D90 Offset: 0x2E22E91 VA: 0x2E22D90
	public void MaskUnusedAnims(PreloadAnims f) { }

	// RVA: 0x2E235B0 Offset: 0x2E236B1 VA: 0x2E235B0
	private ValueTuple<AnimAsset, AnimAsset> FindAssetPair(string keyword) { }

	// RVA: 0x2E23FD0 Offset: 0x2E240D1 VA: 0x2E23FD0
	private static string GetKeyword(string s) { }

	// RVA: 0x2E24050 Offset: 0x2E24151 VA: 0x2E24050
	public void LoadAsync() { }

	// RVA: 0x2E244C0 Offset: 0x2E245C1 VA: 0x2E244C0
	public bool IsLoading() { }

	// RVA: 0x2E24E40 Offset: 0x2E24F41 VA: 0x2E24E40
	public void MakeDAOC(CharacterAppearance ap) { }

	// RVA: 0x2E250D0 Offset: 0x2E251D1 VA: 0x2E250D0
	private ValueTuple<AnimatorOverrideController, AnimatorOverrideController> MakeDAOC(bool isRide, string name) { }

	// RVA: 0x2E255E0 Offset: 0x2E256E1 VA: 0x2E255E0
	public void UseEngage2() { }

	// RVA: 0x2E1FD90 Offset: 0x2E1FE91 VA: 0x2E1FD90
	public bool Has(int hash) { }

	// RVA: 0x2E25620 Offset: 0x2E25721 VA: 0x2E25620
	public bool HasDie() { }

	// RVA: 0x2E256B0 Offset: 0x2E257B1 VA: 0x2E256B0
	public List<string> GetAnimAssetsNameList() { }

	// RVA: 0x2E25C80 Offset: 0x2E25D81 VA: 0x2E25C80
	public static ValueTuple<string, List<string>> FixCommaSeparated(List<string> src) { }

	// RVA: 0x2E21EF0 Offset: 0x2E21FF1 VA: 0x2E21EF0
	public static List<string> InsertNML(List<string> aset, char myNML) { }

	// RVA: 0x2E25F60 Offset: 0x2E26061 VA: 0x2E25F60
	public bool get_HasWinAsStandingDie() { }

	// RVA: 0x2E25FF0 Offset: 0x2E260F1 VA: 0x2E25FF0
	public static void UpdateStatistics(Character chr) { }

	// RVA: 0x2E26000 Offset: 0x2E26101 VA: 0x2E26000
	public bool get_CanBeSmashed() { }

	// RVA: 0x2E26080 Offset: 0x2E26181 VA: 0x2E26080
	private int SelectImpl(bool shuffle, int lastHash, int[] candidates) { }

	// RVA: 0x2E261A0 Offset: 0x2E262A1 VA: 0x2E261A0
	public int SelectRandom(int lashHash, int[] candidates) { }

	// RVA: 0x2E261B0 Offset: 0x2E262B1 VA: 0x2E261B0
	public int SelectRandomAttack12345(int lastHash = 0) { }

	// RVA: 0x2E26250 Offset: 0x2E26351 VA: 0x2E26250
	public int SelectInOrder(int[] candidates) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA290 Offset: 0x2AA391 VA: 0x2AA290
	// RVA: 0x2E22C20 Offset: 0x2E22D21 VA: 0x2E22C20
	internal static void <Override>g__applyCell|84_0(ref AnimAsset aa, string clipName, string cellValue, int hash, ref CharacterAnimset.<>c__DisplayClass84_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA2A0 Offset: 0x2AA3A1 VA: 0x2AA2A0
	// RVA: 0x2E26310 Offset: 0x2E26411 VA: 0x2E26310
	internal static string <Override>g__complement|84_1(string clipName, string cellValue, ref CharacterAnimset.<>c__DisplayClass84_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA2B0 Offset: 0x2AA3B1 VA: 0x2AA2B0
	// RVA: 0x2E24220 Offset: 0x2E24321 VA: 0x2E24220
	internal static void <LoadAsync>g__load|88_0(AnimAsset Body, ref AnimAsset Ride) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA2C0 Offset: 0x2AA3C1 VA: 0x2AA2C0
	// RVA: 0x2E25EC0 Offset: 0x2E25FC1 VA: 0x2E25EC0
	internal static void <InsertNML>g__Add|97_0(string s, ref CharacterAnimset.<>c__DisplayClass97_0 ) { }
}

