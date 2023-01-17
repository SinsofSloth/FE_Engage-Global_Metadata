// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x474A70 Offset: 0x474B71 VA: 0x474A70
public static class RemotingServices // TypeDefIndex: 1106
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x321D910 Offset: 0x321DA11 VA: 0x321D910
	private static void .cctor() { }

	// RVA: 0x321DE10 Offset: 0x321DF11 VA: 0x321DE10
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x321DE20 Offset: 0x321DF21 VA: 0x321DE20
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x321DE30 Offset: 0x321DF31 VA: 0x321DE30
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x321DE70 Offset: 0x321DF71 VA: 0x321DE70
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0x47D200 Offset: 0x47D301 VA: 0x47D200
	// RVA: 0x321E9B0 Offset: 0x321EAB1 VA: 0x321E9B0
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0x47D220 Offset: 0x47D321 VA: 0x47D220
	// RVA: 0x321EB50 Offset: 0x321EC51 VA: 0x321EB50
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x321EC60 Offset: 0x321ED61 VA: 0x321EC60
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x321F000 Offset: 0x321F101 VA: 0x321F000
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x321F070 Offset: 0x321F171 VA: 0x321F070
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x321F4D0 Offset: 0x321F5D1 VA: 0x321F4D0
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x321F540 Offset: 0x321F641 VA: 0x321F540
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x321F630 Offset: 0x321F731 VA: 0x321F630
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0x47D240 Offset: 0x47D341 VA: 0x47D240
	// RVA: 0x321F5D0 Offset: 0x321F6D1 VA: 0x321F5D0
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x321FE10 Offset: 0x321FF11 VA: 0x321FE10
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x3220110 Offset: 0x3220211 VA: 0x3220110
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x3220310 Offset: 0x3220411 VA: 0x3220310
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x3220450 Offset: 0x3220551 VA: 0x3220450
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x32205C0 Offset: 0x32206C1 VA: 0x32205C0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x3220660 Offset: 0x3220761 VA: 0x3220660
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x32207C0 Offset: 0x32208C1 VA: 0x32207C0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x3220A20 Offset: 0x3220B21 VA: 0x3220A20
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x3220AA0 Offset: 0x3220BA1 VA: 0x3220AA0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x321ED40 Offset: 0x321EE41 VA: 0x321ED40
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x3220CD0 Offset: 0x3220DD1 VA: 0x3220CD0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x3220E10 Offset: 0x3220F11 VA: 0x3220E10
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x3220920 Offset: 0x3220A21 VA: 0x3220920
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x32213B0 Offset: 0x32214B1 VA: 0x32213B0
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x321FCB0 Offset: 0x321FDB1 VA: 0x321FCB0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x321DCB0 Offset: 0x321DDB1 VA: 0x321DCB0
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x321FAA0 Offset: 0x321FBA1 VA: 0x321FAA0
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x321F370 Offset: 0x321F471 VA: 0x321F370
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x321EAC0 Offset: 0x321EBC1 VA: 0x321EAC0
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x32214C0 Offset: 0x32215C1 VA: 0x32214C0
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x3221620 Offset: 0x3221721 VA: 0x3221620
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x3221790 Offset: 0x3221891 VA: 0x3221790
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x321DC40 Offset: 0x321DD41 VA: 0x321DC40
	private static void RegisterInternalChannels() { }

	// RVA: 0x321D5B0 Offset: 0x321D6B1 VA: 0x321D5B0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x3221850 Offset: 0x3221951 VA: 0x3221850
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x3221BC0 Offset: 0x3221CC1 VA: 0x3221BC0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x3221CD0 Offset: 0x3221DD1 VA: 0x3221CD0
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x3220C50 Offset: 0x3220D51 VA: 0x3220C50
	private static string GetNormalizedUri(string uri) { }
}

