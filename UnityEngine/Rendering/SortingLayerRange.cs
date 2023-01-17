// Namespace: UnityEngine.Rendering
public struct SortingLayerRange : IEquatable<SortingLayerRange> // TypeDefIndex: 3963
{
	// Fields
	private short m_LowerBound; // 0x0
	private short m_UpperBound; // 0x2

	// Properties
	public static SortingLayerRange all { get; }

	// Methods

	// RVA: 0x31EC650 Offset: 0x31EC751 VA: 0x31EC650
	public void .ctor(short lowerBound, short upperBound) { }

	// RVA: 0x31EC660 Offset: 0x31EC761 VA: 0x31EC660
	public static SortingLayerRange get_all() { }

	// RVA: 0x31EC670 Offset: 0x31EC771 VA: 0x31EC670 Slot: 4
	public bool Equals(SortingLayerRange other) { }

	// RVA: 0x31EC6A0 Offset: 0x31EC7A1 VA: 0x31EC6A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31EC740 Offset: 0x31EC841 VA: 0x31EC740 Slot: 2
	public override int GetHashCode() { }
}

