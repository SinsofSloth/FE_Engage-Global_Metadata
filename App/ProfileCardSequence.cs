// Namespace: App
public class ProfileCardSequence : ProcInst // TypeDefIndex: 11623
{
	// Fields
	private ProfileCardTopMenu.Result2 m_TopMenuResult; // 0x70
	private ProfileCardMyCardMenu.Result2 m_MyCardMenuResult; // 0x74
	private ProfileCardSelectEditMenu.Result2 m_SelectEditMenuResult; // 0x78
	private ProfileCardCommentIndexMenu.Result2 m_CommentIndexMenuResult; // 0x7C
	private ProfileCardAlbumMenu.Result2 m_AlbumMenuResult; // 0x80
	private ProfileCardAlbumListMenu.Result2 m_AlbumListMenuResult; // 0x84
	private ProfileCardMyCardRoot m_ProfileCardMyCardRoot; // 0x88
	private ProfileCardAlbumRoot m_ProfileCardAlbumRoot; // 0x90
	private ProfileCard m_ProfileCardTemp; // 0x98
	private int m_AlbumIndex; // 0xA0
	private bool m_EnabledPhoto; // 0xA4
	private int m_CommentIndex; // 0xA8
	private StringBuilder m_StringBuilder; // 0xB0
	private ProfileCardCommentData[] m_CommentTempArray; // 0xB8
	private bool m_NeededUpdateCardOnBuild; // 0xC0
	private ProfileCardBgData m_BgData; // 0xC8
	private ProfileCardFrameData m_FrameData; // 0xD0
	private bool m_LoadingBgData; // 0xD8
	private bool m_LoadingFrameData; // 0xD9
	private ProfileCardSequence.DisposeEventHandler m_DisposeEventHandler; // 0xE0

	// Methods

