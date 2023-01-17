// Namespace: System.Runtime.CompilerServices
public struct ConfiguredTaskAwaitable // TypeDefIndex: 1258
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: 0x33AE620 Offset: 0x33AE721 VA: 0x33AE620
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x33AE670 Offset: 0x33AE771 VA: 0x33AE670
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { }
}

// Namespace: System.Runtime.CompilerServices
public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1260
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509940 Offset: 0x2509A41 VA: 0x2509940
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|
	|-RVA: 0x25099D0 Offset: 0x2509AD1 VA: 0x25099D0
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x2509A60 Offset: 0x2509B61 VA: 0x2509A60
	|-ConfiguredTaskAwaitable<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2509AF0 Offset: 0x2509BF1 VA: 0x2509AF0
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x2509B80 Offset: 0x2509C81 VA: 0x2509B80
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x2509C10 Offset: 0x2509D11 VA: 0x2509C10
	|-ConfiguredTaskAwaitable<bool>..ctor
	|
	|-RVA: 0x2509CA0 Offset: 0x2509DA1 VA: 0x2509CA0
	|-ConfiguredTaskAwaitable<int>..ctor
	|
	|-RVA: 0x2509D30 Offset: 0x2509E31 VA: 0x2509D30
	|-ConfiguredTaskAwaitable<long>..ctor
	|
	|-RVA: 0x2509DC0 Offset: 0x2509EC1 VA: 0x2509DC0
	|-ConfiguredTaskAwaitable<object>..ctor
	|
	|-RVA: 0x2509E50 Offset: 0x2509F51 VA: 0x2509E50
	|-ConfiguredTaskAwaitable<SceneInstance>..ctor
	|
	|-RVA: 0x2509EE0 Offset: 0x2509FE1 VA: 0x2509EE0
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25099C0 Offset: 0x2509AC1 VA: 0x25099C0
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x2509A50 Offset: 0x2509B51 VA: 0x2509A50
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<bool, WebOperation>>.GetAwaiter
	|
	|-RVA: 0x2509AE0 Offset: 0x2509BE1 VA: 0x2509AE0
	|-ConfiguredTaskAwaitable<ValueTuple<int, int>>.GetAwaiter
	|
	|-RVA: 0x2509B70 Offset: 0x2509C71 VA: 0x2509B70
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, byte[], int>>.GetAwaiter
	|
	|-RVA: 0x2509C00 Offset: 0x2509D01 VA: 0x2509C00
	|-ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|
	|-RVA: 0x2509E40 Offset: 0x2509F41 VA: 0x2509E40
	|-ConfiguredTaskAwaitable<AsyncProtocolResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<BufferOffsetSize>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<Stream>.GetAwaiter
	|-ConfiguredTaskAwaitable<Task>.GetAwaiter
	|-ConfiguredTaskAwaitable<WebRequestStream>.GetAwaiter
	|-ConfiguredTaskAwaitable<WebResponse>.GetAwaiter
	|-ConfiguredTaskAwaitable<WebCompletionSource.Result>.GetAwaiter
	|
	|-RVA: 0x2509C90 Offset: 0x2509D91 VA: 0x2509C90
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|
	|-RVA: 0x2509D20 Offset: 0x2509E21 VA: 0x2509D20
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|
	|-RVA: 0x2509DB0 Offset: 0x2509EB1 VA: 0x2509DB0
	|-ConfiguredTaskAwaitable<long>.GetAwaiter
	|
	|-RVA: 0x2509ED0 Offset: 0x2509FD1 VA: 0x2509ED0
	|-ConfiguredTaskAwaitable<SceneInstance>.GetAwaiter
	|
	|-RVA: 0x2509F60 Offset: 0x250A061 VA: 0x2509F60
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	*/
}

