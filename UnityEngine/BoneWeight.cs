// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43D340 Offset: 0x43D441 VA: 0x43D340
[Serializable]
public struct BoneWeight : IEquatable<BoneWeight> // TypeDefIndex: 3512
{
	// Fields
	[SerializeField] // RVA: 0x442EF0 Offset: 0x442FF1 VA: 0x442EF0
	private float m_Weight0; // 0x0
	[SerializeField] // RVA: 0x442F00 Offset: 0x443001 VA: 0x442F00
	private float m_Weight1; // 0x4
	[SerializeField] // RVA: 0x442F10 Offset: 0x443011 VA: 0x442F10
	private float m_Weight2; // 0x8
	[SerializeField] // RVA: 0x442F20 Offset: 0x443021 VA: 0x442F20
	private float m_Weight3; // 0xC
	[SerializeField] // RVA: 0x442F30 Offset: 0x443031 VA: 0x442F30
	private int m_BoneIndex0; // 0x10
	[SerializeField] // RVA: 0x442F40 Offset: 0x443041 VA: 0x442F40
	private int m_BoneIndex1; // 0x14
	[SerializeField] // RVA: 0x442F50 Offset: 0x443051 VA: 0x442F50
	private int m_BoneIndex2; // 0x18
	[SerializeField] // RVA: 0x442F60 Offset: 0x443061 VA: 0x442F60
	private int m_BoneIndex3; // 0x1C

	// Properties
	public float weight0 { get; }
	public float weight1 { get; }
	public float weight2 { get; }
	public float weight3 { get; }
	public int boneIndex0 { get; }
	public int boneIndex1 { get; }
	public int boneIndex2 { get; }
	public int boneIndex3 { get; }

	// Methods

	// RVA: 0x2F0C150 Offset: 0x2F0C251 VA: 0x2F0C150
	public float get_weight0() { }

	// RVA: 0x2F0C160 Offset: 0x2F0C261 VA: 0x2F0C160
	public float get_weight1() { }

	// RVA: 0x2F0C170 Offset: 0x2F0C271 VA: 0x2F0C170
	public float get_weight2() { }

	// RVA: 0x2F0C180 Offset: 0x2F0C281 VA: 0x2F0C180
	public float get_weight3() { }

	// RVA: 0x2F0C190 Offset: 0x2F0C291 VA: 0x2F0C190
	public int get_boneIndex0() { }

	// RVA: 0x2F0C1A0 Offset: 0x2F0C2A1 VA: 0x2F0C1A0
	public int get_boneIndex1() { }

	// RVA: 0x2F0C1B0 Offset: 0x2F0C2B1 VA: 0x2F0C1B0
	public int get_boneIndex2() { }

	// RVA: 0x2F0C1C0 Offset: 0x2F0C2C1 VA: 0x2F0C1C0
	public int get_boneIndex3() { }

	// RVA: 0x2F0C1D0 Offset: 0x2F0C2D1 VA: 0x2F0C1D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F0C2F0 Offset: 0x2F0C3F1 VA: 0x2F0C2F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2F0C390 Offset: 0x2F0C491 VA: 0x2F0C390 Slot: 4
	public bool Equals(BoneWeight other) { }
}

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

