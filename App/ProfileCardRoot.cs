// Namespace: App
public class ProfileCardRoot : MonoBehaviour // TypeDefIndex: 11611
{
	// Fields
	private const string PrefabPath = "UI/Network/ProfileCard/Prefabs/Card";
	public RectTransform m_RectTransform; // 0x18
	public Animator m_Animator; // 0x20
	public CanvasGroup m_CanvasGroup; // 0x28
	public Image m_FrameImage; // 0x30
	public Image m_BgImage; // 0x38
	[HeaderAttribute] // RVA: 0x2989A0 Offset: 0x298AA1 VA: 0x2989A0
	public GameObject m_FrontPage; // 0x40
	public TextMeshProUGUI m_UserName; // 0x48
	public GameObject m_Hyphen; // 0x50
	public TextMeshProUGUI m_Title; // 0x58
	public Image m_TitleBgImage; // 0x60
	public Image m_Photo; // 0x68
	public Image m_CharacterStamp; // 0x70
	public TextMeshProUGUI m_Comment; // 0x78
	public Image m_CommentBgImage; // 0x80
	public TextMeshProUGUI m_PlayerInfoCaption; // 0x88
	public Image m_PlayerInfoCaptionBgImage; // 0x90
	public TextMeshProUGUI m_PlayTimeCaption; // 0x98
	public TextMeshProUGUI m_PlayTime; // 0xA0
	public Image m_PlayTimeBgImage; // 0xA8
	public TextMeshProUGUI m_BirthdayCaption; // 0xB0
	public TextMeshProUGUI m_Birthday; // 0xB8
	public Image m_BirthdayBgImane; // 0xC0
	public TextMeshProUGUI m_DifficultyCaption; // 0xC8
	public TextMeshProUGUI m_Difficulty; // 0xD0
	public Image m_DifficultyBgImage; // 0xD8
	public TextMeshProUGUI m_ModeCaption; // 0xE0
	public TextMeshProUGUI m_Mode; // 0xE8
	public Image m_ModeBgImage; // 0xF0
	public TextMeshProUGUI m_FavoriteCharacterCaption; // 0xF8
	public TextMeshProUGUI m_FavoriteCharacter; // 0x100
	public Image m_FavoriteCharacterBgImage; // 0x108
	public TextMeshProUGUI m_FavoriteMapCaption; // 0x110
	public TextMeshProUGUI m_FavoriteMap; // 0x118
	public Image m_FavoriteMapBgImage; // 0x120
	public TextMeshProUGUI m_RelayCaption; // 0x128
	public Image m_RelayCaptionBgImage; // 0x130
	public TextMeshProUGUI m_RelayPlayCountCaption; // 0x138
	public TextMeshProUGUI m_RelayPlayCount; // 0x140
	public Image m_RelayPlayCountBgImage; // 0x148
	public TextMeshProUGUI m_VersusCaption; // 0x150
	public Image m_VersusCaptionBgImage; // 0x158
	public TextMeshProUGUI m_VersusMapThemeCaption; // 0x160
	public TextMeshProUGUI m_VersusMapTheme; // 0x168
	public Image m_VersusMapThemeBgImage; // 0x170
	public TextMeshProUGUI m_VersusPlayCountCaption; // 0x178
	public TextMeshProUGUI m_VersusPlayCount; // 0x180
	public Image m_VersusPlayCountBgImage; // 0x188
	public TextMeshProUGUI m_VersusRateCaption; // 0x190
	public TextMeshProUGUI m_VersusRate; // 0x198
	public Image m_VersusRateBgImage; // 0x1A0
	public Image[] m_InfoLineImage; // 0x1A8
	public GameObject m_FrontStampRoot; // 0x1B0
	public GameObject m_FrontStampOrigin; // 0x1B8
	[HeaderAttribute] // RVA: 0x2989E0 Offset: 0x298AE1 VA: 0x2989E0
	public GameObject m_BackPage; // 0x1C0
	public TextMeshProUGUI m_SortieCountCaption; // 0x1C8
	public Image m_SortieCountCaptionBgImage; // 0x1D0
	public ProfileCardRoot.SortieCountInfo[] m_SortieCount; // 0x1D8
	public TextMeshProUGUI m_AchievementCaption; // 0x1E0
	public Image m_AchievementCaptionBgImage; // 0x1E8
	public ProfileCardRoot.AchievementInfo[] m_Achievement; // 0x1F0
	public GameObject m_BackStampRoot; // 0x1F8
	public GameObject m_BackStampOrigin; // 0x200
	[HeaderAttribute] // RVA: 0x298A20 Offset: 0x298B21 VA: 0x298A20
	public Animator m_BgHighlightAnimator; // 0x208
	public Animator m_FrameHighlightAnimator; // 0x210
	public Animator m_TextDecoHighlightAnimator; // 0x218
	public Animator m_TextHighlightAnimator; // 0x220
	public Animator m_TitleHightlightAnimator; // 0x228
	public Animator m_PhotoHighlightAnimator; // 0x230
	public Animator m_CharaStampHighlightAnimator; // 0x238
	public Animator m_CommentHighlightAnimator; // 0x240
	public Animator m_FavoriteCharacterHighlightAnimator; // 0x248
	public Animator m_FavoriteRelayMapHighlightAnimator; // 0x250
	[HeaderAttribute] // RVA: 0x298A60 Offset: 0x298B61 VA: 0x298A60
	public float m_OpenPositionY; // 0x258
	public Vector2 m_SmallPosition; // 0x25C
	public Vector2 m_SmallScale; // 0x264
	private static readonly string m_CharacterStampEmptyImageName; // 0x0
	private bool m_IsFront; // 0x26C
	private StringBuilder m_MessageStringBuilder; // 0x270
	private bool m_IsEFIGS; // 0x278
	private bool m_StampIsVisible; // 0x279
	private ProfileCardBgData m_BgData; // 0x280
	private ProfileCardBgData m_BgDataLoading; // 0x288
	private ProfileCardFrameData m_FrameData; // 0x290
	private ProfileCardFrameData m_FrameDataLoading; // 0x298
	private ProfileCard.FreeStamp[,] m_FreeStamp; // 0x2A0
	private Texture2D m_PhotoTexture2d; // 0x2A8
	private Sprite m_PhotoSprite; // 0x2B0
	private ProfileCardRoot.StartHandler m_StartHandler; // 0x2B8

