// Namespace: MoonSharp.Interpreter.Interop
public interface IProxyFactory // TypeDefIndex: 6078
{
	// Properties
	public abstract Type TargetType { get; }
	public abstract Type ProxyType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object CreateProxyObject(object o);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Type get_ProxyType();
}

