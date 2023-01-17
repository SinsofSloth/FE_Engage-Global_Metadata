// Namespace: System.Text
internal static class EncodingHelper // TypeDefIndex: 481
{
	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x3733930 Offset: 0x3733A31 VA: 0x3733930
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x3733B60 Offset: 0x3733C61 VA: 0x3733B60
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x3733140 Offset: 0x3733241 VA: 0x3733140
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x37316C0 Offset: 0x37317C1 VA: 0x37316C0
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x3733B70 Offset: 0x3733C71 VA: 0x3733B70
	private static void .cctor() { }
}

