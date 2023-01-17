// Namespace: App
public class Mess // TypeDefIndex: 13858
{
	// Fields
	public const int CharSize = 2;
	public const char ShiftIn = '\xe';
	public const char ShiftOut = '\xf';
	public const string NotFoundText = "";
	public static string FileName_HubCommon; // 0x0
	public static string FileNameHeader_Reliance; // 0x8
	public static string FileNameHeader_GodReliance; // 0x10
	public static string FileNameHeader_MainScenario; // 0x18
	public static string FileNameHeader_SideScenario; // 0x20
	public static string FileNameHeader_GodScenario; // 0x28
	public static string FileNameHeader_EvilScenario; // 0x30
	public static string LabelHeader_Reliance; // 0x38
	public static string LabelHeader_GodReliance; // 0x40
	public static string LabelHeader_Die; // 0x48
	public static string LabelHeader_Hub; // 0x50
	public static string ReplaceStr_DefaultHeroName; // 0x58
	public static string ReplaceStr_DefaultMorphName; // 0x60
	public static string ReplaceStr_DefaultMascotName; // 0x68
	public static string ReplaceStr_CNThirdTagMale; // 0x70
	public static string ReplaceStr_CNThirdTagFemale; // 0x78
	public static string ReplaceStr_TWThirdTagMale; // 0x80
	public static string ReplaceStr_TWThirdTagFemale; // 0x88
	private static Dictionary<string, MsgFile> s_messFileDictionary; // 0x90
	private static Dictionary<string, MsgFile> s_soundCmdFileDictionary; // 0x98
	private static Dictionary<string, MsgFile> s_eventCmdFileDictionary; // 0xA0
	private static Dictionary<string, IntPtr> s_messDataDictionary; // 0xA8
	private static Dictionary<string, IntPtr> s_soundCmdDataDictionary; // 0xB0
	private static Dictionary<string, IntPtr> s_eventCmdDataDictionary; // 0xB8
	private static Dictionary<string, string> s_pathDictionary; // 0xC0
	private static Stack<Dictionary<string, int>> s_checkStack; // 0xC8
	private static string s_mess; // 0xD0
	private static bool s_isBody; // 0xD8
	private static bool s_isStrToLower; // 0xD9
	private static bool s_isNesting; // 0xDA
	private const int ArgMax = 8;
	private const int ArgStack = 8;
	private static string[] s_argArray; // 0xE0
	private static Stack<string[]> s_argStack; // 0xE8
	private static string s_partnerPid; // 0xF0
	private static Dictionary<string, ResourceHandle> s_spriteAssetHandleDictionary; // 0xF8

	// Properties
	public static Mess.ArgScope NewArgScope { get; }

	// Methods

	// RVA: 0x2866A70 Offset: 0x2866B71 VA: 0x2866A70
	public static void Initialize() { }

	// RVA: 0x2868240 Offset: 0x2868341 VA: 0x2868240
	private static void UpdateReplaceStr() { }

	// RVA: 0x2868670 Offset: 0x2868771 VA: 0x2868670
	public static void LoadSpriteAsset() { }

	// RVA: 0x2868750 Offset: 0x2868851 VA: 0x2868750
	private static void LoadSpriteAsset(string spriteAssetName) { }

	// RVA: 0x28688C0 Offset: 0x28689C1 VA: 0x28688C0
	private static bool IsSpriteExistInSpriteAsset(string spriteAssetName, string spriteName) { }

	// RVA: 0x2868A30 Offset: 0x2868B31 VA: 0x2868A30
	private static string GetItemSpriteAssetsName(ItemData item) { }

	// RVA: 0x2868AD0 Offset: 0x2868BD1 VA: 0x2868AD0
	private static string GetSkillSpriteAssetsName(SkillData skill) { }

	// RVA: 0x2868B70 Offset: 0x2868C71 VA: 0x2868B70
	private static string GetSystemSpriteAssetsName(string iconName) { }

	// RVA: 0x2868C00 Offset: 0x2868D01 VA: 0x2868C00
	private static string GetGodSymbolEngraveSpriteAssetsName(string iconName) { }

