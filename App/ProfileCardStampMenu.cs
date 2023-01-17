// Namespace: App
public class ProfileCardStampMenu : ProcInst // TypeDefIndex: 11638
{
	// Fields
	private ProfileCardStampRoot m_StampRoot; // 0x70
	private ProfileCardRoot m_CardRoot; // 0x78
	private ProfileCardStampListMenuContent m_StampListMenuContent; // 0x80
	private BasicMenu.Result m_result; // 0x88
	private bool m_CloseCalled; // 0x8C
	private ProfileCard m_MyProfileCardTemp; // 0x90
	private List<ProfileCard.FreeStamp>[] m_FreeStampTempListArray; // 0x98
	private ProfileCardStampData m_CurrentStampData; // 0xA0
	private ProfileCardStampData m_StackStampData; // 0xA8
	private ProfileCard.FreeStamp m_HoldingStamp; // 0xB0
	private int m_OverlappedStampIndex; // 0xB8
	private bool m_IsFront; // 0xBC
	private ProfileCardStampMenu.DisposeEventHandler m_DisposeEventHandler; // 0xC0
	private ProfileCardStampMenu.EditMode m_EditMode; // 0xC8
	private int m_ArrowKeyRepeatTime; // 0xCC

	// Properties
	private static int m_StampSpeed { get; }
	private static float m_StampRotationDiff { get; }
	private static float m_StampScaleDiff { get; }
	private static float m_StampScaleMin { get; }
	private static float m_StampScaleMax { get; }
	private static float m_StickSpeedUpRate { get; }
	private static float m_ArrowKeySpeedUpRate { get; }
	private static float m_StickL_Allowance { get; }
	private static float m_StickR_Allowance { get; }

	// Methods

	// RVA: 0x2ED8C70 Offset: 0x2ED8D71 VA: 0x2ED8C70
	private static int get_m_StampSpeed() { }

	// RVA: 0x2ED8CC0 Offset: 0x2ED8DC1 VA: 0x2ED8CC0
	private static float get_m_StampRotationDiff() { }

	// RVA: 0x2ED8D10 Offset: 0x2ED8E11 VA: 0x2ED8D10
	private static float get_m_StampScaleDiff() { }

	// RVA: 0x2ED8D60 Offset: 0x2ED8E61 VA: 0x2ED8D60
	private static float get_m_StampScaleMin() { }

	// RVA: 0x2ED8DB0 Offset: 0x2ED8EB1 VA: 0x2ED8DB0
	private static float get_m_StampScaleMax() { }

	// RVA: 0x2ED8E00 Offset: 0x2ED8F01 VA: 0x2ED8E00
	private static float get_m_StickSpeedUpRate() { }

	// RVA: 0x2ED8E50 Offset: 0x2ED8F51 VA: 0x2ED8E50
	private static float get_m_ArrowKeySpeedUpRate() { }

	// RVA: 0x2ED8EA0 Offset: 0x2ED8FA1 VA: 0x2ED8EA0
	private static float get_m_StickL_Allowance() { }

	// RVA: 0x2ED8EF0 Offset: 0x2ED8FF1 VA: 0x2ED8EF0
	private static float get_m_StickR_Allowance() { }

