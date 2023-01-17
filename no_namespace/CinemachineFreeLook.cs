// Namespace: 
public sealed class CinemachineFreeLook.CreateRigDelegate : MulticastDelegate // TypeDefIndex: 5755
{
	// Methods

	// RVA: 0x1A89690 Offset: 0x1A89791 VA: 0x1A89690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A896B0 Offset: 0x1A897B1 VA: 0x1A896B0 Slot: 13
	public virtual CinemachineVirtualCamera Invoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A89A50 Offset: 0x1A89B51 VA: 0x1A89A50 Slot: 14
	public virtual IAsyncResult BeginInvoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom, AsyncCallback callback, object object) { }

	// RVA: 0x1A89A80 Offset: 0x1A89B81 VA: 0x1A89A80 Slot: 15
	public virtual CinemachineVirtualCamera EndInvoke(IAsyncResult result) { }
}

