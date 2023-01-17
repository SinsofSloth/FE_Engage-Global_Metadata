// Namespace: 
public enum GameSaveData.Types // TypeDefIndex: 13574
{
	// Fields
	public int value__; // 0x0
	public const GameSaveData.Types None = 0;
	public const GameSaveData.Types Global = 1;
	public const GameSaveData.Types __Chapter = 2;
	public const GameSaveData.Types __Temporary = 3;
	public const GameSaveData.Types __Debug = 4;
	public const GameSaveData.Types Auto = 5;
	public const GameSaveData.Types Manual = 6;
	public const GameSaveData.Types Num = 7;
}

// Namespace: 
public class GameSaveData.Tag.Reader // TypeDefIndex: 13576
{
	// Fields
	private List<int> m_PosList; // 0x10

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x1DC9160 Offset: 0x1DC9261 VA: 0x1DC9160
	public void .ctor(Stream stream) { }

	// RVA: 0x1DC93A0 Offset: 0x1DC94A1 VA: 0x1DC93A0
	public int Read(Stream stream, int index) { }

	// RVA: 0x1DC94B0 Offset: 0x1DC95B1 VA: 0x1DC94B0
	public int get_Count() { }
}

// Namespace: 
private abstract class GameSaveData.ProcBase : ProcWaitMessageBase // TypeDefIndex: 13578
{
	// Fields
	protected GameSaveData m_SaveData; // 0x78
	protected SaveDataHandle m_Handle; // 0x80
	private double m_MsgTime; // 0x88
	private GameObject m_Icon; // 0x90

	// Methods

	// RVA: 0x22E29B0 Offset: 0x22E2AB1 VA: 0x22E29B0
	protected void .ctor(GameSaveData saveData) { }

	// RVA: 0x22E29F0 Offset: 0x22E2AF1 VA: 0x22E29F0
	protected void PauseExitApp() { }

	// RVA: 0x22E2A60 Offset: 0x22E2B61 VA: 0x22E2A60
	protected void ResumeExitApp() { }

	// RVA: 0x22E2AD0 Offset: 0x22E2BD1 VA: 0x22E2AD0
	protected void ResumeExitAppAndJumpIfFailed(int label) { }

	// RVA: 0x22E2B90 Offset: 0x22E2C91 VA: 0x22E2B90
	protected void WriteGlobalCore(Stream stream, byte[] data) { }

	// RVA: 0x22E2CA0 Offset: 0x22E2DA1 VA: 0x22E2CA0
	protected void Check(Stream stream, string path) { }

	// RVA: 0x22E2CB0 Offset: 0x22E2DB1 VA: 0x22E2CB0
	protected void Commit() { }

	// RVA: 0x22E2D40 Offset: 0x22E2E41 VA: 0x22E2D40
	protected bool IsRunning() { }

	// RVA: 0x22E2B70 Offset: 0x22E2C71 VA: 0x22E2B70
	protected bool IsFailed() { }

	// RVA: 0x22E2D60 Offset: 0x22E2E61 VA: 0x22E2D60 Slot: 18
	protected virtual bool IsShowing() { }

	// RVA: 0x22E2D70 Offset: 0x22E2E71 VA: 0x22E2D70
	protected void MessageOpen(string mid) { }

	// RVA: 0x22E2ED0 Offset: 0x22E2FD1 VA: 0x22E2ED0
	protected void MessageClose() { }

	// RVA: 0x22E2F90 Offset: 0x22E3091 VA: 0x22E2F90
	protected void StartMessageTime() { }

	// RVA: 0x22E3000 Offset: 0x22E3101 VA: 0x22E3000
	protected float GetWaitMessageTime() { }

	// RVA: 0x22E3030 Offset: 0x22E3131 VA: 0x22E3030
	protected void WaitMessageTime() { }

	// RVA: 0x22E3100 Offset: 0x22E3201 VA: 0x22E3100
	protected void SaveStartSoundEvent() { }

	// RVA: 0x22E31A0 Offset: 0x22E32A1 VA: 0x22E31A0
	protected void SaveEndSoundEvent() { }

	// RVA: 0x22E3240 Offset: 0x22E3341 VA: 0x22E3240
	protected void ModifyForParentalControlImpl() { }
}

// Namespace: 
private class GameSaveData.ProcRead : GameSaveData.ProcBase // TypeDefIndex: 13580
{
	// Fields
	private byte[] m_Data; // 0x98

	// Methods

	// RVA: 0x22E5300 Offset: 0x22E5401 VA: 0x22E5300
	public static void CreateBind(ProcInst super, GameSaveData saveData) { }

	// RVA: 0x22E5A60 Offset: 0x22E5B61 VA: 0x22E5A60
	private void .ctor(GameSaveData saveData) { }

	// RVA: 0x22E5AA0 Offset: 0x22E5BA1 VA: 0x22E5AA0
	private void MessageOpen() { }

