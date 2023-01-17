// Namespace: App
public class ChallengeMapSelectRoot : MonoBehaviour // TypeDefIndex: 9784
{
	// Fields
	private const string PrefabPath = "UI/Network/Challenge/Prefabs/MapSelectRoot";
	private const string SpriteAtlasPath = "UI/Network/Challenge/Thumnail/Thumnail";
	private SpriteAtlas m_SpriteAtlas; // 0x18
	public BasicMenuContent m_MapSelectMenuContent; // 0x20
	public BasicMenuContent m_DifficultySelectMenu; // 0x28
	public GameObject m_MapHelpObj; // 0x30
	[HeaderAttribute] // RVA: 0x2876B0 Offset: 0x2877B1 VA: 0x2876B0
	public TextMeshProUGUI m_MapTitleText; // 0x38
	public TextMeshProUGUI m_BattleCountText; // 0x40
	public Image m_MapImage; // 0x48
	public TextMeshProUGUI m_DifficultyValueText; // 0x50
	public TextMeshProUGUI m_TurnCountValueText; // 0x58
	[HeaderAttribute] // RVA: 0x2876F0 Offset: 0x2877F1 VA: 0x2876F0
	public ChallengeMapSelectRoot.RewardInfoItem[] m_RewardInfoItem; // 0x60
	[HeaderAttribute] // RVA: 0x287730 Offset: 0x287831 VA: 0x287730
	public TextMeshProUGUI[] m_ExpTextList; // 0x68
	[HeaderAttribute] // RVA: 0x287770 Offset: 0x287871 VA: 0x287770
	public GameObject m_SpRoot; // 0x70
	public TextMeshProUGUI[] m_SpTextList; // 0x78
	private ChallengeData m_SelectChallengeData; // 0x80
	private Sprite m_MapImageSprite; // 0x88
	private Animator m_RootAnim; // 0x90

	// Methods

	// RVA: 0x29B1510 Offset: 0x29B1611 VA: 0x29B1510
	public static void LoadPrefabAsync() { }

	// RVA: 0x29B15F0 Offset: 0x29B16F1 VA: 0x29B15F0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x29B16C0 Offset: 0x29B17C1 VA: 0x29B16C0
	public static void UnloadPrefab() { }

	// RVA: 0x29B1760 Offset: 0x29B1861 VA: 0x29B1760
	public static ChallengeMapSelectRoot CreateRoot() { }

	// RVA: 0x29B18C0 Offset: 0x29B19C1 VA: 0x29B18C0
	private void Create() { }

	// RVA: 0x29B1A00 Offset: 0x29B1B01 VA: 0x29B1A00
	public void Destroy() { }

	// RVA: 0x29B1A90 Offset: 0x29B1B91 VA: 0x29B1A90
	private void .ctor() { }

	// RVA: 0x29B1AA0 Offset: 0x29B1BA1 VA: 0x29B1AA0
	public BasicMenuContent GetChallengeMapSelectMenuContent() { }

	// RVA: 0x29B1AB0 Offset: 0x29B1BB1 VA: 0x29B1AB0
	public BasicMenuContent GetChallengeDifficultyMenuContent() { }

	// RVA: 0x29B0DC0 Offset: 0x29B0EC1 VA: 0x29B0DC0
	public void SetMapHelpActive() { }

	// RVA: 0x29B0870 Offset: 0x29B0971 VA: 0x29B0870
	public void OnSelect(ChallengeData challengeData) { }

	// RVA: 0x29AECF0 Offset: 0x29AEDF1 VA: 0x29AECF0
	public void SetReward(int level, bool isItemDropUnknow = False) { }

	// RVA: 0x29B1AC0 Offset: 0x29B1BC1 VA: 0x29B1AC0
	public void Close() { }

	// RVA: 0x29B1B70 Offset: 0x29B1C71 VA: 0x29B1B70
	public bool IsClosed() { }
}

