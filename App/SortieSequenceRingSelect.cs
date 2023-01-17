// Namespace: App
public class SortieSequenceRingSelect : SingletonProcInst<SortieSequenceRingSelect> // TypeDefIndex: 13362
{
	// Fields
	private const string PrefabPath = "UI/Sortie/RingSelect/Prefabs/RingSelectRoot";
	public const string HelpPrefabPath = "UI/Hub/Arena/Prefabs/DetailHelp";
	private GameObject m_GameObject; // 0x78
	private RingSelectRoot m_Window; // 0x80
	private RingSelectMenu m_RingMenu; // 0x88

	// Properties
	public RingSelectMenu RingMenu { get; }

	// Methods

	// RVA: 0x2162390 Offset: 0x2162491 VA: 0x2162390
	public RingSelectMenu get_RingMenu() { }

	// RVA: 0x21623A0 Offset: 0x21624A1 VA: 0x21623A0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2162C00 Offset: 0x2162D01 VA: 0x2162C00
	private void LoadRes() { }

	// RVA: 0x2162D70 Offset: 0x2162E71 VA: 0x2162D70
	private bool IsLoadingRes() { }

	// RVA: 0x2162EC0 Offset: 0x2162FC1 VA: 0x2162EC0
	private void Open() { }

	// RVA: 0x21632F0 Offset: 0x21633F1 VA: 0x21632F0
	private void MenuTick() { }

	// RVA: 0x2163300 Offset: 0x2163401 VA: 0x2163300
	private void Close() { }

	// RVA: 0x2163500 Offset: 0x2163601 VA: 0x2163500
	private void Decide() { }

	// RVA: 0x2163570 Offset: 0x2163671 VA: 0x2163570
	private bool IsPlayEngageDecide() { }

	// RVA: 0x21635F0 Offset: 0x21636F1 VA: 0x21635F0
	private void GodRespondVoice() { }

	// RVA: 0x2162B80 Offset: 0x2162C81 VA: 0x2162B80
	public void .ctor() { }
}

