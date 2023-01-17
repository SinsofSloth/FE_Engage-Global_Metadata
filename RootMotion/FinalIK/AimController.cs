// Namespace: RootMotion.FinalIK
public class AimController : MonoBehaviour // TypeDefIndex: 14441
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A3CE0 Offset: 0x2A3DE1 VA: 0x2A3CE0
	public AimIK ik; // 0x18
	[TooltipAttribute] // RVA: 0x2A3D20 Offset: 0x2A3E21 VA: 0x2A3D20
	[RangeAttribute] // RVA: 0x2A3D20 Offset: 0x2A3E21 VA: 0x2A3D20
	public float weight; // 0x20
	[TooltipAttribute] // RVA: 0x2A3D80 Offset: 0x2A3E81 VA: 0x2A3D80
	[HeaderAttribute] // RVA: 0x2A3D80 Offset: 0x2A3E81 VA: 0x2A3D80
	public Transform target; // 0x28
	[TooltipAttribute] // RVA: 0x2A3DE0 Offset: 0x2A3EE1 VA: 0x2A3DE0
	public float targetSwitchSmoothTime; // 0x30
	[TooltipAttribute] // RVA: 0x2A3E20 Offset: 0x2A3F21 VA: 0x2A3E20
	public float weightSmoothTime; // 0x34
	[HeaderAttribute] // RVA: 0x2A3E60 Offset: 0x2A3F61 VA: 0x2A3E60
	[TooltipAttribute] // RVA: 0x2A3E60 Offset: 0x2A3F61 VA: 0x2A3E60
	public bool smoothTurnTowardsTarget; // 0x38
	[TooltipAttribute] // RVA: 0x2A3EC0 Offset: 0x2A3FC1 VA: 0x2A3EC0
	public float maxRadiansDelta; // 0x3C
	[TooltipAttribute] // RVA: 0x2A3F00 Offset: 0x2A4001 VA: 0x2A3F00
	public float maxMagnitudeDelta; // 0x40
	[TooltipAttribute] // RVA: 0x2A3F40 Offset: 0x2A4041 VA: 0x2A3F40
	public float slerpSpeed; // 0x44
	[TooltipAttribute] // RVA: 0x2A3F80 Offset: 0x2A4081 VA: 0x2A3F80
	public float smoothDampTime; // 0x48
	[TooltipAttribute] // RVA: 0x2A3FC0 Offset: 0x2A40C1 VA: 0x2A3FC0
	public Vector3 pivotOffsetFromRoot; // 0x4C
	[TooltipAttribute] // RVA: 0x2A4000 Offset: 0x2A4101 VA: 0x2A4000
	public float minDistance; // 0x58
	[TooltipAttribute] // RVA: 0x2A4040 Offset: 0x2A4141 VA: 0x2A4040
	public Vector3 offset; // 0x5C
	[TooltipAttribute] // RVA: 0x2A4080 Offset: 0x2A4181 VA: 0x2A4080
	[HeaderAttribute] // RVA: 0x2A4080 Offset: 0x2A4181 VA: 0x2A4080
	[RangeAttribute] // RVA: 0x2A4080 Offset: 0x2A4181 VA: 0x2A4080
	public float maxRootAngle; // 0x68
	[TooltipAttribute] // RVA: 0x2A4100 Offset: 0x2A4201 VA: 0x2A4100
	public bool turnToTarget; // 0x6C
	[TooltipAttribute] // RVA: 0x2A4140 Offset: 0x2A4241 VA: 0x2A4140
	public float turnToTargetTime; // 0x70
	[HeaderAttribute] // RVA: 0x2A4180 Offset: 0x2A4281 VA: 0x2A4180
	[TooltipAttribute] // RVA: 0x2A4180 Offset: 0x2A4281 VA: 0x2A4180
	public bool useAnimatedAimDirection; // 0x74
	[TooltipAttribute] // RVA: 0x2A41E0 Offset: 0x2A42E1 VA: 0x2A41E0
	public Vector3 animatedAimDirection; // 0x78
	private Transform lastTarget; // 0x88
	private float switchWeight; // 0x90
	private float switchWeightV; // 0x94
	private float weightV; // 0x98
	private Vector3 lastPosition; // 0x9C
	private Vector3 dir; // 0xA8
	private bool lastSmoothTowardsTarget; // 0xB4
	private bool turningToTarget; // 0xB5
	private float turnToTargetMlp; // 0xB8
	private float turnToTargetMlpV; // 0xBC
	private float yawV; // 0xC0
	private float pitchV; // 0xC4
	private float dirMagV; // 0xC8

	// Properties
	private Vector3 pivot { get; }

	// Methods

	// RVA: 0x2ECA700 Offset: 0x2ECA801 VA: 0x2ECA700
	private void Start() { }

	// RVA: 0x2ECA850 Offset: 0x2ECA951 VA: 0x2ECA850
	private void LateUpdate() { }

	// RVA: 0x2ECA7D0 Offset: 0x2ECA8D1 VA: 0x2ECA7D0
	private Vector3 get_pivot() { }

	// RVA: 0x2ECB020 Offset: 0x2ECB121 VA: 0x2ECB020
	private void ApplyMinDistance() { }

	// RVA: 0x2ECB130 Offset: 0x2ECB231 VA: 0x2ECB130
	private void RootRotation() { }

	[IteratorStateMachineAttribute] // RVA: 0x2D08E0 Offset: 0x2D09E1 VA: 0x2D08E0
	// RVA: 0x2ECB440 Offset: 0x2ECB541 VA: 0x2ECB440
	private IEnumerator TurnToTarget() { }

	// RVA: 0x2ECB4C0 Offset: 0x2ECB5C1 VA: 0x2ECB4C0
	public void .ctor() { }
}

