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
private enum ResourceObject.Sequence // TypeDefIndex: 13922
{
	// Fields
	public int value__; // 0x0
	public const ResourceObject.Sequence Start = 0;
	public const ResourceObject.Sequence Tick = 1;
	public const ResourceObject.Sequence End = 2;
}

