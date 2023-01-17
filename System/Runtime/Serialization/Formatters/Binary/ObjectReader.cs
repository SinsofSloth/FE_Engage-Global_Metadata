// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectReader // TypeDefIndex: 1076
{
	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x3869AD0 Offset: 0x3869BD1 VA: 0x3869AD0
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x3869B70 Offset: 0x3869C71 VA: 0x3869B70
	internal object get_TopObject() { }

	// RVA: 0x3869B80 Offset: 0x3869C81 VA: 0x3869B80
	internal void set_TopObject(object value) { }

	// RVA: 0x3869BD0 Offset: 0x3869CD1 VA: 0x3869BD0
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x3869D30 Offset: 0x3869E31 VA: 0x3869D30
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x386A1F0 Offset: 0x386A2F1 VA: 0x386A1F0
	private bool HasSurrogate(Type t) { }

	// RVA: 0x386A2D0 Offset: 0x386A3D1 VA: 0x386A2D0
	private void CheckSerializable(Type t) { }

	// RVA: 0x386A4B0 Offset: 0x386A5B1 VA: 0x386A4B0
	private void InitFullDeserialization() { }

	// RVA: 0x386A650 Offset: 0x386A751 VA: 0x386A650
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x3868CF0 Offset: 0x3868DF1 VA: 0x3868CF0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x38692A0 Offset: 0x38693A1 VA: 0x38692A0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x386A690 Offset: 0x386A791 VA: 0x386A690
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x386B6F0 Offset: 0x386B7F1 VA: 0x386B6F0
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x386A7C0 Offset: 0x386A8C1 VA: 0x386A7C0
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x386A7D0 Offset: 0x386A8D1 VA: 0x386A7D0
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x386A7E0 Offset: 0x386A8E1 VA: 0x386A7E0
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x386AC90 Offset: 0x386AD91 VA: 0x386AC90
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x386B900 Offset: 0x386BA01 VA: 0x386B900
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x386C280 Offset: 0x386C381 VA: 0x386C280
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x386C350 Offset: 0x386C451 VA: 0x386C350
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x386CBC0 Offset: 0x386CCC1 VA: 0x386CBC0
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x386B0D0 Offset: 0x386B1D1 VA: 0x386B0D0
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x386B640 Offset: 0x386B741 VA: 0x386B640
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x386CB90 Offset: 0x386CC91 VA: 0x386CB90
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x386C1A0 Offset: 0x386C2A1 VA: 0x386C1A0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x386CBE0 Offset: 0x386CCE1 VA: 0x386CBE0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x386CD30 Offset: 0x386CE31 VA: 0x386CD30
	internal long GetId(long objectId) { }

	// RVA: 0x386CE50 Offset: 0x386CF51 VA: 0x386CE50
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x386CEC0 Offset: 0x386CFC1 VA: 0x386CEC0
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x386D1C0 Offset: 0x386D2C1 VA: 0x386D1C0
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x386D230 Offset: 0x386D331 VA: 0x386D230
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x3869090 Offset: 0x3869191 VA: 0x3869090
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x386D4E0 Offset: 0x386D5E1 VA: 0x386D4E0
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }
}

