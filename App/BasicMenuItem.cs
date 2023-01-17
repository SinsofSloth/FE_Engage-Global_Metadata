// Namespace: App
public class BasicMenuItem // TypeDefIndex: 12521
{
	// Fields
	protected BasicMenu m_menu; // 0x10
	protected BasicMenuItemContent m_menuItemContent; // 0x18
	protected string m_name; // 0x20
	protected int m_index; // 0x28
	protected int m_fullIndex; // 0x2C
	protected BasicMenuItem.Attribute m_attribute; // 0x30
	protected Color m_cursorColor; // 0x34
	protected Color m_activeTextColor; // 0x44
	protected Color m_inactiveTextColor; // 0x54

	// Methods

	// RVA: 0x28F3130 Offset: 0x28F3231 VA: 0x28F3130
	public void .ctor() { }

	// RVA: 0x2902EA0 Offset: 0x2902FA1 VA: 0x2902EA0
	public BasicMenu GetMenu() { }

	// RVA: 0x2902EB0 Offset: 0x2902FB1 VA: 0x2902EB0
	public BasicMenuItemContent GetMenuItemContent() { }

	// RVA: 0x2902EC0 Offset: 0x2902FC1 VA: 0x2902EC0
	public int GetIndex() { }

	// RVA: 0x2902ED0 Offset: 0x2902FD1 VA: 0x2902ED0
	public int GetFullIndex() { }

	// RVA: 0x2902EE0 Offset: 0x2902FE1 VA: 0x2902EE0
	public BasicMenuItem.Attribute GetAttribute() { }

	// RVA: 0x2902EF0 Offset: 0x2902FF1 VA: 0x2902EF0
	public bool IsSelect() { }

	// RVA: 0x2902F10 Offset: 0x2903011 VA: 0x2902F10
	public bool IsAttributeEnable() { }

	// RVA: 0x28F46B0 Offset: 0x28F47B1 VA: 0x28F46B0
	public bool IsAttributeDisable() { }

	// RVA: 0x28F9240 Offset: 0x28F9341 VA: 0x28F9240
	public bool IsAttributeHide() { }

	// RVA: 0x28F8510 Offset: 0x28F8611 VA: 0x28F8510
	public bool IsAttributeBlank() { }

	// RVA: 0x28F9250 Offset: 0x28F9351 VA: 0x28F9250
	public bool IsAttributeSelect() { }

	// RVA: 0x2902F20 Offset: 0x2903021 VA: 0x2902F20 Slot: 4
	public virtual string GetName() { }

	// RVA: 0x2902F30 Offset: 0x2903031 VA: 0x2902F30 Slot: 5
	public virtual float GetWidth() { }

	// RVA: 0x2902FF0 Offset: 0x29030F1 VA: 0x2902FF0 Slot: 6
	public virtual float GetHeight() { }

	// RVA: 0x28F4A80 Offset: 0x28F4B81 VA: 0x28F4A80
	public void SetCursorColor(Color color) { }

	// RVA: 0x29030B0 Offset: 0x29031B1 VA: 0x29030B0 Slot: 7
	public virtual void SetTextColor(Color color, bool bInactive) { }

	// RVA: 0x2903250 Offset: 0x2903351 VA: 0x2903250
	public void SetTextColor(Color activeColor, Color inactiveColor) { }

	// RVA: 0x28F3290 Offset: 0x28F3391 VA: 0x28F3290
	public void SetCommandColor(Color color, bool bInactive) { }

	// RVA: 0x2903370 Offset: 0x2903471 VA: 0x2903370
	public Color GetCursorColor() { }

	// RVA: 0x2903380 Offset: 0x2903481 VA: 0x2903380
	public Color GetActiveTextColor() { }

	// RVA: 0x2903390 Offset: 0x2903491 VA: 0x2903390
	public Color GetInactiveTextColor() { }

	// RVA: 0x29033A0 Offset: 0x29034A1 VA: 0x29033A0
	public void UpdateCommandColorAsActive() { }

