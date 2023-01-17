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

