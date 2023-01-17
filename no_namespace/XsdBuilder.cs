// Namespace: 
private enum XsdBuilder.State // TypeDefIndex: 2065
{
	// Fields
	public int value__; // 0x0
	public const XsdBuilder.State Root = 0;
	public const XsdBuilder.State Schema = 1;
	public const XsdBuilder.State Annotation = 2;
	public const XsdBuilder.State Include = 3;
	public const XsdBuilder.State Import = 4;
	public const XsdBuilder.State Element = 5;
	public const XsdBuilder.State Attribute = 6;
	public const XsdBuilder.State AttributeGroup = 7;
	public const XsdBuilder.State AttributeGroupRef = 8;
	public const XsdBuilder.State AnyAttribute = 9;
	public const XsdBuilder.State Group = 10;
	public const XsdBuilder.State GroupRef = 11;
	public const XsdBuilder.State All = 12;
	public const XsdBuilder.State Choice = 13;
	public const XsdBuilder.State Sequence = 14;
	public const XsdBuilder.State Any = 15;
	public const XsdBuilder.State Notation = 16;
	public const XsdBuilder.State SimpleType = 17;
	public const XsdBuilder.State ComplexType = 18;
	public const XsdBuilder.State ComplexContent = 19;
	public const XsdBuilder.State ComplexContentRestriction = 20;
	public const XsdBuilder.State ComplexContentExtension = 21;
	public const XsdBuilder.State SimpleContent = 22;
	public const XsdBuilder.State SimpleContentExtension = 23;
	public const XsdBuilder.State SimpleContentRestriction = 24;
	public const XsdBuilder.State SimpleTypeUnion = 25;
	public const XsdBuilder.State SimpleTypeList = 26;
	public const XsdBuilder.State SimpleTypeRestriction = 27;
	public const XsdBuilder.State Unique = 28;
	public const XsdBuilder.State Key = 29;
	public const XsdBuilder.State KeyRef = 30;
	public const XsdBuilder.State Selector = 31;
	public const XsdBuilder.State Field = 32;
	public const XsdBuilder.State MinExclusive = 33;
	public const XsdBuilder.State MinInclusive = 34;
	public const XsdBuilder.State MaxExclusive = 35;
	public const XsdBuilder.State MaxInclusive = 36;
	public const XsdBuilder.State TotalDigits = 37;
	public const XsdBuilder.State FractionDigits = 38;
	public const XsdBuilder.State Length = 39;
	public const XsdBuilder.State MinLength = 40;
	public const XsdBuilder.State MaxLength = 41;
	public const XsdBuilder.State Enumeration = 42;
	public const XsdBuilder.State Pattern = 43;
	public const XsdBuilder.State WhiteSpace = 44;
	public const XsdBuilder.State AppInfo = 45;
	public const XsdBuilder.State Documentation = 46;
	public const XsdBuilder.State Redefine = 47;
}

// Namespace: 
private sealed class XsdBuilder.XsdBuildFunction : MulticastDelegate // TypeDefIndex: 2066
{
	// Methods

	// RVA: 0x19AAEE0 Offset: 0x19AAFE1 VA: 0x19AAEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19AAF00 Offset: 0x19AB001 VA: 0x19AAF00 Slot: 13
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0x19AB270 Offset: 0x19AB371 VA: 0x19AB270 Slot: 14
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x19AB2A0 Offset: 0x19AB3A1 VA: 0x19AB2A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 2067
{
	// Methods

	// RVA: 0x19AB720 Offset: 0x19AB821 VA: 0x19AB720
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19AB740 Offset: 0x19AB841 VA: 0x19AB740 Slot: 13
	public virtual void Invoke(XsdBuilder builder, string value) { }

	// RVA: 0x19ABAB0 Offset: 0x19ABBB1 VA: 0x19ABAB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, string value, AsyncCallback callback, object object) { }

	// RVA: 0x19ABAE0 Offset: 0x19ABBE1 VA: 0x19ABAE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdEndChildFunction : MulticastDelegate // TypeDefIndex: 2068
{
	// Methods

	// RVA: 0x19AB2B0 Offset: 0x19AB3B1 VA: 0x19AB2B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19AB2D0 Offset: 0x19AB3D1 VA: 0x19AB2D0 Slot: 13
	public virtual void Invoke(XsdBuilder builder) { }

	// RVA: 0x19AB630 Offset: 0x19AB731 VA: 0x19AB630 Slot: 14
	public virtual IAsyncResult BeginInvoke(XsdBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x19AB660 Offset: 0x19AB761 VA: 0x19AB660 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdAttributeEntry // TypeDefIndex: 2069
{
	// Fields
	public SchemaNames.Token Attribute; // 0x10
	public XsdBuilder.XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x19AAE90 Offset: 0x19AAF91 VA: 0x19AAE90
	public void .ctor(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdEntry // TypeDefIndex: 2070
{
	// Fields
	public SchemaNames.Token Name; // 0x10
	public XsdBuilder.State CurrentState; // 0x14
	public XsdBuilder.State[] NextStates; // 0x18
	public XsdBuilder.XsdAttributeEntry[] Attributes; // 0x20
	public XsdBuilder.XsdInitFunction InitFunc; // 0x28
	public XsdBuilder.XsdEndChildFunction EndChildFunc; // 0x30
	public bool ParseContent; // 0x38

	// Methods

	// RVA: 0x19AB670 Offset: 0x19AB771 VA: 0x19AB670
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }
}

// Namespace: 
private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 2071
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x19AADE0 Offset: 0x19AAEE1 VA: 0x19AADE0
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x19AAE30 Offset: 0x19AAF31 VA: 0x19AAE30 Slot: 15
	public override string LookupNamespace(string prefix) { }
}

