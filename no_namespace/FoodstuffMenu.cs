// Namespace: 
public sealed class FoodstuffMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 14246
{
	// Methods

	// RVA: 0x22DEE10 Offset: 0x22DEF11 VA: 0x22DEE10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22DEE30 Offset: 0x22DEF31 VA: 0x22DEE30 Slot: 13
	public virtual void Invoke(List<FoodstuffData> foodstuffs) { }

	// RVA: 0x22DF190 Offset: 0x22DF291 VA: 0x22DF190 Slot: 14
	public virtual IAsyncResult BeginInvoke(List<FoodstuffData> foodstuffs, AsyncCallback callback, object object) { }

	// RVA: 0x22DF1C0 Offset: 0x22DF2C1 VA: 0x22DF1C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class FoodstuffMenu.CancelEventHandler : MulticastDelegate // TypeDefIndex: 14247
{
	// Methods

	// RVA: 0x22DEBA0 Offset: 0x22DECA1 VA: 0x22DEBA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22DEBC0 Offset: 0x22DECC1 VA: 0x22DEBC0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x22DEDD0 Offset: 0x22DEED1 VA: 0x22DEDD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x22DEE00 Offset: 0x22DEF01 VA: 0x22DEE00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public enum FoodstuffMenu.FoodstuffMenuItem.Type // TypeDefIndex: 14248
{
	// Fields
	public int value__; // 0x0
	public const FoodstuffMenu.FoodstuffMenuItem.Type Normal = 0;
	public const FoodstuffMenu.FoodstuffMenuItem.Type Rare = 1;
	public const FoodstuffMenu.FoodstuffMenuItem.Type Decide = 2;
}

// Namespace: 
public sealed class FoodstuffMenu.FoodstuffMenuItem.OnChangeSelected : MulticastDelegate // TypeDefIndex: 14249
{
	// Methods

	// RVA: 0x1DC8E60 Offset: 0x1DC8F61 VA: 0x1DC8E60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DC8E80 Offset: 0x1DC8F81 VA: 0x1DC8E80 Slot: 13
	public virtual void Invoke(bool isSelected) { }

	// RVA: 0x1DC90B0 Offset: 0x1DC91B1 VA: 0x1DC90B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isSelected, AsyncCallback callback, object object) { }

	// RVA: 0x1DC9150 Offset: 0x1DC9251 VA: 0x1DC9150 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class FoodstuffMenu.FoodstuffMenuItem : BasicMenuItem // TypeDefIndex: 14250
{
	// Fields
	private FoodstuffMenu.FoodstuffMenuItem.Type m_Type; // 0x64
	private FoodstuffData m_Foodstuff; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x29E330 Offset: 0x29E431 VA: 0x29E330
	private bool <IsSelected>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29E340 Offset: 0x29E441 VA: 0x29E340
	private FoodstuffMenu.FoodstuffMenuItem.OnChangeSelected <OnChangeSelectedEventHander>k__BackingField; // 0x78
	private static FoodstuffMenu.FoodstuffMenuItem s_SelectedRare; // 0x0

	// Properties
	public bool IsSelected { get; set; }
	public FoodstuffMenu.FoodstuffMenuItem.OnChangeSelected OnChangeSelectedEventHander { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE3F0 Offset: 0x2CE4F1 VA: 0x2CE3F0
	// RVA: 0x22DF1D0 Offset: 0x22DF2D1 VA: 0x22DF1D0
	public bool get_IsSelected() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE400 Offset: 0x2CE501 VA: 0x2CE400
	// RVA: 0x22DF1E0 Offset: 0x22DF2E1 VA: 0x22DF1E0
	private void set_IsSelected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE410 Offset: 0x2CE511 VA: 0x2CE410
	// RVA: 0x22DF1F0 Offset: 0x22DF2F1 VA: 0x22DF1F0
	public FoodstuffMenu.FoodstuffMenuItem.OnChangeSelected get_OnChangeSelectedEventHander() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE420 Offset: 0x2CE521 VA: 0x2CE420
	// RVA: 0x22DF200 Offset: 0x22DF301 VA: 0x22DF200
	public void set_OnChangeSelectedEventHander(FoodstuffMenu.FoodstuffMenuItem.OnChangeSelected value) { }

	// RVA: 0x22DF210 Offset: 0x22DF311 VA: 0x22DF210
	public void .ctor(FoodstuffMenu.FoodstuffMenuItem.Type type, FoodstuffData foodstuff, bool isSelected = False) { }

	// RVA: 0x22DF2F0 Offset: 0x22DF3F1 VA: 0x22DF2F0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x22DF350 Offset: 0x22DF451 VA: 0x22DF350 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x22DF400 Offset: 0x22DF501 VA: 0x22DF400 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x22DF4B0 Offset: 0x22DF5B1 VA: 0x22DF4B0
	public void PushA() { }

	// RVA: 0x22DF630 Offset: 0x22DF731 VA: 0x22DF630
	public void Toggle() { }

	// RVA: 0x22DF6E0 Offset: 0x22DF7E1 VA: 0x22DF6E0
	public FoodstuffMenu.FoodstuffMenuItem.Type GetMenuType() { }

	// RVA: 0x22DF6F0 Offset: 0x22DF7F1 VA: 0x22DF6F0
	public FoodstuffData GetFoodstuff() { }

	// RVA: 0x22DF700 Offset: 0x22DF801 VA: 0x22DF700
	private static void .cctor() { }
}

// Namespace: 
public class FoodstuffMenu.FoodstuffSelectMenuManager : SingletonClass<FoodstuffMenu.FoodstuffSelectMenuManager> // TypeDefIndex: 14251
{
	// Fields
	private BasicMenuSelect m_Select; // 0x20

	// Methods

	// RVA: 0x22DF710 Offset: 0x22DF811 VA: 0x22DF710 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x22DF790 Offset: 0x22DF891 VA: 0x22DF790
	public void Save(FoodstuffMenu menu) { }

	// RVA: 0x22DF7A0 Offset: 0x22DF8A1 VA: 0x22DF7A0
	public void Restore(FoodstuffMenu menu) { }

	// RVA: 0x22DF7E0 Offset: 0x22DF8E1 VA: 0x22DF7E0
	public void .ctor() { }
}

