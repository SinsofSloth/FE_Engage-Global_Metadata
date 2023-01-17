// Namespace: System.Globalization
[ComVisibleAttribute] // RVA: 0x473040 Offset: 0x473141 VA: 0x473040
[Serializable]
public class SortKey // TypeDefIndex: 715
{
	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x382B1A0 Offset: 0x382B2A1 VA: 0x382B1A0
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x382B330 Offset: 0x382B431 VA: 0x382B330
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x382B380 Offset: 0x382B481 VA: 0x382B380
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x382B3F0 Offset: 0x382B4F1 VA: 0x382B3F0 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x382B400 Offset: 0x382B501 VA: 0x382B400 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x382B410 Offset: 0x382B511 VA: 0x382B410 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x382B4E0 Offset: 0x382B5E1 VA: 0x382B4E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x382B5A0 Offset: 0x382B6A1 VA: 0x382B5A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x382BA40 Offset: 0x382BB41 VA: 0x382BA40
	internal void .ctor() { }
}

