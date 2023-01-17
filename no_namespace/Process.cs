// Namespace: 
private enum Process.StreamReadMode // TypeDefIndex: 2278
{
	// Fields
	public int value__; // 0x0
	public const Process.StreamReadMode undefined = 0;
	public const Process.StreamReadMode syncMode = 1;
	public const Process.StreamReadMode asyncMode = 2;
}

// Namespace: 
private enum Process.State // TypeDefIndex: 2279
{
	// Fields
	public int value__; // 0x0
	public const Process.State HaveId = 1;
	public const Process.State IsLocal = 2;
	public const Process.State IsNt = 4;
	public const Process.State HaveProcessInfo = 8;
	public const Process.State Exited = 16;
	public const Process.State Associated = 32;
	public const Process.State IsWin2k = 64;
	public const Process.State HaveNtProcessInfo = 12;
}

// Namespace: 
private struct Process.ProcInfo // TypeDefIndex: 2280
{
	// Fields
	public IntPtr process_handle; // 0x0
	public int pid; // 0x8
	public string[] envVariables; // 0x10
	public string UserName; // 0x18
	public string Domain; // 0x20
	public IntPtr Password; // 0x28
	public bool LoadUserProfile; // 0x30
}

