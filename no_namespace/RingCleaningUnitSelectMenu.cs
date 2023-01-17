// Namespace: 
public sealed class RingCleaningUnitSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11742
{
	// Methods

	// RVA: 0x1F4A280 Offset: 0x1F4A381 VA: 0x1F4A280
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F4A2A0 Offset: 0x1F4A3A1 VA: 0x1F4A2A0 Slot: 13
	public virtual void Invoke(Unit unit) { }

	// RVA: 0x1F4A600 Offset: 0x1F4A701 VA: 0x1F4A600 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, AsyncCallback callback, object object) { }

	// RVA: 0x1F4A630 Offset: 0x1F4A731 VA: 0x1F4A630 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RingCleaningUnitSelectMenu.RingCleaningUnitSelectMenuItem.ConfirmDialog : YesNoDialog // TypeDefIndex: 11744
{
	// Methods

	// RVA: 0x21F5730 Offset: 0x21F5831 VA: 0x21F5730
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x21F57B0 Offset: 0x21F58B1 VA: 0x21F57B0
	public static void CreateBind(ProcInst super, Unit unit, Action action) { }
}

// Namespace: 
public class RingCleaningUnitSelectMenu.RingCleaningUnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 11746
{
	// Fields
	private int m_Index; // 0x64
	private Unit m_Unit; // 0x68
	private bool m_bSelect; // 0x70
	public RingCleaningUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x78

	// Methods

	// RVA: 0x1F4A640 Offset: 0x1F4A741 VA: 0x1F4A640
	public void .ctor(int index, Unit unit, RingCleaningUnitSelectMenu.DecideEventHandler decideEventHandler, Unit selectUnit) { }

	// RVA: 0x1F4A6C0 Offset: 0x1F4A7C1 VA: 0x1F4A6C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F4A6E0 Offset: 0x1F4A7E1 VA: 0x1F4A6E0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F4A780 Offset: 0x1F4A881 VA: 0x1F4A780 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F4A830 Offset: 0x1F4A931 VA: 0x1F4A830 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1F4A860 Offset: 0x1F4A961 VA: 0x1F4A860
	public Unit GetUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C64D0 Offset: 0x2C65D1 VA: 0x2C64D0
	// RVA: 0x1F4A870 Offset: 0x1F4A971 VA: 0x1F4A870
	private void <ACall>b__7_0() { }
}

