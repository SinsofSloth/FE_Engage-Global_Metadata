// Namespace: 
public enum ProfileCardAlbumMenu.Result2 // TypeDefIndex: 11556
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardAlbumMenu.Result2 List = 0;
	public const ProfileCardAlbumMenu.Result2 Cancel = 1;
}

// Namespace: 
public sealed class ProfileCardAlbumMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11558
{
	// Methods

	// RVA: 0x1F225E0 Offset: 0x1F226E1 VA: 0x1F225E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F22600 Offset: 0x1F22701 VA: 0x1F22600 Slot: 13
	public virtual void Invoke(ProfileCardAlbumMenu.Result2 result2) { }

	// RVA: 0x1F22860 Offset: 0x1F22961 VA: 0x1F22860 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProfileCardAlbumMenu.Result2 result2, AsyncCallback callback, object object) { }

	// RVA: 0x1F228F0 Offset: 0x1F229F1 VA: 0x1F228F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

