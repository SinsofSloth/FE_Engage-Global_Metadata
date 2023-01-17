// Namespace: nn.ngc
public sealed class ProfanityFilter : IDisposable // TypeDefIndex: 14543
{
	// Fields
	private IntPtr _profanityFilter; // 0x10
	private IntPtr _ngcWorkBuffer; // 0x18

	// Methods

	// RVA: 0x29E64B0 Offset: 0x29E65B1 VA: 0x29E64B0
	public void .ctor() { }

	// RVA: 0x29E6550 Offset: 0x29E6651 VA: 0x29E6550
	public void .ctor(bool checkDesiredLanguage) { }

	// RVA: 0x29E65E0 Offset: 0x29E66E1 VA: 0x29E65E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x29E6720 Offset: 0x29E6821 VA: 0x29E6720 Slot: 4
	public void Dispose() { }

	// RVA: 0x29E66A0 Offset: 0x29E67A1 VA: 0x29E66A0
	private void Dispose(bool disposing) { }

	// RVA: 0x29E6800 Offset: 0x29E6901 VA: 0x29E6800
	public uint GetContentVersion() { }

	// RVA: 0x29E6820 Offset: 0x29E6921 VA: 0x29E6820
	public Result CheckProfanityWords([Out] ProfanityFilter.PatternList[] checkResults, ProfanityFilter.PatternList patterns, string[] words) { }

	// RVA: 0x29E69D0 Offset: 0x29E6AD1 VA: 0x29E69D0
	public Result MaskProfanityWordsInText(ref int profanityWordCount, string inText, out string outText, ProfanityFilter.PatternList patterns) { }

	// RVA: 0x29E6AE0 Offset: 0x29E6BE1 VA: 0x29E6AE0
	public void SetMaskMode(ProfanityFilter.MaskMode mode) { }

	// RVA: 0x29E6B00 Offset: 0x29E6C01 VA: 0x29E6B00
	public void SkipAtSignCheck(ProfanityFilter.SkipMode skipMode) { }

	// RVA: 0x29E67F0 Offset: 0x29E68F1 VA: 0x29E67F0
	private static extern void Destroy(IntPtr profanityFilter, IntPtr ngcWorkBuffer) { }

	// RVA: 0x29E6530 Offset: 0x29E6631 VA: 0x29E6530
	private static extern Result Initialize(ref IntPtr profanityFilter, ref IntPtr ngcWorkBuffer, bool checkDesiredLanguage) { }

	// RVA: 0x29E6810 Offset: 0x29E6911 VA: 0x29E6810
	private static extern uint GetContentVersion(IntPtr profanityFilter) { }

	// RVA: 0x29E6840 Offset: 0x29E6941 VA: 0x29E6840
	private static extern Result CheckProfanityWords(IntPtr profanityFilter, [Out] ProfanityFilter.PatternList[] checkResults, ProfanityFilter.PatternList patterns, string[] words, long wordCount) { }

	// RVA: 0x29E6AB0 Offset: 0x29E6BB1 VA: 0x29E6AB0
	private static extern Result MaskProfanityWordsInText(IntPtr profanityFilter, ref int profanityWordCount, string text, ProfanityFilter.PatternList patterns) { }

	// RVA: 0x29E6AF0 Offset: 0x29E6BF1 VA: 0x29E6AF0
	private static extern void SetMaskMode(IntPtr profanityFilter, ProfanityFilter.MaskMode mode) { }

	// RVA: 0x29E6B10 Offset: 0x29E6C11 VA: 0x29E6B10
	private static extern void SkipAtSignCheck(IntPtr profanityFilter, ProfanityFilter.SkipMode skipMode) { }
}

