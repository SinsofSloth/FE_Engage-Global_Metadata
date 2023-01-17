// Namespace: 
public sealed class GameSaveDataUtil.ProcessResult : MulticastDelegate // TypeDefIndex: 13595
{
	// Methods

	// RVA: 0x22E9480 Offset: 0x22E9581 VA: 0x22E9480
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E9010 Offset: 0x22E9111 VA: 0x22E9010 Slot: 13
	public virtual void Invoke(bool isSuccess) { }

	// RVA: 0x22E94A0 Offset: 0x22E95A1 VA: 0x22E94A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isSuccess, AsyncCallback callback, object object) { }

	// RVA: 0x22E9540 Offset: 0x22E9641 VA: 0x22E9540 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class GameSaveDataUtil.ProcessResultWithHeader : MulticastDelegate // TypeDefIndex: 13596
{
	// Methods

	// RVA: 0x22E9550 Offset: 0x22E9651 VA: 0x22E9550
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E9240 Offset: 0x22E9341 VA: 0x22E9240 Slot: 13
	public virtual void Invoke(bool isSuccess, GameSaveDataHeader header) { }

	// RVA: 0x22E9570 Offset: 0x22E9671 VA: 0x22E9570 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isSuccess, GameSaveDataHeader header, AsyncCallback callback, object object) { }

	// RVA: 0x22E9610 Offset: 0x22E9711 VA: 0x22E9610 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public enum GameSaveDataUtil.ProcProcess.Modes // TypeDefIndex: 13597
{
	// Fields
	public int value__; // 0x0
	public const GameSaveDataUtil.ProcProcess.Modes Read = 0;
	public const GameSaveDataUtil.ProcProcess.Modes Write = 1;
	public const GameSaveDataUtil.ProcProcess.Modes Delete = 2;
	public const GameSaveDataUtil.ProcProcess.Modes Copy = 3;
}

// Namespace: 
private class GameSaveDataUtil.ProcProcess : ProcInst // TypeDefIndex: 13598
{
	// Fields
	private GameSaveData m_SaveData; // 0x70
	private GameSaveDataUtil.ProcProcess.Modes m_Mode; // 0x78
	private GameSaveDataUtil.ProcessResult m_ResultCallback; // 0x80
	private GameSaveDataUtil.ProcessResultWithHeader m_ResultHeaderCallback; // 0x88

	// Methods

	// RVA: 0x22E8900 Offset: 0x22E8A01 VA: 0x22E8900
	public static void CreateBind(ProcInst super, GameSaveData.Types type, int index, GameSaveDataUtil.ProcProcess.Modes mode, GameSaveDataUtil.ProcessResult resultCallback) { }

	// RVA: 0x22E8C70 Offset: 0x22E8D71 VA: 0x22E8C70
	public static void CreateBindWrite(ProcInst super, GameSaveData.Types type, int index, GameSaveDataUtil.ProcessResultWithHeader resultCallback) { }

	// RVA: 0x22E8DD0 Offset: 0x22E8ED1 VA: 0x22E8DD0
	public static void CreateBindCopy(ProcInst super, GameSaveData.Types type, int index, GameSaveData.Types fromType, int fromIndex, GameSaveDataUtil.ProcessResultWithHeader resultHeaderCallback) { }

	// RVA: 0x22E8A70 Offset: 0x22E8B71 VA: 0x22E8A70
	private static void CreateBindCommon(ProcInst super, GameSaveDataUtil.ProcProcess p) { }

	// RVA: 0x22E89A0 Offset: 0x22E8AA1 VA: 0x22E89A0
	private void .ctor(GameSaveData.Types type, int index, GameSaveDataUtil.ProcProcess.Modes mode, GameSaveDataUtil.ProcessResult resultCallback) { }

	// RVA: 0x22E8D00 Offset: 0x22E8E01 VA: 0x22E8D00
	private void .ctor(GameSaveData.Types type, int index, GameSaveDataUtil.ProcessResultWithHeader resultHeaderCallback) { }

	// RVA: 0x22E8E70 Offset: 0x22E8F71 VA: 0x22E8E70
	private void .ctor(GameSaveData.Types type, int index, GameSaveData.Types fromType, int fromIndex, GameSaveDataUtil.ProcessResultWithHeader resultHeaderCallback) { }

	// RVA: 0x22E8F60 Offset: 0x22E9061 VA: 0x22E8F60
	private void Exec() { }

	// RVA: 0x22E8FC0 Offset: 0x22E90C1 VA: 0x22E8FC0
	private void Result() { }
}

// Namespace: 
private class GameSaveDataUtil.ProcDeleteAll.Data // TypeDefIndex: 13599
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C6F0 Offset: 0x29C7F1 VA: 0x29C6F0
	private SaveDataHandle <Handle>k__BackingField; // 0x10

	// Properties
	public SaveDataHandle Handle { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CC3E0 Offset: 0x2CC4E1 VA: 0x2CC3E0
	// RVA: 0x1DC9830 Offset: 0x1DC9931 VA: 0x1DC9830
	public SaveDataHandle get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC3F0 Offset: 0x2CC4F1 VA: 0x2CC3F0
	// RVA: 0x1DC9840 Offset: 0x1DC9941 VA: 0x1DC9840
	public void set_Handle(SaveDataHandle value) { }

	// RVA: 0x1DC9850 Offset: 0x1DC9951 VA: 0x1DC9850
	public void .ctor() { }
}

// Namespace: 
private class GameSaveDataUtil.ProcDeleteAll : ProcInst // TypeDefIndex: 13600
{
	// Fields
	private List<GameSaveDataUtil.ProcDeleteAll.Data> m_Data; // 0x70

	// Methods

	// RVA: 0x22E7FD0 Offset: 0x22E80D1 VA: 0x22E7FD0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22E8450 Offset: 0x22E8551 VA: 0x22E8450
	private void .ctor() { }

	// RVA: 0x22E84E0 Offset: 0x22E85E1 VA: 0x22E84E0
	protected void PauseExitApp() { }

	// RVA: 0x22E8550 Offset: 0x22E8651 VA: 0x22E8550
	protected void ResumeExitApp() { }

	// RVA: 0x22E85C0 Offset: 0x22E86C1 VA: 0x22E85C0
	private void DeleteAll() { }

	// RVA: 0x22E8790 Offset: 0x22E8891 VA: 0x22E8790
	private bool IsRunning() { }

	// RVA: 0x22E8850 Offset: 0x22E8951 VA: 0x22E8850
	private void WriteGlobal() { }

	// RVA: 0x22E88F0 Offset: 0x22E89F1 VA: 0x22E88F0
	private void Result() { }
}

