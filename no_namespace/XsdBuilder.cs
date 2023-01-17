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

