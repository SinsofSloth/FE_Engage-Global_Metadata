// Namespace: System.Reflection
[Serializable]
internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 534
{
	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x34E7F00 Offset: 0x34E8001 VA: 0x34E7F00
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x34E7F10 Offset: 0x34E8011 VA: 0x34E7F10
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x34E8210 Offset: 0x34E8311 VA: 0x34E8210
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34E8570 Offset: 0x34E8671 VA: 0x34E8570 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34E85D0 Offset: 0x34E86D1 VA: 0x34E85D0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}

