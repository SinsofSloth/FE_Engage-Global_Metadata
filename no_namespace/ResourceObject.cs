// Namespace: 
public sealed class ResourceObject.Callback : MulticastDelegate // TypeDefIndex: 13920
{
	// Methods

	// RVA: 0x1F47280 Offset: 0x1F47381 VA: 0x1F47280
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F472A0 Offset: 0x1F473A1 VA: 0x1F472A0 Slot: 13
	public virtual void Invoke(GameObject go) { }

	// RVA: 0x1F47600 Offset: 0x1F47701 VA: 0x1F47600 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

	// RVA: 0x1F47630 Offset: 0x1F47731 VA: 0x1F47630 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ResourceObject.Coroutine : MulticastDelegate // TypeDefIndex: 13921
{
	// Methods

	// RVA: 0x1F47640 Offset: 0x1F47741 VA: 0x1F47640
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F47660 Offset: 0x1F47761 VA: 0x1F47660 Slot: 13
	public virtual IEnumerator Invoke(GameObject go) { }

	// RVA: 0x1F479C0 Offset: 0x1F47AC1 VA: 0x1F479C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

	// RVA: 0x1F479F0 Offset: 0x1F47AF1 VA: 0x1F479F0 Slot: 15
	public virtual IEnumerator EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum ResourceObject.Sequence // TypeDefIndex: 13922
{
	// Fields
	public int value__; // 0x0
	public const ResourceObject.Sequence Start = 0;
	public const ResourceObject.Sequence Tick = 1;
	public const ResourceObject.Sequence End = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x279340 Offset: 0x279441 VA: 0x279340
private enum ResourceObject.Flags // TypeDefIndex: 13923
{
	// Fields
	public int value__; // 0x0
	public const ResourceObject.Flags DoneStart = 1;
	public const ResourceObject.Flags DoneEnd = 2;
	public const ResourceObject.Flags Endless = 4;
	public const ResourceObject.Flags Binding = 8;
	public const ResourceObject.Flags CanSkip = 16;
}

