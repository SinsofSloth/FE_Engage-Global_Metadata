// Namespace: System.Runtime.Serialization
internal class ObjectHolderListEnumerator // TypeDefIndex: 1005
{
	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x38650E0 Offset: 0x38651E1 VA: 0x38650E0
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x3865150 Offset: 0x3865251 VA: 0x3865150
	internal bool MoveNext() { }

	// RVA: 0x3865200 Offset: 0x3865301 VA: 0x3865200
	internal ObjectHolder get_Current() { }
}

