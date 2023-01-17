// Namespace: Cinemachine
[DisallowMultipleComponent] // RVA: 0x1A810 Offset: 0x1A911 VA: 0x1A810
[ExecuteAlways] // RVA: 0x1A810 Offset: 0x1A911 VA: 0x1A810
[SaveDuringPlayAttribute] // RVA: 0x1A810 Offset: 0x1A911 VA: 0x1A810
[AddComponentMenu] // RVA: 0x1A810 Offset: 0x1A911 VA: 0x1A810
[DocumentationSortingAttribute] // RVA: 0x1A810 Offset: 0x1A911 VA: 0x1A810
[HelpURLAttribute] // RVA: 0x1A810 Offset: 0x1A911 VA: 0x1A810
public class CinemachineCollider : CinemachineExtension // TypeDefIndex: 5745
{
	// Fields
	[TooltipAttribute] // RVA: 0x1CB10 Offset: 0x1CC11 VA: 0x1CB10
	[HeaderAttribute] // RVA: 0x1CB10 Offset: 0x1CC11 VA: 0x1CB10
	public LayerMask m_CollideAgainst; // 0x28
	[TagFieldAttribute] // RVA: 0x1CB70 Offset: 0x1CC71 VA: 0x1CB70
	[TooltipAttribute] // RVA: 0x1CB70 Offset: 0x1CC71 VA: 0x1CB70
	public string m_IgnoreTag; // 0x30
	[TooltipAttribute] // RVA: 0x1CBC0 Offset: 0x1CCC1 VA: 0x1CBC0
	public LayerMask m_TransparentLayers; // 0x38
	[TooltipAttribute] // RVA: 0x1CC00 Offset: 0x1CD01 VA: 0x1CC00
	public float m_MinimumDistanceFromTarget; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0x1CC40 Offset: 0x1CD41 VA: 0x1CC40
	[TooltipAttribute] // RVA: 0x1CC40 Offset: 0x1CD41 VA: 0x1CC40
	[SpaceAttribute] // RVA: 0x1CC40 Offset: 0x1CD41 VA: 0x1CC40
	public bool m_AvoidObstacles; // 0x40
	[TooltipAttribute] // RVA: 0x1CCB0 Offset: 0x1CDB1 VA: 0x1CCB0
	[FormerlySerializedAsAttribute] // RVA: 0x1CCB0 Offset: 0x1CDB1 VA: 0x1CCB0
	public float m_DistanceLimit; // 0x44
	[TooltipAttribute] // RVA: 0x1CD10 Offset: 0x1CE11 VA: 0x1CD10
	public float m_MinimumOcclusionTime; // 0x48
	[TooltipAttribute] // RVA: 0x1CD50 Offset: 0x1CE51 VA: 0x1CD50
	public float m_CameraRadius; // 0x4C
	[TooltipAttribute] // RVA: 0x1CD90 Offset: 0x1CE91 VA: 0x1CD90
	public CinemachineCollider.ResolutionStrategy m_Strategy; // 0x50
	[TooltipAttribute] // RVA: 0x1CDD0 Offset: 0x1CED1 VA: 0x1CDD0
	[RangeAttribute] // RVA: 0x1CDD0 Offset: 0x1CED1 VA: 0x1CDD0
	public int m_MaximumEffort; // 0x54
	[RangeAttribute] // RVA: 0x1CE30 Offset: 0x1CF31 VA: 0x1CE30
	[TooltipAttribute] // RVA: 0x1CE30 Offset: 0x1CF31 VA: 0x1CE30
	public float m_SmoothingTime; // 0x58
	[TooltipAttribute] // RVA: 0x1CE90 Offset: 0x1CF91 VA: 0x1CE90
	[FormerlySerializedAsAttribute] // RVA: 0x1CE90 Offset: 0x1CF91 VA: 0x1CE90
	[RangeAttribute] // RVA: 0x1CE90 Offset: 0x1CF91 VA: 0x1CE90
	public float m_Damping; // 0x5C
	[TooltipAttribute] // RVA: 0x1CF10 Offset: 0x1D011 VA: 0x1CF10
	[RangeAttribute] // RVA: 0x1CF10 Offset: 0x1D011 VA: 0x1CF10
	public float m_DampingWhenOccluded; // 0x60
	[TooltipAttribute] // RVA: 0x1CF70 Offset: 0x1D071 VA: 0x1CF70
	[HeaderAttribute] // RVA: 0x1CF70 Offset: 0x1D071 VA: 0x1CF70
	public float m_OptimalTargetDistance; // 0x64
	private const float PrecisionSlush = 0.001;
	private RaycastHit[] m_CornerBuffer; // 0x68
	private const float AngleThreshold = 0.1;
	private Collider[] mColliderBuffer; // 0x70
	private static SphereCollider mCameraCollider; // 0x0
	private static GameObject mCameraColliderGameObject; // 0x8

	// Properties
	public List<List<Vector3>> DebugPaths { get; }

	// Methods

	// RVA: 0x1B8EDC0 Offset: 0x1B8EEC1 VA: 0x1B8EDC0
	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	// RVA: 0x1B8EE30 Offset: 0x1B8EF31 VA: 0x1B8EE30
	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	// RVA: 0x1B8EEA0 Offset: 0x1B8EFA1 VA: 0x1B8EEA0
	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	// RVA: 0x1B8EF10 Offset: 0x1B8F011 VA: 0x1B8EF10
	private void OnValidate() { }

	// RVA: 0x1B8EFB0 Offset: 0x1B8F0B1 VA: 0x1B8EFB0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1B8F160 Offset: 0x1B8F261 VA: 0x1B8F160
	public List<List<Vector3>> get_DebugPaths() { }

	// RVA: 0x1B8F310 Offset: 0x1B8F411 VA: 0x1B8F310 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1B8F350 Offset: 0x1B8F451 VA: 0x1B8F350 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1B8FAF0 Offset: 0x1B8FBF1 VA: 0x1B8FAF0
	private Vector3 PreserveLineOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x1B90AB0 Offset: 0x1B90BB1 VA: 0x1B90AB0
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	// RVA: 0x1B90D30 Offset: 0x1B90E31 VA: 0x1B90D30
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra) { }

	// RVA: 0x1B91400 Offset: 0x1B91501 VA: 0x1B91400
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	// RVA: 0x1B919B0 Offset: 0x1B91AB1 VA: 0x1B919B0
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	// RVA: 0x1B91B60 Offset: 0x1B91C61 VA: 0x1B91B60
	private float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	// RVA: 0x1B8EFE0 Offset: 0x1B8F0E1 VA: 0x1B8EFE0
	private static void DestroyCollider() { }

	// RVA: 0x1B8FDE0 Offset: 0x1B8FEE1 VA: 0x1B8FDE0
	private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state) { }

	// RVA: 0x1B908F0 Offset: 0x1B909F1 VA: 0x1B908F0
	private bool CheckForTargetObstructions(CameraState state) { }

	// RVA: 0x1B90650 Offset: 0x1B90751 VA: 0x1B90650
	private bool IsTargetOffscreen(CameraState state) { }

	// RVA: 0x1B92070 Offset: 0x1B92171 VA: 0x1B92070
	public void .ctor() { }
}

