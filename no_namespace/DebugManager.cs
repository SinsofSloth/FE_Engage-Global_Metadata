// Namespace: 
public sealed class DebugManager.LogFunc : MulticastDelegate // TypeDefIndex: 9100
{
	// Methods

	// RVA: 0x1E13A30 Offset: 0x1E13B31 VA: 0x1E13A30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E137D0 Offset: 0x1E138D1 VA: 0x1E137D0 Slot: 13
	public virtual string Invoke() { }

	// RVA: 0x1E13A50 Offset: 0x1E13B51 VA: 0x1E13A50 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1E13A80 Offset: 0x1E13B81 VA: 0x1E13A80 Slot: 15
	public virtual string EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class DebugManager.LogScope : IDisposable // TypeDefIndex: 9102
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x1E13A90 Offset: 0x1E13B91 VA: 0x1E13A90
	public void .ctor(DebugManager.LogFunc func, string[] args) { }

	// RVA: 0x1E13AA0 Offset: 0x1E13BA1 VA: 0x1E13AA0
	public void .ctor(string[] args) { }

	// RVA: 0x1E13AB0 Offset: 0x1E13BB1 VA: 0x1E13AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E13AC0 Offset: 0x1E13BC1 VA: 0x1E13AC0 Slot: 4
	public void Dispose() { }
}

