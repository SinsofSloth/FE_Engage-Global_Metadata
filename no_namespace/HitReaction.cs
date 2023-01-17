// Namespace: 
[Serializable]
public class HitReaction.HitPointEffector.EffectorLink // TypeDefIndex: 14452
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4870 Offset: 0x2A4971 VA: 0x2A4870
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x2A48B0 Offset: 0x2A49B1 VA: 0x2A48B0
	public float weight; // 0x14
	private Vector3 lastValue; // 0x18
	private Vector3 current; // 0x24

	// Methods

	// RVA: 0x1DCE240 Offset: 0x1DCE341 VA: 0x1DCE240
	public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader) { }

	// RVA: 0x1DCE300 Offset: 0x1DCE401 VA: 0x1DCE300
	public void CrossFadeStart() { }

	// RVA: 0x1DCE320 Offset: 0x1DCE421 VA: 0x1DCE320
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReaction.HitPointBone.BoneLink // TypeDefIndex: 14454
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4970 Offset: 0x2A4A71 VA: 0x2A4970
	public Transform bone; // 0x10
	[TooltipAttribute] // RVA: 0x2A49B0 Offset: 0x2A4AB1 VA: 0x2A49B0
	[RangeAttribute] // RVA: 0x2A49B0 Offset: 0x2A4AB1 VA: 0x2A49B0
	public float weight; // 0x18
	private Quaternion lastValue; // 0x1C
	private Quaternion current; // 0x2C

	// Methods

	// RVA: 0x1DCE0B0 Offset: 0x1DCE1B1 VA: 0x1DCE0B0
	public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader) { }

	// RVA: 0x1DCE1C0 Offset: 0x1DCE2C1 VA: 0x1DCE1C0
	public void CrossFadeStart() { }

	// RVA: 0x1DCE1E0 Offset: 0x1DCE2E1 VA: 0x1DCE1E0
	public void .ctor() { }
}

