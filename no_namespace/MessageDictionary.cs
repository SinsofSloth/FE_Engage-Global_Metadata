// Namespace: 
private class MessageDictionary.DictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1210
{
	// Fields
	private MessageDictionary _methodDictionary; // 0x10
	private IDictionaryEnumerator _hashtableEnum; // 0x18
	private int _posMethod; // 0x20

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x35EE4B0 Offset: 0x35EE5B1 VA: 0x35EE4B0
	public void .ctor(MessageDictionary methodDictionary) { }

	// RVA: 0x35EE5C0 Offset: 0x35EE6C1 VA: 0x35EE5C0 Slot: 8
	public object get_Current() { }

	// RVA: 0x35EE7B0 Offset: 0x35EE8B1 VA: 0x35EE7B0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x35EE990 Offset: 0x35EEA91 VA: 0x35EE990 Slot: 9
	public void Reset() { }

	// RVA: 0x35EE630 Offset: 0x35EE731 VA: 0x35EE630 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x35EEA40 Offset: 0x35EEB41 VA: 0x35EEA40 Slot: 4
	public object get_Key() { }

	// RVA: 0x35EEA50 Offset: 0x35EEB51 VA: 0x35EEA50 Slot: 5
	public object get_Value() { }
}

