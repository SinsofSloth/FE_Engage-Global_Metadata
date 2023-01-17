// Namespace: System
public class UriBuilder // TypeDefIndex: 2213
{
	// Fields
	private bool _changed; // 0x10
	private string _fragment; // 0x18
	private string _host; // 0x20
	private string _password; // 0x28
	private string _path; // 0x30
	private int _port; // 0x38
	private string _query; // 0x40
	private string _scheme; // 0x48
	private string _schemeDelimiter; // 0x50
	private Uri _uri; // 0x58
	private string _username; // 0x60

	// Properties
	public string Host { set; }
	public string Path { set; }
	public string Scheme { set; }
	public Uri Uri { get; }

	// Methods

	// RVA: 0x19418D0 Offset: 0x19419D1 VA: 0x19418D0
	public void .ctor() { }

	// RVA: 0x1941A60 Offset: 0x1941B61 VA: 0x1941A60
	public void set_Host(string value) { }

	// RVA: 0x1941B60 Offset: 0x1941C61 VA: 0x1941B60
	public void set_Path(string value) { }

	// RVA: 0x1941C30 Offset: 0x1941D31 VA: 0x1941C30
	public void set_Scheme(string value) { }

	// RVA: 0x1941D90 Offset: 0x1941E91 VA: 0x1941D90
	public Uri get_Uri() { }

	// RVA: 0x1942020 Offset: 0x1942121 VA: 0x1942020 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x1942100 Offset: 0x1942201 VA: 0x1942100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1941E40 Offset: 0x1941F41 VA: 0x1941E40
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x19421B0 Offset: 0x19422B1 VA: 0x19421B0 Slot: 3
	public override string ToString() { }
}

