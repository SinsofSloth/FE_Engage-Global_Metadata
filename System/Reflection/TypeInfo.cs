// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x4721E0 Offset: 0x4722E1 VA: 0x4721E0
[Serializable]
public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 552
{
	// Properties
	public virtual IEnumerable<Type> ImplementedInterfaces { get; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x47BD70 Offset: 0x47BE71 VA: 0x47BD70
	// RVA: 0x36425D0 Offset: 0x36426D1 VA: 0x36425D0
	internal void .ctor() { }

	// RVA: 0x3642640 Offset: 0x3642741 VA: 0x3642640 Slot: 125
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0x3642650 Offset: 0x3642751 VA: 0x3642650 Slot: 126
	public virtual IEnumerable<Type> get_ImplementedInterfaces() { }
}

