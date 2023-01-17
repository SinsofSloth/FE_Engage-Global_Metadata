// Namespace: TMPro
[Serializable]
public class KerningTable // TypeDefIndex: 7376
{
	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0x192E0A0 Offset: 0x192E1A1 VA: 0x192E0A0
	public void .ctor() { }

	// RVA: 0x192E130 Offset: 0x192E231 VA: 0x192E130
	public void AddKerningPair() { }

	// RVA: 0x192E260 Offset: 0x192E361 VA: 0x192E260
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0x192E3F0 Offset: 0x192E4F1 VA: 0x192E3F0
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0x192E5C0 Offset: 0x192E6C1 VA: 0x192E5C0
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0x192E710 Offset: 0x192E811 VA: 0x192E710
	public void RemoveKerningPair(int index) { }

	// RVA: 0x192E770 Offset: 0x192E871 VA: 0x192E770
	public void SortKerningPairs() { }
}

