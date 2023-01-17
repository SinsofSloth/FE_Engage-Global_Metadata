// Namespace: UTJ
public class SpringBone : ISpringBone // TypeDefIndex: 6402
{
	// Fields
	[HideInInspector] // RVA: 0x5B740 Offset: 0x5B841 VA: 0x5B740
	[SerializeField] // RVA: 0x5B740 Offset: 0x5B841 VA: 0x5B740
	internal int index; // 0x18
	[SerializeField] // RVA: 0x5B780 Offset: 0x5B881 VA: 0x5B780
	internal bool enabledJobSystem; // 0x1C
	[SerializeField] // RVA: 0x5B790 Offset: 0x5B891 VA: 0x5B790
	public SpringCollider[] jobColliders; // 0x20
	[SerializeField] // RVA: 0x5B7A0 Offset: 0x5B8A1 VA: 0x5B7A0
	public Transform[] validChildren; // 0x28
	[RangeAttribute] // RVA: 0x5B7B0 Offset: 0x5B8B1 VA: 0x5B7B0
	public float stiffnessForce; // 0x30
	[RangeAttribute] // RVA: 0x5B7D0 Offset: 0x5B8D1 VA: 0x5B7D0
	public float dragForce; // 0x34
	public Vector3 springForce; // 0x38
	[RangeAttribute] // RVA: 0x5B7F0 Offset: 0x5B8F1 VA: 0x5B7F0
	public float windInfluence; // 0x44
	public Transform pivotNode; // 0x48
	public float angularStiffness; // 0x50
	public AngleLimits yAngleLimits; // 0x58
	public AngleLimits zAngleLimits; // 0x60
	public Transform[] lengthLimitTargets; // 0x68
	[RangeAttribute] // RVA: 0x5B810 Offset: 0x5B911 VA: 0x5B810
	public float radius; // 0x70
	public SpringSphereCollider[] sphereColliders; // 0x78
	public SpringCapsuleCollider[] capsuleColliders; // 0x80
	public SpringPanelCollider[] panelColliders; // 0x88
	private SpringManager manager; // 0x90
	private Vector3 boneAxis; // 0x98
	private float springLength; // 0xA4
	private Quaternion skinAnimationLocalRotation; // 0xA8
	private Quaternion initialLocalRotation; // 0xB8
	private Quaternion actualLocalRotation; // 0xC8
	private Vector3 currTipPos; // 0xD8
	private Vector3 prevTipPos; // 0xE4
	private float[] lengthsToLimitTargets; // 0xF0

	// Properties
	public Vector3 CurrentTipPosition { get; }

	// Methods

	// RVA: 0x310CFC0 Offset: 0x310D0C1 VA: 0x310CFC0
	public Vector3 get_CurrentTipPosition() { }

	// RVA: 0x310CFD0 Offset: 0x310D0D1 VA: 0x310CFD0
	public void Stabilize() { }

	// RVA: 0x310CFF0 Offset: 0x310D0F1 VA: 0x310CFF0
	public void Initialize(SpringManager owner) { }

	// RVA: 0x310D550 Offset: 0x310D651 VA: 0x310D550
	public Vector3 ComputeChildPosition() { }

	// RVA: 0x310DB00 Offset: 0x310DC01 VA: 0x310DB00
	public void RemoveAllColliders() { }

	// RVA: 0x310DBD0 Offset: 0x310DCD1 VA: 0x310DBD0
	public void UpdateSpring(float deltaTime, Vector3 externalForce) { }

	// RVA: 0x310DE60 Offset: 0x310DF61 VA: 0x310DE60
	public void SatisfyConstraintsAndComputeRotation(float deltaTime, float dynamicRatio) { }

	// RVA: 0x310E8D0 Offset: 0x310E9D1 VA: 0x310E8D0
	public void ComputeRotation(float dynamicRatio) { }

	// RVA: 0x310EA50 Offset: 0x310EB51 VA: 0x310EA50
	public Transform GetPivotTransform() { }

	// RVA: 0x310D9A0 Offset: 0x310DAA1 VA: 0x310D9A0
	private static IList<Transform> GetValidChildren(Transform parent) { }

	// RVA: 0x310E590 Offset: 0x310E691 VA: 0x310E590
	private void ApplyAngleLimits(float deltaTime) { }

	// RVA: 0x310E1B0 Offset: 0x310E2B1 VA: 0x310E1B0
	private bool CheckForCollision() { }

	// RVA: 0x310EF70 Offset: 0x310F071 VA: 0x310EF70
	private bool CheckForGroundCollision() { }

	// RVA: 0x310F0C0 Offset: 0x310F1C1 VA: 0x310F0C0
	private Vector3 FixBoneLength(Vector3 headPosition, Vector3 tailPosition, float minLength, float maxLength) { }

	// RVA: 0x310D830 Offset: 0x310D931 VA: 0x310D830
	public void InitializeSpringLengthAndTipPosition() { }

	// RVA: 0x310F1B0 Offset: 0x310F2B1 VA: 0x310F1B0
	public void ResetSpringLengthAndTipPosition() { }

	// RVA: 0x310E7B0 Offset: 0x310E8B1 VA: 0x310E7B0
	private Quaternion ComputeRotation(Vector3 tipPosition) { }

	// RVA: 0x310E030 Offset: 0x310E131 VA: 0x310E030
	private Vector3 ApplyLengthLimits(float deltaTime) { }

	// RVA: 0x310F2E0 Offset: 0x310F3E1 VA: 0x310F2E0
	public void .ctor() { }
}

