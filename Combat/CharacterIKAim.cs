// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273E00 Offset: 0x273F01 VA: 0x273E00
public sealed class CharacterIKAim : MonoBehaviour // TypeDefIndex: 8609
{
	// Fields
	private Character _cp; // 0x18
	private AimIK aimIK; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x282650 Offset: 0x282751 VA: 0x282650
	private Parabola <Parabola>k__BackingField; // 0x28
	public Vector3 AnimAimDir; // 0x30
	public Vector3 CurrentAimDir; // 0x3C

	// Properties
	private Character CP { get; }
	public Parabola Parabola { get; set; }

	// Methods

	// RVA: 0x2B798D0 Offset: 0x2B799D1 VA: 0x2B798D0
	private Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAC20 Offset: 0x2AAD21 VA: 0x2AAC20
	// RVA: 0x2B79990 Offset: 0x2B79A91 VA: 0x2B79990
	public Parabola get_Parabola() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAC30 Offset: 0x2AAD31 VA: 0x2AAC30
	// RVA: 0x2B799A0 Offset: 0x2B79AA1 VA: 0x2B799A0
	public void set_Parabola(Parabola value) { }

	// RVA: 0x2B799B0 Offset: 0x2B79AB1 VA: 0x2B799B0
	private void OnDisable() { }

	// RVA: 0x2B79A60 Offset: 0x2B79B61 VA: 0x2B79A60
	private void OnEnable() { }

	// RVA: 0x2B79B10 Offset: 0x2B79C11 VA: 0x2B79B10
	private void Start() { }

	// RVA: 0x2B79C00 Offset: 0x2B79D01 VA: 0x2B79C00
	private void MyStart() { }

	// RVA: 0x2B79F60 Offset: 0x2B7A061 VA: 0x2B79F60
	private void MyLateUpdate() { }

	// RVA: 0x2B7A080 Offset: 0x2B7A181 VA: 0x2B7A080
	public void AimOn() { }

	// RVA: 0x2B7A370 Offset: 0x2B7A471 VA: 0x2B7A370
	private void AimOff() { }

	// RVA: 0x2B7A390 Offset: 0x2B7A491 VA: 0x2B7A390
	public void Skip() { }

	// RVA: 0x2B7A190 Offset: 0x2B7A291 VA: 0x2B7A190
	private void Aim(float endWeight, float endTime) { }

	// RVA: 0x2B7A3D0 Offset: 0x2B7A4D1 VA: 0x2B7A3D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAC40 Offset: 0x2AAD41 VA: 0x2AAC40
	// RVA: 0x2B7A3E0 Offset: 0x2B7A4E1 VA: 0x2B7A3E0
	private void <MyStart>b__13_0(Character _) { }
}

