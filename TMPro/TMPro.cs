// Namespace: TMPro
[ExtensionAttribute] // RVA: 0x4D0C0 Offset: 0x4D1C1 VA: 0x4D0C0
public static class TMPro_ExtensionMethods // TypeDefIndex: 7471
{
	// Methods

	[ExtensionAttribute] // RVA: 0x4E9E0 Offset: 0x4EAE1 VA: 0x4E9E0
	// RVA: 0x1987F50 Offset: 0x1988051 VA: 0x1987F50
	public static int[] ToIntArray(string text) { }

	[ExtensionAttribute] // RVA: 0x4E9F0 Offset: 0x4EAF1 VA: 0x4E9F0
	// RVA: 0x1988010 Offset: 0x1988111 VA: 0x1988010
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] // RVA: 0x4EA00 Offset: 0x4EB01 VA: 0x4EA00
	// RVA: 0x19880D0 Offset: 0x19881D1 VA: 0x19880D0
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] // RVA: 0x4EA10 Offset: 0x4EB11 VA: 0x4EA10
	// RVA: 0x1988190 Offset: 0x1988291 VA: 0x1988190
	internal static string UintToString(List<uint> unicodes) { }

	[ExtensionAttribute] // RVA: 0x4EA20 Offset: 0x4EB21 VA: 0x4EA20
	// RVA: 0x1988270 Offset: 0x1988371 VA: 0x1988270
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] // RVA: 0x4EA30 Offset: 0x4EB31 VA: 0x4EA30
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024140 Offset: 0x2024241 VA: 0x2024140
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] // RVA: 0x4EA40 Offset: 0x4EB41 VA: 0x4EA40
	// RVA: 0x1988390 Offset: 0x1988491 VA: 0x1988390
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x4EA50 Offset: 0x4EB51 VA: 0x4EA50
	// RVA: 0x19883D0 Offset: 0x19884D1 VA: 0x19883D0
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x4EA60 Offset: 0x4EB61 VA: 0x4EA60
	// RVA: 0x1988400 Offset: 0x1988501 VA: 0x1988400
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x4EA70 Offset: 0x4EB71 VA: 0x4EA70
	// RVA: 0x1988430 Offset: 0x1988531 VA: 0x1988430
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x4EA80 Offset: 0x4EB81 VA: 0x4EA80
	// RVA: 0x1988450 Offset: 0x1988551 VA: 0x1988450
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x4EA90 Offset: 0x4EB91 VA: 0x4EA90
	// RVA: 0x1988520 Offset: 0x1988621 VA: 0x1988520
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x4EAA0 Offset: 0x4EBA1 VA: 0x4EAA0
	// RVA: 0x19885F0 Offset: 0x19886F1 VA: 0x19885F0
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] // RVA: 0x4EAB0 Offset: 0x4EBB1 VA: 0x4EAB0
	// RVA: 0x1988720 Offset: 0x1988821 VA: 0x1988720
	public static Color MinAlpha(Color c1, Color c2) { }

	[ExtensionAttribute] // RVA: 0x4EAC0 Offset: 0x4EBC1 VA: 0x4EAC0
	// RVA: 0x1988760 Offset: 0x1988861 VA: 0x1988760
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] // RVA: 0x4EAD0 Offset: 0x4EBD1 VA: 0x4EAD0
	// RVA: 0x1988820 Offset: 0x1988921 VA: 0x1988820
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }
}

