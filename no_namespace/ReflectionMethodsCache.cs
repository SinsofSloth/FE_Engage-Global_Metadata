// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 4365
{
	// Methods

	// RVA: 0x1BFF140 Offset: 0x1BFF241 VA: 0x1BFF140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BFF160 Offset: 0x1BFF261 VA: 0x1BFF160 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x1BFF4D0 Offset: 0x1BFF5D1 VA: 0x1BFF4D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1BFF5D0 Offset: 0x1BFF6D1 VA: 0x1BFF5D0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

