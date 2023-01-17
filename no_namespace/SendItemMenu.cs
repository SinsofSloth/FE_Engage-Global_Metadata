// Namespace: 
public sealed class SendItemMenu.DecideCallback : MulticastDelegate // TypeDefIndex: 12662
{
	// Methods

	// RVA: 0x2037150 Offset: 0x2037251 VA: 0x2037150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2037170 Offset: 0x2037271 VA: 0x2037170 Slot: 13
	public virtual void Invoke(bool selectUnitItem, int unitItemIndex) { }

	// RVA: 0x20373B0 Offset: 0x20374B1 VA: 0x20373B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool selectUnitItem, int unitItemIndex, AsyncCallback callback, object object) { }

	// RVA: 0x2037470 Offset: 0x2037571 VA: 0x2037470 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class SendItemMenu.CancelCallback : MulticastDelegate // TypeDefIndex: 12663
{
	// Methods

	// RVA: 0x2036930 Offset: 0x2036A31 VA: 0x2036930
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2036950 Offset: 0x2036A51 VA: 0x2036950 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2036B60 Offset: 0x2036C61 VA: 0x2036B60 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2036B90 Offset: 0x2036C91 VA: 0x2036B90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class SendItemMenu.SendItemMenuItem : BasicItemMenuItem // TypeDefIndex: 12664
{
	// Methods

	// RVA: 0x2037480 Offset: 0x2037581 VA: 0x2037480 Slot: 4
	public override string GetName() { }

	// RVA: 0x2037760 Offset: 0x2037861 VA: 0x2037760 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2037900 Offset: 0x2037A01 VA: 0x2037900 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2037A80 Offset: 0x2037B81 VA: 0x2037A80 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2037BF0 Offset: 0x2037CF1 VA: 0x2037BF0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2037A20 Offset: 0x2037B21 VA: 0x2037A20
	private SendItemMenu GetSendItemMenu() { }

	// RVA: 0x2037C80 Offset: 0x2037D81 VA: 0x2037C80 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x2037CF0 Offset: 0x2037DF1 VA: 0x2037CF0 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x2037D90 Offset: 0x2037E91 VA: 0x2037D90 Slot: 29
	protected override Unit GetRecieverUnit() { }

	// RVA: 0x20378F0 Offset: 0x20379F1 VA: 0x20378F0
	private bool IsGainItem() { }

	// RVA: 0x2037DA0 Offset: 0x2037EA1 VA: 0x2037DA0
	public void .ctor() { }
}

// Namespace: 
private class SendItemMenu.ConfirmDialog.ConfirmYesDialogItem : BasicDialogItemYes // TypeDefIndex: 12665
{
	// Fields
	private Unit m_Unit; // 0x70
	private int m_UnitItemIndex; // 0x78
	private UnitItem m_GainUnitItem; // 0x80
	private SendItemMenu.DecideCallback m_DecideCallback; // 0x88

	// Methods

	// RVA: 0x21F8EA0 Offset: 0x21F8FA1 VA: 0x21F8EA0
	public void .ctor(Unit unit, int unitItemIndex, UnitItem gainUnitItem, SendItemMenu.DecideCallback decideCallback) { }

	// RVA: 0x21F8F90 Offset: 0x21F9091 VA: 0x21F8F90 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class SendItemMenu.ConfirmDialog : YesNoDialog // TypeDefIndex: 12666
{
	// Methods

	// RVA: 0x2036BA0 Offset: 0x2036CA1 VA: 0x2036BA0
	public static void CreateBind(ProcInst super, Unit unit, int unitItemIndex, UnitItem gainUnitItem, SendItemMenu.DecideCallback decideCallback) { }

	// RVA: 0x20370D0 Offset: 0x20371D1 VA: 0x20370D0
	private void .ctor(List<BasicMenuItem> menuItemList) { }
}

