// Namespace: System.Text.RegularExpressions
[Serializable]
public class Match : Group // TypeDefIndex: 2264
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x1AC4A60 Offset: 0x1AC4B61 VA: 0x1AC4A60
	public static Match get_Empty() { }

	// RVA: 0x1AC4AD0 Offset: 0x1AC4BD1 VA: 0x1AC4AD0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x1AC4C90 Offset: 0x1AC4D91 VA: 0x1AC4C90 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x1AC4D40 Offset: 0x1AC4E41 VA: 0x1AC4D40 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x1AC4DF0 Offset: 0x1AC4EF1 VA: 0x1AC4DF0
	public Match NextMatch() { }

	// RVA: 0x1AC4E30 Offset: 0x1AC4F31 VA: 0x1AC4E30 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x1AC4F20 Offset: 0x1AC5021 VA: 0x1AC4F20
	internal string LastGroupToStringImpl() { }

	// RVA: 0x1AC4F40 Offset: 0x1AC5041 VA: 0x1AC4F40 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x1AC5190 Offset: 0x1AC5291 VA: 0x1AC5190 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x1AC5270 Offset: 0x1AC5371 VA: 0x1AC5270 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x1AC52B0 Offset: 0x1AC53B1 VA: 0x1AC52B0 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x1AC5340 Offset: 0x1AC5441 VA: 0x1AC5340 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x1AC53D0 Offset: 0x1AC54D1 VA: 0x1AC53D0 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x1AC5460 Offset: 0x1AC5561 VA: 0x1AC5460 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x1AC5600 Offset: 0x1AC5701 VA: 0x1AC5600
	private static void .cctor() { }

	// RVA: 0x1AC56A0 Offset: 0x1AC57A1 VA: 0x1AC56A0
	internal void .ctor() { }
}

