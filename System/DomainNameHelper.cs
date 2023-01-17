// Namespace: System
internal class DomainNameHelper // TypeDefIndex: 2233
{
	// Methods

	// RVA: 0x1ADA090 Offset: 0x1ADA191 VA: 0x1ADA090
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x1ADA220 Offset: 0x1ADA321 VA: 0x1ADA220
	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1ADA490 Offset: 0x1ADA591 VA: 0x1ADA490
	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x1ADA6A0 Offset: 0x1ADA7A1 VA: 0x1ADA6A0
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x1ADA990 Offset: 0x1ADAA91 VA: 0x1ADA990
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x1ADABE0 Offset: 0x1ADACE1 VA: 0x1ADABE0
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x1ADAB90 Offset: 0x1ADAC91 VA: 0x1ADAB90
	private static bool IsIdnAce(char* input, int index) { }

	// RVA: 0x1ADAC80 Offset: 0x1ADAD81 VA: 0x1ADAC80
	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	// RVA: 0x1ADADA0 Offset: 0x1ADAEA1 VA: 0x1ADADA0
	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x1ADA3D0 Offset: 0x1ADA4D1 VA: 0x1ADA3D0
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	// RVA: 0x1ADA420 Offset: 0x1ADA521 VA: 0x1ADA420
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }
}

