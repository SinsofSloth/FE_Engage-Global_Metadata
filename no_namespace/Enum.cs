// Namespace: 
private struct Enum.EnumResult // TypeDefIndex: 211
{
	// Fields
	internal object parsedEnum; // 0x0
	internal bool canThrow; // 0x8
	internal Enum.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal string m_failureParameter; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal Exception m_innerException; // 0x28

	// Methods

	// RVA: 0x35EA760 Offset: 0x35EA861 VA: 0x35EA760
	internal void Init(bool canMethodThrow) { }

	// RVA: 0x35EA7E0 Offset: 0x35EA8E1 VA: 0x35EA7E0
	internal void SetFailure(Exception unhandledException) { }

	// RVA: 0x35EA7F0 Offset: 0x35EA8F1 VA: 0x35EA7F0
	internal void SetFailure(Enum.ParseFailureKind failure, string failureParameter) { }

	// RVA: 0x35EA9D0 Offset: 0x35EAAD1 VA: 0x35EA9D0
	internal void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x35EA850 Offset: 0x35EA951 VA: 0x35EA850
	internal Exception GetEnumParseException() { }
}

