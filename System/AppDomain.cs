// Namespace: System
[ComVisibleAttribute] // RVA: 0x470F00 Offset: 0x471001 VA: 0x470F00
[ClassInterfaceAttribute] // RVA: 0x470F00 Offset: 0x471001 VA: 0x470F00
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 338
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0x4780B0 Offset: 0x4781B1 VA: 0x4780B0
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x4780C0 Offset: 0x4781C1 VA: 0x4780C0
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x4780D0 Offset: 0x4781D1 VA: 0x4780D0
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0x4780E0 Offset: 0x4781E1 VA: 0x4780E0
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x4780F0 Offset: 0x4781F1 VA: 0x4780F0
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x478100 Offset: 0x478201 VA: 0x478100
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x478110 Offset: 0x478211 VA: 0x478110
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x478120 Offset: 0x478221 VA: 0x478120
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x478130 Offset: 0x478231 VA: 0x478130
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x478140 Offset: 0x478241 VA: 0x478140
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x478150 Offset: 0x478251 VA: 0x478150
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x478160 Offset: 0x478261 VA: 0x478160
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x478170 Offset: 0x478271 VA: 0x478170
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x355D010 Offset: 0x355D111 VA: 0x355D010
	private void .ctor() { }

	// RVA: 0x355D020 Offset: 0x355D121 VA: 0x355D020
	private string getFriendlyName() { }

	// RVA: 0x355D030 Offset: 0x355D131 VA: 0x355D030
	private static AppDomain getCurDomain() { }

	// RVA: 0x355D040 Offset: 0x355D141 VA: 0x355D040
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x355D050 Offset: 0x355D151 VA: 0x355D050
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x355D060 Offset: 0x355D161 VA: 0x355D060 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x355D070 Offset: 0x355D171 VA: 0x355D070 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x355D080 Offset: 0x355D181 VA: 0x355D080 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x355D090 Offset: 0x355D191 VA: 0x355D090
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x355D0A0 Offset: 0x355D1A1 VA: 0x355D0A0 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x355D0B0 Offset: 0x355D1B1 VA: 0x355D0B0
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x355D1E0 Offset: 0x355D2E1 VA: 0x355D1E0
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x355D1F0 Offset: 0x355D2F1 VA: 0x355D1F0
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x355D200 Offset: 0x355D301 VA: 0x355D200
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x355D210 Offset: 0x355D311 VA: 0x355D210
	internal static void InternalPopDomainRef() { }

	// RVA: 0x355D220 Offset: 0x355D321 VA: 0x355D220
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x355D230 Offset: 0x355D331 VA: 0x355D230
	internal static Context InternalGetContext() { }

	// RVA: 0x355D240 Offset: 0x355D341 VA: 0x355D240
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x355D250 Offset: 0x355D351 VA: 0x355D250
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x355D260 Offset: 0x355D361 VA: 0x355D260
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x355D400 Offset: 0x355D501 VA: 0x355D400
	internal static string GetProcessGuid() { }

	// RVA: 0x355D4E0 Offset: 0x355D5E1 VA: 0x355D4E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x355D4F0 Offset: 0x355D5F1 VA: 0x355D4F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x355D510 Offset: 0x355D611 VA: 0x355D510
	private int getDomainID() { }

	// RVA: 0x355D520 Offset: 0x355D621 VA: 0x355D520 Slot: 3
	public override string ToString() { }

	// RVA: 0x355D530 Offset: 0x355D631 VA: 0x355D530
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x355DA10 Offset: 0x355DB11 VA: 0x355DA10
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x355DD50 Offset: 0x355DE51 VA: 0x355DD50
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x355DFF0 Offset: 0x355E0F1 VA: 0x355DFF0
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x355E120 Offset: 0x355E221 VA: 0x355E120
	private void DoDomainUnload() { }

	// RVA: 0x355E140 Offset: 0x355E241 VA: 0x355E140
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x355E230 Offset: 0x355E331 VA: 0x355E230
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0x47AF40 Offset: 0x47B041 VA: 0x47AF40
	// RVA: 0x355E390 Offset: 0x355E491 VA: 0x355E390 Slot: 9
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x47AF50 Offset: 0x47B051 VA: 0x47AF50
	// RVA: 0x355E440 Offset: 0x355E541 VA: 0x355E440 Slot: 10
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x47AF60 Offset: 0x47B061 VA: 0x47AF60
	// RVA: 0x355E4F0 Offset: 0x355E5F1 VA: 0x355E4F0 Slot: 11
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x47AF70 Offset: 0x47B071 VA: 0x47AF70
	// RVA: 0x355E5A0 Offset: 0x355E6A1 VA: 0x355E5A0 Slot: 12
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }
}

