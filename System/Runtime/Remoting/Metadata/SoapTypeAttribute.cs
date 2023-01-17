// Namespace: System.Runtime.Remoting.Metadata
[ComVisibleAttribute] // RVA: 0x475060 Offset: 0x475161 VA: 0x475060
[AttributeUsageAttribute] // RVA: 0x475060 Offset: 0x475161 VA: 0x475060
public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 1176
{
	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0x382AEC0 Offset: 0x382AFC1 VA: 0x382AEC0
	public void .ctor() { }

	// RVA: 0x382AED0 Offset: 0x382AFD1 VA: 0x382AED0 Slot: 4
	public override bool get_UseAttribute() { }

	// RVA: 0x382AEE0 Offset: 0x382AFE1 VA: 0x382AEE0
	public string get_XmlElementName() { }

	// RVA: 0x382AEF0 Offset: 0x382AFF1 VA: 0x382AEF0 Slot: 5
	public override string get_XmlNamespace() { }

	// RVA: 0x382AF00 Offset: 0x382B001 VA: 0x382AF00
	public string get_XmlTypeName() { }

	// RVA: 0x382AF10 Offset: 0x382B011 VA: 0x382AF10
	public string get_XmlTypeNamespace() { }

	// RVA: 0x382AF20 Offset: 0x382B021 VA: 0x382AF20
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x382AF30 Offset: 0x382B031 VA: 0x382AF30
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x382AF40 Offset: 0x382B041 VA: 0x382AF40 Slot: 6
	internal override void SetReflectionObject(object reflectionObject) { }
}

