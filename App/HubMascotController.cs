// Namespace: App
internal class HubMascotController : MonoBehaviour // TypeDefIndex: 10829
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295C50 Offset: 0x295D51 VA: 0x295C50
	private HubMascotController.Mode <CurrentMode>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x295C60 Offset: 0x295D61 VA: 0x295C60
	private Transform <Follow>k__BackingField; // 0x20
	public float FollowSpeed1; // 0x28
	public float FollowSpeed2; // 0x2C
	public float SpeedRate; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x295C70 Offset: 0x295D71 VA: 0x295C70
	private bool <IsStop>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x295C80 Offset: 0x295D81 VA: 0x295C80
	private GameObject <DefaultLookAtTarget>k__BackingField; // 0x38
	private Collider[] overlapColliders; // 0x40
	private RaycastHit[] results; // 0x48
	private Animator m_animator; // 0x50
	private float m_speed; // 0x58
	private float m_angle; // 0x5C
	private float m_lastAngle; // 0x60
	private float m_reactionCounter; // 0x64
	private float m_moveDelay; // 0x68
	private float m_distanceTime; // 0x6C
	private bool m_keepAway; // 0x70
	private bool m_reactionFirst; // 0x71
	private Vector3 m_findLast; // 0x74
	private NavMeshAgent m_agent; // 0x80
	private NavMeshPath m_path; // 0x88
	private int ObjectCollisionLayerMask; // 0x90
	private int GroundCollisionLayerMask; // 0x94

	// Properties
	public HubMascotController.Mode CurrentMode { get; set; }
	public NavMeshAgent Agent { get; }
	public Transform Follow { get; set; }
	public bool IsStop { get; set; }
	public GameObject DefaultLookAtTarget { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C2330 Offset: 0x2C2431 VA: 0x2C2330
	// RVA: 0x2BE3B70 Offset: 0x2BE3C71 VA: 0x2BE3B70
	public HubMascotController.Mode get_CurrentMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2340 Offset: 0x2C2441 VA: 0x2C2340
	// RVA: 0x2BE3B80 Offset: 0x2BE3C81 VA: 0x2BE3B80
	public void set_CurrentMode(HubMascotController.Mode value) { }

	// RVA: 0x2BE3B90 Offset: 0x2BE3C91 VA: 0x2BE3B90
	public NavMeshAgent get_Agent() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2350 Offset: 0x2C2451 VA: 0x2C2350
	// RVA: 0x2BE3BA0 Offset: 0x2BE3CA1 VA: 0x2BE3BA0
	public Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2360 Offset: 0x2C2461 VA: 0x2C2360
	// RVA: 0x2BE3BB0 Offset: 0x2BE3CB1 VA: 0x2BE3BB0
	public void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2370 Offset: 0x2C2471 VA: 0x2C2370
	// RVA: 0x2BE3BC0 Offset: 0x2BE3CC1 VA: 0x2BE3BC0
	public bool get_IsStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2380 Offset: 0x2C2481 VA: 0x2C2380
	// RVA: 0x2BE3BD0 Offset: 0x2BE3CD1 VA: 0x2BE3BD0
	public void set_IsStop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2390 Offset: 0x2C2491 VA: 0x2C2390
	// RVA: 0x2BE3BE0 Offset: 0x2BE3CE1 VA: 0x2BE3BE0
	public GameObject get_DefaultLookAtTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C23A0 Offset: 0x2C24A1 VA: 0x2C23A0
	// RVA: 0x2BE3BF0 Offset: 0x2BE3CF1 VA: 0x2BE3BF0
	public void set_DefaultLookAtTarget(GameObject value) { }

	// RVA: 0x2BE3C00 Offset: 0x2BE3D01 VA: 0x2BE3C00
	private void Awake() { }

	// RVA: 0x2BE3CF0 Offset: 0x2BE3DF1 VA: 0x2BE3CF0
	private void Start() { }

	// RVA: 0x2BE3EA0 Offset: 0x2BE3FA1 VA: 0x2BE3EA0
	public void SetBool(string paramName, bool value) { }

	// RVA: 0x2BE3EB0 Offset: 0x2BE3FB1 VA: 0x2BE3EB0
	public void Play(string animName, bool forced = False) { }

	// RVA: 0x2BE3FB0 Offset: 0x2BE40B1 VA: 0x2BE3FB0
	private void Update() { }

	// RVA: 0x2BE4000 Offset: 0x2BE4101 VA: 0x2BE4000
	private void UpdateAgent() { }

	// RVA: 0x2BE4040 Offset: 0x2BE4141 VA: 0x2BE4040
	private void UpdateTrace() { }

	// RVA: 0x2BE4D80 Offset: 0x2BE4E81 VA: 0x2BE4D80
	public void .ctor() { }
}

