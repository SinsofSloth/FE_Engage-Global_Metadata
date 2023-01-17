// Namespace: System.Runtime.Serialization
public sealed class SerializationObjectManager // TypeDefIndex: 1023
{
	// Fields
	private Hashtable m_objectSeenTable; // 0x10
	private SerializationEventHandler m_onSerializedHandler; // 0x18
	private StreamingContext m_context; // 0x20

	// Methods

	// RVA: 0x361BA10 Offset: 0x361BB11 VA: 0x361BA10
	public void .ctor(StreamingContext context) { }

	// RVA: 0x361BAE0 Offset: 0x361BBE1 VA: 0x361BAE0
	public void RegisterObject(object obj) { }

	// RVA: 0x361BCA0 Offset: 0x361BDA1 VA: 0x361BCA0
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x361BC00 Offset: 0x361BD01 VA: 0x361BC00
	private void AddOnSerialized(object obj) { }
}

