// Namespace: 
[Serializable]
public class Recoil.RecoilOffset.EffectorLink // TypeDefIndex: 14477
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5DE0 Offset: 0x2A5EE1 VA: 0x2A5DE0
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x2A5E20 Offset: 0x2A5F21 VA: 0x2A5E20
	public float weight; // 0x14

	// Methods

	// RVA: 0x21F4030 Offset: 0x21F4131 VA: 0x21F4030
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Recoil.RecoilOffset // TypeDefIndex: 14478
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5CC0 Offset: 0x2A5DC1 VA: 0x2A5CC0
	public Vector3 offset; // 0x10
	[RangeAttribute] // RVA: 0x2A5D00 Offset: 0x2A5E01 VA: 0x2A5D00
	[TooltipAttribute] // RVA: 0x2A5D00 Offset: 0x2A5E01 VA: 0x2A5D00
	public float additivity; // 0x1C
	[TooltipAttribute] // RVA: 0x2A5D60 Offset: 0x2A5E61 VA: 0x2A5D60
	public float maxAdditiveOffsetMag; // 0x20
	[TooltipAttribute] // RVA: 0x2A5DA0 Offset: 0x2A5EA1 VA: 0x2A5DA0
	public Recoil.RecoilOffset.EffectorLink[] effectorLinks; // 0x28
	private Vector3 additiveOffset; // 0x30
	private Vector3 lastOffset; // 0x3C

	// Methods

	// RVA: 0x1F2EE70 Offset: 0x1F2EF71 VA: 0x1F2EE70
	public void Start() { }

	// RVA: 0x1F2EEC0 Offset: 0x1F2EFC1 VA: 0x1F2EEC0
	public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft) { }

	// RVA: 0x1F2F090 Offset: 0x1F2F191 VA: 0x1F2F090
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public enum Recoil.Handedness // TypeDefIndex: 14479
{
	// Fields
	public int value__; // 0x0
	public const Recoil.Handedness Right = 0;
	public const Recoil.Handedness Left = 1;
}

