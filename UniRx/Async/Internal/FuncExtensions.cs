// Namespace: UniRx.Async.Internal
[ExtensionAttribute] // RVA: 0x284F0 Offset: 0x285F1 VA: 0x284F0
internal static class FuncExtensions // TypeDefIndex: 5211
{
	// Methods

	[ExtensionAttribute] // RVA: 0x2EA50 Offset: 0x2EB51 VA: 0x2EA50
	// RVA: -1 Offset: -1
	internal static Action<T> AsFuncOfT<T>(Action action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4E50 Offset: 0x22B4F51 VA: 0x22B4E50
	|-FuncExtensions.AsFuncOfT<AsyncOperation>
	|-FuncExtensions.AsFuncOfT<object>
	*/

	[ExtensionAttribute] // RVA: 0x2EA60 Offset: 0x2EB61 VA: 0x2EA60
	// RVA: -1 Offset: -1
	private static void Invoke<T>(Action action, T unused) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4EC0 Offset: 0x22B4FC1 VA: 0x22B4EC0
	|-FuncExtensions.Invoke<object>
	*/
}

