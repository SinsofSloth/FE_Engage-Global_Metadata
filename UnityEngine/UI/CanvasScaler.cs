// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42C50 Offset: 0x42D51 VA: 0x42C50
[DisallowMultipleComponent] // RVA: 0x42C50 Offset: 0x42D51 VA: 0x42C50
[ExecuteAlways] // RVA: 0x42C50 Offset: 0x42D51 VA: 0x42C50
[RequireComponent] // RVA: 0x42C50 Offset: 0x42D51 VA: 0x42C50
public class CanvasScaler : UIBehaviour // TypeDefIndex: 4299
{
	// Fields
	[SerializeField] // RVA: 0x44A10 Offset: 0x44B11 VA: 0x44A10
	[TooltipAttribute] // RVA: 0x44A10 Offset: 0x44B11 VA: 0x44A10
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x18
	[SerializeField] // RVA: 0x44A60 Offset: 0x44B61 VA: 0x44A60
	[TooltipAttribute] // RVA: 0x44A60 Offset: 0x44B61 VA: 0x44A60
	protected float m_ReferencePixelsPerUnit; // 0x1C
	[TooltipAttribute] // RVA: 0x44AB0 Offset: 0x44BB1 VA: 0x44AB0
	[SerializeField] // RVA: 0x44AB0 Offset: 0x44BB1 VA: 0x44AB0
	protected float m_ScaleFactor; // 0x20
	[TooltipAttribute] // RVA: 0x44B00 Offset: 0x44C01 VA: 0x44B00
	[SerializeField] // RVA: 0x44B00 Offset: 0x44C01 VA: 0x44B00
	protected Vector2 m_ReferenceResolution; // 0x24
	[TooltipAttribute] // RVA: 0x44B50 Offset: 0x44C51 VA: 0x44B50
	[SerializeField] // RVA: 0x44B50 Offset: 0x44C51 VA: 0x44B50
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x2C
	[SerializeField] // RVA: 0x44BA0 Offset: 0x44CA1 VA: 0x44BA0
	[RangeAttribute] // RVA: 0x44BA0 Offset: 0x44CA1 VA: 0x44BA0
	[TooltipAttribute] // RVA: 0x44BA0 Offset: 0x44CA1 VA: 0x44BA0
	protected float m_MatchWidthOrHeight; // 0x30
	private const float kLogBase = 2;
	[SerializeField] // RVA: 0x44C10 Offset: 0x44D11 VA: 0x44C10
	[TooltipAttribute] // RVA: 0x44C10 Offset: 0x44D11 VA: 0x44C10
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x34
	[SerializeField] // RVA: 0x44C60 Offset: 0x44D61 VA: 0x44C60
	[TooltipAttribute] // RVA: 0x44C60 Offset: 0x44D61 VA: 0x44C60
	protected float m_FallbackScreenDPI; // 0x38
	[TooltipAttribute] // RVA: 0x44CB0 Offset: 0x44DB1 VA: 0x44CB0
	[SerializeField] // RVA: 0x44CB0 Offset: 0x44DB1 VA: 0x44CB0
	protected float m_DefaultSpriteDPI; // 0x3C
	[SerializeField] // RVA: 0x44D00 Offset: 0x44E01 VA: 0x44D00
	[TooltipAttribute] // RVA: 0x44D00 Offset: 0x44E01 VA: 0x44D00
	protected float m_DynamicPixelsPerUnit; // 0x40
	private Canvas m_Canvas; // 0x48
	private float m_PrevScaleFactor; // 0x50
	private float m_PrevReferencePixelsPerUnit; // 0x54
	[SerializeField] // RVA: 0x44D50 Offset: 0x44E51 VA: 0x44D50
	protected bool m_PresetInfoIsWorld; // 0x58

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x1A40280 Offset: 0x1A40381 VA: 0x1A40280
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x1A40290 Offset: 0x1A40391 VA: 0x1A40290
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x1A402A0 Offset: 0x1A403A1 VA: 0x1A402A0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1A402B0 Offset: 0x1A403B1 VA: 0x1A402B0
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1A402C0 Offset: 0x1A403C1 VA: 0x1A402C0
	public float get_scaleFactor() { }

	// RVA: 0x1A402D0 Offset: 0x1A403D1 VA: 0x1A402D0
	public void set_scaleFactor(float value) { }

	// RVA: 0x1A40310 Offset: 0x1A40411 VA: 0x1A40310
	public Vector2 get_referenceResolution() { }

	// RVA: 0x1A40320 Offset: 0x1A40421 VA: 0x1A40320
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x1A403D0 Offset: 0x1A404D1 VA: 0x1A403D0
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x1A403E0 Offset: 0x1A404E1 VA: 0x1A403E0
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x1A403F0 Offset: 0x1A404F1 VA: 0x1A403F0
	public float get_matchWidthOrHeight() { }

	// RVA: 0x1A40400 Offset: 0x1A40501 VA: 0x1A40400
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x1A40410 Offset: 0x1A40511 VA: 0x1A40410
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0x1A40420 Offset: 0x1A40521 VA: 0x1A40420
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x1A40430 Offset: 0x1A40531 VA: 0x1A40430
	public float get_fallbackScreenDPI() { }

	// RVA: 0x1A40440 Offset: 0x1A40541 VA: 0x1A40440
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x1A40450 Offset: 0x1A40551 VA: 0x1A40450
	public float get_defaultSpriteDPI() { }

	// RVA: 0x1A40460 Offset: 0x1A40561 VA: 0x1A40460
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x1A40490 Offset: 0x1A40591 VA: 0x1A40490
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x1A404A0 Offset: 0x1A405A1 VA: 0x1A404A0
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x1A404B0 Offset: 0x1A405B1 VA: 0x1A404B0
	protected void .ctor() { }

	// RVA: 0x1A40500 Offset: 0x1A40601 VA: 0x1A40500 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A405E0 Offset: 0x1A406E1 VA: 0x1A405E0
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x1A405F0 Offset: 0x1A406F1 VA: 0x1A405F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A40790 Offset: 0x1A40891 VA: 0x1A40790 Slot: 17
	protected virtual void Handle() { }

	// RVA: 0x1A408A0 Offset: 0x1A409A1 VA: 0x1A408A0 Slot: 18
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x1A40930 Offset: 0x1A40A31 VA: 0x1A40930 Slot: 19
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x1A409C0 Offset: 0x1A40AC1 VA: 0x1A409C0 Slot: 20
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x1A40BF0 Offset: 0x1A40CF1 VA: 0x1A40BF0 Slot: 21
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x1A406D0 Offset: 0x1A407D1 VA: 0x1A406D0
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x1A40730 Offset: 0x1A40831 VA: 0x1A40730
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }
}

