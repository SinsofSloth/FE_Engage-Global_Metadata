// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273870 Offset: 0x273971 VA: 0x273870
[Serializable]
public class CameraControllerAuto : BaseCameraController // TypeDefIndex: 8528
{
	// Fields
	[HeaderAttribute] // RVA: 0x2804C0 Offset: 0x2805C1 VA: 0x2804C0
	public AnimationCurve DistanceCurve; // 0xA8
	public Vector2 VirticalMinMax; // 0xB0
	public Vector2 HorizontalMinMax; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x280500 Offset: 0x280601 VA: 0x280500
	private float <TimeLength>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x280510 Offset: 0x280611 VA: 0x280510
	private CameraControllerAuto.CamRotate <Vertical>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x280520 Offset: 0x280621 VA: 0x280520
	private CameraControllerAuto.CamRotate <Horizontal>k__BackingField; // 0xD0
	private float m_Time; // 0xDC

	// Properties
	private float TimeLength { get; set; }
	private CameraControllerAuto.CamRotate Vertical { get; set; }
	private CameraControllerAuto.CamRotate Horizontal { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9620 Offset: 0x2A9721 VA: 0x2A9620
	// RVA: 0x2C84F00 Offset: 0x2C85001 VA: 0x2C84F00
	private float get_TimeLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9630 Offset: 0x2A9731 VA: 0x2A9630
	// RVA: 0x2C84F10 Offset: 0x2C85011 VA: 0x2C84F10
	private void set_TimeLength(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9640 Offset: 0x2A9741 VA: 0x2A9640
	// RVA: 0x2C84F20 Offset: 0x2C85021 VA: 0x2C84F20
	private CameraControllerAuto.CamRotate get_Vertical() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9650 Offset: 0x2A9751 VA: 0x2A9650
	// RVA: 0x2C84F30 Offset: 0x2C85031 VA: 0x2C84F30
	private void set_Vertical(CameraControllerAuto.CamRotate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9660 Offset: 0x2A9761 VA: 0x2A9660
	// RVA: 0x2C84F40 Offset: 0x2C85041 VA: 0x2C84F40
	private CameraControllerAuto.CamRotate get_Horizontal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9670 Offset: 0x2A9771 VA: 0x2A9670
	// RVA: 0x2C84F50 Offset: 0x2C85051 VA: 0x2C84F50
	private void set_Horizontal(CameraControllerAuto.CamRotate value) { }

	// RVA: 0x2C84F60 Offset: 0x2C85061 VA: 0x2C84F60 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x2C855C0 Offset: 0x2C856C1 VA: 0x2C855C0 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x2C85690 Offset: 0x2C85791 VA: 0x2C85690 Slot: 10
	public override void Activate() { }

	// RVA: 0x2C853F0 Offset: 0x2C854F1 VA: 0x2C853F0
	private void Initialize() { }

	// RVA: 0x2C85710 Offset: 0x2C85811 VA: 0x2C85710 Slot: 11
	public override void Deactivate() { }

	// RVA: 0x2C856A0 Offset: 0x2C857A1 VA: 0x2C856A0
	private CameraControllerAuto.CamRotate CreateRandom(float time, float min, float max) { }

	// RVA: 0x2C85720 Offset: 0x2C85821 VA: 0x2C85720 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x2C85790 Offset: 0x2C85891 VA: 0x2C85790
	public void .ctor() { }
}

