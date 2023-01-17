// Namespace: App
public class MyRoomWakeupSelectMenuItemContent : BasicMenuItemContent // TypeDefIndex: 11343
{
	// Fields
	private const int TYPE_MAX = 8;
	private GameObject m_Icon; // 0x48
	private GameObject m_Name; // 0x50
	private GameObject[] m_RankObjects; // 0x58
	private GameObject m_Frame; // 0x60
	private Image m_Image; // 0x68
	private Image[] m_RankImages; // 0x70
	private Image[] m_RankImagesBase; // 0x78
	private TextMeshProUGUI[] m_RankImagesNumber; // 0x80

	// Methods

	// RVA: 0x2843BD0 Offset: 0x2843CD1 VA: 0x2843BD0
	private void SetupObjects() { }

	// RVA: 0x2844270 Offset: 0x2844371 VA: 0x2844270
	private void SetRankColor(Image rankImage, Image baseImage, TextMeshProUGUI numberText, Color color) { }

	// RVA: 0x2844310 Offset: 0x2844411 VA: 0x2844310
	private Color GetCommandColor() { }

	// RVA: 0x2844410 Offset: 0x2844511 VA: 0x2844410 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2844440 Offset: 0x2844541 VA: 0x2844440 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2844A70 Offset: 0x2844B71 VA: 0x2844A70 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2844CF0 Offset: 0x2844DF1 VA: 0x2844CF0 Slot: 15
	protected override void Update() { }

	// RVA: 0x28452B0 Offset: 0x28453B1 VA: 0x28452B0
	public void .ctor() { }
}

