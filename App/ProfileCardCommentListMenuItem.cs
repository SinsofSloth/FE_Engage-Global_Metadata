// Namespace: App
public class ProfileCardCommentListMenuItem : BasicMenuItem // TypeDefIndex: 11572
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x298940 Offset: 0x298A41 VA: 0x298940
	private ProfileCardCommentData <m_CommentData>k__BackingField; // 0x68
	private ProfileCardCommentListMenu.SelectEventHandler m_SelectEventHandler; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x298950 Offset: 0x298A51 VA: 0x298950
	private bool <m_Decided>k__BackingField; // 0x78

	// Properties
	public ProfileCardCommentData m_CommentData { get; set; }
	public bool m_Decided { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C5D80 Offset: 0x2C5E81 VA: 0x2C5D80
	// RVA: 0x280DA70 Offset: 0x280DB71 VA: 0x280DA70
	public ProfileCardCommentData get_m_CommentData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5D90 Offset: 0x2C5E91 VA: 0x2C5D90
	// RVA: 0x280DA80 Offset: 0x280DB81 VA: 0x280DA80
	private void set_m_CommentData(ProfileCardCommentData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5DA0 Offset: 0x2C5EA1 VA: 0x2C5DA0
	// RVA: 0x280DA90 Offset: 0x280DB91 VA: 0x280DA90
	public bool get_m_Decided() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5DB0 Offset: 0x2C5EB1 VA: 0x2C5DB0
	// RVA: 0x280DAA0 Offset: 0x280DBA1 VA: 0x280DAA0
	private void set_m_Decided(bool value) { }

	// RVA: 0x280B520 Offset: 0x280B621 VA: 0x280B520
	public void .ctor(ProfileCardCommentData commentData, bool initialSelect, ProfileCardCommentListMenu.SelectEventHandler selectEventHandler) { }

	// RVA: 0x280DB70 Offset: 0x280DC71 VA: 0x280DB70 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x280DB80 Offset: 0x280DC81 VA: 0x280DB80 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x280DBB0 Offset: 0x280DCB1 VA: 0x280DBB0
	public void SetInitialColor() { }

	// RVA: 0x280DD10 Offset: 0x280DE11 VA: 0x280DD10
	public void UpdateFixedCursor() { }

	// RVA: 0x280DE00 Offset: 0x280DF01 VA: 0x280DE00
	public void UpdateNewIcon() { }

	// RVA: 0x280D2E0 Offset: 0x280D3E1 VA: 0x280D2E0
	public void SetDecided(bool decided, bool updateCursorOrder) { }

	// RVA: 0x280E060 Offset: 0x280E161 VA: 0x280E060 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x280E1C0 Offset: 0x280E2C1 VA: 0x280E1C0 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x280E210 Offset: 0x280E311 VA: 0x280E210 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x280E240 Offset: 0x280E341 VA: 0x280E240 Slot: 18
	public override BasicMenu.Result ACall() { }
}

