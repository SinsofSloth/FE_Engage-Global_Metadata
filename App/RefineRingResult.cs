// Namespace: App
public class RefineRingResult10RingInfoContent : MonoBehaviour // TypeDefIndex: 11088
{
	// Fields
	[SpaceAttribute] // RVA: 0x296680 Offset: 0x296781 VA: 0x296680
	public Image m_CharacterImage; // 0x18
	public Image m_FrameImage; // 0x20
	public GameObject m_NewObject; // 0x28
	public TextMeshProUGUI m_NewText; // 0x30
	[HeaderAttribute] // RVA: 0x2966A0 Offset: 0x2967A1 VA: 0x2966A0
	public Image m_RingIconImage; // 0x38
	public TextMeshProUGUI m_CharacterNameText; // 0x40
	public RefineRingResult10RingInfoContent.RingParam[] m_RingParams; // 0x48
	public Image m_SkillIconImage; // 0x50
	public TextMeshProUGUI m_SkillNameText; // 0x58

	// Methods

	// RVA: 0x2C5ADD0 Offset: 0x2C5AED1 VA: 0x2C5ADD0
	public void SetData(RingData ringData, bool isNew) { }

	// RVA: 0x2C5B650 Offset: 0x2C5B751 VA: 0x2C5B650
	public void .ctor() { }
}

// Namespace: App
public class RefineRingResult10Window : MonoBehaviour // TypeDefIndex: 11089
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	public Animator m_Animator; // 0x18
	public RefineRingResult10RingInfoContent[] m_RingInfoContent; // 0x20

	// Methods

	// RVA: 0x2C5B660 Offset: 0x2C5B761 VA: 0x2C5B660
	public static void LoadPrefabAsync() { }

	// RVA: 0x2C5B720 Offset: 0x2C5B821 VA: 0x2C5B720
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2C5B7C0 Offset: 0x2C5B8C1 VA: 0x2C5B7C0
	public static void UnloadPrefab() { }

	// RVA: 0x2C5B860 Offset: 0x2C5B961 VA: 0x2C5B860
	public static RefineRingResult10Window Create() { }

	// RVA: 0x2C5B9E0 Offset: 0x2C5BAE1 VA: 0x2C5B9E0
	public void Destroy() { }

	// RVA: 0x2C5BA60 Offset: 0x2C5BB61 VA: 0x2C5BA60
	private void .ctor() { }

	// RVA: 0x2C5BA70 Offset: 0x2C5BB71 VA: 0x2C5BA70
	public bool IsOpening() { }

	// RVA: 0x2C5BB40 Offset: 0x2C5BC41 VA: 0x2C5BB40
	public void Close() { }

	// RVA: 0x2C5BC00 Offset: 0x2C5BD01 VA: 0x2C5BC00
	public bool IsClosing() { }

	// RVA: 0x2C5BCD0 Offset: 0x2C5BDD1 VA: 0x2C5BCD0
	public void SetData(List<RingData> ringDataList, List<bool> isNewList) { }

	// RVA: 0x2C5BDF0 Offset: 0x2C5BEF1 VA: 0x2C5BDF0
	private static void .cctor() { }
}

// Namespace: App
public class RefineRingResult1Window : MonoBehaviour // TypeDefIndex: 11091
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	public Animator m_CharacterImageRootAnimator; // 0x18
	public Animator m_RingParamRootAnimator; // 0x20
	public Animator m_NewAnimator; // 0x28
	[SpaceAttribute] // RVA: 0x2966E0 Offset: 0x2967E1 VA: 0x2966E0
	public Image m_CharacterImage; // 0x30
	public Image m_FrameImage; // 0x38
	public GameObject m_NewObject; // 0x40
	public TextMeshProUGUI m_NewText; // 0x48
	[HeaderAttribute] // RVA: 0x296700 Offset: 0x296801 VA: 0x296700
	public Image m_RingIconImage; // 0x50
	public TextMeshProUGUI m_CharacterNameText; // 0x58
	public RefineRingResult1Window.RingParam[] m_RingParams; // 0x60
	public GameObject m_SkillRootObject; // 0x68
	public Image m_SkillIconImage; // 0x70
	public TextMeshProUGUI m_SkillNameText; // 0x78
	public TextMeshProUGUI m_SkillHelpText; // 0x80

	// Methods

	// RVA: 0x2C5BE60 Offset: 0x2C5BF61 VA: 0x2C5BE60
	public static void LoadPrefabAsync() { }

	// RVA: 0x2C5BF20 Offset: 0x2C5C021 VA: 0x2C5BF20
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2C5BFC0 Offset: 0x2C5C0C1 VA: 0x2C5BFC0
	public static void UnloadPrefab() { }

	// RVA: 0x2C5C060 Offset: 0x2C5C161 VA: 0x2C5C060
	public static RefineRingResult1Window Create() { }

	// RVA: 0x2C5C1E0 Offset: 0x2C5C2E1 VA: 0x2C5C1E0
	public void Destroy() { }

	// RVA: 0x2C5C260 Offset: 0x2C5C361 VA: 0x2C5C260
	private void .ctor() { }

	// RVA: 0x2C5C270 Offset: 0x2C5C371 VA: 0x2C5C270
	public bool IsOpening() { }

	// RVA: 0x2C5C3F0 Offset: 0x2C5C4F1 VA: 0x2C5C3F0
	public void Close() { }

	// RVA: 0x2C5C540 Offset: 0x2C5C641 VA: 0x2C5C540
	public bool IsClosing() { }

	// RVA: 0x2C5C6C0 Offset: 0x2C5C7C1 VA: 0x2C5C6C0
	public void SetData(RingData ringData, bool isNew) { }

	// RVA: 0x2C5D050 Offset: 0x2C5D151 VA: 0x2C5D050
	private static void .cctor() { }
}

