// Namespace: 
public sealed class DiscardItemMenu.DecideCallback : MulticastDelegate // TypeDefIndex: 12535
{
	// Methods

	// RVA: 0x1EFB9E0 Offset: 0x1EFBAE1 VA: 0x1EFB9E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EFBA00 Offset: 0x1EFBB01 VA: 0x1EFBA00 Slot: 13
	public virtual void Invoke(bool transporterIsSelected, int transporterItemIndex) { }

	// RVA: 0x1EFBC40 Offset: 0x1EFBD41 VA: 0x1EFBC40 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool transporterIsSelected, int transporterItemIndex, AsyncCallback callback, object object) { }

	// RVA: 0x1EFBD00 Offset: 0x1EFBE01 VA: 0x1EFBD00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DiscardItemMenu.CancelCallback : MulticastDelegate // TypeDefIndex: 12536
{
	// Methods

	// RVA: 0x1EFB140 Offset: 0x1EFB241 VA: 0x1EFB140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EFB160 Offset: 0x1EFB261 VA: 0x1EFB160 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1EFB370 Offset: 0x1EFB471 VA: 0x1EFB370 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1EFB3A0 Offset: 0x1EFB4A1 VA: 0x1EFB3A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278710 Offset: 0x278811 VA: 0x278710
private sealed class DiscardItemMenu.DiscardItemMenuItem.<>c__DisplayClass12_0 // TypeDefIndex: 12537
{
	// Fields
	public DiscardItemMenu menu; // 0x10
	public DiscardItemMenu.DiscardItemMenuItem <>4__this; // 0x18

	// Methods

	// RVA: 0x1DC8E20 Offset: 0x1DC8F21 VA: 0x1DC8E20
	public void .ctor() { }

	// RVA: 0x1DC8E30 Offset: 0x1DC8F31 VA: 0x1DC8E30
	internal void <ACall>b__0() { }
}

// Namespace: 
private class DiscardItemMenu.DiscardItemMenuItem : BasicItemMenuItem // TypeDefIndex: 12538
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29AA20 Offset: 0x29AB21 VA: 0x29AA20
	private int <m_OwnerItemIndex>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x29AA30 Offset: 0x29AB31 VA: 0x29AA30
	private long <m_SortValue>k__BackingField; // 0x68

	// Properties
	public int m_OwnerItemIndex { get; set; }
	public long m_SortValue { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9740 Offset: 0x2C9841 VA: 0x2C9740
	// RVA: 0x1EFBF80 Offset: 0x1EFC081 VA: 0x1EFBF80
	public int get_m_OwnerItemIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9750 Offset: 0x2C9851 VA: 0x2C9750
	// RVA: 0x1EFBF90 Offset: 0x1EFC091 VA: 0x1EFBF90
	private void set_m_OwnerItemIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9760 Offset: 0x2C9861 VA: 0x2C9760
	// RVA: 0x1EFBFA0 Offset: 0x1EFC0A1 VA: 0x1EFBFA0
	public long get_m_SortValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9770 Offset: 0x2C9871 VA: 0x2C9770
	// RVA: 0x1EFBFB0 Offset: 0x1EFC0B1 VA: 0x1EFBFB0
	private void set_m_SortValue(long value) { }

	// RVA: 0x1EFBFC0 Offset: 0x1EFC0C1 VA: 0x1EFBFC0
	public void .ctor(int ownerItemIndex) { }

	// RVA: 0x1EFC080 Offset: 0x1EFC181 VA: 0x1EFC080 Slot: 4
	public override string GetName() { }

	// RVA: 0x1EFC360 Offset: 0x1EFC461 VA: 0x1EFC360 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1EFC4E0 Offset: 0x1EFC5E1 VA: 0x1EFC4E0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1EFC600 Offset: 0x1EFC701 VA: 0x1EFC600 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1EFC770 Offset: 0x1EFC871 VA: 0x1EFC770 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1EFC820 Offset: 0x1EFC921 VA: 0x1EFC820 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x1EFC830 Offset: 0x1EFC931 VA: 0x1EFC830 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x1EFC940 Offset: 0x1EFCA41 VA: 0x1EFC940 Slot: 29
	protected override Unit GetRecieverUnit() { }
}

// Namespace: 
private class DiscardItemMenu.DiscardItemEmptyMenuItem : BasicItemMenuItem // TypeDefIndex: 12539
{
	// Methods

	// RVA: 0x1EFBD10 Offset: 0x1EFBE11 VA: 0x1EFBD10 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1EFBD20 Offset: 0x1EFBE21 VA: 0x1EFBD20 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x1EFBD30 Offset: 0x1EFBE31 VA: 0x1EFBD30 Slot: 30
	public override string GetBlankText() { }

	// RVA: 0x1EFBDB0 Offset: 0x1EFBEB1 VA: 0x1EFBDB0 Slot: 31
	public override bool IsVisibleItemIconOnBlank() { }

	// RVA: 0x1EFBDC0 Offset: 0x1EFBEC1 VA: 0x1EFBDC0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1EFBEB0 Offset: 0x1EFBFB1 VA: 0x1EFBEB0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1EFBEC0 Offset: 0x1EFBFC1 VA: 0x1EFBEC0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1EFBF70 Offset: 0x1EFC071 VA: 0x1EFBF70
	public void .ctor() { }
}

// Namespace: 
public sealed class DiscardItemMenu.ConfirmDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 12540
{
	// Methods

	// RVA: 0x1DC8DC0 Offset: 0x1DC8EC1 VA: 0x1DC8DC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DC8BB0 Offset: 0x1DC8CB1 VA: 0x1DC8BB0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1DC8DE0 Offset: 0x1DC8EE1 VA: 0x1DC8DE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1DC8E10 Offset: 0x1DC8F11 VA: 0x1DC8E10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class DiscardItemMenu.ConfirmDialog.YesDialogItem : BasicDialogItemYes // TypeDefIndex: 12541
{
	// Fields
	private DiscardItemMenu.ConfirmDialog.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x1DC8AE0 Offset: 0x1DC8BE1 VA: 0x1DC8AE0
	public void .ctor(DiscardItemMenu.ConfirmDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x1DC8B90 Offset: 0x1DC8C91 VA: 0x1DC8B90 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class DiscardItemMenu.ConfirmDialog : YesNoDialog // TypeDefIndex: 12542
{
	// Methods

	// RVA: 0x1EFB3B0 Offset: 0x1EFB4B1 VA: 0x1EFB3B0
	public static void CreateBind(ProcInst super, UnitItem discardingUnitItem, DiscardItemMenu.ConfirmDialog.YesEventHandler decideCallback) { }

	// RVA: 0x1EFB960 Offset: 0x1EFBA61 VA: 0x1EFB960
	private void .ctor(List<BasicMenuItem> menuItemList) { }
}

