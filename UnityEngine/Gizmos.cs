// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C230 Offset: 0x43C331 VA: 0x43C230
[StaticAccessorAttribute] // RVA: 0x43C230 Offset: 0x43C331 VA: 0x43C230
public sealed class Gizmos // TypeDefIndex: 3434
{
	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x447390 Offset: 0x447491 VA: 0x447390
	// RVA: 0x2F23AD0 Offset: 0x2F23BD1 VA: 0x2F23AD0
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0x4473A0 Offset: 0x4474A1 VA: 0x4473A0
	// RVA: 0x2F23B80 Offset: 0x2F23C81 VA: 0x2F23B80
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x4473B0 Offset: 0x4474B1 VA: 0x4473B0
	// RVA: 0x2F23C30 Offset: 0x2F23D31 VA: 0x2F23C30
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0x4473C0 Offset: 0x4474C1 VA: 0x4473C0
	// RVA: 0x2F23CE0 Offset: 0x2F23DE1 VA: 0x2F23CE0
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x4473D0 Offset: 0x4474D1 VA: 0x4473D0
	// RVA: 0x2F23D90 Offset: 0x2F23E91 VA: 0x2F23D90
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0x4473E0 Offset: 0x4474E1 VA: 0x4473E0
	// RVA: 0x2F23E40 Offset: 0x2F23F41 VA: 0x2F23E40
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0x4473F0 Offset: 0x4474F1 VA: 0x4473F0
	// RVA: 0x2F23EC0 Offset: 0x2F23FC1 VA: 0x2F23EC0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x2F23FB0 Offset: 0x2F240B1 VA: 0x2F23FB0
	public static Color get_color() { }

	// RVA: 0x2F24060 Offset: 0x2F24161 VA: 0x2F24060
	public static void set_color(Color value) { }

	// RVA: 0x2F24100 Offset: 0x2F24201 VA: 0x2F24100
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x2F23B30 Offset: 0x2F23C31 VA: 0x2F23B30
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x2F23BE0 Offset: 0x2F23CE1 VA: 0x2F23BE0
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x2F23C90 Offset: 0x2F23D91 VA: 0x2F23C90
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x2F23D40 Offset: 0x2F23E41 VA: 0x2F23D40
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x2F23DF0 Offset: 0x2F23EF1 VA: 0x2F23DF0
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x2F23F40 Offset: 0x2F24041 VA: 0x2F23F40
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x2F24010 Offset: 0x2F24111 VA: 0x2F24010
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x2F240B0 Offset: 0x2F241B1 VA: 0x2F240B0
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x2F24150 Offset: 0x2F24251 VA: 0x2F24150
	private static void set_matrix_Injected(ref Matrix4x4 value) { }
}

