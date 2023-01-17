// Namespace: nn.fs
public static class SaveData // TypeDefIndex: 14745
{
	// Properties
	public static ErrorRange ResultUsableSpaceNotEnoughForSaveData { get; }

	// Methods

	// RVA: 0x2060AA0 Offset: 0x2060BA1 VA: 0x2060AA0
	public static ErrorRange get_ResultUsableSpaceNotEnoughForSaveData() { }

	// RVA: 0x2060AE0 Offset: 0x2060BE1 VA: 0x2060AE0
	public static extern Result Ensure(Uid user) { }

	// RVA: 0x205FF00 Offset: 0x2060001 VA: 0x205FF00
	public static extern Result Mount(string name, Uid user) { }

	// RVA: 0x2060B00 Offset: 0x2060C01 VA: 0x2060B00
	public static extern Result MountSaveDataReadOnly(string name, ulong applicationId, Uid user) { }

	// RVA: 0x2060B60 Offset: 0x2060C61 VA: 0x2060B60
	public static extern bool IsExisting(Uid user) { }

	// RVA: 0x2060B80 Offset: 0x2060C81 VA: 0x2060B80
	public static extern bool IsExisting(ulong applicationId, Uid user) { }

	// RVA: 0x2060BA0 Offset: 0x2060CA1 VA: 0x2060BA0
	public static void SetRootPath(string rootPath) { }

	// RVA: 0x2060BB0 Offset: 0x2060CB1 VA: 0x2060BB0
	public static Result MountForDebug(string name) { }
}

