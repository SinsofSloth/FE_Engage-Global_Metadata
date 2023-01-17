// Namespace: 
public enum ProfileCardSelectEditMenu.Result2 // TypeDefIndex: 11612
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardSelectEditMenu.Result2 Title = 0;
	public const ProfileCardSelectEditMenu.Result2 Comment = 1;
	public const ProfileCardSelectEditMenu.Result2 Character = 2;
	public const ProfileCardSelectEditMenu.Result2 RelayMap = 3;
	public const ProfileCardSelectEditMenu.Result2 Bg = 4;
	public const ProfileCardSelectEditMenu.Result2 Frame = 5;
	public const ProfileCardSelectEditMenu.Result2 TextDeco = 6;
	public const ProfileCardSelectEditMenu.Result2 TextColor = 7;
	public const ProfileCardSelectEditMenu.Result2 CharacterStamp = 8;
	public const ProfileCardSelectEditMenu.Result2 Stamp = 9;
	public const ProfileCardSelectEditMenu.Result2 End = 10;
	public const ProfileCardSelectEditMenu.Result2 Num = 10;
}

// Namespace: 
public sealed class ProfileCardSelectEditMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11613
{
	// Methods

	// RVA: 0x1F25FB0 Offset: 0x1F260B1 VA: 0x1F25FB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F25FD0 Offset: 0x1F260D1 VA: 0x1F25FD0 Slot: 13
	public virtual void Invoke(ProfileCardSelectEditMenu.Result2 result) { }

	// RVA: 0x1F26230 Offset: 0x1F26331 VA: 0x1F26230 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProfileCardSelectEditMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1F262C0 Offset: 0x1F263C1 VA: 0x1F262C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ProfileCardSelectEditMenu.DisposeEventHandler : MulticastDelegate // TypeDefIndex: 11614
{
	// Methods

	// RVA: 0x1F262D0 Offset: 0x1F263D1 VA: 0x1F262D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F262F0 Offset: 0x1F263F1 VA: 0x1F262F0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F26500 Offset: 0x1F26601 VA: 0x1F26500 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F26530 Offset: 0x1F26631 VA: 0x1F26530 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ProfileCardSelectEditMenu.ProfileCardSelectEditMenuItem : BasicMenuItem // TypeDefIndex: 11615
{
	// Fields
	private ProfileCardSelectEditMenu.Result2 m_Result2; // 0x64
	private ProfileCardSelectEditMenu.DecideEventHandler m_DecideEventHandler; // 0x68
	private readonly string[] m_NameMid; // 0x70

	// Methods

	// RVA: 0x1F26540 Offset: 0x1F26641 VA: 0x1F26540
	public void .ctor(ProfileCardSelectEditMenu.Result2 result2, ProfileCardSelectEditMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F26A10 Offset: 0x1F26B11 VA: 0x1F26A10 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F26A20 Offset: 0x1F26B21 VA: 0x1F26A20 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F26BF0 Offset: 0x1F26CF1 VA: 0x1F26BF0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x1F26A50 Offset: 0x1F26B51 VA: 0x1F26A50
	public void SetBlinkOnProfileCardRoot(bool on) { }

	// RVA: 0x1F26C20 Offset: 0x1F26D21 VA: 0x1F26C20 Slot: 18
	public override BasicMenu.Result ACall() { }
}

