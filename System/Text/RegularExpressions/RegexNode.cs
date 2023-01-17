// Namespace: System.Text.RegularExpressions
internal sealed class RegexNode // TypeDefIndex: 2269
{
	// Fields
	internal int _type; // 0x10
	internal List<RegexNode> _children; // 0x18
	internal string _str; // 0x20
	internal char _ch; // 0x28
	internal int _m; // 0x2C
	internal int _n; // 0x30
	internal RegexOptions _options; // 0x34
	internal RegexNode _next; // 0x38

	// Methods

	// RVA: 0x3C10070 Offset: 0x3C10171 VA: 0x3C10070
	internal void .ctor(int type, RegexOptions options) { }

	// RVA: 0x3C100B0 Offset: 0x3C101B1 VA: 0x3C100B0
	internal void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x3C10100 Offset: 0x3C10201 VA: 0x3C10100
	internal void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x3C10150 Offset: 0x3C10251 VA: 0x3C10150
	internal void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x3C101A0 Offset: 0x3C102A1 VA: 0x3C101A0
	internal void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x3C101F0 Offset: 0x3C102F1 VA: 0x3C101F0
	internal bool UseOptionR() { }

	// RVA: 0x3C10200 Offset: 0x3C10301 VA: 0x3C10200
	internal RegexNode ReverseLeft() { }

	// RVA: 0x3C10280 Offset: 0x3C10381 VA: 0x3C10280
	internal void MakeRep(int type, int min, int max) { }

	// RVA: 0x3C102A0 Offset: 0x3C103A1 VA: 0x3C102A0
	internal RegexNode Reduce() { }

	// RVA: 0x3C110C0 Offset: 0x3C111C1 VA: 0x3C110C0
	internal RegexNode StripEnation(int emptyType) { }

	// RVA: 0x3C10EA0 Offset: 0x3C10FA1 VA: 0x3C10EA0
	internal RegexNode ReduceGroup() { }

	// RVA: 0x3C10BF0 Offset: 0x3C10CF1 VA: 0x3C10BF0
	internal RegexNode ReduceRep() { }

	// RVA: 0x3C10F30 Offset: 0x3C11031 VA: 0x3C10F30
	internal RegexNode ReduceSet() { }

	// RVA: 0x3C10390 Offset: 0x3C10491 VA: 0x3C10390
	internal RegexNode ReduceAlternation() { }

	// RVA: 0x3C10820 Offset: 0x3C10921 VA: 0x3C10820
	internal RegexNode ReduceConcatenation() { }

	// RVA: 0x3C111D0 Offset: 0x3C112D1 VA: 0x3C111D0
	internal RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x3C112F0 Offset: 0x3C113F1 VA: 0x3C112F0
	internal void AddChild(RegexNode newChild) { }

	// RVA: 0x3C0BE60 Offset: 0x3C0BF61 VA: 0x3C0BE60
	internal RegexNode Child(int i) { }

	// RVA: 0x3C0BE00 Offset: 0x3C0BF01 VA: 0x3C0BE00
	internal int ChildCount() { }

	// RVA: 0x3C113D0 Offset: 0x3C114D1 VA: 0x3C113D0
	internal int Type() { }
}

