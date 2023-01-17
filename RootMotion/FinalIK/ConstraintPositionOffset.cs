// Namespace: RootMotion.FinalIK
[Serializable]
public class ConstraintPositionOffset : Constraint // TypeDefIndex: 14319
{
	// Fields
	public Vector3 offset; // 0x1C
	private Vector3 defaultLocalPosition; // 0x28
	private Vector3 lastLocalPosition; // 0x34
	private bool initiated; // 0x40

	// Properties
	private bool positionChanged { get; }

	// Methods

	// RVA: 0x23B8A80 Offset: 0x23B8B81 VA: 0x23B8A80 Slot: 4
	public override void UpdateConstraint() { }

	// RVA: 0x23B8C30 Offset: 0x23B8D31 VA: 0x23B8C30
	public void .ctor() { }

	// RVA: 0x23B8C40 Offset: 0x23B8D41 VA: 0x23B8C40
	public void .ctor(Transform transform) { }

	// RVA: 0x23B8BF0 Offset: 0x23B8CF1 VA: 0x23B8BF0
	private bool get_positionChanged() { }
}

