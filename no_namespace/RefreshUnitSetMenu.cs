// Namespace: 
public enum RefreshUnitSetMenu.Result2 // TypeDefIndex: 11714
{
	// Fields
	public int value__; // 0x0
	public const RefreshUnitSetMenu.Result2 UnitSelect = 0;
	public const RefreshUnitSetMenu.Result2 Ok = 1;
	public const RefreshUnitSetMenu.Result2 OkWithoutDemo = 2;
	public const RefreshUnitSetMenu.Result2 Cancel = 3;
}

// Namespace: 
public sealed class RefreshUnitSetMenu.SelectFacilityEventHandler : MulticastDelegate // TypeDefIndex: 11715
{
	// Methods

	// RVA: 0x1F3C120 Offset: 0x1F3C221 VA: 0x1F3C120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3C140 Offset: 0x1F3C241 VA: 0x1F3C140 Slot: 13
	public virtual void Invoke(HubFacilityData facilityData) { }

	// RVA: 0x1F3C4A0 Offset: 0x1F3C5A1 VA: 0x1F3C4A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(HubFacilityData facilityData, AsyncCallback callback, object object) { }

	// RVA: 0x1F3C4D0 Offset: 0x1F3C5D1 VA: 0x1F3C4D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RefreshUnitSetMenu.SetUnitEventHandler : MulticastDelegate // TypeDefIndex: 11716
{
	// Methods

	// RVA: 0x1F3C4E0 Offset: 0x1F3C5E1 VA: 0x1F3C4E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3C500 Offset: 0x1F3C601 VA: 0x1F3C500 Slot: 13
	public virtual void Invoke(int unitIndex, Unit unit) { }

	// RVA: 0x1F3C740 Offset: 0x1F3C841 VA: 0x1F3C740 Slot: 14
	public virtual IAsyncResult BeginInvoke(int unitIndex, Unit unit, AsyncCallback callback, object object) { }

	// RVA: 0x1F3C7E0 Offset: 0x1F3C8E1 VA: 0x1F3C7E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RefreshUnitSetMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11717
{
	// Methods

	// RVA: 0x1F3BDA0 Offset: 0x1F3BEA1 VA: 0x1F3BDA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F3BDC0 Offset: 0x1F3BEC1 VA: 0x1F3BDC0 Slot: 13
	public virtual void Invoke(RefreshUnitSetMenu.Result2 result, int unitIndex, HubFacilityData facilityData) { }

	// RVA: 0x1F3C050 Offset: 0x1F3C151 VA: 0x1F3C050 Slot: 14
	public virtual IAsyncResult BeginInvoke(RefreshUnitSetMenu.Result2 result, int unitIndex, HubFacilityData facilityData, AsyncCallback callback, object object) { }

	// RVA: 0x1F3C110 Offset: 0x1F3C211 VA: 0x1F3C110 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

