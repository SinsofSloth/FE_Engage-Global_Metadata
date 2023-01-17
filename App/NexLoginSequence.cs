// Namespace: App
internal class NexLoginSequence : ProcInst // TypeDefIndex: 12735
{
	// Fields
	private bool m_IsShowError; // 0x70
	private static NexLoginSequence.Result s_LastResult; // 0x0
	private static bool s_IsGotIntegerSettings; // 0x4

	// Properties
	public static NexLoginSequence.Result LastResult { get; }

	// Methods

	// RVA: 0x2355FA0 Offset: 0x23560A1 VA: 0x2355FA0
	private void .ctor(bool isShowError) { }

	// RVA: 0x2355FD0 Offset: 0x23560D1 VA: 0x2355FD0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x23560A0 Offset: 0x23561A1 VA: 0x23560A0
	private void WaitAutoLogout() { }

	// RVA: 0x23560E0 Offset: 0x23561E1 VA: 0x23560E0
	private void InitializeNex() { }

	// RVA: 0x2356380 Offset: 0x2356481 VA: 0x2356380
	private void SetupNetworkServiceAccount() { }

	// RVA: 0x2356450 Offset: 0x2356551 VA: 0x2356450
	private void LoginGameServer() { }

	// RVA: 0x2356630 Offset: 0x2356731 VA: 0x2356630
	private void GetIntegerSettings() { }

	// RVA: 0x2356790 Offset: 0x2356891 VA: 0x2356790
	private void ResultSucceeded() { }

	// RVA: 0x2356800 Offset: 0x2356901 VA: 0x2356800
	private void ResultCancelled() { }

	// RVA: 0x2356870 Offset: 0x2356971 VA: 0x2356870
	private void ResultFailed() { }

	// RVA: 0x23568E0 Offset: 0x23569E1 VA: 0x23568E0
	private void ShowError() { }

	// RVA: 0x23569D0 Offset: 0x2356AD1 VA: 0x23569D0
	private void Cleanup() { }

	// RVA: 0x2352590 Offset: 0x2352691 VA: 0x2352590
	public static void CreateBind(ProcInst super, bool isShowError = True) { }

	// RVA: 0x2356AD0 Offset: 0x2356BD1 VA: 0x2356AD0
	public static NexLoginSequence.Result get_LastResult() { }

	// RVA: 0x2356B40 Offset: 0x2356C41 VA: 0x2356B40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA000 Offset: 0x2CA101 VA: 0x2CA000
	// RVA: 0x2356BA0 Offset: 0x2356CA1 VA: 0x2356BA0
	private void <InitializeNex>b__8_0(AsyncResult asyncResult) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA010 Offset: 0x2CA111 VA: 0x2CA010
	// RVA: 0x2356CE0 Offset: 0x2356DE1 VA: 0x2356CE0
	private void <SetupNetworkServiceAccount>b__9_0(Account.SetupNsaResult result) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA020 Offset: 0x2CA121 VA: 0x2CA020
	// RVA: 0x2356E00 Offset: 0x2356F01 VA: 0x2356E00
	private void <LoginGameServer>b__10_0(AsyncResult asyncResult) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA030 Offset: 0x2CA131 VA: 0x2CA030
	// RVA: 0x2356F40 Offset: 0x2357041 VA: 0x2356F40
	private void <GetIntegerSettings>b__11_0(AsyncResult asyncResult, Dictionary<ushort, int> integerSettings) { }
}

