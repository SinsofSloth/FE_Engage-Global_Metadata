// Namespace: UniRx.Async
[ExtensionAttribute] // RVA: 0x278F0 Offset: 0x279F1 VA: 0x278F0
public static class CancellationTokenExtensions // TypeDefIndex: 4909
{
	// Fields
	private static readonly Action<object> cancellationTokenCallback; // 0x0

	// Methods

	[ExtensionAttribute] // RVA: 0x29E80 Offset: 0x29F81 VA: 0x29E80
	// RVA: 0x2E7EAD0 Offset: 0x2E7EBD1 VA: 0x2E7EAD0
	public static ValueTuple<UniTask, CancellationTokenRegistration> ToUniTask(CancellationToken cts) { }

	// RVA: 0x2E7ED90 Offset: 0x2E7EE91 VA: 0x2E7ED90
	private static void Callback(object state) { }

	[ExtensionAttribute] // RVA: 0x29E90 Offset: 0x29F91 VA: 0x29E90
	// RVA: 0x2E7EE80 Offset: 0x2E7EF81 VA: 0x2E7EE80
	public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(CancellationToken cancellationToken, Action callback) { }

	[ExtensionAttribute] // RVA: 0x29EA0 Offset: 0x29FA1 VA: 0x29EA0
	// RVA: 0x2E7D880 Offset: 0x2E7D981 VA: 0x2E7D880
	public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(CancellationToken cancellationToken, Action<object> callback, object state) { }

	// RVA: 0x2E7F010 Offset: 0x2E7F111 VA: 0x2E7F010
	private static void .cctor() { }
}

