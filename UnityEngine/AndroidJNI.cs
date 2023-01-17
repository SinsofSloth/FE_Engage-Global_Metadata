// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x639A0 Offset: 0x63AA1 VA: 0x639A0
[StaticAccessorAttribute] // RVA: 0x639A0 Offset: 0x63AA1 VA: 0x639A0
[NativeConditionalAttribute] // RVA: 0x639A0 Offset: 0x63AA1 VA: 0x639A0
public static class AndroidJNI // TypeDefIndex: 7519
{
	// Methods

	[ThreadSafeAttribute] // RVA: 0x63A40 Offset: 0x63B41 VA: 0x63A40
	// RVA: 0x3EF9670 Offset: 0x3EF9771 VA: 0x3EF9670
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x63A50 Offset: 0x63B51 VA: 0x63A50
	// RVA: 0x3EF96C0 Offset: 0x3EF97C1 VA: 0x3EF96C0
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x63A60 Offset: 0x63B61 VA: 0x63A60
	// RVA: 0x3EF9710 Offset: 0x3EF9811 VA: 0x3EF9710
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x63A70 Offset: 0x63B71 VA: 0x63A70
	// RVA: 0x3EF9750 Offset: 0x3EF9851 VA: 0x3EF9750
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x63A80 Offset: 0x63B81 VA: 0x63A80
	// RVA: 0x3EF9790 Offset: 0x3EF9891 VA: 0x3EF9790
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63A90 Offset: 0x63B91 VA: 0x63A90
	// RVA: 0x3EF97E0 Offset: 0x3EF98E1 VA: 0x3EF97E0
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63AA0 Offset: 0x63BA1 VA: 0x63AA0
	// RVA: 0x3EF9830 Offset: 0x3EF9931 VA: 0x3EF9830
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63AB0 Offset: 0x63BB1 VA: 0x63AB0
	// RVA: 0x3EF9880 Offset: 0x3EF9981 VA: 0x3EF9880
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63AC0 Offset: 0x63BC1 VA: 0x63AC0
	// RVA: 0x3EF98D0 Offset: 0x3EF99D1 VA: 0x3EF98D0
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63AD0 Offset: 0x63BD1 VA: 0x63AD0
	// RVA: 0x3EF9920 Offset: 0x3EF9A21 VA: 0x3EF9920
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63AE0 Offset: 0x63BE1 VA: 0x63AE0
	// RVA: 0x3EF9970 Offset: 0x3EF9A71 VA: 0x3EF9970
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63AF0 Offset: 0x63BF1 VA: 0x63AF0
	// RVA: 0x3EF99D0 Offset: 0x3EF9AD1 VA: 0x3EF99D0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63B00 Offset: 0x63C01 VA: 0x63B00
	// RVA: 0x3EF9A20 Offset: 0x3EF9B21 VA: 0x3EF9A20
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x63B10 Offset: 0x63C11 VA: 0x63B10
	// RVA: 0x3EF9A80 Offset: 0x3EF9B81 VA: 0x3EF9A80
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x3EF9AE0 Offset: 0x3EF9BE1 VA: 0x3EF9AE0
	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x63B20 Offset: 0x63C21 VA: 0x63B20
	// RVA: 0x3EF9B30 Offset: 0x3EF9C31 VA: 0x3EF9B30
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x63B30 Offset: 0x63C31 VA: 0x63B30
	// RVA: 0x3EF9B80 Offset: 0x3EF9C81 VA: 0x3EF9B80
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x63B40 Offset: 0x63C41 VA: 0x63B40
	// RVA: 0x3EF9BD0 Offset: 0x3EF9CD1 VA: 0x3EF9BD0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63B50 Offset: 0x63C51 VA: 0x63B50
	// RVA: 0x3EF9C30 Offset: 0x3EF9D31 VA: 0x3EF9C30
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63B60 Offset: 0x63C61 VA: 0x63B60
	// RVA: 0x3EF9C90 Offset: 0x3EF9D91 VA: 0x3EF9C90
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63B70 Offset: 0x63C71 VA: 0x63B70
	// RVA: 0x3EF9CF0 Offset: 0x3EF9DF1 VA: 0x3EF9CF0
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63B80 Offset: 0x63C81 VA: 0x63B80
	// RVA: 0x3EF9D50 Offset: 0x3EF9E51 VA: 0x3EF9D50
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63B90 Offset: 0x63C91 VA: 0x63B90
	// RVA: 0x3EF9DB0 Offset: 0x3EF9EB1 VA: 0x3EF9DB0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63BA0 Offset: 0x63CA1 VA: 0x63BA0
	// RVA: 0x3EF9E10 Offset: 0x3EF9F11 VA: 0x3EF9E10
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63BB0 Offset: 0x63CB1 VA: 0x63BB0
	// RVA: 0x3EF9E70 Offset: 0x3EF9F71 VA: 0x3EF9E70
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63BC0 Offset: 0x63CC1 VA: 0x63BC0
	// RVA: 0x3EF9ED0 Offset: 0x3EF9FD1 VA: 0x3EF9ED0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63BD0 Offset: 0x63CD1 VA: 0x63BD0
	// RVA: 0x3EF9F30 Offset: 0x3EFA031 VA: 0x3EF9F30
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63BE0 Offset: 0x63CE1 VA: 0x63BE0
	// RVA: 0x3EF9F90 Offset: 0x3EFA091 VA: 0x3EF9F90
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63BF0 Offset: 0x63CF1 VA: 0x63BF0
	// RVA: 0x3EF9FF0 Offset: 0x3EFA0F1 VA: 0x3EF9FF0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C00 Offset: 0x63D01 VA: 0x63C00
	// RVA: 0x3EFA050 Offset: 0x3EFA151 VA: 0x3EFA050
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C10 Offset: 0x63D11 VA: 0x63C10
	// RVA: 0x3EFA0B0 Offset: 0x3EFA1B1 VA: 0x3EFA0B0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C20 Offset: 0x63D21 VA: 0x63C20
	// RVA: 0x3EFA110 Offset: 0x3EFA211 VA: 0x3EFA110
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C30 Offset: 0x63D31 VA: 0x63C30
	// RVA: 0x3EFA170 Offset: 0x3EFA271 VA: 0x3EFA170
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C40 Offset: 0x63D41 VA: 0x63C40
	// RVA: 0x3EFA1D0 Offset: 0x3EFA2D1 VA: 0x3EFA1D0
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C50 Offset: 0x63D51 VA: 0x63C50
	// RVA: 0x3EFA230 Offset: 0x3EFA331 VA: 0x3EFA230
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C60 Offset: 0x63D61 VA: 0x63C60
	// RVA: 0x3EFA290 Offset: 0x3EFA391 VA: 0x3EFA290
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C70 Offset: 0x63D71 VA: 0x63C70
	// RVA: 0x3EFA2F0 Offset: 0x3EFA3F1 VA: 0x3EFA2F0
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C80 Offset: 0x63D81 VA: 0x63C80
	// RVA: 0x3EFA350 Offset: 0x3EFA451 VA: 0x3EFA350
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x63C90 Offset: 0x63D91 VA: 0x63C90
	// RVA: 0x3EFA3B0 Offset: 0x3EFA4B1 VA: 0x3EFA3B0
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63CA0 Offset: 0x63DA1 VA: 0x63CA0
	[ObsoleteAttribute] // RVA: 0x63CA0 Offset: 0x63DA1 VA: 0x63CA0
	// RVA: 0x3EFA400 Offset: 0x3EFA501 VA: 0x3EFA400
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63CF0 Offset: 0x63DF1 VA: 0x63CF0
	// RVA: 0x3EFA450 Offset: 0x3EFA551 VA: 0x3EFA450
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63D00 Offset: 0x63E01 VA: 0x63D00
	// RVA: 0x3EFA4A0 Offset: 0x3EFA5A1 VA: 0x3EFA4A0
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63D10 Offset: 0x63E11 VA: 0x63D10
	// RVA: 0x3EFA4F0 Offset: 0x3EFA5F1 VA: 0x3EFA4F0
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63D20 Offset: 0x63E21 VA: 0x63D20
	// RVA: 0x3EFA540 Offset: 0x3EFA641 VA: 0x3EFA540
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63D30 Offset: 0x63E31 VA: 0x63D30
	// RVA: 0x3EFA590 Offset: 0x3EFA691 VA: 0x3EFA590
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63D40 Offset: 0x63E41 VA: 0x63D40
	// RVA: 0x3EFA5E0 Offset: 0x3EFA6E1 VA: 0x3EFA5E0
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63D50 Offset: 0x63E51 VA: 0x63D50
	// RVA: 0x3EFA630 Offset: 0x3EFA731 VA: 0x3EFA630
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x63D60 Offset: 0x63E61 VA: 0x63D60
	// RVA: 0x3EFA680 Offset: 0x3EFA781 VA: 0x3EFA680
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x63D70 Offset: 0x63E71 VA: 0x63D70
	// RVA: 0x3EFA6D0 Offset: 0x3EFA7D1 VA: 0x3EFA6D0
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0x63D80 Offset: 0x63E81 VA: 0x63D80
	[ThreadSafeAttribute] // RVA: 0x63D80 Offset: 0x63E81 VA: 0x63D80
	// RVA: 0x3EFA720 Offset: 0x3EFA821 VA: 0x3EFA720
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63DD0 Offset: 0x63ED1 VA: 0x63DD0
	// RVA: 0x3EFA770 Offset: 0x3EFA871 VA: 0x3EFA770
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63DE0 Offset: 0x63EE1 VA: 0x63DE0
	// RVA: 0x3EFA7C0 Offset: 0x3EFA8C1 VA: 0x3EFA7C0
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63DF0 Offset: 0x63EF1 VA: 0x63DF0
	// RVA: 0x3EFA810 Offset: 0x3EFA911 VA: 0x3EFA810
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63E00 Offset: 0x63F01 VA: 0x63E00
	// RVA: 0x3EFA860 Offset: 0x3EFA961 VA: 0x3EFA860
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63E10 Offset: 0x63F11 VA: 0x63E10
	// RVA: 0x3EFA8B0 Offset: 0x3EFA9B1 VA: 0x3EFA8B0
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63E20 Offset: 0x63F21 VA: 0x63E20
	// RVA: 0x3EFA900 Offset: 0x3EFAA01 VA: 0x3EFA900
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63E30 Offset: 0x63F31 VA: 0x63E30
	// RVA: 0x3EFA950 Offset: 0x3EFAA51 VA: 0x3EFA950
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63E40 Offset: 0x63F41 VA: 0x63E40
	// RVA: 0x3EFA9A0 Offset: 0x3EFAAA1 VA: 0x3EFA9A0
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x63E50 Offset: 0x63F51 VA: 0x63E50
	// RVA: 0x3EFA9F0 Offset: 0x3EFAAF1 VA: 0x3EFA9F0
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x63E60 Offset: 0x63F61 VA: 0x63E60
	// RVA: 0x3EFAA50 Offset: 0x3EFAB51 VA: 0x3EFAA50
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x63E70 Offset: 0x63F71 VA: 0x63E70
	// RVA: 0x3EFAAA0 Offset: 0x3EFABA1 VA: 0x3EFAAA0
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }
}