	// RVA: 0x29034B0 Offset: 0x29035B1 VA: 0x29034B0
	public void ForceRebuildLayout() { }

	// RVA: 0x2903520 Offset: 0x2903621 VA: 0x2903520
	public void SetMenu(BasicMenu menu) { }

	// RVA: 0x2903530 Offset: 0x2903631 VA: 0x2903530
	public void SetMenuItemContent(BasicMenuItemContent menuItemContent) { }

	// RVA: 0x2903540 Offset: 0x2903641 VA: 0x2903540
	public void SetName(string name) { }

	// RVA: 0x2903550 Offset: 0x2903651 VA: 0x2903550
	public void SetItemIndex(int itemIndex) { }

	// RVA: 0x2903560 Offset: 0x2903661 VA: 0x2903560
	public void SetFullIndex(int itemIndex) { }

	// RVA: 0x2903570 Offset: 0x2903671 VA: 0x2903570
	public void SetAttribute(BasicMenuItem.Attribute attribute) { }

	// RVA: 0x2903580 Offset: 0x2903681 VA: 0x2903580 Slot: 8
	public virtual BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2903590 Offset: 0x2903691 VA: 0x2903590 Slot: 9
	public virtual void Tick() { }

	// RVA: 0x29035A0 Offset: 0x29036A1 VA: 0x29035A0 Slot: 10
	public virtual void OnBuild() { }

	// RVA: 0x29036D0 Offset: 0x29037D1 VA: 0x29036D0 Slot: 11
	public virtual void OnBuildMenuItemContent() { }

	// RVA: 0x29036E0 Offset: 0x29037E1 VA: 0x29036E0 Slot: 12
	public virtual void OnSelect() { }

	// RVA: 0x2903840 Offset: 0x2903941 VA: 0x2903840 Slot: 13
	public virtual void OnDeselect() { }

	// RVA: 0x29038F0 Offset: 0x29039F1 VA: 0x29038F0 Slot: 14
	public virtual void OnCursorMoveEnd() { }

	// RVA: 0x2903A00 Offset: 0x2903B01 VA: 0x2903A00 Slot: 15
	public virtual void OnClose() { }

	// RVA: 0x2903A10 Offset: 0x2903B11 VA: 0x2903A10 Slot: 16
	public virtual BasicMenu.Result SystemCall() { }

	// RVA: 0x2903A20 Offset: 0x2903B21 VA: 0x2903A20 Slot: 17
	public virtual BasicMenu.Result KeyCall() { }

	// RVA: 0x2903A30 Offset: 0x2903B31 VA: 0x2903A30 Slot: 18
	public virtual BasicMenu.Result ACall() { }

	// RVA: 0x2903A40 Offset: 0x2903B41 VA: 0x2903A40 Slot: 19
	public virtual BasicMenu.Result BCall() { }

	// RVA: 0x2903A50 Offset: 0x2903B51 VA: 0x2903A50 Slot: 20
	public virtual BasicMenu.Result XCall() { }

	// RVA: 0x2903A60 Offset: 0x2903B61 VA: 0x2903A60 Slot: 21
	public virtual BasicMenu.Result YCall() { }

	// RVA: 0x2903A70 Offset: 0x2903B71 VA: 0x2903A70 Slot: 22
	public virtual BasicMenu.Result LCall() { }

	// RVA: 0x2903A80 Offset: 0x2903B81 VA: 0x2903A80 Slot: 23
	public virtual BasicMenu.Result RCall() { }

	// RVA: 0x2903A90 Offset: 0x2903B91 VA: 0x2903A90 Slot: 24
	public virtual BasicMenu.Result PlusCall() { }

	// RVA: 0x2903AA0 Offset: 0x2903BA1 VA: 0x2903AA0 Slot: 25
	public virtual BasicMenu.Result MinusCall() { }

	// RVA: 0x2903AB0 Offset: 0x2903BB1 VA: 0x2903AB0 Slot: 26
	public virtual BasicMenu.Result CustomCall() { }
}

