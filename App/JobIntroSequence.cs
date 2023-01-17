// Namespace: App
public class JobIntroSequence : ProcSceneSequence<JobIntroSequence> // TypeDefIndex: 13021
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B910 Offset: 0x29BA11 VA: 0x29B910
	private static int <CurrentGroupIndex>k__BackingField; // 0x0
	private StructList<JobIntroData> m_JobDataList; // 0x88
	private int m_CurrentIndex; // 0x90
	private float m_WaitTime; // 0x94

	// Properties
	private static int CurrentGroupIndex { get; set; }
	private bool IsFinished { get; }
	public static float ReadyTime1 { get; }
	public static float ReadyTime2 { get; }
	public JobIntroData CurrentData { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CADC0 Offset: 0x2CAEC1 VA: 0x2CADC0
	// RVA: 0x2463AD0 Offset: 0x2463BD1 VA: 0x2463AD0
	private static int get_CurrentGroupIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CADD0 Offset: 0x2CAED1 VA: 0x2CADD0
	// RVA: 0x2463B20 Offset: 0x2463C21 VA: 0x2463B20
	private static void set_CurrentGroupIndex(int value) { }

	// RVA: 0x2463B80 Offset: 0x2463C81 VA: 0x2463B80
	public static void ToNextIndex() { }

	// RVA: 0x2463FA0 Offset: 0x24640A1 VA: 0x2463FA0
	public static bool IsExist() { }

	// RVA: 0x2464020 Offset: 0x2464121 VA: 0x2464020
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2464930 Offset: 0x2464A31 VA: 0x2464930
	private bool get_IsFinished() { }

	// RVA: 0x2464980 Offset: 0x2464A81 VA: 0x2464980
	public static float get_ReadyTime1() { }

	// RVA: 0x24649D0 Offset: 0x2464AD1 VA: 0x24649D0
	public static float get_ReadyTime2() { }

	// RVA: 0x2464A20 Offset: 0x2464B21 VA: 0x2464A20
	public JobIntroData get_CurrentData() { }

	// RVA: 0x2464AB0 Offset: 0x2464BB1 VA: 0x2464AB0
	private void Initialize() { }

	// RVA: 0x2464F20 Offset: 0x2465021 VA: 0x2464F20
	private void BeginMap() { }

	// RVA: 0x2464FF0 Offset: 0x24650F1 VA: 0x2464FF0
	private void Unload() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CADE0 Offset: 0x2CAEE1 VA: 0x2CADE0
	// RVA: 0x2465350 Offset: 0x2465451 VA: 0x2465350
	private IEnumerator Begin() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CAE50 Offset: 0x2CAF51 VA: 0x2CAE50
	// RVA: 0x24653D0 Offset: 0x24654D1 VA: 0x24653D0
	private IEnumerator Tick() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CAEC0 Offset: 0x2CAFC1 VA: 0x2CAEC0
	// RVA: 0x2465450 Offset: 0x2465551 VA: 0x2465450
	private IEnumerator Finish() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CAF30 Offset: 0x2CB031 VA: 0x2CAF30
	// RVA: 0x24654B0 Offset: 0x24655B1 VA: 0x24654B0
	private IEnumerator CheckKeyPush() { }

	// RVA: 0x2465530 Offset: 0x2465631 VA: 0x2465530
	private void BranchLoop() { }

	// RVA: 0x24648D0 Offset: 0x24649D1 VA: 0x24648D0
	public void .ctor() { }
}

