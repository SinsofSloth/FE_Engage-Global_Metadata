// Namespace: App
public class RewindMenuItemContent : BasicMenuItemContent // TypeDefIndex: 12617
{
	// Fields
	[SerializeField] // RVA: 0x29B3A0 Offset: 0x29B4A1 VA: 0x29B3A0
	private RewindMenuItemContent m_prev; // 0x48
	[SerializeField] // RVA: 0x29B3B0 Offset: 0x29B4B1 VA: 0x29B3B0
	private RewindMenuItemContent m_next; // 0x50
	[SerializeField] // RVA: 0x29B3C0 Offset: 0x29B4C1 VA: 0x29B3C0
	private string m_initStateName; // 0x58
	[SerializeField] // RVA: 0x29B3D0 Offset: 0x29B4D1 VA: 0x29B3D0
	private int m_MenuPosIndex; // 0x60
	private Animator m_Animator; // 0x68
	private Image m_WindowImage; // 0x70
	private Image m_WhiteImage; // 0x78
	private TextMeshProUGUI m_LogText; // 0x80
	private GameObject m_UnitObject; // 0x88
	private UnitIcon m_UnitIcon; // 0x90
	private TextMeshProUGUI m_UnitName; // 0x98
	private UnitIcon m_DieUnitIcon; // 0xA0
	private Image m_DieIconImage; // 0xA8
	private RewindMenu m_Menu; // 0xB0

	// Methods

	// RVA: 0x24D6330 Offset: 0x24D6431 VA: 0x24D6330
	public void .ctor() { }

	// RVA: 0x24D6340 Offset: 0x24D6441 VA: 0x24D6340
	public void Awake() { }

	// RVA: 0x24D6750 Offset: 0x24D6851 VA: 0x24D6750
	public void Show() { }

	// RVA: 0x24D6810 Offset: 0x24D6911 VA: 0x24D6810
	public void Hide() { }

	// RVA: 0x24D67B0 Offset: 0x24D68B1 VA: 0x24D67B0
	private void SetEnableImageAndText(bool enable) { }

	// RVA: 0x24D6870 Offset: 0x24D6971 VA: 0x24D6870
	public void SetSelectColor(Color color) { }

	// RVA: 0x24D6890 Offset: 0x24D6991 VA: 0x24D6890 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x24D6DD0 Offset: 0x24D6ED1 VA: 0x24D6DD0 Slot: 13
	public override void Disable() { }

	// RVA: 0x24D6930 Offset: 0x24D6A31 VA: 0x24D6930
	public void SetupByMenuItem(RewindMenu.MenuItem rewindMenuItem) { }

	// RVA: 0x24D6DE0 Offset: 0x24D6EE1 VA: 0x24D6DE0
	private RewindMenu.MenuItem GetMenuItem(int menuPosIndex) { }

	// RVA: 0x24D6EE0 Offset: 0x24D6FE1 VA: 0x24D6EE0
	private bool IsAnimStateName(string stateName) { }

	// RVA: 0x24D6F60 Offset: 0x24D7061 VA: 0x24D6F60
	private bool IsMoveAnimState(int from, int to) { }

	// RVA: 0x24D5EA0 Offset: 0x24D5FA1 VA: 0x24D5EA0
	public bool IsMoving() { }

	// RVA: 0x24D5F70 Offset: 0x24D6071 VA: 0x24D5F70
	public void MoveUp() { }

	// RVA: 0x24D60B0 Offset: 0x24D61B1 VA: 0x24D60B0
	public void MoveDown() { }

	// RVA: 0x24D5F30 Offset: 0x24D6031 VA: 0x24D5F30
	public void MoveUpImm() { }

	// RVA: 0x24D6070 Offset: 0x24D6171 VA: 0x24D6070
	public void MoveDownImm() { }

	// RVA: 0x24D7070 Offset: 0x24D7171 VA: 0x24D7070
	public void PlayAnimMoveUp() { }

	// RVA: 0x24D70D0 Offset: 0x24D71D1 VA: 0x24D70D0
	public void PlayAnimMoveDown() { }
}

