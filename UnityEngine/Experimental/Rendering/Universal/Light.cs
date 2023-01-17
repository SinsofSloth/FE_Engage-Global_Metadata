// Namespace: UnityEngine.Experimental.Rendering.Universal
[HelpURLAttribute] // RVA: 0x480170 Offset: 0x480271 VA: 0x480170
[DisallowMultipleComponent] // RVA: 0x480170 Offset: 0x480271 VA: 0x480170
[ExecuteAlways] // RVA: 0x480170 Offset: 0x480271 VA: 0x480170
[AddComponentMenu] // RVA: 0x480170 Offset: 0x480271 VA: 0x480170
public sealed class Light2D : MonoBehaviour // TypeDefIndex: 5466
{
	// Fields
	[NotKeyableAttribute] // RVA: 0x483BA0 Offset: 0x483CA1 VA: 0x483BA0
	[SerializeField] // RVA: 0x483BA0 Offset: 0x483CA1 VA: 0x483BA0
	private Light2D.LightType m_LightType; // 0x18
	[SerializeField] // RVA: 0x483BE0 Offset: 0x483CE1 VA: 0x483BE0
	[FormerlySerializedAsAttribute] // RVA: 0x483BE0 Offset: 0x483CE1 VA: 0x483BE0
	private int m_BlendStyleIndex; // 0x1C
	[SerializeField] // RVA: 0x483C30 Offset: 0x483D31 VA: 0x483C30
	private float m_FalloffIntensity; // 0x20
	[ColorUsageAttribute] // RVA: 0x483C40 Offset: 0x483D41 VA: 0x483C40
	[SerializeField] // RVA: 0x483C40 Offset: 0x483D41 VA: 0x483C40
	private Color m_Color; // 0x24
	[SerializeField] // RVA: 0x483C80 Offset: 0x483D81 VA: 0x483C80
	private float m_Intensity; // 0x34
	[SerializeField] // RVA: 0x483C90 Offset: 0x483D91 VA: 0x483C90
	private float m_LightVolumeOpacity; // 0x38
	[SerializeField] // RVA: 0x483CA0 Offset: 0x483DA1 VA: 0x483CA0
	private int[] m_ApplyToSortingLayers; // 0x40
	[SerializeField] // RVA: 0x483CB0 Offset: 0x483DB1 VA: 0x483CB0
	private Sprite m_LightCookieSprite; // 0x48
	[SerializeField] // RVA: 0x483CC0 Offset: 0x483DC1 VA: 0x483CC0
	private bool m_UseNormalMap; // 0x50
	[SerializeField] // RVA: 0x483CD0 Offset: 0x483DD1 VA: 0x483CD0
	private int m_LightOrder; // 0x54
	[SerializeField] // RVA: 0x483CE0 Offset: 0x483DE1 VA: 0x483CE0
	private bool m_AlphaBlendOnOverlap; // 0x58
	[RangeAttribute] // RVA: 0x483CF0 Offset: 0x483DF1 VA: 0x483CF0
	[SerializeField] // RVA: 0x483CF0 Offset: 0x483DF1 VA: 0x483CF0
	private float m_ShadowIntensity; // 0x5C
	[RangeAttribute] // RVA: 0x483D30 Offset: 0x483E31 VA: 0x483D30
	[SerializeField] // RVA: 0x483D30 Offset: 0x483E31 VA: 0x483D30
	private float m_ShadowVolumeIntensity; // 0x60
	private int m_PreviousLightCookieSprite; // 0x64
	private Mesh m_Mesh; // 0x68
	private Bounds m_LocalBounds; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x483D70 Offset: 0x483E71 VA: 0x483D70
	private BoundingSphere <boundingSphere>k__BackingField; // 0x88
	[SerializeField] // RVA: 0x483D80 Offset: 0x483E81 VA: 0x483D80
	private float m_PointLightInnerAngle; // 0x98
	[SerializeField] // RVA: 0x483D90 Offset: 0x483E91 VA: 0x483D90
	private float m_PointLightOuterAngle; // 0x9C
	[SerializeField] // RVA: 0x483DA0 Offset: 0x483EA1 VA: 0x483DA0
	private float m_PointLightInnerRadius; // 0xA0
	[SerializeField] // RVA: 0x483DB0 Offset: 0x483EB1 VA: 0x483DB0
	private float m_PointLightOuterRadius; // 0xA4
	[SerializeField] // RVA: 0x483DC0 Offset: 0x483EC1 VA: 0x483DC0
	private float m_PointLightDistance; // 0xA8
	[SerializeField] // RVA: 0x483DD0 Offset: 0x483ED1 VA: 0x483DD0
	[NotKeyableAttribute] // RVA: 0x483DD0 Offset: 0x483ED1 VA: 0x483DD0
	private Light2D.PointLightQuality m_PointLightQuality; // 0xAC
	[SerializeField] // RVA: 0x483E10 Offset: 0x483F11 VA: 0x483E10
	private int m_ShapeLightParametricSides; // 0xB0
	[SerializeField] // RVA: 0x483E20 Offset: 0x483F21 VA: 0x483E20
	private float m_ShapeLightParametricAngleOffset; // 0xB4
	[SerializeField] // RVA: 0x483E30 Offset: 0x483F31 VA: 0x483E30
	private float m_ShapeLightParametricRadius; // 0xB8
	[SerializeField] // RVA: 0x483E40 Offset: 0x483F41 VA: 0x483E40
	private float m_ShapeLightFalloffSize; // 0xBC
	[SerializeField] // RVA: 0x483E50 Offset: 0x483F51 VA: 0x483E50
	private Vector2 m_ShapeLightFalloffOffset; // 0xC0
	[SerializeField] // RVA: 0x483E60 Offset: 0x483F61 VA: 0x483E60
	private Vector3[] m_ShapePath; // 0xC8
	private float m_PreviousShapeLightFalloffSize; // 0xD0
	private int m_PreviousShapeLightParametricSides; // 0xD4
	private float m_PreviousShapeLightParametricAngleOffset; // 0xD8
	private float m_PreviousShapeLightParametricRadius; // 0xDC

