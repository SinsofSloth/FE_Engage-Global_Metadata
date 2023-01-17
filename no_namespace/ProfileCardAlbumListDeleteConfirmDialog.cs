// Namespace: 
public sealed class ProfileCardAlbumListDeleteConfirmDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 11546
{
	// Methods

	// RVA: 0x1F21030 Offset: 0x1F21131 VA: 0x1F21030
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F21050 Offset: 0x1F21151 VA: 0x1F21050 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F21260 Offset: 0x1F21361 VA: 0x1F21260 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F21290 Offset: 0x1F21391 VA: 0x1F21290 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ProfileCardAlbumListDeleteConfirmDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11547
{
	// Fields
	private ProfileCardAlbumListDeleteConfirmDialog.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x1F212A0 Offset: 0x1F213A1 VA: 0x1F212A0
	public void .ctor(string message, ProfileCardAlbumListDeleteConfirmDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x1F212E0 Offset: 0x1F213E1 VA: 0x1F212E0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

