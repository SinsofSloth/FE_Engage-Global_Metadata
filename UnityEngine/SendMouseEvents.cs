// Namespace: UnityEngine
internal class SendMouseEvents // TypeDefIndex: 4044
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x77A80 Offset: 0x77B81 VA: 0x77A80
	// RVA: 0x1C62A80 Offset: 0x1C62B81 VA: 0x1C62A80
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x77A90 Offset: 0x77B91 VA: 0x77A90
	// RVA: 0x1C62AF0 Offset: 0x1C62BF1 VA: 0x1C62AF0
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x1C634D0 Offset: 0x1C635D1 VA: 0x1C634D0
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x1C63B90 Offset: 0x1C63C91 VA: 0x1C63B90
	private static void .cctor() { }
}

