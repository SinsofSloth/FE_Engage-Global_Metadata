// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273900 Offset: 0x273A01 VA: 0x273900
[Serializable]
public class CameraControllerFreeCamera : BaseCameraController // TypeDefIndex: 8539
{
	// Fields
	private Vector3 CameraPosFromChara; // 0xA8
	private Vector3 LookDirection; // 0xB4

	// Methods

	// RVA: 0x299D3C0 Offset: 0x299D4C1 VA: 0x299D3C0 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299D470 Offset: 0x299D571 VA: 0x299D470 Slot: 10
	public override void Activate() { }

	// RVA: 0x299D550 Offset: 0x299D651 VA: 0x299D550 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299D5A0 Offset: 0x299D6A1 VA: 0x299D5A0
	public void .ctor() { }
}

