// Namespace: FUtility
public sealed class OrderHandler<T> : MulticastDelegate // TypeDefIndex: 6339
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5DB70 Offset: 0x2A5DC71 VA: 0x2A5DB70
	|-OrderHandler<NativeBlock>..ctor
	|
	|-RVA: 0x2A5DF00 Offset: 0x2A5E001 VA: 0x2A5DF00
	|-OrderHandler<object>..ctor
	|-OrderHandler<SpringJobManager>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(T obj, int no) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5DB90 Offset: 0x2A5DC91 VA: 0x2A5DB90
	|-OrderHandler<NativeBlock>.Invoke
	|
	|-RVA: 0x2A5DF20 Offset: 0x2A5E021 VA: 0x2A5DF20
	|-OrderHandler<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T obj, int no, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5DE10 Offset: 0x2A5DF11 VA: 0x2A5DE10
	|-OrderHandler<NativeBlock>.BeginInvoke
	|
	|-RVA: 0x2A5E2A0 Offset: 0x2A5E3A1 VA: 0x2A5E2A0
	|-OrderHandler<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A5DED0 Offset: 0x2A5DFD1 VA: 0x2A5DED0
	|-OrderHandler<NativeBlock>.EndInvoke
	|
	|-RVA: 0x2A5E340 Offset: 0x2A5E441 VA: 0x2A5E340
	|-OrderHandler<object>.EndInvoke
	*/
}

