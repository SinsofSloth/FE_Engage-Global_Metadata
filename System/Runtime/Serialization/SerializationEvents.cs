// Namespace: System.Runtime.Serialization
internal class SerializationEvents // TypeDefIndex: 1016
{
	// Fields
	private List<MethodInfo> m_OnSerializingMethods; // 0x10
	private List<MethodInfo> m_OnSerializedMethods; // 0x18
	private List<MethodInfo> m_OnDeserializingMethods; // 0x20
	private List<MethodInfo> m_OnDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x3618500 Offset: 0x3618601 VA: 0x3618500
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x3618720 Offset: 0x3618821 VA: 0x3618720
	internal void .ctor(Type t) { }

	// RVA: 0x36188A0 Offset: 0x36189A1 VA: 0x36188A0
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x36188C0 Offset: 0x36189C1 VA: 0x36188C0
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x3618B30 Offset: 0x3618C31 VA: 0x3618B30
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x3611830 Offset: 0x3611931 VA: 0x3611830
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x3618DA0 Offset: 0x3618EA1 VA: 0x3618DA0
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x3618FF0 Offset: 0x36190F1 VA: 0x3618FF0
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }
}

