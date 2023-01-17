// Namespace: 
[Serializable]
public enum IKSolverLimb.BendModifier // TypeDefIndex: 14385
{
	// Fields
	public int value__; // 0x0
	public const IKSolverLimb.BendModifier Animation = 0;
	public const IKSolverLimb.BendModifier Target = 1;
	public const IKSolverLimb.BendModifier Parent = 2;
	public const IKSolverLimb.BendModifier Arm = 3;
	public const IKSolverLimb.BendModifier Goal = 4;
}

// Namespace: 
[Serializable]
public struct IKSolverLimb.AxisDirection // TypeDefIndex: 14386
{
	// Fields
	public Vector3 direction; // 0x0
	public Vector3 axis; // 0xC
	public float dot; // 0x18

	// Methods

	// RVA: 0x35FCCF0 Offset: 0x35FCDF1 VA: 0x35FCCF0
	public void .ctor(Vector3 direction, Vector3 axis) { }
}

