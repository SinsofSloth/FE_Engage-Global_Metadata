// Namespace: 
[Serializable]
public class PenetrationAvoidance.Avoider.EffectorLink // TypeDefIndex: 14474
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A59A0 Offset: 0x2A5AA1 VA: 0x2A59A0
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x2A59E0 Offset: 0x2A5AE1 VA: 0x2A59E0
	public float weight; // 0x14

	// Methods

	// RVA: 0x21F1E80 Offset: 0x21F1F81 VA: 0x21F1E80
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PenetrationAvoidance.Avoider // TypeDefIndex: 14475
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A57C0 Offset: 0x2A58C1 VA: 0x2A57C0
	public Transform[] raycastFrom; // 0x10
	[TooltipAttribute] // RVA: 0x2A5800 Offset: 0x2A5901 VA: 0x2A5800
	public Transform raycastTo; // 0x18
	[RangeAttribute] // RVA: 0x2A5840 Offset: 0x2A5941 VA: 0x2A5840
	[TooltipAttribute] // RVA: 0x2A5840 Offset: 0x2A5941 VA: 0x2A5840
	public float raycastRadius; // 0x20
	[TooltipAttribute] // RVA: 0x2A58A0 Offset: 0x2A59A1 VA: 0x2A58A0
	public PenetrationAvoidance.Avoider.EffectorLink[] effectors; // 0x28
	[TooltipAttribute] // RVA: 0x2A58E0 Offset: 0x2A59E1 VA: 0x2A58E0
	public float smoothTimeIn; // 0x30
	[TooltipAttribute] // RVA: 0x2A5920 Offset: 0x2A5A21 VA: 0x2A5920
	public float smoothTimeOut; // 0x34
	[TooltipAttribute] // RVA: 0x2A5960 Offset: 0x2A5A61 VA: 0x2A5960
	public LayerMask layers; // 0x38
	private Vector3 offset; // 0x3C
	private Vector3 offsetTarget; // 0x48
	private Vector3 offsetV; // 0x54

	// Methods

	// RVA: 0x1F1C420 Offset: 0x1F1C521 VA: 0x1F1C420
	public void Solve(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: 0x1F1C560 Offset: 0x1F1C661 VA: 0x1F1C560
	private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver) { }

	// RVA: 0x1F1C650 Offset: 0x1F1C751 VA: 0x1F1C650
	private Vector3 Raycast(Vector3 from, Vector3 to) { }

	// RVA: 0x1F1C820 Offset: 0x1F1C921 VA: 0x1F1C820
	public void .ctor() { }
}

