// Namespace: 
public sealed class DishSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 14231
{
	// Methods

	// RVA: 0x1EFEC10 Offset: 0x1EFED11 VA: 0x1EFEC10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EFEC30 Offset: 0x1EFED31 VA: 0x1EFEC30 Slot: 13
	public virtual void Invoke(FoodData food) { }

	// RVA: 0x1EFEF90 Offset: 0x1EFF091 VA: 0x1EFEF90 Slot: 14
	public virtual IAsyncResult BeginInvoke(FoodData food, AsyncCallback callback, object object) { }

	// RVA: 0x1EFEFC0 Offset: 0x1EFF0C1 VA: 0x1EFEFC0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DishSelectMenu.CancelEventHandler : MulticastDelegate // TypeDefIndex: 14232
{
	// Methods

	// RVA: 0x1EFE9A0 Offset: 0x1EFEAA1 VA: 0x1EFE9A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EFE9C0 Offset: 0x1EFEAC1 VA: 0x1EFE9C0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1EFEBD0 Offset: 0x1EFECD1 VA: 0x1EFEBD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1EFEC00 Offset: 0x1EFED01 VA: 0x1EFEC00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DishSelectMenu.SelectEventHandler : MulticastDelegate // TypeDefIndex: 14233
{
	// Methods

	// RVA: 0x1EFE910 Offset: 0x1EFEA11 VA: 0x1EFE910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EFF850 Offset: 0x1EFF951 VA: 0x1EFF850 Slot: 13
	public virtual void Invoke(FoodData food) { }

	// RVA: 0x1EFFD20 Offset: 0x1EFFE21 VA: 0x1EFFD20 Slot: 14
	public virtual IAsyncResult BeginInvoke(FoodData food, AsyncCallback callback, object object) { }

	// RVA: 0x1EFFD50 Offset: 0x1EFFE51 VA: 0x1EFFD50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class DishSelectMenu.DishSelectMenuItem : BasicMenuItem // TypeDefIndex: 14234
{
	// Fields
	private FoodData m_Food; // 0x68
	private DishSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x70
	private DishSelectMenu.SelectEventHandler m_SelectEventHandler; // 0x78

	// Methods

	// RVA: 0x1EFE930 Offset: 0x1EFEA31 VA: 0x1EFE930
	public void .ctor(FoodData foodData, DishSelectMenu.DecideEventHandler decideEventHandler, DishSelectMenu.SelectEventHandler selectEventHandler) { }

	// RVA: 0x1EFF4E0 Offset: 0x1EFF5E1 VA: 0x1EFF4E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1EFF520 Offset: 0x1EFF621 VA: 0x1EFF520 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1EFF690 Offset: 0x1EFF791 VA: 0x1EFF690 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1EFFBF0 Offset: 0x1EFFCF1 VA: 0x1EFFBF0
	public FoodData GetFood() { }
}

// Namespace: 
public class DishSelectMenu.DishSelectMenuManager : SingletonClass<DishSelectMenu.DishSelectMenuManager> // TypeDefIndex: 14235
{
	// Fields
	private BasicMenuSelect m_Select; // 0x20

	// Methods

	// RVA: 0x1EFFC00 Offset: 0x1EFFD01 VA: 0x1EFFC00 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x1EFFC80 Offset: 0x1EFFD81 VA: 0x1EFFC80
	public void Save(DishSelectMenu menu) { }

	// RVA: 0x1EFFBB0 Offset: 0x1EFFCB1 VA: 0x1EFFBB0
	public void Restore(DishSelectMenu menu) { }

	// RVA: 0x1EFFCA0 Offset: 0x1EFFDA1 VA: 0x1EFFCA0
	public void .ctor() { }
}

// Namespace: 
private class DishSelectMenu.DishMenuCompare : IComparer<BasicMenuItem> // TypeDefIndex: 14236
{
	// Fields
	private bool m_IsRecommended; // 0x10

	// Methods

	// RVA: 0x1EFEFD0 Offset: 0x1EFF0D1 VA: 0x1EFEFD0
	public void .ctor(bool isRecommended) { }

	// RVA: 0x1EFF000 Offset: 0x1EFF101 VA: 0x1EFF000 Slot: 4
	private int System.Collections.Generic.IComparer<App.BasicMenuItem>.Compare(BasicMenuItem x, BasicMenuItem y) { }

	// RVA: 0x1EFF180 Offset: 0x1EFF281 VA: 0x1EFF180
	private int CompareBothLike(DishSelectMenu.DishSelectMenuItem x, DishSelectMenu.DishSelectMenuItem y) { }

	// RVA: 0x1EFF2F0 Offset: 0x1EFF3F1 VA: 0x1EFF2F0
	private int CompareDifficulty(DishSelectMenu.DishSelectMenuItem x, DishSelectMenu.DishSelectMenuItem y) { }

	// RVA: 0x1EFF350 Offset: 0x1EFF451 VA: 0x1EFF350
	private int CompareDislike(DishSelectMenu.DishSelectMenuItem x, DishSelectMenu.DishSelectMenuItem y) { }

	// RVA: 0x1EFF4C0 Offset: 0x1EFF5C1 VA: 0x1EFF4C0
	private int CompareIndex(DishSelectMenu.DishSelectMenuItem x, DishSelectMenu.DishSelectMenuItem y) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279840 Offset: 0x279941 VA: 0x279840
private sealed class DishSelectMenu.<>c__DisplayClass13_0 // TypeDefIndex: 14237
{
	// Fields
	public List<DishSelectMenu.DishSelectMenuItem> dishMenuItemList; // 0x10

	// Methods

	// RVA: 0x1EFE740 Offset: 0x1EFE841 VA: 0x1EFE740
	public void .ctor() { }

	// RVA: 0x1EFE750 Offset: 0x1EFE851 VA: 0x1EFE750
	internal void <CreateMenuItemList>b__0(FoodData food) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279850 Offset: 0x279951 VA: 0x279850
[Serializable]
private sealed class DishSelectMenu.<>c // TypeDefIndex: 14238
{
	// Fields
	public static readonly DishSelectMenu.<>c <>9; // 0x0
	public static DishSelectMenu.SelectEventHandler <>9__13_1; // 0x8

	// Methods

	// RVA: 0x1EFE640 Offset: 0x1EFE741 VA: 0x1EFE640
	private static void .cctor() { }

	// RVA: 0x1EFE6B0 Offset: 0x1EFE7B1 VA: 0x1EFE6B0
	public void .ctor() { }

	// RVA: 0x1EFE6C0 Offset: 0x1EFE7C1 VA: 0x1EFE6C0
	internal void <CreateMenuItemList>b__13_1(FoodData food) { }
}

