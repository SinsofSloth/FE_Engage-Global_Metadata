// Namespace: App
public class ProfileCardFontSetter : MonoBehaviour // TypeDefIndex: 11593
{
	// Fields
	public TextMeshProUGUI m_Text; // 0x18
	public TMP_FontAsset m_TalkSDF; // 0x20
	public Material m_TalkOutlineMaterial; // 0x28
	public TMP_FontAsset m_TalkProfileUserNameSDF; // 0x30
	public Material m_TalkProfileOutlineMaterial; // 0x38
	public TMP_FontAsset m_SystemProfileCommentSDF; // 0x40
	public Material m_SystemOutlineMaterial; // 0x48
	public Material m_SystemCNOutlineMaterial; // 0x50
	private ProfileCardFontSetter.FontType m_FontType; // 0x58

	// Methods

	// RVA: 0x2816890 Offset: 0x2816991 VA: 0x2816890
	public void SetFontType(ProfileCardFontSetter.FontType fontType) { }

	// RVA: 0x2816920 Offset: 0x2816A21 VA: 0x2816920
	public void SetLanguage(Language.Langs lang) { }

	// RVA: 0x2816990 Offset: 0x2816A91 VA: 0x2816990
	private void SortFontFallbackPriority(Language.Langs lang) { }

	// RVA: 0x2816A90 Offset: 0x2816B91 VA: 0x2816A90
	public void .ctor() { }
}

