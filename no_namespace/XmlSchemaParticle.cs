// Namespace: 
[FlagsAttribute] // RVA: 0x47300 Offset: 0x47401 VA: 0x47300
private enum XmlSchemaParticle.Occurs // TypeDefIndex: 2025
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaParticle.Occurs None = 0;
	public const XmlSchemaParticle.Occurs Min = 1;
	public const XmlSchemaParticle.Occurs Max = 2;
}

// Namespace: 
private class XmlSchemaParticle.EmptyParticle : XmlSchemaParticle // TypeDefIndex: 2026
{
	// Properties
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x19A9080 Offset: 0x19A9181 VA: 0x19A9080 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x19A9090 Offset: 0x19A9191 VA: 0x19A9090
	public void .ctor() { }
}

