// Namespace: 
public enum ProfileCardMyCardMenu.Result2 // TypeDefIndex: 11597
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardMyCardMenu.Result2 Edit = 0;
	public const ProfileCardMyCardMenu.Result2 Save = 1;
	public const ProfileCardMyCardMenu.Result2 Cancel = 2;
}

// Namespace: 
public sealed class ProfileCardMyCardMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11598
{
	// Methods

	// RVA: 0x1F250A0 Offset: 0x1F251A1 VA: 0x1F250A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F250C0 Offset: 0x1F251C1 VA: 0x1F250C0 Slot: 13
	public virtual void Invoke(ProfileCardMyCardMenu.Result2 result2) { }

	// RVA: 0x1F25320 Offset: 0x1F25421 VA: 0x1F25320 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProfileCardMyCardMenu.Result2 result2, AsyncCallback callback, object object) { }

	// RVA: 0x1F253B0 Offset: 0x1F254B1 VA: 0x1F253B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

