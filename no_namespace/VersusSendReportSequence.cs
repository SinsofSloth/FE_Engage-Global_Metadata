// Namespace: 
public sealed class VersusSendReportSequence.EndCallback : MulticastDelegate // TypeDefIndex: 13733
{
	// Methods

	// RVA: 0x1EE3140 Offset: 0x1EE3241 VA: 0x1EE3140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EE3160 Offset: 0x1EE3261 VA: 0x1EE3160 Slot: 13
	public virtual void Invoke(bool isSucceed) { }

	// RVA: 0x1EE3390 Offset: 0x1EE3491 VA: 0x1EE3390 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isSucceed, AsyncCallback callback, object object) { }

	// RVA: 0x1EE3430 Offset: 0x1EE3531 VA: 0x1EE3430 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

