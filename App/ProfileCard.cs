// Namespace: App
public class ProfileCard // TypeDefIndex: 13635
{
	// Fields
	private const int Version = 11;
	public const int MessageMax = 3;
	public const int StampMax = 50;
	public const int SortieCountMax = 10;
	public const int PageCount = 2;
	public const int StampMaxVer5 = 10;
	private string m_UserName; // 0x10
	private Language.Langs m_Lang; // 0x18
	private ProfileCardTitleData m_Title; // 0x20
	private ProfileCardBgData m_Bg; // 0x28
	private ProfileCardFrameData m_Frame; // 0x30
	private ProfileCardTextDecoData m_TextDeco; // 0x38
	private ProfileCardTextColorData m_TextColor; // 0x40
	private ProfileCardCharacterStampData m_CharacterStamp; // 0x48
	private ProfileCardCommentData[] m_Comment; // 0x50
	private string m_CommentString; // 0x58
	private float m_PlayTime; // 0x60
	private byte m_BirthMonth; // 0x64
	private byte m_BirthDay; // 0x65
	private Difficulty m_Difficulty; // 0x68
	private GameMode m_GameMode; // 0x6C
	private Gender m_Gender; // 0x70
	private ProfileCardFavoriteCharacterData m_FavoriteCharacter; // 0x78
	private ProfileCardFavoriteMapData m_FavoriteMap; // 0x80
	private uint m_RelayPlayingCount; // 0x88
	private ProfileCardThemeOfEditMapData m_VersusThemeOfEditMap; // 0x90
	private int m_VersusRate; // 0x98
	private uint m_VersusPlayingCount; // 0x9C
	private ulong m_OwnerID; // 0xA0
	private bool m_IsPublic; // 0xA8
	private List<ProfileCard.FreeStamp>[] m_FreeStamp; // 0xB0
	private ProfileCard.SortieCount[] m_SortieCount; // 0xB8
	private ProfileCard.Achievement[] m_Achievements; // 0xC0
	private byte[] m_Images; // 0xC8
	private static StringBuilder m_MessageBufferTemp; // 0x0

	// Properties
	public Language.Langs Lang { get; set; }
	public ProfileCardTitleData Title { get; set; }
	public ProfileCardBgData Bg { get; set; }
	public ProfileCardFrameData Frame { get; set; }
	public ProfileCardTextDecoData TextDeco { get; set; }
	public ProfileCardTextColorData TextColor { get; set; }
	public ProfileCardCharacterStampData CharacterStamp { get; set; }
	public ProfileCardCommentData[] Comment { get; set; }
	public string CommentString { get; }
	public float PlayTime { get; set; }
	public int PlayTimeHour { get; set; }
	public int PlayTimeMinute { get; set; }
	public byte BirthMonth { get; set; }
	public byte BirthDay { get; set; }
	public Difficulty Difficulty { get; set; }
	public GameMode GameMode { get; set; }
	public Gender Gender { get; set; }
	public ProfileCardFavoriteCharacterData FavoriteCharacter { get; set; }
	public ProfileCardFavoriteMapData FavoriteMap { get; set; }
	public uint RelayPlayingCount { get; set; }
	public ProfileCardThemeOfEditMapData VersusThemeOfEditMap { get; set; }
	public int VersusRate { get; set; }
	public uint VersusPlayingCount { get; set; }
	public ulong OwnerID { get; set; }
	public bool IsPublic { get; set; }
	public List<ProfileCard.FreeStamp>[] FreeStampListArray { get; }

	// Methods

	// RVA: 0x29E6F60 Offset: 0x29E7061 VA: 0x29E6F60
	public void .ctor() { }

	// RVA: 0x29E7620 Offset: 0x29E7721 VA: 0x29E7620
	public void .ctor(ProfileCard src) { }

	// RVA: 0x29E7210 Offset: 0x29E7311 VA: 0x29E7210
	public void Clear() { }

	// RVA: 0x29E7830 Offset: 0x29E7931 VA: 0x29E7830
	public void Copy(ProfileCard src) { }

