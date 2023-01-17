// Namespace: System.Globalization
public sealed class IdnMapping // TypeDefIndex: 725
{
	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x340D340 Offset: 0x340D441 VA: 0x340D340
	public void .ctor() { }

	// RVA: 0x340D3C0 Offset: 0x340D4C1 VA: 0x340D3C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x340D480 Offset: 0x340D581 VA: 0x340D480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x340D490 Offset: 0x340D591 VA: 0x340D490
	public string GetAscii(string unicode) { }

	// RVA: 0x340D500 Offset: 0x340D601 VA: 0x340D500
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x340D5E0 Offset: 0x340D6E1 VA: 0x340D5E0
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x340D8C0 Offset: 0x340D9C1 VA: 0x340D8C0
	private string ToAscii(string s, int offset) { }

	// RVA: 0x340DFF0 Offset: 0x340E0F1 VA: 0x340DFF0
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x340DCD0 Offset: 0x340DDD1 VA: 0x340DCD0
	private string NamePrep(string s, int offset) { }

	// RVA: 0x340E0C0 Offset: 0x340E1C1 VA: 0x340E0C0
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x340DE20 Offset: 0x340DF21 VA: 0x340DE20
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x340E300 Offset: 0x340E401 VA: 0x340E300
	public string GetUnicode(string ascii) { }

	// RVA: 0x340E370 Offset: 0x340E471 VA: 0x340E370
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x340DB00 Offset: 0x340DC01 VA: 0x340DB00
	private string ToUnicode(string s, int offset) { }
}