	// Methods

	// RVA: 0x281A480 Offset: 0x281A581 VA: 0x281A480
	private void .ctor() { }

	// RVA: 0x281A520 Offset: 0x281A621 VA: 0x281A520
	private void Start() { }

	// RVA: 0x281B1D0 Offset: 0x281B2D1 VA: 0x281B1D0
	public void SetStartHandler(ProfileCardRoot.StartHandler startHandler) { }

	// RVA: 0x281B140 Offset: 0x281B241 VA: 0x281B140
	private StringBuilder GetStringBuilder() { }

	// RVA: 0x281B1E0 Offset: 0x281B2E1 VA: 0x281B1E0
	public bool IsOpening() { }

	// RVA: 0x281B2E0 Offset: 0x281B3E1 VA: 0x281B2E0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2806080 Offset: 0x2806181 VA: 0x2806080
	public void UpdateCard(ProfileCard card) { }

	// RVA: 0x281CF00 Offset: 0x281D001 VA: 0x281CF00
	public void UpdataUserName(string userName) { }

	// RVA: 0x281D020 Offset: 0x281D121 VA: 0x281D020
	public void UpdateTitle(ProfileCardTitleData titleData) { }

	// RVA: 0x281D4F0 Offset: 0x281D5F1 VA: 0x281D4F0
	private void UpdateHyphen() { }

	// RVA: 0x281D110 Offset: 0x281D211 VA: 0x281D110
	public void UpdatePhoto(byte[] image) { }

	// RVA: 0x281D5F0 Offset: 0x281D6F1 VA: 0x281D5F0
	private void DestroyPhoto() { }

