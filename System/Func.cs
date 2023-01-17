// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : MulticastDelegate // TypeDefIndex: 2717
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70F30 Offset: 0x1E71031 VA: 0x1E70F30
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70F50 Offset: 0x1E71051 VA: 0x1E70F50
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E71440 Offset: 0x1E71541 VA: 0x1E71440
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E714A0 Offset: 0x1E715A1 VA: 0x1E714A0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

