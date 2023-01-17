// Namespace: UnityEngine.Experimental.Rendering.Universal.LibTessDotNet
internal sealed class CombineCallback : MulticastDelegate // TypeDefIndex: 5529
{
	// Methods

	// RVA: 0x2D2C770 Offset: 0x2D2C871 VA: 0x2D2C770
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D2C790 Offset: 0x2D2C891 VA: 0x2D2C790 Slot: 13
	public virtual object Invoke(Vec3 position, object[] data, float[] weights) { }

	// RVA: 0x2D2CA60 Offset: 0x2D2CB61 VA: 0x2D2CA60 Slot: 14
	public virtual IAsyncResult BeginInvoke(Vec3 position, object[] data, float[] weights, AsyncCallback callback, object object) { }

	// RVA: 0x2D2CB10 Offset: 0x2D2CC11 VA: 0x2D2CB10 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

