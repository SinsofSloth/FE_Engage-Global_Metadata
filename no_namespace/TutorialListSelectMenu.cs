// Namespace: 
private enum TutorialListSelectMenu.Page // TypeDefIndex: 7707
{
	// Fields
	public int value__; // 0x0
	public const TutorialListSelectMenu.Page Rewind = -1;
	public const TutorialListSelectMenu.Page Forward = 1;
}

// Namespace: 
public sealed class TutorialListSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 7708
{
	// Methods

	// RVA: 0x23A94B0 Offset: 0x23A95B1 VA: 0x23A94B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x23A94D0 Offset: 0x23A95D1 VA: 0x23A94D0 Slot: 13
	public virtual void Invoke(TutorialListTopMenu.SelectCategoryType result) { }

	// RVA: 0x23A9730 Offset: 0x23A9831 VA: 0x23A9730 Slot: 14
	public virtual IAsyncResult BeginInvoke(TutorialListTopMenu.SelectCategoryType result, AsyncCallback callback, object object) { }

	// RVA: 0x23A97C0 Offset: 0x23A98C1 VA: 0x23A97C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x271870 Offset: 0x271971 VA: 0x271870
[Serializable]
private sealed class TutorialListSelectMenu.<>c // TypeDefIndex: 7709
{
	// Fields
	public static readonly TutorialListSelectMenu.<>c <>9; // 0x0
	public static Comparison<StructDataArrayList<TutorialData>> <>9__14_0; // 0x8
	public static Comparison<StructDataArrayList<TutorialData>> <>9__15_0; // 0x10

	// Methods

	// RVA: 0x23A9310 Offset: 0x23A9411 VA: 0x23A9310
	private static void .cctor() { }

	// RVA: 0x23A9380 Offset: 0x23A9481 VA: 0x23A9380
	public void .ctor() { }

	// RVA: 0x23A9390 Offset: 0x23A9491 VA: 0x23A9390
	internal int <RebuildMenuItem>b__14_0(StructDataArrayList<TutorialData> a, StructDataArrayList<TutorialData> b) { }

	// RVA: 0x23A9420 Offset: 0x23A9521 VA: 0x23A9420
	internal int <CreateBind>b__15_0(StructDataArrayList<TutorialData> a, StructDataArrayList<TutorialData> b) { }
}

// Namespace: 
public class TutorialListSelectMenu : BasicMenu // TypeDefIndex: 7710
{
	// Fields
	private TutorialListSelectMenu.DecideEventHandler m_DecideEventHandler; // 0xC8
	private List<TutorialListTopMenu.SelectCategoryType> m_CategoryList; // 0xD0
	private TutorialListTopMenu.SelectCategoryType m_SelectCategory; // 0xD8
	private TutorialListRoot m_Root; // 0xE0
	private List<BasicMenuSelect> m_MenuSelectList; // 0xE8
	private int m_CategoryIndex; // 0xF0
	private bool m_IsGetAllTutorial; // 0xF4

	// Methods

	// RVA: 0x287F270 Offset: 0x287F371 VA: 0x287F270
	protected void .ctor(List<BasicMenuItem> menuItemList, TutorialListSelectMenuContent menuContent, List<TutorialListTopMenu.SelectCategoryType> categorylList, TutorialListTopMenu.SelectCategoryType selectCategory, bool isGetAllTutorial, TutorialListRoot root, TutorialListSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x287F690 Offset: 0x287F791 VA: 0x287F690 Slot: 30
	public override string GetName() { }

	// RVA: 0x287F6E0 Offset: 0x287F7E1 VA: 0x287F6E0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x287F7B0 Offset: 0x287F8B1 VA: 0x287F7B0 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x287FB60 Offset: 0x287FC61 VA: 0x287FB60
	private void SwitchTutorialCategory(int value) { }

	// RVA: 0x287FCF0 Offset: 0x287FDF1 VA: 0x287FCF0
	private void RebuildMenuItem() { }

	// RVA: 0x2880200 Offset: 0x2880301 VA: 0x2880200
	public static GameObject CreateBind(ProcInst super, ref List<TutorialListTopMenu.SelectCategoryType> categoryList, TutorialListTopMenu.SelectCategoryType selectCategory, bool isGetAllTutorial, TutorialListSelectMenu.DecideEventHandler decideEventHandler) { }
}

