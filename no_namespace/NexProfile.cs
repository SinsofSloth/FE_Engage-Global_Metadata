// Namespace: 
private enum NexProfile.ServerSequence.Label // TypeDefIndex: 12738
{
	// Fields
	public int value__; // 0x0
	public const NexProfile.ServerSequence.Label Upload = 0;
	public const NexProfile.ServerSequence.Label UploadNew = 1;
	public const NexProfile.ServerSequence.Label UploadChange = 2;
	public const NexProfile.ServerSequence.Label UploadChangeMeta = 3;
	public const NexProfile.ServerSequence.Label Download = 4;
	public const NexProfile.ServerSequence.Label Succeeded = 5;
	public const NexProfile.ServerSequence.Label Error = 6;
	public const NexProfile.ServerSequence.Label End = 7;
}

// Namespace: 
private class NexProfile.ServerSequence : ProcInst // TypeDefIndex: 12740
{
	// Fields
	private const int BufferSizeMax = 65536;
	private NexProfile.ServerSequence.Mode m_Mode; // 0x70
	private ulong m_PrincipalID; // 0x78
	private ProfileCard m_Profile; // 0x80
	private ulong m_DataID; // 0x88

	// Methods

	// RVA: 0x26EEE90 Offset: 0x26EEF91 VA: 0x26EEE90
	private void .ctor(NexProfile.ServerSequence.Mode mode, ulong principalID, ProfileCard profile) { }

	// RVA: 0x26EEEF0 Offset: 0x26EEFF1 VA: 0x26EEEF0
	private void Login() { }

	// RVA: 0x26EEF60 Offset: 0x26EF061 VA: 0x26EEF60
	private void Postlogin() { }

	// RVA: 0x26EF0D0 Offset: 0x26EF1D1 VA: 0x26EF0D0
	private void Branch() { }

	// RVA: 0x26EF190 Offset: 0x26EF291 VA: 0x26EF190
	private void UploadBranch() { }

	// RVA: 0x26EF390 Offset: 0x26EF491 VA: 0x26EF390
	private void UploadNew() { }

	// RVA: 0x26EF740 Offset: 0x26EF841 VA: 0x26EF740
	private void Change() { }

	// RVA: 0x26EF970 Offset: 0x26EFA71 VA: 0x26EF970
	private void ChangeMeta() { }

	// RVA: 0x26EF620 Offset: 0x26EF721 VA: 0x26EF620
	private void SerializeData(out byte[] data, out uint size) { }

	// RVA: 0x26EF710 Offset: 0x26EF811 VA: 0x26EF710
	private DataStore.Permission GetAccessPermission() { }

	// RVA: 0x26EFBA0 Offset: 0x26EFCA1 VA: 0x26EFBA0
	private void Download() { }

	// RVA: 0x26EFEB0 Offset: 0x26EFFB1 VA: 0x26EFEB0
	private ProfileCard DeserializeData(byte[] data) { }

	// RVA: 0x26EFF50 Offset: 0x26F0051 VA: 0x26EFF50
	private void Succeeded() { }

	// RVA: 0x26EFFD0 Offset: 0x26F00D1 VA: 0x26EFFD0
	private void SetError(AsyncResult error) { }

	// RVA: 0x26EF320 Offset: 0x26EF421 VA: 0x26EF320
	private void SetError(NetError.App error) { }

	// RVA: 0x26F0040 Offset: 0x26F0141 VA: 0x26F0040
	private void SetErrorNotFound() { }

	// RVA: 0x26F00C0 Offset: 0x26F01C1 VA: 0x26F00C0
	private void SetErrorPermissionDenied() { }

	// RVA: 0x26F0140 Offset: 0x26F0241 VA: 0x26F0140
	private void Error() { }

	// RVA: 0x26F01B0 Offset: 0x26F02B1 VA: 0x26F01B0
	public static void CreateBindDownload(ProcInst super, ulong principalID) { }

	// RVA: 0x26F0D80 Offset: 0x26F0E81 VA: 0x26F0D80
	public static void CreateBindUpload(ProcInst super, ProfileCard profile) { }

	// RVA: 0x26F01C0 Offset: 0x26F02C1 VA: 0x26F01C0
	private static void CreateBindImpl(ProcInst super, NexProfile.ServerSequence.Mode mode, ulong principalID, ProfileCard profile) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA040 Offset: 0x2CA141 VA: 0x2CA040
	// RVA: 0x26F0D90 Offset: 0x26F0E91 VA: 0x26F0D90
	private void <UploadBranch>b__11_0(AsyncResult asyncResult, DataStorePersistenceInfo info) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA050 Offset: 0x2CA151 VA: 0x2CA050
	// RVA: 0x26F0EC0 Offset: 0x26F0FC1 VA: 0x26F0EC0
	private void <UploadNew>b__12_0(AsyncResult asyncResult, ulong dataId) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA060 Offset: 0x2CA161 VA: 0x2CA060
	// RVA: 0x26F0FC0 Offset: 0x26F10C1 VA: 0x26F0FC0
	private void <Change>b__13_0(AsyncResult asyncResult) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA070 Offset: 0x2CA171 VA: 0x2CA070
	// RVA: 0x26F10C0 Offset: 0x26F11C1 VA: 0x26F10C0
	private void <ChangeMeta>b__14_0(AsyncResult asyncResult) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA080 Offset: 0x2CA181 VA: 0x2CA080
	// RVA: 0x26F11C0 Offset: 0x26F12C1 VA: 0x26F11C0
	private void <Download>b__17_0(AsyncResult asyncResult, byte[] data) { }
}

