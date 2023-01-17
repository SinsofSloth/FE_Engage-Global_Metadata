// Namespace: TMPro
[RequireComponent] // RVA: 0x4D1A0 Offset: 0x4D2A1 VA: 0x4D1A0
[DisallowMultipleComponent] // RVA: 0x4D1A0 Offset: 0x4D2A1 VA: 0x4D1A0
[AddComponentMenu] // RVA: 0x4D1A0 Offset: 0x4D2A1 VA: 0x4D1A0
[ExecuteAlways] // RVA: 0x4D1A0 Offset: 0x4D2A1 VA: 0x4D1A0
[RequireComponent] // RVA: 0x4D1A0 Offset: 0x4D2A1 VA: 0x4D1A0
[HelpURLAttribute] // RVA: 0x4D1A0 Offset: 0x4D2A1 VA: 0x4D1A0
public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 7487
{
	// Fields
	[SerializeField] // RVA: 0x4E500 Offset: 0x4E601 VA: 0x4E500
	private bool m_hasFontAssetChanged; // 0x6C0
	protected TMP_SubMeshUI[] m_subTextObjects; // 0x6C8
	private float m_previousLossyScaleY; // 0x6D0
	private Vector3[] m_RectTransformCorners; // 0x6D8
	private CanvasRenderer m_canvasRenderer; // 0x6E0
	private Canvas m_canvas; // 0x6E8
	private float m_CanvasScaleFactor; // 0x6F0
	private bool m_isFirstAllocation; // 0x6F4
	private int m_max_characters; // 0x6F8
	[SerializeField] // RVA: 0x4E510 Offset: 0x4E611 VA: 0x4E510
	private Material m_baseMaterial; // 0x700
	private bool m_isScrollRegionSet; // 0x708
	[SerializeField] // RVA: 0x4E520 Offset: 0x4E621 VA: 0x4E520
	private Vector4 m_maskOffset; // 0x70C
	private Matrix4x4 m_EnvMapMatrix; // 0x71C
	private bool m_isRegisteredForEvents; // 0x75C
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
	private bool m_isRebuildingLayout; // 0x75D
	private Coroutine m_DelayedGraphicRebuild; // 0x760
	private Coroutine m_DelayedMaterialRebuild; // 0x768
	private Rect m_ClipRect; // 0x770
	private bool m_ValidRect; // 0x780
	[CompilerGeneratedAttribute] // RVA: 0x4E530 Offset: 0x4E631 VA: 0x4E530
	private Action<TMP_TextInfo> OnPreRenderText; // 0x788

	// Properties
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x1B59840 Offset: 0x1B59941 VA: 0x1B59840 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1B59C60 Offset: 0x1B59D61 VA: 0x1B59C60 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B59F40 Offset: 0x1B5A041 VA: 0x1B59F40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B5A110 Offset: 0x1B5A211 VA: 0x1B5A110 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1B5A2C0 Offset: 0x1B5A3C1 VA: 0x1B5A2C0 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x1B59DC0 Offset: 0x1B59EC1 VA: 0x1B59DC0
	private Canvas GetCanvas() { }

	// RVA: 0x1B5A990 Offset: 0x1B5AA91 VA: 0x1B5A990
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x1B5ABF0 Offset: 0x1B5ACF1 VA: 0x1B5ABF0
	private void EnableMasking() { }

	// RVA: 0x1B5B1A0 Offset: 0x1B5B2A1 VA: 0x1B5B1A0
	private void DisableMasking() { }

	// RVA: 0x1B5ADD0 Offset: 0x1B5AED1 VA: 0x1B5ADD0
	private void UpdateMask() { }

	// RVA: 0x1B5B1B0 Offset: 0x1B5B2B1 VA: 0x1B5B1B0 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1B5B310 Offset: 0x1B5B411 VA: 0x1B5B310 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1B5B510 Offset: 0x1B5B611 VA: 0x1B5B510 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1B5B560 Offset: 0x1B5B661 VA: 0x1B5B560 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1B5B730 Offset: 0x1B5B831 VA: 0x1B5B730 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1B5BB80 Offset: 0x1B5BC81 VA: 0x1B5BB80 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1B5BD70 Offset: 0x1B5BE71 VA: 0x1B5BD70 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1B5BEA0 Offset: 0x1B5BFA1 VA: 0x1B5BEA0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1B5BFD0 Offset: 0x1B5C0D1 VA: 0x1B5BFD0 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x1B5C120 Offset: 0x1B5C221 VA: 0x1B5C120 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x1B5C460 Offset: 0x1B5C561 VA: 0x1B5C460
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1B5C500 Offset: 0x1B5C601 VA: 0x1B5C500
	private void SetMeshArrays(int size) { }

	// RVA: 0x1B5C560 Offset: 0x1B5C661 VA: 0x1B5C560 Slot: 114
	internal override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x1B5E720 Offset: 0x1B5E821 VA: 0x1B5E720 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x1B5E860 Offset: 0x1B5E961 VA: 0x1B5E860 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1B5E8B0 Offset: 0x1B5E9B1 VA: 0x1B5E8B0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1B5EA10 Offset: 0x1B5EB11 VA: 0x1B5EA10 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1B5EA70 Offset: 0x1B5EB71 VA: 0x1B5EA70 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1B5ED80 Offset: 0x1B5EE81 VA: 0x1B5ED80 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x1B5F030 Offset: 0x1B5F131 VA: 0x1B5F030
	private void OnPreRenderCanvas() { }

	// RVA: 0x1B5F2D0 Offset: 0x1B5F3D1 VA: 0x1B5F2D0 Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x1B67370 Offset: 0x1B67471 VA: 0x1B67370 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1B67420 Offset: 0x1B67521 VA: 0x1B67420 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1B67540 Offset: 0x1B67641 VA: 0x1B67540 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x1B67650 Offset: 0x1B67751 VA: 0x1B67650 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1B678B0 Offset: 0x1B679B1 VA: 0x1B678B0 Slot: 117
	internal override Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x1B5EE30 Offset: 0x1B5EF31 VA: 0x1B5EE30
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1B67AB0 Offset: 0x1B67BB1 VA: 0x1B67AB0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x1B67B30 Offset: 0x1B67C31 VA: 0x1B67B30 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1B67B40 Offset: 0x1B67C41 VA: 0x1B67B40 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x1B67C00 Offset: 0x1B67D01 VA: 0x1B67C00 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x1B67C10 Offset: 0x1B67D11 VA: 0x1B67C10
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1B67CD0 Offset: 0x1B67DD1 VA: 0x1B67CD0 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1B67CE0 Offset: 0x1B67DE1 VA: 0x1B67CE0 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1B67CF0 Offset: 0x1B67DF1 VA: 0x1B67CF0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1B67E00 Offset: 0x1B67F01 VA: 0x1B67E00 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1B67F10 Offset: 0x1B68011 VA: 0x1B67F10 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x1B68030 Offset: 0x1B68131 VA: 0x1B68030 Slot: 26
	public override void SetAllDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x4EB00 Offset: 0x4EC01 VA: 0x4EB00
	// RVA: 0x1B68080 Offset: 0x1B68181 VA: 0x1B68080
	private IEnumerator DelayedGraphicRebuild() { }

	[IteratorStateMachineAttribute] // RVA: 0x4EB70 Offset: 0x4EC71 VA: 0x4EB70
	// RVA: 0x1B68100 Offset: 0x1B68201 VA: 0x1B68100
	private IEnumerator DelayedMaterialRebuild() { }

	// RVA: 0x1B68180 Offset: 0x1B68281 VA: 0x1B68180 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1B5EC90 Offset: 0x1B5ED91 VA: 0x1B5EC90
	private void UpdateSubObjectPivot() { }

	// RVA: 0x1B68270 Offset: 0x1B68371 VA: 0x1B68270 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1B683A0 Offset: 0x1B684A1 VA: 0x1B683A0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1B684A0 Offset: 0x1B685A1 VA: 0x1B684A0
	public Vector4 get_maskOffset() { }

	// RVA: 0x1B684C0 Offset: 0x1B685C1 VA: 0x1B684C0
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0x1B68500 Offset: 0x1B68601 VA: 0x1B68500 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x1B68510 Offset: 0x1B68611 VA: 0x1B68510 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1B68770 Offset: 0x1B68871 VA: 0x1B68770 Slot: 102
	internal override void UpdateCulling() { }

	// RVA: 0x1B68940 Offset: 0x1B68A41 VA: 0x1B68940 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x1B68A60 Offset: 0x1B68B61 VA: 0x1B68A60 Slot: 112
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1B68B40 Offset: 0x1B68C41 VA: 0x1B68B40 Slot: 113
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1B68BF0 Offset: 0x1B68CF1 VA: 0x1B68BF0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x1B68CC0 Offset: 0x1B68DC1 VA: 0x1B68CC0 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1B68DD0 Offset: 0x1B68ED1 VA: 0x1B68DD0 Slot: 129
	public override void ClearMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x4EBE0 Offset: 0x4ECE1 VA: 0x4EBE0
	// RVA: 0x1B68EE0 Offset: 0x1B68FE1 VA: 0x1B68EE0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4EBF0 Offset: 0x4ECF1 VA: 0x4EBF0
	// RVA: 0x1B68F90 Offset: 0x1B69091 VA: 0x1B68F90 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x1B69040 Offset: 0x1B69141 VA: 0x1B69040 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1B690C0 Offset: 0x1B691C1 VA: 0x1B690C0 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1B69390 Offset: 0x1B69491 VA: 0x1B69390 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x1B69530 Offset: 0x1B69631 VA: 0x1B69530
	public void UpdateFontAsset() { }

	// RVA: 0x1B69540 Offset: 0x1B69641 VA: 0x1B69540
	public void .ctor() { }

	// RVA: 0x1B69630 Offset: 0x1B69731 VA: 0x1B69630
	private static void .cctor() { }
}

