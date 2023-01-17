// Namespace: Cinemachine
[SaveDuringPlayAttribute] // RVA: 0x1B940 Offset: 0x1BA41 VA: 0x1B940
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 5851
{
	// Fields
	[SerializeField] // RVA: 0x21B80 Offset: 0x21C81 VA: 0x21B80
	[HideInInspector] // RVA: 0x21B80 Offset: 0x21C81 VA: 0x21B80
	[NoSaveDuringPlayAttribute] // RVA: 0x21B80 Offset: 0x21C81 VA: 0x21B80
	public string[] m_ExcludedPropertiesInInspector; // 0x18
	[NoSaveDuringPlayAttribute] // RVA: 0x21BD0 Offset: 0x21CD1 VA: 0x21BD0
	[HideInInspector] // RVA: 0x21BD0 Offset: 0x21CD1 VA: 0x21BD0
	[SerializeField] // RVA: 0x21BD0 Offset: 0x21CD1 VA: 0x21BD0
	public CinemachineCore.Stage[] m_LockStageInInspector; // 0x20
	private int m_ValidatingStreamVersion; // 0x28
	private bool m_OnValidateCalled; // 0x2C
	[NoSaveDuringPlayAttribute] // RVA: 0x21C20 Offset: 0x21D21 VA: 0x21C20
	[SerializeField] // RVA: 0x21C20 Offset: 0x21D21 VA: 0x21C20
	[HideInInspector] // RVA: 0x21C20 Offset: 0x21D21 VA: 0x21C20
	private int m_StreamingVersion; // 0x30
	[NoSaveDuringPlayAttribute] // RVA: 0x21C70 Offset: 0x21D71 VA: 0x21C70
	[TooltipAttribute] // RVA: 0x21C70 Offset: 0x21D71 VA: 0x21C70
	public int m_Priority; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x21CC0 Offset: 0x21DC1 VA: 0x21CC0
	private float <FollowTargetAttachment>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x21CD0 Offset: 0x21DD1 VA: 0x21CD0
	private float <LookAtTargetAttachment>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x21CE0 Offset: 0x21DE1 VA: 0x21CE0
	public CinemachineVirtualCameraBase.StandbyUpdateMode m_StandbyUpdate; // 0x40
	private List<CinemachineExtension> mExtensions; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x21D20 Offset: 0x21E21 VA: 0x21D20
	private bool <PreviousStateIsValid>k__BackingField; // 0x50
	private bool m_WasStarted; // 0x51
	private bool mSlaveStatusUpdated; // 0x52
	private CinemachineVirtualCameraBase m_parentVcam; // 0x58
	private int m_QueuePriority; // 0x60

	// Properties
	public int ValidatingStreamVersion { get; set; }
	public float FollowTargetAttachment { get; set; }
	public float LookAtTargetAttachment { get; set; }
	public string Name { get; }
	public virtual string Description { get; }
	public int Priority { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public abstract CameraState State { get; }
	public ICinemachineCamera ParentCamera { get; }
	public abstract Transform LookAt { get; set; }
	public abstract Transform Follow { get; set; }
	public virtual bool PreviousStateIsValid { get; set; }

	// Methods

	// RVA: 0x1A7C9D0 Offset: 0x1A7CAD1 VA: 0x1A7C9D0
	public int get_ValidatingStreamVersion() { }

	// RVA: 0x1A7F280 Offset: 0x1A7F381 VA: 0x1A7F280
	private void set_ValidatingStreamVersion(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23E90 Offset: 0x23F91 VA: 0x23E90
	// RVA: 0x1A7F290 Offset: 0x1A7F391 VA: 0x1A7F290
	public float get_FollowTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x23EA0 Offset: 0x23FA1 VA: 0x23EA0
	// RVA: 0x1A7F2A0 Offset: 0x1A7F3A1 VA: 0x1A7F2A0
	public void set_FollowTargetAttachment(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23EB0 Offset: 0x23FB1 VA: 0x23EB0
	// RVA: 0x1A7F2B0 Offset: 0x1A7F3B1 VA: 0x1A7F2B0
	public float get_LookAtTargetAttachment() { }

	[CompilerGeneratedAttribute] // RVA: 0x23EC0 Offset: 0x23FC1 VA: 0x23EC0
	// RVA: 0x1A7F2C0 Offset: 0x1A7F3C1 VA: 0x1A7F2C0
	public void set_LookAtTargetAttachment(float value) { }

	// RVA: 0x1A7B200 Offset: 0x1A7B301 VA: 0x1A7B200 Slot: 21
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1A798D0 Offset: 0x1A799D1 VA: 0x1A798D0
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A799C0 Offset: 0x1A79AC1 VA: 0x1A799C0
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A7F2D0 Offset: 0x1A7F3D1 VA: 0x1A7F2D0
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A7F370 Offset: 0x1A7F471 VA: 0x1A7F370
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A7F460 Offset: 0x1A7F561 VA: 0x1A7F460
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	// RVA: 0x1A7F560 Offset: 0x1A7F661 VA: 0x1A7F560
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	// RVA: 0x1A7F600 Offset: 0x1A7F701 VA: 0x1A7F600 Slot: 22
	public virtual void AddExtension(CinemachineExtension extension) { }

	// RVA: 0x1A7F6E0 Offset: 0x1A7F7E1 VA: 0x1A7F6E0 Slot: 23
	public virtual void RemoveExtension(CinemachineExtension extension) { }

	// RVA: 0x1A7E2B0 Offset: 0x1A7E3B1 VA: 0x1A7E2B0
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A7E0A0 Offset: 0x1A7E1A1 VA: 0x1A7E0A0
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	// RVA: 0x1A7EE50 Offset: 0x1A7EF51 VA: 0x1A7EE50
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A7F790 Offset: 0x1A7F891 VA: 0x1A7F790 Slot: 4
	public string get_Name() { }

	// RVA: 0x1A7F7A0 Offset: 0x1A7F8A1 VA: 0x1A7F7A0 Slot: 24
	public virtual string get_Description() { }

	// RVA: 0x1A7F7F0 Offset: 0x1A7F8F1 VA: 0x1A7F7F0 Slot: 6
	public int get_Priority() { }

	// RVA: 0x1A7F800 Offset: 0x1A7F901 VA: 0x1A7F800 Slot: 7
	public void set_Priority(int value) { }

	// RVA: 0x1A7C110 Offset: 0x1A7C211 VA: 0x1A7C110
	protected void ApplyPositionBlendMethod(ref CameraState state, CinemachineVirtualCameraBase.BlendHint hint) { }

	// RVA: 0x1A7F810 Offset: 0x1A7F911 VA: 0x1A7F810 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A7F8B0 Offset: 0x1A7F9B1 VA: 0x1A7F8B0 Slot: 14
	public bool get_IsValid() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract CameraState get_State();

	// RVA: 0x1A7F750 Offset: 0x1A7F851 VA: 0x1A7F750 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A7FA10 Offset: 0x1A7FB11 VA: 0x1A7FA10 Slot: 26
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Transform get_LookAt();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_LookAt(Transform value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Transform get_Follow();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Follow(Transform value);

	[CompilerGeneratedAttribute] // RVA: 0x23ED0 Offset: 0x23FD1 VA: 0x23ED0
	// RVA: 0x1A7FA20 Offset: 0x1A7FB21 VA: 0x1A7FA20 Slot: 31
	public virtual bool get_PreviousStateIsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x23EE0 Offset: 0x23FE1 VA: 0x23EE0
	// RVA: 0x1A7FA30 Offset: 0x1A7FB31 VA: 0x1A7FA30 Slot: 32
	public virtual void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1A7EFE0 Offset: 0x1A7F0E1 VA: 0x1A7EFE0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);

	// RVA: 0x1A7EE00 Offset: 0x1A7EF01 VA: 0x1A7EE00 Slot: 34
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A7CE70 Offset: 0x1A7CF71 VA: 0x1A7CE70 Slot: 35
	protected virtual void OnDestroy() { }

	// RVA: 0x1A7FA40 Offset: 0x1A7FB41 VA: 0x1A7FA40 Slot: 36
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1A7FBE0 Offset: 0x1A7FCE1 VA: 0x1A7FBE0 Slot: 37
	protected virtual void Start() { }

	// RVA: 0x1A7FBF0 Offset: 0x1A7FCF1 VA: 0x1A7FBF0
	internal void EnsureStarted() { }

	// RVA: 0x1A7FCB0 Offset: 0x1A7FDB1 VA: 0x1A7FCB0
	public AxisState.IInputAxisProvider GetInputAxisProvider() { }

	// RVA: 0x1A7CFF0 Offset: 0x1A7D0F1 VA: 0x1A7CFF0 Slot: 38
	protected virtual void OnValidate() { }

	// RVA: 0x1A7C460 Offset: 0x1A7C561 VA: 0x1A7C460 Slot: 39
	protected virtual void OnEnable() { }

	// RVA: 0x1A7FD70 Offset: 0x1A7FE71 VA: 0x1A7FD70 Slot: 40
	protected virtual void OnDisable() { }

	// RVA: 0x1A7FDF0 Offset: 0x1A7FEF1 VA: 0x1A7FDF0 Slot: 41
	protected virtual void Update() { }

	// RVA: 0x1A7F930 Offset: 0x1A7FA31 VA: 0x1A7F930
	private void UpdateSlaveStatus() { }

	// RVA: 0x1A7AE00 Offset: 0x1A7AF01 VA: 0x1A7AE00
	protected Transform ResolveLookAt(Transform localLookAt) { }

	// RVA: 0x1A7AF60 Offset: 0x1A7B061 VA: 0x1A7AF60
	protected Transform ResolveFollow(Transform localFollow) { }

	// RVA: 0x1A7FAE0 Offset: 0x1A7FBE1 VA: 0x1A7FAE0
	private void UpdateVcamPoolStatus() { }

	// RVA: 0x1A7FE10 Offset: 0x1A7FF11 VA: 0x1A7FE10
	public void MoveToTopOfPrioritySubqueue() { }

	// RVA: 0x1A7E6D0 Offset: 0x1A7E7D1 VA: 0x1A7E6D0 Slot: 42
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A7E9B0 Offset: 0x1A7EAB1 VA: 0x1A7E9B0 Slot: 43
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A7FE20 Offset: 0x1A7FF21 VA: 0x1A7FE20
	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	// RVA: 0x1A7C6D0 Offset: 0x1A7C7D1 VA: 0x1A7C6D0
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	// RVA: 0x1A7F180 Offset: 0x1A7F281 VA: 0x1A7F180
	protected void .ctor() { }
}

