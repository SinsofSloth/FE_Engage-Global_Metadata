// Namespace: UnityEngine
internal class AndroidJNISafe // TypeDefIndex: 7520
{
	// Methods

	// RVA: 0x3EFBA60 Offset: 0x3EFBB61 VA: 0x3EFBA60
	public static void CheckException() { }

	// RVA: 0x3EFBFD0 Offset: 0x3EFC0D1 VA: 0x3EFBFD0
	public static void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x3EFC060 Offset: 0x3EFC161 VA: 0x3EFC060
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x3EFBF40 Offset: 0x3EFC041 VA: 0x3EFBF40
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x3EFC0F0 Offset: 0x3EFC1F1 VA: 0x3EFC0F0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x3EFC170 Offset: 0x3EFC271 VA: 0x3EFC170
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x3EFC1F0 Offset: 0x3EFC2F1 VA: 0x3EFC1F0
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x3EFC270 Offset: 0x3EFC371 VA: 0x3EFC270
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x3EFC310 Offset: 0x3EFC411 VA: 0x3EFC310
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x3EFC3B0 Offset: 0x3EFC4B1 VA: 0x3EFC3B0
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x3EFC430 Offset: 0x3EFC531 VA: 0x3EFC430
	public static IntPtr FindClass(string name) { }

	// RVA: 0x3EFC4B0 Offset: 0x3EFC5B1 VA: 0x3EFC4B0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC550 Offset: 0x3EFC651 VA: 0x3EFC550
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC5F0 Offset: 0x3EFC6F1 VA: 0x3EFC5F0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC690 Offset: 0x3EFC791 VA: 0x3EFC690
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC730 Offset: 0x3EFC831 VA: 0x3EFC730
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC7D0 Offset: 0x3EFC8D1 VA: 0x3EFC7D0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC880 Offset: 0x3EFC981 VA: 0x3EFC880
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC930 Offset: 0x3EFCA31 VA: 0x3EFC930
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFC9D0 Offset: 0x3EFCAD1 VA: 0x3EFC9D0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCA70 Offset: 0x3EFCB71 VA: 0x3EFCA70
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCB10 Offset: 0x3EFCC11 VA: 0x3EFCB10
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCBB0 Offset: 0x3EFCCB1 VA: 0x3EFCBB0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCC50 Offset: 0x3EFCD51 VA: 0x3EFCC50
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCCF0 Offset: 0x3EFCDF1 VA: 0x3EFCCF0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCD90 Offset: 0x3EFCE91 VA: 0x3EFCD90
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCE30 Offset: 0x3EFCF31 VA: 0x3EFCE30
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCEE0 Offset: 0x3EFCFE1 VA: 0x3EFCEE0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFCF90 Offset: 0x3EFD091 VA: 0x3EFCF90
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFD030 Offset: 0x3EFD131 VA: 0x3EFD030
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFD0D0 Offset: 0x3EFD1D1 VA: 0x3EFD0D0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFD170 Offset: 0x3EFD271 VA: 0x3EFD170
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFD210 Offset: 0x3EFD311 VA: 0x3EFD210
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x3EFD2B0 Offset: 0x3EFD3B1 VA: 0x3EFD2B0
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x3EFD330 Offset: 0x3EFD431 VA: 0x3EFD330
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x3EFD3B0 Offset: 0x3EFD4B1 VA: 0x3EFD3B0
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x3EFD430 Offset: 0x3EFD531 VA: 0x3EFD430
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x3EFD4B0 Offset: 0x3EFD5B1 VA: 0x3EFD4B0
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x3EFD530 Offset: 0x3EFD631 VA: 0x3EFD530
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x3EFD5B0 Offset: 0x3EFD6B1 VA: 0x3EFD5B0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x3EFD630 Offset: 0x3EFD731 VA: 0x3EFD630
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x3EFD6B0 Offset: 0x3EFD7B1 VA: 0x3EFD6B0
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x3EFD730 Offset: 0x3EFD831 VA: 0x3EFD730
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x3EFD7C0 Offset: 0x3EFD8C1 VA: 0x3EFD7C0
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x3EFD840 Offset: 0x3EFD941 VA: 0x3EFD840
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x3EFD8C0 Offset: 0x3EFD9C1 VA: 0x3EFD8C0
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x3EFD940 Offset: 0x3EFDA41 VA: 0x3EFD940
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x3EFD9C0 Offset: 0x3EFDAC1 VA: 0x3EFD9C0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x3EFDA40 Offset: 0x3EFDB41 VA: 0x3EFDA40
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x3EFDAC0 Offset: 0x3EFDBC1 VA: 0x3EFDAC0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x3EFDB40 Offset: 0x3EFDC41 VA: 0x3EFDB40
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x3EFDBC0 Offset: 0x3EFDCC1 VA: 0x3EFDBC0
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x3EFDC40 Offset: 0x3EFDD41 VA: 0x3EFDC40
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x3EFDCD0 Offset: 0x3EFDDD1 VA: 0x3EFDCD0
	public static int GetArrayLength(IntPtr array) { }
}

