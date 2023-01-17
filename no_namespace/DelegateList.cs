// Namespace: 
internal class DelegateList<T> // TypeDefIndex: 5535
{
	// Fields
	private Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc; // 0x0
	private Action<LinkedListNode<Action<T>>> m_releaseFunc; // 0x0
	private LinkedList<Action<T>> m_callbacks; // 0x0
	private bool m_invoking; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2514080 Offset: 0x2514181 VA: 0x2514080
	|-DelegateList<AsyncOperationHandle<bool>>..ctor
	|
	|-RVA: 0x2514860 Offset: 0x2514961 VA: 0x2514860
	|-DelegateList<AsyncOperationHandle<long>>..ctor
	|
	|-RVA: 0x2515040 Offset: 0x2515141 VA: 0x2515040
	|-DelegateList<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x2515820 Offset: 0x2515921 VA: 0x2515820
	|-DelegateList<AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x2516000 Offset: 0x2516101 VA: 0x2516000
	|-DelegateList<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x25167E0 Offset: 0x25168E1 VA: 0x25167E0
	|-DelegateList<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2516FD0 Offset: 0x25170D1 VA: 0x2516FD0
	|-DelegateList<object>..ctor
	|
	|-RVA: 0x25177A0 Offset: 0x25178A1 VA: 0x25177A0
	|-DelegateList<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2514140 Offset: 0x2514241 VA: 0x2514140
	|-DelegateList<AsyncOperationHandle<bool>>.get_Count
	|
	|-RVA: 0x2514920 Offset: 0x2514A21 VA: 0x2514920
	|-DelegateList<AsyncOperationHandle<long>>.get_Count
	|
	|-RVA: 0x2515100 Offset: 0x2515201 VA: 0x2515100
	|-DelegateList<AsyncOperationHandle<object>>.get_Count
	|
	|-RVA: 0x25158E0 Offset: 0x25159E1 VA: 0x25158E0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.get_Count
	|
	|-RVA: 0x25160C0 Offset: 0x25161C1 VA: 0x25160C0
	|-DelegateList<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x25168A0 Offset: 0x25169A1 VA: 0x25168A0
	|-DelegateList<DiagnosticEvent>.get_Count
	|
	|-RVA: 0x2517090 Offset: 0x2517191 VA: 0x2517090
	|-DelegateList<object>.get_Count
	|
	|-RVA: 0x2517860 Offset: 0x2517961 VA: 0x2517860
	|-DelegateList<float>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2514160 Offset: 0x2514261 VA: 0x2514160
	|-DelegateList<AsyncOperationHandle<bool>>.Add
	|
	|-RVA: 0x2514940 Offset: 0x2514A41 VA: 0x2514940
	|-DelegateList<AsyncOperationHandle<long>>.Add
	|
	|-RVA: 0x2515120 Offset: 0x2515221 VA: 0x2515120
	|-DelegateList<AsyncOperationHandle<object>>.Add
	|
	|-RVA: 0x2515900 Offset: 0x2515A01 VA: 0x2515900
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Add
	|
	|-RVA: 0x25160E0 Offset: 0x25161E1 VA: 0x25160E0
	|-DelegateList<AsyncOperationHandle>.Add
	|
	|-RVA: 0x25168C0 Offset: 0x25169C1 VA: 0x25168C0
	|-DelegateList<DiagnosticEvent>.Add
	|
	|-RVA: 0x25170B0 Offset: 0x25171B1 VA: 0x25170B0
	|-DelegateList<object>.Add
	|
	|-RVA: 0x2517880 Offset: 0x2517981 VA: 0x2517880
	|-DelegateList<float>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2514210 Offset: 0x2514311 VA: 0x2514210
	|-DelegateList<AsyncOperationHandle<bool>>.Remove
	|
	|-RVA: 0x25149F0 Offset: 0x2514AF1 VA: 0x25149F0
	|-DelegateList<AsyncOperationHandle<long>>.Remove
	|
	|-RVA: 0x25151D0 Offset: 0x25152D1 VA: 0x25151D0
	|-DelegateList<AsyncOperationHandle<object>>.Remove
	|
	|-RVA: 0x25159B0 Offset: 0x2515AB1 VA: 0x25159B0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Remove
	|
	|-RVA: 0x2516190 Offset: 0x2516291 VA: 0x2516190
	|-DelegateList<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x2516970 Offset: 0x2516A71 VA: 0x2516970
	|-DelegateList<DiagnosticEvent>.Remove
	|
	|-RVA: 0x2517160 Offset: 0x2517261 VA: 0x2517160
	|-DelegateList<object>.Remove
	|
	|-RVA: 0x2517930 Offset: 0x2517A31 VA: 0x2517930
	|-DelegateList<float>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T res) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2514310 Offset: 0x2514411 VA: 0x2514310
	|-DelegateList<AsyncOperationHandle<bool>>.Invoke
	|
	|-RVA: 0x2514AF0 Offset: 0x2514BF1 VA: 0x2514AF0
	|-DelegateList<AsyncOperationHandle<long>>.Invoke
	|
	|-RVA: 0x25152D0 Offset: 0x25153D1 VA: 0x25152D0
	|-DelegateList<AsyncOperationHandle<object>>.Invoke
	|
	|-RVA: 0x2515AB0 Offset: 0x2515BB1 VA: 0x2515AB0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0x2516290 Offset: 0x2516391 VA: 0x2516290
	|-DelegateList<AsyncOperationHandle>.Invoke
	|
	|-RVA: 0x2516A70 Offset: 0x2516B71 VA: 0x2516A70
	|-DelegateList<DiagnosticEvent>.Invoke
	|
	|-RVA: 0x2517260 Offset: 0x2517361 VA: 0x2517260
	|-DelegateList<object>.Invoke
	|
	|-RVA: 0x2517A30 Offset: 0x2517B31 VA: 0x2517A30
	|-DelegateList<float>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25145A0 Offset: 0x25146A1 VA: 0x25145A0
	|-DelegateList<AsyncOperationHandle<bool>>.Clear
	|
	|-RVA: 0x2514D80 Offset: 0x2514E81 VA: 0x2514D80
	|-DelegateList<AsyncOperationHandle<long>>.Clear
	|
	|-RVA: 0x2515560 Offset: 0x2515661 VA: 0x2515560
	|-DelegateList<AsyncOperationHandle<object>>.Clear
	|
	|-RVA: 0x2515D40 Offset: 0x2515E41 VA: 0x2515D40
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.Clear
	|
	|-RVA: 0x2516520 Offset: 0x2516621 VA: 0x2516520
	|-DelegateList<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x2516D10 Offset: 0x2516E11 VA: 0x2516D10
	|-DelegateList<DiagnosticEvent>.Clear
	|
	|-RVA: 0x25174E0 Offset: 0x25175E1 VA: 0x25174E0
	|-DelegateList<object>.Clear
	|
	|-RVA: 0x2517CB0 Offset: 0x2517DB1 VA: 0x2517CB0
	|-DelegateList<float>.Clear
	*/

	// RVA: -1 Offset: -1
	public static DelegateList<T> CreateWithGlobalCache() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2514650 Offset: 0x2514751 VA: 0x2514650
	|-DelegateList<AsyncOperationHandle<bool>>.CreateWithGlobalCache
	|
	|-RVA: 0x2514E30 Offset: 0x2514F31 VA: 0x2514E30
	|-DelegateList<AsyncOperationHandle<long>>.CreateWithGlobalCache
	|
	|-RVA: 0x2515610 Offset: 0x2515711 VA: 0x2515610
	|-DelegateList<AsyncOperationHandle<object>>.CreateWithGlobalCache
	|
	|-RVA: 0x2515DF0 Offset: 0x2515EF1 VA: 0x2515DF0
	|-DelegateList<AsyncOperationHandle<SceneInstance>>.CreateWithGlobalCache
	|
	|-RVA: 0x25165D0 Offset: 0x25166D1 VA: 0x25165D0
	|-DelegateList<AsyncOperationHandle>.CreateWithGlobalCache
	|
	|-RVA: 0x2516DC0 Offset: 0x2516EC1 VA: 0x2516DC0
	|-DelegateList<DiagnosticEvent>.CreateWithGlobalCache
	|
	|-RVA: 0x2517590 Offset: 0x2517691 VA: 0x2517590
	|-DelegateList<object>.CreateWithGlobalCache
	|
	|-RVA: 0x2517D60 Offset: 0x2517E61 VA: 0x2517D60
	|-DelegateList<float>.CreateWithGlobalCache
	*/
}

