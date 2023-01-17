// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 1653
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x1A938A0 Offset: 0x1A939A1 VA: 0x1A938A0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1A941D0 Offset: 0x1A942D1 VA: 0x1A941D0 Slot: 39
	public virtual int get_LineNumber() { }

	// RVA: 0x1A94280 Offset: 0x1A94381 VA: 0x1A94280 Slot: 40
	public virtual int get_LinePosition() { }
}

