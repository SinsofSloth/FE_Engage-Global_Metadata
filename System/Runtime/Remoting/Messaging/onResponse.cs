// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliantAttribute] // RVA: 0x475140 Offset: 0x475241 VA: 0x475140
[ComVisibleAttribute] // RVA: 0x475140 Offset: 0x475241 VA: 0x475140
[Serializable]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 1196
{
	// Properties
	public override IDictionary Properties { get; }

	// Methods

	// RVA: 0x33B1AA0 Offset: 0x33B1BA1 VA: 0x33B1AA0
	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x33B1AC0 Offset: 0x33B1BC1 VA: 0x33B1AC0
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x33B1AD0 Offset: 0x33B1BD1 VA: 0x33B1AD0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33B1AE0 Offset: 0x33B1BE1 VA: 0x33B1AE0 Slot: 22
	public override IDictionary get_Properties() { }
}

