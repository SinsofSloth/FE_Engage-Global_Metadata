// Namespace: 
public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3417
{
	// Methods

	// RVA: 0x38533B0 Offset: 0x38534B1 VA: 0x38533B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x38533D0 Offset: 0x38534D1 VA: 0x38533D0 Slot: 13
	public virtual void Invoke(CullingGroupEvent sphere) { }

	// RVA: 0x3853620 Offset: 0x3853721 VA: 0x3853620 Slot: 14
	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	// RVA: 0x38536B0 Offset: 0x38537B1 VA: 0x38536B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

