// Namespace: 
public sealed class ProfileCardAlbumListMenuOverLimit.CancelEventHandler : MulticastDelegate // TypeDefIndex: 11551
{
	// Methods

	// RVA: 0x1F21D30 Offset: 0x1F21E31 VA: 0x1F21D30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F21D50 Offset: 0x1F21E51 VA: 0x1F21D50 Slot: 13
	public virtual BasicMenu.Result Invoke(ProcInst super) { }

	// RVA: 0x1F220B0 Offset: 0x1F221B1 VA: 0x1F220B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProcInst super, AsyncCallback callback, object object) { }

	// RVA: 0x1F220E0 Offset: 0x1F221E1 VA: 0x1F220E0 Slot: 15
	public virtual BasicMenu.Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ProfileCardAlbumListMenuOverLimit.ProfileCardAlbumListMenuOverLimitItem : BasicMenuItem // TypeDefIndex: 11552
{
	// Fields
	private ProfileCard m_Profile; // 0x68
	private readonly ProfileCardAlbumListMenuOverLimit.CancelEventHandler m_CancelEventHandler; // 0x70

	// Properties
	public ProfileCard Profile { get; }

	// Methods

	// RVA: 0x1F22110 Offset: 0x1F22211 VA: 0x1F22110
	public void .ctor(ProfileCard profile, ProfileCardAlbumListMenuOverLimit.CancelEventHandler cancelEventHandler) { }

	// RVA: 0x1F22180 Offset: 0x1F22281 VA: 0x1F22180 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x1F22190 Offset: 0x1F22291 VA: 0x1F22190 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F22230 Offset: 0x1F22331 VA: 0x1F22230 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F222D0 Offset: 0x1F223D1 VA: 0x1F222D0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1F222E0 Offset: 0x1F223E1 VA: 0x1F222E0
	public ProfileCard get_Profile() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277950 Offset: 0x277A51 VA: 0x277950
private struct ProfileCardAlbumListMenuOverLimit.<>c__DisplayClass6_0 // TypeDefIndex: 11553
{
	// Fields
	public ProfileList profileList; // 0x0
	public List<BasicMenuItem> menuItemList; // 0x8
	public ProfileCardAlbumListMenuOverLimit.CancelEventHandler cancelEventHandler; // 0x10
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277960 Offset: 0x277A61 VA: 0x277960
private sealed class ProfileCardAlbumListMenuOverLimit.<>c__DisplayClass12_0 // TypeDefIndex: 11554
{
	// Fields
	public ProfileCardAlbumListMenuOverLimit <>4__this; // 0x10
	public ProfileCard profile; // 0x18

	// Methods

	// RVA: 0x1F21C80 Offset: 0x1F21D81 VA: 0x1F21C80
	public void .ctor() { }

	// RVA: 0x1F21C90 Offset: 0x1F21D91 VA: 0x1F21C90
	internal void <RemoveProfileCard>b__0() { }
}

