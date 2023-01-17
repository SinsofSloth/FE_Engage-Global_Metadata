// Namespace: System.Runtime.Remoting.Proxies
[AttributeUsageAttribute] // RVA: 0x474B70 Offset: 0x474C71 VA: 0x474B70
[ComVisibleAttribute] // RVA: 0x474B70 Offset: 0x474C71 VA: 0x474B70
public class ProxyAttribute : Attribute // TypeDefIndex: 1121
{
	// Methods

	// RVA: 0x3B66C30 Offset: 0x3B66D31 VA: 0x3B66C30 Slot: 4
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x3B66D30 Offset: 0x3B66E31 VA: 0x3B66D30 Slot: 5
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }
}

