// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseManager // TypeDefIndex: 1129
{
	// Fields
	private ArrayList _objects; // 0x10
	private Timer _timer; // 0x18

	// Methods

	// RVA: 0x341D1A0 Offset: 0x341D2A1 VA: 0x341D1A0
	public void SetPollTime(TimeSpan timeSpan) { }

	// RVA: 0x341D2A0 Offset: 0x341D3A1 VA: 0x341D2A0
	public void TrackLifetime(ServerIdentity identity) { }

	// RVA: 0x341D3C0 Offset: 0x341D4C1 VA: 0x341D3C0
	public void StartManager() { }

	// RVA: 0x341D570 Offset: 0x341D671 VA: 0x341D570
	public void StopManager() { }

	// RVA: 0x341D5B0 Offset: 0x341D6B1 VA: 0x341D5B0
	public void ManageLeases(object state) { }

	// RVA: 0x341D7D0 Offset: 0x341D8D1 VA: 0x341D7D0
	public void .ctor() { }
}

