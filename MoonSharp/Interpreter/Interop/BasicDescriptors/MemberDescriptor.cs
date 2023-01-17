// Namespace: MoonSharp.Interpreter.Interop.BasicDescriptors
[ExtensionAttribute] // RVA: 0xD980 Offset: 0xDA81 VA: 0xD980
public static class MemberDescriptor // TypeDefIndex: 6165
{
	// Methods

	[ExtensionAttribute] // RVA: 0x10CC0 Offset: 0x10DC1 VA: 0x10CC0
	// RVA: 0x2BB4AA0 Offset: 0x2BB4BA1 VA: 0x2BB4AA0
	public static bool HasAllFlags(MemberDescriptorAccess access, MemberDescriptorAccess flag) { }

	[ExtensionAttribute] // RVA: 0x10CD0 Offset: 0x10DD1 VA: 0x10CD0
	// RVA: 0x2BB4AB0 Offset: 0x2BB4BB1 VA: 0x2BB4AB0
	public static bool CanRead(IMemberDescriptor desc) { }

	[ExtensionAttribute] // RVA: 0x10CE0 Offset: 0x10DE1 VA: 0x10CE0
	// RVA: 0x2BB4B60 Offset: 0x2BB4C61 VA: 0x2BB4B60
	public static bool CanWrite(IMemberDescriptor desc) { }

	[ExtensionAttribute] // RVA: 0x10CF0 Offset: 0x10DF1 VA: 0x10CF0
	// RVA: 0x2BB4C10 Offset: 0x2BB4D11 VA: 0x2BB4C10
	public static bool CanExecute(IMemberDescriptor desc) { }

	[ExtensionAttribute] // RVA: 0x10D00 Offset: 0x10E01 VA: 0x10D00
	// RVA: 0x2BB4CC0 Offset: 0x2BB4DC1 VA: 0x2BB4CC0
	public static DynValue GetGetterCallbackAsDynValue(IMemberDescriptor desc, Script script, object obj) { }

	[ExtensionAttribute] // RVA: 0x10D10 Offset: 0x10E11 VA: 0x10D10
	// RVA: 0x2BB4E00 Offset: 0x2BB4F01 VA: 0x2BB4E00
	public static IMemberDescriptor WithAccessOrNull(IMemberDescriptor desc, MemberDescriptorAccess access) { }

	[ExtensionAttribute] // RVA: 0x10D20 Offset: 0x10E21 VA: 0x10D20
	// RVA: 0x2BB4ED0 Offset: 0x2BB4FD1 VA: 0x2BB4ED0
	public static void CheckAccess(IMemberDescriptor desc, MemberDescriptorAccess access, object obj) { }
}

