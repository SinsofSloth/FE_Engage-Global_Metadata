// Namespace: App
public class ProfileCardAlbumMenu : ProcInst // TypeDefIndex: 11559
{
	// Fields
	private ProfileCardAlbumMenu.ChangeProfileEventHandler m_ChangeProfileEventHandler; // 0x70
	private ProfileCardAlbumMenu.DecideEventHandler m_DecideEventHandler; // 0x78
	private ProfileCardRoot m_CardRoot; // 0x80
	private int m_ProfileListIndex; // 0x88
	private ProfileCard m_ProfileCard; // 0x90
	private BasicMenu.Result m_result; // 0x98
	private bool m_CloseCalled; // 0x9C

	// Methods

	// RVA: 0x2805CB0 Offset: 0x2805DB1 VA: 0x2805CB0
	public static ProfileCardAlbumMenu CreateBind(ProcInst super, ProfileCardRoot profiledCardRoot, int initialProfileListIndex, ProfileCardAlbumMenu.ChangeProfileEventHandler changeProfileEventHandler, ProfileCardAlbumMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2805EB0 Offset: 0x2805FB1 VA: 0x2805EB0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2805D60 Offset: 0x2805E61 VA: 0x2805D60
	private void .ctor(ProfileCardRoot cardRoot, int initialProfileListIndex, ProfileCardAlbumMenu.ChangeProfileEventHandler changeProfileEventHandler, ProfileCardAlbumMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2807100 Offset: 0x2807201 VA: 0x2807100
	public string GetName() { }

	// RVA: 0x2807150 Offset: 0x2807251 VA: 0x2807150 Slot: 18
	public virtual void OpenAnime() { }

	// RVA: 0x2807160 Offset: 0x2807261 VA: 0x2807160
	private void Tick() { }

	// RVA: 0x28072F0 Offset: 0x28073F1 VA: 0x28072F0 Slot: 19
	protected virtual bool TickInput() { }

	// RVA: 0x2807250 Offset: 0x2807351 VA: 0x2807250
	private bool IsSwitchingPages() { }

	// RVA: 0x2808490 Offset: 0x2808591 VA: 0x2808490
	private void Close() { }

	// RVA: 0x2807240 Offset: 0x2807341 VA: 0x2807240
	private bool IsClosing() { }

	// RVA: 0x28085E0 Offset: 0x28086E1 VA: 0x28085E0
	private bool IsClosed() { }

	// RVA: 0x28081D0 Offset: 0x28082D1 VA: 0x28081D0
	private void KeyUp(bool isTrigger) { }

	// RVA: 0x2808330 Offset: 0x2808431 VA: 0x2808330
	private void KeyDown(bool isTrigger) { }

	// RVA: 0x2808120 Offset: 0x2808221 VA: 0x2808120
	private BasicMenu.Result ACall() { }

	// RVA: 0x2808160 Offset: 0x2808261 VA: 0x2808160
	private BasicMenu.Result XCall() { }

	// RVA: 0x2808130 Offset: 0x2808231 VA: 0x2808130
	private BasicMenu.Result BCall() { }

	// RVA: 0x2808190 Offset: 0x2808291 VA: 0x2808190
	private BasicMenu.Result LCall() { }

	// RVA: 0x28081B0 Offset: 0x28082B1 VA: 0x28081B0
	private BasicMenu.Result RCall() { }

	// RVA: 0x28085D0 Offset: 0x28086D1 VA: 0x28085D0
	private void OnClose() { }

	// RVA: 0x28087B0 Offset: 0x28088B1 VA: 0x28087B0 Slot: 10
	protected override void OnDispose() { }
}

