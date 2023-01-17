// Namespace: Mono.Globalization.Unicode
internal class SortKeyBuffer // TypeDefIndex: 43
{
	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x382BA80 Offset: 0x382BB81 VA: 0x382BA80
	public void .ctor(int lcid) { }

	// RVA: 0x382BA90 Offset: 0x382BB91 VA: 0x382BA90
	public void Reset() { }

	// RVA: 0x382BAA0 Offset: 0x382BBA1 VA: 0x382BAA0
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x382BCF0 Offset: 0x382BDF1 VA: 0x382BCF0
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x382BE70 Offset: 0x382BF71 VA: 0x382BE70
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x382BF00 Offset: 0x382C001 VA: 0x382BF00
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x382C0A0 Offset: 0x382C1A1 VA: 0x382C0A0
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x382BD90 Offset: 0x382BE91 VA: 0x382BD90
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x382C150 Offset: 0x382C251 VA: 0x382C150
	public SortKey GetResultAndReset() { }

	// RVA: 0x382C980 Offset: 0x382CA81 VA: 0x382C980
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x382C180 Offset: 0x382C281 VA: 0x382C180
	public SortKey GetResult() { }
}

