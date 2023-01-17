// Namespace: System.Globalization
[Serializable]
internal class CodePageDataItem // TypeDefIndex: 717
{
	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal uint m_flags; // 0x28
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }
	public string HeaderName { get; }

	// Methods

	// RVA: 0x33A6810 Offset: 0x33A6911 VA: 0x33A6810
	internal void .ctor(int dataIndex) { }

	// RVA: 0x33A68E0 Offset: 0x33A69E1 VA: 0x33A68E0
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x33A69B0 Offset: 0x33A6AB1 VA: 0x33A69B0
	public string get_WebName() { }

	// RVA: 0x33A6AB0 Offset: 0x33A6BB1 VA: 0x33A6AB0
	public string get_HeaderName() { }

	// RVA: 0x33A6BB0 Offset: 0x33A6CB1 VA: 0x33A6BB0
	private static void .cctor() { }
}