	// RVA: 0x2868C90 Offset: 0x2868D91 VA: 0x2868C90
	private static TMP_SpriteAsset OnSpriteAssetRequestCallback(int arg, string spriteAssetName) { }

	[ConditionalAttribute] // RVA: 0x2CD6C0 Offset: 0x2CD7C1 VA: 0x2CD6C0
	// RVA: 0x2868DB0 Offset: 0x2868EB1 VA: 0x2868DB0
	public static void PushCheck() { }

	[ConditionalAttribute] // RVA: 0x2CD700 Offset: 0x2CD801 VA: 0x2CD700
	// RVA: 0x2868FB0 Offset: 0x28690B1 VA: 0x2868FB0
	public static void PopCheck() { }

	// RVA: 0x2868160 Offset: 0x2868261 VA: 0x2868160
	public static bool Load(string fileName) { }

	// RVA: 0x28681D0 Offset: 0x28682D1 VA: 0x28681D0
	public static bool TryLoad(string fileName) { }

	// RVA: 0x2869160 Offset: 0x2869261 VA: 0x2869160
	private static bool LoadImpl(string fileName, bool isWarning) { }

	// RVA: 0x2869510 Offset: 0x2869611 VA: 0x2869510
	private static bool LoadImpl(string filePath, ref Dictionary<string, MsgFile> fileDictionary, ref Dictionary<string, IntPtr> dataDictionary, bool isWarning) { }

	// RVA: 0x28699F0 Offset: 0x2869AF1 VA: 0x28699F0
	public static bool Free(string fileName) { }

	// RVA: 0x2869B40 Offset: 0x2869C41 VA: 0x2869B40
	public static bool TryFree(string fileName) { }

	// RVA: 0x2869A60 Offset: 0x2869B61 VA: 0x2869A60
	private static bool FreeImpl(string fileName, bool isWarning) { }

	// RVA: 0x2869DB0 Offset: 0x2869EB1 VA: 0x2869DB0
	private static int GetReference(string fileName) { }

	// RVA: 0x2869BB0 Offset: 0x2869CB1 VA: 0x2869BB0
	private static bool FreeImpl(string fileName, ref Dictionary<string, MsgFile> fileDictionary, ref Dictionary<string, IntPtr> dataDictionary, bool isWarning) { }

	// RVA: 0x2869E70 Offset: 0x2869F71 VA: 0x2869E70
	private static void Reload() { }

	// RVA: 0x286A460 Offset: 0x286A561 VA: 0x286A460
	public static bool IsLoadDone(string fileName) { }

	// RVA: 0x286A4F0 Offset: 0x286A5F1 VA: 0x286A4F0
	public static bool IsFileExist(string fileName) { }

	// RVA: 0x286A5A0 Offset: 0x286A6A1 VA: 0x286A5A0
	public static bool IsHeroFemale() { }

	// RVA: 0x286A730 Offset: 0x286A831 VA: 0x286A730
	public static string GetLanguageDirectoryName() { }

	// RVA: 0x28692E0 Offset: 0x28693E1 VA: 0x28692E0
	public static string CreateMessFilePath(string fileName) { }

	// RVA: 0x2869910 Offset: 0x2869A11 VA: 0x2869910
	public static string CreateSoundCmdFilePath(string fileName) { }

	// RVA: 0x2869980 Offset: 0x2869A81 VA: 0x2869980
	public static string CreateEventCmdFilePath(string fileName) { }

	// RVA: 0x286A8C0 Offset: 0x286A9C1 VA: 0x286A8C0
	public static string GetFilePath(string label) { }

	// RVA: 0x286A9E0 Offset: 0x286AAE1 VA: 0x286A9E0
	public static MsgFile GetMsgFile(string fileName) { }

	// RVA: 0x286AA80 Offset: 0x286AB81 VA: 0x286AA80
	public static bool IsMainReleaseScenarioMessFile(string fileName) { }