	// Properties
	internal int[] affectedSortingLayers { get; }
	private int lightCookieSpriteInstanceID { get; }
	internal BoundingSphere boundingSphere { get; set; }
	internal Mesh lightMesh { get; }
	public Light2D.LightType lightType { get; set; }
	public int blendStyleIndex { get; set; }
	public float shadowIntensity { get; set; }
	public float shadowVolumeIntensity { get; set; }
	public Color color { get; set; }
	public float intensity { get; set; }
	public float volumeOpacity { get; }
	public Sprite lightCookieSprite { get; }
	public float falloffIntensity { get; }
	public bool useNormalMap { get; }
	public bool alphaBlendOnOverlap { get; }
	public int lightOrder { get; set; }
	public float pointLightInnerAngle { get; set; }
	public float pointLightOuterAngle { get; set; }
	public float pointLightInnerRadius { get; set; }
	public float pointLightOuterRadius { get; set; }
	public float pointLightDistance { get; }
	public Light2D.PointLightQuality pointLightQuality { get; }
	internal bool isPointLight { get; }
	public int shapeLightParametricSides { get; }
	public float shapeLightParametricAngleOffset { get; }
	public float shapeLightParametricRadius { get; }
	public float shapeLightFalloffSize { get; }
	public Vector2 shapeLightFalloffOffset { get; }
	public Vector3[] shapePath { get; }

	// Methods

	// RVA: 0x3149AB0 Offset: 0x3149BB1 VA: 0x3149AB0
	internal int[] get_affectedSortingLayers() { }

	// RVA: 0x3149AC0 Offset: 0x3149BC1 VA: 0x3149AC0
	private int get_lightCookieSpriteInstanceID() { }

	[CompilerGeneratedAttribute] // RVA: 0x4850F0 Offset: 0x4851F1 VA: 0x4850F0
	// RVA: 0x3149AE0 Offset: 0x3149BE1 VA: 0x3149AE0
	internal BoundingSphere get_boundingSphere() { }

	[CompilerGeneratedAttribute] // RVA: 0x485100 Offset: 0x485201 VA: 0x485100
	// RVA: 0x3149AF0 Offset: 0x3149BF1 VA: 0x3149AF0
	private void set_boundingSphere(BoundingSphere value) { }

	// RVA: 0x3149B10 Offset: 0x3149C11 VA: 0x3149B10
	internal Mesh get_lightMesh() { }