	// RVA: 0x281D450 Offset: 0x281D551 VA: 0x281D450
	public void UpdateComment(string commentString) { }

	// RVA: 0x2818FB0 Offset: 0x28190B1 VA: 0x2818FB0
	public void UpdatePlayTime(float playTime) { }

	// RVA: 0x281D720 Offset: 0x281D821 VA: 0x281D720
	public void UpdatePlayTime(int hour, int minute) { }

	// RVA: 0x2810980 Offset: 0x2810A81 VA: 0x2810980
	public void UpdateFavoriteCharacter(ProfileCardFavoriteCharacterData characterData) { }

	// RVA: 0x2812A10 Offset: 0x2812B11 VA: 0x2812A10
	public void UpdateFavoriteMap(ProfileCardFavoriteMapData mapData) { }

	// RVA: 0x281D820 Offset: 0x281D921 VA: 0x281D820
	public void UpdateBg(string pcbgid) { }

	// RVA: 0x281B3A0 Offset: 0x281B4A1 VA: 0x281B3A0
	public void UpdateBg(ProfileCardBgData bgData) { }

	// RVA: 0x281D8B0 Offset: 0x281D9B1 VA: 0x281D8B0
	public void UpdateFrame(string pcfid) { }

	// RVA: 0x281B5F0 Offset: 0x281B6F1 VA: 0x281B5F0
	public void UpdateFrame(ProfileCardFrameData frameData) { }

	// RVA: 0x281D940 Offset: 0x281DA41 VA: 0x281D940
	public void UpdateCharacterStamp(string id) { }

	// RVA: 0x281D2F0 Offset: 0x281D3F1 VA: 0x281D2F0
	public void UpdateCharacterStamp(ProfileCardCharacterStampData stampData) { }

	// RVA: 0x281D9D0 Offset: 0x281DAD1 VA: 0x281D9D0
	public void UpdateTextDeco(string pctdid) { }

	// RVA: 0x281B860 Offset: 0x281B961 VA: 0x281B860
	public void UpdateTextDeco(ProfileCardTextDecoData decoData) { }

	// RVA: 0x281DA60 Offset: 0x281DB61 VA: 0x281DA60
	public void UpdateTextColor(string pctcid) { }

	// RVA: 0x281C1C0 Offset: 0x281C2C1 VA: 0x281C1C0
	public void UpdateTextColor(ProfileCardTextColorData textColorData) { }

	// RVA: 0x281CD70 Offset: 0x281CE71 VA: 0x281CD70
	public void UpdateFreeStamp(List<ProfileCard.FreeStamp>[] freeStampListArray) { }

	// RVA: 0x281E020 Offset: 0x281E121 VA: 0x281E020
	public void SetFreeStampVisibility(bool visible) { }

	// RVA: 0x281DB50 Offset: 0x281DC51 VA: 0x281DB50
	public void AddFreeStamp(ProfileCard.FreeStamp freeStamp, int page) { }

	// RVA: 0x281E130 Offset: 0x281E231 VA: 0x281E130
	public void RemoveFreeStamp(ProfileCard.FreeStamp freeStamp, int page) { }

	// RVA: 0x281DAF0 Offset: 0x281DBF1 VA: 0x281DAF0
	public void ClearFreeStamp() { }

	// RVA: 0x281E400 Offset: 0x281E501 VA: 0x281E400
	public void ClearFreeStamp(int page) { }

	// RVA: 0x281E670 Offset: 0x281E771 VA: 0x281E670
	public ProfileCardStampObject GetStampObject(int index) { }

	// RVA: 0x281E7C0 Offset: 0x281E8C1 VA: 0x281E7C0
	public ProfileCard.FreeStamp GetStamp(int index) { }

	// RVA: 0x281E830 Offset: 0x281E931 VA: 0x281E830
	public void SetStampFrameActive(int stampIndex, bool actived) { }

	// RVA: 0x281E870 Offset: 0x281E971 VA: 0x281E870
	public bool IsStampExist(ProfileCardRoot.RectInfo rect) { }

