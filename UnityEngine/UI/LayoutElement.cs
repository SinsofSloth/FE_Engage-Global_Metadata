// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x42E30 Offset: 0x42F31 VA: 0x42E30
[RequireComponent] // RVA: 0x42E30 Offset: 0x42F31 VA: 0x42E30
[ExecuteAlways] // RVA: 0x42E30 Offset: 0x42F31 VA: 0x42E30
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 4313
{
	// Fields
	[SerializeField] // RVA: 0x44E60 Offset: 0x44F61 VA: 0x44E60
	private bool m_IgnoreLayout; // 0x18
	[SerializeField] // RVA: 0x44E70 Offset: 0x44F71 VA: 0x44E70
	private float m_MinWidth; // 0x1C
	[SerializeField] // RVA: 0x44E80 Offset: 0x44F81 VA: 0x44E80
	private float m_MinHeight; // 0x20
	[SerializeField] // RVA: 0x44E90 Offset: 0x44F91 VA: 0x44E90
	private float m_PreferredWidth; // 0x24
	[SerializeField] // RVA: 0x44EA0 Offset: 0x44FA1 VA: 0x44EA0
	private float m_PreferredHeight; // 0x28
	[SerializeField] // RVA: 0x44EB0 Offset: 0x44FB1 VA: 0x44EB0
	private float m_FlexibleWidth; // 0x2C
	[SerializeField] // RVA: 0x44EC0 Offset: 0x44FC1 VA: 0x44EC0
	private float m_FlexibleHeight; // 0x30
	[SerializeField] // RVA: 0x44ED0 Offset: 0x44FD1 VA: 0x44ED0
	private int m_LayoutPriority; // 0x34

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x1BEFF70 Offset: 0x1BF0071 VA: 0x1BEFF70 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x1BEFF80 Offset: 0x1BF0081 VA: 0x1BEFF80 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x1BF00D0 Offset: 0x1BF01D1 VA: 0x1BF00D0 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1BF00E0 Offset: 0x1BF01E1 VA: 0x1BF00E0 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1BF00F0 Offset: 0x1BF01F1 VA: 0x1BF00F0 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x1BF0100 Offset: 0x1BF0201 VA: 0x1BF0100 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x1BF0190 Offset: 0x1BF0291 VA: 0x1BF0190 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1BF01A0 Offset: 0x1BF02A1 VA: 0x1BF01A0 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x1BF0230 Offset: 0x1BF0331 VA: 0x1BF0230 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x1BF0240 Offset: 0x1BF0341 VA: 0x1BF0240 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x1BF02D0 Offset: 0x1BF03D1 VA: 0x1BF02D0 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x1BF02E0 Offset: 0x1BF03E1 VA: 0x1BF02E0 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x1BF0370 Offset: 0x1BF0471 VA: 0x1BF0370 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1BF0380 Offset: 0x1BF0481 VA: 0x1BF0380 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x1BF0410 Offset: 0x1BF0511 VA: 0x1BF0410 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1BF0420 Offset: 0x1BF0521 VA: 0x1BF0420 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x1BF04B0 Offset: 0x1BF05B1 VA: 0x1BF04B0 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x1BF04C0 Offset: 0x1BF05C1 VA: 0x1BF04C0 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x1BF0540 Offset: 0x1BF0641 VA: 0x1BF0540
	protected void .ctor() { }

	// RVA: 0x1BF0570 Offset: 0x1BF0671 VA: 0x1BF0570 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1BF05A0 Offset: 0x1BF06A1 VA: 0x1BF05A0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1BF05B0 Offset: 0x1BF06B1 VA: 0x1BF05B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1BF05E0 Offset: 0x1BF06E1 VA: 0x1BF05E0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1BF05F0 Offset: 0x1BF06F1 VA: 0x1BF05F0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1BF0000 Offset: 0x1BF0101 VA: 0x1BF0000
	protected void SetDirty() { }
}

