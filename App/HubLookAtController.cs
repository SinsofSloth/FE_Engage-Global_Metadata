// Namespace: App
[DisallowMultipleComponent] // RVA: 0x2771D0 Offset: 0x2772D1 VA: 0x2771D0
public class HubLookAtController : MonoBehaviour // TypeDefIndex: 10690
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294BD0 Offset: 0x294CD1 VA: 0x294BD0
	private float <FollowTime>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x294BE0 Offset: 0x294CE1 VA: 0x294BE0
	private bool <IsDisabledParam>k__BackingField; // 0x1C
	private InterpolatorFloat m_curve; // 0x20
	private LookAtIK[] m_lookAtIK; // 0x28
	private HubLookAtController.LookAtIKParam[] m_lookAtIKParam; // 0x30
	private GameObject m_lookAtTarget; // 0x38
	private Transform m_target; // 0x40
	private Vector3 m_targetPosition; // 0x48
	private Transform m_headTransform; // 0x58
	private bool m_disableFollow; // 0x60
	private bool m_verticalLimit; // 0x61
	private float m_verticalLimitValue; // 0x64
	private static HubLookAtController.LookAtIKParam DefaultParam; // 0x0

	// Properties
	public float FollowTime { get; set; }
	public bool IsDisabledParam { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0950 Offset: 0x2C0A51 VA: 0x2C0950
	// RVA: 0x2BE0330 Offset: 0x2BE0431 VA: 0x2BE0330
	public float get_FollowTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0960 Offset: 0x2C0A61 VA: 0x2C0960
	// RVA: 0x2BE0340 Offset: 0x2BE0441 VA: 0x2BE0340
	public void set_FollowTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0970 Offset: 0x2C0A71 VA: 0x2C0970
	// RVA: 0x2BE0350 Offset: 0x2BE0451 VA: 0x2BE0350
	public bool get_IsDisabledParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0980 Offset: 0x2C0A81 VA: 0x2C0980
	// RVA: 0x2BE0360 Offset: 0x2BE0461 VA: 0x2BE0360
	public void set_IsDisabledParam(bool value) { }

	// RVA: 0x2BE0370 Offset: 0x2BE0471 VA: 0x2BE0370
	public void SetTargetTransform(Transform target) { }

	// RVA: 0x2BE0380 Offset: 0x2BE0481 VA: 0x2BE0380
	public void SetTargetPosition(Vector3 position) { }

	// RVA: 0x2BE0390 Offset: 0x2BE0491 VA: 0x2BE0390
	public void DisableFollow() { }

	// RVA: 0x2BE03C0 Offset: 0x2BE04C1 VA: 0x2BE03C0
	public void EnableFollow() { }

	// RVA: 0x2BE03F0 Offset: 0x2BE04F1 VA: 0x2BE03F0
	public void Instant() { }

	// RVA: 0x2BE09A0 Offset: 0x2BE0AA1 VA: 0x2BE09A0
	public void EnableVerticalLimit() { }

	// RVA: 0x2BE09B0 Offset: 0x2BE0AB1 VA: 0x2BE09B0
	public void DisableVerticalLimit() { }

	// RVA: 0x2BE09C0 Offset: 0x2BE0AC1 VA: 0x2BE09C0
	private void Awake() { }

	// RVA: 0x2BE0CA0 Offset: 0x2BE0DA1 VA: 0x2BE0CA0
	private void Start() { }

	// RVA: 0x2BE0510 Offset: 0x2BE0611 VA: 0x2BE0510
	private void Update() { }

	// RVA: 0x2BE0D50 Offset: 0x2BE0E51 VA: 0x2BE0D50
	private void OnDrawGizmos() { }

	// RVA: 0x2BE0E10 Offset: 0x2BE0F11 VA: 0x2BE0E10
	private void OnDestroy() { }

	// RVA: 0x2BE0ED0 Offset: 0x2BE0FD1 VA: 0x2BE0ED0
	public void .ctor() { }

	// RVA: 0x2BE0F60 Offset: 0x2BE1061 VA: 0x2BE0F60
	private static void .cctor() { }
}

