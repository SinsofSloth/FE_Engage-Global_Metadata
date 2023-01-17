// Namespace: UnityEngine.UI
public static class LayoutUtility // TypeDefIndex: 4319
{
	// Methods

	// RVA: 0x1B69AF0 Offset: 0x1B69BF1 VA: 0x1B69AF0
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x1B69D60 Offset: 0x1B69E61 VA: 0x1B69D60
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x1B6A190 Offset: 0x1B6A291 VA: 0x1B6A190
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x1B69C30 Offset: 0x1B69D31 VA: 0x1B69C30
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x1B69F80 Offset: 0x1B6A081 VA: 0x1B69F80
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x1B6A2D0 Offset: 0x1B6A3D1 VA: 0x1B6A2D0
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x1B69B00 Offset: 0x1B69C01 VA: 0x1B69B00
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x1B69D70 Offset: 0x1B69E71 VA: 0x1B69D70
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x1B6A1A0 Offset: 0x1B6A2A1 VA: 0x1B6A1A0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x1B6A400 Offset: 0x1B6A501 VA: 0x1B6A400
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x1B6A430 Offset: 0x1B6A531 VA: 0x1B6A430
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }
}

