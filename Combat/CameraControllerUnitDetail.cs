// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273970 Offset: 0x273A71 VA: 0x273970
[Serializable]
public class CameraControllerUnitDetail : BaseCameraController // TypeDefIndex: 8550
{
	// Fields
	[HeaderAttribute] // RVA: 0x281880 Offset: 0x281981 VA: 0x281880
	public float SpeedDistance; // 0xA8
	[HeaderAttribute] // RVA: 0x2818C0 Offset: 0x2819C1 VA: 0x2818C0
	public float SpeedRotate; // 0xAC
	[HeaderAttribute] // RVA: 0x281900 Offset: 0x281A01 VA: 0x281900
	public float AccelRotate; // 0xB0
	[HeaderAttribute] // RVA: 0x281940 Offset: 0x281A41 VA: 0x281940
	public float BrakeRotate; // 0xB4
	[HeaderAttribute] // RVA: 0x281980 Offset: 0x281A81 VA: 0x281980
	public float TargetEmblemSpeed; // 0xB8
	[HeaderAttribute] // RVA: 0x2819C0 Offset: 0x281AC1 VA: 0x2819C0
	public float DistanceEmblemHideNormal; // 0xBC
	[HeaderAttribute] // RVA: 0x281A00 Offset: 0x281B01 VA: 0x281A00
	public float DistanceEmblemHideSigurd; // 0xC0
	[HeaderAttribute] // RVA: 0x281A40 Offset: 0x281B41 VA: 0x281A40
	public bool FlyingEmblemUpDown; // 0xC4
	[HeaderAttribute] // RVA: 0x281A80 Offset: 0x281B81 VA: 0x281A80
	public float AutoSpeed; // 0xC8
	[HeaderAttribute] // RVA: 0x281AC0 Offset: 0x281BC1 VA: 0x281AC0
	public int DefaultCameraPosIndex; // 0xCC
	[HeaderAttribute] // RVA: 0x281B00 Offset: 0x281C01 VA: 0x281B00
	public UnitDetailCameraPosition[] CameraPos; // 0xD0
	private float m_Front; // 0xD8
	private float m_Direction; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x281B40 Offset: 0x281C41 VA: 0x281B40
	private float <Distance>k__BackingField; // 0xE0
	private float m_LastRotateSpeed; // 0xE4
	private bool m_AutoRotate; // 0xE8
	private float m_EmblemAlpha; // 0xEC
	private float m_EmblemAlphaStep; // 0xF0
	private bool m_LookEmblem; // 0xF4
	private float m_LookEmblemRate; // 0xF8

	// Properties
	public float Distance { get; set; }
	private bool IsJointLoaded { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9860 Offset: 0x2A9961 VA: 0x2A9860
	// RVA: 0x29A1860 Offset: 0x29A1961 VA: 0x29A1860
	public float get_Distance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9870 Offset: 0x2A9971 VA: 0x2A9870
	// RVA: 0x29A1870 Offset: 0x29A1971 VA: 0x29A1870
	public void set_Distance(float value) { }

	// RVA: 0x29A1880 Offset: 0x29A1981 VA: 0x29A1880
	private bool get_IsJointLoaded() { }

	// RVA: 0x29A1980 Offset: 0x29A1A81 VA: 0x29A1980 Slot: 10
	public override void Activate() { }

	// RVA: 0x29A1C10 Offset: 0x29A1D11 VA: 0x29A1C10 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x29A2D80 Offset: 0x29A2E81 VA: 0x29A2D80
	private ValueTuple<Vector3, Vector3> GetStartPosition() { }

	// RVA: 0x29A20E0 Offset: 0x29A21E1 VA: 0x29A20E0
	private ValueTuple<Vector3, Vector3> GetPositionImpl(int tryCount = 0) { }

	// RVA: 0x29A2F90 Offset: 0x29A3091 VA: 0x29A2F90 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x29A2FE0 Offset: 0x29A30E1 VA: 0x29A2FE0
	public void .ctor() { }
}

