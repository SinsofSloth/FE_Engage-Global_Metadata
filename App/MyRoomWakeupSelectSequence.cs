// Namespace: App
public class MyRoomWakeupSelectSequence : SingletonProcInst<MyRoomWakeupSelectSequence> // TypeDefIndex: 11347
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297B70 Offset: 0x297C71 VA: 0x297B70
	private MyRoomWakeupSelectMenuContent <SelectMenuContent>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x297B80 Offset: 0x297C81 VA: 0x297B80
	private MyRoomWakeupSelectRoot <Root>k__BackingField; // 0x80
	public GameObject m_mainContent; // 0x88
	private string m_ReservePID; // 0x90
	private GameSound.WakeupVoicePattern m_ReservePattern; // 0x98
	private RelianceData.Level m_ReserveLevel; // 0x9C
	private int m_TmpSelect; // 0xA0
	private int m_TmpScroll; // 0xA4

	// Properties
	public MyRoomWakeupSelectMenuContent SelectMenuContent { get; set; }
	public MyRoomWakeupSelectRoot Root { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C5070 Offset: 0x2C5171 VA: 0x2C5070
	// RVA: 0x2845900 Offset: 0x2845A01 VA: 0x2845900
	public MyRoomWakeupSelectMenuContent get_SelectMenuContent() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5080 Offset: 0x2C5181 VA: 0x2C5080
	// RVA: 0x2845910 Offset: 0x2845A11 VA: 0x2845910
	public void set_SelectMenuContent(MyRoomWakeupSelectMenuContent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5090 Offset: 0x2C5191 VA: 0x2C5090
	// RVA: 0x2845920 Offset: 0x2845A21 VA: 0x2845920
	public MyRoomWakeupSelectRoot get_Root() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C50A0 Offset: 0x2C51A1 VA: 0x2C50A0
	// RVA: 0x2845930 Offset: 0x2845A31 VA: 0x2845930
	public void set_Root(MyRoomWakeupSelectRoot value) { }

	// RVA: 0x283A2E0 Offset: 0x283A3E1 VA: 0x283A2E0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x28460E0 Offset: 0x28461E1 VA: 0x28460E0
	private void WaitLoadPrefab() { }

	// RVA: 0x2846190 Offset: 0x2846291 VA: 0x2846190
	private void CreateUnitSelectMenu() { }

	// RVA: 0x2846220 Offset: 0x2846321 VA: 0x2846220
	private void Entry() { }

	// RVA: 0x2846510 Offset: 0x2846611 VA: 0x2846510
	private void Exit() { }

	// RVA: 0x2843950 Offset: 0x2843A51 VA: 0x2843950
	public void ReserveWakeup(string pid, RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x2843990 Offset: 0x2843A91 VA: 0x2843990
	public void SaveSelectAndScroll(int select, int scroll) { }

	// RVA: 0x2846710 Offset: 0x2846811 VA: 0x2846710
	private void TryStartWakeup() { }

	// RVA: 0x28459D0 Offset: 0x2845AD1 VA: 0x28459D0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2846990 Offset: 0x2846A91 VA: 0x2846990 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2845940 Offset: 0x2845A41 VA: 0x2845940
	public void .ctor() { }
}

