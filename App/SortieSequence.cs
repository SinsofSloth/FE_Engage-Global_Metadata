// Namespace: App
public class SortieSequence : SingletonProcInst<SortieSequence> // TypeDefIndex: 13351
{
	// Fields
	private static bool s_IsDecidedToBattle; // 0x0
	private SortieSequence.Modes m_Mode; // 0x74

	// Properties
	public SortieSequence.Modes Mode { get; }

	// Methods

	// RVA: 0x2159FF0 Offset: 0x215A0F1 VA: 0x2159FF0
	public static ProcInst CreateBindMap(ProcInst super) { }

	// RVA: 0x215B150 Offset: 0x215B251 VA: 0x215B150
	public static ProcInst CreateBindHub(ProcInst super) { }

	// RVA: 0x215B160 Offset: 0x215B261 VA: 0x215B160
	public static ProcInst CreateBindEdit(ProcInst super) { }

	// RVA: 0x215A000 Offset: 0x215A101 VA: 0x215A000
	private static ProcInst CreateBindImpl(ProcInst super, SortieSequence.Modes mode) { }

	// RVA: 0x215B230 Offset: 0x215B331 VA: 0x215B230
	public static void DecideToBattle() { }

	// RVA: 0x215B2E0 Offset: 0x215B3E1 VA: 0x215B2E0
	public static bool IsDecidedToBattle() { }

	// RVA: 0x215B330 Offset: 0x215B431 VA: 0x215B330
	public SortieSequence.Modes get_Mode() { }

	// RVA: 0x215B170 Offset: 0x215B271 VA: 0x215B170
	private void .ctor(SortieSequence.Modes mode) { }

	// RVA: 0x215B340 Offset: 0x215B441 VA: 0x215B340 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x215B670 Offset: 0x215B771 VA: 0x215B670 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x215B6E0 Offset: 0x215B7E1 VA: 0x215B6E0
	private void SetupUnits() { }

	// RVA: 0x215BD90 Offset: 0x215BE91 VA: 0x215BD90
	private void PostSetupUnits() { }

	// RVA: 0x215BE20 Offset: 0x215BF21 VA: 0x215BE20
	private void TryShowTutorial() { }

	// RVA: 0x215BF00 Offset: 0x215C001 VA: 0x215BF00
	private void Notice() { }

	// RVA: 0x215C330 Offset: 0x215C431 VA: 0x215C330
	private void ResetManagers() { }

	// RVA: 0x215C4F0 Offset: 0x215C5F1 VA: 0x215C4F0
	private void ShowHelp() { }

	// RVA: 0x215C590 Offset: 0x215C691 VA: 0x215C590
	private void HideHelp() { }

	// RVA: 0x215C610 Offset: 0x215C711 VA: 0x215C610
	private void PlayBgm() { }

	// RVA: 0x215C6E0 Offset: 0x215C7E1 VA: 0x215C6E0
	private void StopBgm() { }

	// RVA: 0x215C7B0 Offset: 0x215C8B1 VA: 0x215C7B0
	private void StopFieldBgmForRelayTakeOver() { }
}

