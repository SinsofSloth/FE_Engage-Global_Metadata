// Namespace: 
private enum XmlValidatingReaderImpl.ParsingFunction // TypeDefIndex: 1676
{
	// Fields
	public int value__; // 0x0
	public const XmlValidatingReaderImpl.ParsingFunction Read = 0;
	public const XmlValidatingReaderImpl.ParsingFunction Init = 1;
	public const XmlValidatingReaderImpl.ParsingFunction ParseDtdFromContext = 2;
	public const XmlValidatingReaderImpl.ParsingFunction ResolveEntityInternally = 3;
	public const XmlValidatingReaderImpl.ParsingFunction InReadBinaryContent = 4;
	public const XmlValidatingReaderImpl.ParsingFunction ReaderClosed = 5;
	public const XmlValidatingReaderImpl.ParsingFunction Error = 6;
	public const XmlValidatingReaderImpl.ParsingFunction None = 7;
}

// Namespace: 
internal class XmlValidatingReaderImpl.ValidationEventHandling : IValidationEventHandling // TypeDefIndex: 1677
{
	// Fields
	private XmlValidatingReaderImpl reader; // 0x10
	private ValidationEventHandler eventHandler; // 0x18

	// Properties
	private object System.Xml.IValidationEventHandling.EventHandler { get; }

	// Methods

	// RVA: 0x19AABE0 Offset: 0x19AACE1 VA: 0x19AABE0
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x19AAC20 Offset: 0x19AAD21 VA: 0x19AAC20 Slot: 4
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x19AAC30 Offset: 0x19AAD31 VA: 0x19AAC30 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x19AAD50 Offset: 0x19AAE51 VA: 0x19AAD50
	internal void AddHandler(ValidationEventHandler handler) { }
}

