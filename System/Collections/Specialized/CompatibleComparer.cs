// Namespace: System.Collections.Specialized
[Serializable]
internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 2400
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x1B49DF0 Offset: 0x1B49EF1 VA: 0x1B49DF0
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1B49E40 Offset: 0x1B49F41 VA: 0x1B49E40 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x1B4A060 Offset: 0x1B4A161 VA: 0x1B4A060 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x1B4A180 Offset: 0x1B4A281 VA: 0x1B4A180
	public IComparer get_Comparer() { }

	// RVA: 0x1B4A190 Offset: 0x1B4A291 VA: 0x1B4A190
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x1B4A1A0 Offset: 0x1B4A2A1 VA: 0x1B4A1A0
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x1B4A290 Offset: 0x1B4A391 VA: 0x1B4A290
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }
}

