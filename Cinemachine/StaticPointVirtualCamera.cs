// Namespace: Cinemachine
internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 5818
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x215C0 Offset: 0x216C1 VA: 0x215C0
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x215D0 Offset: 0x216D1 VA: 0x215D0
	private int <Priority>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x215E0 Offset: 0x216E1 VA: 0x215E0
	private Transform <LookAt>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x215F0 Offset: 0x216F1 VA: 0x215F0
	private Transform <Follow>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x21600 Offset: 0x21701 VA: 0x21600
	private CameraState <State>k__BackingField; // 0x30

	// Properties
	public string Name { get; set; }
	public string Description { get; }
	public int Priority { get; set; }
	public Transform LookAt { get; set; }
	public Transform Follow { get; set; }
	public CameraState State { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: 0x1A80020 Offset: 0x1A80121 VA: 0x1A80020
	public void .ctor(CameraState state, string name) { }

	// RVA: 0x1A84F00 Offset: 0x1A85001 VA: 0x1A84F00
	public void SetState(CameraState state) { }

	[CompilerGeneratedAttribute] // RVA: 0x23CE0 Offset: 0x23DE1 VA: 0x23CE0
	// RVA: 0x1A84F30 Offset: 0x1A85031 VA: 0x1A84F30 Slot: 4
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x23CF0 Offset: 0x23DF1 VA: 0x23CF0
	// RVA: 0x1A84F40 Offset: 0x1A85041 VA: 0x1A84F40
	private void set_Name(string value) { }

	// RVA: 0x1A84F50 Offset: 0x1A85051 VA: 0x1A84F50 Slot: 5
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x23D00 Offset: 0x23E01 VA: 0x23D00
	// RVA: 0x1A84FA0 Offset: 0x1A850A1 VA: 0x1A84FA0 Slot: 6
	public int get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x23D10 Offset: 0x23E11 VA: 0x23D10
	// RVA: 0x1A84FB0 Offset: 0x1A850B1 VA: 0x1A84FB0 Slot: 7
	public void set_Priority(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23D20 Offset: 0x23E21 VA: 0x23D20
	// RVA: 0x1A84FC0 Offset: 0x1A850C1 VA: 0x1A84FC0 Slot: 8
	public Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x23D30 Offset: 0x23E31 VA: 0x23D30
	// RVA: 0x1A84FD0 Offset: 0x1A850D1 VA: 0x1A84FD0 Slot: 9
	public void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23D40 Offset: 0x23E41 VA: 0x23D40
	// RVA: 0x1A84FE0 Offset: 0x1A850E1 VA: 0x1A84FE0 Slot: 10
	public Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x23D50 Offset: 0x23E51 VA: 0x23D50
	// RVA: 0x1A84FF0 Offset: 0x1A850F1 VA: 0x1A84FF0 Slot: 11
	public void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23D60 Offset: 0x23E61 VA: 0x23D60
	// RVA: 0x1A85000 Offset: 0x1A85101 VA: 0x1A85000 Slot: 12
	public CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x23D70 Offset: 0x23E71 VA: 0x23D70
	// RVA: 0x1A85010 Offset: 0x1A85111 VA: 0x1A85010
	private void set_State(CameraState value) { }

	// RVA: 0x1A85040 Offset: 0x1A85141 VA: 0x1A85040 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A85050 Offset: 0x1A85151 VA: 0x1A85050 Slot: 14
	public bool get_IsValid() { }

	// RVA: 0x1A85060 Offset: 0x1A85161 VA: 0x1A85060 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A85070 Offset: 0x1A85171 VA: 0x1A85070 Slot: 16
	public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1A85080 Offset: 0x1A85181 VA: 0x1A85080 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A85090 Offset: 0x1A85191 VA: 0x1A85090 Slot: 18
	public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A850A0 Offset: 0x1A851A1 VA: 0x1A850A0 Slot: 19
	public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A850B0 Offset: 0x1A851B1 VA: 0x1A850B0 Slot: 20
	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

