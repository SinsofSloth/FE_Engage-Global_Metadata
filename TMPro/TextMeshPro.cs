// Namespace: TMPro
[DisallowMultipleComponent] // RVA: 0x4D0D0 Offset: 0x4D1D1 VA: 0x4D0D0
[RequireComponent] // RVA: 0x4D0D0 Offset: 0x4D1D1 VA: 0x4D0D0
[AddComponentMenu] // RVA: 0x4D0D0 Offset: 0x4D1D1 VA: 0x4D0D0
[ExecuteAlways] // RVA: 0x4D0D0 Offset: 0x4D1D1 VA: 0x4D0D0
[HelpURLAttribute] // RVA: 0x4D0D0 Offset: 0x4D1D1 VA: 0x4D0D0
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 7484
{
	// Fields
	[SerializeField] // RVA: 0x4E490 Offset: 0x4E591 VA: 0x4E490
	private bool m_hasFontAssetChanged; // 0x6C0
	private float m_previousLossyScaleY; // 0x6C4
	[SerializeField] // RVA: 0x4E4A0 Offset: 0x4E5A1 VA: 0x4E4A0
	private Renderer m_renderer; // 0x6C8
	private MeshFilter m_meshFilter; // 0x6D0
	private bool m_isFirstAllocation; // 0x6D8
	private int m_max_characters; // 0x6DC
	private int m_max_numberOfLines; // 0x6E0
	private TMP_SubMesh[] m_subTextObjects; // 0x6E8
	[SerializeField] // RVA: 0x4E4B0 Offset: 0x4E5B1 VA: 0x4E4B0
	private MaskingTypes m_maskType; // 0x6F0
	private Matrix4x4 m_EnvMapMatrix; // 0x6F4
	private Vector3[] m_RectTransformCorners; // 0x738
	private bool m_isRegisteredForEvents; // 0x740
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x88
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0x98
	[SerializeField] // RVA: 0x4E4C0 Offset: 0x4E5C1 VA: 0x4E4C0
	internal int _SortingLayer; // 0x744
	[SerializeField] // RVA: 0x4E4D0 Offset: 0x4E5D1 VA: 0x4E4D0
	internal int _SortingLayerID; // 0x748
	[SerializeField] // RVA: 0x4E4E0 Offset: 0x4E5E1 VA: 0x4E4E0
	internal int _SortingOrder; // 0x74C
	[CompilerGeneratedAttribute] // RVA: 0x4E4F0 Offset: 0x4E5F1 VA: 0x4E4F0
	private Action<TMP_TextInfo> OnPreRenderText; // 0x750
	private bool m_currentAutoSizeMode; // 0x758

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0x4ECF0 Offset: 0x4EDF1 VA: 0x4ECF0
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x1989A80 Offset: 0x1989B81 VA: 0x1989A80 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1989F80 Offset: 0x198A081 VA: 0x1989F80 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x198A200 Offset: 0x198A301 VA: 0x198A200 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x198A2B0 Offset: 0x198A3B1 VA: 0x198A2B0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x198A390 Offset: 0x198A491 VA: 0x198A390 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x198AAE0 Offset: 0x198ABE1 VA: 0x198AAE0
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x198AD40 Offset: 0x198AE41 VA: 0x198AD40
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x198AEA0 Offset: 0x198AFA1 VA: 0x198AEA0
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x198AF50 Offset: 0x198B051 VA: 0x198AF50
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x198B050 Offset: 0x198B151 VA: 0x198B050
	private void EnableMasking() { }

	// RVA: 0x198B240 Offset: 0x198B341 VA: 0x198B240
	private void DisableMasking() { }

	// RVA: 0x198B1B0 Offset: 0x198B2B1 VA: 0x198B1B0
	private void UpdateMask() { }

	// RVA: 0x198B470 Offset: 0x198B571 VA: 0x198B470 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x198B5A0 Offset: 0x198B6A1 VA: 0x198B5A0 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x198B7A0 Offset: 0x198B8A1 VA: 0x198B7A0 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x198B7F0 Offset: 0x198B8F1 VA: 0x198B7F0 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x198B9C0 Offset: 0x198BAC1 VA: 0x198B9C0 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x198BD80 Offset: 0x198BE81 VA: 0x198BD80 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x198BEE0 Offset: 0x198BFE1 VA: 0x198BEE0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x198C000 Offset: 0x198C101 VA: 0x198C000 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x198B3A0 Offset: 0x198B4A1 VA: 0x198B3A0
	private void CreateMaterialInstance() { }

	// RVA: 0x198C120 Offset: 0x198C221 VA: 0x198C120 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x198C210 Offset: 0x198C311 VA: 0x198C210 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x198C4F0 Offset: 0x198C5F1 VA: 0x198C4F0
	private void SetPerspectiveCorrection() { }

	// RVA: 0x198C590 Offset: 0x198C691 VA: 0x198C590 Slot: 114
	internal override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x198E5E0 Offset: 0x198E6E1 VA: 0x198E5E0 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x198E720 Offset: 0x198E821 VA: 0x198E720 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x198E740 Offset: 0x198E841 VA: 0x198E740 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x198E780 Offset: 0x198E881 VA: 0x198E780 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x198E920 Offset: 0x198EA21 VA: 0x198E920 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x198EB70 Offset: 0x198EC71 VA: 0x198EB70
	private void OnPreRenderObject() { }

	// RVA: 0x198EF70 Offset: 0x198F071 VA: 0x198EF70 Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x1996EE0 Offset: 0x1996FE1 VA: 0x1996EE0 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1996F90 Offset: 0x1997091 VA: 0x1996F90
	private void SetMeshFilters(bool state) { }

	// RVA: 0x1997220 Offset: 0x1997321 VA: 0x1997220 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x198EE20 Offset: 0x198EF21 VA: 0x198EE20
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x1997340 Offset: 0x1997441 VA: 0x1997340 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x1997450 Offset: 0x1997551 VA: 0x1997450
	internal void UpdateSubMeshSortingLayerID(int id) { }

	// RVA: 0x1997580 Offset: 0x1997681 VA: 0x1997580
	internal void UpdateSubMeshSortingOrder(int order) { }

	// RVA: 0x19976B0 Offset: 0x19977B1 VA: 0x19976B0 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x198E9D0 Offset: 0x198EAD1 VA: 0x198E9D0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1997910 Offset: 0x1997A11 VA: 0x1997910
	public int get_sortingLayerID() { }

	// RVA: 0x1997A70 Offset: 0x1997B71 VA: 0x1997A70
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1997B30 Offset: 0x1997C31 VA: 0x1997B30
	public int get_sortingOrder() { }

	// RVA: 0x1997BD0 Offset: 0x1997CD1 VA: 0x1997BD0
	public void set_sortingOrder(int value) { }

	// RVA: 0x1997C90 Offset: 0x1997D91 VA: 0x1997C90 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1997CA0 Offset: 0x1997DA1 VA: 0x1997CA0 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x1997D90 Offset: 0x1997E91 VA: 0x1997D90
	public TextContainer get_textContainer() { }

	// RVA: 0x1989EC0 Offset: 0x1989FC1 VA: 0x1989EC0
	public Transform get_transform() { }

	// RVA: 0x19979B0 Offset: 0x1997AB1 VA: 0x19979B0
	public Renderer get_renderer() { }

	// RVA: 0x1997DA0 Offset: 0x1997EA1 VA: 0x1997DA0 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x198A0D0 Offset: 0x198A1D1 VA: 0x198A0D0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x1997E70 Offset: 0x1997F71 VA: 0x1997E70
	public MaskingTypes get_maskType() { }

	// RVA: 0x1997E80 Offset: 0x1997F81 VA: 0x1997E80
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x1997E90 Offset: 0x1997F91 VA: 0x1997E90
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x1997F40 Offset: 0x1998041 VA: 0x1997F40
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x1997FB0 Offset: 0x19980B1 VA: 0x1997FB0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x19980C0 Offset: 0x19981C1 VA: 0x19980C0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x19981B0 Offset: 0x19982B1 VA: 0x19981B0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x19981C0 Offset: 0x19982C1 VA: 0x19981C0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1998210 Offset: 0x1998311 VA: 0x1998210 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1998300 Offset: 0x1998401 VA: 0x1998300 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1998440 Offset: 0x1998541 VA: 0x1998440 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x1998560 Offset: 0x1998661 VA: 0x1998560 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x1998580 Offset: 0x1998681 VA: 0x1998580 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1998600 Offset: 0x1998701 VA: 0x1998600 Slot: 130
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGeneratedAttribute] // RVA: 0x4EAE0 Offset: 0x4EBE1 VA: 0x4EAE0
	// RVA: 0x1998710 Offset: 0x1998811 VA: 0x1998710 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4EAF0 Offset: 0x4EBF1 VA: 0x4EAF0
	// RVA: 0x19987C0 Offset: 0x19988C1 VA: 0x19987C0 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x1998870 Offset: 0x1998971 VA: 0x1998870 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1998880 Offset: 0x1998981 VA: 0x1998880 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1998AE0 Offset: 0x1998BE1 VA: 0x1998AE0 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x1998C50 Offset: 0x1998D51 VA: 0x1998C50
	public void UpdateFontAsset() { }

	// RVA: 0x1998C60 Offset: 0x1998D61 VA: 0x1998C60 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1998C70 Offset: 0x1998D71 VA: 0x1998C70 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1998C80 Offset: 0x1998D81 VA: 0x1998C80
	public void .ctor() { }

	// RVA: 0x1998D70 Offset: 0x1998E71 VA: 0x1998D70
	private static void .cctor() { }
}

