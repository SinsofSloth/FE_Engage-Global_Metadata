// Namespace: App
public class Language // TypeDefIndex: 13843
{
	// Fields
	private static Language.Langs s_Lang; // 0x0
	private static Language.Voices s_Voice; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x29CBC0 Offset: 0x29CCC1 VA: 0x29CBC0
	private static Action s_LangChanged; // 0x8
	private static CultureInfo s_CultureInfo; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD6A0 Offset: 0x2CD7A1 VA: 0x2CD6A0
	// RVA: 0x1F7CE70 Offset: 0x1F7CF71 VA: 0x1F7CE70
	private static void add_s_LangChanged(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD6B0 Offset: 0x2CD7B1 VA: 0x2CD6B0
	// RVA: 0x1F7CF70 Offset: 0x1F7D071 VA: 0x1F7CF70
	private static void remove_s_LangChanged(Action value) { }

	// RVA: 0x1F7D070 Offset: 0x1F7D171 VA: 0x1F7D070
	public static void Initialize() { }

	// RVA: 0x1F7D6A0 Offset: 0x1F7D7A1 VA: 0x1F7D6A0
	private static void SetLangAndVoiceFirst(Language.Langs lang, Language.Voices voice) { }

	// RVA: 0x1F7D860 Offset: 0x1F7D961 VA: 0x1F7D860
	public static Language.Langs GetLang() { }

	// RVA: 0x1F7D8D0 Offset: 0x1F7D9D1 VA: 0x1F7D8D0
	public static void add_LangChanged(Action value) { }

	// RVA: 0x1F7D940 Offset: 0x1F7DA41 VA: 0x1F7D940
	public static void remove_LangChanged(Action value) { }

	// RVA: 0x1F7D9B0 Offset: 0x1F7DAB1 VA: 0x1F7D9B0
	public static int GetSortKey(Language.Langs lang, TMP_FontAsset font) { }

	// RVA: 0x1F7D7D0 Offset: 0x1F7D8D1 VA: 0x1F7D7D0
	public static void SetLang(Language.Langs lang) { }

	// RVA: 0x1F7DE90 Offset: 0x1F7DF91 VA: 0x1F7DE90
	public static Language.Voices GetVoice() { }

	// RVA: 0x1F7DF00 Offset: 0x1F7E001 VA: 0x1F7DF00
	public static void SetVoice(Language.Voices voice) { }

	// RVA: 0x1F7DF70 Offset: 0x1F7E071 VA: 0x1F7DF70
	public static void ReflectSetting() { }

	// RVA: 0x1F7E160 Offset: 0x1F7E261 VA: 0x1F7E160
	public static void SaveSetting(ProcInst parent) { }

	// RVA: 0x1F7E180 Offset: 0x1F7E281 VA: 0x1F7E180
	public static string GetLangName(Language.Langs lang) { }

	// RVA: 0x1F7E2D0 Offset: 0x1F7E3D1 VA: 0x1F7E2D0
	public static string GetVoiceName(Language.Voices voice) { }

	// RVA: 0x1F7E3A0 Offset: 0x1F7E4A1 VA: 0x1F7E3A0
	public static bool IsTalkLayout2Lines(Language.Langs lang) { }

	// RVA: 0x1F7E3B0 Offset: 0x1F7E4B1 VA: 0x1F7E3B0
	public static string GetLangDesired() { }

	// RVA: 0x1F7DC80 Offset: 0x1F7DD81 VA: 0x1F7DC80
	private static CultureInfo GetCultureInfo(Language.Langs lang) { }

	// RVA: 0x1F7E4F0 Offset: 0x1F7E5F1 VA: 0x1F7E4F0
	public static CultureInfo GetCultureInfo() { }

	// RVA: 0x1F7E560 Offset: 0x1F7E661 VA: 0x1F7E560
	public void .ctor() { }

	// RVA: 0x1F7E570 Offset: 0x1F7E671 VA: 0x1F7E570
	private static void .cctor() { }
}

