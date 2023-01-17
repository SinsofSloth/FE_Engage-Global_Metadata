// Namespace: System
[DebuggerTypeProxyAttribute] // RVA: 0x46F8A0 Offset: 0x46F9A1 VA: 0x46F8A0
[ComVisibleAttribute] // RVA: 0x46F8A0 Offset: 0x46F9A1 VA: 0x46F8A0
[DebuggerDisplayAttribute] // RVA: 0x46F8A0 Offset: 0x46F9A1 VA: 0x46F8A0
[Serializable]
public class Lazy<T> // TypeDefIndex: 133
{
	// Fields
	private static readonly Func<T> ALREADY_INVOKED_SENTINEL; // 0x0
	private object m_boxed; // 0x0
	private Func<T> m_valueFactory; // 0x0
	private object m_threadSafeObj; // 0x0

	// Properties
	internal LazyThreadSafetyMode Mode { get; }
	public bool IsValueCreated { get; }
	[DebuggerBrowsableAttribute] // RVA: 0x47DC90 Offset: 0x47DD91 VA: 0x47DC90
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3160 Offset: 0x2AD3261 VA: 0x2AD3160
	|-Lazy<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3180 Offset: 0x2AD3281 VA: 0x2AD3180
	|-Lazy<CustomEnvSetManager>..ctor
	|-Lazy<DebugManager>..ctor
	|-Lazy<object>..ctor
	|-Lazy<VolumeManager>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD31A0 Offset: 0x2AD32A1 VA: 0x2AD31A0
	|-Lazy<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> valueFactory, LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3270 Offset: 0x2AD3371 VA: 0x2AD3270
	|-Lazy<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static object GetObjectFromMode(LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD33A0 Offset: 0x2AD34A1 VA: 0x2AD33A0
	|-Lazy<object>.GetObjectFromMode
	*/

	[OnSerializingAttribute] // RVA: 0x4795E0 Offset: 0x4796E1 VA: 0x4795E0
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD34D0 Offset: 0x2AD35D1 VA: 0x2AD34D0
	|-Lazy<object>.OnSerializing
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD34F0 Offset: 0x2AD35F1 VA: 0x2AD34F0
	|-Lazy<object>.ToString
	*/

	// RVA: -1 Offset: -1
	internal LazyThreadSafetyMode get_Mode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD35A0 Offset: 0x2AD36A1 VA: 0x2AD35A0
	|-Lazy<object>.get_Mode
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3630 Offset: 0x2AD3731 VA: 0x2AD3630
	|-Lazy<object>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3690 Offset: 0x2AD3791 VA: 0x2AD3690
	|-Lazy<CustomEnvSetManager>.get_Value
	|-Lazy<DebugManager>.get_Value
	|-Lazy<object>.get_Value
	|-Lazy<VolumeManager>.get_Value
	*/

	// RVA: -1 Offset: -1
	private T LazyInitValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD37A0 Offset: 0x2AD38A1 VA: 0x2AD37A0
	|-Lazy<object>.LazyInitValue
	*/

	// RVA: -1 Offset: -1
	private Lazy.Boxed<T> CreateValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD3BF0 Offset: 0x2AD3CF1 VA: 0x2AD3BF0
	|-Lazy<object>.CreateValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AD4190 Offset: 0x2AD4291 VA: 0x2AD4190
	|-Lazy<object>..cctor
	*/
}

