// Namespace: UniRx.Operators
public sealed class ZipFunc<T1, T2, T3, T4, T5, T6, TR> : MulticastDelegate // TypeDefIndex: 7149
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF0620 Offset: 0x3EF0721 VA: 0x3EF0620
	|-ZipFunc<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TR Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF0640 Offset: 0x3EF0741 VA: 0x3EF0640
	|-ZipFunc<object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF0A20 Offset: 0x3EF0B21 VA: 0x3EF0A20
	|-ZipFunc<object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TR EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF0A60 Offset: 0x3EF0B61 VA: 0x3EF0A60
	|-ZipFunc<object, object, object, object, object, object, object>.EndInvoke
	*/
}

