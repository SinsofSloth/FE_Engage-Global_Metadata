// Namespace: System.Xml.Schema
public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 1978
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x94
	private XmlSchemaContentModel contentModel; // 0x98
	private XmlSchemaParticle particle; // 0xA0
	private XmlSchemaObjectCollection attributes; // 0xA8
	private XmlSchemaAnyAttribute anyAttribute; // 0xB0
	private XmlSchemaParticle contentTypeParticle; // 0xB8
	private XmlSchemaDerivationMethod blockResolved; // 0xC0
	private XmlSchemaObjectTable localElements; // 0xC8
	private XmlSchemaObjectTable attributeUses; // 0xD0
	private XmlSchemaAnyAttribute attributeWildcard; // 0xD8
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE0

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x49500 Offset: 0x49601 VA: 0x49500
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnoreAttribute] // RVA: 0x49510 Offset: 0x49611 VA: 0x49510
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[DefaultValueAttribute] // RVA: 0x49520 Offset: 0x49621 VA: 0x49520
	[XmlAttributeAttribute] // RVA: 0x49520 Offset: 0x49621 VA: 0x49520
	public bool IsAbstract { get; set; }
	[XmlAttributeAttribute] // RVA: 0x49570 Offset: 0x49671 VA: 0x49570
	[DefaultValueAttribute] // RVA: 0x49570 Offset: 0x49671 VA: 0x49570
	public XmlSchemaDerivationMethod Block { get; set; }
	[DefaultValueAttribute] // RVA: 0x49610 Offset: 0x49711 VA: 0x49610
	[XmlAttributeAttribute] // RVA: 0x49610 Offset: 0x49711 VA: 0x49610
	public override bool IsMixed { get; set; }
	[XmlElementAttribute] // RVA: 0x49660 Offset: 0x49761 VA: 0x49660
	[XmlElementAttribute] // RVA: 0x49660 Offset: 0x49761 VA: 0x49660
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElementAttribute] // RVA: 0x49730 Offset: 0x49831 VA: 0x49730
	[XmlElementAttribute] // RVA: 0x49730 Offset: 0x49831 VA: 0x49730
	[XmlElementAttribute] // RVA: 0x49730 Offset: 0x49831 VA: 0x49730
	[XmlElementAttribute] // RVA: 0x49730 Offset: 0x49831 VA: 0x49730
	public XmlSchemaParticle Particle { get; set; }
	[XmlElementAttribute] // RVA: 0x498A0 Offset: 0x499A1 VA: 0x498A0
	[XmlElementAttribute] // RVA: 0x498A0 Offset: 0x499A1 VA: 0x498A0
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElementAttribute] // RVA: 0x49970 Offset: 0x49A71 VA: 0x49970
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x499B0 Offset: 0x49AB1 VA: 0x499B0
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnoreAttribute] // RVA: 0x499C0 Offset: 0x49AC1 VA: 0x499C0
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnoreAttribute] // RVA: 0x499D0 Offset: 0x49AD1 VA: 0x499D0
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnoreAttribute] // RVA: 0x499E0 Offset: 0x49AE1 VA: 0x499E0
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnoreAttribute] // RVA: 0x499F0 Offset: 0x49AF1 VA: 0x499F0
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnoreAttribute] // RVA: 0x49A00 Offset: 0x49B01 VA: 0x49A00
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x1960FA0 Offset: 0x19610A1 VA: 0x1960FA0
	private static void .cctor() { }

	// RVA: 0x1961200 Offset: 0x1961301 VA: 0x1961200
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x19616D0 Offset: 0x19617D1 VA: 0x19616D0
	public void .ctor() { }

	// RVA: 0x1961D90 Offset: 0x1961E91 VA: 0x1961D90
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x1961E00 Offset: 0x1961F01 VA: 0x1961E00
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x1961860 Offset: 0x1961961 VA: 0x1961860
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x1961E70 Offset: 0x1961F71 VA: 0x1961E70
	public bool get_IsAbstract() { }

	// RVA: 0x1961E80 Offset: 0x1961F81 VA: 0x1961E80
	public void set_IsAbstract(bool value) { }

	// RVA: 0x1961EA0 Offset: 0x1961FA1 VA: 0x1961EA0
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1961EB0 Offset: 0x1961FB1 VA: 0x1961EB0
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1961EC0 Offset: 0x1961FC1 VA: 0x1961EC0 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x1961ED0 Offset: 0x1961FD1 VA: 0x1961ED0 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x1961EF0 Offset: 0x1961FF1 VA: 0x1961EF0
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x1961F00 Offset: 0x1962001 VA: 0x1961F00
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x1961F10 Offset: 0x1962011 VA: 0x1961F10
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x1961F20 Offset: 0x1962021 VA: 0x1961F20
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1961F30 Offset: 0x1962031 VA: 0x1961F30
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1961FC0 Offset: 0x19620C1 VA: 0x1961FC0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1961FD0 Offset: 0x19620D1 VA: 0x1961FD0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1961FE0 Offset: 0x19620E1 VA: 0x1961FE0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1961FF0 Offset: 0x19620F1 VA: 0x1961FF0
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x1962000 Offset: 0x1962101 VA: 0x1962000
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1962010 Offset: 0x1962111 VA: 0x1962010
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x19620A0 Offset: 0x19621A1 VA: 0x19620A0
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x19620B0 Offset: 0x19621B1 VA: 0x19620B0
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x1962140 Offset: 0x1962241 VA: 0x1962140
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x1962150 Offset: 0x1962251 VA: 0x1962150
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1962160 Offset: 0x1962261 VA: 0x1962160
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1962170 Offset: 0x1962271 VA: 0x1962170
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x1962190 Offset: 0x1962291 VA: 0x1962190
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x19621A0 Offset: 0x19622A1 VA: 0x19621A0
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x1962780 Offset: 0x1962881 VA: 0x1962780 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1962790 Offset: 0x1962891 VA: 0x1962790
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x19635D0 Offset: 0x19636D1 VA: 0x19635D0
	private void ClearCompiledState() { }

	// RVA: 0x195F690 Offset: 0x195F791 VA: 0x195F690
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1963720 Offset: 0x1963821 VA: 0x1963720
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x1963320 Offset: 0x1963421 VA: 0x1963320
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1963980 Offset: 0x1963A81 VA: 0x1963980
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x1963090 Offset: 0x1963191 VA: 0x1963090
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x195F540 Offset: 0x195F641 VA: 0x195F540
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }
}

