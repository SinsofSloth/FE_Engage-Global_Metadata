// Namespace: 
public sealed class ConditionalWeakTable.CreateValueCallback<TKey, TValue> : MulticastDelegate // TypeDefIndex: 1280
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510510 Offset: 0x2510611 VA: 0x2510510
	|-ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext>..ctor
	|-ConditionalWeakTable.CreateValueCallback<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510530 Offset: 0x2510631 VA: 0x2510530
	|-ConditionalWeakTable.CreateValueCallback<object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(TKey key, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2510890 Offset: 0x2510991 VA: 0x2510890
	|-ConditionalWeakTable.CreateValueCallback<object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TValue EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25108C0 Offset: 0x25109C1 VA: 0x25108C0
	|-ConditionalWeakTable.CreateValueCallback<object, object>.EndInvoke
	*/
}

