// Namespace: System.Text.RegularExpressions
[DefaultMemberAttribute] // RVA: 0x2FCC0 Offset: 0x2FDC1 VA: 0x2FCC0
[Serializable]
public class MatchCollection : ICollection, IEnumerable // TypeDefIndex: 2266
{
	// Fields
	internal Regex _regex; // 0x10
	internal ArrayList _matches; // 0x18
	internal bool _done; // 0x20
	internal string _input; // 0x28
	internal int _beginning; // 0x30
	internal int _length; // 0x34
	internal int _startat; // 0x38
	internal int _prevlen; // 0x3C
	private static int infinite; // 0x0

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }
	public virtual Match Item { get; }

	// Methods

	// RVA: 0x1AC56E0 Offset: 0x1AC57E1 VA: 0x1AC56E0
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x1AC5830 Offset: 0x1AC5931 VA: 0x1AC5830
	internal Match GetMatch(int i) { }

	// RVA: 0x1AC5990 Offset: 0x1AC5A91 VA: 0x1AC5990 Slot: 5
	public int get_Count() { }

	// RVA: 0x1AC5A20 Offset: 0x1AC5B21 VA: 0x1AC5A20 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1AC5A30 Offset: 0x1AC5B31 VA: 0x1AC5A30 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1AC5A40 Offset: 0x1AC5B41 VA: 0x1AC5A40 Slot: 9
	public virtual Match get_Item(int i) { }

	// RVA: 0x1AC5AB0 Offset: 0x1AC5BB1 VA: 0x1AC5AB0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1AC5CA0 Offset: 0x1AC5DA1 VA: 0x1AC5CA0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1AC5D60 Offset: 0x1AC5E61 VA: 0x1AC5D60
	private static void .cctor() { }

	// RVA: 0x1AC5DB0 Offset: 0x1AC5EB1 VA: 0x1AC5DB0
	internal void .ctor() { }
}

