// Namespace: App
public class ProfileCardMyCardMenu : ProcInst // TypeDefIndex: 11599
{
	// Fields
	private ProfileCardMyCardMenu.DecideEventHandler m_DecideEventHandler; // 0x70
	private ProfileCardRoot m_Root; // 0x78
	private ProfileCard m_MyProfileCardTemp; // 0x80
	private BasicMenu.Result m_result; // 0x88
	private bool m_NeededUpdateCardOnBuild; // 0x8C
	private bool m_CloseCalled; // 0x8D

	// Methods

	// RVA: 0x2817CB0 Offset: 0x2817DB1 VA: 0x2817CB0
	public static ProfileCardMyCardMenu CreateBind(ProcInst super, ProfileCardRoot profiledCardRoot, ProfileCard myProfileCardTemp, bool neededUpdateCardOnBuild, ProfileCardMyCardMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2817E30 Offset: 0x2817F31 VA: 0x2817E30
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2817DA0 Offset: 0x2817EA1 VA: 0x2817DA0
	private void .ctor(ProfileCardRoot menuRoot, ProfileCard myProfileCardTemp, bool neededUpdateCardOnBuild, ProfileCardMyCardMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x28180B0 Offset: 0x28181B1 VA: 0x28180B0
	private void AfterBuild() { }

	// RVA: 0x28180D0 Offset: 0x28181D1 VA: 0x28180D0
	public string GetName() { }

	// RVA: 0x2818120 Offset: 0x2818221 VA: 0x2818120 Slot: 18
	public virtual void OpenAnime() { }

	// RVA: 0x2818130 Offset: 0x2818231 VA: 0x2818130
	private void Tick() { }

	// RVA: 0x28182C0 Offset: 0x28183C1 VA: 0x28182C0 Slot: 19
	protected virtual bool TickInput() { }

	// RVA: 0x2818220 Offset: 0x2818321 VA: 0x2818220
	private bool IsSwitchingPages() { }

	// RVA: 0x2818A80 Offset: 0x2818B81 VA: 0x2818A80
	private void Close() { }

	// RVA: 0x2818210 Offset: 0x2818311 VA: 0x2818210
	private bool IsClosing() { }

	// RVA: 0x2818AA0 Offset: 0x2818BA1 VA: 0x2818AA0
	private bool IsClosed() { }

	// RVA: 0x28189B0 Offset: 0x2818AB1 VA: 0x28189B0
	private BasicMenu.Result ACall() { }

	// RVA: 0x28189E0 Offset: 0x2818AE1 VA: 0x28189E0
	private BasicMenu.Result BCall() { }

	// RVA: 0x2818A10 Offset: 0x2818B11 VA: 0x2818A10
	private BasicMenu.Result XCall() { }

	// RVA: 0x2818A40 Offset: 0x2818B41 VA: 0x2818A40
	private BasicMenu.Result LCall() { }

	// RVA: 0x2818A60 Offset: 0x2818B61 VA: 0x2818A60
	private BasicMenu.Result RCall() { }

	// RVA: 0x2818A90 Offset: 0x2818B91 VA: 0x2818A90
	private void OnClose() { }

	// RVA: 0x2818AB0 Offset: 0x2818BB1 VA: 0x2818AB0 Slot: 10
	protected override void OnDispose() { }
}

