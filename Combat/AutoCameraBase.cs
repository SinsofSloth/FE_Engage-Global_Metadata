// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273850 Offset: 0x273951 VA: 0x273850
internal abstract class AutoCameraBase : BaseCameraController // TypeDefIndex: 8524
{
	// Fields
	protected const float MinLongitude = -70;
	protected const float MaxLongitude = 70;
	protected const float MinLatitude = -5.5;
	protected const float MaxLatitude = 60;
	protected const float HalfLatitude = 27.25;
	[SerializeField] // RVA: 0x280070 Offset: 0x280171 VA: 0x280070
	[RangeAttribute] // RVA: 0x280070 Offset: 0x280171 VA: 0x280070
	protected float m_Longitude; // 0xA8
	[SerializeField] // RVA: 0x2800C0 Offset: 0x2801C1 VA: 0x2800C0
	[RangeAttribute] // RVA: 0x2800C0 Offset: 0x2801C1 VA: 0x2800C0
	protected float m_Latitude; // 0xAC
	[SerializeField] // RVA: 0x280110 Offset: 0x280211 VA: 0x280110
	[RangeAttribute] // RVA: 0x280110 Offset: 0x280211 VA: 0x280110
	protected float m_MinDistance; // 0xB0
	[SerializeField] // RVA: 0x280150 Offset: 0x280251 VA: 0x280150
	[RangeAttribute] // RVA: 0x280150 Offset: 0x280251 VA: 0x280150
	protected float m_FocusSide; // 0xB4
	protected Vector3 m_LastViewDir; // 0xB8
	private float m_FOV; // 0xC4
	protected Vector3 m_CameraLookUp; // 0xC8
	private const float HalfDegree = 20;
	private float HalfDegreeDot; // 0xD4

	// Methods

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void Tick();

	// RVA: 0x2610F10 Offset: 0x2611011 VA: 0x2610F10 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x2610840 Offset: 0x2610941 VA: 0x2610840
	protected bool IsSimilarAngle(Vector3 A, Vector3 B) { }

	// RVA: 0x2611370 Offset: 0x2611471 VA: 0x2611370 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x26118C0 Offset: 0x26119C1 VA: 0x26118C0
	private static float CalcFitDistance(float xdist, float fovYDeg) { }

	// RVA: 0x2611A80 Offset: 0x2611B81 VA: 0x2611A80
	private static Vector3 Reprojection(Camera cam, Vector3 A, Vector3 B, float t) { }

	// RVA: 0x2611920 Offset: 0x2611A21 VA: 0x2611920
	private static Vector3 Reprojection(ref Matrix4x4 mvp, Vector3 A, Vector3 B, float t) { }

	// RVA: 0x2611B40 Offset: 0x2611C41 VA: 0x2611B40 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x2610EE0 Offset: 0x2610FE1 VA: 0x2610EE0
	protected void .ctor() { }
}

