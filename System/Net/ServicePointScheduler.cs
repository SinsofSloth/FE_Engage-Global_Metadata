// Namespace: System.Net
internal class ServicePointScheduler // TypeDefIndex: 2578
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x318A0 Offset: 0x319A1 VA: 0x318A0
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private ServicePointScheduler.AsyncManualResetEvent schedulerEvent; // 0x20
	private ServicePointScheduler.ConnectionGroup defaultGroup; // 0x28
	private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups; // 0x30
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations; // 0x38
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58

	// Properties
	public ServicePoint ServicePoint { get; }
	public int MaxIdleTime { get; }
	public int ConnectionLimit { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x32880 Offset: 0x32981 VA: 0x32880
	// RVA: 0x2D074A0 Offset: 0x2D075A1 VA: 0x2D074A0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x2D074B0 Offset: 0x2D075B1 VA: 0x2D074B0
	public int get_MaxIdleTime() { }

	// RVA: 0x2D074C0 Offset: 0x2D075C1 VA: 0x2D074C0
	public int get_ConnectionLimit() { }

	// RVA: 0x2D05460 Offset: 0x2D05561 VA: 0x2D05460
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x2D074D0 Offset: 0x2D075D1 VA: 0x2D074D0
	public void Run() { }

	[AsyncStateMachineAttribute] // RVA: 0x32890 Offset: 0x32991 VA: 0x32890
	// RVA: 0x2D076C0 Offset: 0x2D077C1 VA: 0x2D076C0
	private void StartScheduler() { }

	// RVA: 0x2D077E0 Offset: 0x2D078E1 VA: 0x2D077E0
	private void Cleanup() { }

	// RVA: 0x2D079C0 Offset: 0x2D07AC1 VA: 0x2D079C0
	private void RunSchedulerIteration() { }

	// RVA: 0x2D07C70 Offset: 0x2D07D71 VA: 0x2D07C70
	private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation, Task<ValueTuple<bool, WebOperation>> task) { }

	// RVA: 0x2D07F90 Offset: 0x2D08091 VA: 0x2D07F90
	private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x2D07B80 Offset: 0x2D07C81 VA: 0x2D07B80
	private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group) { }

	// RVA: 0x2D07FD0 Offset: 0x2D080D1 VA: 0x2D07FD0
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x2D07EC0 Offset: 0x2D07FC1 VA: 0x2D07EC0
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x2D06320 Offset: 0x2D06421 VA: 0x2D06320
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x2D080A0 Offset: 0x2D081A1 VA: 0x2D080A0
	private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x2D082A0 Offset: 0x2D083A1 VA: 0x2D082A0
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x2D082B0 Offset: 0x2D083B1 VA: 0x2D082B0
	private void OnConnectionClosed(WebConnection connection) { }
}

