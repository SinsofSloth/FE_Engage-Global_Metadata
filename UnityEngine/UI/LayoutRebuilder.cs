// Namespace: UnityEngine.UI
public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 4317
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x1BF1C00 Offset: 0x1BF1D01 VA: 0x1BF1C00
	private void Initialize(RectTransform controller) { }

	// RVA: 0x1BF1C40 Offset: 0x1BF1D41 VA: 0x1BF1C40
	private void Clear() { }

	// RVA: 0x1BF1C70 Offset: 0x1BF1D71 VA: 0x1BF1C70
	private static void .cctor() { }

	// RVA: 0x1BF1E10 Offset: 0x1BF1F11 VA: 0x1BF1E10
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x1BF1E80 Offset: 0x1BF1F81 VA: 0x1BF1E80 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x1BF1E90 Offset: 0x1BF1F91 VA: 0x1BF1E90 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x1BF1F10 Offset: 0x1BF2011 VA: 0x1BF1F10
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x1BF2040 Offset: 0x1BF2141 VA: 0x1BF2040
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x1BF2130 Offset: 0x1BF2231 VA: 0x1BF2130 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1BF2800 Offset: 0x1BF2901 VA: 0x1BF2800
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x1BF24C0 Offset: 0x1BF25C1 VA: 0x1BF24C0
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x1BF0600 Offset: 0x1BF0701 VA: 0x1BF0600
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x1BF2C60 Offset: 0x1BF2D61 VA: 0x1BF2C60
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x1BF2E70 Offset: 0x1BF2F71 VA: 0x1BF2E70
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x1BF3000 Offset: 0x1BF3101 VA: 0x1BF3000 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x1BF3090 Offset: 0x1BF3191 VA: 0x1BF3090 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x1BF30A0 Offset: 0x1BF31A1 VA: 0x1BF30A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BF30B0 Offset: 0x1BF31B1 VA: 0x1BF30B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BF3100 Offset: 0x1BF3201 VA: 0x1BF3100 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BF3180 Offset: 0x1BF3281 VA: 0x1BF3180
	public void .ctor() { }
}

