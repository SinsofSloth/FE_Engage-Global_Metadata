// Namespace: MoonSharp.Interpreter.Diagnostics.PerformanceCounters
internal class DummyPerformanceStopwatch : IPerformanceStopwatch, IDisposable // TypeDefIndex: 6205
{
	// Fields
	public static DummyPerformanceStopwatch Instance; // 0x0
	private PerformanceResult m_Result; // 0x10

	// Methods

	// RVA: 0x3103150 Offset: 0x3103251 VA: 0x3103150
	private void .ctor() { }

	// RVA: 0x3103200 Offset: 0x3103301 VA: 0x3103200 Slot: 4
	public IDisposable Start() { }

	// RVA: 0x3103210 Offset: 0x3103311 VA: 0x3103210 Slot: 5
	public PerformanceResult GetResult() { }

	// RVA: 0x3103220 Offset: 0x3103321 VA: 0x3103220 Slot: 6
	public void Dispose() { }

	// RVA: 0x3103230 Offset: 0x3103331 VA: 0x3103230
	private static void .cctor() { }
}

