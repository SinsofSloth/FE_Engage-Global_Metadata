// Namespace: System.Runtime.Serialization.Formatters.Binary
[ComVisibleAttribute] // RVA: 0x4748B0 Offset: 0x4749B1 VA: 0x4748B0
public sealed class BinaryFormatter // TypeDefIndex: 1066
{
	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0x3504B20 Offset: 0x3504C21 VA: 0x3504B20
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x3504B30 Offset: 0x3504C31 VA: 0x3504B30 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x3504B40 Offset: 0x3504C41 VA: 0x3504B40
	public void .ctor() { }

	// RVA: 0x3504BC0 Offset: 0x3504CC1 VA: 0x3504BC0
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x3504C30 Offset: 0x3504D31 VA: 0x3504C30 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x3504C50 Offset: 0x3504D51 VA: 0x3504C50
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x3504C40 Offset: 0x3504D41 VA: 0x3504C40 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x3504E90 Offset: 0x3504F91 VA: 0x3504E90 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x3504EA0 Offset: 0x3504FA1 VA: 0x3504EA0 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x3504EB0 Offset: 0x3504FB1 VA: 0x3504EB0
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x35050A0 Offset: 0x35051A1 VA: 0x35050A0
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x3505320 Offset: 0x3505421 VA: 0x3505320
	private static void .cctor() { }
}

