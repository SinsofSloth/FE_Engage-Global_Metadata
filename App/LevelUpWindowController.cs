// Namespace: App
public class LevelUpWindowController : MonoBehaviour // TypeDefIndex: 13435
{
	// Fields
	[SpaceAttribute] // RVA: 0x29BFF0 Offset: 0x29C0F1 VA: 0x29BFF0
	public TextMeshProUGUI m_CharaName; // 0x18
	[SpaceAttribute] // RVA: 0x29C010 Offset: 0x29C111 VA: 0x29C010
	public TextMeshProUGUI m_TitleLevel; // 0x20
	public TextMeshProUGUI m_Level; // 0x28
	[SpaceAttribute] // RVA: 0x29C030 Offset: 0x29C131 VA: 0x29C030
	public TextMeshProUGUI m_Job; // 0x30
	[HeaderAttribute] // RVA: 0x29C050 Offset: 0x29C151 VA: 0x29C050
	public int m_ParameterMax; // 0x38
	[SpaceAttribute] // RVA: 0x29C090 Offset: 0x29C191 VA: 0x29C090
	public GameObject m_Hp; // 0x40
	public GameObject m_Str; // 0x48
	public GameObject m_Magic; // 0x50
	public GameObject m_Tech; // 0x58
	public GameObject m_Quick; // 0x60
	public GameObject m_Def; // 0x68
	public GameObject m_Mdef; // 0x70
	public GameObject m_Luck; // 0x78
	public GameObject m_Phys; // 0x80
	public GameObject m_Sight; // 0x88
	public GameObject m_Move; // 0x90
	[SpaceAttribute] // RVA: 0x29C0B0 Offset: 0x29C1B1 VA: 0x29C0B0
	public Sprite m_ArrowUp; // 0x98
	public Sprite m_ArrowDown; // 0xA0
	public Sprite m_FrameUp; // 0xA8
	public Sprite m_FrameDown; // 0xB0
	private GameObject[] m_ParamObjectArray; // 0xB8

	// Methods

	// RVA: 0x1F8BB80 Offset: 0x1F8BC81 VA: 0x1F8BB80
	private void Start() { }

	// RVA: 0x1F8C440 Offset: 0x1F8C541 VA: 0x1F8C440
	private void Update() { }

	// RVA: 0x1F8C450 Offset: 0x1F8C551 VA: 0x1F8C450
	private TextMeshProUGUI GetValueTextMesh(GameObject paramRoot) { }

	// RVA: 0x1F8C4F0 Offset: 0x1F8C5F1 VA: 0x1F8C4F0
	private void StartAnime(GameObject paramRoot) { }

	// RVA: 0x1F839F0 Offset: 0x1F83AF1 VA: 0x1F839F0
	public void SetupParams(Unit unit, Unit next) { }

	// RVA: 0x1F88720 Offset: 0x1F88821 VA: 0x1F88720
	public void ChangeParam(CapabilityDefinition.Type type, int change, int newValue) { }

	// RVA: 0x1F8AEA0 Offset: 0x1F8AFA1 VA: 0x1F8AEA0
	public void OutAnime() { }

	// RVA: 0x1F86C50 Offset: 0x1F86D51 VA: 0x1F86C50
	public bool IsAnimation() { }

	// RVA: 0x1F8C5C0 Offset: 0x1F8C6C1 VA: 0x1F8C5C0
	public void .ctor() { }
}

