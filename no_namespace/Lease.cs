// Namespace: 
private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 1127
{
	// Methods

	// RVA: 0x35ED8B0 Offset: 0x35ED9B1 VA: 0x35ED8B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35ED8D0 Offset: 0x35ED9D1 VA: 0x35ED8D0 Slot: 13
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x35EDC30 Offset: 0x35EDD31 VA: 0x35EDC30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x35EDC60 Offset: 0x35EDD61 VA: 0x35EDC60 Slot: 15
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }
}

