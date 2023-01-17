// Namespace: App.Talk3D
public class TalkTagParser // TypeDefIndex: 14163
{
	// Fields
	public const char ShiftIn = '\xe';
	public const char ShiftOut = '\xf';
	private Dictionary<Mess.TagGroup, TalkTag> m_TagDictionary; // 0x10
	private TalkTagFinish m_TagFinish; // 0x18
	private TalkTagAddLetter m_TagAddLetter; // 0x20

	// Methods

	// RVA: 0x2C28640 Offset: 0x2C28741 VA: 0x2C28640
	public void .ctor() { }

	// RVA: 0x2C28A60 Offset: 0x2C28B61 VA: 0x2C28A60
	public TalkTag Parse(TalkPtr talkPtr) { }

	// RVA: 0x2C332D0 Offset: 0x2C333D1 VA: 0x2C332D0
	public TalkTag GetAddLetterTagForReplace(char chr) { }

	// RVA: 0x2C31730 Offset: 0x2C31831 VA: 0x2C31730
	public void ResetLineFeedEnable() { }

	// RVA: 0x2C38360 Offset: 0x2C38461 VA: 0x2C38360
	public static string GetHeadText(string mid, int num) { }

	// RVA: 0x2C38870 Offset: 0x2C38971 VA: 0x2C38870
	private static bool AddCharToHeadText(char chr, ref string head, ref int num, ref bool strToLowerTrigger, ref bool isLatestStrPatchim1, ref bool isLatestStrPatchim2) { }
}

