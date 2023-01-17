// Namespace: 
public enum MascotTopMenu.MenuResult // TypeDefIndex: 10859
{
	// Fields
	public int value__; // 0x0
	public const MascotTopMenu.MenuResult Meal = 0;
	public const MascotTopMenu.MenuResult Strok = 1;
	public const MascotTopMenu.MenuResult Custom = 2;
	public const MascotTopMenu.MenuResult End = 3;
}

// Namespace: 
public sealed class MascotTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10860
{
	// Methods

	// RVA: 0x2152150 Offset: 0x2152251 VA: 0x2152150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2151EE0 Offset: 0x2151FE1 VA: 0x2151EE0 Slot: 13
	public virtual void Invoke(MascotTopMenu.MenuResult result) { }

	// RVA: 0x2152170 Offset: 0x2152271 VA: 0x2152170 Slot: 14
	public virtual IAsyncResult BeginInvoke(MascotTopMenu.MenuResult result, AsyncCallback callback, object object) { }

	// RVA: 0x2152200 Offset: 0x2152301 VA: 0x2152200 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class MascotTopMenu.MealMenuItem : BasicMenuItem // TypeDefIndex: 10861
{
	// Fields
	private MascotTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x2152210 Offset: 0x2152311 VA: 0x2152210
	public void .ctor(MascotTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x2152250 Offset: 0x2152351 VA: 0x2152250 Slot: 4
	public override string GetName() { }

	// RVA: 0x21522D0 Offset: 0x21523D1 VA: 0x21522D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21522E0 Offset: 0x21523E1 VA: 0x21522E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2152310 Offset: 0x2152411 VA: 0x2152310 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MascotTopMenu.StrokMenuItem : BasicMenuItem // TypeDefIndex: 10862
{
	// Fields
	private MascotTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x2152320 Offset: 0x2152421 VA: 0x2152320
	public void .ctor(MascotTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x2152360 Offset: 0x2152461 VA: 0x2152360 Slot: 4
	public override string GetName() { }

	// RVA: 0x21523E0 Offset: 0x21524E1 VA: 0x21523E0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21523F0 Offset: 0x21524F1 VA: 0x21523F0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2152420 Offset: 0x2152521 VA: 0x2152420 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MascotTopMenu.CustomMenuItem : BasicMenuItem // TypeDefIndex: 10863
{
	// Fields
	private MascotTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x2151DE0 Offset: 0x2151EE1 VA: 0x2151DE0
	public void .ctor(MascotTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x2151E20 Offset: 0x2151F21 VA: 0x2151E20 Slot: 4
	public override string GetName() { }

	// RVA: 0x2151EA0 Offset: 0x2151FA1 VA: 0x2151EA0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2151EB0 Offset: 0x2151FB1 VA: 0x2151EB0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2152140 Offset: 0x2152241 VA: 0x2152140 Slot: 19
	public override BasicMenu.Result BCall() { }
}

