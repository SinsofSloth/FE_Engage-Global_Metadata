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
[CompilerGeneratedAttribute] // RVA: 0x2778B0 Offset: 0x2779B1 VA: 0x2778B0
private sealed class InvestmentMenu.InvestmentMenuItem.InvestmentSubMenuItem.<>c__DisplayClass6_0 // TypeDefIndex: 11423
{
	// Fields
	public HubNationData parentNationData; // 0x10
	public InvestmentMenu.InvestmentMenuItem.InvestmentSubMenuItem <>4__this; // 0x18

	// Methods

	// RVA: 0x2D751D0 Offset: 0x2D752D1 VA: 0x2D751D0
	public void .ctor() { }

	// RVA: 0x2D751E0 Offset: 0x2D752E1 VA: 0x2D751E0
	internal void <ACall>b__0(GameObject gameObject) { }
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

// Namespace: 
public class InvestmentMenu.InvestmentMenuItem : BasicMenuItem // TypeDefIndex: 11425
{
	// Fields
	private int m_Index; // 0x64

	// Methods

	// RVA: 0x2225AC0 Offset: 0x2225BC1 VA: 0x2225AC0
	public void .ctor(int index) { }

	// RVA: 0x2225AF0 Offset: 0x2225BF1 VA: 0x2225AF0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2225C20 Offset: 0x2225D21 VA: 0x2225C20 Slot: 4
	public override string GetName() { }

	// RVA: 0x2225C90 Offset: 0x2225D91 VA: 0x2225C90 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2225D30 Offset: 0x2225E31 VA: 0x2225D30 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2226060 Offset: 0x2226161 VA: 0x2226060 Slot: 20
	public override BasicMenu.Result XCall() { }

	// RVA: 0x2225B40 Offset: 0x2225C41 VA: 0x2225B40
	public HubNationData GetNationData() { }

	// RVA: 0x22261A0 Offset: 0x22262A1 VA: 0x22261A0
	public int GetNextCost() { }

	// RVA: 0x22261C0 Offset: 0x22262C1 VA: 0x22261C0
	public void Add(int addCost) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5770 Offset: 0x2C5871 VA: 0x2C5770
	// RVA: 0x22269A0 Offset: 0x2226AA1 VA: 0x22269A0
	private void <ACall>b__5_0(int selectId) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5780 Offset: 0x2C5881 VA: 0x2C5780
	// RVA: 0x2226A80 Offset: 0x2226B81 VA: 0x2226A80
	private void <XCall>b__6_0(int selectId) { }
}

