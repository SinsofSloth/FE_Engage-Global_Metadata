// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273930 Offset: 0x273A31 VA: 0x273930
[Serializable]
public class CameraControllerSelfie : BaseCameraController // TypeDefIndex: 8542
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2810C0 Offset: 0x2811C1 VA: 0x2810C0
	private bool <IsSideInverse>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x2810D0 Offset: 0x2811D1 VA: 0x2810D0
	private bool <IsCameraInverse>k__BackingField; // 0xA9

	// Properties
	public bool IsSideInverse { get; set; }
	public bool IsCameraInverse { get; set; }
	public int TargetSide { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9720 Offset: 0x2A9821 VA: 0x2A9720
	// RVA: 0x299E5A0 Offset: 0x299E6A1 VA: 0x299E5A0
	public bool get_IsSideInverse() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9730 Offset: 0x2A9831 VA: 0x2A9730
	// RVA: 0x299E5B0 Offset: 0x299E6B1 VA: 0x299E5B0
	public void set_IsSideInverse(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9740 Offset: 0x2A9841 VA: 0x2A9740
	// RVA: 0x299E5C0 Offset: 0x299E6C1 VA: 0x299E5C0
	public bool get_IsCameraInverse() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9750 Offset: 0x2A9851 VA: 0x2A9750
	// RVA: 0x299E5D0 Offset: 0x299E6D1 VA: 0x299E5D0
	public void set_IsCameraInverse(bool value) { }

	// RVA: 0x299E5E0 Offset: 0x299E6E1 VA: 0x299E5E0
	public int get_TargetSide() { }

	// RVA: 0x299E5F0 Offset: 0x299E6F1 VA: 0x299E5F0 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299EA30 Offset: 0x299EB31 VA: 0x299EA30 Slot: 10
	public override void Activate() { }

	// RVA: 0x299EA40 Offset: 0x299EB41 VA: 0x299EA40 Slot: 11
	public override void Deactivate() { }

	// RVA: 0x299EA50 Offset: 0x299EB51 VA: 0x299EA50 Slot: 5
	public override ValueTuple<bool, bool> GetInverse() { }

	// RVA: 0x299EAC0 Offset: 0x299EBC1 VA: 0x299EAC0 Slot: 6
	public override void SetInverse(bool invSide, bool invCamera) { }

	// RVA: 0x299EAE0 Offset: 0x299EBE1 VA: 0x299EAE0 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299EB30 Offset: 0x299EC31 VA: 0x299EB30
	public void .ctor() { }
}

