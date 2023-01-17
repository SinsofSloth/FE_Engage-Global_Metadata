// Namespace: 
private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 772
{
	// Methods

	// RVA: 0x35EFFB0 Offset: 0x35F00B1 VA: 0x35EFFB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35EFFD0 Offset: 0x35F00D1 VA: 0x35EFFD0 Slot: 13
	public virtual void Invoke(IntPtr arg) { }

	// RVA: 0x35F0200 Offset: 0x35F0301 VA: 0x35F0200 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	// RVA: 0x35F0290 Offset: 0x35F0391 VA: 0x35F0290 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 774
{
	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x35EFF50 Offset: 0x35F0051 VA: 0x35EFF50
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x35EFFA0 Offset: 0x35F00A1 VA: 0x35EFFA0
	public void Invoke() { }
}

