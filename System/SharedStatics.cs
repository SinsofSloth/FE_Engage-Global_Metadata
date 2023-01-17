// Namespace: System
internal sealed class SharedStatics // TypeDefIndex: 301
{
	// Fields
	private static readonly SharedStatics _sharedStatics; // 0x0
	private Tokenizer.StringMaker _maker; // 0x10

	// Methods

	// RVA: 0x361C9F0 Offset: 0x361CAF1 VA: 0x361C9F0
	private void .ctor() { }

	// RVA: 0x3612A10 Offset: 0x3612B11 VA: 0x3612A10
	public static Tokenizer.StringMaker GetSharedStringMaker() { }

	// RVA: 0x3612BC0 Offset: 0x3612CC1 VA: 0x3612BC0
	public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) { }

	// RVA: 0x361CA00 Offset: 0x361CB01 VA: 0x361CA00
	private static void .cctor() { }
}

