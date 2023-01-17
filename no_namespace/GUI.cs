// Namespace: 
public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 4145
{
	// Methods

	// RVA: 0x1C65A70 Offset: 0x1C65B71 VA: 0x1C65A70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C65A90 Offset: 0x1C65B91 VA: 0x1C65A90 Slot: 13
	public virtual void Invoke(int id) { }

	// RVA: 0x1C65CC0 Offset: 0x1C65DC1 VA: 0x1C65CC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

	// RVA: 0x1C65D50 Offset: 0x1C65E51 VA: 0x1C65D50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

