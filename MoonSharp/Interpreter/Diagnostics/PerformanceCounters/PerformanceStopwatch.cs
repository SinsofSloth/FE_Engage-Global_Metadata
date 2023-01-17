// Namespace: MoonSharp.Interpreter.Diagnostics.PerformanceCounters
internal class PerformanceStopwatch : IDisposable, IPerformanceStopwatch // TypeDefIndex: 6209
{
	// Fields
	private Stopwatch m_Stopwatch; // 0x10
	private int m_Count; // 0x18
	private int m_Reentrant; // 0x1C
	private PerformanceCounter m_Counter; // 0x20

	// Methods

	// RVA: 0x2BC8AD0 Offset: 0x2BC8BD1 VA: 0x2BC8AD0
	public void .ctor(PerformanceCounter perfcounter) { }

	// RVA: 0x2BC8E60 Offset: 0x2BC8F61 VA: 0x2BC8E60 Slot: 5
	public IDisposable Start() { }

	// RVA: 0x2BC8EB0 Offset: 0x2BC8FB1 VA: 0x2BC8EB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2BC8ED0 Offset: 0x2BC8FD1 VA: 0x2BC8ED0 Slot: 6
	public PerformanceResult GetResult() { }
}

