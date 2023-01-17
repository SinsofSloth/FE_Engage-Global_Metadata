// Namespace: UnityEngine.ResourceManagement.Util
public class LRUCacheAllocationStrategy : IAllocationStrategy // TypeDefIndex: 5566
{
	// Fields
	private int m_poolMaxSize; // 0x10
	private int m_poolInitialCapacity; // 0x14
	private int m_poolCacheMaxSize; // 0x18
	private List<List<object>> m_poolCache; // 0x20
	private Dictionary<int, List<object>> m_cache; // 0x28

	// Methods

	// RVA: 0x362E050 Offset: 0x362E151 VA: 0x362E050
	public void .ctor(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity) { }

	// RVA: 0x362E1E0 Offset: 0x362E2E1 VA: 0x362E1E0
	private List<object> GetPool() { }

	// RVA: 0x362E2C0 Offset: 0x362E3C1 VA: 0x362E2C0
	private void ReleasePool(List<object> pool) { }

	// RVA: 0x362E350 Offset: 0x362E451 VA: 0x362E350 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x362E4D0 Offset: 0x362E5D1 VA: 0x362E4D0 Slot: 5
	public void Release(int typeHash, object obj) { }
}

