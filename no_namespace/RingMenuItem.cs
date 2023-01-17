// Namespace: 
public sealed class RingMenuItem.SelectEventHandler : MulticastDelegate // TypeDefIndex: 11173
{
	// Methods

	// RVA: 0x1F55920 Offset: 0x1F55A21 VA: 0x1F55920
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F55940 Offset: 0x1F55A41 VA: 0x1F55940 Slot: 13
	public virtual void Invoke(RingData ringData) { }

	// RVA: 0x1F55CA0 Offset: 0x1F55DA1 VA: 0x1F55CA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(RingData ringData, AsyncCallback callback, object object) { }

	// RVA: 0x1F55CD0 Offset: 0x1F55DD1 VA: 0x1F55CD0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

