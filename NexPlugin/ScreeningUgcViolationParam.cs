// Namespace: NexPlugin
public class ScreeningUgcViolationParam // TypeDefIndex: 15005
{
	// Fields
	internal Screening.ReportCategory category; // 0x10
	internal string reason; // 0x18
	internal List<ScreeningContextInfo> context; // 0x20
	internal ulong screenshotDataId; // 0x28

	// Methods

	// RVA: 0x2064310 Offset: 0x2064411 VA: 0x2064310
	public void .ctor() { }

	// RVA: 0x2064490 Offset: 0x2064591 VA: 0x2064490
	public void SetCategory(Screening.ReportCategory category_) { }

	// RVA: 0x20644A0 Offset: 0x20645A1 VA: 0x20644A0
	public Screening.ReportCategory GetCategory() { }

	// RVA: 0x20644B0 Offset: 0x20645B1 VA: 0x20644B0
	public void SetReason(string reason_) { }

	// RVA: 0x20644C0 Offset: 0x20645C1 VA: 0x20644C0
	public string GetReason() { }

	// RVA: 0x20644D0 Offset: 0x20645D1 VA: 0x20644D0
	public void SetContextInfo(string key, string value) { }

	// RVA: 0x2064740 Offset: 0x2064841 VA: 0x2064740
	public string GetContextInfo(string key) { }

	// RVA: 0x2064850 Offset: 0x2064951 VA: 0x2064850
	public void SetScreenshotDataId(ulong screenshotDataId_) { }

	// RVA: 0x2064860 Offset: 0x2064961 VA: 0x2064860
	public ulong GetScreenshotDataId() { }

	// RVA: 0x2064400 Offset: 0x2064501 VA: 0x2064400
	public void Reset() { }

	// RVA: 0x2064870 Offset: 0x2064971 VA: 0x2064870
	public void Trace() { }

	// RVA: 0x2064880 Offset: 0x2064981 VA: 0x2064880 Slot: 3
	public override string ToString() { }
}

