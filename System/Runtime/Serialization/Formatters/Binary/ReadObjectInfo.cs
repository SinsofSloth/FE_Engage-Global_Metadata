// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ReadObjectInfo // TypeDefIndex: 1070
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x3B6FFA0 Offset: 0x3B700A1 VA: 0x3B6FFA0
	internal void .ctor() { }

	// RVA: 0x3B6FFB0 Offset: 0x3B700B1 VA: 0x3B6FFB0
	internal void ObjectEnd() { }

	// RVA: 0x3B6FFC0 Offset: 0x3B700C1 VA: 0x3B6FFC0
	internal void PrepareForReuse() { }

	// RVA: 0x3B6FFD0 Offset: 0x3B700D1 VA: 0x3B6FFD0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x3B70170 Offset: 0x3B70271 VA: 0x3B70170
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x3B704B0 Offset: 0x3B705B1 VA: 0x3B704B0
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x3B705A0 Offset: 0x3B706A1 VA: 0x3B705A0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x3B70240 Offset: 0x3B70341 VA: 0x3B70240
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x3B70750 Offset: 0x3B70851 VA: 0x3B70750
	private void InitSiRead() { }

	// RVA: 0x3B706D0 Offset: 0x3B707D1 VA: 0x3B706D0
	private void InitNoMembers() { }

	// RVA: 0x3B707F0 Offset: 0x3B708F1 VA: 0x3B707F0
	private void InitMemberInfo() { }

	// RVA: 0x3B70BC0 Offset: 0x3B70CC1 VA: 0x3B70BC0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x3B70EA0 Offset: 0x3B70FA1 VA: 0x3B70EA0
	internal Type GetType(string name) { }

	// RVA: 0x3B71020 Offset: 0x3B71121 VA: 0x3B71020
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x3B710E0 Offset: 0x3B711E1 VA: 0x3B710E0
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x3B711E0 Offset: 0x3B712E1 VA: 0x3B711E0
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x3B71290 Offset: 0x3B71391 VA: 0x3B71290
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x3B70D80 Offset: 0x3B70E81 VA: 0x3B70D80
	private int Position(string name) { }

	// RVA: 0x3B71330 Offset: 0x3B71431 VA: 0x3B71330
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x3B70A50 Offset: 0x3B70B51 VA: 0x3B70A50
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x3B70100 Offset: 0x3B70201 VA: 0x3B70100
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

