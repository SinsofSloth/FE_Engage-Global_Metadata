// Namespace: 
private sealed class MonoProperty.Getter<T, R> : MulticastDelegate // TypeDefIndex: 591
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12060 Offset: 0x3A12161 VA: 0x3A12060
	|-MonoProperty.Getter<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12080 Offset: 0x3A12181 VA: 0x3A12080
	|-MonoProperty.Getter<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T _this, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A123E0 Offset: 0x3A124E1 VA: 0x3A123E0
	|-MonoProperty.Getter<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12410 Offset: 0x3A12511 VA: 0x3A12410
	|-MonoProperty.Getter<object, object>.EndInvoke
	*/
}

