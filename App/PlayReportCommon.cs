// Namespace: App
public class PlayReportCommon : PlayReportSendBase // TypeDefIndex: 13786
{
	// Fields
	private const int s_ReportVersion = 6;

	// Methods

	// RVA: 0x29D22C0 Offset: 0x29D23C1 VA: 0x29D22C0 Slot: 4
	protected override long GetBufferSizeImpl() { }

	// RVA: 0x29D22D0 Offset: 0x29D23D1 VA: 0x29D22D0
	public void ReportChapterClear() { }

	// RVA: 0x29D2720 Offset: 0x29D2821 VA: 0x29D2720
	public void ReportSortie() { }

	// RVA: 0x29D2330 Offset: 0x29D2431 VA: 0x29D2330
	private void SendCommon(string sendType, bool isSendHubs) { }

	// RVA: 0x29D2BC0 Offset: 0x29D2CC1 VA: 0x29D2BC0
	private void ReportBasic() { }

	// RVA: 0x29D60C0 Offset: 0x29D61C1 VA: 0x29D60C0
	private int GetProgress() { }

	// RVA: 0x29D6240 Offset: 0x29D6341 VA: 0x29D6240
	private string GetChapterType() { }

	// RVA: 0x29D3CC0 Offset: 0x29D3DC1 VA: 0x29D3CC0
	private void ReportForce() { }

	// RVA: 0x29D3420 Offset: 0x29D3521 VA: 0x29D3420
	private void ReportConfig() { }

	// RVA: 0x29D4000 Offset: 0x29D4101 VA: 0x29D4000
	private void ReportUnit() { }

	// RVA: 0x29D6730 Offset: 0x29D6831 VA: 0x29D6730
	private uint GetForceMask() { }

	// RVA: 0x29D67B0 Offset: 0x29D68B1 VA: 0x29D67B0
	private void ReportUnitImpl(Unit unit, int useReportNo, int inReportCount) { }

	// RVA: 0x29D6740 Offset: 0x29D6841 VA: 0x29D6740
	private bool IsPlayerUnit(Unit unit) { }

	// RVA: 0x29D8630 Offset: 0x29D8731 VA: 0x29D8630
	private bool IsPlayerGodPool(GodUnit godUnit) { }

	// RVA: 0x29D82B0 Offset: 0x29D83B1 VA: 0x29D82B0
	private int GodPoolLevel(Unit unit, string godName) { }

	// RVA: 0x29D43C0 Offset: 0x29D44C1 VA: 0x29D43C0
	private void ReportReliance() { }

	// RVA: 0x29D49F0 Offset: 0x29D4AF1 VA: 0x29D49F0
	private void ReportHub() { }

	// RVA: 0x29D5DC0 Offset: 0x29D5EC1 VA: 0x29D5DC0
	private void ReportOther() { }

	// RVA: 0x29D8670 Offset: 0x29D8771 VA: 0x29D8670
	public void .ctor() { }
}

