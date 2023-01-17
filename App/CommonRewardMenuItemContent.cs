// Namespace: App
public class CommonRewardMenuItemContent : BasicMenuItemContent // TypeDefIndex: 12594
{
	// Fields
	[SerializeField] // RVA: 0x29B260 Offset: 0x29B361 VA: 0x29B260
	private Image m_ImageFace; // 0x48
	[SerializeField] // RVA: 0x29B270 Offset: 0x29B371 VA: 0x29B270
	private TextMeshProUGUI m_UnitName; // 0x50
	[SerializeField] // RVA: 0x29B280 Offset: 0x29B381 VA: 0x29B280
	private TextMeshProUGUI m_LevelValue; // 0x58
	[SerializeField] // RVA: 0x29B290 Offset: 0x29B391 VA: 0x29B290
	private TextMeshProUGUI m_ExpValue; // 0x60
	[SerializeField] // RVA: 0x29B2A0 Offset: 0x29B3A1 VA: 0x29B2A0
	private TextMeshProUGUI m_ExpAddValue; // 0x68
	[SerializeField] // RVA: 0x29B2B0 Offset: 0x29B3B1 VA: 0x29B2B0
	private GameObject m_ObjGauge; // 0x70
	[SerializeField] // RVA: 0x29B2C0 Offset: 0x29B3C1 VA: 0x29B2C0
	private GameObject m_ObjExpValue; // 0x78
	[SerializeField] // RVA: 0x29B2D0 Offset: 0x29B3D1 VA: 0x29B2D0
	private GameObject m_ObjExpMax; // 0x80
	[SerializeField] // RVA: 0x29B2E0 Offset: 0x29B3E1 VA: 0x29B2E0
	private Image m_ImageGauge; // 0x88
	[SerializeField] // RVA: 0x29B2F0 Offset: 0x29B3F1 VA: 0x29B2F0
	private Material m_GaugeMaxColor; // 0x90
	[SerializeField] // RVA: 0x29B300 Offset: 0x29B401 VA: 0x29B300
	private Animator m_AnimLevelUp; // 0x98
	[SerializeField] // RVA: 0x29B310 Offset: 0x29B411 VA: 0x29B310
	private Animator m_AnimAddValue; // 0xA0
	[SerializeField] // RVA: 0x29B320 Offset: 0x29B421 VA: 0x29B320
	private Image m_ImageArrow; // 0xA8
	private int m_StockExp; // 0xB0
	private Unit m_Unit; // 0xB8
	private bool m_IsPlaySoundExp; // 0xC0

	// Methods

	// RVA: 0x257D800 Offset: 0x257D901 VA: 0x257D800 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x257DE80 Offset: 0x257DF81 VA: 0x257DE80 Slot: 11
	public override void BuildTextColor() { }

	// RVA: 0x257CB60 Offset: 0x257CC61 VA: 0x257CB60
	public void StartGauge() { }

	// RVA: 0x257CEC0 Offset: 0x257CFC1 VA: 0x257CEC0
	public void UpdateGauge(int speed) { }

	// RVA: 0x257CC80 Offset: 0x257CD81 VA: 0x257CC80
	public bool IsGaugeEnd() { }

	// RVA: 0x257DF50 Offset: 0x257E051 VA: 0x257DF50
	public void .ctor() { }
}

