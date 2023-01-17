// Namespace: System.Xml.Schema
[FlagsAttribute] // RVA: 0x47270 Offset: 0x47371 VA: 0x47270
public enum XmlSchemaDerivationMethod // TypeDefIndex: 1984
{
	// Fields
	public int value__; // 0x0
	[XmlEnumAttribute] // RVA: 0x474D0 Offset: 0x475D1 VA: 0x474D0
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnumAttribute] // RVA: 0x47510 Offset: 0x47611 VA: 0x47510
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnumAttribute] // RVA: 0x47550 Offset: 0x47651 VA: 0x47550
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnumAttribute] // RVA: 0x47590 Offset: 0x47691 VA: 0x47590
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnumAttribute] // RVA: 0x475D0 Offset: 0x476D1 VA: 0x475D0
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnumAttribute] // RVA: 0x47610 Offset: 0x47711 VA: 0x47610
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnumAttribute] // RVA: 0x47650 Offset: 0x47751 VA: 0x47650
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnoreAttribute] // RVA: 0x47690 Offset: 0x47791 VA: 0x47690
	public const XmlSchemaDerivationMethod None = 256;
}

