// Namespace: 
public enum Phase.Kind // TypeDefIndex: 8498
{
	// Fields
	public int value__; // 0x0
	public const Phase.Kind Unknown = 0;
	public const Phase.Kind Attack = 1;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x2736C0 Offset: 0x2737C1 VA: 0x2736C0
public enum Phase.Detail // TypeDefIndex: 8500
{
	// Fields
	public int value__; // 0x0
	public const Phase.Detail FirstAttack = 1;
	public const Phase.Detail LastAttack = 2;
	public const Phase.Detail Rush = 4;
	public const Phase.Detail Efficacy = 8;
	public const Phase.Detail EngageAttack = 16;
	public const Phase.Detail Break = 32;
	public const Phase.Detail Smash = 64;
	public const Phase.Detail StandingDie = 128;
	public const Phase.Detail DamageDisplayed = 256;
	public const Phase.Detail ChainAtk = 4096;
	public const Phase.Detail ChainAtk2 = 8192;
	public const Phase.Detail ChainGrd1 = 16384;
	public const Phase.Detail ChainGrd2 = 32768;
	public const Phase.Detail ChainGrd3 = 65536;
	public const Phase.Detail ChainGrd4 = 131072;
	public const Phase.Detail ChainGrd = 245760;
}

