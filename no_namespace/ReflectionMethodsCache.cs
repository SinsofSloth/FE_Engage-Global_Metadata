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
public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 4361
{
	// Methods

	// RVA: 0x1C00420 Offset: 0x1C00521 VA: 0x1C00420
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C00440 Offset: 0x1C00541 VA: 0x1C00440 Slot: 13
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1C00790 Offset: 0x1C00891 VA: 0x1C00790 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1C00880 Offset: 0x1C00981 VA: 0x1C00880 Slot: 15
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }
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
public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 4363
{
	// Methods

	// RVA: 0x1BFFAC0 Offset: 0x1BFFBC1 VA: 0x1BFFAC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BFFAE0 Offset: 0x1BFFBE1 VA: 0x1BFFAE0 Slot: 13
	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	// RVA: 0x1BFFDE0 Offset: 0x1BFFEE1 VA: 0x1BFFDE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1BFFEE0 Offset: 0x1BFFFE1 VA: 0x1BFFEE0 Slot: 15
	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }
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

