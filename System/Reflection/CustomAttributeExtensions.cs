// Namespace: System.Reflection
[ExtensionAttribute] // RVA: 0x471660 Offset: 0x471761 VA: 0x471660
public static class CustomAttributeExtensions // TypeDefIndex: 501
{
	// Methods

	[ExtensionAttribute] // RVA: 0x47BC70 Offset: 0x47BD71 VA: 0x47BC70
	// RVA: 0x37E4E70 Offset: 0x37E4F71 VA: 0x37E4E70
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x47BC80 Offset: 0x47BD81 VA: 0x47BC80
	// RVA: 0x37E4E80 Offset: 0x37E4F81 VA: 0x37E4E80
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x47BC90 Offset: 0x47BD91 VA: 0x47BC90
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229DBB0 Offset: 0x229DCB1 VA: 0x229DBB0
	|-CustomAttributeExtensions.GetCustomAttribute<NeutralResourcesLanguageAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[ExtensionAttribute] // RVA: 0x47BCA0 Offset: 0x47BDA1 VA: 0x47BCA0
	// RVA: 0x37E4E90 Offset: 0x37E4F91 VA: 0x37E4E90
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0x47BCB0 Offset: 0x47BDB1 VA: 0x47BCB0
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229DC90 Offset: 0x229DD91 VA: 0x229DC90
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	|-CustomAttributeExtensions.GetCustomAttributes<StateMachineAttribute>
	*/
}