	// RVA: 0x281E920 Offset: 0x281EA21 VA: 0x281E920
	public ProfileCard.FreeStamp GetOverlappedStamp(ProfileCardRoot.RectInfo rect) { }

	// RVA: 0x281E9C0 Offset: 0x281EAC1 VA: 0x281E9C0
	public int GetOverlappedStampIndex(ProfileCardRoot.RectInfo rect) { }

	// RVA: 0x281EDE0 Offset: 0x281EEE1 VA: 0x281EDE0
	public bool Contain(RectTransform rectTransform) { }

	// RVA: 0x281EFA0 Offset: 0x281F0A1 VA: 0x281EFA0
	public Rect GetRect() { }

	// RVA: 0x281F110 Offset: 0x281F211 VA: 0x281F110 Slot: 4
	public virtual void Open() { }

	// RVA: 0x28085F0 Offset: 0x28086F1 VA: 0x28085F0
	public void SwitchPages() { }

	// RVA: 0x28084A0 Offset: 0x28085A1 VA: 0x28084A0
	public bool IsSwithcingPages() { }

	// RVA: 0x281F170 Offset: 0x281F271 VA: 0x281F170
	public bool IsFront() { }

	// RVA: 0x281F180 Offset: 0x281F281 VA: 0x281F180
	public void SwitchScale() { }

	// RVA: 0x281F2C0 Offset: 0x281F3C1 VA: 0x281F2C0
	public void ScaleSmall() { }

	// RVA: 0x280F0E0 Offset: 0x280F1E1 VA: 0x280F0E0
	public void ScaleSmallImmediately() { }

	// RVA: 0x281F3B0 Offset: 0x281F4B1 VA: 0x281F3B0
	public void ScaleLarge() { }

	// RVA: 0x281F4A0 Offset: 0x281F5A1 VA: 0x281F4A0
	public bool IsScalingSmall() { }

	// RVA: 0x281F560 Offset: 0x281F661 VA: 0x281F560
	public bool IsScalingLarge() { }

	// RVA: 0x281E030 Offset: 0x281E131 VA: 0x281E030
	public bool IsScaledSmall() { }

	// RVA: 0x281F620 Offset: 0x281F721 VA: 0x281F620
	public void BlinkBg(bool on) { }

	// RVA: 0x281F650 Offset: 0x281F751 VA: 0x281F650
	public void BlinkFrame(bool on) { }

	// RVA: 0x281F680 Offset: 0x281F781 VA: 0x281F680
	public void BlinkTextDeco(bool on) { }

	// RVA: 0x281F6B0 Offset: 0x281F7B1 VA: 0x281F6B0
	public void BlinkText(bool on) { }

	// RVA: 0x281F6E0 Offset: 0x281F7E1 VA: 0x281F6E0
	public void BlinkTitle(bool on) { }

	// RVA: 0x281F710 Offset: 0x281F811 VA: 0x281F710
	public void BlinkPhoto(bool on) { }

	// RVA: 0x281F740 Offset: 0x281F841 VA: 0x281F740
	public void BlinkCharacterStamp(bool on) { }

	// RVA: 0x281F770 Offset: 0x281F871 VA: 0x281F770
	public void BlinkComment(bool on) { }

	// RVA: 0x281F7A0 Offset: 0x281F8A1 VA: 0x281F7A0
	public void BlinkFavoriteCharacter(bool on) { }

	// RVA: 0x281F7D0 Offset: 0x281F8D1 VA: 0x281F7D0
	public void BlinkFavoriteRelayMap(bool on) { }

	// RVA: 0x2808F10 Offset: 0x2809011 VA: 0x2808F10
	public void Close() { }

	// RVA: 0x2809120 Offset: 0x2809221 VA: 0x2809120
	public bool IsClosing() { }

	// RVA: 0x281F800 Offset: 0x281F901 VA: 0x281F800
	public bool IsClosed() { }

	// RVA: 0x2809260 Offset: 0x2809361 VA: 0x2809260
	public void Destroy() { }

	// RVA: 0x281F8C0 Offset: 0x281F9C1 VA: 0x281F8C0
	private static void .cctor() { }
}

