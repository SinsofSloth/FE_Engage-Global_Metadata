// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3B5D0 Offset: 0x3B6D1 VA: 0x3B5D0
[Serializable]
private sealed class DebugManager.<>c // TypeDefIndex: 4549
{
	// Fields
	public static readonly DebugManager.<>c <>9; // 0x0
	public static Action<bool> <>9__52_0; // 0x8
	public static Action <>9__52_1; // 0x10

	// Methods

	// RVA: 0x354F160 Offset: 0x354F261 VA: 0x354F160
	private static void .cctor() { }

	// RVA: 0x354F1D0 Offset: 0x354F2D1 VA: 0x354F1D0
	public void .ctor() { }

	// RVA: 0x354F1E0 Offset: 0x354F2E1 VA: 0x354F1E0
	internal void <.ctor>b__52_0(bool <p0>) { }

	// RVA: 0x354F1F0 Offset: 0x354F2F1 VA: 0x354F1F0
	internal void <.ctor>b__52_1() { }

	// RVA: 0x354F200 Offset: 0x354F301 VA: 0x354F200
	internal DebugManager <.cctor>b__69_0() { }
}

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
private class DebugManager.LogArg : IDisposable // TypeDefIndex: 9101
{
	// Fields
	private StackFrame m_Stack; // 0x10
	private DebugManager.LogFunc m_Func; // 0x18
	private string[] m_Args; // 0x20

	// Methods

	// RVA: 0x1E13570 Offset: 0x1E13671 VA: 0x1E13570
	public void .ctor(StackFrame stack, DebugManager.LogFunc func, string[] args) { }

	// RVA: 0x1E135E0 Offset: 0x1E136E1 VA: 0x1E135E0
	public string Call() { }

	// RVA: 0x1E139E0 Offset: 0x1E13AE1 VA: 0x1E139E0 Slot: 4
	public void Dispose() { }
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

