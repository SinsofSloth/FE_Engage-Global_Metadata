// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class DependenciesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 5559
{
	// Fields
	private readonly IList<IResourceLocation> m_Dependencies; // 0x10
	private readonly int m_DependenciesHash; // 0x18

	// Methods

	// RVA: 0x362A370 Offset: 0x362A471 VA: 0x362A370
	public void .ctor(IList<IResourceLocation> dependencies, int dependenciesHash) { }

	// RVA: 0x362A3C0 Offset: 0x362A4C1 VA: 0x362A3C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x362A3D0 Offset: 0x362A4D1 VA: 0x362A3D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x362A4B0 Offset: 0x362A5B1 VA: 0x362A4B0 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x362A480 Offset: 0x362A581 VA: 0x362A480
	private bool Equals(DependenciesCacheKey other) { }
}

