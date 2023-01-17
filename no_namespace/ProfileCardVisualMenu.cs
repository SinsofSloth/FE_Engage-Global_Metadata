// Namespace: 
public enum ProfileCardVisualMenu.Category // TypeDefIndex: 11664
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardVisualMenu.Category Bg = 0;
	public const ProfileCardVisualMenu.Category Frame = 1;
	public const ProfileCardVisualMenu.Category TextDeco = 2;
	public const ProfileCardVisualMenu.Category TextColor = 3;
	public const ProfileCardVisualMenu.Category CharacterStamp = 4;
	public const ProfileCardVisualMenu.Category Num = 5;
}

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

// Namespace: 
public sealed class ProfileCardVisualMenu.DisposeEventHandler : MulticastDelegate // TypeDefIndex: 11666
{
	// Methods

	// RVA: 0x1F29C40 Offset: 0x1F29D41 VA: 0x1F29C40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F29C60 Offset: 0x1F29D61 VA: 0x1F29C60 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F29E70 Offset: 0x1F29F71 VA: 0x1F29E70 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F29EA0 Offset: 0x1F29FA1 VA: 0x1F29EA0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

