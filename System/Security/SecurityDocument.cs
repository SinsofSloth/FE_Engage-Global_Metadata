// Namespace: System.Security
[Serializable]
internal sealed class SecurityDocument // TypeDefIndex: 872
{
	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x3612300 Offset: 0x3612401 VA: 0x3612300
	public void .ctor(int numData) { }

	// RVA: 0x3612380 Offset: 0x3612481 VA: 0x3612380
	public void GuaranteeSize(int size) { }

	// RVA: 0x3612440 Offset: 0x3612541 VA: 0x3612440
	public void AddString(string str, ref int position) { }

	// RVA: 0x3612630 Offset: 0x3612731 VA: 0x3612630
	public void AppendString(string str, ref int position) { }

	// RVA: 0x36126D0 Offset: 0x36127D1 VA: 0x36126D0
	public static int EncodedStringSize(string str) { }

	// RVA: 0x36126E0 Offset: 0x36127E1 VA: 0x36126E0
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x3612D30 Offset: 0x3612E31 VA: 0x3612D30
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x3612E20 Offset: 0x3612F21 VA: 0x3612E20
	public SecurityElement GetRootElement() { }

	// RVA: 0x3612E50 Offset: 0x3612F51 VA: 0x3612E50
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x3612E80 Offset: 0x3612F81 VA: 0x3612E80
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }
}

