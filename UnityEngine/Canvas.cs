// Namespace: UnityEngine
[NativeClassAttribute] // RVA: 0x68670 Offset: 0x68771 VA: 0x68670
[RequireComponent] // RVA: 0x68670 Offset: 0x68771 VA: 0x68670
[NativeHeaderAttribute] // RVA: 0x68670 Offset: 0x68771 VA: 0x68670
[NativeHeaderAttribute] // RVA: 0x68670 Offset: 0x68771 VA: 0x68670
public sealed class Canvas : Behaviour // TypeDefIndex: 4232
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x68800 Offset: 0x68901 VA: 0x68800
	[DebuggerBrowsableAttribute] // RVA: 0x68800 Offset: 0x68901 VA: 0x68800
	private static Canvas.WillRenderCanvases preWillRenderCanvases; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x68840 Offset: 0x68941 VA: 0x68840
	[DebuggerBrowsableAttribute] // RVA: 0x68840 Offset: 0x68941 VA: 0x68840
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x8

	// Properties
	public RenderMode renderMode { get; set; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool overridePixelPerfect { get; set; }
	public bool pixelPerfect { get; set; }
	public float planeDistance { get; set; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; set; }
	public int sortingLayerID { get; set; }
	public int cachedSortingLayerValue { get; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public string sortingLayerName { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	[NativePropertyAttribute] // RVA: 0x68D30 Offset: 0x68E31 VA: 0x68D30
	public Camera worldCamera { get; set; }
	[NativePropertyAttribute] // RVA: 0x68D70 Offset: 0x68E71 VA: 0x68D70
	public float normalizedSortingGridSize { get; set; }
	[NativePropertyAttribute] // RVA: 0x68DB0 Offset: 0x68EB1 VA: 0x68DB0
	[ObsoleteAttribute] // RVA: 0x68DB0 Offset: 0x68EB1 VA: 0x68DB0
	public int sortingGridNormalizedSize { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x689E0 Offset: 0x68AE1 VA: 0x689E0
	// RVA: 0x1C50350 Offset: 0x1C50451 VA: 0x1C50350
	public static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x689F0 Offset: 0x68AF1 VA: 0x689F0
	// RVA: 0x1C50410 Offset: 0x1C50511 VA: 0x1C50410
	public static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x68A00 Offset: 0x68B01 VA: 0x68A00
	// RVA: 0x1C504D0 Offset: 0x1C505D1 VA: 0x1C504D0
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x68A10 Offset: 0x68B11 VA: 0x68A10
	// RVA: 0x1C505A0 Offset: 0x1C506A1 VA: 0x1C505A0
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x1C50670 Offset: 0x1C50771 VA: 0x1C50670
	public RenderMode get_renderMode() { }

	// RVA: 0x1C506C0 Offset: 0x1C507C1 VA: 0x1C506C0
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x1C50710 Offset: 0x1C50811 VA: 0x1C50710
	public bool get_isRootCanvas() { }

	// RVA: 0x1C50760 Offset: 0x1C50861 VA: 0x1C50760
	public Rect get_pixelRect() { }

	// RVA: 0x1C50810 Offset: 0x1C50911 VA: 0x1C50810
	public float get_scaleFactor() { }

	// RVA: 0x1C50860 Offset: 0x1C50961 VA: 0x1C50860
	public void set_scaleFactor(float value) { }

	// RVA: 0x1C508B0 Offset: 0x1C509B1 VA: 0x1C508B0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1C50900 Offset: 0x1C50A01 VA: 0x1C50900
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1C50950 Offset: 0x1C50A51 VA: 0x1C50950
	public bool get_overridePixelPerfect() { }

	// RVA: 0x1C509A0 Offset: 0x1C50AA1 VA: 0x1C509A0
	public void set_overridePixelPerfect(bool value) { }

	// RVA: 0x1C509F0 Offset: 0x1C50AF1 VA: 0x1C509F0
	public bool get_pixelPerfect() { }

	// RVA: 0x1C50A40 Offset: 0x1C50B41 VA: 0x1C50A40
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x1C50A90 Offset: 0x1C50B91 VA: 0x1C50A90
	public float get_planeDistance() { }

	// RVA: 0x1C50AE0 Offset: 0x1C50BE1 VA: 0x1C50AE0
	public void set_planeDistance(float value) { }

	// RVA: 0x1C50B30 Offset: 0x1C50C31 VA: 0x1C50B30
	public int get_renderOrder() { }

	// RVA: 0x1C50B80 Offset: 0x1C50C81 VA: 0x1C50B80
	public bool get_overrideSorting() { }

	// RVA: 0x1C50BD0 Offset: 0x1C50CD1 VA: 0x1C50BD0
	public void set_overrideSorting(bool value) { }

	// RVA: 0x1C50C20 Offset: 0x1C50D21 VA: 0x1C50C20
	public int get_sortingOrder() { }

	// RVA: 0x1C50C70 Offset: 0x1C50D71 VA: 0x1C50C70
	public void set_sortingOrder(int value) { }

	// RVA: 0x1C50CC0 Offset: 0x1C50DC1 VA: 0x1C50CC0
	public int get_targetDisplay() { }

	// RVA: 0x1C50D10 Offset: 0x1C50E11 VA: 0x1C50D10
	public void set_targetDisplay(int value) { }

	// RVA: 0x1C50D60 Offset: 0x1C50E61 VA: 0x1C50D60
	public int get_sortingLayerID() { }

	// RVA: 0x1C50DB0 Offset: 0x1C50EB1 VA: 0x1C50DB0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1C50E00 Offset: 0x1C50F01 VA: 0x1C50E00
	public int get_cachedSortingLayerValue() { }

	// RVA: 0x1C50E50 Offset: 0x1C50F51 VA: 0x1C50E50
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x1C50EA0 Offset: 0x1C50FA1 VA: 0x1C50EA0
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x1C50EF0 Offset: 0x1C50FF1 VA: 0x1C50EF0
	public string get_sortingLayerName() { }

	// RVA: 0x1C50F40 Offset: 0x1C51041 VA: 0x1C50F40
	public void set_sortingLayerName(string value) { }

	// RVA: 0x1C50F90 Offset: 0x1C51091 VA: 0x1C50F90
	public Canvas get_rootCanvas() { }

	// RVA: 0x1C50FE0 Offset: 0x1C510E1 VA: 0x1C50FE0
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0x1C51090 Offset: 0x1C51191 VA: 0x1C51090
	public Camera get_worldCamera() { }

	// RVA: 0x1C510E0 Offset: 0x1C511E1 VA: 0x1C510E0
	public void set_worldCamera(Camera value) { }

	// RVA: 0x1C51130 Offset: 0x1C51231 VA: 0x1C51130
	public float get_normalizedSortingGridSize() { }

	// RVA: 0x1C51180 Offset: 0x1C51281 VA: 0x1C51180
	public void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x1C511D0 Offset: 0x1C512D1 VA: 0x1C511D0
	public int get_sortingGridNormalizedSize() { }

	// RVA: 0x1C51220 Offset: 0x1C51321 VA: 0x1C51220
	public void set_sortingGridNormalizedSize(int value) { }

	[FreeFunctionAttribute] // RVA: 0x68A20 Offset: 0x68B21 VA: 0x68A20
	[ObsoleteAttribute] // RVA: 0x68A20 Offset: 0x68B21 VA: 0x68A20
	// RVA: 0x1C51270 Offset: 0x1C51371 VA: 0x1C51270
	public static Material GetDefaultCanvasTextMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x68A90 Offset: 0x68B91 VA: 0x68A90
	// RVA: 0x1C512B0 Offset: 0x1C513B1 VA: 0x1C512B0
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x68AD0 Offset: 0x68BD1 VA: 0x68AD0
	// RVA: 0x1C512F0 Offset: 0x1C513F1 VA: 0x1C512F0
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x1C51330 Offset: 0x1C51431 VA: 0x1C51330
	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	// RVA: 0x1C51380 Offset: 0x1C51481 VA: 0x1C51380
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x68B10 Offset: 0x68C11 VA: 0x68B10
	// RVA: 0x1C51410 Offset: 0x1C51511 VA: 0x1C51410
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x68B20 Offset: 0x68C21 VA: 0x68B20
	// RVA: 0x1C51470 Offset: 0x1C51571 VA: 0x1C51470
	private static void SendWillRenderCanvases() { }

	// RVA: 0x1C516E0 Offset: 0x1C517E1 VA: 0x1C516E0
	public void .ctor() { }

	// RVA: 0x1C507C0 Offset: 0x1C508C1 VA: 0x1C507C0
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x1C51040 Offset: 0x1C51141 VA: 0x1C51040
	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }
}

