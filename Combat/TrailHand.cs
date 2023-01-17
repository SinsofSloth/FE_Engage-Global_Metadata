// Namespace: Combat
internal struct TrailHand // TypeDefIndex: 8652
{
	// Fields
	public TrailVertexSupplier Supplier; // 0x0
	public TrailMesh Mesh; // 0x8
	public Transform RootNode; // 0x10
	public Transform TipNode; // 0x18

	// Properties
	public bool IsAlive { get; }

	// Methods

	// RVA: 0x25EBFF0 Offset: 0x25EC0F1 VA: 0x25EBFF0
	public bool get_IsAlive() { }

	// RVA: 0x25EC110 Offset: 0x25EC211 VA: 0x25EC110
	public bool SetRootAndTipTransform(Transform t, string rootName, string tipName) { }

	// RVA: 0x25EC260 Offset: 0x25EC361 VA: 0x25EC260
	public void Clear() { }

	// RVA: 0x25EC270 Offset: 0x25EC371 VA: 0x25EC270
	public void Update(float dt) { }
}

