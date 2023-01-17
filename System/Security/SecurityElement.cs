// Namespace: System.Security
[ComVisibleAttribute] // RVA: 0x473A40 Offset: 0x473B41 VA: 0x473A40
[Serializable]
public sealed class SecurityElement // TypeDefIndex: 876
{
	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public Hashtable Attributes { get; }
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { get; set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x3613130 Offset: 0x3613231 VA: 0x3613130
	public void .ctor(string tag) { }

	// RVA: 0x36133D0 Offset: 0x36134D1 VA: 0x36133D0
	public void .ctor(string tag, string text) { }

	// RVA: 0x3613790 Offset: 0x3613891 VA: 0x3613790
	public Hashtable get_Attributes() { }

	// RVA: 0x3613A80 Offset: 0x3613B81 VA: 0x3613A80
	public ArrayList get_Children() { }

	// RVA: 0x3613A90 Offset: 0x3613B91 VA: 0x3613A90
	public string get_Tag() { }

	// RVA: 0x3613AA0 Offset: 0x3613BA1 VA: 0x3613AA0
	public string get_Text() { }

	// RVA: 0x3613620 Offset: 0x3613721 VA: 0x3613620
	public void set_Text(string value) { }

	// RVA: 0x3613140 Offset: 0x3613241 VA: 0x3613140
	public void AddAttribute(string name, string value) { }

	// RVA: 0x36132F0 Offset: 0x36133F1 VA: 0x36132F0
	public void AddChild(SecurityElement child) { }

	// RVA: 0x3613FF0 Offset: 0x36140F1 VA: 0x3613FF0
	public static string Escape(string str) { }

	// RVA: 0x3613B40 Offset: 0x3613C41 VA: 0x3613B40
	private static string Unescape(string str) { }

	// RVA: 0x3614200 Offset: 0x3614301 VA: 0x3614200
	public static SecurityElement FromString(string xml) { }

	// RVA: 0x36145C0 Offset: 0x36146C1 VA: 0x36145C0
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x3614650 Offset: 0x3614751 VA: 0x3614650
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x3613590 Offset: 0x3613691 VA: 0x3613590
	public static bool IsValidTag(string tag) { }

	// RVA: 0x3613AB0 Offset: 0x3613BB1 VA: 0x3613AB0
	public static bool IsValidText(string text) { }

	// RVA: 0x36146E0 Offset: 0x36147E1 VA: 0x36146E0
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x3614820 Offset: 0x3614921 VA: 0x3614820 Slot: 3
	public override string ToString() { }

	// RVA: 0x36148A0 Offset: 0x36149A1 VA: 0x36148A0
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x3613D20 Offset: 0x3613E21 VA: 0x3613D20
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x3614E30 Offset: 0x3614F31 VA: 0x3614E30
	internal void set_m_strText(string value) { }

	// RVA: 0x3614E40 Offset: 0x3614F41 VA: 0x3614E40
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x36150A0 Offset: 0x36151A1 VA: 0x36150A0
	private static void .cctor() { }
}

