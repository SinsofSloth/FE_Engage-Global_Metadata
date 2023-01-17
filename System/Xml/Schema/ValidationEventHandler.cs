// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler : MulticastDelegate // TypeDefIndex: 1942
{
	// Methods

	// RVA: 0x19BC430 Offset: 0x19BC531 VA: 0x19BC430
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19B0370 Offset: 0x19B0471 VA: 0x19B0370 Slot: 13
	public virtual void Invoke(object sender, ValidationEventArgs e) { }

	// RVA: 0x19BC450 Offset: 0x19BC551 VA: 0x19BC450 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ValidationEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x19BC480 Offset: 0x19BC581 VA: 0x19BC480 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

