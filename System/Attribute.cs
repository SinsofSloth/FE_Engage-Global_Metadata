// Namespace: System
[AttributeUsageAttribute] // RVA: 0x46FD40 Offset: 0x46FE41 VA: 0x46FD40
[Serializable]
public abstract class Attribute // TypeDefIndex: 173
{
	// Methods

	// RVA: 0x356B530 Offset: 0x356B631 VA: 0x356B530
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	// RVA: 0x356B5F0 Offset: 0x356B6F1 VA: 0x356B5F0
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	// RVA: 0x356B6B0 Offset: 0x356B7B1 VA: 0x356B6B0
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x356B740 Offset: 0x356B841 VA: 0x356B740
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x356B7D0 Offset: 0x356B8D1 VA: 0x356B7D0
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	// RVA: 0x356B7E0 Offset: 0x356B8E1 VA: 0x356B7E0
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	// RVA: 0x356BAE0 Offset: 0x356BBE1 VA: 0x356BAE0
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	// RVA: 0x356BAF0 Offset: 0x356BBF1 VA: 0x356BAF0
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x356BE30 Offset: 0x356BF31 VA: 0x356BE30
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x356BE40 Offset: 0x356BF41 VA: 0x356BE40
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x356BEE0 Offset: 0x356BFE1 VA: 0x356BEE0
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x356C100 Offset: 0x356C201 VA: 0x356C100
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	// RVA: 0x356C110 Offset: 0x356C211 VA: 0x356C110
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x3566F50 Offset: 0x3567051 VA: 0x3566F50
	protected void .ctor() { }

	// RVA: 0x356C1B0 Offset: 0x356C2B1 VA: 0x356C1B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x356C400 Offset: 0x356C501 VA: 0x356C400
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	// RVA: 0x356C670 Offset: 0x356C771 VA: 0x356C670 Slot: 2
	public override int GetHashCode() { }
}

