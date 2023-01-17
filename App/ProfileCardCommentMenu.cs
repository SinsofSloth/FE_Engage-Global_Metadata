// Namespace: App
public class ProfileCardCommentMenu : ProcInst // TypeDefIndex: 11576
{
	// Fields
	private ProfileCardCommentMenu.DisposeEventHandler m_DisposeEventHandler; // 0x70
	private ProfileCardMessageSelectMenuContent m_MessageSelectMenuContent; // 0x78
	private ProfileCardMessageListMenuContent m_MessageListMenuContent; // 0x80
	private ProfileCardRoot m_ProfileCardRoot; // 0x88
	private ProfileCardCommentIndexMenu m_ProfileCardCommentIndexMenu; // 0x90
	private ProfileCardCommentListMenu m_ProfileCardCommentListMenu; // 0x98
	private ProfileCard m_MyProfileCardTemp; // 0xA0
	private ProfileCardCommentData[] m_CommentTempArray; // 0xA8
	private StringBuilder m_StringBuilder; // 0xB0
	private int m_DecidedMessageIndex; // 0xB8

	// Methods

	// RVA: 0x280E2F0 Offset: 0x280E3F1 VA: 0x280E2F0
	public static ProfileCardCommentMenu CreateBind(ProcInst super, ProfileCardMessageSelectMenuContent messageSelectMenuContent, ProfileCardMessageListMenuContent messageListMenuContent, ProfileCardRoot profileCardRoot, ProfileCard myProfileCardTemp, int initialIndex, ProfileCardCommentMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x280E3B0 Offset: 0x280E4B1 VA: 0x280E3B0
	private void .ctor(ProcInst super, ProfileCardMessageSelectMenuContent messageSelectMenuContent, ProfileCardMessageListMenuContent messageListMenuContent, ProfileCardRoot profileCardRoot, ProfileCard profileCard, int initialIndex, ProfileCardCommentMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x280E6E0 Offset: 0x280E7E1 VA: 0x280E6E0
	private void OnDisposeChildren() { }
}

