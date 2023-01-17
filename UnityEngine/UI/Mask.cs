// Namespace: UnityEngine.UI
[DisallowMultipleComponent] // RVA: 0x42FD0 Offset: 0x430D1 VA: 0x42FD0
[RequireComponent] // RVA: 0x42FD0 Offset: 0x430D1 VA: 0x42FD0
[ExecuteAlways] // RVA: 0x42FD0 Offset: 0x430D1 VA: 0x42FD0
[AddComponentMenu] // RVA: 0x42FD0 Offset: 0x430D1 VA: 0x42FD0
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 4321
{
	// Fields
	private RectTransform m_RectTransform; // 0x18
	[SerializeField] // RVA: 0x44F00 Offset: 0x45001 VA: 0x44F00
	private bool m_ShowMaskGraphic; // 0x20
	private Graphic m_Graphic; // 0x28
	private Material m_MaskMaterial; // 0x30
	private Material m_UnmaskMaterial; // 0x38

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x1B6A7B0 Offset: 0x1B6A8B1 VA: 0x1B6A7B0
	public RectTransform get_rectTransform() { }

	// RVA: 0x1B6A830 Offset: 0x1B6A931 VA: 0x1B6A830
	public bool get_showMaskGraphic() { }

	// RVA: 0x1B6A840 Offset: 0x1B6A941 VA: 0x1B6A840
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x1B6A9A0 Offset: 0x1B6AAA1 VA: 0x1B6A9A0
	public Graphic get_graphic() { }

	// RVA: 0x1B6AA20 Offset: 0x1B6AB21 VA: 0x1B6AA20
	protected void .ctor() { }

	// RVA: 0x1B6AA30 Offset: 0x1B6AB31 VA: 0x1B6AA30 Slot: 19
	public virtual bool MaskEnabled() { }

	[ObsoleteAttribute] // RVA: 0x46010 Offset: 0x46111 VA: 0x46010
	// RVA: 0x1B6AB20 Offset: 0x1B6AC21 VA: 0x1B6AB20 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x1B6AB30 Offset: 0x1B6AC31 VA: 0x1B6AB30 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1B6B0D0 Offset: 0x1B6B1D1 VA: 0x1B6B0D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1B6B490 Offset: 0x1B6B591 VA: 0x1B6B490 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1B6B5A0 Offset: 0x1B6B6A1 VA: 0x1B6B5A0 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }
}

