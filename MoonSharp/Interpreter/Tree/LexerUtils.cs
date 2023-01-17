// Namespace: MoonSharp.Interpreter.Tree
internal static class LexerUtils // TypeDefIndex: 5992
{
	// Methods

	// RVA: 0x33219A0 Offset: 0x3321AA1 VA: 0x33219A0
	public static double ParseNumber(Token T) { }

	// RVA: 0x3321AF0 Offset: 0x3321BF1 VA: 0x3321AF0
	public static double ParseHexInteger(Token T) { }

	// RVA: 0x3321D10 Offset: 0x3321E11 VA: 0x3321D10
	public static string ReadHexProgressive(string s, ref double d, out int digits) { }

	// RVA: 0x3321F60 Offset: 0x3322061 VA: 0x3321F60
	public static double ParseHexFloat(Token T) { }

	// RVA: 0x3321E50 Offset: 0x3321F51 VA: 0x3321E50
	public static int HexDigit2Value(char c) { }

	// RVA: 0x331EC20 Offset: 0x331ED21 VA: 0x331EC20
	public static bool CharIsDigit(char c) { }

	// RVA: 0x3320D90 Offset: 0x3320E91 VA: 0x3320D90
	public static bool CharIsHexDigit(char c) { }

	// RVA: 0x3320CE0 Offset: 0x3320DE1 VA: 0x3320CE0
	public static string AdjustLuaLongString(string str) { }

	// RVA: 0x3320DF0 Offset: 0x3320EF1 VA: 0x3320DF0
	public static string UnescapeLuaString(Token token, string str) { }

	// RVA: 0x33226A0 Offset: 0x33227A1 VA: 0x33226A0
	private static string ConvertUtf32ToChar(int i) { }
}

