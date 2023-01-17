// Namespace: MoonSharp.Interpreter.Diagnostics
public class PerformanceStatistics // TypeDefIndex: 6203
{
	// Fields
	private IPerformanceStopwatch[] m_Stopwatches; // 0x10
	private static IPerformanceStopwatch[] m_GlobalStopwatches; // 0x0
	private bool m_Enabled; // 0x18

	// Properties
	public bool Enabled { get; set; }

	// Methods

	// RVA: 0x2BC8580 Offset: 0x2BC8681 VA: 0x2BC8580
	public bool get_Enabled() { }

	// RVA: 0x2BC8590 Offset: 0x2BC8691 VA: 0x2BC8590
	public void set_Enabled(bool value) { }

	// RVA: 0x2BC8B60 Offset: 0x2BC8C61 VA: 0x2BC8B60
	public PerformanceResult GetPerformanceCounterResult(PerformanceCounter pc) { }

	// RVA: 0x2BAE440 Offset: 0x2BAE541 VA: 0x2BAE440
	internal IDisposable StartStopwatch(PerformanceCounter pc) { }

	// RVA: 0x2BB7350 Offset: 0x2BB7451 VA: 0x2BB7350
	internal static IDisposable StartGlobalStopwatch(PerformanceCounter pc) { }

	// RVA: 0x2BC8C50 Offset: 0x2BC8D51 VA: 0x2BC8C50
	public string GetPerformanceLog() { }

	// RVA: 0x2BC8D70 Offset: 0x2BC8E71 VA: 0x2BC8D70
	public void .ctor() { }

	// RVA: 0x2BC8DE0 Offset: 0x2BC8EE1 VA: 0x2BC8DE0
	private static void .cctor() { }
}

