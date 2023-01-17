// Namespace: 
private enum Enum.ParseFailureKind // TypeDefIndex: 210
{
	// Fields
	public int value__; // 0x0
	public const Enum.ParseFailureKind None = 0;
	public const Enum.ParseFailureKind Argument = 1;
	public const Enum.ParseFailureKind ArgumentNull = 2;
	public const Enum.ParseFailureKind ArgumentWithParameter = 3;
	public const Enum.ParseFailureKind UnhandledException = 4;
}

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

// Namespace: 
private class Enum.ValuesAndNames // TypeDefIndex: 212
{
	// Fields
	public ulong[] Values; // 0x10
	public string[] Names; // 0x18

	// Methods

	// RVA: 0x35EAA50 Offset: 0x35EAB51 VA: 0x35EAA50
	public void .ctor(ulong[] values, string[] names) { }
}

