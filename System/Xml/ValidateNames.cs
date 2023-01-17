// Namespace: System.Xml
internal static class ValidateNames // TypeDefIndex: 1736
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0x19BB1A0 Offset: 0x19BB2A1 VA: 0x19BB1A0
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x19BB280 Offset: 0x19BB381 VA: 0x19BB280
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x19BB380 Offset: 0x19BB481 VA: 0x19BB380
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x19BB4F0 Offset: 0x19BB5F1 VA: 0x19BB4F0
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x19BB620 Offset: 0x19BB721 VA: 0x19BB620
	internal static int ParseNCName(string s) { }

	// RVA: 0x19BB690 Offset: 0x19BB791 VA: 0x19BB690
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0x19BB780 Offset: 0x19BB881 VA: 0x19BB780
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0x19BB8C0 Offset: 0x19BB9C1 VA: 0x19BB8C0
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x19BBA70 Offset: 0x19BBB71 VA: 0x19BBA70
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x19BBC40 Offset: 0x19BBD41 VA: 0x19BBC40
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0x19BBDB0 Offset: 0x19BBEB1 VA: 0x19BBDB0
	private static void .cctor() { }
}

