// Namespace: nn.os
public sealed class UserExceptionHandler : MulticastDelegate // TypeDefIndex: 14531
{
	// Methods

	// RVA: 0x20AAF50 Offset: 0x20AB051 VA: 0x20AAF50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x20AAF70 Offset: 0x20AB071 VA: 0x20AAF70 Slot: 13
	public virtual void Invoke(string exceptionInfo) { }

	// RVA: 0x20AB2D0 Offset: 0x20AB3D1 VA: 0x20AB2D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string exceptionInfo, AsyncCallback callback, object object) { }

	// RVA: 0x20AB300 Offset: 0x20AB401 VA: 0x20AB300 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

