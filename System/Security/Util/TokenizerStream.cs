// Namespace: System.Security.Util
internal sealed class TokenizerStream // TypeDefIndex: 890
{
	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x1B25840 Offset: 0x1B25941 VA: 0x1B25840
	internal void .ctor() { }

	// RVA: 0x1B25520 Offset: 0x1B25621 VA: 0x1B25520
	internal void AddToken(short token) { }

	// RVA: 0x1B25670 Offset: 0x1B25771 VA: 0x1B25670
	internal void AddString(string str) { }

	// RVA: 0x1B25A40 Offset: 0x1B25B41 VA: 0x1B25A40
	internal void Reset() { }

	// RVA: 0x1B25A90 Offset: 0x1B25B91 VA: 0x1B25A90
	internal short GetNextFullToken() { }

	// RVA: 0x1B25B30 Offset: 0x1B25C31 VA: 0x1B25B30
	internal short GetNextToken() { }

	// RVA: 0x1B25BD0 Offset: 0x1B25CD1 VA: 0x1B25BD0
	internal string GetNextString() { }

	// RVA: 0x1B25C50 Offset: 0x1B25D51 VA: 0x1B25C50
	internal void ThrowAwayNextString() { }

	// RVA: 0x1B25CC0 Offset: 0x1B25DC1 VA: 0x1B25CC0
	internal void TagLastToken(short tag) { }

	// RVA: 0x1B25D30 Offset: 0x1B25E31 VA: 0x1B25D30
	internal int GetTokenCount() { }

	// RVA: 0x1B25D40 Offset: 0x1B25E41 VA: 0x1B25D40
	internal void GoToPosition(int position) { }
}

