// Namespace: App
public class PhotographEditDisposMenuContent : BasicMenuContent // TypeDefIndex: 11481
{
	// Fields
	[SerializeField] // RVA: 0x2986B0 Offset: 0x2987B1 VA: 0x2986B0
	private GameObject m_ArrowRoot; // 0xE8
	[SerializeField] // RVA: 0x2986C0 Offset: 0x2987C1 VA: 0x2986C0
	private Image m_BodyAccIcon; // 0xF0
	[SerializeField] // RVA: 0x2986D0 Offset: 0x2987D1 VA: 0x2986D0
	private Image m_FaceAccIcon; // 0xF8
	[SerializeField] // RVA: 0x2986E0 Offset: 0x2987E1 VA: 0x2986E0
	private Image m_WeaponOrScarfIcon; // 0x100
	[SerializeField] // RVA: 0x2986F0 Offset: 0x2987F1 VA: 0x2986F0
	private TextMeshProUGUI m_PauseCount; // 0x108

	// Methods

	// RVA: 0x2A31930 Offset: 0x2A31A31 VA: 0x2A31930
	public static void CreateBind(ProcInst super, PhotographAllMenuContent allMenuContent, PhotographDisposManager disposManager, PhotographEditDisposMenu.ReturnHandler returnHandler) { }

	// RVA: 0x2A31B20 Offset: 0x2A31C21 VA: 0x2A31B20
	public void UpdateUIObj(bool isArrowActive, bool isMascot, int pauseNo, int pauseCount) { }

	// RVA: 0x2A31E10 Offset: 0x2A31F11 VA: 0x2A31E10 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2A31E80 Offset: 0x2A31F81 VA: 0x2A31E80 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2A31EF0 Offset: 0x2A31FF1 VA: 0x2A31EF0 Slot: 9
	protected override float CalcCursorMovedPosX(int menuItemIdx) { }

	// RVA: 0x2A31F90 Offset: 0x2A32091 VA: 0x2A31F90 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIdx) { }

	// RVA: 0x2A32030 Offset: 0x2A32131 VA: 0x2A32030
	public void .ctor() { }
}

