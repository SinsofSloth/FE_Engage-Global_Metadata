// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273910 Offset: 0x273A11 VA: 0x273910
[Serializable]
public class CameraControllerOrbital : BaseCameraController // TypeDefIndex: 8540
{
	// Fields
	[HeaderAttribute] // RVA: 0x280F00 Offset: 0x281001 VA: 0x280F00
	public CameraPositionData.TargetJoint Target; // 0xA8
	[HeaderAttribute] // RVA: 0x280F40 Offset: 0x281041 VA: 0x280F40
	public float Distance; // 0xAC
	[HeaderAttribute] // RVA: 0x280F80 Offset: 0x281081 VA: 0x280F80
	public float StartDegree; // 0xB0
	[HeaderAttribute] // RVA: 0x280FC0 Offset: 0x2810C1 VA: 0x280FC0
	public float RotateSpeed; // 0xB4
	[HeaderAttribute] // RVA: 0x281000 Offset: 0x281101 VA: 0x281000
	public float CameraHeight; // 0xB8
	[HeaderAttribute] // RVA: 0x281040 Offset: 0x281141 VA: 0x281040
	public float FOVWalk; // 0xBC
	[HeaderAttribute] // RVA: 0x281080 Offset: 0x281181 VA: 0x281080
	public float FOVRide; // 0xC0
	private float m_Rotate; // 0xC4
	private FXZ m_LookAt; // 0xC8

	// Methods

	// RVA: 0x299D5B0 Offset: 0x299D6B1 VA: 0x299D5B0 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299D750 Offset: 0x299D851 VA: 0x299D750 Slot: 10
	public override void Activate() { }

	// RVA: 0x299E0E0 Offset: 0x299E1E1 VA: 0x299E0E0 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299E130 Offset: 0x299E231 VA: 0x299E130
	public void .ctor() { }
}

