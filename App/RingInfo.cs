// Namespace: App
public class RingInfo : SingletonProcInst<RingInfo> // TypeDefIndex: 11833
{
	// Fields
	private RingInfo.RingInfoWindowRingModel[] m_RingInfoWindows; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x299590 Offset: 0x299691 VA: 0x299590
	private static GodUnit <God>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2995A0 Offset: 0x2996A1 VA: 0x2995A0
	private static GodData <GodData>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x2995B0 Offset: 0x2996B1 VA: 0x2995B0
	private static RingData <Ring>k__BackingField; // 0x10
	private static bool s_IsPlayAnimation; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x2995C0 Offset: 0x2996C1 VA: 0x2995C0
	private static RingData <Ring2>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2995D0 Offset: 0x2996D1 VA: 0x2995D0
	private static int <s_LoadStartCount>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2995E0 Offset: 0x2996E1 VA: 0x2995E0
	private static bool <s_IsLoadStart>k__BackingField; // 0x2C
	private static readonly int LoadStartWait; // 0x30
	private static bool s_IsVisibleDirty; // 0x34

	// Properties
	private static GodUnit God { get; set; }
	private static GodData GodData { get; set; }
	public static RingData Ring { get; set; }
	public static RingData Ring2 { get; set; }
	private static int s_LoadStartCount { get; set; }
	private static bool s_IsLoadStart { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C6B20 Offset: 0x2C6C21 VA: 0x2C6B20
	// RVA: 0x268B720 Offset: 0x268B821 VA: 0x268B720
	private static GodUnit get_God() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B30 Offset: 0x2C6C31 VA: 0x2C6B30
	// RVA: 0x268B790 Offset: 0x268B891 VA: 0x268B790
	private static void set_God(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B40 Offset: 0x2C6C41 VA: 0x2C6B40
	// RVA: 0x268B810 Offset: 0x268B911 VA: 0x268B810
	private static GodData get_GodData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B50 Offset: 0x2C6C51 VA: 0x2C6B50
	// RVA: 0x268B880 Offset: 0x268B981 VA: 0x268B880
	private static void set_GodData(GodData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B60 Offset: 0x2C6C61 VA: 0x2C6B60
	// RVA: 0x268B900 Offset: 0x268BA01 VA: 0x268B900
	public static RingData get_Ring() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B70 Offset: 0x2C6C71 VA: 0x2C6B70
	// RVA: 0x268B970 Offset: 0x268BA71 VA: 0x268B970
	private static void set_Ring(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B80 Offset: 0x2C6C81 VA: 0x2C6B80
	// RVA: 0x268B9F0 Offset: 0x268BAF1 VA: 0x268B9F0
	public static RingData get_Ring2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6B90 Offset: 0x2C6C91 VA: 0x2C6B90
	// RVA: 0x268BA60 Offset: 0x268BB61 VA: 0x268BA60
	private static void set_Ring2(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6BA0 Offset: 0x2C6CA1 VA: 0x2C6BA0
	// RVA: 0x268BAE0 Offset: 0x268BBE1 VA: 0x268BAE0
	private static int get_s_LoadStartCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6BB0 Offset: 0x2C6CB1 VA: 0x2C6BB0
	// RVA: 0x268BB50 Offset: 0x268BC51 VA: 0x268BB50
	private static void set_s_LoadStartCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6BC0 Offset: 0x2C6CC1 VA: 0x2C6BC0
	// RVA: 0x268BBC0 Offset: 0x268BCC1 VA: 0x268BBC0
	private static bool get_s_IsLoadStart() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6BD0 Offset: 0x2C6CD1 VA: 0x2C6BD0
	// RVA: 0x268BC30 Offset: 0x268BD31 VA: 0x268BC30
	private static void set_s_IsLoadStart(bool value) { }

	// RVA: 0x268BCB0 Offset: 0x268BDB1 VA: 0x268BCB0
	public static void CreateAsync(ProcInst super) { }

	// RVA: 0x267B9F0 Offset: 0x267BAF1 VA: 0x267B9F0
	public static void SetVisible(bool value, int index = 0, bool isVisibleDirty = False) { }

	// RVA: 0x268C320 Offset: 0x268C421 VA: 0x268C320
	private void PrepareRingModel() { }

	// RVA: 0x268C420 Offset: 0x268C521 VA: 0x268C420
	private bool IsCreating() { }

	// RVA: 0x268C4B0 Offset: 0x268C5B1 VA: 0x268C4B0
	private void Start() { }

	// RVA: 0x268C530 Offset: 0x268C631 VA: 0x268C530
	private void Tick() { }

	// RVA: 0x268CDC0 Offset: 0x268CEC1 VA: 0x268CDC0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x268C0E0 Offset: 0x268C1E1 VA: 0x268C0E0
	public static void SetRing(GodUnit godUnit) { }

	// RVA: 0x268D050 Offset: 0x268D151 VA: 0x268D050
	public static void SetRingCommon(RingData data, RingData data2, bool isPlayAnimation = True) { }

	// RVA: 0x268CE80 Offset: 0x268CF81 VA: 0x268CE80
	private static void ResetCounter() { }

	// RVA: 0x267D7F0 Offset: 0x267D8F1 VA: 0x267D7F0
	public static void UpdateDirty() { }

	// RVA: 0x268CB50 Offset: 0x268CC51 VA: 0x268CB50
	private void SetRingImpl(GodUnit godUnit, RingData ringData, bool isPlayAnimation = True, int index = 0) { }

	// RVA: 0x268D290 Offset: 0x268D391 VA: 0x268D290
	private void DeleteRingModels() { }

	// RVA: 0x268D300 Offset: 0x268D401 VA: 0x268D300
	public static RenderTexture GetRenderTexture(int index = 0) { }

	// RVA: 0x268D3F0 Offset: 0x268D4F1 VA: 0x268D3F0
	public static void PlayDecisionAnim() { }

	// RVA: 0x268D490 Offset: 0x268D591 VA: 0x268D490
	private static void SetAnimatorEnable(bool value) { }

	// RVA: 0x268C030 Offset: 0x268C131 VA: 0x268C030
	public void .ctor() { }

	// RVA: 0x268D540 Offset: 0x268D641 VA: 0x268D540
	private static void .cctor() { }
}

