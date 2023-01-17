// Namespace: UnityEngine
public class AndroidJavaObject : IDisposable // TypeDefIndex: 7513
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x3EFE3E0 Offset: 0x3EFE4E1 VA: 0x3EFE3E0
	public void .ctor(string className, object[] args) { }

	// RVA: 0x3EFE770 Offset: 0x3EFE871 VA: 0x3EFE770 Slot: 4
	public void Dispose() { }

	// RVA: 0x3EFE7F0 Offset: 0x3EFE8F1 VA: 0x3EFE7F0
	public IntPtr GetRawObject() { }

	// RVA: 0x3EFE810 Offset: 0x3EFE911 VA: 0x3EFE810
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E170 Offset: 0x255E271 VA: 0x255E170
	|-AndroidJavaObject.Call<AndroidJavaObject>
	|-AndroidJavaObject.Call<object>
	|-AndroidJavaObject.Call<string>
	|
	|-RVA: 0x255E110 Offset: 0x255E211 VA: 0x255E110
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0x255E120 Offset: 0x255E221 VA: 0x255E120
	|-AndroidJavaObject.Call<char>
	|
	|-RVA: 0x255E130 Offset: 0x255E231 VA: 0x255E130
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0x255E140 Offset: 0x255E241 VA: 0x255E140
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0x255E150 Offset: 0x255E251 VA: 0x255E150
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x255E160 Offset: 0x255E261 VA: 0x255E160
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x255E180 Offset: 0x255E281 VA: 0x255E180
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0x255E190 Offset: 0x255E291 VA: 0x255E190
	|-AndroidJavaObject.Call<float>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E1B0 Offset: 0x255E2B1 VA: 0x255E1B0
	|-AndroidJavaObject.CallStatic<AndroidJavaObject>
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0x255E1A0 Offset: 0x255E2A1 VA: 0x255E1A0
	|-AndroidJavaObject.CallStatic<int>
	*/

	// RVA: 0x3EFE020 Offset: 0x3EFE121 VA: 0x3EFE020
	protected void DebugPrint(string msg) { }

	// RVA: 0x3EFE420 Offset: 0x3EFE521 VA: 0x3EFE420
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x3EFE840 Offset: 0x3EFE941 VA: 0x3EFE840
	internal void .ctor(IntPtr jobject) { }

	// RVA: 0x3EFDDD0 Offset: 0x3EFDED1 VA: 0x3EFDDD0
	internal void .ctor() { }

	// RVA: 0x3EFEAB0 Offset: 0x3EFEBB1 VA: 0x3EFEAB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3EFEB30 Offset: 0x3EFEC31 VA: 0x3EFEB30 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E1C0 Offset: 0x255E2C1 VA: 0x255E1C0
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x255F290 Offset: 0x255F391 VA: 0x255F290
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x2560350 Offset: 0x2560451 VA: 0x2560350
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x2561440 Offset: 0x2561541 VA: 0x2561440
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x2562500 Offset: 0x2562601 VA: 0x2562500
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x25635C0 Offset: 0x25636C1 VA: 0x25635C0
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x327B550 Offset: 0x327B651 VA: 0x327B550
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x327C510 Offset: 0x327C611 VA: 0x327C510
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x327D5D0 Offset: 0x327D6D1 VA: 0x327D5D0
	|-AndroidJavaObject._Call<float>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x327E6C0 Offset: 0x327E7C1 VA: 0x327E6C0
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x327F780 Offset: 0x327F881 VA: 0x327F780
	|-AndroidJavaObject._CallStatic<object>
	*/

	// RVA: 0x3EFEC70 Offset: 0x3EFED71 VA: 0x3EFEC70
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x3EFEDB0 Offset: 0x3EFEEB1 VA: 0x3EFEDB0
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x3EFE800 Offset: 0x3EFE901 VA: 0x3EFE800
	protected IntPtr _GetRawObject() { }

	// RVA: 0x3EFE820 Offset: 0x3EFE921 VA: 0x3EFE820
	protected IntPtr _GetRawClass() { }

	// RVA: 0x3EFEEF0 Offset: 0x3EFEFF1 VA: 0x3EFEEF0
	private static void .cctor() { }
}

