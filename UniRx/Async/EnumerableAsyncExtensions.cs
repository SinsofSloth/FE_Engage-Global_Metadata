// Namespace: UniRx.Async
[ExtensionAttribute] // RVA: 0x27940 Offset: 0x27A41 VA: 0x27940
public static class EnumerableAsyncExtensions // TypeDefIndex: 4914
{
	// Methods

	[ExtensionAttribute] // RVA: 0x29F90 Offset: 0x2A091 VA: 0x29F90
	// RVA: -1 Offset: -1
	public static IEnumerable<UniTask> Select<T>(IEnumerable<T> source, Func<T, UniTask> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AFAB0 Offset: 0x22AFBB1 VA: 0x22AFAB0
	|-EnumerableAsyncExtensions.Select<object>
	*/

	[ExtensionAttribute] // RVA: 0x29FA0 Offset: 0x2A0A1 VA: 0x29FA0
	// RVA: -1 Offset: -1
	public static IEnumerable<UniTask<TR>> Select<T, TR>(IEnumerable<T> source, Func<T, UniTask<TR>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AFAD0 Offset: 0x22AFBD1 VA: 0x22AFAD0
	|-EnumerableAsyncExtensions.Select<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x29FB0 Offset: 0x2A0B1 VA: 0x29FB0
	// RVA: -1 Offset: -1
	public static IEnumerable<UniTask> Select<T>(IEnumerable<T> source, Func<T, int, UniTask> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AFAC0 Offset: 0x22AFBC1 VA: 0x22AFAC0
	|-EnumerableAsyncExtensions.Select<object>
	*/

	[ExtensionAttribute] // RVA: 0x29FC0 Offset: 0x2A0C1 VA: 0x29FC0
	// RVA: -1 Offset: -1
	public static IEnumerable<UniTask<TR>> Select<T, TR>(IEnumerable<T> source, Func<T, int, UniTask<TR>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AFAE0 Offset: 0x22AFBE1 VA: 0x22AFAE0
	|-EnumerableAsyncExtensions.Select<object, object>
	*/
}

