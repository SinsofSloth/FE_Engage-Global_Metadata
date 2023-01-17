// Namespace: UniRx.Async
[ExtensionAttribute] // RVA: 0x27950 Offset: 0x27A51 VA: 0x27950
public static class EnumeratorAsyncExtensions // TypeDefIndex: 4916
{
	// Methods

	[ExtensionAttribute] // RVA: 0x29FD0 Offset: 0x2A0D1 VA: 0x29FD0
	// RVA: 0x2E81FF0 Offset: 0x2E820F1 VA: 0x2E81FF0
	public static IAwaiter GetAwaiter(IEnumerator enumerator) { }

	[ExtensionAttribute] // RVA: 0x29FE0 Offset: 0x2A0E1 VA: 0x29FE0
	// RVA: 0x2E82200 Offset: 0x2E82301 VA: 0x2E82200
	public static UniTask ToUniTask(IEnumerator enumerator) { }

	[ExtensionAttribute] // RVA: 0x29FF0 Offset: 0x2A0F1 VA: 0x29FF0
	// RVA: 0x2E82370 Offset: 0x2E82471 VA: 0x2E82370
	public static UniTask ConfigureAwait(IEnumerator enumerator, PlayerLoopTiming timing = 4, CancellationToken cancellationToken) { }
}

