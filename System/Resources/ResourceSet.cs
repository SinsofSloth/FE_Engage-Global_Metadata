// Namespace: System.Resources
[ComVisibleAttribute] // RVA: 0x4715D0 Offset: 0x4716D1 VA: 0x4715D0
[Serializable]
public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 496
{
	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0x32268E0 Offset: 0x32269E1 VA: 0x32268E0
	protected void .ctor() { }

	// RVA: 0x32269D0 Offset: 0x3226AD1 VA: 0x32269D0
	internal void .ctor(bool junk) { }

	// RVA: 0x3226960 Offset: 0x3226A61 VA: 0x3226960
	private void CommonInit() { }

	// RVA: 0x32269E0 Offset: 0x3226AE1 VA: 0x32269E0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3226AD0 Offset: 0x3226BD1 VA: 0x3226AD0 Slot: 4
	public void Dispose() { }

	[ComVisibleAttribute] // RVA: 0x47BC50 Offset: 0x47BD51 VA: 0x47BC50
	// RVA: 0x3226AE0 Offset: 0x3226BE1 VA: 0x3226AE0 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x3226B70 Offset: 0x3226C71 VA: 0x3226B70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3226AF0 Offset: 0x3226BF1 VA: 0x3226AF0
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x3226B80 Offset: 0x3226C81 VA: 0x3226B80 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0x3226DC0 Offset: 0x3226EC1 VA: 0x3226DC0 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0x32272F0 Offset: 0x32273F1 VA: 0x32272F0 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0x3227300 Offset: 0x3227401 VA: 0x3227300 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0x3226CF0 Offset: 0x3226DF1 VA: 0x3226CF0
	private object GetObjectInternal(string name) { }

	// RVA: 0x3226FD0 Offset: 0x32270D1 VA: 0x3226FD0
	private object GetCaseInsensitiveObjectInternal(string name) { }
}

