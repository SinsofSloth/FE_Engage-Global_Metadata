// Namespace: 
private class RelayProfileSequence.DownloadSequence : ProcInst // TypeDefIndex: 12951
{
	// Fields
	private ulong m_PrincipalId; // 0x70
	private List<ulong> m_PlayerIds; // 0x78
	private int m_PlayerIdIndex; // 0x80
	private List<ProfileCard> m_Profiles; // 0x88

	// Methods

	// RVA: 0x1F3F830 Offset: 0x1F3F931 VA: 0x1F3F830
	private void .ctor(ulong principalId, List<ulong> playerIds) { }

	// RVA: 0x1F3F8F0 Offset: 0x1F3F9F1 VA: 0x1F3F8F0
	private void Download() { }

	// RVA: 0x1F3FA80 Offset: 0x1F3FB81 VA: 0x1F3FA80
	private void Postdownload() { }

	// RVA: 0x1F3FC30 Offset: 0x1F3FD31 VA: 0x1F3FC30
	private void NextPlayer() { }

	// RVA: 0x1F3FC40 Offset: 0x1F3FD41 VA: 0x1F3FC40
	private void Sanitize() { }

	// RVA: 0x1F3FE10 Offset: 0x1F3FF11 VA: 0x1F3FE10
	private void ConfirmSave() { }

	// RVA: 0x1F3FF60 Offset: 0x1F40061 VA: 0x1F3FF60
	private void Save() { }

	// RVA: 0x1F40150 Offset: 0x1F40251 VA: 0x1F40150
	public static void CreateBind(ProcInst super, ulong principalId, List<ulong> playerIds) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA380 Offset: 0x2CA481 VA: 0x2CA380
	// RVA: 0x1F40770 Offset: 0x1F40871 VA: 0x1F40770
	private void <ConfirmSave>b__10_0() { }
}

