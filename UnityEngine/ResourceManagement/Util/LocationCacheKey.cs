// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class LocationCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 5558
{
	// Fields
	private readonly IResourceLocation m_Location; // 0x10
	private readonly Type m_DesiredType; // 0x18

	// Methods

	// RVA: 0x362F690 Offset: 0x362F791 VA: 0x362F690
	public void .ctor(IResourceLocation location, Type desiredType) { }

	// RVA: 0x362F7B0 Offset: 0x362F8B1 VA: 0x362F7B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x362F860 Offset: 0x362F961 VA: 0x362F860 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x362F990 Offset: 0x362FA91 VA: 0x362F990 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x362F920 Offset: 0x362FA21 VA: 0x362F920
	private bool Equals(LocationCacheKey other) { }
}

