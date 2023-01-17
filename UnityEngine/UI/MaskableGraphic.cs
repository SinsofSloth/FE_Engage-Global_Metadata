// Namespace: UnityEngine.UI
public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 4324
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0x99
	protected Material m_MaskMaterial; // 0xA0
	private RectMask2D m_ParentMask; // 0xA8
	[SerializeField] // RVA: 0x44F10 Offset: 0x45011 VA: 0x44F10
	private bool m_Maskable; // 0xB0
	private bool m_IsMaskingGraphic; // 0xB1
	[ObsoleteAttribute] // RVA: 0x44F20 Offset: 0x45021 VA: 0x44F20
	[EditorBrowsableAttribute] // RVA: 0x44F20 Offset: 0x45021 VA: 0x44F20
	protected bool m_IncludeForMasking; // 0xB2
	[SerializeField] // RVA: 0x44F80 Offset: 0x45081 VA: 0x44F80
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xB8
	[EditorBrowsableAttribute] // RVA: 0x44F90 Offset: 0x45091 VA: 0x44F90
	[ObsoleteAttribute] // RVA: 0x44F90 Offset: 0x45091 VA: 0x44F90
	protected bool m_ShouldRecalculate; // 0xC0
	protected int m_StencilValue; // 0xC4
	private readonly Vector3[] m_Corners; // 0xC8

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	public bool isMaskingGraphic { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x1B6CB00 Offset: 0x1B6CC01 VA: 0x1B6CB00
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x1B6CB10 Offset: 0x1B6CC11 VA: 0x1B6CB10
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x1B6CB20 Offset: 0x1B6CC21 VA: 0x1B6CB20
	public bool get_maskable() { }

	// RVA: 0x1B6CB30 Offset: 0x1B6CC31 VA: 0x1B6CB30
	public void set_maskable(bool value) { }

	// RVA: 0x1B6CB70 Offset: 0x1B6CC71 VA: 0x1B6CB70
	public bool get_isMaskingGraphic() { }

	// RVA: 0x1B6AE20 Offset: 0x1B6AF21 VA: 0x1B6AE20
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x1B6CB80 Offset: 0x1B6CC81 VA: 0x1B6CB80 Slot: 58
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1B6CCB0 Offset: 0x1B6CDB1 VA: 0x1B6CCB0 Slot: 59
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1B6D100 Offset: 0x1B6D201 VA: 0x1B6D100
	private void UpdateCull(bool cull) { }

	// RVA: 0x1B6D1E0 Offset: 0x1B6D2E1 VA: 0x1B6D1E0 Slot: 60
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x1B6D260 Offset: 0x1B6D361 VA: 0x1B6D260 Slot: 61
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x1B6D2A0 Offset: 0x1B6D3A1 VA: 0x1B6D2A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B6D470 Offset: 0x1B6D571 VA: 0x1B6D470 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B6D550 Offset: 0x1B6D651 VA: 0x1B6D550 Slot: 12
	protected override void OnTransformParentChanged() { }

	[ObsoleteAttribute] // RVA: 0x46050 Offset: 0x46151 VA: 0x46050
	[EditorBrowsableAttribute] // RVA: 0x46050 Offset: 0x46151 VA: 0x46050
	// RVA: 0x1B6D5B0 Offset: 0x1B6D6B1 VA: 0x1B6D5B0 Slot: 62
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x1B6D5C0 Offset: 0x1B6D6C1 VA: 0x1B6D5C0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1B6CD10 Offset: 0x1B6CE11 VA: 0x1B6CD10
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1B6D300 Offset: 0x1B6D401 VA: 0x1B6D300
	private void UpdateClipParent() { }

	// RVA: 0x1B6D900 Offset: 0x1B6DA01 VA: 0x1B6D900 Slot: 63
	public virtual void RecalculateClipping() { }

	// RVA: 0x1B6D910 Offset: 0x1B6DA11 VA: 0x1B6D910 Slot: 64
	public virtual void RecalculateMasking() { }

	// RVA: 0x1B6D9B0 Offset: 0x1B6DAB1 VA: 0x1B6D9B0
	protected void .ctor() { }

	// RVA: 0x1B6DAA0 Offset: 0x1B6DBA1 VA: 0x1B6DAA0 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }
}

