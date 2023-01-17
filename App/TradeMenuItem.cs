// Namespace: App
public abstract class TradeMenuItem : BasicItemMenuItem // TypeDefIndex: 12676
{
	// Methods

	// RVA: 0x25EA200 Offset: 0x25EA301 VA: 0x25EA200 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x25EB0D0 Offset: 0x25EB1D1 VA: 0x25EB0D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x25EB990 Offset: 0x25EBA91 VA: 0x25EB990 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x25EBC20 Offset: 0x25EBD21 VA: 0x25EBC20 Slot: 5
	public override float GetWidth() { }

	// RVA: 0x25EBCA0 Offset: 0x25EBDA1 VA: 0x25EBCA0 Slot: 6
	public override float GetHeight() { }

	// RVA: 0x25EBD20 Offset: 0x25EBE21 VA: 0x25EBD20 Slot: 28
	public override Unit GetUnit() { }

	// RVA: 0x25EBD50 Offset: 0x25EBE51 VA: 0x25EBD50 Slot: 27
	public override UnitItem GetUnitItem() { }

	// RVA: 0x25EAEC0 Offset: 0x25EAFC1 VA: 0x25EAEC0
	public TradeMenu GetTradeMenu() { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract Unit GetLeftUnit();

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract Unit GetRightUnit();

	// RVA: 0x25EBD90 Offset: 0x25EBE91 VA: 0x25EBD90 Slot: 36
	protected virtual int GetLeftInitialSelectIndex() { }

	// RVA: 0x25EBDA0 Offset: 0x25EBEA1 VA: 0x25EBDA0 Slot: 37
	protected virtual int GetRightInitialSelectIndex() { }

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract void SetDone();

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract bool IsDone();

	// RVA: 0x25EBDB0 Offset: 0x25EBEB1 VA: 0x25EBDB0 Slot: 40
	protected virtual void OnTrade() { }

	// RVA: 0x25EBDC0 Offset: 0x25EBEC1 VA: 0x25EBDC0 Slot: 41
	protected virtual void OnEnd() { }

	// RVA: 0x25EAF40 Offset: 0x25EB041 VA: 0x25EAF40
	protected BasicMenuItem.Attribute BuildAttributeSelect() { }

	// RVA: 0x25EB170 Offset: 0x25EB271 VA: 0x25EB170
	protected BasicMenu.Result Trade() { }

	// RVA: 0x25EB780 Offset: 0x25EB881 VA: 0x25EB780
	protected BasicMenu.Result SelectFirstItem() { }

	// RVA: 0x25EBDD0 Offset: 0x25EBED1 VA: 0x25EBDD0
	protected void .ctor() { }
}

