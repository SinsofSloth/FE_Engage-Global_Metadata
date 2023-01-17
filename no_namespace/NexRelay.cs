// Namespace: 
public enum NexRelay.Results // TypeDefIndex: 12748
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.Results Failed = 0;
	public const NexRelay.Results FailedCompare = 1;
	public const NexRelay.Results FailedNotFound = 2;
	public const NexRelay.Results Cancelled = 3;
	public const NexRelay.Results Succeeded = 4;
}

// Namespace: 
protected static class NexRelay.ServerSequenceBase.ConfirmRetryDialog // TypeDefIndex: 12750
{
	// Methods

	// RVA: 0x21F1C10 Offset: 0x21F1D11 VA: 0x21F1C10
	public static void CreateBind(ProcInst super, int yesLabel) { }
}

// Namespace: 
private enum NexRelay.UploadNewSequence.Label // TypeDefIndex: 12752
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.UploadNewSequence.Label Login = 0;
	public const NexRelay.UploadNewSequence.Label Error = 1;
	public const NexRelay.UploadNewSequence.Label End = 2;
}

// Namespace: 
private enum NexRelay.UploadTakeOverSequence.Label // TypeDefIndex: 12754
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.UploadTakeOverSequence.Label Login = 0;
	public const NexRelay.UploadTakeOverSequence.Label UpdateData = 1;
	public const NexRelay.UploadTakeOverSequence.Label Error = 2;
	public const NexRelay.UploadTakeOverSequence.Label ErrorApp = 3;
	public const NexRelay.UploadTakeOverSequence.Label End = 4;
}

// Namespace: 
private enum NexRelay.SearchSequence.Label // TypeDefIndex: 12756
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.SearchSequence.Label Error = 0;
	public const NexRelay.SearchSequence.Label End = 1;
}

// Namespace: 
private enum NexRelay.SetPlayingSequence.Label // TypeDefIndex: 12758
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.SetPlayingSequence.Label Login = 0;
	public const NexRelay.SetPlayingSequence.Label Error = 1;
	public const NexRelay.SetPlayingSequence.Label ErrorApp = 2;
	public const NexRelay.SetPlayingSequence.Label End = 3;
}

// Namespace: 
private enum NexRelay.DownloadSequence.Label // TypeDefIndex: 12760
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.DownloadSequence.Label Login = 0;
	public const NexRelay.DownloadSequence.Label GetData = 1;
	public const NexRelay.DownloadSequence.Label Error = 2;
	public const NexRelay.DownloadSequence.Label ErrorApp = 3;
	public const NexRelay.DownloadSequence.Label End = 4;
}

// Namespace: 
private enum NexRelay.DownloadMetaSequence.Label // TypeDefIndex: 12762
{
	// Fields
	public int value__; // 0x0
	public const NexRelay.DownloadMetaSequence.Label Error = 0;
	public const NexRelay.DownloadMetaSequence.Label ErrorApp = 1;
	public const NexRelay.DownloadMetaSequence.Label End = 2;
}

