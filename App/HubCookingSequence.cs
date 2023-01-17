// Namespace: App
internal class HubCookingSequence : ProcInst // TypeDefIndex: 10488
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E3A0 Offset: 0x28E4A1 VA: 0x28E3A0
	private static FoodData <SelectedFood>k__BackingField; // 0x0
	private List<Unit> m_SelectedUnits; // 0x70
	private FoodstuffData[] m_SelectedFoodstuffs; // 0x78
	private int m_LoadingCharacterCount; // 0x80
	private List<HubAccess> m_UnitAccesses; // 0x88
	private List<Character> m_Characters; // 0x90
	private CookData m_CurrentCook; // 0x98
	private Dish m_Dish; // 0xA0
	private UnitItem m_Bento; // 0xA8
	private Cooking.ConversationType m_ConversationType; // 0xB0
	private Dish.RelianceResult m_DishRelianceResult; // 0xB8
	private TResourceHandle<GameObject> m_DishModelHandle; // 0xE8
	private GameObject m_DishModel; // 0xF0
	private GameObject m_UnitBCameraLocator; // 0xF8
	private InterpolatorFloat m_PanPositionY; // 0x100
	private InterpolatorVector3 m_PanEularAngle; // 0x108
	private GameObject m_CharaLight; // 0x110
	private GameObject m_CharaLightEat; // 0x118
	private ReliancePopUpController m_ReliancePopUp; // 0x120
	private bool m_IsReliancePopupLoaded; // 0x128
	private bool m_IsSkipDoCooking; // 0x129
	private Unit m_AddItemUnit; // 0x130
	private string m_SoundEvent; // 0x138
	private string m_VoiceEvent; // 0x140
	private const float PanTime = 0.8;

	// Properties
	public static FoodData SelectedFood { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BE750 Offset: 0x2BE851 VA: 0x2BE750
	// RVA: 0x3053390 Offset: 0x3053491 VA: 0x3053390
	public static FoodData get_SelectedFood() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE760 Offset: 0x2BE861 VA: 0x2BE760
	// RVA: 0x3053400 Offset: 0x3053501 VA: 0x3053400
	private static void set_SelectedFood(FoodData value) { }

	// RVA: 0x3053480 Offset: 0x3053581 VA: 0x3053480
	private void .ctor() { }

	// RVA: 0x3053690 Offset: 0x3053791 VA: 0x3053690
	private void .ctor(bool isSkip) { }

	// RVA: 0x30538B0 Offset: 0x30539B1 VA: 0x30538B0
	private void LoadResources() { }

	// RVA: 0x30538E0 Offset: 0x30539E1 VA: 0x30538E0
	private bool IsLoadingResources() { }

	// RVA: 0x3053920 Offset: 0x3053A21 VA: 0x3053920
	private void Init() { }

	// RVA: 0x3053B80 Offset: 0x3053C81 VA: 0x3053B80
	private void CheckThrowAwayBento() { }

	// RVA: 0x3053B90 Offset: 0x3053C91 VA: 0x3053B90
	private void OpenStartMenu() { }

	// RVA: 0x30545C0 Offset: 0x30546C1 VA: 0x30545C0
	private void ExecuteCooking() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BE770 Offset: 0x2BE871 VA: 0x2BE770
	// RVA: 0x3054AA0 Offset: 0x3054BA1 VA: 0x3054AA0
	private IEnumerator FightVoice() { }

	// RVA: 0x3054B20 Offset: 0x3054C21 VA: 0x3054B20
	private void BindCook() { }

	// RVA: 0x3054C00 Offset: 0x3054D01 VA: 0x3054C00
	private void UnbindCook() { }

	// RVA: 0x3054C70 Offset: 0x3054D71 VA: 0x3054C70
	private Character GetCookCharacter() { }

	// RVA: 0x3054D10 Offset: 0x3054E11 VA: 0x3054D10
	private void SetupModel() { }

	// RVA: 0x30556B0 Offset: 0x30557B1 VA: 0x30556B0
	private void EnableCharaLight() { }

	// RVA: 0x3055890 Offset: 0x3055991 VA: 0x3055890
	private void SetLook(int no, HubCookingSequence.LookTarget lookTarget) { }

	// RVA: 0x30559D0 Offset: 0x3055AD1 VA: 0x30559D0
	private bool IsLoadingPlayResources() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BE7E0 Offset: 0x2BE8E1 VA: 0x2BE7E0
	// RVA: 0x3055A80 Offset: 0x3055B81 VA: 0x3055A80
	private IEnumerator DoCooking() { }

	// RVA: 0x3055B00 Offset: 0x3055C01 VA: 0x3055B00
	private void SetConversation() { }

	// RVA: 0x3055420 Offset: 0x3055521 VA: 0x3055420
	private HubAccess SetupSelectUnit(string locatorName, string pid) { }

	// RVA: 0x3055D40 Offset: 0x3055E41 VA: 0x3055D40
	private void ResetSelectUnit(string locatorName) { }

	// RVA: 0x3055DE0 Offset: 0x3055EE1 VA: 0x3055DE0
	private void ResultVoice() { }

	// RVA: 0x3055F20 Offset: 0x3056021 VA: 0x3055F20
	private void RelianceUp() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BE850 Offset: 0x2BE951 VA: 0x2BE850
	// RVA: 0x3056030 Offset: 0x3056131 VA: 0x3056030
	private IEnumerator RelianceUpWait() { }

	// RVA: 0x30560B0 Offset: 0x30561B1 VA: 0x30560B0
	private void SetConversationCamera() { }

	// RVA: 0x30562F0 Offset: 0x30563F1 VA: 0x30562F0
	private void Conversation1() { }

	// RVA: 0x3056570 Offset: 0x3056671 VA: 0x3056570
	public bool IsPlayingTelop() { }

	// RVA: 0x3056440 Offset: 0x3056541 VA: 0x3056440
	private string GetConversationLabel(Unit unit, Cooking.Order order, Unit toUnit) { }

	// RVA: 0x3056580 Offset: 0x3056681 VA: 0x3056580
	private string GetConversationLabelAboutDelicious(Unit unit) { }

	[IteratorStateMachineAttribute] // RVA: 0x2BE8C0 Offset: 0x2BE9C1 VA: 0x2BE8C0
	// RVA: 0x3056700 Offset: 0x3056801 VA: 0x3056700
	private IEnumerator PanCamera() { }

	// RVA: 0x3056780 Offset: 0x3056881 VA: 0x3056780
	private void Conversation2() { }

	// RVA: 0x3056550 Offset: 0x3056651 VA: 0x3056550
	private void PopUpReliance(Unit unitA, Unit unitB, Dish.RelianceResult.TryResult tryResult, int value) { }

	// RVA: 0x30568F0 Offset: 0x30569F1 VA: 0x30568F0
	private void FinalConversation() { }

	// RVA: 0x3056ED0 Offset: 0x3056FD1 VA: 0x3056ED0
	private void ShowResult() { }

	// RVA: 0x3056F00 Offset: 0x3057001 VA: 0x3056F00
	private void SoundResult() { }

	// RVA: 0x3057040 Offset: 0x3057141 VA: 0x3057040
	private bool IsAvailableBento() { }

	// RVA: 0x3057150 Offset: 0x3057251 VA: 0x3057150
	private void GiveBento() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BE930 Offset: 0x2BEA31 VA: 0x2BE930
	// RVA: 0x30571F0 Offset: 0x30572F1 VA: 0x30571F0
	private IEnumerator ShowBentoResult() { }

	// RVA: 0x3057270 Offset: 0x3057371 VA: 0x3057270
	private void AddAchieveCount() { }

	// RVA: 0x30574A0 Offset: 0x30575A1 VA: 0x30574A0
	private void ExitSound() { }

	// RVA: 0x3057520 Offset: 0x3057621 VA: 0x3057520
	private void OpenTitleBar() { }

	// RVA: 0x3057660 Offset: 0x3057761 VA: 0x3057660
	private void CloseTitleBar() { }

	// RVA: 0x3057730 Offset: 0x3057831 VA: 0x3057730
	private void Exit() { }

	// RVA: 0x30577F0 Offset: 0x30578F1 VA: 0x30577F0
	private void UnloadResources() { }

	// RVA: 0x3057820 Offset: 0x3057921 VA: 0x3057820
	private void SetRenderParamsEat() { }

	// RVA: 0x3057900 Offset: 0x3057A01 VA: 0x3057900
	private void SetEatsShadowPreset() { }

	// RVA: 0x30579A0 Offset: 0x3057AA1 VA: 0x30579A0
	private void SetRenderParamsHub() { }

	// RVA: 0x3057AB0 Offset: 0x3057BB1 VA: 0x3057AB0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x30549A0 Offset: 0x3054AA1 VA: 0x30549A0
	private Unit GetCurrentCookUnit() { }

	// RVA: 0x3059560 Offset: 0x3059661 VA: 0x3059560
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE9A0 Offset: 0x2BEAA1 VA: 0x2BE9A0
	// RVA: 0x3059570 Offset: 0x3059671 VA: 0x3059570
	private void <OpenStartMenu>b__32_0(List<Unit> units, FoodData food, List<FoodstuffData> foodstuffs, Action action) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE9B0 Offset: 0x2BEAB1 VA: 0x2BE9B0
	// RVA: 0x30596E0 Offset: 0x30597E1 VA: 0x30596E0
	private void <ExecuteCooking>b__33_0(Unit unit) { }
}

