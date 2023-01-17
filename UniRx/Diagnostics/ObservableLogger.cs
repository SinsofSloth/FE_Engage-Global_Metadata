// Namespace: UniRx.Diagnostics
public class ObservableLogger : IObservable<LogEntry> // TypeDefIndex: 6851
{
	// Fields
	private static readonly Subject<LogEntry> logPublisher; // 0x0
	public static readonly ObservableLogger Listener; // 0x8

	// Methods

	// RVA: 0x19DDD00 Offset: 0x19DDE01 VA: 0x19DDD00
	private void .ctor() { }

	// RVA: 0x19D1B90 Offset: 0x19D1C91 VA: 0x19D1B90
	public static Action<LogEntry> RegisterLogger(Logger logger) { }

	// RVA: 0x19DDD10 Offset: 0x19DDE11 VA: 0x19DDD10 Slot: 4
	public IDisposable Subscribe(IObserver<LogEntry> observer) { }

	// RVA: 0x19DDDA0 Offset: 0x19DDEA1 VA: 0x19DDDA0
	private static void .cctor() { }
}

