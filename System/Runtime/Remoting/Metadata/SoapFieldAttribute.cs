// Namespace: System.Runtime.Remoting.Metadata
[ComVisibleAttribute] // RVA: 0x474FA0 Offset: 0x4750A1 VA: 0x474FA0
[AttributeUsageAttribute] // RVA: 0x474FA0 Offset: 0x4750A1 VA: 0x474FA0
public sealed class SoapFieldAttribute : SoapAttribute // TypeDefIndex: 1173
{
	// Fields
	private string _elementName; // 0x28
	private bool _isElement; // 0x30

	// Properties
	public string XmlElementName { get; }

	// Methods

	// RVA: 0x38291F0 Offset: 0x38292F1 VA: 0x38291F0
	public void .ctor() { }

	// RVA: 0x3829200 Offset: 0x3829301 VA: 0x3829200
	public string get_XmlElementName() { }

	// RVA: 0x3829210 Offset: 0x3829311 VA: 0x3829210
	public bool IsInteropXmlElement() { }

	// RVA: 0x3829220 Offset: 0x3829321 VA: 0x3829220 Slot: 6
	internal override void SetReflectionObject(object reflectionObject) { }
}

