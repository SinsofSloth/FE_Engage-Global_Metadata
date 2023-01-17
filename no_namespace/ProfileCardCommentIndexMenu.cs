// Namespace: 
public enum ProfileCardCommentIndexMenu.Result2 // TypeDefIndex: 11561
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardCommentIndexMenu.Result2 Decide = 0;
	public const ProfileCardCommentIndexMenu.Result2 Cancel = 1;
}

// Namespace: 
public sealed class ProfileCardCommentIndexMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11562
{
	// Methods

	// RVA: 0x1F22900 Offset: 0x1F22A01 VA: 0x1F22900
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F22920 Offset: 0x1F22A21 VA: 0x1F22920 Slot: 13
	public virtual void Invoke(ProfileCardCommentIndexMenu.Result2 result, int index) { }

	// RVA: 0x1F22B90 Offset: 0x1F22C91 VA: 0x1F22B90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProfileCardCommentIndexMenu.Result2 result, int index, AsyncCallback callback, object object) { }

	// RVA: 0x1F22C50 Offset: 0x1F22D51 VA: 0x1F22C50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ProfileCardCommentIndexMenu.DisposeEventHandler : MulticastDelegate // TypeDefIndex: 11563
{
	// Methods

	// RVA: 0x1F22C60 Offset: 0x1F22D61 VA: 0x1F22C60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F22C80 Offset: 0x1F22D81 VA: 0x1F22C80 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F22E90 Offset: 0x1F22F91 VA: 0x1F22E90 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F22EC0 Offset: 0x1F22FC1 VA: 0x1F22EC0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

