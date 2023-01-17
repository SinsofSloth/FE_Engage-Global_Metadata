// Namespace: 
public class EventSequence.Coroutine // TypeDefIndex: 10249
{
	// Fields
	private DynValue m_Func; // 0x10
	private DynValue[] m_Args; // 0x18
	private bool m_First; // 0x20

	// Methods

	// RVA: 0x1F086F0 Offset: 0x1F087F1 VA: 0x1F086F0
	public void .ctor(DynValue func, DynValue[] args) { }

	// RVA: 0x1F08750 Offset: 0x1F08851 VA: 0x1F08750
	public void .ctor(DynValue func, DynValue callback, DynValue[] args) { }

	// RVA: 0x1F087C0 Offset: 0x1F088C1 VA: 0x1F087C0
	private DynValue[] GetCallbackArgs(DynValue callback, DynValue[] args) { }

	// RVA: 0x1F08910 Offset: 0x1F08A11 VA: 0x1F08910
	public Coroutine GetCoroutine() { }

	// RVA: 0x1F08930 Offset: 0x1F08A31 VA: 0x1F08930
	public WatchItem[] GetStackTrace() { }

	// RVA: 0x1F08990 Offset: 0x1F08A91 VA: 0x1F08990
	public void Yield() { }

	// RVA: 0x1F089E0 Offset: 0x1F08AE1 VA: 0x1F089E0
	public DynValue DoCoroutine() { }

	// RVA: 0x1F08B30 Offset: 0x1F08C31 VA: 0x1F08B30
	public bool IsDead() { }
}

