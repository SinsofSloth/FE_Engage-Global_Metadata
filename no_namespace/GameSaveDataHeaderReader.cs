// Namespace: 
public enum GameSaveDataHeaderReader.States // TypeDefIndex: 13589
{
	// Fields
	public int value__; // 0x0
	public const GameSaveDataHeaderReader.States Running = 0;
	public const GameSaveDataHeaderReader.States NoData = 1;
	public const GameSaveDataHeaderReader.States Succeeded = 2;
	public const GameSaveDataHeaderReader.States Failed = 3;
}

// Namespace: 
public class GameSaveDataHeaderReader.Handle // TypeDefIndex: 13590
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C6B0 Offset: 0x29C7B1 VA: 0x29C6B0
	private GameSaveData.Types <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29C6C0 Offset: 0x29C7C1 VA: 0x29C6C0
	private int <Index>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x29C6D0 Offset: 0x29C7D1 VA: 0x29C6D0
	private GameSaveDataHeaderReader.States <State>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29C6E0 Offset: 0x29C7E1 VA: 0x29C6E0
	private GameSaveDataHeader <Header>k__BackingField; // 0x20

	// Properties
	public GameSaveData.Types Type { get; set; }
	public int Index { get; set; }
	public GameSaveDataHeaderReader.States State { get; set; }
	public GameSaveDataHeader Header { get; set; }

	// Methods

	// RVA: 0x22E7510 Offset: 0x22E7611 VA: 0x22E7510
	public void .ctor(GameSaveData.Types type, int index) { }

	// RVA: 0x22E4F80 Offset: 0x22E5081 VA: 0x22E4F80
	public bool IsRunning() { }

	// RVA: 0x22E7550 Offset: 0x22E7651 VA: 0x22E7550
	public bool IsNoData() { }

	// RVA: 0x22E51F0 Offset: 0x22E52F1 VA: 0x22E51F0
	public bool IsSucceeded() { }

	// RVA: 0x22E7560 Offset: 0x22E7661 VA: 0x22E7560
	public bool IsFailed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC360 Offset: 0x2CC461 VA: 0x2CC360
	// RVA: 0x22E7570 Offset: 0x22E7671 VA: 0x22E7570
	public GameSaveData.Types get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC370 Offset: 0x2CC471 VA: 0x2CC370
	// RVA: 0x22E7580 Offset: 0x22E7681 VA: 0x22E7580
	private void set_Type(GameSaveData.Types value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC380 Offset: 0x2CC481 VA: 0x2CC380
	// RVA: 0x22E7590 Offset: 0x22E7691 VA: 0x22E7590
	public int get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC390 Offset: 0x2CC491 VA: 0x2CC390
	// RVA: 0x22E75A0 Offset: 0x22E76A1 VA: 0x22E75A0
	private void set_Index(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC3A0 Offset: 0x2CC4A1 VA: 0x2CC3A0
	// RVA: 0x22E75B0 Offset: 0x22E76B1 VA: 0x22E75B0
	public GameSaveDataHeaderReader.States get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC3B0 Offset: 0x2CC4B1 VA: 0x2CC3B0
	// RVA: 0x22E75C0 Offset: 0x22E76C1 VA: 0x22E75C0
	public void set_State(GameSaveDataHeaderReader.States value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC3C0 Offset: 0x2CC4C1 VA: 0x2CC3C0
	// RVA: 0x22E75D0 Offset: 0x22E76D1 VA: 0x22E75D0
	public GameSaveDataHeader get_Header() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC3D0 Offset: 0x2CC4D1 VA: 0x2CC3D0
	// RVA: 0x22E75E0 Offset: 0x22E76E1 VA: 0x22E75E0
	public void set_Header(GameSaveDataHeader value) { }
}

// Namespace: 
private class GameSaveDataHeaderReader.HandleList : List<GameSaveDataHeaderReader.Handle> // TypeDefIndex: 13591
{
	// Methods

	// RVA: 0x22E75F0 Offset: 0x22E76F1 VA: 0x22E75F0
	public void AddAndReadAsync(GameSaveData.Types type) { }

	// RVA: 0x22E7AA0 Offset: 0x22E7BA1 VA: 0x22E7AA0
	public void .ctor() { }
}

// Namespace: 
private class GameSaveDataHeaderReader.ProcRead : ProcInst // TypeDefIndex: 13592
{
	// Fields
	private GameSaveDataHeaderReader.Handle m_Handle; // 0x70
	private SaveDataReadHandle m_SaveDataHandle; // 0x78

	// Methods

	// RVA: 0x22E77B0 Offset: 0x22E78B1 VA: 0x22E77B0
	public static void Create(ProcInst super, GameSaveDataHeaderReader.Handle handle) { }

	// RVA: 0x22E7B20 Offset: 0x22E7C21 VA: 0x22E7B20
	private void .ctor(GameSaveDataHeaderReader.Handle handle) { }

	// RVA: 0x22E7B60 Offset: 0x22E7C61 VA: 0x22E7B60
	private void Read() { }

	// RVA: 0x22E7CC0 Offset: 0x22E7DC1 VA: 0x22E7CC0
	private bool IsRunning() { }

	// RVA: 0x22E7CE0 Offset: 0x22E7DE1 VA: 0x22E7CE0
	private void Result() { }
}

// Namespace: 
private class GameSaveDataHeaderReader.ProcRelease : ProcInst // TypeDefIndex: 13593
{
	// Fields
	private List<GameSaveDataHeaderReader.Handle> m_Handles; // 0x70

	// Methods

	// RVA: 0x22E7DD0 Offset: 0x22E7ED1 VA: 0x22E7DD0
	public static void Create(ProcInst super, List<GameSaveDataHeaderReader.Handle> handles) { }

	// RVA: 0x22E7E50 Offset: 0x22E7F51 VA: 0x22E7E50
	private void .ctor(List<GameSaveDataHeaderReader.Handle> handles) { }

	// RVA: 0x22E7E90 Offset: 0x22E7F91 VA: 0x22E7E90 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x22E7F10 Offset: 0x22E8011 VA: 0x22E7F10 Slot: 6
	protected override void OnTick() { }
}

