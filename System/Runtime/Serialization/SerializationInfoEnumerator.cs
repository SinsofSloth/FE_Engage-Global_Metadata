// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x4747C0 Offset: 0x4748C1 VA: 0x4747C0
public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 1022
{
	// Fields
	private string[] m_members; // 0x10
	private object[] m_data; // 0x18
	private Type[] m_types; // 0x20
	private int m_numItems; // 0x28
	private int m_currItem; // 0x2C
	private bool m_current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x361A050 Offset: 0x361A151 VA: 0x361A050
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x3615630 Offset: 0x3615731 VA: 0x3615630 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x361B6F0 Offset: 0x361B7F1 VA: 0x361B6F0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x361B850 Offset: 0x361B951 VA: 0x361B850
	public SerializationEntry get_Current() { }

	// RVA: 0x361B960 Offset: 0x361BA61 VA: 0x361B960 Slot: 6
	public void Reset() { }

	// RVA: 0x36154F0 Offset: 0x36155F1 VA: 0x36154F0
	public string get_Name() { }

	// RVA: 0x3615590 Offset: 0x3615691 VA: 0x3615590
	public object get_Value() { }

	// RVA: 0x361B970 Offset: 0x361BA71 VA: 0x361B970
	public Type get_ObjectType() { }
}

