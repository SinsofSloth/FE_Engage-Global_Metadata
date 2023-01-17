// Namespace: 
public class VersusSendReportSequence.UploadInfo // TypeDefIndex: 13732
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C960 Offset: 0x29CA61 VA: 0x29C960
	private ulong <DataId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29C970 Offset: 0x29CA71 VA: 0x29C970
	private ulong <ScreenShotId>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29C980 Offset: 0x29CA81 VA: 0x29C980
	private Screening.ReportCategory <Category>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29C990 Offset: 0x29CA91 VA: 0x29C990
	private string <Reason>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29C9A0 Offset: 0x29CAA1 VA: 0x29C9A0
	private ulong <PrincipalId>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29C9B0 Offset: 0x29CAB1 VA: 0x29C9B0
	private string <Language>k__BackingField; // 0x38

	// Properties
	public ulong DataId { get; set; }
	public ulong ScreenShotId { get; set; }
	public Screening.ReportCategory Category { get; set; }
	public string Reason { get; set; }
	public ulong PrincipalId { get; set; }
	public string Language { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD220 Offset: 0x2CD321 VA: 0x2CD220
	// RVA: 0x1EE3440 Offset: 0x1EE3541 VA: 0x1EE3440
	public void set_DataId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD230 Offset: 0x2CD331 VA: 0x2CD230
	// RVA: 0x1EE3450 Offset: 0x1EE3551 VA: 0x1EE3450
	public ulong get_DataId() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD240 Offset: 0x2CD341 VA: 0x2CD240
	// RVA: 0x1EE3460 Offset: 0x1EE3561 VA: 0x1EE3460
	public void set_ScreenShotId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD250 Offset: 0x2CD351 VA: 0x2CD250
	// RVA: 0x1EE3470 Offset: 0x1EE3571 VA: 0x1EE3470
	public ulong get_ScreenShotId() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD260 Offset: 0x2CD361 VA: 0x2CD260
	// RVA: 0x1EE3480 Offset: 0x1EE3581 VA: 0x1EE3480
	public void set_Category(Screening.ReportCategory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD270 Offset: 0x2CD371 VA: 0x2CD270
	// RVA: 0x1EE3490 Offset: 0x1EE3591 VA: 0x1EE3490
	public Screening.ReportCategory get_Category() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD280 Offset: 0x2CD381 VA: 0x2CD280
	// RVA: 0x1EE34A0 Offset: 0x1EE35A1 VA: 0x1EE34A0
	public void set_Reason(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD290 Offset: 0x2CD391 VA: 0x2CD290
	// RVA: 0x1EE34B0 Offset: 0x1EE35B1 VA: 0x1EE34B0
	public string get_Reason() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD2A0 Offset: 0x2CD3A1 VA: 0x2CD2A0
	// RVA: 0x1EE34C0 Offset: 0x1EE35C1 VA: 0x1EE34C0
	public void set_PrincipalId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD2B0 Offset: 0x2CD3B1 VA: 0x2CD2B0
	// RVA: 0x1EE34D0 Offset: 0x1EE35D1 VA: 0x1EE34D0
	public ulong get_PrincipalId() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD2C0 Offset: 0x2CD3C1 VA: 0x2CD2C0
	// RVA: 0x1EE34E0 Offset: 0x1EE35E1 VA: 0x1EE34E0
	public void set_Language(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD2D0 Offset: 0x2CD3D1 VA: 0x2CD2D0
	// RVA: 0x1EE34F0 Offset: 0x1EE35F1 VA: 0x1EE34F0
	public string get_Language() { }

	// RVA: 0x1EE3500 Offset: 0x1EE3601 VA: 0x1EE3500
	public void .ctor() { }
}

// Namespace: 
public sealed class VersusSendReportSequence.EndCallback : MulticastDelegate // TypeDefIndex: 13733
{
	// Methods

	// RVA: 0x1EE3140 Offset: 0x1EE3241 VA: 0x1EE3140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EE3160 Offset: 0x1EE3261 VA: 0x1EE3160 Slot: 13
	public virtual void Invoke(bool isSucceed) { }

	// RVA: 0x1EE3390 Offset: 0x1EE3491 VA: 0x1EE3390 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isSucceed, AsyncCallback callback, object object) { }

	// RVA: 0x1EE3430 Offset: 0x1EE3531 VA: 0x1EE3430 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum VersusSendReportSequence.Label // TypeDefIndex: 13734
{
	// Fields
	public int value__; // 0x0
	public const VersusSendReportSequence.Label Error = 0;
	public const VersusSendReportSequence.Label End = 1;
}

