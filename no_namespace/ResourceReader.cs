// Namespace: 
internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 494
{
	// Fields
	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

	// Properties
	public object Key { get; }
	public object Current { get; }
	internal int DataPosition { get; }
	public DictionaryEntry Entry { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1C01130 Offset: 0x1C01231 VA: 0x1C01130
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0x1C01180 Offset: 0x1C01281 VA: 0x1C01180 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1C011D0 Offset: 0x1C012D1 VA: 0x1C011D0 Slot: 4
	public object get_Key() { }

	// RVA: 0x1C01280 Offset: 0x1C01381 VA: 0x1C01280 Slot: 8
	public object get_Current() { }

	// RVA: 0x1C015A0 Offset: 0x1C016A1 VA: 0x1C015A0
	internal int get_DataPosition() { }

	// RVA: 0x1C012F0 Offset: 0x1C013F1 VA: 0x1C012F0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1C015B0 Offset: 0x1C016B1 VA: 0x1C015B0 Slot: 5
	public object get_Value() { }

	// RVA: 0x1C01660 Offset: 0x1C01761 VA: 0x1C01660 Slot: 9
	public void Reset() { }
}

