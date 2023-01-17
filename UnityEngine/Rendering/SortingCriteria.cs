// Namespace: UnityEngine.Rendering
[FlagsAttribute] // RVA: 0x441060 Offset: 0x441161 VA: 0x441060
public enum SortingCriteria // TypeDefIndex: 3962
{
	// Fields
	public int value__; // 0x0
	public const SortingCriteria None = 0;
	public const SortingCriteria SortingLayer = 1;
	public const SortingCriteria RenderQueue = 2;
	public const SortingCriteria BackToFront = 4;
	public const SortingCriteria QuantizedFrontToBack = 8;
	public const SortingCriteria OptimizeStateChanges = 16;
	public const SortingCriteria CanvasOrder = 32;
	public const SortingCriteria RendererPriority = 64;
	public const SortingCriteria CommonOpaque = 59;
	public const SortingCriteria CommonTransparent = 23;
}

