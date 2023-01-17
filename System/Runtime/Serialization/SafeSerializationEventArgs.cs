// Namespace: System.Runtime.Serialization
public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 1007
{
	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x36104D0 Offset: 0x36105D1 VA: 0x36104D0
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x36105C0 Offset: 0x36106C1 VA: 0x36105C0
	internal IList<object> get_SerializedStates() { }
}

