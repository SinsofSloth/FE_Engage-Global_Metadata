// Namespace: System.Xml.Schema
internal class CompiledIdentityConstraint // TypeDefIndex: 1801
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x1A28640 Offset: 0x1A28741 VA: 0x1A28640
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x1A28650 Offset: 0x1A28751 VA: 0x1A28650
	public Asttree get_Selector() { }

	// RVA: 0x1A28660 Offset: 0x1A28761 VA: 0x1A28660
	public Asttree[] get_Fields() { }

	// RVA: 0x1A28670 Offset: 0x1A28771 VA: 0x1A28670
	private void .ctor() { }

	// RVA: 0x1A28710 Offset: 0x1A28811 VA: 0x1A28710
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1A28C50 Offset: 0x1A28D51 VA: 0x1A28C50
	private static void .cctor() { }
}

