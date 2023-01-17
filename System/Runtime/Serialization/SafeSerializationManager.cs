// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 1009
{
	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x479350 Offset: 0x479451 VA: 0x479350
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x47D110 Offset: 0x47D211 VA: 0x47D110
	// RVA: 0x36105D0 Offset: 0x36106D1 VA: 0x36105D0
	internal void add_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x47D120 Offset: 0x47D221 VA: 0x47D120
	// RVA: 0x3610680 Offset: 0x3610781 VA: 0x3610680
	internal void remove_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x3610730 Offset: 0x3610831 VA: 0x3610730
	internal void .ctor() { }

	// RVA: 0x3610740 Offset: 0x3610841 VA: 0x3610740
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3610A70 Offset: 0x3610B71 VA: 0x3610A70
	internal bool get_IsActive() { }

	// RVA: 0x3610A80 Offset: 0x3610B81 VA: 0x3610A80
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3610D80 Offset: 0x3610E81 VA: 0x3610D80
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x36110D0 Offset: 0x36111D1 VA: 0x36110D0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3611190 Offset: 0x3611291 VA: 0x3611190 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x47D130 Offset: 0x47D231 VA: 0x47D130
	// RVA: 0x36114C0 Offset: 0x36115C1 VA: 0x36114C0
	private void OnDeserialized(StreamingContext context) { }
}