	// RVA: 0x3149B20 Offset: 0x3149C21 VA: 0x3149B20
	public Light2D.LightType get_lightType() { }

	// RVA: 0x3149B30 Offset: 0x3149C31 VA: 0x3149B30
	public void set_lightType(Light2D.LightType value) { }

	// RVA: 0x3149E50 Offset: 0x3149F51 VA: 0x3149E50
	public int get_blendStyleIndex() { }

	// RVA: 0x3149E60 Offset: 0x3149F61 VA: 0x3149E60
	public void set_blendStyleIndex(int value) { }

	// RVA: 0x3149E70 Offset: 0x3149F71 VA: 0x3149E70
	public float get_shadowIntensity() { }

	// RVA: 0x3149E80 Offset: 0x3149F81 VA: 0x3149E80
	public void set_shadowIntensity(float value) { }

	// RVA: 0x3149EB0 Offset: 0x3149FB1 VA: 0x3149EB0
	public float get_shadowVolumeIntensity() { }

	// RVA: 0x3149EC0 Offset: 0x3149FC1 VA: 0x3149EC0
	public void set_shadowVolumeIntensity(float value) { }

	// RVA: 0x3149EF0 Offset: 0x3149FF1 VA: 0x3149EF0
	public Color get_color() { }

	// RVA: 0x3149F00 Offset: 0x314A001 VA: 0x3149F00
	public void set_color(Color value) { }

	// RVA: 0x3149F20 Offset: 0x314A021 VA: 0x3149F20
	public float get_intensity() { }

	// RVA: 0x3149F30 Offset: 0x314A031 VA: 0x3149F30
	public void set_intensity(float value) { }

	// RVA: 0x3149F40 Offset: 0x314A041 VA: 0x3149F40
	public float get_volumeOpacity() { }

	// RVA: 0x3149F50 Offset: 0x314A051 VA: 0x3149F50
	public Sprite get_lightCookieSprite() { }

	// RVA: 0x3149F60 Offset: 0x314A061 VA: 0x3149F60
	public float get_falloffIntensity() { }

	// RVA: 0x3149F70 Offset: 0x314A071 VA: 0x3149F70
	public bool get_useNormalMap() { }

	// RVA: 0x3149F80 Offset: 0x314A081 VA: 0x3149F80
	public bool get_alphaBlendOnOverlap() { }

	// RVA: 0x3149F90 Offset: 0x314A091 VA: 0x3149F90
	public int get_lightOrder() { }

	// RVA: 0x3149FA0 Offset: 0x314A0A1 VA: 0x3149FA0
	public void set_lightOrder(int value) { }

	// RVA: 0x3149FB0 Offset: 0x314A0B1 VA: 0x3149FB0
	internal int GetTopMostLitLayer() { }

	// RVA: 0x3149BC0 Offset: 0x3149CC1 VA: 0x3149BC0
	internal void UpdateMesh() { }

	// RVA: 0x314B980 Offset: 0x314BA81 VA: 0x314B980
	internal void UpdateBoundingSphere() { }

	// RVA: 0x314BC00 Offset: 0x314BD01 VA: 0x314BC00
	internal bool IsLitLayer(int layer) { }

	// RVA: 0x314BC70 Offset: 0x314BD71 VA: 0x314BC70
	private void Awake() { }

	// RVA: 0x314BCF0 Offset: 0x314BDF1 VA: 0x314BCF0
	private void OnEnable() { }

	// RVA: 0x314BE70 Offset: 0x314BF71 VA: 0x314BE70
	private void OnDisable() { }

	// RVA: 0x314BFC0 Offset: 0x314C0C1 VA: 0x314BFC0
	private void LateUpdate() { }

	// RVA: 0x314C0B0 Offset: 0x314C1B1 VA: 0x314C0B0
	public float get_pointLightInnerAngle() { }

	// RVA: 0x314C0C0 Offset: 0x314C1C1 VA: 0x314C0C0
	public void set_pointLightInnerAngle(float value) { }

	// RVA: 0x314C0D0 Offset: 0x314C1D1 VA: 0x314C0D0
	public float get_pointLightOuterAngle() { }

