// Namespace: 
public enum SaveData.Manager.TaskKind // TypeDefIndex: 9156
{
	// Fields
	public int value__; // 0x0
	public const SaveData.Manager.TaskKind Read = 0;
	public const SaveData.Manager.TaskKind Write = 1;
	public const SaveData.Manager.TaskKind Delete = 2;
	public const SaveData.Manager.TaskKind Commit = 3;
}

// Namespace: 
public class SaveData.Manager.Task // TypeDefIndex: 9157
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286C70 Offset: 0x286D71 VA: 0x286C70
	private SaveData.Manager.TaskKind <Kind>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x286C80 Offset: 0x286D81 VA: 0x286C80
	private string <Path>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x286C90 Offset: 0x286D91 VA: 0x286C90
	private byte[] <Data>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x286CA0 Offset: 0x286DA1 VA: 0x286CA0
	private long <Size>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x286CB0 Offset: 0x286DB1 VA: 0x286CB0
	private long <Offset>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x286CC0 Offset: 0x286DC1 VA: 0x286CC0
	private bool <IsEnableResize>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x286CD0 Offset: 0x286DD1 VA: 0x286CD0
	private SaveDataHandle <Handle>k__BackingField; // 0x40

	// Properties
	public SaveData.Manager.TaskKind Kind { get; set; }
	public string Path { get; set; }
	public byte[] Data { get; set; }
	public long Size { get; set; }
	public long Offset { get; set; }
	public bool IsEnableResize { get; set; }
	public SaveDataHandle Handle { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AE510 Offset: 0x2AE611 VA: 0x2AE510
	// RVA: 0x21F7F90 Offset: 0x21F8091 VA: 0x21F7F90
	public SaveData.Manager.TaskKind get_Kind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE520 Offset: 0x2AE621 VA: 0x2AE520
	// RVA: 0x21F7FA0 Offset: 0x21F80A1 VA: 0x21F7FA0
	public void set_Kind(SaveData.Manager.TaskKind value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE530 Offset: 0x2AE631 VA: 0x2AE530
	// RVA: 0x21F7FB0 Offset: 0x21F80B1 VA: 0x21F7FB0
	public string get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE540 Offset: 0x2AE641 VA: 0x2AE540
	// RVA: 0x21F7FC0 Offset: 0x21F80C1 VA: 0x21F7FC0
	public void set_Path(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE550 Offset: 0x2AE651 VA: 0x2AE550
	// RVA: 0x21F7FD0 Offset: 0x21F80D1 VA: 0x21F7FD0
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE560 Offset: 0x2AE661 VA: 0x2AE560
	// RVA: 0x21F7FE0 Offset: 0x21F80E1 VA: 0x21F7FE0
	public void set_Data(byte[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE570 Offset: 0x2AE671 VA: 0x2AE570
	// RVA: 0x21F7FF0 Offset: 0x21F80F1 VA: 0x21F7FF0
	public long get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE580 Offset: 0x2AE681 VA: 0x2AE580
	// RVA: 0x21F8000 Offset: 0x21F8101 VA: 0x21F8000
	public void set_Size(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE590 Offset: 0x2AE691 VA: 0x2AE590
	// RVA: 0x21F8010 Offset: 0x21F8111 VA: 0x21F8010
	public long get_Offset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE5A0 Offset: 0x2AE6A1 VA: 0x2AE5A0
	// RVA: 0x21F8020 Offset: 0x21F8121 VA: 0x21F8020
	public void set_Offset(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE5B0 Offset: 0x2AE6B1 VA: 0x2AE5B0
	// RVA: 0x21F8030 Offset: 0x21F8131 VA: 0x21F8030
	public bool get_IsEnableResize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE5C0 Offset: 0x2AE6C1 VA: 0x2AE5C0
	// RVA: 0x21F8040 Offset: 0x21F8141 VA: 0x21F8040
	public void set_IsEnableResize(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE5D0 Offset: 0x2AE6D1 VA: 0x2AE5D0
	// RVA: 0x21F8050 Offset: 0x21F8151 VA: 0x21F8050
	public SaveDataHandle get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE5E0 Offset: 0x2AE6E1 VA: 0x2AE5E0
	// RVA: 0x21F8060 Offset: 0x21F8161 VA: 0x21F8060
	public void set_Handle(SaveDataHandle value) { }

	// RVA: 0x21F8070 Offset: 0x21F8171 VA: 0x21F8070
	public void .ctor() { }
}

// Namespace: 
private enum SaveData.Manager.EventKind // TypeDefIndex: 9158
{
	// Fields
	public int value__; // 0x0
	public const SaveData.Manager.EventKind Cleanup = 0;
	public const SaveData.Manager.EventKind Task = 1;
}

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

