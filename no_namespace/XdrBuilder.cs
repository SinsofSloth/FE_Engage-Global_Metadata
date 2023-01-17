// Namespace: 
private sealed class XdrBuilder.XdrAttributeEntry // TypeDefIndex: 1953
{
	// Fields
	internal SchemaNames.Token _Attribute; // 0x10
	internal int _SchemaFlags; // 0x14
	internal XmlSchemaDatatype _Datatype; // 0x18
	internal XdrBuilder.XdrBuildFunction _BuildFunc; // 0x20

	// Methods

	// RVA: 0x19A5EA0 Offset: 0x19A5FA1 VA: 0x19A5EA0
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	// RVA: 0x19A5F10 Offset: 0x19A6011 VA: 0x19A5F10
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build) { }
}

