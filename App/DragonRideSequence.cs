// Namespace: App
public class DragonRideSequence : ProcSceneSequence<HubSequence> // TypeDefIndex: 10533
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28F460 Offset: 0x28F561 VA: 0x28F460
	private bool <FromDebugMenu>k__BackingField; // 0x84
	private bool m_IsLoadMenuContent; // 0x85
	private DragonRideSequence.PrizeData m_PrizeBondData; // 0x88
	private List<DragonRideSequence.PrizeData> m_PrizeItemDataList; // 0x90
	private int m_PrizeItemMax; // 0x98
	private int m_PrizeItemCount; // 0x9C
	private List<string> m_AnnouceDifficult; // 0xA0
	private bool m_IsAnnounceVoiceOnce; // 0xA8
	private GameObject m_Talker; // 0xB0
	private Character m_TalkerChara; // 0xB8

	// Properties
	public bool FromDebugMenu { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BEFF0 Offset: 0x2BF0F1 VA: 0x2BEFF0
	// RVA: 0x2DD2530 Offset: 0x2DD2631 VA: 0x2DD2530
	public bool get_FromDebugMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF000 Offset: 0x2BF101 VA: 0x2BF000
	// RVA: 0x2DD2540 Offset: 0x2DD2641 VA: 0x2DD2540
	public void set_FromDebugMenu(bool value) { }

	// RVA: 0x2DD2550 Offset: 0x2DD2651 VA: 0x2DD2550
	private void _CommonDebugMenu() { }

	// RVA: 0x2DD2560 Offset: 0x2DD2661 VA: 0x2DD2560 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2DD25D0 Offset: 0x2DD26D1 VA: 0x2DD25D0
	private void CancelFade() { }

	// RVA: 0x2DD2640 Offset: 0x2DD2741 VA: 0x2DD2640
	private void CheckTestExecute() { }

	// RVA: 0x2DD2840 Offset: 0x2DD2941 VA: 0x2DD2840
	private void LoadResource() { }

	// RVA: 0x2DD28F0 Offset: 0x2DD29F1 VA: 0x2DD28F0
	private bool IsLoadingResource() { }

	// RVA: 0x2DD2970 Offset: 0x2DD2A71 VA: 0x2DD2970
	private void UnloadResouce() { }

	// RVA: 0x2DD2A00 Offset: 0x2DD2B01 VA: 0x2DD2A00
	private void Init() { }

	// RVA: 0x2DD2BA0 Offset: 0x2DD2CA1 VA: 0x2DD2BA0
	private void Exit() { }

	// RVA: 0x2DD2F30 Offset: 0x2DD3031 VA: 0x2DD2F30
	private void CheckNewDifficult() { }

	// RVA: 0x2DD3480 Offset: 0x2DD3581 VA: 0x2DD3480
	private void AnnounceNewDifficult() { }

	// RVA: 0x2DD3720 Offset: 0x2DD3821 VA: 0x2DD3720
	private bool CheckAnnounceDifficult() { }

	// RVA: 0x2DD3770 Offset: 0x2DD3871 VA: 0x2DD3770
	private void CreateTitleBar() { }

	// RVA: 0x2DD2CF0 Offset: 0x2DD2DF1 VA: 0x2DD2CF0
	private void CloseTitleBar() { }

	// RVA: 0x2DD3960 Offset: 0x2DD3A61 VA: 0x2DD3960
	private void CreateSelectMenu() { }

	// RVA: 0x2DD3A80 Offset: 0x2DD3B81 VA: 0x2DD3A80
	private void Talk_CourseSelect() { }

	// RVA: 0x2DD3A90 Offset: 0x2DD3B91 VA: 0x2DD3A90
	private void ConfirmAssist() { }

	// RVA: 0x2DD3C40 Offset: 0x2DD3D41 VA: 0x2DD3C40
	private void CreateGameSequence() { }

	// RVA: 0x2DD3C50 Offset: 0x2DD3D51 VA: 0x2DD3C50
	private bool CheckRetireMinigame() { }

	// RVA: 0x2DD3D10 Offset: 0x2DD3E11 VA: 0x2DD3D10
	private bool CheckGetablePrize() { }

	// RVA: 0x2DD3E10 Offset: 0x2DD3F11 VA: 0x2DD3E10
	private void SetPrizeFlag() { }

	// RVA: 0x2DD3FE0 Offset: 0x2DD40E1 VA: 0x2DD3FE0
	private void SetPrizeList() { }

	// RVA: 0x2DD4C80 Offset: 0x2DD4D81 VA: 0x2DD4C80
	private void GetPrizeBond() { }

	// RVA: 0x2DD4E20 Offset: 0x2DD4F21 VA: 0x2DD4E20
	private void GetPrizeItem() { }

	// RVA: 0x2DD4FF0 Offset: 0x2DD50F1 VA: 0x2DD4FF0
	private bool isGetAllPrizeItem() { }

	// RVA: 0x2DD3630 Offset: 0x2DD3731 VA: 0x2DD3630
	private void VoiceAnnounceNewDifficult() { }

	// RVA: 0x2DD5000 Offset: 0x2DD5101 VA: 0x2DD5000
	private void StopVoiceNewDifficult() { }

	// RVA: 0x2DD50C0 Offset: 0x2DD51C1 VA: 0x2DD50C0
	private void VoiceSelectDifficult() { }

	// RVA: 0x2DD51A0 Offset: 0x2DD52A1 VA: 0x2DD51A0
	private void VoiceStart() { }

	// RVA: 0x2DD2E50 Offset: 0x2DD2F51 VA: 0x2DD2E50
	private void VoiceEnd() { }

	// RVA: 0x2DD5280 Offset: 0x2DD5381 VA: 0x2DD5280
	public static void CreateBind(ProcInst super, bool fromDebugMenu) { }

	// RVA: 0x2DD66F0 Offset: 0x2DD67F1 VA: 0x2DD66F0
	public static void RegistFlag() { }

	// RVA: 0x2DD6640 Offset: 0x2DD6741 VA: 0x2DD6640
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF010 Offset: 0x2BF111 VA: 0x2BF010
	// RVA: 0x2DD6C80 Offset: 0x2DD6D81 VA: 0x2DD6C80
	private void <CreateSelectMenu>b__29_0(DragonRideDifficultSelectMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF020 Offset: 0x2BF121 VA: 0x2BF020
	// RVA: 0x2DD6DA0 Offset: 0x2DD6EA1 VA: 0x2DD6DA0
	private void <ConfirmAssist>b__31_0(int r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF030 Offset: 0x2BF131 VA: 0x2BF030
	// RVA: 0x2DD4B90 Offset: 0x2DD4C91 VA: 0x2DD4B90
	internal static string <SetPrizeList>g__GetNearBondData|36_0(int count) { }
}

