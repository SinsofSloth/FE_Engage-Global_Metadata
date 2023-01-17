// Namespace: UnityEngine.AddressableAssets
internal class CheckCatalogsOperation : AsyncOperationBase<List<string>> // TypeDefIndex: 7294
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x88
	private List<string> m_LocalHashes; // 0x90
	private List<AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos; // 0x98
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA0

	// Methods

	// RVA: 0x3092550 Offset: 0x3092651 VA: 0x3092550
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x30925C0 Offset: 0x30926C1 VA: 0x30925C0
	public AsyncOperationHandle<List<string>> Start(List<AddressablesImpl.ResourceLocatorInfo> locatorInfos) { }

	// RVA: 0x3096300 Offset: 0x3096401 VA: 0x3096300 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x3096450 Offset: 0x3096551 VA: 0x3096450 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x30964D0 Offset: 0x30965D1 VA: 0x30964D0 Slot: 32
	protected override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x3096590 Offset: 0x3096691 VA: 0x3096590 Slot: 28
	protected override void Execute() { }
}

