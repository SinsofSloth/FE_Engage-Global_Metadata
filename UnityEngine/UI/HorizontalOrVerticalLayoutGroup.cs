// Namespace: UnityEngine.UI
[ExecuteAlways] // RVA: 0x42E20 Offset: 0x42F21 VA: 0x42E20
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 4307
{
	// Fields
	[SerializeField] // RVA: 0x44DE0 Offset: 0x44EE1 VA: 0x44DE0
	protected float m_Spacing; // 0x58
	[SerializeField] // RVA: 0x44DF0 Offset: 0x44EF1 VA: 0x44DF0
	protected bool m_ChildForceExpandWidth; // 0x5C
	[SerializeField] // RVA: 0x44E00 Offset: 0x44F01 VA: 0x44E00
	protected bool m_ChildForceExpandHeight; // 0x5D
	[SerializeField] // RVA: 0x44E10 Offset: 0x44F11 VA: 0x44E10
	protected bool m_ChildControlWidth; // 0x5E
	[SerializeField] // RVA: 0x44E20 Offset: 0x44F21 VA: 0x44E20
	protected bool m_ChildControlHeight; // 0x5F
	[SerializeField] // RVA: 0x44E30 Offset: 0x44F31 VA: 0x44E30
	protected bool m_ChildScaleWidth; // 0x60
	[SerializeField] // RVA: 0x44E40 Offset: 0x44F41 VA: 0x44E40
	protected bool m_ChildScaleHeight; // 0x61
	[SerializeField] // RVA: 0x44E50 Offset: 0x44F51 VA: 0x44E50
	protected bool m_ReverseArrangement; // 0x62

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }
	public bool reverseArrangement { get; set; }

	// Methods

	// RVA: 0x1A57250 Offset: 0x1A57351 VA: 0x1A57250
	public float get_spacing() { }

	// RVA: 0x1A57260 Offset: 0x1A57361 VA: 0x1A57260
	public void set_spacing(float value) { }

	// RVA: 0x1A572D0 Offset: 0x1A573D1 VA: 0x1A572D0
	public bool get_childForceExpandWidth() { }

	// RVA: 0x1A572E0 Offset: 0x1A573E1 VA: 0x1A572E0
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x1A57340 Offset: 0x1A57441 VA: 0x1A57340
	public bool get_childForceExpandHeight() { }

	// RVA: 0x1A57350 Offset: 0x1A57451 VA: 0x1A57350
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x1A573B0 Offset: 0x1A574B1 VA: 0x1A573B0
	public bool get_childControlWidth() { }

	// RVA: 0x1A573C0 Offset: 0x1A574C1 VA: 0x1A573C0
	public void set_childControlWidth(bool value) { }

	// RVA: 0x1A57420 Offset: 0x1A57521 VA: 0x1A57420
	public bool get_childControlHeight() { }

	// RVA: 0x1A57430 Offset: 0x1A57531 VA: 0x1A57430
	public void set_childControlHeight(bool value) { }

	// RVA: 0x1A57490 Offset: 0x1A57591 VA: 0x1A57490
	public bool get_childScaleWidth() { }

	// RVA: 0x1A574A0 Offset: 0x1A575A1 VA: 0x1A574A0
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x1A57500 Offset: 0x1A57601 VA: 0x1A57500
	public bool get_childScaleHeight() { }

	// RVA: 0x1A57510 Offset: 0x1A57611 VA: 0x1A57510
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x1A57570 Offset: 0x1A57671 VA: 0x1A57570
	public bool get_reverseArrangement() { }

	// RVA: 0x1A57580 Offset: 0x1A57681 VA: 0x1A57580
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x1A567F0 Offset: 0x1A568F1 VA: 0x1A567F0
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x1A56BF0 Offset: 0x1A56CF1 VA: 0x1A56BF0
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x1A575E0 Offset: 0x1A576E1 VA: 0x1A575E0
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x1A567B0 Offset: 0x1A568B1 VA: 0x1A567B0
	protected void .ctor() { }
}

