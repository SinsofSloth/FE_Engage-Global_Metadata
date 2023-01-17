// Namespace: App
public class GameUserRestartData : SingletonClass<GameUserRestartData> // TypeDefIndex: 13628
{
	// Fields
	private GameUserRestartData.RestartStream[] m_Streams; // 0x20
	private GameUserRestartData.Targtes m_Target; // 0x28
	private bool m_KeepLevel; // 0x2C

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x28DCBF0 Offset: 0x28DCCF1 VA: 0x28DCBF0
	private GameUserRestartData.RestartStream GetStream(GameUserRestartData.Targtes target) { }

	// RVA: 0x28DCC30 Offset: 0x28DCD31 VA: 0x28DCC30 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x28DCD70 Offset: 0x28DCE71 VA: 0x28DCD70 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x28DCD80 Offset: 0x28DCE81 VA: 0x28DCD80 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x28DCD90 Offset: 0x28DCE91 VA: 0x28DCD90 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x28DCE20 Offset: 0x28DCF21 VA: 0x28DCE20 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x28DD100 Offset: 0x28DD201 VA: 0x28DD100
	public static void Save(GameUserRestartData.Targtes target) { }

	// RVA: 0x28DD1C0 Offset: 0x28DD2C1 VA: 0x28DD1C0
	public static bool Load(GameUserRestartData.Targtes target, bool keepLevel = False, bool keepAchieve = True, bool completed = False) { }

	// RVA: 0x28DD040 Offset: 0x28DD141 VA: 0x28DD040
	public static void Clear() { }

	// RVA: 0x28DD2B0 Offset: 0x28DD3B1 VA: 0x28DD2B0
	public static bool IsEnable(GameUserRestartData.Targtes target) { }

	// RVA: 0x28DD370 Offset: 0x28DD471 VA: 0x28DD370
	public static int GetSize(GameUserRestartData.Targtes target) { }

	// RVA: 0x28DD430 Offset: 0x28DD531 VA: 0x28DD430
	public static ChapterData GetChapter(GameUserRestartData.Targtes target) { }

	// RVA: 0x28DD4E0 Offset: 0x28DD5E1 VA: 0x28DD4E0
	public static GameUserRestartData.Targtes GetTarget() { }

	// RVA: 0x28DD560 Offset: 0x28DD661 VA: 0x28DD560
	public static bool IsKeepLevel() { }

	// RVA: 0x28DD5E0 Offset: 0x28DD6E1 VA: 0x28DD5E0
	public static void SetTarget(GameUserRestartData.Targtes target, bool keepLevel = False) { }

	// RVA: 0x28DD680 Offset: 0x28DD781 VA: 0x28DD680
	public void .ctor() { }
}