	// RVA: 0x29E7C80 Offset: 0x29E7D81 VA: 0x29E7C80
	public byte[] GetImage() { }

	// RVA: 0x29E7C90 Offset: 0x29E7D91 VA: 0x29E7C90
	public void SetImage(byte[] image) { }

	// RVA: 0x29E7CA0 Offset: 0x29E7DA1 VA: 0x29E7CA0
	public string GetUserName() { }

	// RVA: 0x29E7CB0 Offset: 0x29E7DB1 VA: 0x29E7CB0
	public string GetCheckedUserName() { }

	// RVA: 0x29E7CE0 Offset: 0x29E7DE1 VA: 0x29E7CE0
	public void SetUserName(string name) { }

	// RVA: 0x29E7CF0 Offset: 0x29E7DF1 VA: 0x29E7CF0
	public Language.Langs get_Lang() { }

	// RVA: 0x29E7D00 Offset: 0x29E7E01 VA: 0x29E7D00
	public void set_Lang(Language.Langs value) { }

	// RVA: 0x29E7D10 Offset: 0x29E7E11 VA: 0x29E7D10
	public ProfileCardTitleData get_Title() { }

	// RVA: 0x29E7D20 Offset: 0x29E7E21 VA: 0x29E7D20
	public void set_Title(ProfileCardTitleData value) { }

	// RVA: 0x29E7D30 Offset: 0x29E7E31 VA: 0x29E7D30
	public string GetTitleName() { }

	// RVA: 0x29E7DA0 Offset: 0x29E7EA1 VA: 0x29E7DA0
	public ProfileCardBgData get_Bg() { }

	// RVA: 0x29E7DB0 Offset: 0x29E7EB1 VA: 0x29E7DB0
	public void set_Bg(ProfileCardBgData value) { }

	// RVA: 0x29E7DC0 Offset: 0x29E7EC1 VA: 0x29E7DC0
	public ProfileCardFrameData get_Frame() { }

	// RVA: 0x29E7DD0 Offset: 0x29E7ED1 VA: 0x29E7DD0
	public void set_Frame(ProfileCardFrameData value) { }

	// RVA: 0x29E7DE0 Offset: 0x29E7EE1 VA: 0x29E7DE0
	public ProfileCardTextDecoData get_TextDeco() { }

	// RVA: 0x29E7DF0 Offset: 0x29E7EF1 VA: 0x29E7DF0
	public void set_TextDeco(ProfileCardTextDecoData value) { }

	// RVA: 0x29E7E00 Offset: 0x29E7F01 VA: 0x29E7E00
	public ProfileCardTextColorData get_TextColor() { }

	// RVA: 0x29E7E10 Offset: 0x29E7F11 VA: 0x29E7E10
	public void set_TextColor(ProfileCardTextColorData value) { }

	// RVA: 0x29E7E20 Offset: 0x29E7F21 VA: 0x29E7E20
	public ProfileCardCharacterStampData get_CharacterStamp() { }

	// RVA: 0x29E7E30 Offset: 0x29E7F31 VA: 0x29E7E30
	public void set_CharacterStamp(ProfileCardCharacterStampData value) { }

	// RVA: 0x29E7E40 Offset: 0x29E7F41 VA: 0x29E7E40
	public ProfileCardCommentData[] get_Comment() { }

	// RVA: 0x29E7E50 Offset: 0x29E7F51 VA: 0x29E7E50
	public void set_Comment(ProfileCardCommentData[] value) { }

	// RVA: 0x29E7F60 Offset: 0x29E8061 VA: 0x29E7F60
	public string get_CommentString() { }

	// RVA: 0x29E7F70 Offset: 0x29E8071 VA: 0x29E7F70
	public void InitializeComment() { }

	// RVA: 0x29E8220 Offset: 0x29E8321 VA: 0x29E8220
	public ProfileCardCommentData GetComment(int i) { }

	// RVA: 0x29E8280 Offset: 0x29E8381 VA: 0x29E8280
	public string GetCommentMessage(int i) { }

