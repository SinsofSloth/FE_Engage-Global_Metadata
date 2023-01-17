// Namespace: Cinemachine
[ExecuteAlways] // RVA: 0x1A5A0 Offset: 0x1A6A1 VA: 0x1A5A0
[HelpURLAttribute] // RVA: 0x1A5A0 Offset: 0x1A6A1 VA: 0x1A5A0
[AddComponentMenu] // RVA: 0x1A5A0 Offset: 0x1A6A1 VA: 0x1A5A0
[ExcludeFromPresetAttribute] // RVA: 0x1A5A0 Offset: 0x1A6A1 VA: 0x1A5A0
[DocumentationSortingAttribute] // RVA: 0x1A5A0 Offset: 0x1A6A1 VA: 0x1A5A0
[DisallowMultipleComponent] // RVA: 0x1A5A0 Offset: 0x1A6A1 VA: 0x1A5A0
public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 5732
{
	// Fields
	[VcamTargetPropertyAttribute] // RVA: 0x1C310 Offset: 0x1C411 VA: 0x1C310
	[NoSaveDuringPlayAttribute] // RVA: 0x1C310 Offset: 0x1C411 VA: 0x1C310
	[TooltipAttribute] // RVA: 0x1C310 Offset: 0x1C411 VA: 0x1C310
	public Transform m_LookAt; // 0x68
	[TooltipAttribute] // RVA: 0x1C370 Offset: 0x1C471 VA: 0x1C370
	[VcamTargetPropertyAttribute] // RVA: 0x1C370 Offset: 0x1C471 VA: 0x1C370
	[NoSaveDuringPlayAttribute] // RVA: 0x1C370 Offset: 0x1C471 VA: 0x1C370
	public Transform m_Follow; // 0x70
	[TooltipAttribute] // RVA: 0x1C3D0 Offset: 0x1C4D1 VA: 0x1C3D0
	public bool m_ShowDebugText; // 0x78
	[TooltipAttribute] // RVA: 0x1C410 Offset: 0x1C511 VA: 0x1C410
	public bool m_Loop; // 0x79
	[SerializeField] // RVA: 0x1C450 Offset: 0x1C551 VA: 0x1C450
	[NoSaveDuringPlayAttribute] // RVA: 0x1C450 Offset: 0x1C551 VA: 0x1C450
	[HideInInspector] // RVA: 0x1C450 Offset: 0x1C551 VA: 0x1C450
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x80
	[TooltipAttribute] // RVA: 0x1C4A0 Offset: 0x1C5A1 VA: 0x1C4A0
	public CinemachineBlendListCamera.Instruction[] m_Instructions; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1C4E0 Offset: 0x1C5E1 VA: 0x1C4E0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x1C4F0 Offset: 0x1C5F1 VA: 0x1C4F0
	private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0x98
	private CameraState m_State; // 0xA0
	private float mActivationTime; // 0x180
	private int mCurrentInstruction; // 0x184
	private CinemachineBlend mActiveBlend; // 0x188

	// Properties
	public override string Description { get; }
	public ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	private ICinemachineCamera TransitioningFrom { get; set; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }
	public bool IsBlending { get; }

	// Methods

	// RVA: 0x1B87520 Offset: 0x1B87621 VA: 0x1B87520 Slot: 24
	public override string get_Description() { }

	// RVA: 0x1B87680 Offset: 0x1B87781 VA: 0x1B87680
	private void Reset() { }

	[CompilerGeneratedAttribute] // RVA: 0x23460 Offset: 0x23561 VA: 0x23460
	// RVA: 0x1B876E0 Offset: 0x1B877E1 VA: 0x1B876E0
	public void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23470 Offset: 0x23571 VA: 0x23470
	// RVA: 0x1B876F0 Offset: 0x1B877F1 VA: 0x1B876F0
	public ICinemachineCamera get_LiveChild() { }

	// RVA: 0x1B87700 Offset: 0x1B87801 VA: 0x1B87700 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1B87720 Offset: 0x1B87821 VA: 0x1B87720 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1B87730 Offset: 0x1B87831 VA: 0x1B87730 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1B87740 Offset: 0x1B87841 VA: 0x1B87740 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1B87750 Offset: 0x1B87851 VA: 0x1B87750 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1B87760 Offset: 0x1B87861 VA: 0x1B87760 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1B87770 Offset: 0x1B87871 VA: 0x1B87770 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1B87A30 Offset: 0x1B87B31 VA: 0x1B87A30 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1B87B30 Offset: 0x1B87C31 VA: 0x1B87B30 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGeneratedAttribute] // RVA: 0x23480 Offset: 0x23581 VA: 0x23480
	// RVA: 0x1B87CF0 Offset: 0x1B87DF1 VA: 0x1B87CF0
	private ICinemachineCamera get_TransitioningFrom() { }

	[CompilerGeneratedAttribute] // RVA: 0x23490 Offset: 0x23591 VA: 0x23490
	// RVA: 0x1B87D00 Offset: 0x1B87E01 VA: 0x1B87D00
	private void set_TransitioningFrom(ICinemachineCamera value) { }

	// RVA: 0x1B87D10 Offset: 0x1B87E11 VA: 0x1B87D10 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B88840 Offset: 0x1B88941 VA: 0x1B88840 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1B88A20 Offset: 0x1B88B21 VA: 0x1B88A20 Slot: 40
	protected override void OnDisable() { }

	// RVA: 0x1B88B10 Offset: 0x1B88C11 VA: 0x1B88B10
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1B88B50 Offset: 0x1B88C51 VA: 0x1B88B50
	private void OnGuiHandler() { }

	// RVA: 0x1B88CE0 Offset: 0x1B88DE1 VA: 0x1B88CE0
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x1B88D10 Offset: 0x1B88E11 VA: 0x1B88D10
	public bool get_IsBlending() { }

	// RVA: 0x1B889E0 Offset: 0x1B88AE1 VA: 0x1B889E0
	private void InvalidateListOfChildren() { }

	// RVA: 0x1B87840 Offset: 0x1B87941 VA: 0x1B87840
	private void UpdateListOfChildren() { }

	// RVA: 0x1B88D20 Offset: 0x1B88E21 VA: 0x1B88D20
	internal void ValidateInstructions() { }

	// RVA: 0x1B881E0 Offset: 0x1B882E1 VA: 0x1B881E0
	private void AdvanceCurrentInstruction(float deltaTime) { }

	// RVA: 0x1B88EF0 Offset: 0x1B88FF1 VA: 0x1B88EF0
	public void .ctor() { }
}

