// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 2540
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x1B58690 Offset: 0x1B58791 VA: 0x1B58690
	public void .ctor(string header) { }

	// RVA: 0x1B58760 Offset: 0x1B58861 VA: 0x1B58760
	public string get_Realm() { }

	// RVA: 0x1B58790 Offset: 0x1B58891 VA: 0x1B58790
	public string get_Opaque() { }

	// RVA: 0x1B587C0 Offset: 0x1B588C1 VA: 0x1B587C0
	public string get_Nonce() { }

	// RVA: 0x1B587F0 Offset: 0x1B588F1 VA: 0x1B587F0
	public string get_Algorithm() { }

	// RVA: 0x1B58820 Offset: 0x1B58921 VA: 0x1B58820
	public string get_QOP() { }

	// RVA: 0x1B58850 Offset: 0x1B58951 VA: 0x1B58850
	public bool Parse() { }

	// RVA: 0x1B58D00 Offset: 0x1B58E01 VA: 0x1B58D00
	private void SkipWhitespace() { }

	// RVA: 0x1B58D90 Offset: 0x1B58E91 VA: 0x1B58D90
	private string GetKey() { }

	// RVA: 0x1B58AB0 Offset: 0x1B58BB1 VA: 0x1B58AB0
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x1B58E80 Offset: 0x1B58F81 VA: 0x1B58E80
	private static void .cctor() { }
}

