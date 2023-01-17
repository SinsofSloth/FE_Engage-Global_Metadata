// Namespace: System.Runtime.Remoting.Metadata
[AttributeUsageAttribute] // RVA: 0x474FE0 Offset: 0x4750E1 VA: 0x474FE0
[ComVisibleAttribute] // RVA: 0x474FE0 Offset: 0x4750E1 VA: 0x474FE0
public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 1174
{
	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x38292E0 Offset: 0x38293E1 VA: 0x38292E0
	public void .ctor() { }

	// RVA: 0x38292F0 Offset: 0x38293F1 VA: 0x38292F0 Slot: 4
	public override bool get_UseAttribute() { }

	// RVA: 0x3829300 Offset: 0x3829401 VA: 0x3829300 Slot: 5
	public override string get_XmlNamespace() { }

	// RVA: 0x3829310 Offset: 0x3829411 VA: 0x3829310 Slot: 6
	internal override void SetReflectionObject(object reflectionObject) { }
}

