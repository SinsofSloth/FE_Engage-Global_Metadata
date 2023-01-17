// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder // TypeDefIndex: 1236
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x356AEE0 Offset: 0x356AFE1 VA: 0x356AEE0
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThroughAttribute] // RVA: 0x47D320 Offset: 0x47D421 VA: 0x47D320
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2736200 Offset: 0x2736301 VA: 0x2736200
	|-AsyncTaskMethodBuilder.Start<object>
	|
	|-RVA: 0x2736390 Offset: 0x2736491 VA: 0x2736390
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2736470 Offset: 0x2736571 VA: 0x2736470
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x2736550 Offset: 0x2736651 VA: 0x2736550
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x2736630 Offset: 0x2736731 VA: 0x2736630
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x2736710 Offset: 0x2736811 VA: 0x2736710
	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	|
	|-RVA: 0x27367F0 Offset: 0x27368F1 VA: 0x27367F0
	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x27368D0 Offset: 0x27369D1 VA: 0x27368D0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<FinishWriting>d__30>
	|
	|-RVA: 0x27369B0 Offset: 0x2736AB1 VA: 0x27369B0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x2736A90 Offset: 0x2736B91 VA: 0x2736A90
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<ProcessWrite>d__32>
	|
	|-RVA: 0x2736B70 Offset: 0x2736C71 VA: 0x2736B70
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<SetHeadersAsync>d__35>
	|
	|-RVA: 0x2736C50 Offset: 0x2736D51 VA: 0x2736C50
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x2736D30 Offset: 0x2736E31 VA: 0x2736D30
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x2736E10 Offset: 0x2736F11 VA: 0x2736E10
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__37>
	|
	|-RVA: 0x2736EF0 Offset: 0x2736FF1 VA: 0x2736EF0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x2736FD0 Offset: 0x27370D1 VA: 0x2736FD0
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x27370B0 Offset: 0x27371B1 VA: 0x27370B0
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<Initialize>d__56>
	|
	|-RVA: 0x2737190 Offset: 0x2737291 VA: 0x2737190
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<ReadAllAsync>d__57>
	*/

	// RVA: 0x356AEF0 Offset: 0x356AFF1 VA: 0x356AEF0
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2736040 Offset: 0x2736141 VA: 0x2736040
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x2736050 Offset: 0x2736151 VA: 0x2736050
	|-AsyncTaskMethodBuilder.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2736060 Offset: 0x2736161 VA: 0x2736060
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2736070 Offset: 0x2736171 VA: 0x2736070
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, byte[], int>>, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x2736090 Offset: 0x2736191 VA: 0x2736090
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x2736080 Offset: 0x2736181 VA: 0x2736080
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x27360A0 Offset: 0x27361A1 VA: 0x27360A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__38>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x27360B0 Offset: 0x27361B1 VA: 0x27360B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__57>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, WebResponseStream.<ReadAllAsync>d__57>
	|
	|-RVA: 0x27360C0 Offset: 0x27361C1 VA: 0x27360C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WebResponseStream.<ReadAllAsync>d__57>
	|
	|-RVA: 0x27360D0 Offset: 0x27361D1 VA: 0x27360D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x27360E0 Offset: 0x27361E1 VA: 0x27360E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x27360F0 Offset: 0x27361F1 VA: 0x27360F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x2736100 Offset: 0x2736201 VA: 0x2736100
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x2736110 Offset: 0x2736211 VA: 0x2736110
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2736120 Offset: 0x2736221 VA: 0x2736120
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x2736130 Offset: 0x2736231 VA: 0x2736130
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x2736140 Offset: 0x2736241 VA: 0x2736140
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|
	|-RVA: 0x2736150 Offset: 0x2736251 VA: 0x2736150
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x2736160 Offset: 0x2736261 VA: 0x2736160
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__30>
	|
	|-RVA: 0x2736170 Offset: 0x2736271 VA: 0x2736170
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x2736180 Offset: 0x2736281 VA: 0x2736180
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__32>
	|
	|-RVA: 0x2736190 Offset: 0x2736291 VA: 0x2736190
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__35>
	|
	|-RVA: 0x27361A0 Offset: 0x27362A1 VA: 0x27361A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x27361B0 Offset: 0x27362B1 VA: 0x27361B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x27361C0 Offset: 0x27362C1 VA: 0x27361C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__37>
	|
	|-RVA: 0x27361D0 Offset: 0x27362D1 VA: 0x27361D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x27361E0 Offset: 0x27362E1 VA: 0x27361E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x27361F0 Offset: 0x27362F1 VA: 0x27361F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebResponseStream.<Initialize>d__56>
	*/

	// RVA: 0x356AF50 Offset: 0x356B051 VA: 0x356AF50
	public Task get_Task() { }

	// RVA: 0x356AFB0 Offset: 0x356B0B1 VA: 0x356AFB0
	public void SetResult() { }

	// RVA: 0x356B040 Offset: 0x356B141 VA: 0x356B040
	public void SetException(Exception exception) { }

	// RVA: 0x356B0A0 Offset: 0x356B1A1 VA: 0x356B0A0
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 1237
{
	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F470A0 Offset: 0x2F471A1 VA: 0x2F470A0
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|
	|-RVA: 0x2F48910 Offset: 0x2F48A11 VA: 0x2F48910
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>.Create
	|
	|-RVA: 0x2F4A0C0 Offset: 0x2F4A1C1 VA: 0x2F4A0C0
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.Create
	|
	|-RVA: 0x2F4B850 Offset: 0x2F4B951 VA: 0x2F4B850
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.Create
	|
	|-RVA: 0x2F4D130 Offset: 0x2F4D231 VA: 0x2F4D130
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Create
	|
	|-RVA: 0x2F51930 Offset: 0x2F51A31 VA: 0x2F51930
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Create
	|-AsyncTaskMethodBuilder<BufferOffsetSize>.Create
	|-AsyncTaskMethodBuilder<HttpWebResponse>.Create
	|-AsyncTaskMethodBuilder<object>.Create
	|-AsyncTaskMethodBuilder<Stream>.Create
	|-AsyncTaskMethodBuilder<WebRequestStream>.Create
	|
	|-RVA: 0x2F4EA10 Offset: 0x2F4EB11 VA: 0x2F4EA10
	|-AsyncTaskMethodBuilder<bool>.Create
	|
	|-RVA: 0x2F501A0 Offset: 0x2F502A1 VA: 0x2F501A0
	|-AsyncTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x2F52280 Offset: 0x2F52381 VA: 0x2F52280
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	*/

	[DebuggerStepThroughAttribute] // RVA: 0x47D330 Offset: 0x47D431 VA: 0x47D330
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2541230 Offset: 0x2541331 VA: 0x2541230
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x2541590 Offset: 0x2541691 VA: 0x2541590
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Start<WebOperation.<WaitForCompletion>d__53>
	|-AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>.Start<WebOperation.<WaitForCompletion>d__53>
	|
	|-RVA: 0x2541B90 Offset: 0x2541C91 VA: 0x2541B90
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.Start<HttpWebRequest.<RunWithTimeout>d__234<ValueTuple<int, int>>>
	|
	|-RVA: 0x2541D50 Offset: 0x2541E51 VA: 0x2541D50
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.Start<WebResponseStream.<ProcessRead>d__49>
	|
	|-RVA: 0x25420D0 Offset: 0x25421D1 VA: 0x25420D0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	|-AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x25425E0 Offset: 0x25426E1 VA: 0x25425E0
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.Start<HttpWebRequest.<GetResponseFromData>d__237>
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Start<HttpWebRequest.<GetResponseFromData>d__237>
	|
	|-RVA: 0x25475C0 Offset: 0x25476C1 VA: 0x25475C0
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x25435A0 Offset: 0x25436A1 VA: 0x25435A0
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x2543680 Offset: 0x2543781 VA: 0x2543680
	|-AsyncTaskMethodBuilder<bool>.Start<WebCompletionSource.<WaitForCompletion>d__8>
	|
	|-RVA: 0x2543760 Offset: 0x2543861 VA: 0x2543760
	|-AsyncTaskMethodBuilder<bool>.Start<WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x2543840 Offset: 0x2543941 VA: 0x2543840
	|-AsyncTaskMethodBuilder<bool>.Start<ServicePointScheduler.AsyncManualResetEvent.<WaitAsync>d__3>
	|
	|-RVA: 0x25476A0 Offset: 0x25477A1 VA: 0x25476A0
	|-AsyncTaskMethodBuilder<BufferOffsetSize>.Start<HttpWebRequest.<<GetRewriteHandler>b__263_0>d>
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<<GetRewriteHandler>b__263_0>d>
	|
	|-RVA: 0x2547860 Offset: 0x2547961 VA: 0x2547860
	|-AsyncTaskMethodBuilder<HttpWebResponse>.Start<HttpWebRequest.<MyGetResponseAsync>d__236>
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<MyGetResponseAsync>d__236>
	|
	|-RVA: 0x2544E90 Offset: 0x2544F91 VA: 0x2544E90
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x2544F70 Offset: 0x2545071 VA: 0x2544F70
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x2545050 Offset: 0x2545151 VA: 0x2545050
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x2545130 Offset: 0x2545231 VA: 0x2545130
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<EnsureReadAsync>d__51>
	|
	|-RVA: 0x2545210 Offset: 0x2545311 VA: 0x2545210
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<InnerReadAsync>d__50>
	|
	|-RVA: 0x25452F0 Offset: 0x25453F1 VA: 0x25452F0
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<ReadAsync>d__48>
	|
	|-RVA: 0x2547270 Offset: 0x2547371 VA: 0x2547270
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<RunWithTimeout>d__234<object>>
	|
	|-RVA: 0x2547430 Offset: 0x2547531 VA: 0x2547430
	|-AsyncTaskMethodBuilder<object>.Start<object>
	|
	|-RVA: 0x2547780 Offset: 0x2547881 VA: 0x2547780
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<MyGetRequestStreamAsync>d__229>
	|-AsyncTaskMethodBuilder<Stream>.Start<HttpWebRequest.<MyGetRequestStreamAsync>d__229>
	|
	|-RVA: 0x2547940 Offset: 0x2547A41 VA: 0x2547940
	|-AsyncTaskMethodBuilder<object>.Start<MonoTlsStream.<CreateStream>d__17>
	|-AsyncTaskMethodBuilder<Stream>.Start<MonoTlsStream.<CreateStream>d__17>
	|
	|-RVA: 0x2547A20 Offset: 0x2547B21 VA: 0x2547A20
	|-AsyncTaskMethodBuilder<object>.Start<WebConnection.<InitConnection>d__19>
	|-AsyncTaskMethodBuilder<WebRequestStream>.Start<WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x2547B00 Offset: 0x2547C01 VA: 0x2547B00
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<Stream>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x2547BE0 Offset: 0x2547CE1 VA: 0x2547BE0
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F470B0 Offset: 0x2F471B1 VA: 0x2F470B0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|
	|-RVA: 0x2F48920 Offset: 0x2F48A21 VA: 0x2F48920
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>.SetStateMachine
	|
	|-RVA: 0x2F4A0D0 Offset: 0x2F4A1D1 VA: 0x2F4A0D0
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.SetStateMachine
	|
	|-RVA: 0x2F4B860 Offset: 0x2F4B961 VA: 0x2F4B860
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.SetStateMachine
	|
	|-RVA: 0x2F4D140 Offset: 0x2F4D241 VA: 0x2F4D140
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetStateMachine
	|
	|-RVA: 0x2F51940 Offset: 0x2F51A41 VA: 0x2F51940
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<BufferOffsetSize>.SetStateMachine
	|-AsyncTaskMethodBuilder<HttpWebResponse>.SetStateMachine
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|-AsyncTaskMethodBuilder<Stream>.SetStateMachine
	|-AsyncTaskMethodBuilder<WebRequestStream>.SetStateMachine
	|
	|-RVA: 0x2F4EA20 Offset: 0x2F4EB21 VA: 0x2F4EA20
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|
	|-RVA: 0x2F501B0 Offset: 0x2F502B1 VA: 0x2F501B0
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x2F52290 Offset: 0x2F52391 VA: 0x2F52290
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2543920 Offset: 0x2543A21 VA: 0x2543920
	|-AsyncTaskMethodBuilder<int>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x25453D0 Offset: 0x25454D1 VA: 0x25453D0
	|-AsyncTaskMethodBuilder<object>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x2547CC0 Offset: 0x2547DC1 VA: 0x2547CC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<object, object>
	|
	|-RVA: 0x2547EB0 Offset: 0x2547FB1 VA: 0x2547EB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitOnCompleted<CryptoStream.HopToThreadPoolAwaitable, CryptoStream.<WriteAsyncInternal>d__37>
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2540FA0 Offset: 0x25410A1 VA: 0x2540FA0
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x2541310 Offset: 0x2541411 VA: 0x2541310
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>, WebOperation.<WaitForCompletion>d__53>
	|-AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, WebOperation>>, WebOperation.<WaitForCompletion>d__53>
	|
	|-RVA: 0x2541670 Offset: 0x2541771 VA: 0x2541670
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ProcessRead>d__49>
	|
	|-RVA: 0x2541900 Offset: 0x2541A01 VA: 0x2541900
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<RunWithTimeout>d__234<ValueTuple<int, int>>>
	|
	|-RVA: 0x2541E30 Offset: 0x2541F31 VA: 0x2541E30
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	|-AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x25421B0 Offset: 0x25422B1 VA: 0x25421B0
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<BufferOffsetSize>, HttpWebRequest.<GetResponseFromData>d__237>
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<GetResponseFromData>d__237>
	|
	|-RVA: 0x2542420 Offset: 0x2542521 VA: 0x2542420
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<GetResponseFromData>d__237>
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<GetResponseFromData>d__237>
	|
	|-RVA: 0x2546950 Offset: 0x2546A51 VA: 0x2546950
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x25426C0 Offset: 0x25427C1 VA: 0x25426C0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x2542960 Offset: 0x2542A61 VA: 0x2542960
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31>
	|
	|-RVA: 0x2542C00 Offset: 0x2542D01 VA: 0x2542C00
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__8>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebCompletionSource.Result>, WebCompletionSource.<WaitForCompletion>d__8>
	|
	|-RVA: 0x2542E80 Offset: 0x2542F81 VA: 0x2542E80
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebConnection.<CreateStream>d__18>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x2543120 Offset: 0x2543221 VA: 0x2543120
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.AsyncManualResetEvent.<WaitAsync>d__3>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task>, ServicePointScheduler.AsyncManualResetEvent.<WaitAsync>d__3>
	|
	|-RVA: 0x25433B0 Offset: 0x25434B1 VA: 0x25433B0
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x2546B20 Offset: 0x2546C21 VA: 0x2546B20
	|-AsyncTaskMethodBuilder<BufferOffsetSize>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<<GetRewriteHandler>b__263_0>d>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<<GetRewriteHandler>b__263_0>d>
	|
	|-RVA: 0x25455C0 Offset: 0x25456C1 VA: 0x25455C0
	|-AsyncTaskMethodBuilder<HttpWebResponse>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>, HttpWebRequest.<MyGetResponseAsync>d__236>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>, HttpWebRequest.<MyGetResponseAsync>d__236>
	|
	|-RVA: 0x25464F0 Offset: 0x25465F1 VA: 0x25464F0
	|-AsyncTaskMethodBuilder<HttpWebResponse>.AwaitUnsafeOnCompleted<TaskAwaiter<WebRequestStream>, HttpWebRequest.<MyGetResponseAsync>d__236>
	|-AsyncTaskMethodBuilder<HttpWebResponse>.AwaitUnsafeOnCompleted<TaskAwaiter<WebResponseStream>, HttpWebRequest.<MyGetResponseAsync>d__236>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__236>
	|
	|-RVA: 0x2546CF0 Offset: 0x2546DF1 VA: 0x2546CF0
	|-AsyncTaskMethodBuilder<HttpWebResponse>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<MyGetResponseAsync>d__236>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<MyGetResponseAsync>d__236>
	|
	|-RVA: 0x2543AE0 Offset: 0x2543BE1 VA: 0x2543AE0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<int, int>>, WebResponseStream.<ReadAsync>d__48>
	|
	|-RVA: 0x2544A40 Offset: 0x2544B41 VA: 0x2544A40
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult>, MobileAuthenticatedStream.<StartOperation>d__58>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__58>
	|
	|-RVA: 0x2543D80 Offset: 0x2543E81 VA: 0x2543D80
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebResponseStream.<ReadAsync>d__48>
	|
	|-RVA: 0x2544020 Offset: 0x2544121 VA: 0x2544020
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x2544290 Offset: 0x2544391 VA: 0x2544290
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x2544520 Offset: 0x2544621 VA: 0x2544520
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<EnsureReadAsync>d__51>
	|
	|-RVA: 0x25447B0 Offset: 0x25448B1 VA: 0x25447B0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InnerReadAsync>d__50>
	|
	|-RVA: 0x2544CD0 Offset: 0x2544DD1 VA: 0x2544CD0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<ReadAsyncInternal>d__34>
	|
	|-RVA: 0x2545830 Offset: 0x2545931 VA: 0x2545830
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	|-AsyncTaskMethodBuilder<WebRequestStream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x2545AC0 Offset: 0x2545BC1 VA: 0x2545AC0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<RunWithTimeout>d__234<object>>
	|
	|-RVA: 0x2545D50 Offset: 0x2545E51 VA: 0x2545D50
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<MyGetRequestStreamAsync>d__229>
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream>, HttpWebRequest.<MyGetRequestStreamAsync>d__229>
	|
	|-RVA: 0x2545FD0 Offset: 0x25460D1 VA: 0x2545FD0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x2546260 Offset: 0x2546361 VA: 0x2546260
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x2546760 Offset: 0x2546861 VA: 0x2546760
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x2546EB0 Offset: 0x2546FB1 VA: 0x2546EB0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoTlsStream.<CreateStream>d__17>
	|-AsyncTaskMethodBuilder<Stream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoTlsStream.<CreateStream>d__17>
	|
	|-RVA: 0x2547090 Offset: 0x2547191 VA: 0x2547090
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	|-AsyncTaskMethodBuilder<WebRequestStream>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x25480A0 Offset: 0x25481A1 VA: 0x25480A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2548330 Offset: 0x2548431 VA: 0x2548330
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x25485C0 Offset: 0x25486C1 VA: 0x25485C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x2548850 Offset: 0x2548951 VA: 0x2548850
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__47>
	|
	|-RVA: 0x2548AF0 Offset: 0x2548BF1 VA: 0x2548AF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x2548D80 Offset: 0x2548E81 VA: 0x2548D80
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__57>
	|
	|-RVA: 0x2548FF0 Offset: 0x25490F1 VA: 0x2548FF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, WebResponseStream.<ReadAllAsync>d__57>
	|
	|-RVA: 0x2549260 Offset: 0x2549361 VA: 0x2549260
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<object, object>
	|
	|-RVA: 0x2549450 Offset: 0x2549551 VA: 0x2549450
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x2549630 Offset: 0x2549731 VA: 0x2549630
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x2549810 Offset: 0x2549911 VA: 0x2549810
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x25499F0 Offset: 0x2549AF1 VA: 0x25499F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x2549BD0 Offset: 0x2549CD1 VA: 0x2549BD0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CryptoStream.<WriteAsyncInternal>d__37>
	|
	|-RVA: 0x2549DC0 Offset: 0x2549EC1 VA: 0x2549DC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x2549FA0 Offset: 0x254A0A1 VA: 0x2549FA0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|
	|-RVA: 0x254A180 Offset: 0x254A281 VA: 0x254A180
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x254A360 Offset: 0x254A461 VA: 0x254A360
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__30>
	|
	|-RVA: 0x254A530 Offset: 0x254A631 VA: 0x254A530
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__34>
	|
	|-RVA: 0x254A710 Offset: 0x254A811 VA: 0x254A710
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__32>
	|
	|-RVA: 0x254A8F0 Offset: 0x254A9F1 VA: 0x254A8F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__35>
	|
	|-RVA: 0x254AAD0 Offset: 0x254ABD1 VA: 0x254AAD0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsync>d__31>
	|
	|-RVA: 0x254ACB0 Offset: 0x254ADB1 VA: 0x254ACB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__38>
	|
	|-RVA: 0x254AE90 Offset: 0x254AF91 VA: 0x254AE90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__37>
	|
	|-RVA: 0x254B060 Offset: 0x254B161 VA: 0x254B060
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__36>
	|
	|-RVA: 0x254B240 Offset: 0x254B341 VA: 0x254B240
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebResponseStream.<InitReadAsync>d__61>
	|
	|-RVA: 0x254B420 Offset: 0x254B521 VA: 0x254B420
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebResponseStream.<Initialize>d__56>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F470C0 Offset: 0x2F471C1 VA: 0x2F470C0
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|
	|-RVA: 0x2F48930 Offset: 0x2F48A31 VA: 0x2F48930
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.get_Task
	|-AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>.get_Task
	|
	|-RVA: 0x2F4A0E0 Offset: 0x2F4A1E1 VA: 0x2F4A0E0
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.get_Task
	|
	|-RVA: 0x2F4B870 Offset: 0x2F4B971 VA: 0x2F4B870
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.get_Task
	|-AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.get_Task
	|
	|-RVA: 0x2F4D150 Offset: 0x2F4D251 VA: 0x2F4D150
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.get_Task
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.get_Task
	|
	|-RVA: 0x2F51950 Offset: 0x2F51A51 VA: 0x2F51950
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.get_Task
	|-AsyncTaskMethodBuilder<BufferOffsetSize>.get_Task
	|-AsyncTaskMethodBuilder<HttpWebResponse>.get_Task
	|-AsyncTaskMethodBuilder<object>.get_Task
	|-AsyncTaskMethodBuilder<Stream>.get_Task
	|-AsyncTaskMethodBuilder<WebRequestStream>.get_Task
	|
	|-RVA: 0x2F4EA30 Offset: 0x2F4EB31 VA: 0x2F4EA30
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x2F501C0 Offset: 0x2F502C1 VA: 0x2F501C0
	|-AsyncTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x2F522A0 Offset: 0x2F523A1 VA: 0x2F522A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F47190 Offset: 0x2F47291 VA: 0x2F47190
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x2F48A00 Offset: 0x2F48B01 VA: 0x2F48A00
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|-AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>.SetResult
	|
	|-RVA: 0x2F4A1B0 Offset: 0x2F4A2B1 VA: 0x2F4A1B0
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.SetResult
	|
	|-RVA: 0x2F4B940 Offset: 0x2F4BA41 VA: 0x2F4B940
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|-AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.SetResult
	|
	|-RVA: 0x2F4D220 Offset: 0x2F4D321 VA: 0x2F4D220
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.SetResult
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x2F51A20 Offset: 0x2F51B21 VA: 0x2F51A20
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetResult
	|-AsyncTaskMethodBuilder<BufferOffsetSize>.SetResult
	|-AsyncTaskMethodBuilder<HttpWebResponse>.SetResult
	|-AsyncTaskMethodBuilder<object>.SetResult
	|-AsyncTaskMethodBuilder<Stream>.SetResult
	|-AsyncTaskMethodBuilder<WebRequestStream>.SetResult
	|
	|-RVA: 0x2F4EB00 Offset: 0x2F4EC01 VA: 0x2F4EB00
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x2F50290 Offset: 0x2F50391 VA: 0x2F50290
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x2F52370 Offset: 0x2F52471 VA: 0x2F52370
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F47360 Offset: 0x2F47461 VA: 0x2F47360
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x2F48BE0 Offset: 0x2F48CE1 VA: 0x2F48BE0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x2F4A380 Offset: 0x2F4A481 VA: 0x2F4A380
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.SetResult
	|
	|-RVA: 0x2F4BB60 Offset: 0x2F4BC61 VA: 0x2F4BB60
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0x2F4D440 Offset: 0x2F4D541 VA: 0x2F4D440
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x2F4ECD0 Offset: 0x2F4EDD1 VA: 0x2F4ECD0
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x2F50460 Offset: 0x2F50561 VA: 0x2F50460
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x2F51BF0 Offset: 0x2F51CF1 VA: 0x2F51BF0
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x2F52540 Offset: 0x2F52641 VA: 0x2F52540
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F473C0 Offset: 0x2F474C1 VA: 0x2F473C0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0x2F48C40 Offset: 0x2F48D41 VA: 0x2F48C40
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetException
	|-AsyncTaskMethodBuilder<ValueTuple<bool, WebOperation>>.SetException
	|
	|-RVA: 0x2F4A3E0 Offset: 0x2F4A4E1 VA: 0x2F4A3E0
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.SetException
	|
	|-RVA: 0x2F4BBE0 Offset: 0x2F4BCE1 VA: 0x2F4BBE0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetException
	|-AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>>.SetException
	|
	|-RVA: 0x2F4D4C0 Offset: 0x2F4D5C1 VA: 0x2F4D4C0
	|-AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.SetException
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetException
	|
	|-RVA: 0x2F51C50 Offset: 0x2F51D51 VA: 0x2F51C50
	|-AsyncTaskMethodBuilder<AsyncProtocolResult>.SetException
	|-AsyncTaskMethodBuilder<BufferOffsetSize>.SetException
	|-AsyncTaskMethodBuilder<HttpWebResponse>.SetException
	|-AsyncTaskMethodBuilder<object>.SetException
	|-AsyncTaskMethodBuilder<Stream>.SetException
	|-AsyncTaskMethodBuilder<WebRequestStream>.SetException
	|
	|-RVA: 0x2F4ED30 Offset: 0x2F4EE31 VA: 0x2F4ED30
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x2F504C0 Offset: 0x2F505C1 VA: 0x2F504C0
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x2F525A0 Offset: 0x2F526A1 VA: 0x2F525A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F475C0 Offset: 0x2F476C1 VA: 0x2F475C0
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0x2F48E40 Offset: 0x2F48F41 VA: 0x2F48E40
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.GetTaskForResult
	|
	|-RVA: 0x2F4A5E0 Offset: 0x2F4A6E1 VA: 0x2F4A5E0
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>.GetTaskForResult
	|
	|-RVA: 0x2F4BDE0 Offset: 0x2F4BEE1 VA: 0x2F4BDE0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.GetTaskForResult
	|
	|-RVA: 0x2F4D6C0 Offset: 0x2F4D7C1 VA: 0x2F4D6C0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.GetTaskForResult
	|
	|-RVA: 0x2F4EF30 Offset: 0x2F4F031 VA: 0x2F4EF30
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0x2F506C0 Offset: 0x2F507C1 VA: 0x2F506C0
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0x2F51E50 Offset: 0x2F51F51 VA: 0x2F51E50
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0x2F527A0 Offset: 0x2F528A1 VA: 0x2F527A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F48810 Offset: 0x2F48911 VA: 0x2F48810
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0x2F49FC0 Offset: 0x2F4A0C1 VA: 0x2F49FC0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0x2F4B750 Offset: 0x2F4B851 VA: 0x2F4B750
	|-AsyncTaskMethodBuilder<ValueTuple<int, int>>..cctor
	|
	|-RVA: 0x2F4D010 Offset: 0x2F4D111 VA: 0x2F4D010
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>..cctor
	|
	|-RVA: 0x2F4E8F0 Offset: 0x2F4E9F1 VA: 0x2F4E8F0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>..cctor
	|
	|-RVA: 0x2F500A0 Offset: 0x2F501A1 VA: 0x2F500A0
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0x2F51830 Offset: 0x2F51931 VA: 0x2F51830
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0x2F52180 Offset: 0x2F52281 VA: 0x2F52180
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0x2F53910 Offset: 0x2F53A11 VA: 0x2F53910
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	*/
}

