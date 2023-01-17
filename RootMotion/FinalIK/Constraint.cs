// Namespace: RootMotion.FinalIK
[Serializable]
public abstract class Constraint // TypeDefIndex: 14317
{
	// Fields
	public Transform transform; // 0x10
	public float weight; // 0x18

	// Properties
	public bool isValid { get; }

	// Methods

	// RVA: 0x23B8880 Offset: 0x23B8981 VA: 0x23B8880
	public bool get_isValid() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void UpdateConstraint();

	// RVA: 0x23B8900 Offset: 0x23B8A01 VA: 0x23B8900
	protected void .ctor() { }
}

