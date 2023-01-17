// Namespace: 
public enum ProfanityFilter.MaskMode // TypeDefIndex: 14540
{
	// Fields
	public int value__; // 0x0
	public const ProfanityFilter.MaskMode OverWrite = 0;
	public const ProfanityFilter.MaskMode ReplaceByOneCharacter = 1;
}

// Namespace: 
public enum ProfanityFilter.SkipMode // TypeDefIndex: 14541
{
	// Fields
	public int value__; // 0x0
	public const ProfanityFilter.SkipMode NotSkip = 0;
	public const ProfanityFilter.SkipMode SkipAtSign = 1;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27A380 Offset: 0x27A481 VA: 0x27A380
public enum ProfanityFilter.PatternList // TypeDefIndex: 14542
{
	// Fields
	public int value__; // 0x0
	public const ProfanityFilter.PatternList Japanese = 1;
	public const ProfanityFilter.PatternList AmericanEnglish = 2;
	public const ProfanityFilter.PatternList CanadianFrench = 4;
	public const ProfanityFilter.PatternList LatinAmericanSpanish = 8;
	public const ProfanityFilter.PatternList BritishEnglish = 16;
	public const ProfanityFilter.PatternList French = 32;
	public const ProfanityFilter.PatternList German = 64;
	public const ProfanityFilter.PatternList Italian = 128;
	public const ProfanityFilter.PatternList Spanish = 256;
	public const ProfanityFilter.PatternList Dutch = 512;
	public const ProfanityFilter.PatternList Korean = 1024;
	public const ProfanityFilter.PatternList SimplifiedChinese = 2048;
	public const ProfanityFilter.PatternList Portuguese = 4096;
	public const ProfanityFilter.PatternList Russian = 8192;
	public const ProfanityFilter.PatternList BrazilianPortuguese = 16384;
	public const ProfanityFilter.PatternList TraditionalChinese = 32768;
	public const ProfanityFilter.PatternList Max = 16;
}

