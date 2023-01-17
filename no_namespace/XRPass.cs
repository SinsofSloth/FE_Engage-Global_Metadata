// Namespace: 
internal sealed class XRPass.CustomMirrorView : MulticastDelegate // TypeDefIndex: 5378
{
	// Methods

	// RVA: 0x2FA7190 Offset: 0x2FA7291 VA: 0x2FA7190
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2FA01F0 Offset: 0x2FA02F1 VA: 0x2FA01F0 Slot: 13
	public virtual void Invoke(XRPass pass, CommandBuffer cmd, RenderTexture rt, Rect viewport) { }

	// RVA: 0x2FA71B0 Offset: 0x2FA72B1 VA: 0x2FA71B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(XRPass pass, CommandBuffer cmd, RenderTexture rt, Rect viewport, AsyncCallback callback, object object) { }

	// RVA: 0x2FA7260 Offset: 0x2FA7361 VA: 0x2FA7260 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

