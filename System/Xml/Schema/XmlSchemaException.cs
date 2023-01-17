// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaException : SystemException // TypeDefIndex: 1987
{
	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private string sourceUri; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	private XmlSchemaObject sourceSchemaObject; // 0xA8
	private string message; // 0xB0

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1965610 Offset: 0x1965711 VA: 0x1965610
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1965AA0 Offset: 0x1965BA1 VA: 0x1965AA0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1965C20 Offset: 0x1965D21 VA: 0x1965C20
	public void .ctor() { }

	// RVA: 0x1965C40 Offset: 0x1965D41 VA: 0x1965C40
	public void .ctor(string message) { }

	// RVA: 0x1965DC0 Offset: 0x1965EC1 VA: 0x1965DC0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1965C50 Offset: 0x1965D51 VA: 0x1965C50
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1965E90 Offset: 0x1965F91 VA: 0x1965E90
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1965F30 Offset: 0x1966031 VA: 0x1965F30
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1966050 Offset: 0x1966151 VA: 0x1966050
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1966190 Offset: 0x1966291 VA: 0x1966190
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1966240 Offset: 0x1966341 VA: 0x1966240
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x19662F0 Offset: 0x19663F1 VA: 0x19662F0
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1966460 Offset: 0x1966561 VA: 0x1966460
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x19663A0 Offset: 0x19664A1 VA: 0x19663A0
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x1965DD0 Offset: 0x1965ED1 VA: 0x1965DD0
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x19659D0 Offset: 0x1965AD1 VA: 0x19659D0
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x19665A0 Offset: 0x19666A1 VA: 0x19665A0
	internal string get_GetRes() { }

	// RVA: 0x19665B0 Offset: 0x19666B1 VA: 0x19665B0
	internal string[] get_Args() { }

	// RVA: 0x19665C0 Offset: 0x19666C1 VA: 0x19665C0
	public string get_SourceUri() { }

	// RVA: 0x19665D0 Offset: 0x19666D1 VA: 0x19665D0
	public int get_LineNumber() { }

	// RVA: 0x19665E0 Offset: 0x19666E1 VA: 0x19665E0
	public int get_LinePosition() { }

	// RVA: 0x19665F0 Offset: 0x19666F1 VA: 0x19665F0
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x1966600 Offset: 0x1966701 VA: 0x1966600
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1966640 Offset: 0x1966741 VA: 0x1966640
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1966650 Offset: 0x1966751 VA: 0x1966650
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x19666A0 Offset: 0x19667A1 VA: 0x19666A0 Slot: 5
	public override string get_Message() { }
}

