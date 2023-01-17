// Namespace: System.Runtime.Remoting.Activation
internal class ActivationServices // TypeDefIndex: 1164
{
	// Fields
	private static IActivator _constructionActivator; // 0x0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0x3559D00 Offset: 0x3559E01 VA: 0x3559D00
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0x3559DC0 Offset: 0x3559EC1 VA: 0x3559DC0
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0x3559FF0 Offset: 0x355A0F1 VA: 0x3559FF0
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0x355A1C0 Offset: 0x355A2C1 VA: 0x355A1C0
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x355AC20 Offset: 0x355AD21 VA: 0x355AC20
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0x355B040 Offset: 0x355B141 VA: 0x355B040
	public static object CreateProxyForType(Type type) { }

	// RVA: 0x355B030 Offset: 0x355B131 VA: 0x355B030
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0x355B1C0 Offset: 0x355B2C1 VA: 0x355B1C0
	public static void EnableProxyActivation(Type type, bool enable) { }
}

