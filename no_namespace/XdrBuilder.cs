// Namespace: 
private sealed class XdrBuilder.DeclBaseInfo // TypeDefIndex: 1945
{
	// Fields
	internal XmlQualifiedName _Name; // 0x10
	internal string _Prefix; // 0x18
	internal XmlQualifiedName _TypeName; // 0x20
	internal string _TypePrefix; // 0x28
	internal object _Default; // 0x30
	internal object _Revises; // 0x38
	internal uint _MaxOccurs; // 0x40
	internal uint _MinOccurs; // 0x44
	internal bool _Checking; // 0x48
	internal SchemaElementDecl _ElementDecl; // 0x50
	internal SchemaAttDef _Attdef; // 0x58
	internal XdrBuilder.DeclBaseInfo _Next; // 0x60

	// Methods

	// RVA: 0x19A5CA0 Offset: 0x19A5DA1 VA: 0x19A5CA0
	internal void .ctor() { }

	// RVA: 0x19A5CD0 Offset: 0x19A5DD1 VA: 0x19A5CD0
	internal void Reset() { }
}

// Namespace: 
private sealed class XdrBuilder.GroupContent // TypeDefIndex: 1946
{
	// Fields
	internal uint _MinVal; // 0x10
	internal uint _MaxVal; // 0x14
	internal bool _HasMaxAttr; // 0x18
	internal bool _HasMinAttr; // 0x19
	internal int _Order; // 0x1C

	// Methods

	// RVA: 0x19A5DF0 Offset: 0x19A5EF1 VA: 0x19A5DF0
	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	// RVA: 0x19A5E10 Offset: 0x19A5F11 VA: 0x19A5E10
	internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other) { }

	// RVA: 0x19A5E90 Offset: 0x19A5F91 VA: 0x19A5E90
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.ElementContent // TypeDefIndex: 1947
{
	// Fields
	internal SchemaElementDecl _ElementDecl; // 0x10
	internal int _ContentAttr; // 0x18
	internal int _OrderAttr; // 0x1C
	internal bool _MasterGroupRequired; // 0x20
	internal bool _ExistTerminal; // 0x21
	internal bool _AllowDataType; // 0x22
	internal bool _HasDataType; // 0x23
	internal bool _HasType; // 0x24
	internal bool _EnumerationRequired; // 0x25
	internal uint _MinVal; // 0x28
	internal uint _MaxVal; // 0x2C
	internal uint _MaxLength; // 0x30
	internal uint _MinLength; // 0x34
	internal Hashtable _AttDefList; // 0x38

	// Methods

	// RVA: 0x19A5DE0 Offset: 0x19A5EE1 VA: 0x19A5DE0
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.AttributeContent // TypeDefIndex: 1948
{
	// Fields
	internal SchemaAttDef _AttDef; // 0x10
	internal XmlQualifiedName _Name; // 0x18
	internal string _Prefix; // 0x20
	internal bool _Required; // 0x28
	internal uint _MinVal; // 0x2C
	internal uint _MaxVal; // 0x30
	internal uint _MaxLength; // 0x34
	internal uint _MinLength; // 0x38
	internal bool _EnumerationRequired; // 0x3C
	internal bool _HasDataType; // 0x3D
	internal bool _Global; // 0x3E
	internal object _Default; // 0x40

	// Methods

	// RVA: 0x19A5C90 Offset: 0x19A5D91 VA: 0x19A5C90
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.XdrBuildFunction : MulticastDelegate // TypeDefIndex: 1949
{
	// Methods

	// RVA: 0x19A6350 Offset: 0x19A6451 VA: 0x19A6350
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19A6370 Offset: 0x19A6471 VA: 0x19A6370 Slot: 13
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19A6710 Offset: 0x19A6811 VA: 0x19A6710 Slot: 14
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, string prefix, AsyncCallback callback, object object) { }

	// RVA: 0x19A6740 Offset: 0x19A6841 VA: 0x19A6740 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 1950
{
	// Methods

	// RVA: 0x19A6BD0 Offset: 0x19A6CD1 VA: 0x19A6BD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19A6BF0 Offset: 0x19A6CF1 VA: 0x19A6BF0 Slot: 13
	public virtual void Invoke(XdrBuilder builder, object obj) { }

	// RVA: 0x19A6F60 Offset: 0x19A7061 VA: 0x19A6F60 Slot: 14
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, AsyncCallback callback, object object) { }

	// RVA: 0x19A6F90 Offset: 0x19A7091 VA: 0x19A6F90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 1951
{
	// Methods

	// RVA: 0x19A5F90 Offset: 0x19A6091 VA: 0x19A5F90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19A5FB0 Offset: 0x19A60B1 VA: 0x19A5FB0 Slot: 13
	public virtual void Invoke(XdrBuilder builder) { }

	// RVA: 0x19A6310 Offset: 0x19A6411 VA: 0x19A6310 Slot: 14
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x19A6340 Offset: 0x19A6441 VA: 0x19A6340 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrEndChildFunction : MulticastDelegate // TypeDefIndex: 1952
{
	// Methods

	// RVA: 0x19A6750 Offset: 0x19A6851 VA: 0x19A6750
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19A6770 Offset: 0x19A6871 VA: 0x19A6770 Slot: 13
	public virtual void Invoke(XdrBuilder builder) { }

	// RVA: 0x19A6AD0 Offset: 0x19A6BD1 VA: 0x19A6AD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x19A6B00 Offset: 0x19A6C01 VA: 0x19A6B00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

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

// Namespace: 
private sealed class XdrBuilder.XdrEntry // TypeDefIndex: 1954
{
	// Fields
	internal SchemaNames.Token _Name; // 0x10
	internal int[] _NextStates; // 0x18
	internal XdrBuilder.XdrAttributeEntry[] _Attributes; // 0x20
	internal XdrBuilder.XdrInitFunction _InitFunc; // 0x28
	internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc; // 0x30
	internal XdrBuilder.XdrEndChildFunction _EndChildFunc; // 0x38
	internal bool _AllowText; // 0x40

	// Methods

	// RVA: 0x19A6B10 Offset: 0x19A6C11 VA: 0x19A6B10
	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }
}

