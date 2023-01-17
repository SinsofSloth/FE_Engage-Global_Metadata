// Namespace: System.Text.RegularExpressions
internal sealed class RegexWriter // TypeDefIndex: 2276
{
	// Fields
	internal int[] _intStack; // 0x10
	internal int _depth; // 0x18
	internal int[] _emitted; // 0x20
	internal int _curpos; // 0x28
	internal Dictionary<string, int> _stringhash; // 0x30
	internal List<string> _stringtable; // 0x38
	internal bool _counting; // 0x40
	internal int _count; // 0x44
	internal int _trackcount; // 0x48
	internal Hashtable _caps; // 0x50

	// Methods

	// RVA: 0x2D01D30 Offset: 0x2D01E31 VA: 0x2D01D30
	internal static RegexCode Write(RegexTree t) { }

	// RVA: 0x2D01DA0 Offset: 0x2D01EA1 VA: 0x2D01DA0
	private void .ctor() { }

	// RVA: 0x2D02350 Offset: 0x2D02451 VA: 0x2D02350
	internal void PushInt(int I) { }

	// RVA: 0x2D02430 Offset: 0x2D02531 VA: 0x2D02430
	internal bool EmptyStack() { }

	// RVA: 0x2D02440 Offset: 0x2D02541 VA: 0x2D02440
	internal int PopInt() { }

	// RVA: 0x2D02480 Offset: 0x2D02581 VA: 0x2D02480
	internal int CurPos() { }

	// RVA: 0x2D02490 Offset: 0x2D02591 VA: 0x2D02490
	internal void PatchJump(int Offset, int jumpDest) { }

	// RVA: 0x2D024D0 Offset: 0x2D025D1 VA: 0x2D024D0
	internal void Emit(int op) { }

	// RVA: 0x2D02560 Offset: 0x2D02661 VA: 0x2D02560
	internal void Emit(int op, int opd1) { }

	// RVA: 0x2D02610 Offset: 0x2D02711 VA: 0x2D02610
	internal void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x2D026E0 Offset: 0x2D027E1 VA: 0x2D026E0
	internal int StringCode(string str) { }

	// RVA: 0x2D02810 Offset: 0x2D02911 VA: 0x2D02810
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x2D02880 Offset: 0x2D02981 VA: 0x2D02880
	internal int MapCapnum(int capnum) { }

	// RVA: 0x2D01EE0 Offset: 0x2D01FE1 VA: 0x2D01EE0
	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x2D02940 Offset: 0x2D02A41 VA: 0x2D02940
	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }
}

