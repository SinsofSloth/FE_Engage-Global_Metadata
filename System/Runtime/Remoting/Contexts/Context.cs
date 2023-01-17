// Namespace: System.Runtime.Remoting.Contexts
[ComVisibleAttribute] // RVA: 0x474C50 Offset: 0x474D51 VA: 0x474C50
public class Context // TypeDefIndex: 1133
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0x479360 Offset: 0x479461 VA: 0x479360
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x33B1F30 Offset: 0x33B2031 VA: 0x33B1F30
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x33B1F40 Offset: 0x33B2041 VA: 0x33B1F40
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x33B1F50 Offset: 0x33B2051 VA: 0x33B1F50
	public void .ctor() { }

	// RVA: 0x33B1FF0 Offset: 0x33B20F1 VA: 0x33B1FF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x33B20B0 Offset: 0x33B21B1 VA: 0x33B20B0
	public static Context get_DefaultContext() { }

	// RVA: 0x33B20C0 Offset: 0x33B21C1 VA: 0x33B20C0 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x33B20D0 Offset: 0x33B21D1 VA: 0x33B20D0 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x33B2150 Offset: 0x33B2251 VA: 0x33B2150
	internal bool get_IsDefaultContext() { }

	// RVA: 0x33B2160 Offset: 0x33B2261 VA: 0x33B2160
	internal bool get_NeedsContextSink() { }

	// RVA: 0x33B2250 Offset: 0x33B2351 VA: 0x33B2250
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x33B2540 Offset: 0x33B2641 VA: 0x33B2540
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x33B22E0 Offset: 0x33B23E1 VA: 0x33B22E0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x33A5CF0 Offset: 0x33A5DF1 VA: 0x33A5CF0
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x33A6510 Offset: 0x33A6611 VA: 0x33A6510
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x33A5E20 Offset: 0x33A5F21 VA: 0x33A5E20
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x33A64F0 Offset: 0x33A65F1 VA: 0x33A64F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x33B25D0 Offset: 0x33B26D1 VA: 0x33B25D0
	internal bool get_HasExitSinks() { }

	// RVA: 0x33B2920 Offset: 0x33B2A21 VA: 0x33B2920 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x33B2AF0 Offset: 0x33B2BF1 VA: 0x33B2AF0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x33B2C60 Offset: 0x33B2D61 VA: 0x33B2C60 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x33B2DE0 Offset: 0x33B2EE1 VA: 0x33B2DE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x33B1870 Offset: 0x33B1971 VA: 0x33B1870
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x33B2720 Offset: 0x33B2821 VA: 0x33B2720
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x33A58A0 Offset: 0x33A59A1 VA: 0x33A58A0
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x33B2E70 Offset: 0x33B2F71 VA: 0x33B2E70
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x33B3060 Offset: 0x33B3161 VA: 0x33B3060
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x33B3070 Offset: 0x33B3171 VA: 0x33B3070
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x33B37F0 Offset: 0x33B38F1 VA: 0x33B37F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x33B3980 Offset: 0x33B3A81 VA: 0x33B3980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x33B3B10 Offset: 0x33B3C11 VA: 0x33B3B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x33B3B80 Offset: 0x33B3C81 VA: 0x33B3B80
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x33B3C00 Offset: 0x33B3D01 VA: 0x33B3C00
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x33B3C80 Offset: 0x33B3D81 VA: 0x33B3C80
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x33B3D00 Offset: 0x33B3E01 VA: 0x33B3D00
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x33B3D30 Offset: 0x33B3E31 VA: 0x33B3D30
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x33B3D70 Offset: 0x33B3E71 VA: 0x33B3D70
	private static void .cctor() { }
}

