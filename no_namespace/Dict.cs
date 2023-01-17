// Namespace: 
public class Dict.Node<TValue> // TypeDefIndex: 5505
{
	// Fields
	internal TValue _key; // 0x0
	internal Dict.Node<TValue> _prev; // 0x0
	internal Dict.Node<TValue> _next; // 0x0

	// Properties
	public TValue Key { get; }
	public Dict.Node<TValue> Prev { get; }
	public Dict.Node<TValue> Next { get; }

	// Methods

	// RVA: -1 Offset: -1
	public TValue get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A72E0 Offset: 0x31A73E1 VA: 0x31A72E0
	|-Dict.Node<object>.get_Key
	|-Dict.Node<Tess.ActiveRegion>.get_Key
	*/

	// RVA: -1 Offset: -1
	public Dict.Node<TValue> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A72F0 Offset: 0x31A73F1 VA: 0x31A72F0
	|-Dict.Node<object>.get_Prev
	*/

	// RVA: -1 Offset: -1
	public Dict.Node<TValue> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7300 Offset: 0x31A7401 VA: 0x31A7300
	|-Dict.Node<object>.get_Next
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A7310 Offset: 0x31A7411 VA: 0x31A7310
	|-Dict.Node<object>..ctor
	*/
}

// Namespace: 
public sealed class Dict.LessOrEqual<TValue> : MulticastDelegate // TypeDefIndex: 5506
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD54D0 Offset: 0x2AD55D1 VA: 0x2AD54D0
	|-Dict.LessOrEqual<object>..ctor
	|-Dict.LessOrEqual<Tess.ActiveRegion>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(TValue lhs, TValue rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD54F0 Offset: 0x2AD55F1 VA: 0x2AD54F0
	|-Dict.LessOrEqual<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(TValue lhs, TValue rhs, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD5870 Offset: 0x2AD5971 VA: 0x2AD5870
	|-Dict.LessOrEqual<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD58A0 Offset: 0x2AD59A1 VA: 0x2AD58A0
	|-Dict.LessOrEqual<object>.EndInvoke
	*/
}