	// RVA: 0x2820350 Offset: 0x2820451 VA: 0x2820350
	public static void CreateBind(ProcInst super, bool enabledPhoto = True, ProfileCardSequence.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x28203E0 Offset: 0x28204E1 VA: 0x28203E0
	private void .ctor(bool enabledPhoto, ProfileCardSequence.DisposeEventHandler disposeEventHandler) { }

	// RVA: 0x28204D0 Offset: 0x28205D1 VA: 0x28204D0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2823900 Offset: 0x2823A01 VA: 0x2823900
	private void LoadResources() { }

	// RVA: 0x2823A80 Offset: 0x2823B81 VA: 0x2823A80
	private bool IsLoadingResources() { }

	// RVA: 0x2823B80 Offset: 0x2823C81 VA: 0x2823B80
	private void StartSequence() { }

	// RVA: 0x2823B90 Offset: 0x2823C91 VA: 0x2823B90
	private void CreateTopMenu() { }

	// RVA: 0x2823E30 Offset: 0x2823F31 VA: 0x2823E30
	private bool IsLoadingCardContantsResources() { }

	// RVA: 0x2823EF0 Offset: 0x2823FF1 VA: 0x2823EF0
	private void LoadMyCardContent() { }

	// RVA: 0x28240D0 Offset: 0x28241D1 VA: 0x28240D0
	private bool IsLoadingCardContent() { }

	// RVA: 0x28240F0 Offset: 0x28241F1 VA: 0x28240F0
	private void UnloadCardContent() { }

	// RVA: 0x2824170 Offset: 0x2824271 VA: 0x2824170
	private bool IsAsianLanguage() { }

	// RVA: 0x2824240 Offset: 0x2824341 VA: 0x2824240
	private void ShowContentsNotice() { }

	// RVA: 0x2824350 Offset: 0x2824451 VA: 0x2824350
	private void ConvertMyCardLanguage() { }

	// RVA: 0x2824450 Offset: 0x2824551 VA: 0x2824450
	private void CreateMyCardRoot() { }

	// RVA: 0x28245E0 Offset: 0x28246E1 VA: 0x28245E0
	private void ShowMyCardRoot() { }

	// RVA: 0x2824610 Offset: 0x2824711 VA: 0x2824610
	private void HideMyCardRoot() { }

	// RVA: 0x2824640 Offset: 0x2824741 VA: 0x2824640
	private void CreateMyCardMenu() { }

	// RVA: 0x28248A0 Offset: 0x28249A1 VA: 0x28248A0
	private void CreateSelectEditMenu() { }

	// RVA: 0x2824B10 Offset: 0x2824C11 VA: 0x2824B10
	private void CreateTitleMenu() { }

	// RVA: 0x2824E10 Offset: 0x2824F11 VA: 0x2824E10
	private void CreateCommentMenu() { }

	// RVA: 0x2825060 Offset: 0x2825161 VA: 0x2825060
	private void CreateCommentListMenu() { }

	// RVA: 0x28255A0 Offset: 0x28256A1 VA: 0x28255A0
	private void CreateFavoriteCharacterMenu() { }

	// RVA: 0x28258A0 Offset: 0x28259A1 VA: 0x28258A0
	private void CreateFavoriteRelayMap() { }

	// RVA: 0x2825BA0 Offset: 0x2825CA1 VA: 0x2825BA0
	private void CreateVisualMenu() { }

	// RVA: 0x2825E30 Offset: 0x2825F31 VA: 0x2825E30
	private void CreateBgMenu() { }

	// RVA: 0x2826140 Offset: 0x2826241 VA: 0x2826140
	private void CreateFrameMenu() { }

	// RVA: 0x2826450 Offset: 0x2826551 VA: 0x2826450
	private void CreateTextDecoMenu() { }

	// RVA: 0x2826760 Offset: 0x2826861 VA: 0x2826760
	private void CreateTextColorMenu() { }

	// RVA: 0x2826A70 Offset: 0x2826B71 VA: 0x2826A70
	private void CreateCharacterStampMenu() { }

	// RVA: 0x2826D80 Offset: 0x2826E81 VA: 0x2826D80
	private void CreateStampMenu() { }

	// RVA: 0x2827040 Offset: 0x2827141 VA: 0x2827040
	private void ScaleCardRootLarge() { }

	// RVA: 0x2827060 Offset: 0x2827161 VA: 0x2827060
	private bool IsCardRootScalingLarge() { }

	// RVA: 0x2827190 Offset: 0x2827291 VA: 0x2827190
	private void ScaleCardRootSmall() { }

	// RVA: 0x28271B0 Offset: 0x28272B1 VA: 0x28271B0
	private bool IsCardRootScalingSmall() { }

	// RVA: 0x28272E0 Offset: 0x28273E1 VA: 0x28272E0
	private void CreatePhotoSequence() { }

	// RVA: 0x28272F0 Offset: 0x28273F1 VA: 0x28272F0
	private void SaveMyCardEdit() { }

	// RVA: 0x2827380 Offset: 0x2827481 VA: 0x2827380
	private void CloseMyCardRoot() { }

	// RVA: 0x28273A0 Offset: 0x28274A1 VA: 0x28273A0
	private bool IsClosingMyCardRoot() { }

	// RVA: 0x2827440 Offset: 0x2827541 VA: 0x2827440
	private void DestroyMyCardRoot() { }

	// RVA: 0x28274E0 Offset: 0x28275E1 VA: 0x28274E0
	private void LoadAlbumTopContent() { }

	// RVA: 0x2827710 Offset: 0x2827811 VA: 0x2827710
	private void CreateAlbumRoot() { }

	// RVA: 0x28278C0 Offset: 0x28279C1 VA: 0x28278C0
	private void CreateAlbumListMenu() { }

	// RVA: 0x2827C60 Offset: 0x2827D61 VA: 0x2827C60
	private void CreateAlbumMenu() { }

	// RVA: 0x2827F40 Offset: 0x2828041 VA: 0x2827F40
	private void CloseAlubumRoot() { }

	// RVA: 0x2827F60 Offset: 0x2828061 VA: 0x2827F60
	private bool IsClosingAlbumRoot() { }

	// RVA: 0x2828000 Offset: 0x2828101 VA: 0x2828000
	private void DestroyAlbumRoot() { }

	// RVA: 0x28280A0 Offset: 0x28281A1 VA: 0x28280A0
	private void ScaleAlbumCardRootSmallImmediately() { }

	// RVA: 0x2828160 Offset: 0x2828261 VA: 0x2828160
	private void HideAlbumCardRoot() { }

	// RVA: 0x2828210 Offset: 0x2828311 VA: 0x2828210
	private void ShowAlbumCardRoot() { }

	// RVA: 0x28282C0 Offset: 0x28283C1 VA: 0x28282C0
	private void ScaleAlbumCardRootLarge() { }

	// RVA: 0x2828400 Offset: 0x2828501 VA: 0x2828400
	private bool IsAlbumCardRootScalingLarge() { }

	// RVA: 0x2828530 Offset: 0x2828631 VA: 0x2828530
	private void ScaleAlbumCardRootSmall() { }

	// RVA: 0x2828660 Offset: 0x2828761 VA: 0x2828660
	private bool IsAlbumCardRootScalingSmall() { }

	// RVA: 0x28287A0 Offset: 0x28288A1 VA: 0x28287A0
	private void CreatePublicSetting() { }

	// RVA: 0x2828890 Offset: 0x2828991 VA: 0x2828890
	private void CreateStampVisibilitySetting() { }

	// RVA: 0x2828980 Offset: 0x2828A81 VA: 0x2828980
	private void EndSequence() { }

	// RVA: 0x2828A50 Offset: 0x2828B51 VA: 0x2828A50
	private void UnloadResources() { }

	// RVA: 0x2828BA0 Offset: 0x2828CA1 VA: 0x2828BA0 Slot: 10
	protected override void OnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5E40 Offset: 0x2C5F41 VA: 0x2C5E40
	// RVA: 0x2828BE0 Offset: 0x2828CE1 VA: 0x2828BE0
	private bool <CreateDesc>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5E50 Offset: 0x2C5F51 VA: 0x2C5E50
	// RVA: 0x2828BF0 Offset: 0x2828CF1 VA: 0x2828BF0
	private bool <CreateDesc>b__24_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5E60 Offset: 0x2C5F61 VA: 0x2C5E60
	// RVA: 0x2828C00 Offset: 0x2828D01 VA: 0x2828C00
	private bool <CreateDesc>b__24_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5E70 Offset: 0x2C5F71 VA: 0x2C5E70
	// RVA: 0x2828C10 Offset: 0x2828D11 VA: 0x2828C10
	private bool <CreateDesc>b__24_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5E80 Offset: 0x2C5F81 VA: 0x2C5E80
	// RVA: 0x2828C20 Offset: 0x2828D21 VA: 0x2828C20
	private bool <CreateDesc>b__24_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5E90 Offset: 0x2C5F91 VA: 0x2C5E90
	// RVA: 0x2828C30 Offset: 0x2828D31 VA: 0x2828C30
	private bool <CreateDesc>b__24_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5EA0 Offset: 0x2C5FA1 VA: 0x2C5EA0
	// RVA: 0x2828C40 Offset: 0x2828D41 VA: 0x2828C40
	private bool <CreateDesc>b__24_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5EB0 Offset: 0x2C5FB1 VA: 0x2C5EB0
	// RVA: 0x2828C50 Offset: 0x2828D51 VA: 0x2828C50
	private bool <CreateDesc>b__24_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5EC0 Offset: 0x2C5FC1 VA: 0x2C5EC0
	// RVA: 0x2828C60 Offset: 0x2828D61 VA: 0x2828C60
	private bool <CreateDesc>b__24_8() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5ED0 Offset: 0x2C5FD1 VA: 0x2C5ED0
	// RVA: 0x2828C70 Offset: 0x2828D71 VA: 0x2828C70
	private bool <CreateDesc>b__24_9() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5EE0 Offset: 0x2C5FE1 VA: 0x2C5EE0
	// RVA: 0x2828C80 Offset: 0x2828D81 VA: 0x2828C80
	private bool <CreateDesc>b__24_10() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5EF0 Offset: 0x2C5FF1 VA: 0x2C5EF0
	// RVA: 0x2828C90 Offset: 0x2828D91 VA: 0x2828C90
	private bool <CreateDesc>b__24_11() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F00 Offset: 0x2C6001 VA: 0x2C5F00
	// RVA: 0x2828CA0 Offset: 0x2828DA1 VA: 0x2828CA0
	private bool <CreateDesc>b__24_12() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F10 Offset: 0x2C6011 VA: 0x2C5F10
	// RVA: 0x2828CB0 Offset: 0x2828DB1 VA: 0x2828CB0
	private bool <CreateDesc>b__24_13() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F20 Offset: 0x2C6021 VA: 0x2C5F20
	// RVA: 0x2828CC0 Offset: 0x2828DC1 VA: 0x2828CC0
	private bool <CreateDesc>b__24_14() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F30 Offset: 0x2C6031 VA: 0x2C5F30
	// RVA: 0x2828CD0 Offset: 0x2828DD1 VA: 0x2828CD0
	private bool <CreateDesc>b__24_15() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F40 Offset: 0x2C6041 VA: 0x2C5F40
	// RVA: 0x2828CE0 Offset: 0x2828DE1 VA: 0x2828CE0
	private bool <CreateDesc>b__24_16() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F50 Offset: 0x2C6051 VA: 0x2C5F50
	// RVA: 0x2828CF0 Offset: 0x2828DF1 VA: 0x2828CF0
	private bool <CreateDesc>b__24_17() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F60 Offset: 0x2C6061 VA: 0x2C5F60
	// RVA: 0x2828D00 Offset: 0x2828E01 VA: 0x2828D00
	private bool <CreateDesc>b__24_18() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F70 Offset: 0x2C6071 VA: 0x2C5F70
	// RVA: 0x2828D10 Offset: 0x2828E11 VA: 0x2828D10
	private bool <CreateDesc>b__24_19() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F80 Offset: 0x2C6081 VA: 0x2C5F80
	// RVA: 0x2828D20 Offset: 0x2828E21 VA: 0x2828D20
	private bool <CreateDesc>b__24_20() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5F90 Offset: 0x2C6091 VA: 0x2C5F90
	// RVA: 0x2828D30 Offset: 0x2828E31 VA: 0x2828D30
	private bool <CreateDesc>b__24_21() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5FA0 Offset: 0x2C60A1 VA: 0x2C5FA0
	// RVA: 0x2828D40 Offset: 0x2828E41 VA: 0x2828D40
	private bool <CreateDesc>b__24_22() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5FB0 Offset: 0x2C60B1 VA: 0x2C5FB0
	// RVA: 0x2828D50 Offset: 0x2828E51 VA: 0x2828D50
	private bool <CreateDesc>b__24_23() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5FC0 Offset: 0x2C60C1 VA: 0x2C5FC0
	// RVA: 0x2828D60 Offset: 0x2828E61 VA: 0x2828D60
	private void <CreateTopMenu>b__28_0(ProfileCardTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5FD0 Offset: 0x2C60D1 VA: 0x2C5FD0
	// RVA: 0x2828D70 Offset: 0x2828E71 VA: 0x2828D70
	private void <LoadMyCardContent>b__30_0(Sprite sprite) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5FE0 Offset: 0x2C60E1 VA: 0x2C5FE0
	// RVA: 0x2828D80 Offset: 0x2828E81 VA: 0x2828D80
	private void <LoadMyCardContent>b__30_1(Sprite sprite) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5FF0 Offset: 0x2C60F1 VA: 0x2C5FF0
	// RVA: 0x2828D90 Offset: 0x2828E91 VA: 0x2828D90
	private void <CreateMyCardMenu>b__39_0(ProfileCardMyCardMenu.Result2 result) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6000 Offset: 0x2C6101 VA: 0x2C6000
	// RVA: 0x2828DA0 Offset: 0x2828EA1 VA: 0x2828DA0
	private void <CreateSelectEditMenu>b__40_0(ProfileCardSelectEditMenu.Result2 result) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6010 Offset: 0x2C6111 VA: 0x2C6010
	// RVA: 0x2828DB0 Offset: 0x2828EB1 VA: 0x2828DB0
	private void <CreateSelectEditMenu>b__40_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6020 Offset: 0x2C6121 VA: 0x2C6020
	// RVA: 0x2828E20 Offset: 0x2828F21 VA: 0x2828E20
	private void <CreateTitleMenu>b__41_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6030 Offset: 0x2C6131 VA: 0x2C6030
	// RVA: 0x2828EA0 Offset: 0x2828FA1 VA: 0x2828EA0
	private void <CreateCommentMenu>b__42_0(ProfileCardCommentIndexMenu.Result2 result, int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6040 Offset: 0x2C6141 VA: 0x2C6040
	// RVA: 0x2828EB0 Offset: 0x2828FB1 VA: 0x2828EB0
	private void <CreateCommentMenu>b__42_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6050 Offset: 0x2C6151 VA: 0x2C6050
	// RVA: 0x2828FA0 Offset: 0x28290A1 VA: 0x2828FA0
	private void <CreateCommentListMenu>b__43_0(ProfileCardCommentData commentData) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6060 Offset: 0x2C6161 VA: 0x2C6060
	// RVA: 0x2829120 Offset: 0x2829221 VA: 0x2829120
	private void <CreateCommentListMenu>b__43_1(ProfileCardCommentData commentData) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6070 Offset: 0x2C6171 VA: 0x2C6070
	// RVA: 0x2829160 Offset: 0x2829261 VA: 0x2829160
	private void <CreateCommentListMenu>b__43_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6080 Offset: 0x2C6181 VA: 0x2C6080
	// RVA: 0x2829220 Offset: 0x2829321 VA: 0x2829220
	private void <CreateCommentListMenu>b__43_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6090 Offset: 0x2C6191 VA: 0x2C6090
	// RVA: 0x2829260 Offset: 0x2829361 VA: 0x2829260
	private void <CreateFavoriteCharacterMenu>b__44_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C60A0 Offset: 0x2C61A1 VA: 0x2C60A0
	// RVA: 0x28292E0 Offset: 0x28293E1 VA: 0x28292E0
	private void <CreateFavoriteRelayMap>b__45_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C60B0 Offset: 0x2C61B1 VA: 0x2C60B0
	// RVA: 0x2829360 Offset: 0x2829461 VA: 0x2829360
	private void <CreateVisualMenu>b__46_0(ProfileCardVisualMenu.Category category, string id) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C60C0 Offset: 0x2C61C1 VA: 0x2C60C0
	// RVA: 0x2829610 Offset: 0x2829711 VA: 0x2829610
	private void <CreateVisualMenu>b__46_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C60D0 Offset: 0x2C61D1 VA: 0x2C60D0
	// RVA: 0x2829650 Offset: 0x2829751 VA: 0x2829650
	private void <CreateBgMenu>b__47_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C60E0 Offset: 0x2C61E1 VA: 0x2C60E0
	// RVA: 0x28296D0 Offset: 0x28297D1 VA: 0x28296D0
	private void <CreateFrameMenu>b__48_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C60F0 Offset: 0x2C61F1 VA: 0x2C60F0
	// RVA: 0x2829750 Offset: 0x2829851 VA: 0x2829750
	private void <CreateTextDecoMenu>b__49_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6100 Offset: 0x2C6201 VA: 0x2C6100
	// RVA: 0x28297D0 Offset: 0x28298D1 VA: 0x28297D0
	private void <CreateTextColorMenu>b__50_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6110 Offset: 0x2C6211 VA: 0x2C6110
	// RVA: 0x2829850 Offset: 0x2829951 VA: 0x2829850
	private void <CreateCharacterStampMenu>b__51_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6120 Offset: 0x2C6221 VA: 0x2C6120
	// RVA: 0x28298D0 Offset: 0x28299D1 VA: 0x28298D0
	private void <CreateStampMenu>b__52_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6130 Offset: 0x2C6231 VA: 0x2C6130
	// RVA: 0x2829930 Offset: 0x2829A31 VA: 0x2829930
	private void <LoadAlbumTopContent>b__62_0(Sprite sprite) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6140 Offset: 0x2C6241 VA: 0x2C6140
	// RVA: 0x2829940 Offset: 0x2829A41 VA: 0x2829940
	private void <LoadAlbumTopContent>b__62_1(Sprite sprite) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6150 Offset: 0x2C6251 VA: 0x2C6150
	// RVA: 0x2829950 Offset: 0x2829A51 VA: 0x2829950
	private void <CreateAlbumListMenu>b__64_0(ProfileCardAlbumListMenu.Result2 result, int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6160 Offset: 0x2C6261 VA: 0x2C6160
	// RVA: 0x2829970 Offset: 0x2829A71 VA: 0x2829970
	private void <CreateAlbumListMenu>b__64_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6170 Offset: 0x2C6271 VA: 0x2C6170
	// RVA: 0x2829A30 Offset: 0x2829B31 VA: 0x2829A30
	private void <CreateAlbumListMenu>b__64_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6180 Offset: 0x2C6281 VA: 0x2C6180
	// RVA: 0x2829A70 Offset: 0x2829B71 VA: 0x2829A70
	private void <CreateAlbumMenu>b__65_0(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6190 Offset: 0x2C6291 VA: 0x2C6190
	// RVA: 0x2829A80 Offset: 0x2829B81 VA: 0x2829A80
	private void <CreateAlbumMenu>b__65_1(ProfileCardAlbumMenu.Result2 result) { }
}

