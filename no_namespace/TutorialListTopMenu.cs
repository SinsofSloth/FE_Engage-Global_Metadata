// Namespace: 
public enum TutorialListTopMenu.SelectCategoryType // TypeDefIndex: 7714
{
	// Fields
	public int value__; // 0x0
	public const TutorialListTopMenu.SelectCategoryType PickUp = 0;
	public const TutorialListTopMenu.SelectCategoryType Battle = 1;
	public const TutorialListTopMenu.SelectCategoryType God = 2;
	public const TutorialListTopMenu.SelectCategoryType KizunaGmap = 3;
	public const TutorialListTopMenu.SelectCategoryType Hub = 4;
	public const TutorialListTopMenu.SelectCategoryType Challenge = 5;
	public const TutorialListTopMenu.SelectCategoryType None = 6;
	public const TutorialListTopMenu.SelectCategoryType End = 7;
}

// Namespace: 
public class TutorialListTopMenu : BasicMenu // TypeDefIndex: 7716
{
	// Fields
	private TutorialListTopMenu.DecideEventHandler m_DecideEventHandler; // 0xC8

	// Methods

	// RVA: 0x2883F70 Offset: 0x2884071 VA: 0x2883F70
	protected void .ctor(List<BasicMenuItem> menuItemList, TutorialListTopMenuContent menuContent, int index, TutorialListTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2883FD0 Offset: 0x28840D1 VA: 0x2883FD0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2884020 Offset: 0x2884121 VA: 0x2884020 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2880060 Offset: 0x2880161 VA: 0x2880060
	public static TutorialData.Types GetTutorialDataType(TutorialListTopMenu.SelectCategoryType select) { }

	// RVA: 0x287F4B0 Offset: 0x287F5B1 VA: 0x287F4B0
	public static string GetTutorialCategoryTitleName(TutorialListTopMenu.SelectCategoryType select) { }

	// RVA: 0x2882570 Offset: 0x2882671 VA: 0x2882570
	public static GameObject CreateBind(ProcInst super, ref List<TutorialListTopMenu.SelectCategoryType> categoryList, TutorialListTopMenu.SelectCategoryType selectCategory, bool isGetAllTutorial, TutorialListTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2884050 Offset: 0x2884151 VA: 0x2884050
	private static void AddMenuItemList(ref List<BasicMenuItem> menuItemList, BasicMenuItem menuItem, TutorialListTopMenu.SelectCategoryType categoryType, ref List<TutorialListTopMenu.SelectCategoryType> categoryList, TutorialListTopMenu.SelectCategoryType selectCategory, bool isGetAllTutorial, ref int index) { }
}

