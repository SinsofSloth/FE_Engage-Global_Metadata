// Namespace: System.Globalization
internal class Bootstring // TypeDefIndex: 726
{
	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x350C200 Offset: 0x350C301 VA: 0x350C200
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x350C280 Offset: 0x350C381 VA: 0x350C280
	public string Encode(string s, int offset) { }

	// RVA: 0x350C650 Offset: 0x350C751 VA: 0x350C650
	private char EncodeDigit(int d) { }

	// RVA: 0x350C6F0 Offset: 0x350C7F1 VA: 0x350C6F0
	private int DecodeDigit(char c) { }

	// RVA: 0x350C670 Offset: 0x350C771 VA: 0x350C670
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x350C730 Offset: 0x350C831 VA: 0x350C730
	public string Decode(string s, int offset) { }
}

