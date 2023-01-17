// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43D350 Offset: 0x43D451 VA: 0x43D350
[Serializable]
public struct BoneWeight1 : IEquatable<BoneWeight1> // TypeDefIndex: 3513
{
	// Fields
	[SerializeField] // RVA: 0x442F70 Offset: 0x443071 VA: 0x442F70
	private float m_Weight; // 0x0
	[SerializeField] // RVA: 0x442F80 Offset: 0x443081 VA: 0x442F80
	private int m_BoneIndex; // 0x4

	// Properties
	public float weight { get; }
	public int boneIndex { get; }

	// Methods

	// RVA: 0x2F0C4B0 Offset: 0x2F0C5B1 VA: 0x2F0C4B0
	public float get_weight() { }

	// RVA: 0x2F0C4C0 Offset: 0x2F0C5C1 VA: 0x2F0C4C0
	public int get_boneIndex() { }

	// RVA: 0x2F0C4D0 Offset: 0x2F0C5D1 VA: 0x2F0C4D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2F0C590 Offset: 0x2F0C691 VA: 0x2F0C590 Slot: 4
	public bool Equals(BoneWeight1 other) { }

	// RVA: 0x2F0C600 Offset: 0x2F0C701 VA: 0x2F0C600 Slot: 2
	public override int GetHashCode() { }
}

