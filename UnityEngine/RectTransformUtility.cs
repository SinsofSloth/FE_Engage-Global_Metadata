// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x68590 Offset: 0x68691 VA: 0x68590
[NativeHeaderAttribute] // RVA: 0x68590 Offset: 0x68691 VA: 0x68590
[NativeHeaderAttribute] // RVA: 0x68590 Offset: 0x68691 VA: 0x68590
[NativeHeaderAttribute] // RVA: 0x68590 Offset: 0x68691 VA: 0x68590
[StaticAccessorAttribute] // RVA: 0x68590 Offset: 0x68691 VA: 0x68590
public sealed class RectTransformUtility // TypeDefIndex: 4228
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x1C53470 Offset: 0x1C53571 VA: 0x1C53470
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x1C535A0 Offset: 0x1C536A1 VA: 0x1C535A0
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x1C536C0 Offset: 0x1C537C1 VA: 0x1C536C0
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x1C53800 Offset: 0x1C53901 VA: 0x1C53800
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x1C538C0 Offset: 0x1C539C1 VA: 0x1C538C0
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x1C539F0 Offset: 0x1C53AF1 VA: 0x1C539F0
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x1C53CB0 Offset: 0x1C53DB1 VA: 0x1C53CB0
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x1C53B90 Offset: 0x1C53C91 VA: 0x1C53B90
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x1C53DA0 Offset: 0x1C53EA1 VA: 0x1C53DA0
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x1C53E60 Offset: 0x1C53F61 VA: 0x1C53E60
	public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child) { }

	// RVA: 0x1C543F0 Offset: 0x1C544F1 VA: 0x1C543F0
	public static Bounds CalculateRelativeRectTransformBounds(Transform trans) { }

	// RVA: 0x1C54490 Offset: 0x1C54591 VA: 0x1C54490
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x1C54750 Offset: 0x1C54851 VA: 0x1C54750
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x1C549E0 Offset: 0x1C54AE1 VA: 0x1C549E0
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x1C549F0 Offset: 0x1C54AF1 VA: 0x1C549F0
	private static void .cctor() { }

	// RVA: 0x1C53530 Offset: 0x1C53631 VA: 0x1C53530
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x1C53660 Offset: 0x1C53761 VA: 0x1C53660
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x1C53790 Offset: 0x1C53891 VA: 0x1C53790
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }
}

