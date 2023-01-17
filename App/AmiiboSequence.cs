// Namespace: App
internal class AmiiboSequence : SingletonProcInst<AmiiboSequence> // TypeDefIndex: 10402
{
	// Fields
	private int m_RetryCount; // 0x74
	private const int RetryCountMax = 3;
	private List<AmiiboSequence.GainItemData> m_GainItemList; // 0x78
	private int m_GainItemIndex; // 0x80
	private bool m_DebugAlreadyGetOnceItem; // 0x84
	public static readonly long ReesetTimeSeconds; // 0x0

	// Methods

	// RVA: 0x20E7F50 Offset: 0x20E8051 VA: 0x20E7F50
	private void FinalizeSystem() { }

	// RVA: 0x20E7FD0 Offset: 0x20E80D1 VA: 0x20E7FD0
	private void AmiiboReadingMenu() { }

	// RVA: 0x20E7FE0 Offset: 0x20E80E1 VA: 0x20E7FE0
	private void InitializeSystem() { }

	// RVA: 0x20E8100 Offset: 0x20E8201 VA: 0x20E8100
	private void Setup() { }

	// RVA: 0x20E83D0 Offset: 0x20E84D1 VA: 0x20E83D0
	private void ShowError(Result result) { }

	// RVA: 0x20E8330 Offset: 0x20E8431 VA: 0x20E8330
	private bool SetupOnGameErrorHandling(Result result) { }

	// RVA: 0x20E8410 Offset: 0x20E8511 VA: 0x20E8410
	private void Read() { }

	// RVA: 0x20E84F0 Offset: 0x20E85F1 VA: 0x20E84F0
	private bool ReadOnGameErrorHandling(Result result) { }

	// RVA: 0x20E85E0 Offset: 0x20E86E1 VA: 0x20E85E0
	private bool CommonErrorHandling(Result result) { }

	// RVA: 0x20E87F0 Offset: 0x20E88F1 VA: 0x20E87F0
	private static bool CheckPassedDay(int seconds, int oldSeconds) { }

	// RVA: 0x20E8870 Offset: 0x20E8971 VA: 0x20E8870
	private void ReceiveRelayTicket(int num) { }

	// RVA: 0x20E8910 Offset: 0x20E8A11 VA: 0x20E8910
	private void ReceiveFirstItem(AmiiboData data, int numberingId) { }

	// RVA: 0x20E8B20 Offset: 0x20E8C21 VA: 0x20E8B20
	private void ReceiveOtherAmiiboItem(AmiiboData data, int seedOffset, int numberingId) { }

	// RVA: 0x20E8D00 Offset: 0x20E8E01 VA: 0x20E8D00
	private void Mount() { }

	// RVA: 0x20EA660 Offset: 0x20EA761 VA: 0x20EA660
	private bool MountOnGameErrorHandling(Result result) { }

	// RVA: 0x20EA8C0 Offset: 0x20EA9C1 VA: 0x20EA8C0
	private void GetItem() { }

	// RVA: 0x20EB160 Offset: 0x20EB261 VA: 0x20EB160
	private void AlreadyGetItem() { }

	// RVA: 0x20EB200 Offset: 0x20EB301 VA: 0x20EB200
	public void JumpToMount() { }

	// RVA: 0x20E7A00 Offset: 0x20E7B01 VA: 0x20E7A00
	public bool SearchAmiibo() { }

	// RVA: 0x20EB2C0 Offset: 0x20EB3C1 VA: 0x20EB2C0
	private void TagLostStandbyReady() { }

	// RVA: 0x20EB3D0 Offset: 0x20EB4D1 VA: 0x20EB3D0
	public static void AmiiboGameUserDataReset() { }

	// RVA: 0x20EB730 Offset: 0x20EB831 VA: 0x20EB730
	public static bool CheckPassedDay() { }

	// RVA: 0x20EBAA0 Offset: 0x20EBBA1 VA: 0x20EBAA0
	public static int GetCanReceiveCount() { }

	// RVA: 0x20EBD20 Offset: 0x20EBE21 VA: 0x20EBD20
	public static int GetReceiveCountResetTime() { }

	// RVA: 0x20EBEF0 Offset: 0x20EBFF1 VA: 0x20EBEF0
	public static string GetReceiveCountResetTimeString() { }

	// RVA: 0x20EC040 Offset: 0x20EC141 VA: 0x20EC040
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x20EC1E0 Offset: 0x20EC2E1 VA: 0x20EC1E0
	public ProcDesc[] CreateDesc() { }

	// RVA: 0x20ECD70 Offset: 0x20ECE71 VA: 0x20ECD70
	private void LoadRes() { }

	// RVA: 0x20ECE10 Offset: 0x20ECF11 VA: 0x20ECE10
	private bool IsLoadingRes() { }

	// RVA: 0x20ECE80 Offset: 0x20ECF81 VA: 0x20ECE80
	private void UnloadRes() { }

	// RVA: 0x20EC160 Offset: 0x20EC261 VA: 0x20EC160
	public void .ctor() { }

	// RVA: 0x20ECF00 Offset: 0x20ED001 VA: 0x20ECF00
	private static void .cctor() { }
}

