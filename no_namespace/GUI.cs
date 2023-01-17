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

// Namespace: 
public abstract class GUI.Scope : IDisposable // TypeDefIndex: 4146
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x3C8A590 Offset: 0x3C8A691 VA: 0x3C8A590 Slot: 5
	internal virtual void Dispose(bool disposing) { }

	// RVA: 0x3C8A620 Offset: 0x3C8A721 VA: 0x3C8A620 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3C8A780 Offset: 0x3C8A881 VA: 0x3C8A780 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void CloseScope();

	// RVA: 0x3C8A800 Offset: 0x3C8A901 VA: 0x3C8A800
	protected void .ctor() { }
}

