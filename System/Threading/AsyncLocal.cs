// Namespace: System.Threading
public sealed class AsyncLocal<T> : IAsyncLocal // TypeDefIndex: 751
{
	// Fields
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler; // 0x0

	// Properties
	public T Value { set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2670 Offset: 0x32D2771 VA: 0x32D2670
	|-AsyncLocal<CultureInfo>..ctor
	|-AsyncLocal<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D26B0 Offset: 0x32D27B1 VA: 0x32D26B0
	|-AsyncLocal<CultureInfo>.set_Value
	|-AsyncLocal<object>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2730 Offset: 0x32D2831 VA: 0x32D2730
	|-AsyncLocal<object>.System.Threading.IAsyncLocal.OnValueChanged
	*/
}

