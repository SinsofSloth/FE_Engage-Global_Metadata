// Namespace: Cinemachine
public struct CameraState // TypeDefIndex: 5814
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x21440 Offset: 0x21541 VA: 0x21440
	private LensSettings <Lens>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x21450 Offset: 0x21551 VA: 0x21450
	private Vector3 <ReferenceUp>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x21460 Offset: 0x21561 VA: 0x21460
	private Vector3 <ReferenceLookAt>k__BackingField; // 0x38
	public static Vector3 kNoPoint; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x21470 Offset: 0x21571 VA: 0x21470
	private Vector3 <RawPosition>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x21480 Offset: 0x21581 VA: 0x21480
	private Quaternion <RawOrientation>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x21490 Offset: 0x21591 VA: 0x21490
	private Vector3 <PositionDampingBypass>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x214A0 Offset: 0x215A1 VA: 0x214A0
	private float <ShotQuality>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x214B0 Offset: 0x215B1 VA: 0x214B0
	private Vector3 <PositionCorrection>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x214C0 Offset: 0x215C1 VA: 0x214C0
	private Quaternion <OrientationCorrection>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x214D0 Offset: 0x215D1 VA: 0x214D0
	private CameraState.BlendHintValue <BlendHint>k__BackingField; // 0x8C
	private CameraState.CustomBlendable mCustom0; // 0x90
	private CameraState.CustomBlendable mCustom1; // 0xA0
	private CameraState.CustomBlendable mCustom2; // 0xB0
	private CameraState.CustomBlendable mCustom3; // 0xC0
	private List<CameraState.CustomBlendable> m_CustomOverflow; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x214E0 Offset: 0x215E1 VA: 0x214E0
	private int <NumCustomBlendables>k__BackingField; // 0xD8

	// Properties
	public LensSettings Lens { get; set; }
	public Vector3 ReferenceUp { get; set; }
	public Vector3 ReferenceLookAt { get; set; }
	public bool HasLookAt { get; }
	public Vector3 RawPosition { get; set; }
	public Quaternion RawOrientation { get; set; }
	public Vector3 PositionDampingBypass { get; set; }
	public float ShotQuality { get; set; }
	public Vector3 PositionCorrection { get; set; }
	public Quaternion OrientationCorrection { get; set; }
	public Vector3 CorrectedPosition { get; }
	public Quaternion CorrectedOrientation { get; }
	public Vector3 FinalPosition { get; }
	public Quaternion FinalOrientation { get; }
	public CameraState.BlendHintValue BlendHint { get; set; }
	public static CameraState Default { get; }
	public int NumCustomBlendables { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x238D0 Offset: 0x239D1 VA: 0x238D0
	[CompilerGeneratedAttribute] // RVA: 0x238D0 Offset: 0x239D1 VA: 0x238D0
	// RVA: 0x1B82770 Offset: 0x1B82871 VA: 0x1B82770
	public LensSettings get_Lens() { }

	[CompilerGeneratedAttribute] // RVA: 0x23910 Offset: 0x23A11 VA: 0x23910
	// RVA: 0x1B827A0 Offset: 0x1B828A1 VA: 0x1B827A0
	public void set_Lens(LensSettings value) { }

	[IsReadOnlyAttribute] // RVA: 0x23920 Offset: 0x23A21 VA: 0x23920
	[CompilerGeneratedAttribute] // RVA: 0x23920 Offset: 0x23A21 VA: 0x23920
	// RVA: 0x1B827C0 Offset: 0x1B828C1 VA: 0x1B827C0
	public Vector3 get_ReferenceUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x23960 Offset: 0x23A61 VA: 0x23960
	// RVA: 0x1B827D0 Offset: 0x1B828D1 VA: 0x1B827D0
	public void set_ReferenceUp(Vector3 value) { }

	[IsReadOnlyAttribute] // RVA: 0x23970 Offset: 0x23A71 VA: 0x23970
	[CompilerGeneratedAttribute] // RVA: 0x23970 Offset: 0x23A71 VA: 0x23970
	// RVA: 0x1B827E0 Offset: 0x1B828E1 VA: 0x1B827E0
	public Vector3 get_ReferenceLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x239B0 Offset: 0x23AB1 VA: 0x239B0
	// RVA: 0x1B827F0 Offset: 0x1B828F1 VA: 0x1B827F0
	public void set_ReferenceLookAt(Vector3 value) { }

	// RVA: 0x1B82800 Offset: 0x1B82901 VA: 0x1B82800
	public bool get_HasLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x239C0 Offset: 0x23AC1 VA: 0x239C0
	[IsReadOnlyAttribute] // RVA: 0x239C0 Offset: 0x23AC1 VA: 0x239C0
	// RVA: 0x1B82820 Offset: 0x1B82921 VA: 0x1B82820
	public Vector3 get_RawPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x23A00 Offset: 0x23B01 VA: 0x23A00
	// RVA: 0x1B82830 Offset: 0x1B82931 VA: 0x1B82830
	public void set_RawPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23A10 Offset: 0x23B11 VA: 0x23A10
	[IsReadOnlyAttribute] // RVA: 0x23A10 Offset: 0x23B11 VA: 0x23A10
	// RVA: 0x1B82840 Offset: 0x1B82941 VA: 0x1B82840
	public Quaternion get_RawOrientation() { }

	[CompilerGeneratedAttribute] // RVA: 0x23A50 Offset: 0x23B51 VA: 0x23A50
	// RVA: 0x1B82850 Offset: 0x1B82951 VA: 0x1B82850
	public void set_RawOrientation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23A60 Offset: 0x23B61 VA: 0x23A60
	[IsReadOnlyAttribute] // RVA: 0x23A60 Offset: 0x23B61 VA: 0x23A60
	// RVA: 0x1B82870 Offset: 0x1B82971 VA: 0x1B82870
	public Vector3 get_PositionDampingBypass() { }

	[CompilerGeneratedAttribute] // RVA: 0x23AA0 Offset: 0x23BA1 VA: 0x23AA0
	// RVA: 0x1B82880 Offset: 0x1B82981 VA: 0x1B82880
	public void set_PositionDampingBypass(Vector3 value) { }

	[IsReadOnlyAttribute] // RVA: 0x23AB0 Offset: 0x23BB1 VA: 0x23AB0
	[CompilerGeneratedAttribute] // RVA: 0x23AB0 Offset: 0x23BB1 VA: 0x23AB0
	// RVA: 0x1B82890 Offset: 0x1B82991 VA: 0x1B82890
	public float get_ShotQuality() { }

	[CompilerGeneratedAttribute] // RVA: 0x23AF0 Offset: 0x23BF1 VA: 0x23AF0
	// RVA: 0x1B828A0 Offset: 0x1B829A1 VA: 0x1B828A0
	public void set_ShotQuality(float value) { }

	[IsReadOnlyAttribute] // RVA: 0x23B00 Offset: 0x23C01 VA: 0x23B00
	[CompilerGeneratedAttribute] // RVA: 0x23B00 Offset: 0x23C01 VA: 0x23B00
	// RVA: 0x1B828B0 Offset: 0x1B829B1 VA: 0x1B828B0
	public Vector3 get_PositionCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x23B40 Offset: 0x23C41 VA: 0x23B40
	// RVA: 0x1B828C0 Offset: 0x1B829C1 VA: 0x1B828C0
	public void set_PositionCorrection(Vector3 value) { }

	[IsReadOnlyAttribute] // RVA: 0x23B50 Offset: 0x23C51 VA: 0x23B50
	[CompilerGeneratedAttribute] // RVA: 0x23B50 Offset: 0x23C51 VA: 0x23B50
	// RVA: 0x1B828D0 Offset: 0x1B829D1 VA: 0x1B828D0
	public Quaternion get_OrientationCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x23B90 Offset: 0x23C91 VA: 0x23B90
	// RVA: 0x1B828E0 Offset: 0x1B829E1 VA: 0x1B828E0
	public void set_OrientationCorrection(Quaternion value) { }

	// RVA: 0x1B82900 Offset: 0x1B82A01 VA: 0x1B82900
	public Vector3 get_CorrectedPosition() { }

	// RVA: 0x1B82920 Offset: 0x1B82A21 VA: 0x1B82920
	public Quaternion get_CorrectedOrientation() { }

	// RVA: 0x1B82940 Offset: 0x1B82A41 VA: 0x1B82940
	public Vector3 get_FinalPosition() { }

	// RVA: 0x1B82960 Offset: 0x1B82A61 VA: 0x1B82960
	public Quaternion get_FinalOrientation() { }

	[CompilerGeneratedAttribute] // RVA: 0x23BA0 Offset: 0x23CA1 VA: 0x23BA0
	[IsReadOnlyAttribute] // RVA: 0x23BA0 Offset: 0x23CA1 VA: 0x23BA0
	// RVA: 0x1B82A50 Offset: 0x1B82B51 VA: 0x1B82A50
	public CameraState.BlendHintValue get_BlendHint() { }

	[CompilerGeneratedAttribute] // RVA: 0x23BE0 Offset: 0x23CE1 VA: 0x23BE0
	// RVA: 0x1B82A60 Offset: 0x1B82B61 VA: 0x1B82A60
	public void set_BlendHint(CameraState.BlendHintValue value) { }

	// RVA: 0x1B82A70 Offset: 0x1B82B71 VA: 0x1B82A70
	public static CameraState get_Default() { }

	[CompilerGeneratedAttribute] // RVA: 0x23BF0 Offset: 0x23CF1 VA: 0x23BF0
	[IsReadOnlyAttribute] // RVA: 0x23BF0 Offset: 0x23CF1 VA: 0x23BF0
	// RVA: 0x1B82CC0 Offset: 0x1B82DC1 VA: 0x1B82CC0
	public int get_NumCustomBlendables() { }

	[CompilerGeneratedAttribute] // RVA: 0x23C30 Offset: 0x23D31 VA: 0x23C30
	// RVA: 0x1B82CD0 Offset: 0x1B82DD1 VA: 0x1B82CD0
	private void set_NumCustomBlendables(int value) { }

	// RVA: 0x1B82CE0 Offset: 0x1B82DE1 VA: 0x1B82CE0
	public CameraState.CustomBlendable GetCustomBlendable(int index) { }

	// RVA: 0x1B82DE0 Offset: 0x1B82EE1 VA: 0x1B82DE0
	private int FindCustomBlendable(Object custom) { }

	// RVA: 0x1B82FD0 Offset: 0x1B830D1 VA: 0x1B82FD0
	public void AddCustomBlendable(CameraState.CustomBlendable b) { }

	// RVA: 0x1B83170 Offset: 0x1B83271 VA: 0x1B83170
	public static CameraState Lerp(CameraState stateA, CameraState stateB, float t) { }

	// RVA: 0x1B83EB0 Offset: 0x1B83FB1 VA: 0x1B83EB0
	private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t) { }

	// RVA: 0x1B83E00 Offset: 0x1B83F01 VA: 0x1B83E00
	private static Vector3 ApplyPosBlendHint(Vector3 posA, CameraState.BlendHintValue hintA, Vector3 posB, CameraState.BlendHintValue hintB, Vector3 original, Vector3 blended) { }

	// RVA: 0x1B83E50 Offset: 0x1B83F51 VA: 0x1B83E50
	private static Quaternion ApplyRotBlendHint(Quaternion rotA, CameraState.BlendHintValue hintA, Quaternion rotB, CameraState.BlendHintValue hintB, Quaternion original, Quaternion blended) { }

	// RVA: 0x1B83FD0 Offset: 0x1B840D1 VA: 0x1B83FD0
	private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t) { }

	// RVA: 0x1B841F0 Offset: 0x1B842F1 VA: 0x1B841F0
	private static void .cctor() { }
}

