// Namespace: System
[Serializable]
internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 335
{
	// Fields
	private Type[] m_instantiation; // 0x10
	private int[] m_elementTypes; // 0x18
	private int m_genericParameterPosition; // 0x20
	private Type m_declaringType; // 0x28
	private MethodBase m_declaringMethod; // 0x30
	private string m_data; // 0x38
	private string m_assemblyName; // 0x40
	private int m_unityType; // 0x48

	// Methods

	// RVA: 0x34C89B0 Offset: 0x34C8AB1 VA: 0x34C89B0
	internal static void GetUnitySerializationInfo(SerializationInfo info, Missing missing) { }

	// RVA: 0x34C8A70 Offset: 0x34C8B71 VA: 0x34C8A70
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x34C8CD0 Offset: 0x34C8DD1 VA: 0x34C8CD0
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x34C8DE0 Offset: 0x34C8EE1 VA: 0x34C8DE0
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x34C9150 Offset: 0x34C9251 VA: 0x34C9150
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x34C92F0 Offset: 0x34C93F1 VA: 0x34C92F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34C9720 Offset: 0x34C9821 VA: 0x34C9720
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x34C97C0 Offset: 0x34C98C1 VA: 0x34C97C0 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34C9820 Offset: 0x34C9921 VA: 0x34C9820 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}

