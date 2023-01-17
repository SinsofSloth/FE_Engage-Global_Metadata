// Namespace: 
public class MyRoomWakeupSelectRoot.CursorTop // TypeDefIndex: 11344
{
	// Fields
	private const int TYPE_MAX = 8;
	private bool[,] m_OpenFlags; // 0x10
	private RectTransform ResetRect; // 0x18
	private float RankC_PosX; // 0x20
	private float RankB_PosX; // 0x24
	private float RankA_PosX; // 0x28
	private float RankS_PosX; // 0x2C
	private float Upper_PosY; // 0x30
	private float Lower_PosY; // 0x34
	private float MoveFrame; // 0x38
	private RectTransform m_cursorTop; // 0x40
	private int m_selectIndex; // 0x48
	private int m_prevIndex; // 0x4C
	private float m_moveTick; // 0x50

	// Methods

	// RVA: 0x26E4F90 Offset: 0x26E5091 VA: 0x26E4F90
	public void InitOpenFlag(bool[,] flags) { }

	// RVA: 0x26E4FA0 Offset: 0x26E50A1 VA: 0x26E4FA0
	public bool IsOpen(int index) { }

	// RVA: 0x26E5010 Offset: 0x26E5111 VA: 0x26E5010
	public void .ctor(RectTransform transform) { }

	// RVA: 0x26E5070 Offset: 0x26E5171 VA: 0x26E5070
	public void Reset(RectTransform transform, RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x26E52D0 Offset: 0x26E53D1 VA: 0x26E52D0
	public void SetSelectIndex(int selectIndex) { }

	// RVA: 0x26E52F0 Offset: 0x26E53F1 VA: 0x26E52F0
	public int GetSelectIndex() { }

	// RVA: 0x26E5300 Offset: 0x26E5401 VA: 0x26E5300
	public void KeyUp(bool isTrigger) { }

	// RVA: 0x26E5440 Offset: 0x26E5541 VA: 0x26E5440
	public void KeyDown(bool isTrigger) { }

	// RVA: 0x26E5580 Offset: 0x26E5681 VA: 0x26E5580
	public void KeyLeft(bool isTrigger) { }

	// RVA: 0x26E56C0 Offset: 0x26E57C1 VA: 0x26E56C0
	public void KeyRight(bool isTrigger) { }

	// RVA: 0x26E5800 Offset: 0x26E5901 VA: 0x26E5800
	public void Update() { }

	// RVA: 0x26E5250 Offset: 0x26E5351 VA: 0x26E5250
	private float GetCorrectedYCoord() { }

	// RVA: 0x26E51F0 Offset: 0x26E52F1 VA: 0x26E51F0
	private float GetPositionX(int selectIndex) { }

	// RVA: 0x26E5270 Offset: 0x26E5371 VA: 0x26E5270
	private float GetPositionY(int selectIndex) { }
}

