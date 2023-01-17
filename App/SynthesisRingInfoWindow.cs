// Namespace: App
public class SynthesisRingInfoWindow : MonoBehaviour // TypeDefIndex: 11235
{
	// Fields
	[HeaderAttribute] // RVA: 0x297110 Offset: 0x297211 VA: 0x297110
	public TextMeshProUGUI m_NeededTitleText; // 0x18
	public Image m_NeededRingIconImage; // 0x20
	public TextMeshProUGUI m_CharacterNameText; // 0x28
	public TextMeshProUGUI m_NeededValueText; // 0x30
	public TextMeshProUGUI m_PiecesOfBondText; // 0x38
	public TextMeshProUGUI m_PiecesOfBondValueText; // 0x40
	[SpaceAttribute] // RVA: 0x297150 Offset: 0x297251 VA: 0x297150
	[HeaderAttribute] // RVA: 0x297150 Offset: 0x297251 VA: 0x297150
	public SynthesisRingInfoWindow.CharaPhoto[] m_BasePhotos; // 0x48
	private int m_BasePhotoIdx; // 0x50
	public Image m_BaseRingImage; // 0x58
	public TextMeshProUGUI m_BaseRingNameText; // 0x60
	public SynthesisRingInfoWindow.RingEnhance[] m_BaseRingEnhances; // 0x68
	public TextMeshProUGUI m_BaseRingCountCaptionText; // 0x70
	public TextMeshProUGUI m_BaseRingCountBeforeText; // 0x78
	public TextMeshProUGUI m_BaseRingCountAfterText; // 0x80
	[SpaceAttribute] // RVA: 0x2971A0 Offset: 0x2972A1 VA: 0x2971A0
	[HeaderAttribute] // RVA: 0x2971A0 Offset: 0x2972A1 VA: 0x2971A0
	public SynthesisRingInfoWindow.CharaPhoto[] m_SynthesisedPhotos; // 0x88
	private int m_SynthesisedPhotoIdx; // 0x90
	public Image m_SynthesisedRingImage; // 0x98
	public TextMeshProUGUI m_SynthesisedRingNameText; // 0xA0
	public SynthesisRingInfoWindow.RingEnhance[] m_SynthesisedRingEnhances; // 0xA8
	public TextMeshProUGUI m_SynthesisedRingCountCaptionText; // 0xB0
	public TextMeshProUGUI m_SynthesisedRingCountBeforeText; // 0xB8
	public TextMeshProUGUI m_SynthesisedRingCountAfterText; // 0xC0
	[HeaderAttribute] // RVA: 0x2971F0 Offset: 0x2972F1 VA: 0x2971F0
	[SpaceAttribute] // RVA: 0x2971F0 Offset: 0x2972F1 VA: 0x2971F0
	public GameObject m_SkillParentObject; // 0xC8
	public Image m_SkillIconImage; // 0xD0
	public TextMeshProUGUI m_SkillNameText; // 0xD8
	public TextMeshProUGUI m_SkillHelpText; // 0xE0
	private Animator m_Animator; // 0xE8
	private Material m_MaterialBefore; // 0xF0
	private Material m_MaterialAfter; // 0xF8

	// Methods

	// RVA: 0x292D940 Offset: 0x292DA41 VA: 0x292D940
	private void Start() { }

	// RVA: 0x292DD90 Offset: 0x292DE91 VA: 0x292DD90
	private void OnDestroy() { }

	// RVA: 0x292DEE0 Offset: 0x292DFE1 VA: 0x292DEE0
	public void Open() { }

	// RVA: 0x292DFA0 Offset: 0x292E0A1 VA: 0x292DFA0
	public void Close() { }

	// RVA: 0x292E060 Offset: 0x292E161 VA: 0x292E060
	public void SetData(RingData ringData) { }

	// RVA: 0x292F420 Offset: 0x292F521 VA: 0x292F420
	private void SetupCharaImage(SynthesisRingInfoWindow.CharaPhoto[] photo, ref int idx, RingData data) { }

	// RVA: 0x292F4E0 Offset: 0x292F5E1 VA: 0x292F4E0
	public void .ctor() { }
}

