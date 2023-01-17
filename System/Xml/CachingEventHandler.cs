// Namespace: System.Xml
internal sealed class CachingEventHandler : MulticastDelegate // TypeDefIndex: 1681
{
	// Methods

	// RVA: 0x1A27CB0 Offset: 0x1A27DB1 VA: 0x1A27CB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A27CD0 Offset: 0x1A27DD1 VA: 0x1A27CD0 Slot: 13
	public virtual void Invoke(XsdCachingReader cachingReader) { }

	// RVA: 0x1A28030 Offset: 0x1A28131 VA: 0x1A28030 Slot: 14
	public virtual IAsyncResult BeginInvoke(XsdCachingReader cachingReader, AsyncCallback callback, object object) { }

	// RVA: 0x1A28060 Offset: 0x1A28161 VA: 0x1A28060 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

