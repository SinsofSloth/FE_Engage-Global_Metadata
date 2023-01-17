// Namespace: 
private enum Guid.GuidParseThrowStyle // TypeDefIndex: 242
{
	// Fields
	public int value__; // 0x0
	public const Guid.GuidParseThrowStyle None = 0;
	public const Guid.GuidParseThrowStyle All = 1;
	public const Guid.GuidParseThrowStyle AllButOverflow = 2;
}

// Namespace: 
private struct Guid.GuidResult // TypeDefIndex: 244
{
	// Fields
	internal Guid parsedGuid; // 0x0
	internal Guid.GuidParseThrowStyle throwStyle; // 0x10
	internal Guid.ParseFailureKind m_failure; // 0x14
	internal string m_failureMessageID; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal string m_failureArgumentName; // 0x28
	internal Exception m_innerException; // 0x30

	// Methods

	// RVA: 0x35EBD50 Offset: 0x35EBE51 VA: 0x35EBD50
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x35EBDD0 Offset: 0x35EBED1 VA: 0x35EBDD0
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x35EBDE0 Offset: 0x35EBEE1 VA: 0x35EBDE0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x35EBE90 Offset: 0x35EBF91 VA: 0x35EBE90
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x35EBDF0 Offset: 0x35EBEF1 VA: 0x35EBDF0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x35EBEA0 Offset: 0x35EBFA1 VA: 0x35EBEA0
	internal Exception GetGuidParseException() { }
}

