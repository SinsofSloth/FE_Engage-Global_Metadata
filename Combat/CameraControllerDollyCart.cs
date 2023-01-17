// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2738F0 Offset: 0x2739F1 VA: 0x2738F0
[Serializable]
public class CameraControllerDollyCart : BaseCameraController // TypeDefIndex: 8538
{
	// Fields
	[HeaderAttribute] // RVA: 0x280EC0 Offset: 0x280FC1 VA: 0x280EC0
	public int FrameCount; // 0xA8
	private float m_LastHeight; // 0xAC
	private CameraControllerDollyCart.State m_State; // 0xB0
	private CinemachineSmoothPath m_Path; // 0xB8
	private CinemachineDollyCart m_Cart; // 0xC0

	// Methods

	// RVA: 0x299CD90 Offset: 0x299CE91 VA: 0x299CD90
	private void Start() { }

	// RVA: 0x299CE50 Offset: 0x299CF51 VA: 0x299CE50 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299D320 Offset: 0x299D421 VA: 0x299D320 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x299D340 Offset: 0x299D441 VA: 0x299D340 Slot: 10
	public override void Activate() { }

	// RVA: 0x299D360 Offset: 0x299D461 VA: 0x299D360 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299D3B0 Offset: 0x299D4B1 VA: 0x299D3B0
	public void .ctor() { }
}

