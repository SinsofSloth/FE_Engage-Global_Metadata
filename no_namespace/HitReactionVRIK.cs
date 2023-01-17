// Namespace: 
[Serializable]
public class HitReactionVRIK.PositionOffset.PositionOffsetLink // TypeDefIndex: 14458
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4C60 Offset: 0x2A4D61 VA: 0x2A4C60
	public IKSolverVR.PositionOffset positionOffset; // 0x10
	[TooltipAttribute] // RVA: 0x2A4CA0 Offset: 0x2A4DA1 VA: 0x2A4CA0
	public float weight; // 0x14
	private Vector3 lastValue; // 0x18
	private Vector3 current; // 0x24

	// Methods

	// RVA: 0x1DCE330 Offset: 0x1DCE431 VA: 0x1DCE330
	public void Apply(VRIK ik, Vector3 offset, float crossFader) { }

	// RVA: 0x1DCE3D0 Offset: 0x1DCE4D1 VA: 0x1DCE3D0
	public void CrossFadeStart() { }

	// RVA: 0x1DCE3F0 Offset: 0x1DCE4F1 VA: 0x1DCE3F0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReactionVRIK.RotationOffset.RotationOffsetLink // TypeDefIndex: 14460
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4D60 Offset: 0x2A4E61 VA: 0x2A4D60
	public IKSolverVR.RotationOffset rotationOffset; // 0x10
	[TooltipAttribute] // RVA: 0x2A4DA0 Offset: 0x2A4EA1 VA: 0x2A4DA0
	[RangeAttribute] // RVA: 0x2A4DA0 Offset: 0x2A4EA1 VA: 0x2A4DA0
	public float weight; // 0x14
	private Quaternion lastValue; // 0x18
	private Quaternion current; // 0x28

	// Methods

	// RVA: 0x1DCE400 Offset: 0x1DCE501 VA: 0x1DCE400
	public void Apply(VRIK ik, Quaternion offset, float crossFader) { }

	// RVA: 0x1DCE4E0 Offset: 0x1DCE5E1 VA: 0x1DCE4E0
	public void CrossFadeStart() { }

	// RVA: 0x1DCE500 Offset: 0x1DCE601 VA: 0x1DCE500
	public void .ctor() { }
}

