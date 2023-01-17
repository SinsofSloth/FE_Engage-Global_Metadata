// Namespace: MoonSharp.Interpreter.Diagnostics.PerformanceCounters
internal class GlobalPerformanceStopwatch : IPerformanceStopwatch // TypeDefIndex: 6207
{
	// Fields
	private int m_Count; // 0x10
	private long m_Elapsed; // 0x18
	private PerformanceCounter m_Counter; // 0x20

	// Methods

	// RVA: 0x3315E80 Offset: 0x3315F81 VA: 0x3315E80
	public void .ctor(PerformanceCounter perfcounter) { }

	// RVA: 0x3315EB0 Offset: 0x3315FB1 VA: 0x3315EB0
	private void SignalStopwatchTerminated(Stopwatch sw) { }

	// RVA: 0x3315EF0 Offset: 0x3315FF1 VA: 0x3315EF0 Slot: 4
	public IDisposable Start() { }

	// RVA: 0x3315F60 Offset: 0x3316061 VA: 0x3315F60 Slot: 5
	public PerformanceResult GetResult() { }
}