	// RVA: 0x314C0E0 Offset: 0x314C1E1 VA: 0x314C0E0
	public void set_pointLightOuterAngle(float value) { }

	// RVA: 0x314C0F0 Offset: 0x314C1F1 VA: 0x314C0F0
	public float get_pointLightInnerRadius() { }

	// RVA: 0x314C100 Offset: 0x314C201 VA: 0x314C100
	public void set_pointLightInnerRadius(float value) { }

	// RVA: 0x314C110 Offset: 0x314C211 VA: 0x314C110
	public float get_pointLightOuterRadius() { }

	// RVA: 0x314C120 Offset: 0x314C221 VA: 0x314C120
	public void set_pointLightOuterRadius(float value) { }

	// RVA: 0x314C130 Offset: 0x314C231 VA: 0x314C130
	public float get_pointLightDistance() { }

	// RVA: 0x314C140 Offset: 0x314C241 VA: 0x314C140
	public Light2D.PointLightQuality get_pointLightQuality() { }

	// RVA: 0x314BBF0 Offset: 0x314BCF1 VA: 0x314BBF0
	internal bool get_isPointLight() { }

	// RVA: 0x314C150 Offset: 0x314C251 VA: 0x314C150
	public int get_shapeLightParametricSides() { }

	// RVA: 0x314C160 Offset: 0x314C261 VA: 0x314C160
	public float get_shapeLightParametricAngleOffset() { }

	// RVA: 0x314C170 Offset: 0x314C271 VA: 0x314C170
	public float get_shapeLightParametricRadius() { }

	// RVA: 0x314C180 Offset: 0x314C281 VA: 0x314C180
	public float get_shapeLightFalloffSize() { }

	// RVA: 0x314C190 Offset: 0x314C291 VA: 0x314C190
	public Vector2 get_shapeLightFalloffOffset() { }

	// RVA: 0x314C1A0 Offset: 0x314C2A1 VA: 0x314C1A0
	public Vector3[] get_shapePath() { }

	// RVA: 0x314C1B0 Offset: 0x314C2B1 VA: 0x314C1B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.Universal
[MovedFromAttribute] // RVA: 0x4801F0 Offset: 0x4802F1 VA: 0x4801F0
[Serializable]
public struct Light2DBlendStyle // TypeDefIndex: 5471
{
	// Fields
	public string name; // 0x0
	[SerializeField] // RVA: 0x483E70 Offset: 0x483F71 VA: 0x483E70
	internal Light2DBlendStyle.TextureChannel maskTextureChannel; // 0x8
	[RangeAttribute] // RVA: 0x483E80 Offset: 0x483F81 VA: 0x483E80
	[SerializeField] // RVA: 0x483E80 Offset: 0x483F81 VA: 0x483E80
	internal float renderTextureScale; // 0xC
	[SerializeField] // RVA: 0x483ED0 Offset: 0x483FD1 VA: 0x483ED0
	internal Light2DBlendStyle.BlendMode blendMode; // 0x10
	[SerializeField] // RVA: 0x483EE0 Offset: 0x483FE1 VA: 0x483EE0
	internal Light2DBlendStyle.BlendFactors customBlendFactors; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x483EF0 Offset: 0x483FF1 VA: 0x483EF0
	private bool <isDirty>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x483F00 Offset: 0x484001 VA: 0x483F00
	private bool <hasRenderTarget>k__BackingField; // 0x1D
	internal RenderTargetHandle renderTargetHandle; // 0x20

	// Properties
	internal Vector2 blendFactors { get; }
	internal Light2DBlendStyle.MaskChannelFilter maskTextureChannelFilter { get; }
	internal bool isDirty { get; set; }
	internal bool hasRenderTarget { get; set; }

	// Methods

	// RVA: 0x314C2A0 Offset: 0x314C3A1 VA: 0x314C2A0
	internal Vector2 get_blendFactors() { }

	// RVA: 0x314C320 Offset: 0x314C421 VA: 0x314C320
	internal Light2DBlendStyle.MaskChannelFilter get_maskTextureChannelFilter() { }

