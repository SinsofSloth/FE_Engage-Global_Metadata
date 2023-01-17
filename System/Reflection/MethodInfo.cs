// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x471F40 Offset: 0x472041 VA: 0x471F40
[ComDefaultInterfaceAttribute] // RVA: 0x471F40 Offset: 0x472041 VA: 0x471F40
[ClassInterfaceAttribute] // RVA: 0x471F40 Offset: 0x472041 VA: 0x471F40
[Serializable]
public abstract class MethodInfo : MethodBase, _MethodInfo // TypeDefIndex: 540
{
	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type ReturnType { get; }

	// Methods

	// RVA: 0x34EF9C0 Offset: 0x34EFAC1 VA: 0x34EF9C0
	protected void .ctor() { }

	// RVA: 0x34E8DE0 Offset: 0x34E8EE1 VA: 0x34E8DE0
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x34ECE10 Offset: 0x34ECF11 VA: 0x34ECE10
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x34EF9D0 Offset: 0x34EFAD1 VA: 0x34EF9D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34EF9E0 Offset: 0x34EFAE1 VA: 0x34EF9E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34EF9F0 Offset: 0x34EFAF1 VA: 0x34EF9F0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x34EFA00 Offset: 0x34EFB01 VA: 0x34EFA00 Slot: 44
	public virtual Type get_ReturnType() { }

	[ComVisibleAttribute] // RVA: 0x47BD30 Offset: 0x47BE31 VA: 0x47BD30
	// RVA: 0x34EFA40 Offset: 0x34EFB41 VA: 0x34EFA40 Slot: 23
	public override Type[] GetGenericArguments() { }

	[ComVisibleAttribute] // RVA: 0x47BD50 Offset: 0x47BE51 VA: 0x47BD50
	// RVA: 0x34EFAA0 Offset: 0x34EFBA1 VA: 0x34EFAA0 Slot: 45
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x34EFB00 Offset: 0x34EFC01 VA: 0x34EFB00 Slot: 46
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: 0x34EFB60 Offset: 0x34EFC61 VA: 0x34EFB60 Slot: 47
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x34EFBC0 Offset: 0x34EFCC1 VA: 0x34EFBC0 Slot: 48
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x34EFC20 Offset: 0x34EFD21 VA: 0x34EFC20 Slot: 49
	internal virtual MethodInfo GetBaseMethod() { }
}

