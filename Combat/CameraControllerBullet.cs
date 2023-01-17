// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2738B0 Offset: 0x2739B1 VA: 0x2738B0
[Serializable]
public class CameraControllerBullet : BaseCameraController // TypeDefIndex: 8533
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x280A60 Offset: 0x280B61 VA: 0x280A60
	private CameraControllerBullet.State <ShootState>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x280A70 Offset: 0x280B71 VA: 0x280A70
	private LaunchBehaviour <Lancher>k__BackingField; // 0xB0
	[HeaderAttribute] // RVA: 0x280A80 Offset: 0x280B81 VA: 0x280A80
	public Vector3 StartVector; // 0xB8
	[HeaderAttribute] // RVA: 0x280AC0 Offset: 0x280BC1 VA: 0x280AC0
	public Vector3 HoldVector; // 0xC4
	[HeaderAttribute] // RVA: 0x280B00 Offset: 0x280C01 VA: 0x280B00
	public Vector3 BulletVector; // 0xD0
	[RangeAttribute] // RVA: 0x280B40 Offset: 0x280C41 VA: 0x280B40
	[HeaderAttribute] // RVA: 0x280B40 Offset: 0x280C41 VA: 0x280B40
	public float SpeedBrake; // 0xDC
	private Vector3 m_LastSpeed; // 0xE0

	// Properties
	private CameraControllerBullet.State ShootState { get; set; }
	private LaunchBehaviour Lancher { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A96A0 Offset: 0x2A97A1 VA: 0x2A96A0
	// RVA: 0x299A9F0 Offset: 0x299AAF1 VA: 0x299A9F0
	private CameraControllerBullet.State get_ShootState() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A96B0 Offset: 0x2A97B1 VA: 0x2A96B0
	// RVA: 0x299AA00 Offset: 0x299AB01 VA: 0x299AA00
	private void set_ShootState(CameraControllerBullet.State value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A96C0 Offset: 0x2A97C1 VA: 0x2A96C0
	// RVA: 0x299AA10 Offset: 0x299AB11 VA: 0x299AA10
	private LaunchBehaviour get_Lancher() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A96D0 Offset: 0x2A97D1 VA: 0x2A96D0
	// RVA: 0x299AA20 Offset: 0x299AB21 VA: 0x299AA20
	private void set_Lancher(LaunchBehaviour value) { }

	// RVA: 0x299AA30 Offset: 0x299AB31 VA: 0x299AA30 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299AAE0 Offset: 0x299ABE1 VA: 0x299AAE0
	private void CheckState() { }

	// RVA: 0x299ADE0 Offset: 0x299AEE1 VA: 0x299ADE0
	private ValueTuple<Vector3, Vector3> GetPosition() { }

	// RVA: 0x299AE80 Offset: 0x299AF81 VA: 0x299AE80
	private ValueTuple<Vector3, Vector3> GetPositionReady() { }

	// RVA: 0x299AFB0 Offset: 0x299B0B1 VA: 0x299AFB0
	private ValueTuple<Vector3, Vector3> GetPositionBeforeShoot() { }

	// RVA: 0x299B0F0 Offset: 0x299B1F1 VA: 0x299B0F0
	private ValueTuple<Vector3, Vector3> GetPositionShooting() { }

	// RVA: 0x299B240 Offset: 0x299B341 VA: 0x299B240
	private ValueTuple<Vector3, Vector3> GetPositionAfterShoot() { }

	// RVA: 0x299B420 Offset: 0x299B521 VA: 0x299B420
	private Vector3 GetCombatVector(Vector3 lookAtVector) { }

	// RVA: 0x299B570 Offset: 0x299B671 VA: 0x299B570 Slot: 10
	public override void Activate() { }

	// RVA: 0x299B600 Offset: 0x299B701 VA: 0x299B600 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299B670 Offset: 0x299B771 VA: 0x299B670
	public void .ctor() { }
}

