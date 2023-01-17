// Namespace: App
public class ProfileCardFlags : SingletonClass<ProfileCardFlags> // TypeDefIndex: 11590
{
	// Fields
	private Dictionary<int, bool> m_Dictionary; // 0x20

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x2813B10 Offset: 0x2813C11 VA: 0x2813B10 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2813B20 Offset: 0x2813C21 VA: 0x2813B20
	public void .ctor() { }

	// RVA: 0x2813C00 Offset: 0x2813D01 VA: 0x2813C00
	public void Initialize() { }

	// RVA: 0x2814A60 Offset: 0x2814B61 VA: 0x2814A60
	private void Entry(ProfileCardBgData data, bool value = False) { }

	// RVA: 0x2814B20 Offset: 0x2814C21 VA: 0x2814B20
	private void Entry(ProfileCardFrameData data, bool value = False) { }

	// RVA: 0x2814BE0 Offset: 0x2814CE1 VA: 0x2814BE0
	private void Entry(ProfileCardTextDecoData data, bool value = False) { }

	// RVA: 0x2814CA0 Offset: 0x2814DA1 VA: 0x2814CA0
	private void Entry(ProfileCardTextColorData data, bool value = False) { }

	// RVA: 0x2814D60 Offset: 0x2814E61 VA: 0x2814D60
	private void Entry(ProfileCardCharacterStampData data, bool value = False) { }

	// RVA: 0x2814E20 Offset: 0x2814F21 VA: 0x2814E20
	private void Entry(ProfileCardStampData data, bool value = False) { }

	// RVA: 0x2814EE0 Offset: 0x2814FE1 VA: 0x2814EE0
	private void Entry(ProfileCardTitleData data, bool value = False) { }

	// RVA: 0x2814FA0 Offset: 0x28150A1 VA: 0x2814FA0
	private void Entry(ProfileCardFavoriteCharacterData data, bool value = False) { }

	// RVA: 0x2815060 Offset: 0x2815161 VA: 0x2815060
	private void Entry(ProfileCardFavoriteMapData data, bool value = False) { }

	// RVA: 0x2815120 Offset: 0x2815221 VA: 0x2815120
	private void Entry(ProfileCardCommentData data, bool value = False) { }

	// RVA: 0x28151E0 Offset: 0x28152E1 VA: 0x28151E0
	private void Entry(ProfileCardThemeOfEditMapData data, bool value = False) { }

	// RVA: 0x28152A0 Offset: 0x28153A1 VA: 0x28152A0
	private void Entry(int hash, bool value = False) { }

	// RVA: 0x28153C0 Offset: 0x28154C1 VA: 0x28153C0
	public bool IsExist(ProfileCardBgData data) { }

	// RVA: 0x2815430 Offset: 0x2815531 VA: 0x2815430
	public bool IsExist(ProfileCardFrameData data) { }

	// RVA: 0x28154A0 Offset: 0x28155A1 VA: 0x28154A0
	public bool IsExist(ProfileCardTextDecoData data) { }

	// RVA: 0x2815510 Offset: 0x2815611 VA: 0x2815510
	public bool IsExist(ProfileCardTextColorData data) { }

	// RVA: 0x2815580 Offset: 0x2815681 VA: 0x2815580
	public bool IsExist(ProfileCardCharacterStampData data) { }

	// RVA: 0x28155F0 Offset: 0x28156F1 VA: 0x28155F0
	public bool IsExist(ProfileCardStampData data) { }

	// RVA: 0x2815660 Offset: 0x2815761 VA: 0x2815660
	public bool IsExist(ProfileCardTitleData data) { }

	// RVA: 0x28156D0 Offset: 0x28157D1 VA: 0x28156D0
	public bool IsExist(ProfileCardFavoriteCharacterData data) { }

	// RVA: 0x2815740 Offset: 0x2815841 VA: 0x2815740
	public bool IsExist(ProfileCardFavoriteMapData data) { }

	// RVA: 0x28157B0 Offset: 0x28158B1 VA: 0x28157B0
	public bool IsExist(ProfileCardCommentData data) { }

