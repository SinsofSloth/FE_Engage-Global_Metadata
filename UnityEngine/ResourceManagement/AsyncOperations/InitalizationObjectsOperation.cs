// Namespace: UnityEngine.ResourceManagement.AsyncOperations
internal class InitalizationObjectsOperation : AsyncOperationBase<bool> // TypeDefIndex: 7251
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp; // 0x88
	private AddressablesImpl m_Addressables; // 0xA0
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA8

	// Properties
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x30997E0 Offset: 0x30998E1 VA: 0x30997E0
	public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables) { }

	// RVA: 0x3099840 Offset: 0x3099941 VA: 0x3099840 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x3099890 Offset: 0x3099991 VA: 0x3099890
	internal bool LogRuntimeWarnings(string pathToBuildLogs) { }

	// RVA: 0x3099A80 Offset: 0x3099B81 VA: 0x3099A80 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x3099C30 Offset: 0x3099D31 VA: 0x3099C30 Slot: 28
	protected override void Execute() { }

	// RVA: 0x309A2D0 Offset: 0x309A3D1 VA: 0x309A2D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x65E80 Offset: 0x65F81 VA: 0x65E80
	// RVA: 0x309A330 Offset: 0x309A431 VA: 0x309A330
	private void <Execute>b__8_0(AsyncOperationHandle<IList<AsyncOperationHandle>> obj) { }
}

