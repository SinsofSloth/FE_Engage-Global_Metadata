// Namespace: 
private class RelayProfileSequence.UploadSequence : ProcInst // TypeDefIndex: 12946
{
	// Fields
	private ProfileCard m_Profile; // 0x70

	// Methods

	// RVA: 0x1F407E0 Offset: 0x1F408E1 VA: 0x1F407E0
	private void .ctor() { }

	// RVA: 0x1F40880 Offset: 0x1F40981 VA: 0x1F40880
	private void Sanitize() { }

	// RVA: 0x1F40920 Offset: 0x1F40A21 VA: 0x1F40920
	private void Upload() { }

	// RVA: 0x1F409B0 Offset: 0x1F40AB1 VA: 0x1F409B0
	public static void CreateBind(ProcInst super) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA370 Offset: 0x2CA471 VA: 0x2CA370
	// RVA: 0x1F40BD0 Offset: 0x1F40CD1 VA: 0x1F40BD0
	private void <Sanitize>b__2_0(bool isOk) { }
}

// Namespace: 
private enum RelayProfileSequence.DownloadSequence.Label // TypeDefIndex: 12947
{
	// Fields
	public int value__; // 0x0
	public const RelayProfileSequence.DownloadSequence.Label Download = 0;
	public const RelayProfileSequence.DownloadSequence.Label Sanitize = 1;
	public const RelayProfileSequence.DownloadSequence.Label Save = 2;
	public const RelayProfileSequence.DownloadSequence.Label End = 3;
}

// Namespace: 
private class RelayProfileSequence.DownloadSequence.DownloadYesNoDialog.YesItem : BasicDialogItemYes // TypeDefIndex: 12948
{
	// Fields
	private Action m_DecideCallback; // 0x70

	// Methods

	// RVA: 0x2D7DB50 Offset: 0x2D7DC51 VA: 0x2D7DB50
	public void .ctor(Action decideCallback) { }

	// RVA: 0x2D7DB90 Offset: 0x2D7DC91 VA: 0x2D7DB90 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class RelayProfileSequence.DownloadSequence.DownloadYesNoDialog // TypeDefIndex: 12949
{
	// Methods

	// RVA: 0x21F4BE0 Offset: 0x21F4CE1 VA: 0x21F4BE0
	public static void CreateBind(ProcInst super, string mess, Action decideCallback) { }

	// RVA: 0x21F4C70 Offset: 0x21F4D71 VA: 0x21F4C70
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2788A0 Offset: 0x2789A1 VA: 0x2788A0
private sealed class RelayProfileSequence.DownloadSequence.<>c__DisplayClass9_0 // TypeDefIndex: 12950
{
	// Fields
	public RelayProfileSequence.DownloadSequence <>4__this; // 0x10
	public int count; // 0x18

	// Methods

	// RVA: 0x21F4B00 Offset: 0x21F4C01 VA: 0x21F4B00
	public void .ctor() { }

	// RVA: 0x21F4B10 Offset: 0x21F4C11 VA: 0x21F4B10
	internal void <Sanitize>b__0(bool[] isOk) { }
}

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

