// Namespace: 
[Serializable]
public class Inertia.Body.EffectorLink // TypeDefIndex: 14463
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5020 Offset: 0x2A5121 VA: 0x2A5020
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x2A5060 Offset: 0x2A5161 VA: 0x2A5060
	public float weight; // 0x14

	// Methods

	// RVA: 0x1DD0CD0 Offset: 0x1DD0DD1 VA: 0x1DD0CD0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Inertia.Body // TypeDefIndex: 14464
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4E80 Offset: 0x2A4F81 VA: 0x2A4E80
	public Transform transform; // 0x10
	[TooltipAttribute] // RVA: 0x2A4EC0 Offset: 0x2A4FC1 VA: 0x2A4EC0
	public Inertia.Body.EffectorLink[] effectorLinks; // 0x18
	[TooltipAttribute] // RVA: 0x2A4F00 Offset: 0x2A5001 VA: 0x2A4F00
	public float speed; // 0x20
	[TooltipAttribute] // RVA: 0x2A4F40 Offset: 0x2A5041 VA: 0x2A4F40
	public float acceleration; // 0x24
	[RangeAttribute] // RVA: 0x2A4F80 Offset: 0x2A5081 VA: 0x2A4F80
	[TooltipAttribute] // RVA: 0x2A4F80 Offset: 0x2A5081 VA: 0x2A4F80
	public float matchVelocity; // 0x28
	[TooltipAttribute] // RVA: 0x2A4FE0 Offset: 0x2A50E1 VA: 0x2A4FE0
	public float gravity; // 0x2C
	private Vector3 delta; // 0x30
	private Vector3 lazyPoint; // 0x3C
	private Vector3 direction; // 0x48
	private Vector3 lastPosition; // 0x54
	private bool firstUpdate; // 0x60

	// Methods

	// RVA: 0x22208E0 Offset: 0x22209E1 VA: 0x22208E0
	public void Reset() { }

	// RVA: 0x22209A0 Offset: 0x2220AA1 VA: 0x22209A0
	public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime) { }

	// RVA: 0x2220C50 Offset: 0x2220D51 VA: 0x2220C50
	public void .ctor() { }
}

