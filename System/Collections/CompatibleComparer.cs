// Namespace: System.Collections
[Serializable]
internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 1345
{
	// Fields
	private IComparer _comparer; // 0x10
	private IHashCodeProvider _hcp; // 0x18

	// Properties
	internal IComparer Comparer { get; }
	internal IHashCodeProvider HashCodeProvider { get; }

	// Methods

	// RVA: 0x33AA730 Offset: 0x33AA831 VA: 0x33AA730
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x33AA780 Offset: 0x33AA881 VA: 0x33AA780
	public int Compare(object a, object b) { }

	// RVA: 0x33AA970 Offset: 0x33AAA71 VA: 0x33AA970 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x33AA990 Offset: 0x33AAA91 VA: 0x33AA990 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x33AAAB0 Offset: 0x33AABB1 VA: 0x33AAAB0
	internal IComparer get_Comparer() { }

	// RVA: 0x33AAAC0 Offset: 0x33AABC1 VA: 0x33AAAC0
	internal IHashCodeProvider get_HashCodeProvider() { }
}

