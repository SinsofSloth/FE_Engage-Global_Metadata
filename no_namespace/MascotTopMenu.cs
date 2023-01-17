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

