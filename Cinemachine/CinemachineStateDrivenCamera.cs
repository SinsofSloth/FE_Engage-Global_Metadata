// Namespace: Cinemachine
[ExecuteAlways] // RVA: 0x1AF20 Offset: 0x1B021 VA: 0x1AF20
[ExcludeFromPresetAttribute] // RVA: 0x1AF20 Offset: 0x1B021 VA: 0x1AF20
[AddComponentMenu] // RVA: 0x1AF20 Offset: 0x1B021 VA: 0x1AF20
[HelpURLAttribute] // RVA: 0x1AF20 Offset: 0x1B021 VA: 0x1AF20
[DisallowMultipleComponent] // RVA: 0x1AF20 Offset: 0x1B021 VA: 0x1AF20
[DocumentationSortingAttribute] // RVA: 0x1AF20 Offset: 0x1B021 VA: 0x1AF20
public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 5768
{
	// Fields
	[TooltipAttribute] // RVA: 0x1DED0 Offset: 0x1DFD1 VA: 0x1DED0
	[NoSaveDuringPlayAttribute] // RVA: 0x1DED0 Offset: 0x1DFD1 VA: 0x1DED0
	[VcamTargetPropertyAttribute] // RVA: 0x1DED0 Offset: 0x1DFD1 VA: 0x1DED0
	public Transform m_LookAt; // 0x68
	[VcamTargetPropertyAttribute] // RVA: 0x1DF30 Offset: 0x1E031 VA: 0x1DF30
	[NoSaveDuringPlayAttribute] // RVA: 0x1DF30 Offset: 0x1E031 VA: 0x1DF30
	[TooltipAttribute] // RVA: 0x1DF30 Offset: 0x1E031 VA: 0x1DF30
	public Transform m_Follow; // 0x70
	[SpaceAttribute] // RVA: 0x1DF90 Offset: 0x1E091 VA: 0x1DF90
	[TooltipAttribute] // RVA: 0x1DF90 Offset: 0x1E091 VA: 0x1DF90
	[NoSaveDuringPlayAttribute] // RVA: 0x1DF90 Offset: 0x1E091 VA: 0x1DF90
	public Animator m_AnimatedTarget; // 0x78
	[TooltipAttribute] // RVA: 0x1DFF0 Offset: 0x1E0F1 VA: 0x1DFF0
	[NoSaveDuringPlayAttribute] // RVA: 0x1DFF0 Offset: 0x1E0F1 VA: 0x1DFF0
	public int m_LayerIndex; // 0x80
	[TooltipAttribute] // RVA: 0x1E040 Offset: 0x1E141 VA: 0x1E040
	public bool m_ShowDebugText; // 0x84
	[SerializeField] // RVA: 0x1E080 Offset: 0x1E181 VA: 0x1E080
	[NoSaveDuringPlayAttribute] // RVA: 0x1E080 Offset: 0x1E181 VA: 0x1E080
	[HideInInspector] // RVA: 0x1E080 Offset: 0x1E181 VA: 0x1E080
	internal CinemachineVirtualCameraBase[] m_ChildCameras; // 0x88
	[TooltipAttribute] // RVA: 0x1E0D0 Offset: 0x1E1D1 VA: 0x1E0D0
	public CinemachineStateDrivenCamera.Instruction[] m_Instructions; // 0x90
	[TooltipAttribute] // RVA: 0x1E110 Offset: 0x1E211 VA: 0x1E110
	[CinemachineBlendDefinitionPropertyAttribute] // RVA: 0x1E110 Offset: 0x1E211 VA: 0x1E110
	public CinemachineBlendDefinition m_DefaultBlend; // 0x98
	[TooltipAttribute] // RVA: 0x1E160 Offset: 0x1E261 VA: 0x1E160
	public CinemachineBlenderSettings m_CustomBlends; // 0xA8
	[SerializeField] // RVA: 0x1E1A0 Offset: 0x1E2A1 VA: 0x1E1A0
	[HideInInspector] // RVA: 0x1E1A0 Offset: 0x1E2A1 VA: 0x1E1A0
	internal CinemachineStateDrivenCamera.ParentHash[] m_ParentHash; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x1E1E0 Offset: 0x1E2E1 VA: 0x1E1E0
	private ICinemachineCamera <LiveChild>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x1E1F0 Offset: 0x1E2F1 VA: 0x1E1F0
	private ICinemachineCamera <TransitioningFrom>k__BackingField; // 0xC0
	private CameraState m_State; // 0xC8
	private Dictionary<AnimationClip, List<CinemachineStateDrivenCamera.HashPair>> mHashCache; // 0x1A8
	private float mActivationTime; // 0x1B0
	private CinemachineStateDrivenCamera.Instruction mActiveInstruction; // 0x1B8
	private float mPendingActivationTime; // 0x1D0
	private CinemachineStateDrivenCamera.Instruction mPendingInstruction; // 0x1D8
	private CinemachineBlend mActiveBlend; // 0x1F0
	private Dictionary<int, int> mInstructionDictionary; // 0x1F8
	private Dictionary<int, int> mStateParentLookup; // 0x200
	private List<AnimatorClipInfo> m_clipInfoList; // 0x208

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

	// RVA: 0x1BA86D0 Offset: 0x1BA87D1 VA: 0x1BA86D0 Slot: 24
	public override string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x23660 Offset: 0x23761 VA: 0x23660
	// RVA: 0x1BA8830 Offset: 0x1BA8931 VA: 0x1BA8830
	public void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23670 Offset: 0x23771 VA: 0x23670
	// RVA: 0x1BA8840 Offset: 0x1BA8941 VA: 0x1BA8840
	public ICinemachineCamera get_LiveChild() { }

	// RVA: 0x1BA8850 Offset: 0x1BA8951 VA: 0x1BA8850 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1BA8880 Offset: 0x1BA8981 VA: 0x1BA8880 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1BA8890 Offset: 0x1BA8991 VA: 0x1BA8890 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1BA88A0 Offset: 0x1BA89A1 VA: 0x1BA88A0 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1BA88B0 Offset: 0x1BA89B1 VA: 0x1BA88B0 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1BA88C0 Offset: 0x1BA89C1 VA: 0x1BA88C0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1BA88D0 Offset: 0x1BA89D1 VA: 0x1BA88D0 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1BA8BB0 Offset: 0x1BA8CB1 VA: 0x1BA8BB0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1BA8CB0 Offset: 0x1BA8DB1 VA: 0x1BA8CB0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGeneratedAttribute] // RVA: 0x23680 Offset: 0x23781 VA: 0x23680
	// RVA: 0x1BA8D50 Offset: 0x1BA8E51 VA: 0x1BA8D50
	private ICinemachineCamera get_TransitioningFrom() { }

	[CompilerGeneratedAttribute] // RVA: 0x23690 Offset: 0x23791 VA: 0x23690
	// RVA: 0x1BA8D60 Offset: 0x1BA8E61 VA: 0x1BA8D60
	private void set_TransitioningFrom(ICinemachineCamera value) { }

	// RVA: 0x1BA8D70 Offset: 0x1BA8E71 VA: 0x1BA8D70 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1BA9920 Offset: 0x1BA9A21 VA: 0x1BA9920 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1BA9AF0 Offset: 0x1BA9BF1 VA: 0x1BA9AF0 Slot: 40
	protected override void OnDisable() { }

	// RVA: 0x1BA9BE0 Offset: 0x1BA9CE1 VA: 0x1BA9BE0
	public void OnTransformChildrenChanged() { }

	// RVA: 0x1BA9C20 Offset: 0x1BA9D21 VA: 0x1BA9C20
	private void OnGuiHandler() { }

	// RVA: 0x1BA9E40 Offset: 0x1BA9F41 VA: 0x1BA9E40
	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	// RVA: 0x1BA9E70 Offset: 0x1BA9F71 VA: 0x1BA9E70
	public bool get_IsBlending() { }

	// RVA: 0x1BA9E80 Offset: 0x1BA9F81 VA: 0x1BA9E80
	public static int CreateFakeHash(int parentHash, AnimationClip clip) { }

	// RVA: 0x1BA9F10 Offset: 0x1BAA011 VA: 0x1BA9F10
	private int LookupFakeHash(int parentHash, AnimationClip clip) { }

	// RVA: 0x1BA9AB0 Offset: 0x1BA9BB1 VA: 0x1BA9AB0
	private void InvalidateListOfChildren() { }

	// RVA: 0x1BA89A0 Offset: 0x1BA8AA1 VA: 0x1BA89A0
	private void UpdateListOfChildren() { }

	// RVA: 0x1BAA1B0 Offset: 0x1BAA2B1 VA: 0x1BAA1B0
	internal void ValidateInstructions() { }

	// RVA: 0x1BA91E0 Offset: 0x1BA92E1 VA: 0x1BA91E0
	private CinemachineVirtualCameraBase ChooseCurrentCamera() { }

	// RVA: 0x1BAA480 Offset: 0x1BAA581 VA: 0x1BAA480
	private int GetClipHash(int hash, List<AnimatorClipInfo> clips) { }

	// RVA: 0x1BA96C0 Offset: 0x1BA97C1 VA: 0x1BA96C0
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0x1BAA620 Offset: 0x1BAA721 VA: 0x1BAA620
	public void .ctor() { }
}

