// Namespace: App
public class TutorialData : StructDataArray<TutorialData> // TypeDefIndex: 10110
{
	// Fields
	private const int FirstIndex = 0;
	[CompilerGeneratedAttribute] // RVA: 0x28D950 Offset: 0x28DA51 VA: 0x28D950
	private string <MID>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28D960 Offset: 0x28DA61 VA: 0x28D960
	private string <Title>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28D970 Offset: 0x28DA71 VA: 0x28D970
	private string <SpriteAtlas>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28D980 Offset: 0x28DA81 VA: 0x28D980
	private TutorialData.Types <Type>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28D990 Offset: 0x28DA91 VA: 0x28D990
	private TutorialData.Notices <Notice>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x28D9A0 Offset: 0x28DAA1 VA: 0x28D9A0
	private string <Cid>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28D9B0 Offset: 0x28DAB1 VA: 0x28D9B0
	private int <No>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28D9C0 Offset: 0x28DAC1 VA: 0x28D9C0
	private TutorialData.SSTypes <SSType>k__BackingField; // 0x54

	// Properties
	public string MID { get; set; }
	public string Title { get; set; }
	public string SpriteAtlas { get; set; }
	public TutorialData.Types Type { get; set; }
	public TutorialData.Notices Notice { get; set; }
	public string Cid { get; set; }
	public int No { get; set; }
	public TutorialData.SSTypes SSType { get; set; }

	// Methods

	// RVA: 0x287D150 Offset: 0x287D251 VA: 0x287D150
	public static void Load() { }

	// RVA: 0x287D200 Offset: 0x287D301 VA: 0x287D200
	public static List<TutorialData> TryGetFromTutid(string tutid) { }

	// RVA: 0x287D280 Offset: 0x287D381 VA: 0x287D280
	public static void LockPickUpTutorial() { }

	// RVA: 0x287DA70 Offset: 0x287DB71 VA: 0x287DA70
	public static void SetListFlag(TutorialData.Flags flag) { }

	// RVA: 0x287D450 Offset: 0x287D551 VA: 0x287D450
	public static StructArrayList<TutorialData> GetListFromType(TutorialData.Types type, bool isGetAllTutorial = False) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD150 Offset: 0x2BD251 VA: 0x2BD150
	// RVA: 0x287DD50 Offset: 0x287DE51 VA: 0x287DD50
	public string get_MID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD160 Offset: 0x2BD261 VA: 0x2BD160
	// RVA: 0x287DD60 Offset: 0x287DE61 VA: 0x287DD60
	private void set_MID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD170 Offset: 0x2BD271 VA: 0x2BD170
	// RVA: 0x287DD70 Offset: 0x287DE71 VA: 0x287DD70
	public string get_Title() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD180 Offset: 0x2BD281 VA: 0x2BD180
	// RVA: 0x287DD80 Offset: 0x287DE81 VA: 0x287DD80
	private void set_Title(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD190 Offset: 0x2BD291 VA: 0x2BD190
	// RVA: 0x287DD90 Offset: 0x287DE91 VA: 0x287DD90
	public string get_SpriteAtlas() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD1A0 Offset: 0x2BD2A1 VA: 0x2BD1A0
	// RVA: 0x287DDA0 Offset: 0x287DEA1 VA: 0x287DDA0
	private void set_SpriteAtlas(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD1B0 Offset: 0x2BD2B1 VA: 0x2BD1B0
	// RVA: 0x287DDB0 Offset: 0x287DEB1 VA: 0x287DDB0
	public TutorialData.Types get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD1C0 Offset: 0x2BD2C1 VA: 0x2BD1C0
	// RVA: 0x287DDC0 Offset: 0x287DEC1 VA: 0x287DDC0
	private void set_Type(TutorialData.Types value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD1D0 Offset: 0x2BD2D1 VA: 0x2BD1D0
	// RVA: 0x287DDD0 Offset: 0x287DED1 VA: 0x287DDD0
	public TutorialData.Notices get_Notice() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD1E0 Offset: 0x2BD2E1 VA: 0x2BD1E0
	// RVA: 0x287DDE0 Offset: 0x287DEE1 VA: 0x287DDE0
	private void set_Notice(TutorialData.Notices value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD1F0 Offset: 0x2BD2F1 VA: 0x2BD1F0
	// RVA: 0x287DDF0 Offset: 0x287DEF1 VA: 0x287DDF0
	public string get_Cid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD200 Offset: 0x2BD301 VA: 0x2BD200
	// RVA: 0x287DE00 Offset: 0x287DF01 VA: 0x287DE00
	private void set_Cid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD210 Offset: 0x2BD311 VA: 0x2BD210
	// RVA: 0x287DE10 Offset: 0x287DF11 VA: 0x287DE10
	public int get_No() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD220 Offset: 0x2BD321 VA: 0x2BD220
	// RVA: 0x287DE20 Offset: 0x287DF21 VA: 0x287DE20
	private void set_No(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD230 Offset: 0x2BD331 VA: 0x2BD230
	// RVA: 0x287DE30 Offset: 0x287DF31 VA: 0x287DE30
	public TutorialData.SSTypes get_SSType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD240 Offset: 0x2BD341 VA: 0x2BD240
	// RVA: 0x287DE40 Offset: 0x287DF41 VA: 0x287DE40
	private void set_SSType(TutorialData.SSTypes value) { }

	// RVA: 0x287DE50 Offset: 0x287DF51 VA: 0x287DE50
	private static string GetGlobalFlagsName(string tutid) { }

	// RVA: 0x287D820 Offset: 0x287D921 VA: 0x287D820
	public static void SetGlobalFlags(string tutid, TutorialData.Flags flag) { }

	// RVA: 0x287DEB0 Offset: 0x287DFB1 VA: 0x287DEB0
	public static TutorialData.Flags GetGlobalFlags(string tutid) { }

	// RVA: 0x287DB70 Offset: 0x287DC71 VA: 0x287DB70
	public static bool IsGlobalFlags(string tutid, TutorialData.Flags flag) { }

	// RVA: 0x287E040 Offset: 0x287E141 VA: 0x287E040
	public static bool IsLock(string tutid) { }

	// RVA: 0x287E050 Offset: 0x287E151 VA: 0x287E050
	public static void RegistGlobalFlags() { }

	// RVA: 0x287E200 Offset: 0x287E301 VA: 0x287E200
	public static void CompletedChapter(ChapterData chapter) { }

	// RVA: 0x287E360 Offset: 0x287E461 VA: 0x287E360
	public void .ctor() { }
}

