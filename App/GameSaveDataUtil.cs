// Namespace: App
public static class GameSaveDataUtil // TypeDefIndex: 13601
{
	// Methods

	// RVA: 0x26AED30 Offset: 0x26AEE31 VA: 0x26AED30
	public static bool IsExist(GameSaveData.Types type) { }

	// RVA: 0x26AEEA0 Offset: 0x26AEFA1 VA: 0x26AEEA0
	public static bool IsExist(GameSaveData.Types type, int index) { }

	// RVA: 0x26AEF60 Offset: 0x26AF061 VA: 0x26AEF60
	public static bool IsExist(string path) { }

	// RVA: 0x26AEFD0 Offset: 0x26AF0D1 VA: 0x26AEFD0
	public static bool ReadHeader(GameSaveData.Types type, int index, GameSaveDataHeader header) { }

	// RVA: 0x26AF170 Offset: 0x26AF271 VA: 0x26AF170
	public static void Read(ProcInst super, GameSaveData.Types type, int index, GameSaveDataUtil.ProcessResult resultCallback) { }

	// RVA: 0x26AF2C0 Offset: 0x26AF3C1 VA: 0x26AF2C0
	public static void ReadGlobal(ProcInst super) { }

	// RVA: 0x26AF2D0 Offset: 0x26AF3D1 VA: 0x26AF2D0
	public static void Write(ProcInst super, GameSaveData.Types type, int index, GameSaveDataUtil.ProcessResultWithHeader resultHeaderCallback) { }

	// RVA: 0x26AF2E0 Offset: 0x26AF3E1 VA: 0x26AF2E0
	public static void Delete(ProcInst super, GameSaveData.Types type, int index, GameSaveDataUtil.ProcessResult resultCallback) { }

	// RVA: 0x26AF430 Offset: 0x26AF531 VA: 0x26AF430
	public static void CommitTemporary(ProcInst super) { }

	// RVA: 0x26AF690 Offset: 0x26AF791 VA: 0x26AF690
	public static void DeleteAll(ProcInst super) { }

	// RVA: 0x26AF6A0 Offset: 0x26AF7A1 VA: 0x26AF6A0
	public static void Copy(ProcInst super, GameSaveData.Types type, int index, GameSaveData.Types fromType, int fromIndex, GameSaveDataUtil.ProcessResultWithHeader resultHeaderCallback) { }

	// RVA: 0x26AF810 Offset: 0x26AF911 VA: 0x26AF810
	public static void TryNotifyNormalizeContentsOccurred(ProcInst super) { }
}

