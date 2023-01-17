// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B8C0 Offset: 0x1B9C1 VA: 0x1B8C0
public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 5822
{
	// Fields
	protected const float Epsilon = 0.0001;
	private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	private Transform mCachedFollowTarget; // 0x20
	private CinemachineVirtualCameraBase mCachedFollowTargetVcam; // 0x28
	private ICinemachineTargetGroup mCachedFollowTargetGroup; // 0x30
	private Transform mCachedLookAtTarget; // 0x38
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x40
	private ICinemachineTargetGroup mCachedLookAtTargetGroup; // 0x48

	// Properties
	public CinemachineVirtualCameraBase VirtualCamera { get; }
	public Transform FollowTarget { get; }
	public Transform LookAtTarget { get; }
	public ICinemachineTargetGroup AbstractFollowTargetGroup { get; }
	public CinemachineTargetGroup FollowTargetGroup { get; }
	public Vector3 FollowTargetPosition { get; }
	public Quaternion FollowTargetRotation { get; }
	public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; }
	public CinemachineTargetGroup LookAtTargetGroup { get; }
	public Vector3 LookAtTargetPosition { get; }
	public Quaternion LookAtTargetRotation { get; }
	public CameraState VcamState { get; }
	public abstract bool IsValid { get; }
	public abstract CinemachineCore.Stage Stage { get; }
	public virtual bool BodyAppliesAfterAim { get; }

	// Methods

	// RVA: 0x1B853D0 Offset: 0x1B854D1 VA: 0x1B853D0
	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	// RVA: 0x1B85250 Offset: 0x1B85351 VA: 0x1B85250
	public Transform get_FollowTarget() { }

	// RVA: 0x1B92AC0 Offset: 0x1B92BC1 VA: 0x1B92AC0
	public Transform get_LookAtTarget() { }

	// RVA: 0x1B92B70 Offset: 0x1B92C71 VA: 0x1B92B70
	private void UpdateFollowTargetCache() { }

	// RVA: 0x1B92D10 Offset: 0x1B92E11 VA: 0x1B92D10
	public ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }

	// RVA: 0x1B92E10 Offset: 0x1B92F11 VA: 0x1B92E10
	public CinemachineTargetGroup get_FollowTargetGroup() { }

	// RVA: 0x1B85830 Offset: 0x1B85931 VA: 0x1B85830
	public Vector3 get_FollowTargetPosition() { }

	// RVA: 0x1B85A10 Offset: 0x1B85B11 VA: 0x1B85A10
	public Quaternion get_FollowTargetRotation() { }

	// RVA: 0x1B92EA0 Offset: 0x1B92FA1 VA: 0x1B92EA0
	private void UpdateLookAtTargetCache() { }

	// RVA: 0x1B93040 Offset: 0x1B93141 VA: 0x1B93040
	public ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }

	// RVA: 0x1B93140 Offset: 0x1B93241 VA: 0x1B93140
	public CinemachineTargetGroup get_LookAtTargetGroup() { }

	// RVA: 0x1B931D0 Offset: 0x1B932D1 VA: 0x1B931D0
	public Vector3 get_LookAtTargetPosition() { }

	// RVA: 0x1B933B0 Offset: 0x1B934B1 VA: 0x1B933B0
	public Quaternion get_LookAtTargetRotation() { }

	// RVA: 0x1B935D0 Offset: 0x1B936D1 VA: 0x1B935D0
	public CameraState get_VcamState() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsValid();

	// RVA: 0x1B936D0 Offset: 0x1B937D1 VA: 0x1B936D0 Slot: 5
	public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract CinemachineCore.Stage get_Stage();

	// RVA: 0x1B936E0 Offset: 0x1B937E1 VA: 0x1B936E0 Slot: 7
	public virtual bool get_BodyAppliesAfterAim() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void MutateCameraState(ref CameraState curState, float deltaTime);

	// RVA: 0x1B936F0 Offset: 0x1B937F1 VA: 0x1B936F0 Slot: 9
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x1B93700 Offset: 0x1B93801 VA: 0x1B93700 Slot: 10
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1B93710 Offset: 0x1B93811 VA: 0x1B93710 Slot: 11
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1B93720 Offset: 0x1B93821 VA: 0x1B93720 Slot: 12
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1B862C0 Offset: 0x1B863C1 VA: 0x1B862C0
	protected void .ctor() { }
}

