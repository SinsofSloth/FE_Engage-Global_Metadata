// Namespace: System.Reflection
internal struct MonoMethodInfo // TypeDefIndex: 578
{
	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x34FA0E0 Offset: 0x34FA1E1 VA: 0x34FA0E0
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x34FA0F0 Offset: 0x34FA1F1 VA: 0x34FA0F0
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x34F9B50 Offset: 0x34F9C51 VA: 0x34F9B50
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x34F4090 Offset: 0x34F4191 VA: 0x34F4090
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x34F95C0 Offset: 0x34F96C1 VA: 0x34F95C0
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x34F3FB0 Offset: 0x34F40B1 VA: 0x34F3FB0
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x34F3FF0 Offset: 0x34F40F1 VA: 0x34F3FF0
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x34F37F0 Offset: 0x34F38F1 VA: 0x34F37F0
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x34FA100 Offset: 0x34FA201 VA: 0x34FA100
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x34F3830 Offset: 0x34F3931 VA: 0x34F3830
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }
}

