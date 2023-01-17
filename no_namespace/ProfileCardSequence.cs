// Namespace: 
public sealed class ProfileCardSequence.DisposeEventHandler : MulticastDelegate // TypeDefIndex: 11618
{
	// Methods

	// RVA: 0x1F26E40 Offset: 0x1F26F41 VA: 0x1F26E40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F26E60 Offset: 0x1F26F61 VA: 0x1F26E60 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F27070 Offset: 0x1F27171 VA: 0x1F27070 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F270A0 Offset: 0x1F271A1 VA: 0x1F270A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum ProfileCardSequence.Label // TypeDefIndex: 11619
{
	// Fields
	public int value__; // 0x0
	public const ProfileCardSequence.Label Entry = 0;
	public const ProfileCardSequence.Label Top = 1;
	public const ProfileCardSequence.Label MyCard = 2;
	public const ProfileCardSequence.Label MyCardMain = 3;
	public const ProfileCardSequence.Label MyCardSave = 4;
	public const ProfileCardSequence.Label MyCardEnd = 5;
	public const ProfileCardSequence.Label SelectEdit = 6;
	public const ProfileCardSequence.Label Title = 7;
	public const ProfileCardSequence.Label Comment = 8;
	public const ProfileCardSequence.Label CommentList = 9;
	public const ProfileCardSequence.Label Character = 10;
	public const ProfileCardSequence.Label RelayMap = 11;
	public const ProfileCardSequence.Label Bg = 12;
	public const ProfileCardSequence.Label Frame = 13;
	public const ProfileCardSequence.Label TextDeco = 14;
	public const ProfileCardSequence.Label TextColor = 15;
	public const ProfileCardSequence.Label CharacterStamp = 16;
	public const ProfileCardSequence.Label Stamp = 17;
	public const ProfileCardSequence.Label Album = 18;
	public const ProfileCardSequence.Label AlbumMain = 19;
	public const ProfileCardSequence.Label AlbumList = 20;
	public const ProfileCardSequence.Label AlbumEnd = 21;
	public const ProfileCardSequence.Label Photo = 22;
	public const ProfileCardSequence.Label PublicSetting = 23;
	public const ProfileCardSequence.Label StampVisibilitySetting = 24;
	public const ProfileCardSequence.Label End = 25;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277A00 Offset: 0x277B01 VA: 0x277A00
private sealed class ProfileCardSequence.<>c__DisplayClass36_0 // TypeDefIndex: 11620
{
	// Fields
	public ProfileCardRoot profileCardRoot; // 0x10
	public ProfileCardSequence <>4__this; // 0x18

	// Methods

	// RVA: 0x1F26D40 Offset: 0x1F26E41 VA: 0x1F26D40
	public void .ctor() { }

	// RVA: 0x1F26D50 Offset: 0x1F26E51 VA: 0x1F26D50
	internal void <CreateMyCardRoot>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277A10 Offset: 0x277B11 VA: 0x277A10
[Serializable]
private sealed class ProfileCardSequence.<>c // TypeDefIndex: 11621
{
	// Fields
	public static readonly ProfileCardSequence.<>c <>9; // 0x0
	public static ProfileCardVisualMenu.DecideEventHandler <>9__47_0; // 0x8
	public static ProfileCardVisualMenu.DecideEventHandler <>9__48_0; // 0x10
	public static ProfileCardVisualMenu.DecideEventHandler <>9__49_0; // 0x18
	public static ProfileCardVisualMenu.DecideEventHandler <>9__50_0; // 0x20
	public static ProfileCardVisualMenu.DecideEventHandler <>9__51_0; // 0x28

	// Methods

	// RVA: 0x1F26C70 Offset: 0x1F26D71 VA: 0x1F26C70
	private static void .cctor() { }

	// RVA: 0x1F26CE0 Offset: 0x1F26DE1 VA: 0x1F26CE0
	public void .ctor() { }

	// RVA: 0x1F26CF0 Offset: 0x1F26DF1 VA: 0x1F26CF0
	internal void <CreateBgMenu>b__47_0(ProfileCardVisualMenu.Category category, string id) { }

	// RVA: 0x1F26D00 Offset: 0x1F26E01 VA: 0x1F26D00
	internal void <CreateFrameMenu>b__48_0(ProfileCardVisualMenu.Category category, string id) { }

	// RVA: 0x1F26D10 Offset: 0x1F26E11 VA: 0x1F26D10
	internal void <CreateTextDecoMenu>b__49_0(ProfileCardVisualMenu.Category category, string id) { }

	// RVA: 0x1F26D20 Offset: 0x1F26E21 VA: 0x1F26D20
	internal void <CreateTextColorMenu>b__50_0(ProfileCardVisualMenu.Category category, string id) { }

	// RVA: 0x1F26D30 Offset: 0x1F26E31 VA: 0x1F26D30
	internal void <CreateCharacterStampMenu>b__51_0(ProfileCardVisualMenu.Category category, string id) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277A20 Offset: 0x277B21 VA: 0x277A20
private sealed class ProfileCardSequence.<>c__DisplayClass63_0 // TypeDefIndex: 11622
{
	// Fields
	public ProfileCardRoot profileCardRoot; // 0x10
	public ProfileCard profileList0; // 0x18

	// Methods

	// RVA: 0x1F26D80 Offset: 0x1F26E81 VA: 0x1F26D80
	public void .ctor() { }

	// RVA: 0x1F26D90 Offset: 0x1F26E91 VA: 0x1F26D90
	internal void <CreateAlbumRoot>b__0() { }
}