	// RVA: 0x29E8110 Offset: 0x29E8211 VA: 0x29E8110
	public void SetComment(int i, string pccid) { }

	// RVA: 0x29E7E80 Offset: 0x29E7F81 VA: 0x29E7E80
	public void GenerateCommentString() { }

	// RVA: 0x29E8360 Offset: 0x29E8461 VA: 0x29E8360
	public float get_PlayTime() { }

	// RVA: 0x29E8370 Offset: 0x29E8471 VA: 0x29E8370
	public void set_PlayTime(float value) { }

	// RVA: 0x29E8380 Offset: 0x29E8481 VA: 0x29E8380
	public int get_PlayTimeHour() { }

	// RVA: 0x29E8400 Offset: 0x29E8501 VA: 0x29E8400
	public void set_PlayTimeHour(int value) { }

	// RVA: 0x29E8410 Offset: 0x29E8511 VA: 0x29E8410
	public int get_PlayTimeMinute() { }

	// RVA: 0x29E8490 Offset: 0x29E8591 VA: 0x29E8490
	public void set_PlayTimeMinute(int value) { }

	// RVA: 0x29E84A0 Offset: 0x29E85A1 VA: 0x29E84A0
	public byte get_BirthMonth() { }

	// RVA: 0x29E84B0 Offset: 0x29E85B1 VA: 0x29E84B0
	public void set_BirthMonth(byte value) { }

	// RVA: 0x29E84C0 Offset: 0x29E85C1 VA: 0x29E84C0
	public byte get_BirthDay() { }

	// RVA: 0x29E84D0 Offset: 0x29E85D1 VA: 0x29E84D0
	public void set_BirthDay(byte value) { }

	// RVA: 0x29E84E0 Offset: 0x29E85E1 VA: 0x29E84E0
	public Difficulty get_Difficulty() { }

	// RVA: 0x29E84F0 Offset: 0x29E85F1 VA: 0x29E84F0
	public void set_Difficulty(Difficulty value) { }

	// RVA: 0x29E8500 Offset: 0x29E8601 VA: 0x29E8500
	public GameMode get_GameMode() { }

	// RVA: 0x29E8510 Offset: 0x29E8611 VA: 0x29E8510
	public void set_GameMode(GameMode value) { }

	// RVA: 0x29E8520 Offset: 0x29E8621 VA: 0x29E8520
	public Gender get_Gender() { }

	// RVA: 0x29E8530 Offset: 0x29E8631 VA: 0x29E8530
	public void set_Gender(Gender value) { }

	// RVA: 0x29E8540 Offset: 0x29E8641 VA: 0x29E8540
	public ProfileCardFavoriteCharacterData get_FavoriteCharacter() { }

	// RVA: 0x29E8550 Offset: 0x29E8651 VA: 0x29E8550
	public void set_FavoriteCharacter(ProfileCardFavoriteCharacterData value) { }

	// RVA: 0x29E8560 Offset: 0x29E8661 VA: 0x29E8560
	public void SetFavoriteCharacter(string pcfcid) { }

	// RVA: 0x29E8600 Offset: 0x29E8701 VA: 0x29E8600
	public ProfileCardFavoriteMapData get_FavoriteMap() { }

	// RVA: 0x29E8610 Offset: 0x29E8711 VA: 0x29E8610
	public void set_FavoriteMap(ProfileCardFavoriteMapData value) { }

	// RVA: 0x29E8620 Offset: 0x29E8721 VA: 0x29E8620
	public uint get_RelayPlayingCount() { }

	// RVA: 0x29E8630 Offset: 0x29E8731 VA: 0x29E8630
	public void set_RelayPlayingCount(uint value) { }

	// RVA: 0x29E8640 Offset: 0x29E8741 VA: 0x29E8640
	public ProfileCardThemeOfEditMapData get_VersusThemeOfEditMap() { }

	// RVA: 0x29E8650 Offset: 0x29E8751 VA: 0x29E8650
	public void set_VersusThemeOfEditMap(ProfileCardThemeOfEditMapData value) { }

