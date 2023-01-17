// Namespace: UnityEngine.AddressableAssets
internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>> // TypeDefIndex: 7296
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x88
	private List<AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos; // 0x90
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0x98

	// Methods

	// RVA: 0x3092EB0 Offset: 0x3092FB1 VA: 0x3092EB0
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x3092F20 Offset: 0x3093021 VA: 0x3092F20
	public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds) { }

	// RVA: 0x309FE20 Offset: 0x309FF21 VA: 0x309FE20 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x309FF70 Offset: 0x30A0071 VA: 0x309FF70 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x309FFF0 Offset: 0x30A00F1 VA: 0x309FFF0 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x30A00B0 Offset: 0x30A01B1 VA: 0x30A00B0 Slot: 28
	protected override void Execute() { }
}

