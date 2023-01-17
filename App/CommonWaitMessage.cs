// Namespace: App
public class CommonWaitMessage : ProcWaitMessageBase // TypeDefIndex: 12529
{
	// Fields
	private bool m_IsLoopSE; // 0x78
	private bool m_IsPlaySE; // 0x79
	private static CommonWaitMessage s_Instance; // 0x0

	// Methods

	// RVA: 0x23B1DC0 Offset: 0x23B1EC1 VA: 0x23B1DC0
	public static void Open(string msg, bool isPlaySound = True, bool isHideWaitAnime = False) { }

	// RVA: 0x23B2150 Offset: 0x23B2251 VA: 0x23B2150
	public static void Close(bool isSuccess = True) { }

	// RVA: 0x23B2260 Offset: 0x23B2361 VA: 0x23B2260
	public static bool IsAlive() { }

	// RVA: 0x23B21F0 Offset: 0x23B22F1 VA: 0x23B21F0
	private void .ctor(bool isPlaySound) { }

	// RVA: 0x23B2360 Offset: 0x23B2461 VA: 0x23B2360 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23B2340 Offset: 0x23B2441 VA: 0x23B2340
	private void PlayLoopSE() { }

	// RVA: 0x23B2240 Offset: 0x23B2341 VA: 0x23B2240
	private void StopLoopSE() { }

	// RVA: 0x23B2250 Offset: 0x23B2351 VA: 0x23B2250
	private void PlayResultSE(bool isSuccess) { }
}

