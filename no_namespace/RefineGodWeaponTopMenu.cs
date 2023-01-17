// Namespace: 
public enum RefineGodWeaponTopMenu.Result2 // TypeDefIndex: 11077
{
	// Fields
	public int value__; // 0x0
	public const RefineGodWeaponTopMenu.Result2 Refine = 0;
	public const RefineGodWeaponTopMenu.Result2 Reset = 1;
	public const RefineGodWeaponTopMenu.Result2 End = 2;
}

// Namespace: 
public sealed class RefineGodWeaponTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11078
{
	// Methods

	// RVA: 0x1F31110 Offset: 0x1F31211 VA: 0x1F31110
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F31130 Offset: 0x1F31231 VA: 0x1F31130 Slot: 13
	public virtual void Invoke(RefineGodWeaponTopMenu.Result2 result) { }

	// RVA: 0x1F31390 Offset: 0x1F31491 VA: 0x1F31390 Slot: 14
	public virtual IAsyncResult BeginInvoke(RefineGodWeaponTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1F31420 Offset: 0x1F31521 VA: 0x1F31420 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefineGodWeaponTopMenu.RefineMenuItem : BasicMenuItem // TypeDefIndex: 11079
{
	// Fields
	public RefineGodWeaponTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F31430 Offset: 0x1F31531 VA: 0x1F31430
	public void .ctor(RefineGodWeaponTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F314E0 Offset: 0x1F315E1 VA: 0x1F314E0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class RefineGodWeaponTopMenu.ResetMenuItem : BasicMenuItem // TypeDefIndex: 11080
{
	// Fields
	public RefineGodWeaponTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F31510 Offset: 0x1F31611 VA: 0x1F31510
	public void .ctor(RefineGodWeaponTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F315C0 Offset: 0x1F316C1 VA: 0x1F315C0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

