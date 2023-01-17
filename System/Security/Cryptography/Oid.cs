// Namespace: System.Security.Cryptography
public sealed class Oid // TypeDefIndex: 2341
{
	// Fields
	private string m_value; // 0x10
	private string m_friendlyName; // 0x18
	private OidGroup m_group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; }

	// Methods

	// RVA: 0x1AD1FD0 Offset: 0x1AD20D1 VA: 0x1AD1FD0
	public void .ctor(string oid) { }

	// RVA: 0x1AD2030 Offset: 0x1AD2131 VA: 0x1AD2030
	internal void .ctor(string oid, OidGroup group, bool lookupFriendlyName) { }

	// RVA: 0x1AD20A0 Offset: 0x1AD21A1 VA: 0x1AD20A0
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x1AD20F0 Offset: 0x1AD21F1 VA: 0x1AD20F0
	public void .ctor(Oid oid) { }

	// RVA: 0x1AD2190 Offset: 0x1AD2291 VA: 0x1AD2190
	public string get_Value() { }

	// RVA: 0x1AD21A0 Offset: 0x1AD22A1 VA: 0x1AD21A0
	public void set_Value(string value) { }

	// RVA: 0x1AD21B0 Offset: 0x1AD22B1 VA: 0x1AD21B0
	public string get_FriendlyName() { }
}