	// RVA: 0x22E5B00 Offset: 0x22E5C01 VA: 0x22E5B00
	private void Read() { }

	// RVA: 0x22E5BD0 Offset: 0x22E5CD1 VA: 0x22E5BD0
	private void Deserialize() { }

	// RVA: 0x22E5CB0 Offset: 0x22E5DB1 VA: 0x22E5CB0
	private void CleanupRelayUserGlobalData() { }

	// RVA: 0x22E5D60 Offset: 0x22E5E61 VA: 0x22E5D60
	private void ModifyForParentalControl() { }

	// RVA: 0x22E5D80 Offset: 0x22E5E81 VA: 0x22E5D80 Slot: 18
	protected override bool IsShowing() { }
}

// Namespace: 
private class GameSaveData.ProcWrite : GameSaveData.ProcBase // TypeDefIndex: 13582
{
	// Fields
	private Stream m_Stream; // 0x98
	private byte[] m_Data; // 0xA0

	// Methods

	// RVA: 0x22E5DA0 Offset: 0x22E5EA1 VA: 0x22E5DA0
	public static void CreateBind(ProcInst super, GameSaveData saveData) { }

	// RVA: 0x22E68B0 Offset: 0x22E69B1 VA: 0x22E68B0
	private void .ctor(GameSaveData saveData) { }

	// RVA: 0x22E6990 Offset: 0x22E6A91 VA: 0x22E6990 Slot: 18
	protected override bool IsShowing() { }

	// RVA: 0x22E6A70 Offset: 0x22E6B71 VA: 0x22E6A70
	private void MessageOpen() { }

	// RVA: 0x22E6AD0 Offset: 0x22E6BD1 VA: 0x22E6AD0
	private void ModifyForParentalControl() { }

	// RVA: 0x22E6AF0 Offset: 0x22E6BF1 VA: 0x22E6AF0
	private void Write() { }

	// RVA: 0x22E6BD0 Offset: 0x22E6CD1 VA: 0x22E6BD0
	private void WriteGlobal() { }

	// RVA: 0x22E6C20 Offset: 0x22E6D21 VA: 0x22E6C20
	private void Success() { }
}

// Namespace: 
private class GameSaveData.ProcDelete : GameSaveData.ProcBase // TypeDefIndex: 13584
{
	// Fields
	private GameSaveDataHeaderReader m_HeaderReader; // 0x98
	private Stream m_Stream; // 0xA0
	private byte[] m_Data; // 0xA8

	// Methods

	// RVA: 0x22E41B0 Offset: 0x22E42B1 VA: 0x22E41B0
	public static void CreateBind(ProcInst super, GameSaveData saveData) { }

	// RVA: 0x22E4D50 Offset: 0x22E4E51 VA: 0x22E4D50
	private void .ctor(GameSaveData saveData) { }

	// RVA: 0x22E4D90 Offset: 0x22E4E91 VA: 0x22E4D90 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x22E4DE0 Offset: 0x22E4EE1 VA: 0x22E4DE0
	private void MessageOpen() { }

	// RVA: 0x22E4E40 Offset: 0x22E4F41 VA: 0x22E4E40
	private void ReadHeader() { }

	// RVA: 0x22E4EC0 Offset: 0x22E4FC1 VA: 0x22E4EC0
	private bool IsReadingHeader() { }

	// RVA: 0x22E4F90 Offset: 0x22E5091 VA: 0x22E4F90
	private void DeleteSaveData() { }

	// RVA: 0x22E5020 Offset: 0x22E5121 VA: 0x22E5020
	private bool CheckRelayUserGlobalData() { }

	// RVA: 0x22E5200 Offset: 0x22E5301 VA: 0x22E5200
	private void WriteGlobal() { }

	// RVA: 0x22E52F0 Offset: 0x22E53F1 VA: 0x22E52F0
	private void Success() { }
}

// Namespace: 
private class GameSaveData.ProcCopy : GameSaveData.ProcBase // TypeDefIndex: 13586
{
	// Fields
	private byte[] m_Data; // 0x98

	// Methods

	// RVA: 0x22E33B0 Offset: 0x22E34B1 VA: 0x22E33B0
	public static void CreateBind(ProcInst super, GameSaveData saveData) { }

	// RVA: 0x22E3E70 Offset: 0x22E3F71 VA: 0x22E3E70
	private void .ctor(GameSaveData saveData) { }

	// RVA: 0x22E3EB0 Offset: 0x22E3FB1 VA: 0x22E3EB0
	private void MessageOpen() { }

	// RVA: 0x22E3F10 Offset: 0x22E4011 VA: 0x22E3F10
	private void Read() { }

	// RVA: 0x22E4020 Offset: 0x22E4121 VA: 0x22E4020
	private void Write() { }

	// RVA: 0x22E41A0 Offset: 0x22E42A1 VA: 0x22E41A0
	private void Success() { }
}

