// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B8E0 Offset: 0x1B9E1 VA: 0x1B8E0
public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 5830
{
	// Fields
	protected const float Epsilon = 0.0001;
	private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20

	// Properties
	public CinemachineVirtualCameraBase VirtualCamera { get; }

	// Methods

	// RVA: 0x1B97770 Offset: 0x1B97871 VA: 0x1B97770
	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	// RVA: 0x1B97830 Offset: 0x1B97931 VA: 0x1B97830 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1B97840 Offset: 0x1B97941 VA: 0x1B97840 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1B97850 Offset: 0x1B97951 VA: 0x1B97850 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x1B97860 Offset: 0x1B97961 VA: 0x1B97860
	internal void EnsureStarted() { }

	// RVA: 0x1B97870 Offset: 0x1B97971 VA: 0x1B97870 Slot: 7
	protected virtual void ConnectToVcam(bool connect) { }

	// RVA: 0x1B979C0 Offset: 0x1B97AC1 VA: 0x1B979C0 Slot: 8
	public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B979D0 Offset: 0x1B97AD1 VA: 0x1B979D0
	public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);

	// RVA: 0x1B979E0 Offset: 0x1B97AE1 VA: 0x1B979E0 Slot: 10
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1B979F0 Offset: 0x1B97AF1 VA: 0x1B979F0 Slot: 11
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1B97A00 Offset: 0x1B97B01 VA: 0x1B97A00 Slot: 12
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B97A10 Offset: 0x1B97B11 VA: 0x1B97A10 Slot: 13
	public virtual float GetMaxDampTime() { }

	// RVA: -1 Offset: -1
	protected T GetExtraState<T>(ICinemachineCamera vcam) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229A640 Offset: 0x229A741 VA: 0x229A640
	|-CinemachineExtension.GetExtraState<object>
	|-CinemachineExtension.GetExtraState<CinemachineCollider.VcamExtraState>
	|-CinemachineExtension.GetExtraState<CinemachineConfiner.VcamExtraState>
	|-CinemachineExtension.GetExtraState<CinemachineFollowZoom.VcamExtraState>
	|-CinemachineExtension.GetExtraState<CinemachineVolumeSettings.VcamExtraState>
	*/

	// RVA: -1 Offset: -1
	protected List<T> GetAllExtraStates<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229A370 Offset: 0x229A471 VA: 0x229A370
	|-CinemachineExtension.GetAllExtraStates<object>
	|-CinemachineExtension.GetAllExtraStates<CinemachineCollider.VcamExtraState>
	|-CinemachineExtension.GetAllExtraStates<CinemachineVolumeSettings.VcamExtraState>
	*/

	// RVA: 0x1B97A20 Offset: 0x1B97B21 VA: 0x1B97A20
	protected void .ctor() { }
}