	// RVA: 0x2ED8F40 Offset: 0x2ED9041 VA: 0x2ED8F40
	public static ProfileCardStampMenu CreateBind(ProcInst super, ProfileCardStampRoot profiledCardStampRoot, ProfileCardRoot cardRoot, ProfileCardStampListMenuContent profileCardStampListMenuContent, ProfileCard myProfileCardTemp, bool isFront, ProfileCardStampMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2ED9490 Offset: 0x2ED9591 VA: 0x2ED9490
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2ED9010 Offset: 0x2ED9111 VA: 0x2ED9010
	private void .ctor(ProfileCardStampRoot menuRoot, ProfileCardRoot cardRoot, ProfileCardStampListMenuContent stampListMenuContent, ProfileCard myProfileCardTemp, bool isFront, ProfileCardStampMenu.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x2ED9D40 Offset: 0x2ED9E41 VA: 0x2ED9D40
	public string GetName() { }

	// RVA: 0x2ED9D90 Offset: 0x2ED9E91 VA: 0x2ED9D90 Slot: 18
	public virtual void OpenAnime() { }

	// RVA: 0x2ED9DA0 Offset: 0x2ED9EA1 VA: 0x2ED9DA0
	private void Tick() { }

	// RVA: 0x2ED9F40 Offset: 0x2EDA041 VA: 0x2ED9F40 Slot: 19
	protected virtual bool TickInput() { }

	// RVA: 0x2ED9E90 Offset: 0x2ED9F91 VA: 0x2ED9E90
	private bool IsSwitchingPages() { }

	// RVA: 0x2EDDF20 Offset: 0x2EDE021 VA: 0x2EDDF20
	private void Close() { }

	// RVA: 0x2ED9E80 Offset: 0x2ED9F81 VA: 0x2ED9E80
	private bool IsClosing() { }

	// RVA: 0x2EDDF40 Offset: 0x2EDE041 VA: 0x2EDDF40
	private bool IsClosed() { }

	// RVA: 0x2EDD910 Offset: 0x2EDDA11 VA: 0x2EDD910
	private BasicMenu.Result DirCall(bool left, bool right, bool up, bool down, float lx, float ly, bool speedUp) { }

	// RVA: 0x2EDC640 Offset: 0x2EDC741 VA: 0x2EDC640
	private BasicMenu.Result ACall() { }

	// RVA: 0x2EDCD40 Offset: 0x2EDCE41 VA: 0x2EDCD40
	private BasicMenu.Result BCall() { }

	// RVA: 0x2EDCF70 Offset: 0x2EDD071 VA: 0x2EDCF70
	private BasicMenu.Result XCall() { }

	// RVA: 0x2EDD350 Offset: 0x2EDD451 VA: 0x2EDD350
	private BasicMenu.Result LCall(bool trigger) { }

	// RVA: 0x2EDD3A0 Offset: 0x2EDD4A1 VA: 0x2EDD3A0
	private BasicMenu.Result RCall(bool trigger) { }

	// RVA: 0x2EDD3F0 Offset: 0x2EDD4F1 VA: 0x2EDD3F0
	private BasicMenu.Result ZLCall(bool trigger) { }

	// RVA: 0x2EDD490 Offset: 0x2EDD591 VA: 0x2EDD490
	private BasicMenu.Result ZRCall(bool trigger) { }

	// RVA: 0x2EDDC90 Offset: 0x2EDDD91 VA: 0x2EDDC90
	private BasicMenu.Result StickRCall(float x, float y) { }

	// RVA: 0x2EDD530 Offset: 0x2EDD631 VA: 0x2EDD530
	private BasicMenu.Result PlusCall(bool trigger) { }

	// RVA: 0x2EDD620 Offset: 0x2EDD721 VA: 0x2EDD620
	private BasicMenu.Result MinusCall(bool trigger) { }

	// RVA: 0x2EDD6E0 Offset: 0x2EDD7E1 VA: 0x2EDD6E0
	private BasicMenu.Result StickLCall(bool trigger) { }

	// RVA: 0x2EDD820 Offset: 0x2EDD921 VA: 0x2EDD820
	private BasicMenu.Result StickRCall(bool trigger) { }

	// RVA: 0x2EDEA50 Offset: 0x2EDEB51 VA: 0x2EDEA50
	private void SelectStamp(ProfileCardStampData stampData) { }

	// RVA: 0x2EDE7C0 Offset: 0x2EDE8C1 VA: 0x2EDE7C0
	private bool PutStamp(ProfileCardStampData stampData) { }

	// RVA: 0x2EDFB00 Offset: 0x2EDFC01 VA: 0x2EDFB00
	private bool PutStamp(ProfileCard.FreeStamp freeStamp) { }

	// RVA: 0x2EDED00 Offset: 0x2EDEE01 VA: 0x2EDED00
	private void RemoveStamp(ProfileCard.FreeStamp freeStamp) { }

	// RVA: 0x2EDFC20 Offset: 0x2EDFD21 VA: 0x2EDFC20
	private void ClearStamp() { }

	// RVA: 0x2EDFA70 Offset: 0x2EDFB71 VA: 0x2EDFA70
	private int GetFreeStampCount() { }

	// RVA: 0x2EDF420 Offset: 0x2EDF521 VA: 0x2EDF420
	private void SwitchPages() { }

	// RVA: 0x2EDF230 Offset: 0x2EDF331 VA: 0x2EDF230
	private void ReleaseHoldingStamp() { }

	// RVA: 0x2EDFD30 Offset: 0x2EDFE31 VA: 0x2EDFD30
	private void TransitDeleteMode() { }

	// RVA: 0x2EDFD40 Offset: 0x2EDFE41 VA: 0x2EDFD40
	private void EndDeleteMode(bool transitHeader = True) { }

	// RVA: 0x2ED9AB0 Offset: 0x2ED9BB1 VA: 0x2ED9AB0
	private void UpdateStampCursor() { }

	// RVA: 0x2ED9660 Offset: 0x2ED9761 VA: 0x2ED9660
	private void CopyStampFromProfileCard() { }

	// RVA: 0x2EE0380 Offset: 0x2EE0481 VA: 0x2EE0380
	private void ApplyStampToProfileCard() { }

	// RVA: 0x2EE03A0 Offset: 0x2EE04A1 VA: 0x2EE03A0
	private void ResetStampsOnCardRoot() { }

	// RVA: 0x2EE03D0 Offset: 0x2EE04D1 VA: 0x2EE03D0
	private void OnSaveAndClose() { }

	// RVA: 0x2EE0420 Offset: 0x2EE0521 VA: 0x2EE0420
	private void OnNoSaveAndClose() { }

	// RVA: 0x2EDDF30 Offset: 0x2EDE031 VA: 0x2EDDF30
	private void OnClose() { }

	// RVA: 0x2EE0490 Offset: 0x2EE0591 VA: 0x2EE0490 Slot: 10
	protected override void OnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C61A0 Offset: 0x2C62A1 VA: 0x2C61A0
	// RVA: 0x2EE0530 Offset: 0x2EE0631 VA: 0x2EE0530
	private void <XCall>b__49_0(ProfileCardStampData stampData) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C61B0 Offset: 0x2C62B1 VA: 0x2C61B0
	// RVA: 0x2EE0590 Offset: 0x2EE0691 VA: 0x2EE0590
	private void <XCall>b__49_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C61C0 Offset: 0x2C62C1 VA: 0x2C61C0
	// RVA: 0x2EE0830 Offset: 0x2EE0931 VA: 0x2EE0830
	private void <XCall>b__49_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C61D0 Offset: 0x2C62D1 VA: 0x2C61D0
	// RVA: 0x2EE08F0 Offset: 0x2EE09F1 VA: 0x2EE08F0
	private void <MinusCall>b__56_0() { }
}

