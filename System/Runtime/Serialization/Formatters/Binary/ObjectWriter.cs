// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectWriter // TypeDefIndex: 1077
{
	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x380D530 Offset: 0x380D631 VA: 0x380D530
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x380D680 Offset: 0x380D781 VA: 0x380D680
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x380E5F0 Offset: 0x380E6F1 VA: 0x380E5F0
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x380E010 Offset: 0x380E111 VA: 0x380E010
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x380EE70 Offset: 0x380EF71 VA: 0x380EE70
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x380F1E0 Offset: 0x380F2E1 VA: 0x380F1E0
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x380F3B0 Offset: 0x380F4B1 VA: 0x380F3B0
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x380E600 Offset: 0x380E701 VA: 0x380E600
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x380FD10 Offset: 0x380FE11 VA: 0x380FD10
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x380FFE0 Offset: 0x38100E1 VA: 0x380FFE0
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x380E480 Offset: 0x380E581 VA: 0x380E480
	private object GetNext(out long objID) { }

	// RVA: 0x380DB70 Offset: 0x380DC71 VA: 0x380DB70
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x38102F0 Offset: 0x38103F1 VA: 0x38102F0
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x380FAE0 Offset: 0x380FBE1 VA: 0x380FAE0
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x380FC10 Offset: 0x380FD11 VA: 0x380FC10
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x380FC00 Offset: 0x380FD01 VA: 0x380FC00
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x3810300 Offset: 0x3810401 VA: 0x3810300
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x380F810 Offset: 0x380F911 VA: 0x380F810
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x380DB50 Offset: 0x380DC51 VA: 0x380DB50
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x3810460 Offset: 0x3810561 VA: 0x3810460
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x380F2E0 Offset: 0x380F3E1 VA: 0x380F2E0
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x380DED0 Offset: 0x380DFD1 VA: 0x380DED0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x380F9C0 Offset: 0x380FAC1 VA: 0x380F9C0
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x380F8D0 Offset: 0x380F9D1 VA: 0x380F8D0
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x380F1A0 Offset: 0x380F2A1 VA: 0x380F1A0
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x380EDC0 Offset: 0x380EEC1 VA: 0x380EDC0
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x380DC50 Offset: 0x380DD51 VA: 0x380DC50
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x380EDB0 Offset: 0x380EEB1 VA: 0x380EDB0
	private Type GetType(object obj) { }

	// RVA: 0x3810500 Offset: 0x3810601 VA: 0x3810500
	private NameInfo GetNameInfo() { }

	// RVA: 0x380EDA0 Offset: 0x380EEA1 VA: 0x380EDA0
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x380E470 Offset: 0x380E571 VA: 0x380E470
	private void PutNameInfo(NameInfo nameInfo) { }
}