	// RVA: 0x286AB60 Offset: 0x286AC61 VA: 0x286AB60
	public static bool IsDLCScenarioMessFile(string fileName) { }

	// RVA: 0x286AC40 Offset: 0x286AD41 VA: 0x286AC40
	public static bool IsRelianceMessFile(string fileName) { }

	// RVA: 0x286ACD0 Offset: 0x286ADD1 VA: 0x286ACD0
	public static bool IsGodRelianceMessFile(string fileName) { }

	[ConditionalAttribute] // RVA: 0x2CD740 Offset: 0x2CD841 VA: 0x2CD740
	// RVA: 0x286AD60 Offset: 0x286AE61 VA: 0x286AD60
	public static void DumpFile() { }

	[ConditionalAttribute] // RVA: 0x2CD780 Offset: 0x2CD881 VA: 0x2CD780
	// RVA: 0x286AE90 Offset: 0x286AF91 VA: 0x286AE90
	public static void DumpLabel() { }

	// RVA: 0x286B170 Offset: 0x286B271 VA: 0x286B170
	public static List<string> GetAllLabel() { }

	// RVA: 0x284CC80 Offset: 0x284CD81 VA: 0x284CC80
	public static string Get(string label) { }

	// RVA: 0x2868580 Offset: 0x2868681 VA: 0x2868580
	public static string Get(string label, string arg0) { }

	// RVA: 0x286B510 Offset: 0x286B611 VA: 0x286B510
	public static string Get(string label, string arg0, string arg1) { }

	// RVA: 0x286B670 Offset: 0x286B771 VA: 0x286B670
	public static string Get(string label, string arg0, string arg1, string arg2) { }

	// RVA: 0x286B840 Offset: 0x286B941 VA: 0x286B840
	public static string Get(string label, string[] args) { }

	// RVA: 0x286B9F0 Offset: 0x286BAF1 VA: 0x286B9F0
	public static string TryGetReplace(string label) { }

	// RVA: 0x286BC00 Offset: 0x286BD01 VA: 0x286BC00
	public static IntPtr GetIntPtr(string label) { }

	// RVA: 0x286B330 Offset: 0x286B431 VA: 0x286B330
	private static string GetImpl(string label, bool isReplace) { }

	// RVA: 0x286C1D0 Offset: 0x286C2D1 VA: 0x286C1D0
	public static string GetSoundCmdText(string label) { }

	// RVA: 0x286C320 Offset: 0x286C421 VA: 0x286C320
	public static bool GetSoundCmdText(string label, ref string soundCmdExecBefore, ref string soundCmdExecAfter) { }

	// RVA: 0x286C490 Offset: 0x286C591 VA: 0x286C490
	public static string GetEventCmdText(string label) { }

	// RVA: 0x286C510 Offset: 0x286C611 VA: 0x286C510
	public static bool GetEventCmdText(string label, ref string eventCmdExecBefore, ref string eventCmdExecAfter) { }

	// RVA: 0x286C250 Offset: 0x286C351 VA: 0x286C250
	private static string GetCmdImpl(string label, Dictionary<string, IntPtr> dataDictionary) { }

	// RVA: 0x286C3B0 Offset: 0x286C4B1 VA: 0x286C3B0
	private static bool GetCmdImpl(string label, Dictionary<string, IntPtr> dataDictionary, ref string cmdExecBefore, ref string cmdExecAfter) { }

	// RVA: 0x286C790 Offset: 0x286C891 VA: 0x286C790
	public static bool IsExist(string label) { }

	// RVA: 0x286C820 Offset: 0x286C921 VA: 0x286C820
	public static bool IsNesting() { }

	// RVA: 0x286BCB0 Offset: 0x286BDB1 VA: 0x286BCB0
	private static string GetString(string label, IntPtr pMessData, bool isReplace) { }

	// RVA: 0x286C890 Offset: 0x286C991 VA: 0x286C890
	private static char ReadChar(IntPtr p, int offset) { }

	// RVA: 0x286CD70 Offset: 0x286CE71 VA: 0x286CD70
	public static float CalcTalkStringTotalWidth(string messStr) { }

