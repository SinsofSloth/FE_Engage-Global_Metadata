// Namespace: 
public sealed class PhotographSelectDisposMenu.ReturnHandler : MulticastDelegate // TypeDefIndex: 11505
{
	// Methods

	// RVA: 0x1F1F950 Offset: 0x1F1FA51 VA: 0x1F1F950
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1F970 Offset: 0x1F1FA71 VA: 0x1F1F970 Slot: 13
	public virtual void Invoke(PhotographSequence.Label NextLabel) { }

	// RVA: 0x1F1FBD0 Offset: 0x1F1FCD1 VA: 0x1F1FBD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(PhotographSequence.Label NextLabel, AsyncCallback callback, object object) { }

	// RVA: 0x1F1FC60 Offset: 0x1F1FD61 VA: 0x1F1FC60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PhotographSelectDisposMenu.ConfirmDialog.YesHandler : MulticastDelegate // TypeDefIndex: 11506
{
	// Methods

	// RVA: 0x21F2170 Offset: 0x21F2271 VA: 0x21F2170
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21F2190 Offset: 0x21F2291 VA: 0x21F2190 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x21F23A0 Offset: 0x21F24A1 VA: 0x21F23A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x21F23D0 Offset: 0x21F24D1 VA: 0x21F23D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PhotographSelectDisposMenu.ConfirmDialog.NoHandler : MulticastDelegate // TypeDefIndex: 11507
{
	// Methods

	// RVA: 0x21F1E90 Offset: 0x21F1F91 VA: 0x21F1E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21F1EB0 Offset: 0x21F1FB1 VA: 0x21F1EB0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x21F20C0 Offset: 0x21F21C1 VA: 0x21F20C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x21F20F0 Offset: 0x21F21F1 VA: 0x21F20F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class PhotographSelectDisposMenu.ConfirmDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11508
{
	// Fields
	private PhotographSelectDisposMenu.ConfirmDialog.YesHandler m_YesHandler; // 0x70
	private PhotographSelectDisposMenu.ConfirmDialog.NoHandler m_NoHandler; // 0x78

	// Methods

	// RVA: 0x21F23E0 Offset: 0x21F24E1 VA: 0x21F23E0
	public void .ctor(PhotographSelectDisposMenu.ConfirmDialog.YesHandler yesHandler, PhotographSelectDisposMenu.ConfirmDialog.NoHandler noHandler) { }

	// RVA: 0x21F2430 Offset: 0x21F2531 VA: 0x21F2430 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21F2450 Offset: 0x21F2551 VA: 0x21F2450 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class PhotographSelectDisposMenu.ConfirmDialog.NoMenuItem : BasicDialogItemNo // TypeDefIndex: 11509
{
	// Fields
	private PhotographSelectDisposMenu.ConfirmDialog.NoHandler m_NoHandler; // 0x70

	// Methods

	// RVA: 0x21F2100 Offset: 0x21F2201 VA: 0x21F2100
	public void .ctor(PhotographSelectDisposMenu.ConfirmDialog.NoHandler noHandler) { }

	// RVA: 0x21F2140 Offset: 0x21F2241 VA: 0x21F2140 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21F2160 Offset: 0x21F2261 VA: 0x21F2160 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
public class PhotographSelectDisposMenu.ConfirmDialog // TypeDefIndex: 11510
{
	// Methods

	// RVA: 0x1F1F830 Offset: 0x1F1F931 VA: 0x1F1F830
	public static void CreateBind(ProcInst super, PhotographSelectDisposMenu.ConfirmDialog.YesHandler yesHandler, PhotographSelectDisposMenu.ConfirmDialog.NoHandler noHandler) { }

	// RVA: 0x1F1F940 Offset: 0x1F1FA41 VA: 0x1F1F940
	public void .ctor() { }
}

