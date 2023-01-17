// Namespace: MoonSharp.Interpreter.Interop
public class DelegateProxyFactory<TProxy, TTarget> : IProxyFactory<TProxy, TTarget>, IProxyFactory // TypeDefIndex: 6077
{
	// Fields
	private Func<TTarget, TProxy> wrapDelegate; // 0x0

	// Properties
	public Type TargetType { get; }
	public Type ProxyType { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TTarget, TProxy> wrapDelegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517F70 Offset: 0x2518071 VA: 0x2517F70
	|-DelegateProxyFactory<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TProxy CreateProxyObject(TTarget target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517FB0 Offset: 0x25180B1 VA: 0x2517FB0
	|-DelegateProxyFactory<object, object>.CreateProxyObject
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object CreateProxyObject(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2517FD0 Offset: 0x25180D1 VA: 0x2517FD0
	|-DelegateProxyFactory<object, object>.CreateProxyObject
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public Type get_TargetType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2518070 Offset: 0x2518171 VA: 0x2518070
	|-DelegateProxyFactory<object, object>.get_TargetType
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public Type get_ProxyType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25180F0 Offset: 0x25181F1 VA: 0x25180F0
	|-DelegateProxyFactory<object, object>.get_ProxyType
	*/
}

