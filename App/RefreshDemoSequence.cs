// Namespace: App
public class RefreshDemoSequence : ProcInst // TypeDefIndex: 11687
{
	// Fields
	private static readonly string s_BasketPath; // 0x0
	private static readonly string s_FruitsPath; // 0x8
	private static readonly string s_AOCHumMPath; // 0x10
	private static readonly string s_AOCHumFPath; // 0x18
	private static readonly string s_AOCHorsePath; // 0x20
	private static readonly string s_AOCc400Path; // 0x28
	private RefreshDemoSequence.RefreshArea m_RefreshArea; // 0x70
	private List<Unit> m_SelectUnitList; // 0x78
	private GameObject m_AreaObject; // 0x80
	private int m_LoadingCount; // 0x88
	private GameObject m_MainCamera; // 0x90
	private ResourceHandle m_DemoCameraHandle; // 0x98
	private GameObject m_DemoCamera; // 0xA0
	private ReliancePopUpController m_ReliancePopUp; // 0xA8

	// Methods

	// RVA: 0x2528430 Offset: 0x2528531 VA: 0x2528430
	public static void CreateBind(ProcInst super, string aid, Unit unit1, Unit unit2) { }

	// RVA: 0x25284D0 Offset: 0x25285D1 VA: 0x25284D0
	private void .ctor(string aid, Unit unit1, Unit unit2) { }

	// RVA: 0x2528680 Offset: 0x2528781 VA: 0x2528680
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2528D70 Offset: 0x2528E71 VA: 0x2528D70
	private void StartSequence() { }

	// RVA: 0x2529330 Offset: 0x2529431 VA: 0x2529330
	private void CreateUnit(Unit unit, int locatorNum) { }

	// RVA: 0x2529600 Offset: 0x2529701 VA: 0x2529600
	private void CreateHorse(string pid, int locatorNum) { }

	// RVA: 0x2529820 Offset: 0x2529921 VA: 0x2529820
	private bool IsWaitingSetup() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C62C0 Offset: 0x2C63C1 VA: 0x2C62C0
	// RVA: 0x2529860 Offset: 0x2529961 VA: 0x2529860
	private IEnumerator PlayDemo() { }

	// RVA: 0x25298E0 Offset: 0x25299E1 VA: 0x25298E0
	private void EndSequence() { }

	// RVA: 0x2529AF0 Offset: 0x2529BF1 VA: 0x2529AF0
	private void LoadResource() { }

	// RVA: 0x252A260 Offset: 0x252A361 VA: 0x252A260
	private bool IsLoadingResource() { }

	// RVA: 0x252A4C0 Offset: 0x252A5C1 VA: 0x252A4C0
	private void UnloadResource() { }

	// RVA: 0x252A5D0 Offset: 0x252A6D1 VA: 0x252A5D0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6330 Offset: 0x2C6431 VA: 0x2C6330
	// RVA: 0x252A720 Offset: 0x252A821 VA: 0x252A720
	private void <StartSequence>b__18_0(GameObject demoCamera) { }
}

