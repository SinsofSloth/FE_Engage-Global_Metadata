// Namespace: System
public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 160
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D660 Offset: 0x250D761 VA: 0x250D660
	|-Converter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D680 Offset: 0x250D781 VA: 0x250D680
	|-Converter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(TInput input, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250D9E0 Offset: 0x250DAE1 VA: 0x250D9E0
	|-Converter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TOutput EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x250DA10 Offset: 0x250DB11 VA: 0x250DA10
	|-Converter<object, object>.EndInvoke
	*/
}

