// Namespace: System
[ComVisibleAttribute] // RVA: 0x470A80 Offset: 0x470B81 VA: 0x470A80
[Serializable]
public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 306
{
	// Fields
	private static readonly StringComparer _invariantCulture; // 0x0
	private static readonly StringComparer _invariantCultureIgnoreCase; // 0x8
	private static readonly StringComparer _ordinal; // 0x10
	private static readonly StringComparer _ordinalIgnoreCase; // 0x18

	// Properties
	public static StringComparer InvariantCultureIgnoreCase { get; }
	public static StringComparer CurrentCultureIgnoreCase { get; }
	public static StringComparer Ordinal { get; }
	public static StringComparer OrdinalIgnoreCase { get; }

	// Methods

	// RVA: 0x3659CC0 Offset: 0x3659DC1 VA: 0x3659CC0
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x3659D30 Offset: 0x3659E31 VA: 0x3659D30
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x3659DD0 Offset: 0x3659ED1 VA: 0x3659DD0
	public static StringComparer get_Ordinal() { }

	// RVA: 0x3659E40 Offset: 0x3659F41 VA: 0x3659E40
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x3659EB0 Offset: 0x3659FB1 VA: 0x3659EB0 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x365A060 Offset: 0x365A161 VA: 0x365A060 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x365A130 Offset: 0x365A231 VA: 0x365A130 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x365A210 Offset: 0x365A311 VA: 0x365A210
	protected void .ctor() { }

	// RVA: 0x365A220 Offset: 0x365A321 VA: 0x365A220
	private static void .cctor() { }
}

