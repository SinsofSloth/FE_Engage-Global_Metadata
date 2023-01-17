// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 1711
{
	// Methods

	// RVA: 0x32F9B30 Offset: 0x32F9C31 VA: 0x32F9B30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x32F9B50 Offset: 0x32F9C51 VA: 0x32F9B50 Slot: 13
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }

	// RVA: 0x32F9EC0 Offset: 0x32F9FC1 VA: 0x32F9EC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, XmlNodeChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x32F9EF0 Offset: 0x32F9FF1 VA: 0x32F9EF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

