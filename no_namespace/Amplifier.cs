// Namespace: 
[Serializable]
public class Amplifier.Body // TypeDefIndex: 14445
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4260 Offset: 0x2A4361 VA: 0x2A4260
	public Transform transform; // 0x10
	[TooltipAttribute] // RVA: 0x2A42A0 Offset: 0x2A43A1 VA: 0x2A42A0
	public Transform relativeTo; // 0x18
	[TooltipAttribute] // RVA: 0x2A42E0 Offset: 0x2A43E1 VA: 0x2A42E0
	public Amplifier.Body.EffectorLink[] effectorLinks; // 0x20
	[TooltipAttribute] // RVA: 0x2A4320 Offset: 0x2A4421 VA: 0x2A4320
	public float verticalWeight; // 0x28
	[TooltipAttribute] // RVA: 0x2A4360 Offset: 0x2A4461 VA: 0x2A4360
	public float horizontalWeight; // 0x2C
	[TooltipAttribute] // RVA: 0x2A43A0 Offset: 0x2A44A1 VA: 0x2A43A0
	public float speed; // 0x30
	private Vector3 lastRelativePos; // 0x34
	private Vector3 smoothDelta; // 0x40
	private bool firstUpdate; // 0x4C

	// Methods

	// RVA: 0x1F5D880 Offset: 0x1F5D981 VA: 0x1F5D880
	public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime) { }

	// RVA: 0x1F5DB90 Offset: 0x1F5DC91 VA: 0x1F5DB90
	private static Vector3 Multiply(Vector3 v1, Vector3 v2) { }

	// RVA: 0x1F5DBA0 Offset: 0x1F5DCA1 VA: 0x1F5DBA0
	public void .ctor() { }
}

