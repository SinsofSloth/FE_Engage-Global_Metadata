// Namespace: 
private enum EventSequence.Label // TypeDefIndex: 10248
{
	// Fields
	public int value__; // 0x0
	public const EventSequence.Label End = 0;
}

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

// Namespace: 
private class EventSequence.MapEventStatck : ProcInst // TypeDefIndex: 10250
{
	// Fields
	private Stack<MapInspector> m_Stack; // 0x70
	private int m_UnitIndex; // 0x78

	// Methods

	// RVA: 0x1F08B70 Offset: 0x1F08C71 VA: 0x1F08B70
	private void .ctor(MapInspector inspector) { }

	// RVA: 0x1F08C40 Offset: 0x1F08D41 VA: 0x1F08C40
	private void .ctor(Stack<MapInspector> stack, Unit unit) { }

	// RVA: 0x1F08CA0 Offset: 0x1F08DA1 VA: 0x1F08CA0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1F08D30 Offset: 0x1F08E31 VA: 0x1F08D30 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x1F08DC0 Offset: 0x1F08EC1 VA: 0x1F08DC0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1F08E40 Offset: 0x1F08F41 VA: 0x1F08E40
	public static bool TryCreateBind(ProcInst super, MapInspector.Kind kind, Unit unit, int arg1 = 0, int arg2 = 0, int arg3 = 0, int arg4 = 0) { }

	// RVA: 0x1F08F60 Offset: 0x1F09061 VA: 0x1F08F60
	public static bool TryCreateBind(ProcInst super, MapInspector inspector) { }

	// RVA: 0x1F08FF0 Offset: 0x1F090F1 VA: 0x1F08FF0
	private static bool IsExist(Unit unit) { }

	// RVA: 0x1F09010 Offset: 0x1F09111 VA: 0x1F09010
	public static bool TryCreateBind(ProcInst super, MapInspector.Kind kind, Unit unit) { }

	// RVA: 0x1F09050 Offset: 0x1F09151 VA: 0x1F09050
	public static bool TryCreateBind(ProcInst super, MapInspector.Kind kind, Unit unit, int value) { }

	// RVA: 0x1F09080 Offset: 0x1F09181 VA: 0x1F09080
	public static bool TryCreateBind(ProcInst super, MapInspector.Kind kind, Unit from, Unit to) { }
}

