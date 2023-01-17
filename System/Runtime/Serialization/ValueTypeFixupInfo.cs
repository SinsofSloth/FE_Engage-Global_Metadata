// Namespace: System.Runtime.Serialization
internal class ValueTypeFixupInfo // TypeDefIndex: 1026
{
	// Fields
	private long m_containerID; // 0x10
	private FieldInfo m_parentField; // 0x18
	private int[] m_parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x34CDB80 Offset: 0x34CDC81 VA: 0x34CDB80
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x34CDCD0 Offset: 0x34CDDD1 VA: 0x34CDCD0
	public long get_ContainerID() { }

	// RVA: 0x34CDCE0 Offset: 0x34CDDE1 VA: 0x34CDCE0
	public FieldInfo get_ParentField() { }

	// RVA: 0x34CDCF0 Offset: 0x34CDDF1 VA: 0x34CDCF0
	public int[] get_ParentIndex() { }
}