	// RVA: 0x2815820 Offset: 0x2815921 VA: 0x2815820
	public bool IsExist(ProfileCardThemeOfEditMapData data) { }

	// RVA: 0x2815360 Offset: 0x2815461 VA: 0x2815360
	private bool IsExist(int hash) { }

	// RVA: 0x2815890 Offset: 0x2815991 VA: 0x2815890
	public bool Get(ProfileCardBgData data) { }

	// RVA: 0x28159A0 Offset: 0x2815AA1 VA: 0x28159A0
	public bool Get(ProfileCardFrameData data) { }

	// RVA: 0x2815A30 Offset: 0x2815B31 VA: 0x2815A30
	public bool Get(ProfileCardTextDecoData data) { }

	// RVA: 0x2815AC0 Offset: 0x2815BC1 VA: 0x2815AC0
	public bool Get(ProfileCardTextColorData data) { }

	// RVA: 0x2815B50 Offset: 0x2815C51 VA: 0x2815B50
	public bool Get(ProfileCardCharacterStampData data) { }

	// RVA: 0x2815BE0 Offset: 0x2815CE1 VA: 0x2815BE0
	public bool Get(ProfileCardStampData data) { }

	// RVA: 0x2815C70 Offset: 0x2815D71 VA: 0x2815C70
	public bool Get(ProfileCardTitleData data) { }

	// RVA: 0x2811620 Offset: 0x2811721 VA: 0x2811620
	public bool Get(ProfileCardFavoriteCharacterData data) { }

	// RVA: 0x28136F0 Offset: 0x28137F1 VA: 0x28136F0
	public bool Get(ProfileCardFavoriteMapData data) { }

	// RVA: 0x280DFD0 Offset: 0x280E0D1 VA: 0x280DFD0
	public bool Get(ProfileCardCommentData data) { }

	// RVA: 0x2815D00 Offset: 0x2815E01 VA: 0x2815D00
	public bool Get(ProfileCardThemeOfEditMapData data) { }

	// RVA: 0x2815920 Offset: 0x2815A21 VA: 0x2815920
	private bool Get(int hash) { }

	// RVA: 0x2815D90 Offset: 0x2815E91 VA: 0x2815D90
	public void Set(ProfileCardBgData data, bool value) { }

	// RVA: 0x2815F10 Offset: 0x2816011 VA: 0x2815F10
	public void Set(ProfileCardFrameData data, bool value) { }

	// RVA: 0x2815FD0 Offset: 0x28160D1 VA: 0x2815FD0
	public void Set(ProfileCardTextDecoData data, bool value) { }

	// RVA: 0x2816090 Offset: 0x2816191 VA: 0x2816090
	public void Set(ProfileCardTextColorData data, bool value) { }

	// RVA: 0x2816150 Offset: 0x2816251 VA: 0x2816150
	public void Set(ProfileCardCharacterStampData data, bool value) { }

	// RVA: 0x2816210 Offset: 0x2816311 VA: 0x2816210
	public void Set(ProfileCardStampData data, bool value) { }

	// RVA: 0x28162D0 Offset: 0x28163D1 VA: 0x28162D0
	public void Set(ProfileCardTitleData data, bool value) { }

	// RVA: 0x2811850 Offset: 0x2811951 VA: 0x2811850
	public void Set(ProfileCardFavoriteCharacterData data, bool value) { }

	// RVA: 0x2813920 Offset: 0x2813A21 VA: 0x2813920
	public void Set(ProfileCardFavoriteMapData data, bool value) { }

	// RVA: 0x280DAB0 Offset: 0x280DBB1 VA: 0x280DAB0
	public void Set(ProfileCardCommentData data, bool value) { }

	// RVA: 0x2816390 Offset: 0x2816491 VA: 0x2816390
	public void Set(ProfileCardThemeOfEditMapData data, bool value) { }

	// RVA: 0x2815E50 Offset: 0x2815F51 VA: 0x2815E50
	private void Set(int hash, bool value) { }

	// RVA: 0x2816450 Offset: 0x2816551 VA: 0x2816450 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x28165E0 Offset: 0x28166E1 VA: 0x28165E0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }
}

