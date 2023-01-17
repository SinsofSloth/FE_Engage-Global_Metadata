// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x63900 Offset: 0x63A01 VA: 0x63900
[NativeHeaderAttribute] // RVA: 0x63900 Offset: 0x63A01 VA: 0x63900
[NativeConditionalAttribute] // RVA: 0x63900 Offset: 0x63A01 VA: 0x63900
[StaticAccessorAttribute] // RVA: 0x63900 Offset: 0x63A01 VA: 0x63900
public static class AndroidJNIHelper // TypeDefIndex: 7518
{
	// Methods

	// RVA: 0x3EFAB00 Offset: 0x3EFAC01 VA: 0x3EFAB00
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x3EFAD70 Offset: 0x3EFAE71 VA: 0x3EFAD70
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x3EFAFF0 Offset: 0x3EFB0F1 VA: 0x3EFAFF0
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x3EFB0D0 Offset: 0x3EFB1D1 VA: 0x3EFB0D0
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x3EFB280 Offset: 0x3EFB381 VA: 0x3EFB280
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x3EFB850 Offset: 0x3EFB951 VA: 0x3EFB850
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x3EFBA00 Offset: 0x3EFBB01 VA: 0x3EFBA00
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255DF60 Offset: 0x255E061 VA: 0x255DF60
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x255DF70 Offset: 0x255E071 VA: 0x255DF70
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x255DF80 Offset: 0x255E081 VA: 0x255DF80
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x255DF90 Offset: 0x255E091 VA: 0x255DF90
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x255DFA0 Offset: 0x255E0A1 VA: 0x255DFA0
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x255DFB0 Offset: 0x255E0B1 VA: 0x255DFB0
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x255DFC0 Offset: 0x255E0C1 VA: 0x255DFC0
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x255DFD0 Offset: 0x255E0D1 VA: 0x255DFD0
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x255DFE0 Offset: 0x255E0E1 VA: 0x255DFE0
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255DFF0 Offset: 0x255E0F1 VA: 0x255DFF0
	|-AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x255E010 Offset: 0x255E111 VA: 0x255E010
	|-AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x255E030 Offset: 0x255E131 VA: 0x255E030
	|-AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x255E050 Offset: 0x255E151 VA: 0x255E050
	|-AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x255E070 Offset: 0x255E171 VA: 0x255E070
	|-AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x255E090 Offset: 0x255E191 VA: 0x255E090
	|-AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x255E0B0 Offset: 0x255E1B1 VA: 0x255E0B0
	|-AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x255E0D0 Offset: 0x255E1D1 VA: 0x255E0D0
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x255E0F0 Offset: 0x255E1F1 VA: 0x255E0F0
	|-AndroidJNIHelper.GetMethodID<float>
	*/
}

