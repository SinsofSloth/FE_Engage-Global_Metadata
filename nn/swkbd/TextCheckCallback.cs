// Namespace: nn.swkbd
[UnmanagedFunctionPointerAttribute] // RVA: 0x27A310 Offset: 0x27A411 VA: 0x27A310
public sealed class TextCheckCallback : MulticastDelegate // TypeDefIndex: 14516
{
	// Methods

	// RVA: 0x25DA8E0 Offset: 0x25DA9E1 VA: 0x25DA8E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x25DA900 Offset: 0x25DAA01 VA: 0x25DA900 Slot: 13
	public virtual TextCheckResult Invoke(IntPtr pOutDialogTextBuf, ref long pOutDialogTextLengthSize, ref String pStr) { }

	// RVA: 0x25DAB60 Offset: 0x25DAC61 VA: 0x25DAB60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr pOutDialogTextBuf, ref long pOutDialogTextLengthSize, ref String pStr, AsyncCallback callback, object object) { }

	// RVA: 0x25DAC50 Offset: 0x25DAD51 VA: 0x25DAC50 Slot: 15
	public virtual TextCheckResult EndInvoke(ref long pOutDialogTextLengthSize, ref String pStr, IAsyncResult result) { }
}

