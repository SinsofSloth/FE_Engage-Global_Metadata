// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x638B0 Offset: 0x639B1 VA: 0x638B0
internal sealed class _AndroidJNIHelper // TypeDefIndex: 7516
{
	// Methods

	// RVA: 0x3EFB200 Offset: 0x3EFB301 VA: 0x3EFB200
	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x3EFB000 Offset: 0x3EFB101 VA: 0x3EFB000
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x63A30 Offset: 0x63B31 VA: 0x63A30
	// RVA: 0x3F020C0 Offset: 0x3F021C1 VA: 0x3F020C0
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x3EFB290 Offset: 0x3EFB391 VA: 0x3EFB290
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x3F03020 Offset: 0x3F03121 VA: 0x3F03020
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x3F007E0 Offset: 0x3F008E1 VA: 0x3F007E0
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x3EFF940 Offset: 0x3EFFA41 VA: 0x3EFF940
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x3EFB860 Offset: 0x3EFB961 VA: 0x3EFB860
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x3F024E0 Offset: 0x3F025E1 VA: 0x3F024E0
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38755B0 Offset: 0x38756B1 VA: 0x38755B0
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x3875D50 Offset: 0x3875E51 VA: 0x3875D50
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x38764F0 Offset: 0x38765F1 VA: 0x38764F0
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x3876C80 Offset: 0x3876D81 VA: 0x3876C80
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x3877420 Offset: 0x3877521 VA: 0x3877420
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x3877BB0 Offset: 0x3877CB1 VA: 0x3877BB0
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x3878340 Offset: 0x3878441 VA: 0x3878340
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x3878AD0 Offset: 0x3878BD1 VA: 0x3878AD0
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x3879270 Offset: 0x3879371 VA: 0x3879270
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: 0x3EFBA30 Offset: 0x3EFBB31 VA: 0x3EFBA30
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3879A00 Offset: 0x3879B01 VA: 0x3879A00
	|-_AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x3879A60 Offset: 0x3879B61 VA: 0x3879A60
	|-_AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x3879AC0 Offset: 0x3879BC1 VA: 0x3879AC0
	|-_AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x3879B20 Offset: 0x3879C21 VA: 0x3879B20
	|-_AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x3879B80 Offset: 0x3879C81 VA: 0x3879B80
	|-_AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x3879BE0 Offset: 0x3879CE1 VA: 0x3879BE0
	|-_AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x3879C40 Offset: 0x3879D41 VA: 0x3879C40
	|-_AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x3879CA0 Offset: 0x3879DA1 VA: 0x3879CA0
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x3879D00 Offset: 0x3879E01 VA: 0x3879D00
	|-_AndroidJNIHelper.GetMethodID<float>
	*/

	// RVA: 0x3EFAB10 Offset: 0x3EFAC11 VA: 0x3EFAB10
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x3EFAD80 Offset: 0x3EFAE81 VA: 0x3EFAD80
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x3F03860 Offset: 0x3F03961 VA: 0x3F03860
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x3F03960 Offset: 0x3F03A61 VA: 0x3F03960
	public static string GetSignature(object obj) { }

	// RVA: 0x3F03760 Offset: 0x3F03861 VA: 0x3F03760
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3879D60 Offset: 0x3879E61 VA: 0x3879D60
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0x3879EB0 Offset: 0x3879FB1 VA: 0x3879EB0
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0x387A000 Offset: 0x387A101 VA: 0x387A000
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0x387A150 Offset: 0x387A251 VA: 0x387A150
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0x387A2A0 Offset: 0x387A3A1 VA: 0x387A2A0
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0x387A3F0 Offset: 0x387A4F1 VA: 0x387A3F0
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0x387A540 Offset: 0x387A641 VA: 0x387A540
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0x387A690 Offset: 0x387A791 VA: 0x387A690
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0x387A7E0 Offset: 0x387A8E1 VA: 0x387A7E0
	|-_AndroidJNIHelper.GetSignature<float>
	*/
}

