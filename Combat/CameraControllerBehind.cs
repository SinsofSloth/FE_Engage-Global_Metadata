// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273880 Offset: 0x273981 VA: 0x273880
[Serializable]
public class CameraControllerBehind : BaseCameraController // TypeDefIndex: 8529
{
	// Fields
	[HeaderAttribute] // RVA: 0x280530 Offset: 0x280631 VA: 0x280530
	public float Distance; // 0xA8
	[HeaderAttribute] // RVA: 0x280570 Offset: 0x280671 VA: 0x280570
	public float CameraHeight; // 0xAC
	[HeaderAttribute] // RVA: 0x2805B0 Offset: 0x2806B1 VA: 0x2805B0
	public float CameraLookUp; // 0xB0
	[RangeAttribute] // RVA: 0x2805F0 Offset: 0x2806F1 VA: 0x2805F0
	[HeaderAttribute] // RVA: 0x2805F0 Offset: 0x2806F1 VA: 0x2805F0
	public float DistanceRate; // 0xB4
	[HeaderAttribute] // RVA: 0x280650 Offset: 0x280751 VA: 0x280650
	public bool SidePlayer; // 0xB8
	[HeaderAttribute] // RVA: 0x280690 Offset: 0x280791 VA: 0x280690
	public float NearUnitSize; // 0xBC
	[HeaderAttribute] // RVA: 0x2806D0 Offset: 0x2807D1 VA: 0x2806D0
	public float FarUnitSize; // 0xC0
	[HeaderAttribute] // RVA: 0x280710 Offset: 0x280811 VA: 0x280710
	public float CameraUpThreshold; // 0xC4
	private float m_BaseDegree; // 0xC8
	private float m_LastDegree; // 0xCC
	private float m_LastLookHeight; // 0xD0
	private bool m_DoCameraLookUp; // 0xD4
	private bool isValid; // 0xD5
	private bool m_IsInverse; // 0xD6
	private bool m_IsSideRev; // 0xD7
	[CompilerGeneratedAttribute] // RVA: 0x280750 Offset: 0x280851 VA: 0x280750
	private float <WidthOnCamera>k__BackingField; // 0xD8

	// Properties
	private float WidthOnCamera { get; set; }
	private int NearSide { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9680 Offset: 0x2A9781 VA: 0x2A9680
	// RVA: 0x2C857A0 Offset: 0x2C858A1 VA: 0x2C857A0
	private float get_WidthOnCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9690 Offset: 0x2A9791 VA: 0x2A9690
	// RVA: 0x2C857B0 Offset: 0x2C858B1 VA: 0x2C857B0
	private void set_WidthOnCamera(float value) { }

	// RVA: 0x2C857C0 Offset: 0x2C858C1 VA: 0x2C857C0
	private int get_NearSide() { }

	// RVA: 0x2C857E0 Offset: 0x2C858E1 VA: 0x2C857E0
	private void Start() { }

	// RVA: 0x2C858B0 Offset: 0x2C859B1 VA: 0x2C858B0
	private void Initilize() { }

	// RVA: 0x2C85980 Offset: 0x2C85A81 VA: 0x2C85980 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x2C859C0 Offset: 0x2C85AC1 VA: 0x2C859C0
	internal ValueTuple<Vector3, Vector3> GetPositionInfoImpl(float delta) { }

	// RVA: 0x2C863F0 Offset: 0x2C864F1 VA: 0x2C863F0 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x2C864C0 Offset: 0x2C865C1 VA: 0x2C864C0 Slot: 10
	public override void Activate() { }

	// RVA: 0x2C864D0 Offset: 0x2C865D1 VA: 0x2C864D0 Slot: 8
	public override void Stabilize() { }

	// RVA: 0x2C86610 Offset: 0x2C86711 VA: 0x2C86610 Slot: 5
	public override ValueTuple<bool, bool> GetInverse() { }

	// RVA: 0x2C86680 Offset: 0x2C86781 VA: 0x2C86680 Slot: 6
	public override void SetInverse(bool invSide, bool invCamera) { }

	// RVA: 0x2C86780 Offset: 0x2C86881 VA: 0x2C86780 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x2C86290 Offset: 0x2C86391 VA: 0x2C86290
	private bool IsDive() { }

	// RVA: 0x2C86330 Offset: 0x2C86431 VA: 0x2C86330
	private bool IsDragon() { }

	// RVA: 0x2C867F0 Offset: 0x2C868F1 VA: 0x2C867F0
	public void .ctor() { }
}

