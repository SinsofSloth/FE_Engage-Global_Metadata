// Namespace: System.Collections.Specialized
[DefaultMemberAttribute] // RVA: 0x30810 Offset: 0x30911 VA: 0x30810
[Serializable]
public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 2401
{
	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }

	// Methods

	// RVA: 0x1ACD370 Offset: 0x1ACD471 VA: 0x1ACD370
	public void .ctor() { }

	// RVA: 0x1ACD3E0 Offset: 0x1ACD4E1 VA: 0x1ACD3E0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1ACD460 Offset: 0x1ACD561 VA: 0x1ACD460
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x1ACD4D0 Offset: 0x1ACD5D1 VA: 0x1ACD4D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1ACD550 Offset: 0x1ACD651 VA: 0x1ACD550
	protected void InvalidateCachedArrays() { }

	// RVA: 0x1ACD590 Offset: 0x1ACD691 VA: 0x1ACD590
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x1ACD750 Offset: 0x1ACD851 VA: 0x1ACD750
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x1ACD800 Offset: 0x1ACD901 VA: 0x1ACD800 Slot: 15
	public virtual void Add(string name, string value) { }

	// RVA: 0x1ACDA20 Offset: 0x1ACDB21 VA: 0x1ACDA20 Slot: 16
	public virtual string Get(string name) { }

	// RVA: 0x1ACDB60 Offset: 0x1ACDC61 VA: 0x1ACDB60 Slot: 17
	public virtual string[] GetValues(string name) { }

	// RVA: 0x1ACDD20 Offset: 0x1ACDE21 VA: 0x1ACDD20 Slot: 18
	public virtual void Set(string name, string value) { }

	// RVA: 0x1ACDE30 Offset: 0x1ACDF31 VA: 0x1ACDE30 Slot: 19
	public virtual void Remove(string name) { }

	// RVA: 0x1ACDE80 Offset: 0x1ACDF81 VA: 0x1ACDE80
	public string get_Item(string name) { }

	// RVA: 0x1ACDE90 Offset: 0x1ACDF91 VA: 0x1ACDE90
	public void set_Item(string name, string value) { }

	// RVA: 0x1ACDEA0 Offset: 0x1ACDFA1 VA: 0x1ACDEA0 Slot: 20
	public virtual string Get(int index) { }

	// RVA: 0x1ACDFA0 Offset: 0x1ACE0A1 VA: 0x1ACDFA0 Slot: 21
	public virtual string GetKey(int index) { }
}