	// RVA: 0x286CE80 Offset: 0x286CF81 VA: 0x286CE80
	public static float CalcWaitMsecForTalkAutoPlay(string messStr) { }

	// RVA: 0x286C5A0 Offset: 0x286C6A1 VA: 0x286C5A0
	public static bool SplitCmd(string cmd, ref string cmdExecBefore, ref string cmdExecAfter) { }

	// RVA: 0x286C960 Offset: 0x286CA61 VA: 0x286C960
	private static void AddTagString(ushort tagGroupId, ushort tagId, byte[] param) { }

	// RVA: 0x286CF00 Offset: 0x286D001 VA: 0x286CF00
	private static void ReplaceArgString(Mess.TagID_Arg tagId) { }

	// RVA: 0x286D2B0 Offset: 0x286D3B1 VA: 0x286D2B0
	private static void AddTagString_Localize(ushort tagId, byte[] param) { }

	// RVA: 0x286D820 Offset: 0x286D921 VA: 0x286D820
	public static bool IsPatchim1(char c) { }

	// RVA: 0x286D960 Offset: 0x286DA61 VA: 0x286D960
	public static bool IsPatchim2(char c) { }

	// RVA: 0x286DAA0 Offset: 0x286DBA1 VA: 0x286DAA0
	private static bool IsPatchimStrCode(int chrCode, bool isWithout2) { }

	// RVA: 0x286DB50 Offset: 0x286DC51 VA: 0x286DB50
	public static void SetArgument(int index, int value) { }

	// RVA: 0x286B430 Offset: 0x286B531 VA: 0x286B430
	public static void SetArgument(int index, string value) { }

	// RVA: 0x2867D10 Offset: 0x2867E11 VA: 0x2867D10
	public static void ClearArgument() { }

	// RVA: 0x286DBE0 Offset: 0x286DCE1 VA: 0x286DBE0
	public static string GetArgument(int index) { }

	// RVA: 0x286DC70 Offset: 0x286DD71 VA: 0x286DC70
	public static Mess.ArgScope get_NewArgScope() { }

	// RVA: 0x286D220 Offset: 0x286D321 VA: 0x286D220
	public static string CreateSpaceTag(uint pixel) { }

	// RVA: 0x286D010 Offset: 0x286D111 VA: 0x286D010
	public static string CreateSpriteTag(Mess.IconCategory iconCategory, string kindName) { }

	// RVA: 0x286E1F0 Offset: 0x286E2F1 VA: 0x286E1F0
	private static string CreateSpriteTag(string spriteAssetName, string iconName) { }

	// RVA: 0x286DCA0 Offset: 0x286DDA1 VA: 0x286DCA0
	public static string CreateItemSpriteTag(ItemData item, bool forSystem = True) { }

	// RVA: 0x286DF20 Offset: 0x286E021 VA: 0x286DF20
	public static string CreateSkillSpriteTag(SkillData skill) { }

	// RVA: 0x286E030 Offset: 0x286E131 VA: 0x286E030
	public static string CreateSystemSpriteTag(string iconName) { }

	// RVA: 0x286E110 Offset: 0x286E211 VA: 0x286E110
	public static string CreateGodSymbleEngraveSpriteTag(string iconName) { }

	// RVA: 0x286E460 Offset: 0x286E561 VA: 0x286E460
	public static void SetPartnerPID(string pid) { }

	// RVA: 0x286E4E0 Offset: 0x286E5E1 VA: 0x286E4E0
	public static string GetPartnerPID() { }

	// RVA: 0x286E550 Offset: 0x286E651 VA: 0x286E550
	public static string GetPartnerName() { }

	// RVA: 0x286E790 Offset: 0x286E891 VA: 0x286E790
	public static string GetGameDataName(string value) { }

	// RVA: 0x286E9F0 Offset: 0x286EAF1 VA: 0x286E9F0
	public void .ctor() { }

	// RVA: 0x286EA00 Offset: 0x286EB01 VA: 0x286EA00
	private static void .cctor() { }
}

