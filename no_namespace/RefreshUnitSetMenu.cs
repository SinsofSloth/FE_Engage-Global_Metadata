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