	[IsReadOnlyAttribute] // RVA: 0x485110 Offset: 0x485211 VA: 0x485110
	[CompilerGeneratedAttribute] // RVA: 0x485110 Offset: 0x485211 VA: 0x485110
	// RVA: 0x314C5A0 Offset: 0x314C6A1 VA: 0x314C5A0
	internal bool get_isDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x485150 Offset: 0x485251 VA: 0x485150
	// RVA: 0x314C5B0 Offset: 0x314C6B1 VA: 0x314C5B0
	internal void set_isDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x485160 Offset: 0x485261 VA: 0x485160
	[IsReadOnlyAttribute] // RVA: 0x485160 Offset: 0x485261 VA: 0x485160
	// RVA: 0x314C5C0 Offset: 0x314C6C1 VA: 0x314C5C0
	internal bool get_hasRenderTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x4851A0 Offset: 0x4852A1 VA: 0x4851A0
	// RVA: 0x314C5D0 Offset: 0x314C6D1 VA: 0x314C5D0
	internal void set_hasRenderTarget(bool value) { }
}

// Namespace: UnityEngine.Experimental.Rendering.Universal
internal class Light2DCullResult : ILight2DCullResult // TypeDefIndex: 5475
{
	// Fields
	private List<Light2D> m_VisibleLights; // 0x10

	// Properties
	public List<Light2D> visibleLights { get; }

	// Methods

	// RVA: 0x314C5E0 Offset: 0x314C6E1 VA: 0x314C5E0 Slot: 4
	public List<Light2D> get_visibleLights() { }

	// RVA: 0x314C5F0 Offset: 0x314C6F1 VA: 0x314C5F0 Slot: 6
	public bool IsSceneLit() { }

	// RVA: 0x314C800 Offset: 0x314C901 VA: 0x314C800 Slot: 5
	public LightStats GetLightStatsByLayer(int layer) { }

	// RVA: 0x314C9B0 Offset: 0x314CAB1 VA: 0x314C9B0
	public void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera) { }

	// RVA: 0x314CE00 Offset: 0x314CF01 VA: 0x314CE00
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.Universal
internal static class Light2DManager // TypeDefIndex: 5476
{
	// Fields
	private static SortingLayer[] s_SortingLayers; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x483F30 Offset: 0x484031 VA: 0x483F30
	private static readonly List<Light2D> <lights>k__BackingField; // 0x8

	// Properties
	public static List<Light2D> lights { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x485250 Offset: 0x485351 VA: 0x485250
	// RVA: 0x314D550 Offset: 0x314D651 VA: 0x314D550
	public static List<Light2D> get_lights() { }

	// RVA: 0x314BD80 Offset: 0x314BE81 VA: 0x314BD80
	public static void RegisterLight(Light2D light) { }

	// RVA: 0x314BEE0 Offset: 0x314BFE1 VA: 0x314BEE0
	public static void DeregisterLight(Light2D light) { }

	// RVA: 0x3149CA0 Offset: 0x3149DA1 VA: 0x3149CA0
	public static void ErrorIfDuplicateGlobalLight(Light2D light) { }

	// RVA: 0x314D870 Offset: 0x314D971 VA: 0x314D870
	public static bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, out Color color) { }

	// RVA: 0x314D5C0 Offset: 0x314D6C1 VA: 0x314D5C0
	private static bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex) { }

	// RVA: 0x314A0E0 Offset: 0x314A1E1 VA: 0x314A0E0
	public static SortingLayer[] GetCachedSortingLayer() { }

	// RVA: 0x314DAE0 Offset: 0x314DBE1 VA: 0x314DAE0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering.Universal
internal static class Light2DLookupTexture // TypeDefIndex: 5483
{
	// Fields
	private static Texture2D s_PointLightLookupTexture; // 0x0
	private static Texture2D s_FalloffLookupTexture; // 0x8

	// Methods

	// RVA: 0x314CE90 Offset: 0x314CF91 VA: 0x314CE90
	public static Texture GetLightLookupTexture() { }

	// RVA: 0x314D2D0 Offset: 0x314D3D1 VA: 0x314D2D0
	public static Texture GetFalloffLookupTexture() { }

	// RVA: 0x314CF50 Offset: 0x314D051 VA: 0x314CF50
	private static Texture2D CreatePointLightLookupTexture() { }

	// RVA: 0x314D390 Offset: 0x314D491 VA: 0x314D390
	private static Texture2D CreateFalloffLookupTexture() { }
}