	// RVA: 0x29E8660 Offset: 0x29E8761 VA: 0x29E8660
	public int get_VersusRate() { }

	// RVA: 0x29E8670 Offset: 0x29E8771 VA: 0x29E8670
	public void set_VersusRate(int value) { }

	// RVA: 0x29E8680 Offset: 0x29E8781 VA: 0x29E8680
	public uint get_VersusPlayingCount() { }

	// RVA: 0x29E8690 Offset: 0x29E8791 VA: 0x29E8690
	public void set_VersusPlayingCount(uint value) { }

	// RVA: 0x29E86A0 Offset: 0x29E87A1 VA: 0x29E86A0
	public ulong get_OwnerID() { }

	// RVA: 0x29E86B0 Offset: 0x29E87B1 VA: 0x29E86B0
	public void set_OwnerID(ulong value) { }

	// RVA: 0x29E86C0 Offset: 0x29E87C1 VA: 0x29E86C0
	public bool get_IsPublic() { }

	// RVA: 0x29E8760 Offset: 0x29E8861 VA: 0x29E8760
	public void set_IsPublic(bool value) { }

	// RVA: 0x29E8770 Offset: 0x29E8871 VA: 0x29E8770
	public List<ProfileCard.FreeStamp>[] get_FreeStampListArray() { }

	// RVA: 0x29E8780 Offset: 0x29E8881 VA: 0x29E8780
	public ProfileCard.FreeStamp GetFreeStamp(int page, int index) { }

	// RVA: 0x29E8850 Offset: 0x29E8951 VA: 0x29E8850
	public int GetFreeStampCount(bool isFront) { }

	// RVA: 0x29E8900 Offset: 0x29E8A01 VA: 0x29E8900
	public int GetFreeStampCount(int page) { }

	// RVA: 0x29E8990 Offset: 0x29E8A91 VA: 0x29E8990
	public ProfileCard.FreeStamp AddFreeStamp(ProfileCardStampData stampData, Vector2 position, float rotation, float scaleX, float scaleY, bool isFront) { }

	// RVA: 0x29E8AB0 Offset: 0x29E8BB1 VA: 0x29E8AB0
	public void RemoveFreeStamp(ProfileCard.FreeStamp freeStamp, bool isFront) { }

	// RVA: 0x29E8B60 Offset: 0x29E8C61 VA: 0x29E8B60
	public void ClearFreeStamp(bool isFront) { }

	// RVA: 0x29E8C00 Offset: 0x29E8D01 VA: 0x29E8C00
	public void CopyFreeStamp(List<ProfileCard.FreeStamp>[] freeStampListArray) { }

	// RVA: 0x29E8D50 Offset: 0x29E8E51 VA: 0x29E8D50
	public ProfileCard.SortieCount GetSortieCount(int index) { }

	// RVA: 0x29E8DA0 Offset: 0x29E8EA1 VA: 0x29E8DA0
	public void SetSortieCount(int index, PersonData personData, JobData jobData, int count) { }

	// RVA: 0x29E8E50 Offset: 0x29E8F51 VA: 0x29E8E50
	public void SortSortieCount() { }

	// RVA: 0x29E8F80 Offset: 0x29E9081 VA: 0x29E8F80
	public void ClearSortieCount() { }

	// RVA: 0x29E9000 Offset: 0x29E9101 VA: 0x29E9000
	public int GetAchievement(AchieveData.Categories category) { }

	// RVA: 0x29E9040 Offset: 0x29E9141 VA: 0x29E9040
	public void SetAchievement(AchieveData.Categories categoty, int count) { }

	// RVA: 0x29E9080 Offset: 0x29E9181 VA: 0x29E9080
	public void Serialize(Stream stream) { }

	// RVA: 0x29E9610 Offset: 0x29E9711 VA: 0x29E9610
	public void Deserialize(Stream stream) { }

	// RVA: 0x29EB6D0 Offset: 0x29EB7D1 VA: 0x29EB6D0
	private static void .cctor() { }
}

