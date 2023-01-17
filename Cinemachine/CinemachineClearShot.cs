// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1A750 Offset: 0x1A851 VA: 0x1A750
[ExecuteAlways] // RVA: 0x1A750 Offset: 0x1A851 VA: 0x1A750
[ExcludeFromPresetAttribute] // RVA: 0x1A750 Offset: 0x1A851 VA: 0x1A750
[AddComponentMenu] // RVA: 0x1A750 Offset: 0x1A851 VA: 0x1A750
[HelpURLAttribute] // RVA: 0x1A750 Offset: 0x1A851 VA: 0x1A750
[DisallowMultipleComponent] // RVA: 0x1A750 Offset: 0x1A851 VA: 0x1A750
public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 5742
{
	// Fields
	[VcamTargetPropertyAttribute] // RVA: 0x1C870 Offset: 0x1C971 VA: 0x1C870
	[NoSaveDuringPlayAttribute] // RVA: 0x1C870 Offset: 0x1C971 VA: 0x1C870
	[TooltipAttribute] // RVA: 0x1C870 Offset: 0x1C971 VA: 0x1C870
	public Transform m_LookAt; // 0x68
	[NoSaveDuringPlayAttribute] // RVA: 0x1C8D0 Offset: 0x1C9D1 VA: 0x1C8D0
	[VcamTargetPropertyAttribute] // RVA: 0x1C8D0 Offset: 0x1C9D1 VA: 0x1C8D0
	[TooltipAttribute] // RVA: 0x1C8D0 Offset: 0x1C9D1 VA: 0x1C8D0
	public Transform m_Follow; // 0x70
	[NoSaveDuringPlayAttribute] // RVA: 0x1C930 Offset: 0x1CA31 VA: 0x1C930
	[TooltipAttribute] // RVA: 0x1C930 Offset: 0x1CA31 VA: 0x1C930
	public bool m_ShowDebugText; // 0x78
	[NoSaveDuringPlayAttribute] // RVA: 0x1C980 Offset: 0x1CA81 VA: 0x1C980
	[HideInInspector] // RVA: 0x1C980 Offset: 0x1CA81 VA: 0x1C980
	[SerializeField] // RVA: 0x1C980 Offset: 0x1CA81 VA: 0x1C980
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x80
	[TooltipAttribute] // RVA: 0x1C9D0 Offset: 0x1CAD1 VA: 0x1C9D0
	public float m_ActivateAfter; // 0x88
	[TooltipAttribute] // RVA: 0x1CA10 Offset: 0x1CB11 VA: 0x1CA10
	public float m_MinDuration; // 0x8C
	[TooltipAttribute] // RVA: 0x1CA50 Offset: 0x1CB51 VA: 0x1CA50
	public bool m_RandomizeChoice; // 0x90
	[TooltipAttribute] // RVA: 0x1CA90 Offset: 0x1CB91 VA: 0x1CA90
	[CinemachineBlendDefinitionPropertyAttribute] // RVA: 0x1CA90 Offset: 0x1CB91 VA: 0x1CA90
	public CinemachineBlendDefinition m_DefaultBlend; // 0x98
	[HideInInspector] // RVA: 0x1CAE0 Offset: 0x1CBE1 VA: 0x1CAE0
	public CinemachineBlenderSettings m_CustomBlends; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x1CAF0 Offset: 0x1CBF1 VA: 0x1CAF0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0xB0
	private CameraState m_State; // 0xB8
	private float mActivationTime; // 0x198
	private float mPendingActivationTime; // 0x19C
	private ICinemachineCamera mPendingCamera; // 0x1A0
	private CinemachineBlend mActiveBlend; // 0x1A8
	private bool mRandomizeNow; // 0x1B0
	private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x1B8
	[CompilerGeneratedAttribute] // RVA: 0x1CB00 Offset: 0x1CC01 VA: 0x1CB00
	private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0x1C0

	// Properties
	public override string Description { get; }
	public ICinemachineCamera LiveChild { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool IsBlending { get; }
	public CinemachineVirtualCameraBase[] ChildCameras { get; }
	private ICinemachineCamera TransitioningFrom { get; set; }

	// Methods

	// RVA: 0x1B8D150 Offset: 0x1B8D251 VA: 0x1B8D150 Slot: 24
	public override string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x23580 Offset: 0x23681 VA: 0x23580
	// RVA: 0x1B8D2B0 Offset: 0x1B8D3B1 VA: 0x1B8D2B0
	public void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23590 Offset: 0x23691 VA: 0x23590
	// RVA: 0x1B8D2C0 Offset: 0x1B8D3C1 VA: 0x1B8D2C0
	public ICinemachineCamera get_LiveChild() { }

	// RVA: 0x1B8D2D0 Offset: 0x1B8D3D1 VA: 0x1B8D2D0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1B8D2E0 Offset: 0x1B8D3E1 VA: 0x1B8D2E0 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1B8D300 Offset: 0x1B8D401 VA: 0x1B8D300 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1B8D310 Offset: 0x1B8D411 VA: 0x1B8D310 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1B8D320 Offset: 0x1B8D421 VA: 0x1B8D320 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1B8D330 Offset: 0x1B8D431 VA: 0x1B8D330 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1B8D340 Offset: 0x1B8D441 VA: 0x1B8D340 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1B8D620 Offset: 0x1B8D721 VA: 0x1B8D620 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1B8D720 Offset: 0x1B8D821 VA: 0x1B8D720 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B8E3F0 Offset: 0x1B8E4F1 VA: 0x1B8E3F0 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1B8E5E0 Offset: 0x1B8E6E1 VA: 0x1B8E5E0 Slot: 40
	protected override void OnDisable() { }

	// RVA: 0x1B8E6D0 Offset: 0x1B8E7D1 VA: 0x1B8E6D0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x1B8E720 Offset: 0x1B8E821 VA: 0x1B8E720
	private void OnGuiHandler() { }

	// RVA: 0x1B8E8B0 Offset: 0x1B8E9B1 VA: 0x1B8E8B0
	public bool get_IsBlending() { }

	// RVA: 0x1B8E8C0 Offset: 0x1B8E9C1 VA: 0x1B8E8C0
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x1B8E590 Offset: 0x1B8E691 VA: 0x1B8E590
	private void InvalidateListOfChildren() { }

	// RVA: 0x1B8E8F0 Offset: 0x1B8E9F1 VA: 0x1B8E8F0
	public void ResetRandomization() { }

	// RVA: 0x1B8D410 Offset: 0x1B8D511 VA: 0x1B8D410
	private void UpdateListOfChildren() { }

	// RVA: 0x1B8DAF0 Offset: 0x1B8DBF1 VA: 0x1B8DAF0
	private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp) { }

	// RVA: 0x1B8E930 Offset: 0x1B8EA31 VA: 0x1B8E930
	private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src) { }

	// RVA: 0x1B8E190 Offset: 0x1B8E291 VA: 0x1B8E190
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0x1B8EC00 Offset: 0x1B8ED01 VA: 0x1B8EC00 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGeneratedAttribute] // RVA: 0x235A0 Offset: 0x236A1 VA: 0x235A0
	// RVA: 0x1B8ECD0 Offset: 0x1B8EDD1 VA: 0x1B8ECD0
	private ICinemachineCamera get_TransitioningFrom() { }

	[CompilerGeneratedAttribute] // RVA: 0x235B0 Offset: 0x236B1 VA: 0x235B0
	// RVA: 0x1B8ECE0 Offset: 0x1B8EDE1 VA: 0x1B8ECE0
	private void set_TransitioningFrom(ICinemachineCamera value) { }

	// RVA: 0x1B8ECF0 Offset: 0x1B8EDF1 VA: 0x1B8ECF0
	public void .ctor() { }
}

