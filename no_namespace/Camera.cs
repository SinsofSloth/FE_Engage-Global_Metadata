// Namespace: 
public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 3413
{
	// Methods

	// RVA: 0x3852FD0 Offset: 0x38530D1 VA: 0x3852FD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3852FF0 Offset: 0x38530F1 VA: 0x3852FF0 Slot: 13
	public virtual void Invoke(Camera cam) { }

	// RVA: 0x3853350 Offset: 0x3853451 VA: 0x3853350 Slot: 14
	public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

	// RVA: 0x3853380 Offset: 0x3853481 VA: 0x3853380 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

