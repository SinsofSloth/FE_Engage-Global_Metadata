// Namespace: 
public sealed class ProfileCardVisualMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11665
{
	// Methods

	// RVA: 0x1F29900 Offset: 0x1F29A01 VA: 0x1F29900
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F29920 Offset: 0x1F29A21 VA: 0x1F29920 Slot: 13
	public virtual void Invoke(ProfileCardVisualMenu.Category category, string id) { }

	// RVA: 0x1F29B90 Offset: 0x1F29C91 VA: 0x1F29B90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProfileCardVisualMenu.Category category, string id, AsyncCallback callback, object object) { }

	// RVA: 0x1F29C30 Offset: 0x1F29D31 VA: 0x1F29C30 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

