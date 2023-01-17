// Namespace: Cinemachine
[AddComponentMenu] // RVA: 0x1A530 Offset: 0x1A631 VA: 0x1A530
[ExecuteAlways] // RVA: 0x1A530 Offset: 0x1A631 VA: 0x1A530
[SaveDuringPlayAttribute] // RVA: 0x1A530 Offset: 0x1A631 VA: 0x1A530
[DisallowMultipleComponent] // RVA: 0x1A530 Offset: 0x1A631 VA: 0x1A530
public class Cinemachine3rdPersonAim : CinemachineExtension // TypeDefIndex: 5730
{
	// Fields
	[TooltipAttribute] // RVA: 0x1C1E0 Offset: 0x1C2E1 VA: 0x1C1E0
	[HeaderAttribute] // RVA: 0x1C1E0 Offset: 0x1C2E1 VA: 0x1C1E0
	public LayerMask AimCollisionFilter; // 0x28
	[TooltipAttribute] // RVA: 0x1C240 Offset: 0x1C341 VA: 0x1C240
	[TagFieldAttribute] // RVA: 0x1C240 Offset: 0x1C341 VA: 0x1C240
	public string IgnoreTag; // 0x30
	[TooltipAttribute] // RVA: 0x1C290 Offset: 0x1C391 VA: 0x1C290
	public float AimDistance; // 0x38
	[TooltipAttribute] // RVA: 0x1C2D0 Offset: 0x1C3D1 VA: 0x1C2D0
	public RectTransform AimTargetReticle; // 0x40

	// Methods

	// RVA: 0x1B84250 Offset: 0x1B84351 VA: 0x1B84250
	private void OnValidate() { }

	// RVA: 0x1B84280 Offset: 0x1B84381 VA: 0x1B84280
	private void Reset() { }

	// RVA: 0x1B84310 Offset: 0x1B84411 VA: 0x1B84310 Slot: 12
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B84470 Offset: 0x1B84571 VA: 0x1B84470
	private void DrawReticle(CinemachineBrain brain) { }

	// RVA: 0x1B84BA0 Offset: 0x1B84CA1 VA: 0x1B84BA0
	private Vector3 GetLookAtPoint(ref CameraState state) { }

	// RVA: 0x1B84E60 Offset: 0x1B84F61 VA: 0x1B84E60 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1B84F40 Offset: 0x1B85041 VA: 0x1B84F40
	public void .ctor() { }
}

// Namespace: Cinemachine
[AddComponentMenu] // RVA: 0x1B270 Offset: 0x1B371 VA: 0x1B270
[SaveDuringPlayAttribute] // RVA: 0x1B270 Offset: 0x1B371 VA: 0x1B270
public class Cinemachine3rdPersonFollow : CinemachineComponentBase // TypeDefIndex: 5782
{
	// Fields
	[TooltipAttribute] // RVA: 0x1E9E0 Offset: 0x1EAE1 VA: 0x1E9E0
	public Vector3 Damping; // 0x50
	[TooltipAttribute] // RVA: 0x1EA20 Offset: 0x1EB21 VA: 0x1EA20
	[HeaderAttribute] // RVA: 0x1EA20 Offset: 0x1EB21 VA: 0x1EA20
	public Vector3 ShoulderOffset; // 0x5C
	[TooltipAttribute] // RVA: 0x1EA80 Offset: 0x1EB81 VA: 0x1EA80
	public float VerticalArmLength; // 0x68
	[TooltipAttribute] // RVA: 0x1EAC0 Offset: 0x1EBC1 VA: 0x1EAC0
	[RangeAttribute] // RVA: 0x1EAC0 Offset: 0x1EBC1 VA: 0x1EAC0
	public float CameraSide; // 0x6C
	[TooltipAttribute] // RVA: 0x1EB20 Offset: 0x1EC21 VA: 0x1EB20
	public float CameraDistance; // 0x70
	[TooltipAttribute] // RVA: 0x1EB60 Offset: 0x1EC61 VA: 0x1EB60
	[HeaderAttribute] // RVA: 0x1EB60 Offset: 0x1EC61 VA: 0x1EB60
	public LayerMask CameraCollisionFilter; // 0x74
	[TooltipAttribute] // RVA: 0x1EBC0 Offset: 0x1ECC1 VA: 0x1EBC0
	[TagFieldAttribute] // RVA: 0x1EBC0 Offset: 0x1ECC1 VA: 0x1EBC0
	public string IgnoreTag; // 0x78
	[RangeAttribute] // RVA: 0x1EC10 Offset: 0x1ED11 VA: 0x1EC10
	[TooltipAttribute] // RVA: 0x1EC10 Offset: 0x1ED11 VA: 0x1EC10
	public float CameraRadius; // 0x80
	private Vector3 m_PreviousFollowTargetPosition; // 0x84
	private Vector3 m_DampingCorrection; // 0x90
	private float m_CamPosCollisionCorrection; // 0x9C

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1B84FB0 Offset: 0x1B850B1 VA: 0x1B84FB0
	private void OnValidate() { }

	// RVA: 0x1B85050 Offset: 0x1B85151 VA: 0x1B85050
	private void Reset() { }

	// RVA: 0x1B850D0 Offset: 0x1B851D1 VA: 0x1B850D0
	private void OnDestroy() { }

	// RVA: 0x1B85140 Offset: 0x1B85241 VA: 0x1B85140 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1B85300 Offset: 0x1B85401 VA: 0x1B85300 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1B85310 Offset: 0x1B85411 VA: 0x1B85310 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1B85350 Offset: 0x1B85451 VA: 0x1B85350 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B85530 Offset: 0x1B85631 VA: 0x1B85530
	private void PositionCamera(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B860B0 Offset: 0x1B861B1 VA: 0x1B860B0
	public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) { }

	// RVA: 0x1B85CA0 Offset: 0x1B85DA1 VA: 0x1B85CA0
	private Quaternion GetHeading(Vector3 targetForward, Vector3 up) { }

	// RVA: 0x1B85D30 Offset: 0x1B85E31 VA: 0x1B85D30
	private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand) { }

	// RVA: 0x1B85E90 Offset: 0x1B85F91 VA: 0x1B85E90
	private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float cameraRadius) { }

	// RVA: 0x1B86250 Offset: 0x1B86351 VA: 0x1B86250
	public void .ctor() { }
}

