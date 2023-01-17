// Namespace: System.Security.Policy
[MonoTODOAttribute] // RVA: 0x473AC0 Offset: 0x473BC1 VA: 0x473AC0
[ComVisibleAttribute] // RVA: 0x473AC0 Offset: 0x473BC1 VA: 0x473AC0
[Serializable]
public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 881
{
	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[ObsoleteAttribute] // RVA: 0x47E130 Offset: 0x47E231 VA: 0x47E130
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x3B60A30 Offset: 0x3B60B31 VA: 0x3B60A30
	public void .ctor() { }

	// RVA: 0x3B60A40 Offset: 0x3B60B41 VA: 0x3B60A40 Slot: 5
	public int get_Count() { }

	// RVA: 0x3B60AB0 Offset: 0x3B60BB1 VA: 0x3B60AB0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x3B60AC0 Offset: 0x3B60BC1 VA: 0x3B60AC0 Slot: 6
	public object get_SyncRoot() { }

	[ObsoleteAttribute] // RVA: 0x47CE00 Offset: 0x47CF01 VA: 0x47CE00
	// RVA: 0x3B60AD0 Offset: 0x3B60BD1 VA: 0x3B60AD0 Slot: 4
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] // RVA: 0x47CE10 Offset: 0x47CF11 VA: 0x47CE10
	// RVA: 0x3B60BA0 Offset: 0x3B60CA1 VA: 0x3B60BA0 Slot: 8
	public IEnumerator GetEnumerator() { }
}

