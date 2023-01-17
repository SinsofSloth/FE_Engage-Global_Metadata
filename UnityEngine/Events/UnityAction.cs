// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3703
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF4C80 Offset: 0x2DF4D81 VA: 0x2DF4C80
	|-UnityAction<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF4CA0 Offset: 0x2DF4DA1 VA: 0x2DF4CA0
	|-UnityAction<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF5060 Offset: 0x2DF5161 VA: 0x2DF5060
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF50A0 Offset: 0x2DF51A1 VA: 0x2DF50A0
	|-UnityAction<object, object, object, object>.EndInvoke
	*/
}

