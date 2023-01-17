// Namespace: 
public sealed class InvestmentMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11422
{
	// Methods

	// RVA: 0x22257D0 Offset: 0x22258D1 VA: 0x22257D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22257F0 Offset: 0x22258F1 VA: 0x22257F0 Slot: 13
	public virtual void Invoke(int index) { }

	// RVA: 0x2225A20 Offset: 0x2225B21 VA: 0x2225A20 Slot: 14
	public virtual IAsyncResult BeginInvoke(int index, AsyncCallback callback, object object) { }

	// RVA: 0x2225AB0 Offset: 0x2225BB1 VA: 0x2225AB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class InvestmentMenu.InvestmentMenuItem.InvestmentSubMenuItem : BasicMenuItem // TypeDefIndex: 11424
{
	// Fields
	private int m_useCost; // 0x64
	private InvestmentMenu.InvestmentMenuItem m_parent; // 0x68

	// Methods

	// RVA: 0x1DD15C0 Offset: 0x1DD16C1 VA: 0x1DD15C0
	public void .ctor(int cost, InvestmentMenu.InvestmentMenuItem parent) { }

	// RVA: 0x1DD17C0 Offset: 0x1DD18C1 VA: 0x1DD17C0 Slot: 7
	public override void SetTextColor(Color color, bool bInactive) { }

	// RVA: 0x1DD1950 Offset: 0x1DD1A51 VA: 0x1DD1950 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1DD1A40 Offset: 0x1DD1B41 VA: 0x1DD1A40 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DD1B20 Offset: 0x1DD1C21 VA: 0x1DD1B20 Slot: 18
	public override BasicMenu.Result ACall() { }
}

