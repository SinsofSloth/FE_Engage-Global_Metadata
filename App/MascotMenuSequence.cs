// Namespace: App
public class MascotMenuSequence : SingletonProcInst<MascotMenuSequence> // TypeDefIndex: 10873
{
	// Fields
	private MascotFriendlyContent m_FriendlyGauge; // 0x78
	private MascotPresentationRoot m_MascotPresentationRoot; // 0x80
	private MascotTopMenu.MenuResult m_TopMenuResult; // 0x88
	private MascotCustomizeMenu.MenuResult m_CustomMenuResult; // 0x8C
	private ResourceHandle m_Handle; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x295D90 Offset: 0x295E91 VA: 0x295D90
	private FoodstuffData <Foodstuff>k__BackingField; // 0x98
	private bool m_Reserved; // 0xA0
	private Vector3 m_MascotReservePosition; // 0xA4
	private Quaternion m_MascotReserveRotation; // 0xB0
	private HubMascotCamera m_MascotCamera; // 0xC0

	// Properties
	public FoodstuffData Foodstuff { get; set; }
	public MascotFriendlyContent FriendlyGauge { get; }
	public MascotPresentationRoot PresentationRoot { get; }
	private HubPlayerController PlayerController { get; }
	private HubUnitController Player { get; }
	private HubMascotController Mascot { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C26F0 Offset: 0x2C27F1 VA: 0x2C26F0
	// RVA: 0x28559D0 Offset: 0x2855AD1 VA: 0x28559D0
	public FoodstuffData get_Foodstuff() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2700 Offset: 0x2C2801 VA: 0x2C2700
	// RVA: 0x28559E0 Offset: 0x2855AE1 VA: 0x28559E0
	public void set_Foodstuff(FoodstuffData value) { }

	// RVA: 0x28559F0 Offset: 0x2855AF1 VA: 0x28559F0
	public MascotFriendlyContent get_FriendlyGauge() { }

	// RVA: 0x2855A00 Offset: 0x2855B01 VA: 0x2855A00
	public MascotPresentationRoot get_PresentationRoot() { }

	// RVA: 0x2855A10 Offset: 0x2855B11 VA: 0x2855A10
	private HubPlayerController get_PlayerController() { }

	// RVA: 0x2855A20 Offset: 0x2855B21 VA: 0x2855A20
	private HubUnitController get_Player() { }

	// RVA: 0x2855A80 Offset: 0x2855B81 VA: 0x2855A80
	private HubMascotController get_Mascot() { }

	// RVA: 0x2855B20 Offset: 0x2855C21 VA: 0x2855B20
	public static void SetShadowModel(GameObject gameObject, bool enabled) { }

	// RVA: 0x2855C20 Offset: 0x2855D21 VA: 0x2855C20
	private void LoadResources() { }

	// RVA: 0x2855DF0 Offset: 0x2855EF1 VA: 0x2855DF0
	private bool IsLoadingResources() { }

	// RVA: 0x2855EA0 Offset: 0x2855FA1 VA: 0x2855EA0
	private void StartSequence() { }

	// RVA: 0x28560A0 Offset: 0x28561A1 VA: 0x28560A0
	private void OpenTitle() { }

	// RVA: 0x2856270 Offset: 0x2856371 VA: 0x2856270
	private void CreateTopMenu() { }

	// RVA: 0x28565A0 Offset: 0x28566A1 VA: 0x28565A0
	private void CreateCustomMenu() { }

	// RVA: 0x2856630 Offset: 0x2856731 VA: 0x2856630
	private void InitStrok() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C2710 Offset: 0x2C2811 VA: 0x2C2710
	// RVA: 0x2856A50 Offset: 0x2856B51 VA: 0x2856A50
	private IEnumerator Strok() { }

	// RVA: 0x2856AD0 Offset: 0x2856BD1 VA: 0x2856AD0
	private void ExitStrok() { }

	// RVA: 0x2856E40 Offset: 0x2856F41 VA: 0x2856E40
	private void GetBond() { }

	// RVA: 0x2856F00 Offset: 0x2857001 VA: 0x2856F00
	private void InitCustom() { }

	// RVA: 0x2857720 Offset: 0x2857821 VA: 0x2857720
	private void ExitCustom() { }

	// RVA: 0x2857E50 Offset: 0x2857F51 VA: 0x2857E50
	private void Exit() { }

	// RVA: 0x2858100 Offset: 0x2858201 VA: 0x2858100
	private void CreateFoodSelect() { }

	// RVA: 0x2858310 Offset: 0x2858411 VA: 0x2858310
	private void CreateFoodEat() { }

	// RVA: 0x2858320 Offset: 0x2858421 VA: 0x2858320
	private void CreateAccChange() { }

	// RVA: 0x28584E0 Offset: 0x28585E1 VA: 0x28584E0
	private void CreateColorChange() { }

	// RVA: 0x2858600 Offset: 0x2858701 VA: 0x2858600
	private void FriendlyPopup() { }

	// RVA: 0x28586F0 Offset: 0x28587F1 VA: 0x28586F0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2859EC0 Offset: 0x2859FC1 VA: 0x2859EC0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2859FB0 Offset: 0x285A0B1 VA: 0x2859FB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2780 Offset: 0x2C2881 VA: 0x2C2780
	// RVA: 0x285A0C0 Offset: 0x285A1C1 VA: 0x285A0C0
	private void <CreateTopMenu>b__25_0(MascotTopMenu.MenuResult r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2790 Offset: 0x2C2891 VA: 0x2C2790
	// RVA: 0x285A0D0 Offset: 0x285A1D1 VA: 0x285A0D0
	private void <CreateCustomMenu>b__26_0(MascotCustomizeMenu.MenuResult r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C27A0 Offset: 0x2C28A1 VA: 0x2C27A0
	// RVA: 0x285A0E0 Offset: 0x285A1E1 VA: 0x285A0E0
	private bool <CreateDesc>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C27B0 Offset: 0x2C28B1 VA: 0x2C27B0
	// RVA: 0x285A0F0 Offset: 0x285A1F1 VA: 0x285A0F0
	private bool <CreateDesc>b__43_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C27C0 Offset: 0x2C28C1 VA: 0x2C27C0
	// RVA: 0x285A100 Offset: 0x285A201 VA: 0x285A100
	private bool <CreateDesc>b__43_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C27D0 Offset: 0x2C28D1 VA: 0x2C27D0
	// RVA: 0x285A110 Offset: 0x285A211 VA: 0x285A110
	private bool <CreateDesc>b__43_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C27E0 Offset: 0x2C28E1 VA: 0x2C27E0
	// RVA: 0x285A120 Offset: 0x285A221 VA: 0x285A120
	private bool <CreateDesc>b__43_4() { }
}

