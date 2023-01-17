// Namespace: Cinemachine
[HelpURLAttribute] // RVA: 0x1AC30 Offset: 0x1AD31 VA: 0x1AC30
[ExcludeFromPresetAttribute] // RVA: 0x1AC30 Offset: 0x1AD31 VA: 0x1AC30
[DisallowMultipleComponent] // RVA: 0x1AC30 Offset: 0x1AD31 VA: 0x1AC30
[DocumentationSortingAttribute] // RVA: 0x1AC30 Offset: 0x1AD31 VA: 0x1AC30
[AddComponentMenu] // RVA: 0x1AC30 Offset: 0x1AD31 VA: 0x1AC30
[ExecuteAlways] // RVA: 0x1AC30 Offset: 0x1AD31 VA: 0x1AC30
public class CinemachineMixingCamera : CinemachineVirtualCameraBase // TypeDefIndex: 5758
{
	// Fields
	public const int MaxCameras = 8;
	[TooltipAttribute] // RVA: 0x1DA60 Offset: 0x1DB61 VA: 0x1DA60
	public float m_Weight0; // 0x64
	[TooltipAttribute] // RVA: 0x1DAA0 Offset: 0x1DBA1 VA: 0x1DAA0
	public float m_Weight1; // 0x68
	[TooltipAttribute] // RVA: 0x1DAE0 Offset: 0x1DBE1 VA: 0x1DAE0
	public float m_Weight2; // 0x6C
	[TooltipAttribute] // RVA: 0x1DB20 Offset: 0x1DC21 VA: 0x1DB20
	public float m_Weight3; // 0x70
	[TooltipAttribute] // RVA: 0x1DB60 Offset: 0x1DC61 VA: 0x1DB60
	public float m_Weight4; // 0x74
	[TooltipAttribute] // RVA: 0x1DBA0 Offset: 0x1DCA1 VA: 0x1DBA0
	public float m_Weight5; // 0x78
	[TooltipAttribute] // RVA: 0x1DBE0 Offset: 0x1DCE1 VA: 0x1DBE0
	public float m_Weight6; // 0x7C
	[TooltipAttribute] // RVA: 0x1DC20 Offset: 0x1DD21 VA: 0x1DC20
	public float m_Weight7; // 0x80
	private CameraState m_State; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1DC60 Offset: 0x1DD61 VA: 0x1DC60
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x1DC70 Offset: 0x1DD71 VA: 0x1DC70
	private Transform <LookAt>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x1DC80 Offset: 0x1DD81 VA: 0x1DC80
	private Transform <Follow>k__BackingField; // 0x178
	private CinemachineVirtualCameraBase[] m_ChildCameras; // 0x180
	private Dictionary<CinemachineVirtualCameraBase, int> m_indexMap; // 0x188

	// Properties
	private ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }

	// Methods

	// RVA: 0x1BA1CB0 Offset: 0x1BA1DB1 VA: 0x1BA1CB0
	public float GetWeight(int index) { }

	// RVA: 0x1BA1E30 Offset: 0x1BA1F31 VA: 0x1BA1E30
	public void SetWeight(int index, float w) { }

	// RVA: 0x1BA1F60 Offset: 0x1BA2061 VA: 0x1BA1F60
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1BA2340 Offset: 0x1BA2441 VA: 0x1BA2340
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[CompilerGeneratedAttribute] // RVA: 0x23600 Offset: 0x23701 VA: 0x23600
	// RVA: 0x1BA24A0 Offset: 0x1BA25A1 VA: 0x1BA24A0
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23610 Offset: 0x23711 VA: 0x23610
	// RVA: 0x1BA24B0 Offset: 0x1BA25B1 VA: 0x1BA24B0
	private ICinemachineCamera get_LiveChild() { }

	// RVA: 0x1BA24C0 Offset: 0x1BA25C1 VA: 0x1BA24C0 Slot: 25
	public override CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x23620 Offset: 0x23721 VA: 0x23620
	// RVA: 0x1BA24D0 Offset: 0x1BA25D1 VA: 0x1BA24D0 Slot: 27
	public override Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x23630 Offset: 0x23731 VA: 0x23630
	// RVA: 0x1BA24E0 Offset: 0x1BA25E1 VA: 0x1BA24E0 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23640 Offset: 0x23741 VA: 0x23640
	// RVA: 0x1BA24F0 Offset: 0x1BA25F1 VA: 0x1BA24F0 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x23650 Offset: 0x23751 VA: 0x23650
	// RVA: 0x1BA2500 Offset: 0x1BA2601 VA: 0x1BA2500 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1BA2510 Offset: 0x1BA2611 VA: 0x1BA2510 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1BA25E0 Offset: 0x1BA26E1 VA: 0x1BA25E0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1BA26E0 Offset: 0x1BA27E1 VA: 0x1BA26E0 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1BA2780 Offset: 0x1BA2881 VA: 0x1BA2780
	public void OnTransformChildrenChanged() { }

	// RVA: 0x1BA27D0 Offset: 0x1BA28D1 VA: 0x1BA27D0 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1BA2940 Offset: 0x1BA2A41 VA: 0x1BA2940 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1BA2AD0 Offset: 0x1BA2BD1 VA: 0x1BA2AD0
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x1BA2730 Offset: 0x1BA2831 VA: 0x1BA2730
	protected void InvalidateListOfChildren() { }

	// RVA: 0x1BA20C0 Offset: 0x1BA21C1 VA: 0x1BA20C0
	protected void ValidateListOfChildren() { }

	// RVA: 0x1BA2B00 Offset: 0x1BA2C01 VA: 0x1BA2B00 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1BA2F40 Offset: 0x1BA3041 VA: 0x1BA2F40 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1BA31B0 Offset: 0x1BA32B1 VA: 0x1BA31B0
	public void .ctor() { }
}

