// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class AsyncOpHandlesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 5560
{
	// Fields
	private readonly HashSet<AsyncOperationHandle> m_Handles; // 0x10

	// Methods

	// RVA: 0x36262E0 Offset: 0x36263E1 VA: 0x36262E0
	public void .ctor(IList<AsyncOperationHandle> handles) { }

	// RVA: 0x3626380 Offset: 0x3626481 VA: 0x3626380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3626390 Offset: 0x3626491 VA: 0x3626390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x36264F0 Offset: 0x36265F1 VA: 0x36264F0 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x3626460 Offset: 0x3626561 VA: 0x3626460
	private bool Equals(AsyncOpHandlesCacheKey other) { }
}

