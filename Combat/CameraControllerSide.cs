// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273940 Offset: 0x273A41 VA: 0x273940
[Serializable]
public class CameraControllerSide : BaseCameraController // TypeDefIndex: 8543
{
	// Fields
	[HeaderAttribute] // RVA: 0x2810E0 Offset: 0x2811E1 VA: 0x2810E0
	[TooltipAttribute] // RVA: 0x2810E0 Offset: 0x2811E1 VA: 0x2810E0
	public AnimationCurve DistanceCurve; // 0xA8
	[HeaderAttribute] // RVA: 0x281140 Offset: 0x281241 VA: 0x281140
	public float CameraHeight; // 0xB0
	[HeaderAttribute] // RVA: 0x281180 Offset: 0x281281 VA: 0x281180
	public bool CameraHeighWithTarget; // 0xB4

	// Properties
	private float MaxDistance { get; }

	// Methods

	// RVA: 0x299EB40 Offset: 0x299EC41 VA: 0x299EB40
	private float get_MaxDistance() { }

	// RVA: 0x299EBB0 Offset: 0x299ECB1 VA: 0x299EBB0 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299ED10 Offset: 0x299EE11 VA: 0x299ED10 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x299EF60 Offset: 0x299F061 VA: 0x299EF60 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299EFD0 Offset: 0x299F0D1 VA: 0x299EFD0
	public void .ctor() { }
}

