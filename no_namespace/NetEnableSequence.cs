// Namespace: 
public sealed class NetEnableSequence.ResultFunction : MulticastDelegate // TypeDefIndex: 12710
{
	// Methods

	// RVA: 0x26E79C0 Offset: 0x26E7AC1 VA: 0x26E79C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26E79E0 Offset: 0x26E7AE1 VA: 0x26E79E0 Slot: 13
	public virtual void Invoke(bool isEnable) { }

	// RVA: 0x26E7C10 Offset: 0x26E7D11 VA: 0x26E7C10 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isEnable, AsyncCallback callback, object object) { }

	// RVA: 0x26E7CB0 Offset: 0x26E7DB1 VA: 0x26E7CB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum NetEnableSequence.Label // TypeDefIndex: 12711
{
	// Fields
	public int value__; // 0x0
	public const NetEnableSequence.Label Login = 0;
	public const NetEnableSequence.Label Result = 1;
}

// Namespace: 
private struct NetEnableSequence.Arg // TypeDefIndex: 12712
{
	// Fields
	public bool withoutConfirm; // 0x0
	public bool canWriteConfig; // 0x1
	public bool isNetLoginOnce; // 0x2
	public bool isReflectNetResult; // 0x3
	public NetEnableSequence.ResultFunction resultFunc; // 0x8
}

// Namespace: 
private class NetEnableSequence.ConfirmDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 12713
{
	// Methods

	// RVA: 0x21ED610 Offset: 0x21ED711 VA: 0x21ED610 Slot: 4
	public override string GetName() { }

	// RVA: 0x21ED690 Offset: 0x21ED791 VA: 0x21ED690 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21ED710 Offset: 0x21ED811 VA: 0x21ED710
	public void .ctor() { }
}

// Namespace: 
private class NetEnableSequence.ConfirmDialog.NoMenuItem : BasicDialogItemNo // TypeDefIndex: 12714
{
	// Methods

	// RVA: 0x21ED580 Offset: 0x21ED681 VA: 0x21ED580 Slot: 4
	public override string GetName() { }

	// RVA: 0x21ED600 Offset: 0x21ED701 VA: 0x21ED600
	public void .ctor() { }
}

// Namespace: 
private class NetEnableSequence.ConfirmDialog // TypeDefIndex: 12715
{
	// Methods

	// RVA: 0x26E78B0 Offset: 0x26E79B1 VA: 0x26E78B0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x26E79B0 Offset: 0x26E7AB1 VA: 0x26E79B0
	public void .ctor() { }
}

