// Namespace: App
public class GridMenu : BasicMenu // TypeDefIndex: 12557
{
	// Fields
	protected GridMenuContent m_gridMenuContent; // 0xC8
	private int m_column; // 0xD0

	// Methods

	// RVA: 0x27C1D90 Offset: 0x27C1E91 VA: 0x27C1D90
	public void .ctor(List<BasicMenuItem> menuItemList, GridMenuContent menuContent) { }

	// RVA: 0x27C1DD0 Offset: 0x27C1ED1 VA: 0x27C1DD0 Slot: 30
	public override string GetName() { }

	// RVA: 0x27C1E20 Offset: 0x27C1F21 VA: 0x27C1E20 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x27C1F50 Offset: 0x27C2051 VA: 0x27C1F50 Slot: 33
	protected override int GetBuildRowNum() { }

	// RVA: 0x27C2020 Offset: 0x27C2121 VA: 0x27C2020 Slot: 34
	public override void SetSelectIndex(int index) { }

	// RVA: 0x27C20D0 Offset: 0x27C21D1 VA: 0x27C20D0 Slot: 37
	public override void RebuildInstant(BasicMenuSelect menuSelect, int displayIndex) { }

	// RVA: 0x27C2190 Offset: 0x27C2291 VA: 0x27C2190 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x27C2390 Offset: 0x27C2491 VA: 0x27C2390 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x27C25B0 Offset: 0x27C26B1 VA: 0x27C25B0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x27C2780 Offset: 0x27C2881 VA: 0x27C2780 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x27C2990 Offset: 0x27C2A91 VA: 0x27C2990 Slot: 35
	public override void AdjustScrollIndex() { }

	// RVA: 0x27C2A10 Offset: 0x27C2B11 VA: 0x27C2A10
	public void SetCellSize(float w, float h) { }

	// RVA: 0x27C2B30 Offset: 0x27C2C31 VA: 0x27C2B30
	public void SetCellW(float w) { }

	// RVA: 0x27C2BC0 Offset: 0x27C2CC1 VA: 0x27C2BC0
	public void SetCellH(float h) { }

	// RVA: 0x27C2C50 Offset: 0x27C2D51 VA: 0x27C2C50
	public Vector2 GetCellSize() { }

	// RVA: 0x27C2CD0 Offset: 0x27C2DD1 VA: 0x27C2CD0
	public float GetCellW() { }

	// RVA: 0x27C2D50 Offset: 0x27C2E51 VA: 0x27C2D50
	public float GetCellH() { }

	// RVA: 0x27C2DD0 Offset: 0x27C2ED1 VA: 0x27C2DD0
	public void SetColumnCount(int count) { }

	// RVA: 0x27C1ED0 Offset: 0x27C1FD1 VA: 0x27C1ED0
	public int GetColumnCount() { }

	// RVA: 0x27C2AB0 Offset: 0x27C2BB1 VA: 0x27C2AB0
	protected GridMenuContent GetGridMenuContent() { }
}

