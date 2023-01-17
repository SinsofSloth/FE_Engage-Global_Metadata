// Namespace: 
private class MascotColorChangeMenu.CursorTop // TypeDefIndex: 10845
{
	// Fields
	public int XCount; // 0x10
	public int YCount; // 0x14
	private float MoveFrame; // 0x18
	private RectTransform m_cursorTop; // 0x20
	private ValueTuple<int, int> m_selectIndex; // 0x28
	private ValueTuple<int, int> m_selectIndexOld; // 0x30
	private float m_moveTick; // 0x38

	// Properties
	public int SelectIndexX { get; }
	public int SelectIndexY { get; }

	// Methods

	// RVA: 0x214FE10 Offset: 0x214FF11 VA: 0x214FE10
	public int get_SelectIndexX() { }

	// RVA: 0x214FE20 Offset: 0x214FF21 VA: 0x214FE20
	public int get_SelectIndexY() { }

	// RVA: 0x214FE30 Offset: 0x214FF31 VA: 0x214FE30
	public void .ctor(RectTransform transform) { }

	// RVA: 0x214FF00 Offset: 0x2150001 VA: 0x214FF00
	public void SetIndexInstant(int index) { }

	// RVA: 0x2150060 Offset: 0x2150161 VA: 0x2150060
	public bool MoveCursor(int moveX, int moveY, bool isTrigger) { }

	// RVA: 0x2150100 Offset: 0x2150201 VA: 0x2150100
	public void Update() { }

	// RVA: 0x2150010 Offset: 0x2150111 VA: 0x2150010
	private void SetPosition(float x, float y) { }

	// RVA: 0x214FFB0 Offset: 0x21500B1 VA: 0x214FFB0
	private float GetPositionX(int selectIndex) { }

	// RVA: 0x214FFE0 Offset: 0x21500E1 VA: 0x214FFE0
	private float GetPositionY(int selectIndex) { }
}

