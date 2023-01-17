// Namespace: 
private class SaveData.Manager : SingletonClass<SaveData.Manager> // TypeDefIndex: 9159
{
	// Fields
	private static readonly Result ResultSuccess; // 0x0
	private Thread m_Thread; // 0x20
	private EventWaitHandle[] m_Events; // 0x28
	private Queue<SaveData.Manager.Task> m_Tasks; // 0x30

	// Properties
	private EventWaitHandle CleanupEvent { get; }
	private EventWaitHandle TaskEvent { get; }

	// Methods

	// RVA: 0x1F59030 Offset: 0x1F59131 VA: 0x1F59030
	public void .ctor() { }

	// RVA: 0x1F592A0 Offset: 0x1F593A1 VA: 0x1F592A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1F59340 Offset: 0x1F59441 VA: 0x1F59340
	public void Cleanup() { }

	// RVA: 0x1F59450 Offset: 0x1F59551 VA: 0x1F59450
	public void RegisterTask(SaveData.Manager.Task task) { }

	// RVA: 0x1F59630 Offset: 0x1F59731 VA: 0x1F59630
	public Result Read(ref long readSize, string path, long offset, byte[] data, long size) { }

	// RVA: 0x1F597F0 Offset: 0x1F598F1 VA: 0x1F597F0
	public Result Write(string path, long offset, byte[] data, long size, bool isEnableResize) { }

	// RVA: 0x1F59AA0 Offset: 0x1F59BA1 VA: 0x1F59AA0
	public Result Delete(string path) { }

	// RVA: 0x1F59C60 Offset: 0x1F59D61 VA: 0x1F59C60
	public void Commit(string mountName) { }

	// RVA: 0x1F59DA0 Offset: 0x1F59EA1 VA: 0x1F59DA0
	public bool IsExist(string path) { }

	// RVA: 0x1F59E80 Offset: 0x1F59F81 VA: 0x1F59E80
	public long GetFileSize(string path) { }

	// RVA: 0x1F59FD0 Offset: 0x1F5A0D1 VA: 0x1F59FD0
	public void Dump(string rootPath) { }

	// RVA: 0x1F5A110 Offset: 0x1F5A211 VA: 0x1F5A110
	private void ThreadFunc() { }

	// RVA: 0x1F5A3F0 Offset: 0x1F5A4F1 VA: 0x1F5A3F0
	private void Read(SaveData.Manager.Task task) { }

	// RVA: 0x1F5A4F0 Offset: 0x1F5A5F1 VA: 0x1F5A4F0
	private void Write(SaveData.Manager.Task task) { }

	// RVA: 0x1F5A550 Offset: 0x1F5A651 VA: 0x1F5A550
	private void Delete(SaveData.Manager.Task task) { }

	// RVA: 0x1F5A5A0 Offset: 0x1F5A6A1 VA: 0x1F5A5A0
	private void Commit(SaveData.Manager.Task task) { }

	// RVA: 0x1F59650 Offset: 0x1F59751 VA: 0x1F59650
	private Result ReadNX(ref long readSize, string path, long offset, byte[] data, long size) { }

	// RVA: 0x1F59810 Offset: 0x1F59911 VA: 0x1F59810
	private Result WriteNX(string path, long offset, byte[] data, long size, bool isEnableResize) { }

	// RVA: 0x1F59AC0 Offset: 0x1F59BC1 VA: 0x1F59AC0
	private Result DeleteNX(string path) { }

	// RVA: 0x1F59D00 Offset: 0x1F59E01 VA: 0x1F59D00
	private void CommitNX(string mountName) { }

	// RVA: 0x1F59DB0 Offset: 0x1F59EB1 VA: 0x1F59DB0
	private bool IsExistNX(string path) { }

	// RVA: 0x1F59E90 Offset: 0x1F59F91 VA: 0x1F59E90
	private long GetFileSizeNX(string path) { }

	// RVA: 0x1F5A700 Offset: 0x1F5A801 VA: 0x1F5A700
	private Result CreateFileNX(string path, long size) { }

	// RVA: 0x1F5A070 Offset: 0x1F5A171 VA: 0x1F5A070
	private void DumpNX(string rootPath) { }

	// RVA: 0x1F5A970 Offset: 0x1F5AA71 VA: 0x1F5A970
	private void DumpSingleDirectoryNX(StringBuilder sb, int indentCount, string parentPath, string dirName) { }

	// RVA: 0x1F5A690 Offset: 0x1F5A791 VA: 0x1F5A690
	private string Backslash2Slash(string path) { }

	// RVA: 0x1F59420 Offset: 0x1F59521 VA: 0x1F59420
	private EventWaitHandle get_CleanupEvent() { }

	// RVA: 0x1F59600 Offset: 0x1F59701 VA: 0x1F59600
	private EventWaitHandle get_TaskEvent() { }

	// RVA: 0x1F5ACB0 Offset: 0x1F5ADB1 VA: 0x1F5ACB0
	private static void .cctor() { }
}

