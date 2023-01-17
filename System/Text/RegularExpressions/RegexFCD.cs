// Namespace: System.Text.RegularExpressions
internal sealed class RegexFCD // TypeDefIndex: 2257
{
	// Fields
	private int[] _intStack; // 0x10
	private int _intDepth; // 0x18
	private RegexFC[] _fcStack; // 0x20
	private int _fcDepth; // 0x28
	private bool _skipAllChildren; // 0x2C
	private bool _skipchild; // 0x2D
	private bool _failed; // 0x2E

	// Methods

	// RVA: 0x3C0B760 Offset: 0x3C0B861 VA: 0x3C0B760
	internal static RegexPrefix FirstChars(RegexTree t) { }

	// RVA: 0x3C0BB00 Offset: 0x3C0BC01 VA: 0x3C0BB00
	internal static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x3C0BED0 Offset: 0x3C0BFD1 VA: 0x3C0BED0
	internal static int Anchors(RegexTree tree) { }

	// RVA: 0x3C0C0A0 Offset: 0x3C0C1A1 VA: 0x3C0C0A0
	private static int AnchorFromType(int type) { }

	// RVA: 0x3C0B8B0 Offset: 0x3C0B9B1 VA: 0x3C0B8B0
	private void .ctor() { }

	// RVA: 0x3C0C110 Offset: 0x3C0C211 VA: 0x3C0C110
	private void PushInt(int I) { }

	// RVA: 0x3C0C1F0 Offset: 0x3C0C2F1 VA: 0x3C0C1F0
	private bool IntIsEmpty() { }

	// RVA: 0x3C0C200 Offset: 0x3C0C301 VA: 0x3C0C200
	private int PopInt() { }

	// RVA: 0x3C0C240 Offset: 0x3C0C341 VA: 0x3C0C240
	private void PushFC(RegexFC fc) { }

	// RVA: 0x3C0C350 Offset: 0x3C0C451 VA: 0x3C0C350
	private bool FCIsEmpty() { }

	// RVA: 0x3C0C360 Offset: 0x3C0C461 VA: 0x3C0C360
	private RegexFC PopFC() { }

	// RVA: 0x3C0C3A0 Offset: 0x3C0C4A1 VA: 0x3C0C3A0
	private RegexFC TopFC() { }

	// RVA: 0x3C0B950 Offset: 0x3C0BA51 VA: 0x3C0B950
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x3C0CAE0 Offset: 0x3C0CBE1 VA: 0x3C0CAE0
	private void SkipChild() { }

	// RVA: 0x3C0C3E0 Offset: 0x3C0C4E1 VA: 0x3C0C3E0
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }
}

