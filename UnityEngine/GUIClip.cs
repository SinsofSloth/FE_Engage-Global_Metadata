// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x52970 Offset: 0x52A71 VA: 0x52970
[NativeHeaderAttribute] // RVA: 0x52970 Offset: 0x52A71 VA: 0x52970
internal sealed class GUIClip // TypeDefIndex: 4148
{
	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x53A10 Offset: 0x53B11 VA: 0x53A10
	// RVA: 0x3C73DC0 Offset: 0x3C73EC1 VA: 0x3C73DC0
	internal static Rect get_visibleRect() { }

	// RVA: 0x3C799C0 Offset: 0x3C79AC1 VA: 0x3C799C0
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x3C760B0 Offset: 0x3C761B1 VA: 0x3C760B0
	internal static void Internal_Pop() { }

	// RVA: 0x3C70EA0 Offset: 0x3C70FA1 VA: 0x3C70EA0
	internal static void SetMatrix(Matrix4x4 m) { }

	// RVA: 0x3C75FF0 Offset: 0x3C760F1 VA: 0x3C75FF0
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x3C761F0 Offset: 0x3C762F1 VA: 0x3C761F0
	internal static void Pop() { }

	// RVA: 0x3C79970 Offset: 0x3C79A71 VA: 0x3C79970
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x3C79A30 Offset: 0x3C79B31 VA: 0x3C79A30
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x3C79AA0 Offset: 0x3C79BA1 VA: 0x3C79AA0
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }
}

