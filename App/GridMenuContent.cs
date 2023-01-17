// Namespace: App
public class GridMenuContent : BasicMenuContent // TypeDefIndex: 12558
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	protected GridLayoutGroup m_gridLayoutGroup; // 0xE8

	// Methods

	// RVA: 0x2DADAD0 Offset: 0x2DADBD1 VA: 0x2DADAD0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2DADB70 Offset: 0x2DADC71 VA: 0x2DADB70 Slot: 9
	protected override float CalcCursorMovedPosX(int menuItemIndex) { }

	// RVA: 0x2DADC80 Offset: 0x2DADD81 VA: 0x2DADC80 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2DADDB0 Offset: 0x2DADEB1 VA: 0x2DADDB0 Slot: 13
	protected override void InitObjReference() { }

	// RVA: 0x2DADE20 Offset: 0x2DADF21 VA: 0x2DADE20 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2DADEC0 Offset: 0x2DADFC1 VA: 0x2DADEC0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2DADF60 Offset: 0x2DAE061 VA: 0x2DADF60 Slot: 28
	protected override void CycleMenuItemContent(bool isForward, int cycleCount) { }

	// RVA: 0x2DAE260 Offset: 0x2DAE361 VA: 0x2DAE260 Slot: 29
	protected override float GetLineHeightForScroll() { }

	// RVA: 0x2DAE280 Offset: 0x2DAE381 VA: 0x2DAE280 Slot: 30
	protected override void Awake() { }

	// RVA: 0x2DAE2C0 Offset: 0x2DAE3C1 VA: 0x2DAE2C0 Slot: 34
	public virtual int CalcColumn(int menuItemIndex) { }

	// RVA: 0x2DAE2F0 Offset: 0x2DAE3F1 VA: 0x2DAE2F0 Slot: 35
	public virtual int CalcRow(int menuItemIndex) { }

	// RVA: 0x2DAE320 Offset: 0x2DAE421 VA: 0x2DAE320 Slot: 36
	public virtual int CalcMenuItemIndex(int row, int column) { }

	// RVA: 0x2DAE350 Offset: 0x2DAE451 VA: 0x2DAE350
	public void SetCellSize(float w, float h) { }

	// RVA: 0x2DAE390 Offset: 0x2DAE491 VA: 0x2DAE390
	public void SetCellW(float w) { }

	// RVA: 0x2DAE3D0 Offset: 0x2DAE4D1 VA: 0x2DAE3D0
	public void SetCellH(float h) { }

	// RVA: 0x2DAE410 Offset: 0x2DAE511 VA: 0x2DAE410
	public Vector2 GetCellSize() { }

	// RVA: 0x2DADC70 Offset: 0x2DADD71 VA: 0x2DADC70
	public float GetCellW() { }

	// RVA: 0x2DADDA0 Offset: 0x2DADEA1 VA: 0x2DADDA0
	public float GetCellH() { }

	// RVA: 0x2DAE420 Offset: 0x2DAE521 VA: 0x2DAE420
	public void SetColumnCount(int count) { }

	// RVA: 0x2DADEB0 Offset: 0x2DADFB1 VA: 0x2DADEB0
	public int GetColumnCount() { }

	// RVA: 0x2DAE430 Offset: 0x2DAE531 VA: 0x2DAE430 Slot: 37
	protected virtual void UpdateCursorSize() { }

	// RVA: 0x2DAE500 Offset: 0x2DAE601 VA: 0x2DAE500
	public static void LoadPrefabAsync() { }

	// RVA: 0x2DAE5A0 Offset: 0x2DAE6A1 VA: 0x2DAE5A0
	public static GridMenuContent Create() { }

	// RVA: 0x2DAE660 Offset: 0x2DAE761 VA: 0x2DAE660
	public void .ctor() { }

	// RVA: 0x2DAE6D0 Offset: 0x2DAE7D1 VA: 0x2DAE6D0
	private static void .cctor() { }
}

