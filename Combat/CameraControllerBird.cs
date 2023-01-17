// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2738A0 Offset: 0x2739A1 VA: 0x2738A0
[Serializable]
public class CameraControllerBird : BaseCameraController // TypeDefIndex: 8531
{
	// Fields
	[HeaderAttribute] // RVA: 0x2809A0 Offset: 0x280AA1 VA: 0x2809A0
	public Vector3 CameraPosWalk; // 0xA8
	[HeaderAttribute] // RVA: 0x2809E0 Offset: 0x280AE1 VA: 0x2809E0
	public Vector3 CameraPosHorse; // 0xB4
	[HeaderAttribute] // RVA: 0x280A20 Offset: 0x280B21 VA: 0x280A20
	public Vector3 CameraPosFly; // 0xC0
	private float m_Time; // 0xCC
	private int m_TargetSide; // 0xD0

	// Methods

	// RVA: 0x299A360 Offset: 0x299A461 VA: 0x299A360 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299A700 Offset: 0x299A801 VA: 0x299A700
	private Vector3 GetVec(Vector3 baseVec) { }

	// RVA: 0x299A7C0 Offset: 0x299A8C1 VA: 0x299A7C0 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x299A8C0 Offset: 0x299A9C1 VA: 0x299A8C0 Slot: 10
	public override void Activate() { }

	// RVA: 0x299A8F0 Offset: 0x299A9F1 VA: 0x299A8F0 Slot: 5
	public override ValueTuple<bool, bool> GetInverse() { }

	// RVA: 0x299A960 Offset: 0x299AA61 VA: 0x299A960 Slot: 6
	public override void SetInverse(bool invSide, bool invCamera) { }

	// RVA: 0x299A970 Offset: 0x299AA71 VA: 0x299A970 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299A9E0 Offset: 0x299AAE1 VA: 0x299A9E0
	public void .ctor() { }
}

