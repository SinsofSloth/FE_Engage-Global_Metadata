// Namespace: System.Diagnostics
public class Stopwatch // TypeDefIndex: 2289
{
	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }

	// Methods

	// RVA: 0x2D128D0 Offset: 0x2D129D1 VA: 0x2D128D0
	public static long GetTimestamp() { }

	// RVA: 0x2D128E0 Offset: 0x2D129E1 VA: 0x2D128E0
	public static Stopwatch StartNew() { }

	// RVA: 0x2D12990 Offset: 0x2D12A91 VA: 0x2D12990
	public void .ctor() { }

	// RVA: 0x2D12A30 Offset: 0x2D12B31 VA: 0x2D12A30
	public TimeSpan get_Elapsed() { }

	// RVA: 0x2D12C30 Offset: 0x2D12D31 VA: 0x2D12C30
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x2D12BA0 Offset: 0x2D12CA1 VA: 0x2D12BA0
	public long get_ElapsedTicks() { }

	// RVA: 0x2D129A0 Offset: 0x2D12AA1 VA: 0x2D129A0
	public void Start() { }

	// RVA: 0x2D12DD0 Offset: 0x2D12ED1 VA: 0x2D12DD0
	public void Stop() { }

	// RVA: 0x2D12E60 Offset: 0x2D12F61 VA: 0x2D12E60
	private static void .cctor() { }
}

