// Namespace: Cinemachine
internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 5819
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x21610 Offset: 0x21711 VA: 0x21610
	private CinemachineBlend <Blend>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x21620 Offset: 0x21721 VA: 0x21620
	private int <Priority>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x21630 Offset: 0x21731 VA: 0x21630
	private Transform <LookAt>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x21640 Offset: 0x21741 VA: 0x21640
	private Transform <Follow>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x21650 Offset: 0x21751 VA: 0x21650
	private CameraState <State>k__BackingField; // 0x30

	// Properties
	public CinemachineBlend Blend { get; set; }
	public string Name { get; }
	public string Description { get; }
	public int Priority { get; set; }
	public Transform LookAt { get; set; }
	public Transform Follow { get; set; }
	public CameraState State { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: 0x1B818E0 Offset: 0x1B819E1 VA: 0x1B818E0
	public void .ctor(CinemachineBlend blend) { }

	[CompilerGeneratedAttribute] // RVA: 0x23D80 Offset: 0x23E81 VA: 0x23D80
	// RVA: 0x1B81920 Offset: 0x1B81A21 VA: 0x1B81920
	public CinemachineBlend get_Blend() { }

	[CompilerGeneratedAttribute] // RVA: 0x23D90 Offset: 0x23E91 VA: 0x23D90
	// RVA: 0x1B81930 Offset: 0x1B81A31 VA: 0x1B81930
	public void set_Blend(CinemachineBlend value) { }

	// RVA: 0x1B81940 Offset: 0x1B81A41 VA: 0x1B81940 Slot: 4
	public string get_Name() { }

	// RVA: 0x1B81990 Offset: 0x1B81A91 VA: 0x1B81990 Slot: 5
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x23DA0 Offset: 0x23EA1 VA: 0x23DA0
	// RVA: 0x1B81DB0 Offset: 0x1B81EB1 VA: 0x1B81DB0 Slot: 6
	public int get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x23DB0 Offset: 0x23EB1 VA: 0x23DB0
	// RVA: 0x1B81DC0 Offset: 0x1B81EC1 VA: 0x1B81DC0 Slot: 7
	public void set_Priority(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23DC0 Offset: 0x23EC1 VA: 0x23DC0
	// RVA: 0x1B81DD0 Offset: 0x1B81ED1 VA: 0x1B81DD0 Slot: 8
	public Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x23DD0 Offset: 0x23ED1 VA: 0x23DD0
	// RVA: 0x1B81DE0 Offset: 0x1B81EE1 VA: 0x1B81DE0 Slot: 9
	public void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23DE0 Offset: 0x23EE1 VA: 0x23DE0
	// RVA: 0x1B81DF0 Offset: 0x1B81EF1 VA: 0x1B81DF0 Slot: 10
	public Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x23DF0 Offset: 0x23EF1 VA: 0x23DF0
	// RVA: 0x1B81E00 Offset: 0x1B81F01 VA: 0x1B81E00 Slot: 11
	public void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23E00 Offset: 0x23F01 VA: 0x23E00
	// RVA: 0x1B81E10 Offset: 0x1B81F11 VA: 0x1B81E10 Slot: 12
	public CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x23E10 Offset: 0x23F11 VA: 0x23E10
	// RVA: 0x1B81E20 Offset: 0x1B81F21 VA: 0x1B81E20
	private void set_State(CameraState value) { }

	// RVA: 0x1B81E50 Offset: 0x1B81F51 VA: 0x1B81E50 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1B81E60 Offset: 0x1B81F61 VA: 0x1B81E60 Slot: 14
	public bool get_IsValid() { }

	// RVA: 0x1B81FC0 Offset: 0x1B820C1 VA: 0x1B81FC0 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1B81FD0 Offset: 0x1B820D1 VA: 0x1B81FD0 Slot: 16
	public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1B82010 Offset: 0x1B82111 VA: 0x1B82010
	public CameraState CalculateNewState(float deltaTime) { }

	// RVA: 0x1B82030 Offset: 0x1B82131 VA: 0x1B82030 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B82740 Offset: 0x1B82841 VA: 0x1B82740 Slot: 18
	public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B82750 Offset: 0x1B82851 VA: 0x1B82750 Slot: 19
	public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B82760 Offset: 0x1B82861 VA: 0x1B82760 Slot: 20
	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

