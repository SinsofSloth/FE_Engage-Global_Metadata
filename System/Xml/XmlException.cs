// Namespace: System.Xml
[Serializable]
public class XmlException : SystemException // TypeDefIndex: 1759
{
	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private int lineNumber; // 0x98
	private int linePosition; // 0x9C
	[OptionalFieldAttribute] // RVA: 0x473F0 Offset: 0x474F1 VA: 0x473F0
	private string sourceUri; // 0xA0
	private string message; // 0xA8

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x32EBE90 Offset: 0x32EBF91 VA: 0x32EBE90
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x32EC570 Offset: 0x32EC671 VA: 0x32EC570 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x32EC6F0 Offset: 0x32EC7F1 VA: 0x32EC6F0
	public void .ctor() { }

	// RVA: 0x32EC710 Offset: 0x32EC811 VA: 0x32EC710
	public void .ctor(string message) { }

	// RVA: 0x32EC730 Offset: 0x32EC831 VA: 0x32EC730
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x32EC740 Offset: 0x32EC841 VA: 0x32EC740
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x32EC9C0 Offset: 0x32ECAC1 VA: 0x32EC9C0
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x32ECB20 Offset: 0x32ECC21 VA: 0x32ECB20
	internal void .ctor(string res, string arg) { }

	// RVA: 0x32ECC40 Offset: 0x32ECD41 VA: 0x32ECC40
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x32ECD60 Offset: 0x32ECE61 VA: 0x32ECD60
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x32ECE30 Offset: 0x32ECF31 VA: 0x32ECE30
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x32ECFD0 Offset: 0x32ED0D1 VA: 0x32ECFD0
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x32ED100 Offset: 0x32ED201 VA: 0x32ED100
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x32ED230 Offset: 0x32ED331 VA: 0x32ED230
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x32ED2E0 Offset: 0x32ED3E1 VA: 0x32ED2E0
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x32ED390 Offset: 0x32ED491 VA: 0x32ED390
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x32ECA60 Offset: 0x32ECB61 VA: 0x32ECA60
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x32EC8B0 Offset: 0x32EC9B1 VA: 0x32EC8B0
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x32EC2A0 Offset: 0x32EC3A1 VA: 0x32EC2A0
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x32ED440 Offset: 0x32ED541 VA: 0x32ED440
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x32ED7A0 Offset: 0x32ED8A1 VA: 0x32ED7A0
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x32ED4A0 Offset: 0x32ED5A1 VA: 0x32ED4A0
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0x32ED800 Offset: 0x32ED901 VA: 0x32ED800
	public int get_LineNumber() { }

	// RVA: 0x32ED810 Offset: 0x32ED911 VA: 0x32ED810
	public int get_LinePosition() { }

	// RVA: 0x32ED820 Offset: 0x32ED921 VA: 0x32ED820 Slot: 5
	public override string get_Message() { }

	// RVA: 0x32ED840 Offset: 0x32ED941 VA: 0x32ED840
	internal string get_ResString() { }
}

