// Namespace: 
private class UnitSelectAllUnitMenu.EntrustMenuItem : BasicMenuItem // TypeDefIndex: 13304
{
	// Fields
	private SortieEntrustResult m_Result; // 0x64

	// Methods

	// RVA: 0x1ED5A60 Offset: 0x1ED5B61 VA: 0x1ED5A60 Slot: 4
	public override string GetName() { }

	// RVA: 0x1ED5AE0 Offset: 0x1ED5BE1 VA: 0x1ED5AE0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1ED5B20 Offset: 0x1ED5C21 VA: 0x1ED5B20 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1ED5D10 Offset: 0x1ED5E11 VA: 0x1ED5D10 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1ED5DF0 Offset: 0x1ED5EF1 VA: 0x1ED5DF0
	private void Decide() { }

	// RVA: 0x1ED5ED0 Offset: 0x1ED5FD1 VA: 0x1ED5ED0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB6B0 Offset: 0x2CB7B1 VA: 0x2CB6B0
	// RVA: 0x1ED5EE0 Offset: 0x1ED5FE1 VA: 0x1ED5EE0
	private void <ACall>b__3_0(ProcInst super) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB6C0 Offset: 0x2CB7C1 VA: 0x2CB6C0
	// RVA: 0x1ED5FC0 Offset: 0x1ED60C1 VA: 0x1ED5FC0
	private bool <ACall>b__3_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB6D0 Offset: 0x2CB7D1 VA: 0x2CB6D0
	// RVA: 0x1ED5FD0 Offset: 0x1ED60D1 VA: 0x1ED5FD0
	private void <ACall>b__3_2(ProcInst super) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB6E0 Offset: 0x2CB7E1 VA: 0x2CB6E0
	// RVA: 0x1ED5FF0 Offset: 0x1ED60F1 VA: 0x1ED5FF0
	private void <ACall>b__3_3() { }
}

// Namespace: 
private class UnitSelectAllUnitMenu.StoreAllMenuItem : BasicMenuItem // TypeDefIndex: 13306
{
	// Fields
	private bool m_IsSuccess; // 0x64

	// Methods

	// RVA: 0x1ED60D0 Offset: 0x1ED61D1 VA: 0x1ED60D0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1ED6150 Offset: 0x1ED6251 VA: 0x1ED6150 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1ED63B0 Offset: 0x1ED64B1 VA: 0x1ED63B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1ED65C0 Offset: 0x1ED66C1 VA: 0x1ED65C0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1ED6320 Offset: 0x1ED6421 VA: 0x1ED6320
	private static bool IsTarget(Unit unit) { }

	// RVA: 0x1ED66A0 Offset: 0x1ED67A1 VA: 0x1ED66A0
	private void Decide() { }

	// RVA: 0x1ED6840 Offset: 0x1ED6941 VA: 0x1ED6840
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB6F0 Offset: 0x2CB7F1 VA: 0x2CB6F0
	// RVA: 0x1ED6850 Offset: 0x1ED6951 VA: 0x1ED6850
	private void <ACall>b__3_0(ProcInst super) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB700 Offset: 0x2CB801 VA: 0x2CB700
	// RVA: 0x1ED6930 Offset: 0x1ED6A31 VA: 0x1ED6930
	private bool <ACall>b__3_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB710 Offset: 0x2CB811 VA: 0x2CB710
	// RVA: 0x1ED6940 Offset: 0x1ED6A41 VA: 0x1ED6940
	private void <ACall>b__3_3() { }
}

// Namespace: 
public sealed class UnitSelectAllUnitMenu.ConfirmDialog.CloseEventHandler : MulticastDelegate // TypeDefIndex: 13308
{
	// Methods

	// RVA: 0x2D695A0 Offset: 0x2D696A1 VA: 0x2D695A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D695C0 Offset: 0x2D696C1 VA: 0x2D695C0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2D697D0 Offset: 0x2D698D1 VA: 0x2D697D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2D69800 Offset: 0x2D69901 VA: 0x2D69800 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class UnitSelectAllUnitMenu.ConfirmDialog.ConfirmNoDialogItem : BasicDialogItemNo // TypeDefIndex: 13310
{
	// Methods

	// RVA: 0x2D69810 Offset: 0x2D69911 VA: 0x2D69810
	public void .ctor(string text) { }

	// RVA: 0x2D69820 Offset: 0x2D69921 VA: 0x2D69820 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }
}

// Namespace: 
private enum UnitSelectAllUnitMenu.ConfirmSequence.Label // TypeDefIndex: 13312
{
	// Fields
	public int value__; // 0x0
	public const UnitSelectAllUnitMenu.ConfirmSequence.Label End = 0;
}

// Namespace: 
public sealed class UnitSelectAllUnitMenu.ConfirmSequence.CheckEventHandler : MulticastDelegate // TypeDefIndex: 13314
{
	// Methods

	// RVA: 0x2D6A650 Offset: 0x2D6A751 VA: 0x2D6A650
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D69EA0 Offset: 0x2D69FA1 VA: 0x2D69EA0 Slot: 13
	public virtual bool Invoke() { }

	// RVA: 0x2D6A670 Offset: 0x2D6A771 VA: 0x2D6A670 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2D6A6A0 Offset: 0x2D6A7A1 VA: 0x2D6A6A0 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class UnitSelectAllUnitMenu.ConfirmSequence.EndEventHandler : MulticastDelegate // TypeDefIndex: 13316
{
	// Methods

	// RVA: 0x2D6A730 Offset: 0x2D6A831 VA: 0x2D6A730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D6A440 Offset: 0x2D6A541 VA: 0x2D6A440 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2D6A750 Offset: 0x2D6A851 VA: 0x2D6A750 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2D6A780 Offset: 0x2D6A881 VA: 0x2D6A780 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class UnitSelectAllUnitMenu.ConfirmSequence : ProcInst // TypeDefIndex: 13318
{
	// Methods

	// RVA: 0x1ED5610 Offset: 0x1ED5711 VA: 0x1ED5610
	public static void CreateBind(ProcInst super, UnitSelectAllUnitMenu.ConfirmSequence.DecideEventHandler decide, UnitSelectAllUnitMenu.ConfirmSequence.CheckEventHandler check, UnitSelectAllUnitMenu.ConfirmSequence.FailureEventHandler failure, UnitSelectAllUnitMenu.ConfirmSequence.EndEventHandler end) { }

	// RVA: 0x1ED5A50 Offset: 0x1ED5B51 VA: 0x1ED5A50
	public void .ctor() { }
}

