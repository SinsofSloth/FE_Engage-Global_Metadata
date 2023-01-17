// Namespace: System.Runtime.Remoting
internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 1100
{
	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0x33AACA0 Offset: 0x33AADA1 VA: 0x33AACA0
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0x33AAD80 Offset: 0x33AAE81 VA: 0x33AAD80
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0x33AAE70 Offset: 0x33AAF71 VA: 0x33AAE70
	private bool CheckPath(string path) { }

	// RVA: 0x33AAF50 Offset: 0x33AB051 VA: 0x33AAF50 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x33AAF60 Offset: 0x33AB061 VA: 0x33AAF60 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x33AAF70 Offset: 0x33AB071 VA: 0x33AAF70 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x33AAF80 Offset: 0x33AB081 VA: 0x33AAF80 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33AB140 Offset: 0x33AB241 VA: 0x33AB140
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33ADDB0 Offset: 0x33ADEB1 VA: 0x33ADDB0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x33AC2C0 Offset: 0x33AC3C1 VA: 0x33AC2C0
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33AC610 Offset: 0x33AC711 VA: 0x33AC610
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33ADE50 Offset: 0x33ADF51 VA: 0x33ADE50
	private TimeSpan ParseTime(string s) { }

	// RVA: 0x33ACBE0 Offset: 0x33ACCE1 VA: 0x33ACBE0
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x33ACFD0 Offset: 0x33AD0D1 VA: 0x33ACFD0
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x33AD6F0 Offset: 0x33AD7F1 VA: 0x33AD6F0
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33AD830 Offset: 0x33AD931 VA: 0x33AD830
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33AD400 Offset: 0x33AD501 VA: 0x33AD400
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33AD500 Offset: 0x33AD601 VA: 0x33AD500
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33AD900 Offset: 0x33ADA01 VA: 0x33AD900
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0x33ADB10 Offset: 0x33ADC11 VA: 0x33ADB10
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x33AE2B0 Offset: 0x33AE3B1 VA: 0x33AE2B0
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0x33AE3F0 Offset: 0x33AE4F1 VA: 0x33AE3F0
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x33AE4C0 Offset: 0x33AE5C1 VA: 0x33AE4C0 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x33AE4D0 Offset: 0x33AE5D1 VA: 0x33AE4D0 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

