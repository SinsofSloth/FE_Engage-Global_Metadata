// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273950 Offset: 0x273A51 VA: 0x273950
[Serializable]
public class CameraControllerSolo : BaseCameraController // TypeDefIndex: 8544
{
	// Fields
	[HeaderAttribute] // RVA: 0x2811C0 Offset: 0x2812C1 VA: 0x2811C0
	public float Distance; // 0xA8
	[HeaderAttribute] // RVA: 0x281200 Offset: 0x281301 VA: 0x281200
	public int TargetSide; // 0xAC
	[HeaderAttribute] // RVA: 0x281240 Offset: 0x281341 VA: 0x281240
	public CameraPositionData.TargetJoint FollowJoint; // 0xB0
	[HeaderAttribute] // RVA: 0x281280 Offset: 0x281381 VA: 0x281280
	public Vector3 FollowVector; // 0xB4
	[HeaderAttribute] // RVA: 0x2812C0 Offset: 0x2813C1 VA: 0x2812C0
	public Vector3 FollowVectorBigDragonLeg; // 0xC0
	[HeaderAttribute] // RVA: 0x281300 Offset: 0x281401 VA: 0x281300
	public Vector3 FollowVectorBigDragonFly; // 0xCC
	[HeaderAttribute] // RVA: 0x281340 Offset: 0x281441 VA: 0x281340
	public CameraPositionData.TargetJoint LookAtJoint; // 0xD8
	[HeaderAttribute] // RVA: 0x281380 Offset: 0x281481 VA: 0x281380
	public Vector3 LookAtVector; // 0xDC
	[HeaderAttribute] // RVA: 0x2813C0 Offset: 0x2814C1 VA: 0x2813C0
	public Vector3 LookAtVectorBigDragonLeg; // 0xE8
	[HeaderAttribute] // RVA: 0x281400 Offset: 0x281501 VA: 0x281400
	public Vector3 LookAtVectorBigDragonFly; // 0xF4
	[HeaderAttribute] // RVA: 0x281440 Offset: 0x281541 VA: 0x281440
	public bool LookCenterAndLookAt; // 0x100
	[HeaderAttribute] // RVA: 0x281480 Offset: 0x281581 VA: 0x281480
	public bool UnusableCheck; // 0x101
	private bool m_IsCameraInverse; // 0x102
	private bool m_IsSideInverse; // 0x103

	// Properties
	private int CameraTarget { get; }

	// Methods

	// RVA: 0x299EFE0 Offset: 0x299F0E1 VA: 0x299EFE0
	private int get_CameraTarget() { }

	// RVA: 0x299F020 Offset: 0x299F121 VA: 0x299F020 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299F7A0 Offset: 0x299F8A1 VA: 0x299F7A0
	private Vector3 GetCombatVector(Vector3 vec) { }

	// RVA: 0x299F880 Offset: 0x299F981 VA: 0x299F880 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x299FAE0 Offset: 0x299FBE1 VA: 0x299FAE0 Slot: 5
	public override ValueTuple<bool, bool> GetInverse() { }

	// RVA: 0x299FB50 Offset: 0x299FC51 VA: 0x299FB50 Slot: 6
	public override void SetInverse(bool invSide, bool invCamera) { }

	// RVA: 0x299FBA0 Offset: 0x299FCA1 VA: 0x299FBA0 Slot: 10
	public override void Activate() { }

	// RVA: 0x299FBB0 Offset: 0x299FCB1 VA: 0x299FBB0 Slot: 11
	public override void Deactivate() { }

	// RVA: 0x299FBC0 Offset: 0x299FCC1 VA: 0x299FBC0 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299FC60 Offset: 0x299FD61 VA: 0x299FC60
	public void .ctor() { }
}

