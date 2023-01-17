// Namespace: 
public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 4360
{
	// Methods

	// RVA: 0x1BFFF30 Offset: 0x1C00031 VA: 0x1BFFF30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BFFF50 Offset: 0x1C00051 VA: 0x1BFFF50 Slot: 13
	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x1C002C0 Offset: 0x1C003C1 VA: 0x1C002C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1C003E0 Offset: 0x1C004E1 VA: 0x1C003E0 Slot: 15
	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 4362
{
	// Methods

	// RVA: 0x1BFF600 Offset: 0x1BFF701 VA: 0x1BFF600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BFF620 Offset: 0x1BFF721 VA: 0x1BFF620 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x1BFF990 Offset: 0x1BFFA91 VA: 0x1BFF990 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1BFFA90 Offset: 0x1BFFB91 VA: 0x1BFFA90 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 4364
{
	// Methods

	// RVA: 0x1BFECD0 Offset: 0x1BFEDD1 VA: 0x1BFECD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BFECF0 Offset: 0x1BFEDF1 VA: 0x1BFECF0 Slot: 13
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1BFF040 Offset: 0x1BFF141 VA: 0x1BFF040 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1BFF130 Offset: 0x1BFF231 VA: 0x1BFF130 Slot: 15
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }
}

