// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43C9A0 Offset: 0x43CAA1 VA: 0x43C9A0
[NativeHeaderAttribute] // RVA: 0x43C9A0 Offset: 0x43CAA1 VA: 0x43C9A0
[NativeHeaderAttribute] // RVA: 0x43C9A0 Offset: 0x43CAA1 VA: 0x43C9A0
[RequireComponent] // RVA: 0x43C9A0 Offset: 0x43CAA1 VA: 0x43C9A0
public class Renderer : Component // TypeDefIndex: 3457
{
	// Properties
	public Bounds bounds { get; }
	public bool enabled { get; set; }
	public bool isVisible { get; }
	public ShadowCastingMode shadowCastingMode { get; set; }
	public bool receiveShadows { set; }
	public MotionVectorGenerationMode motionVectorGenerationMode { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public int lightmapIndex { get; set; }
	public Vector4 lightmapScaleOffset { get; set; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x448220 Offset: 0x448321 VA: 0x448220
	// RVA: 0x31DFEC0 Offset: 0x31DFFC1 VA: 0x31DFEC0
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x448270 Offset: 0x448371 VA: 0x448270
	// RVA: 0x31DFF90 Offset: 0x31E0091 VA: 0x31DFF90
	private void SetStaticLightmapST(Vector4 st) { }

	[FreeFunctionAttribute] // RVA: 0x4482C0 Offset: 0x4483C1 VA: 0x4482C0
	// RVA: 0x31E0040 Offset: 0x31E0141 VA: 0x31E0040
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x448310 Offset: 0x448411 VA: 0x448310
	// RVA: 0x31E0090 Offset: 0x31E0191 VA: 0x31E0090
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x448360 Offset: 0x448461 VA: 0x448360
	// RVA: 0x31E00E0 Offset: 0x31E01E1 VA: 0x31E00E0
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x4483B0 Offset: 0x4484B1 VA: 0x4483B0
	// RVA: 0x31E0130 Offset: 0x31E0231 VA: 0x31E0130
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x448400 Offset: 0x448501 VA: 0x448400
	// RVA: 0x31E0180 Offset: 0x31E0281 VA: 0x31E0180
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x448450 Offset: 0x448551 VA: 0x448450
	// RVA: 0x31E01D0 Offset: 0x31E02D1 VA: 0x31E01D0
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x31E0220 Offset: 0x31E0321 VA: 0x31E0220
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x31E0270 Offset: 0x31E0371 VA: 0x31E0270
	public bool get_enabled() { }

	// RVA: 0x31E02C0 Offset: 0x31E03C1 VA: 0x31E02C0
	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x4484A0 Offset: 0x4485A1 VA: 0x4484A0
	// RVA: 0x31E0310 Offset: 0x31E0411 VA: 0x31E0310
	public bool get_isVisible() { }

	// RVA: 0x31E0360 Offset: 0x31E0461 VA: 0x31E0360
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x31E03B0 Offset: 0x31E04B1 VA: 0x31E03B0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x31E0400 Offset: 0x31E0501 VA: 0x31E0400
	public void set_receiveShadows(bool value) { }

	// RVA: 0x31E0450 Offset: 0x31E0551 VA: 0x31E0450
	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	// RVA: 0x31E04A0 Offset: 0x31E05A1 VA: 0x31E04A0
	public int get_sortingLayerID() { }

	// RVA: 0x31E04F0 Offset: 0x31E05F1 VA: 0x31E04F0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x31E0540 Offset: 0x31E0641 VA: 0x31E0540
	public int get_sortingOrder() { }

	// RVA: 0x31E0590 Offset: 0x31E0691 VA: 0x31E0590
	public void set_sortingOrder(int value) { }

	[NativeNameAttribute] // RVA: 0x4484E0 Offset: 0x4485E1 VA: 0x4484E0
	// RVA: 0x31E05E0 Offset: 0x31E06E1 VA: 0x31E05E0
	private int GetLightmapIndex(LightmapType lt) { }

	[NativeNameAttribute] // RVA: 0x448520 Offset: 0x448621 VA: 0x448520
	// RVA: 0x31E0630 Offset: 0x31E0731 VA: 0x31E0630
	private void SetLightmapIndex(int index, LightmapType lt) { }

	[NativeNameAttribute] // RVA: 0x448560 Offset: 0x448661 VA: 0x448560
	// RVA: 0x31E0690 Offset: 0x31E0791 VA: 0x31E0690
	private Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0x31E0760 Offset: 0x31E0861 VA: 0x31E0760
	public int get_lightmapIndex() { }

	// RVA: 0x31E07B0 Offset: 0x31E08B1 VA: 0x31E07B0
	public void set_lightmapIndex(int value) { }

	// RVA: 0x31E0810 Offset: 0x31E0911 VA: 0x31E0810
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x31E0870 Offset: 0x31E0971 VA: 0x31E0870
	public void set_lightmapScaleOffset(Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x4485A0 Offset: 0x4486A1 VA: 0x4485A0
	// RVA: 0x31E08D0 Offset: 0x31E09D1 VA: 0x31E08D0
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x31E0920 Offset: 0x31E0A21 VA: 0x31E0920
	public Material[] get_materials() { }

	// RVA: 0x31E0970 Offset: 0x31E0A71 VA: 0x31E0970
	public void set_materials(Material[] value) { }

	// RVA: 0x31E09C0 Offset: 0x31E0AC1 VA: 0x31E09C0
	public Material get_material() { }

	// RVA: 0x31E0A10 Offset: 0x31E0B11 VA: 0x31E0A10
	public void set_material(Material value) { }

	// RVA: 0x31E0A60 Offset: 0x31E0B61 VA: 0x31E0A60
	public Material get_sharedMaterial() { }

	// RVA: 0x31E0AB0 Offset: 0x31E0BB1 VA: 0x31E0AB0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x31E0B00 Offset: 0x31E0C01 VA: 0x31E0B00
	public Material[] get_sharedMaterials() { }

	// RVA: 0x31E0B50 Offset: 0x31E0C51 VA: 0x31E0B50
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x31E0BA0 Offset: 0x31E0CA1 VA: 0x31E0BA0
	public void .ctor() { }

	// RVA: 0x31DFF40 Offset: 0x31E0041 VA: 0x31DFF40
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x31DFFF0 Offset: 0x31E00F1 VA: 0x31DFFF0
	private void SetStaticLightmapST_Injected(ref Vector4 st) { }

	// RVA: 0x31E0700 Offset: 0x31E0801 VA: 0x31E0700
	private void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) { }
}

