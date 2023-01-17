// Namespace: App
public abstract class ProcWaitMessageBase : ProcInst // TypeDefIndex: 12528
{
	// Fields
	protected GameMessage m_GameMessage; // 0x70

	// Methods

	// RVA: 0x29E6220 Offset: 0x29E6321 VA: 0x29E6220
	public void .ctor() { }

	// RVA: 0x29E6230 Offset: 0x29E6331 VA: 0x29E6230
	public void MessageOpenKeyWait(string msg) { }

	// RVA: 0x29E62F0 Offset: 0x29E63F1 VA: 0x29E62F0
	public void MessageOpenSystemWait(string msg, bool isHideWaitAnime = False) { }

	// RVA: 0x29E6370 Offset: 0x29E6471 VA: 0x29E6370
	public void MessageClose() { }

	// RVA: 0x29E62A0 Offset: 0x29E63A1 VA: 0x29E62A0
	public void MessageDelete() { }

	// RVA: 0x29E63A0 Offset: 0x29E64A1 VA: 0x29E63A0
	public bool MessageIsWaitToOpen() { }

	// RVA: 0x29E63D0 Offset: 0x29E64D1 VA: 0x29E63D0
	public bool MessageIsWaitToClose() { }
}

