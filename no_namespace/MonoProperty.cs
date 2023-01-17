// Namespace: 
private sealed class MonoProperty.GetterAdapter : MulticastDelegate // TypeDefIndex: 590
{
	// Methods

	// RVA: 0x35EEAE0 Offset: 0x35EEBE1 VA: 0x35EEAE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35EEB00 Offset: 0x35EEC01 VA: 0x35EEB00 Slot: 13
	public virtual object Invoke(object _this) { }

	// RVA: 0x35EEE60 Offset: 0x35EEF61 VA: 0x35EEE60 Slot: 14
	public virtual IAsyncResult BeginInvoke(object _this, AsyncCallback callback, object object) { }

	// RVA: 0x35EEE90 Offset: 0x35EEF91 VA: 0x35EEE90 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

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

// Namespace: 
private sealed class MonoProperty.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 592
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4530 Offset: 0x36C4631 VA: 0x36C4530
	|-MonoProperty.StaticGetter<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4550 Offset: 0x36C4651 VA: 0x36C4550
	|-MonoProperty.StaticGetter<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4760 Offset: 0x36C4861 VA: 0x36C4760
	|-MonoProperty.StaticGetter<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual R EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C4790 Offset: 0x36C4891 VA: 0x36C4790
	|-MonoProperty.StaticGetter<object>.EndInvoke
	*/
}

