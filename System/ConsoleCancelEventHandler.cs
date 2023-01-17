// Namespace: System
public sealed class ConsoleCancelEventHandler : MulticastDelegate // TypeDefIndex: 185
{
	// Methods

	// RVA: 0x33AFFE0 Offset: 0x33B00E1 VA: 0x33AFFE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x33AFC20 Offset: 0x33AFD21 VA: 0x33AFC20 Slot: 13
	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

	// RVA: 0x33B0000 Offset: 0x33B0101 VA: 0x33B0000 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ConsoleCancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x33B0030 Offset: 0x33B0131 VA: 0x33B0030 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

