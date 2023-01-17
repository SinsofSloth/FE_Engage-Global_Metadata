// Namespace: RootMotion.FinalIK
[Serializable]
public class ConstraintRotationOffset : Constraint // TypeDefIndex: 14321
{
	// Fields
	public Quaternion offset; // 0x1C
	private Quaternion defaultRotation; // 0x2C
	private Quaternion defaultLocalRotation; // 0x3C
	private Quaternion lastLocalRotation; // 0x4C
	private Quaternion defaultTargetLocalRotation; // 0x5C
	private bool initiated; // 0x6C

	// Properties
	private bool rotationChanged { get; }

	// Methods

	// RVA: 0x23B8DB0 Offset: 0x23B8EB1 VA: 0x23B8DB0 Slot: 4
	public override void UpdateConstraint() { }

	// RVA: 0x23B8F50 Offset: 0x23B9051 VA: 0x23B8F50
	public void .ctor() { }

	// RVA: 0x23B8F60 Offset: 0x23B9061 VA: 0x23B8F60
	public void .ctor(Transform transform) { }

	// RVA: 0x23B8F10 Offset: 0x23B9011 VA: 0x23B8F10
	private bool get_rotationChanged() { }
}

