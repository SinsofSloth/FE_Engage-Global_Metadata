// Namespace: 
[Serializable]
private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1382
{
	// Fields
	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x1C04990 Offset: 0x1C04A91 VA: 0x1C04990
	internal void .ctor(Stack stack) { }

	// RVA: 0x1C049F0 Offset: 0x1C04AF1 VA: 0x1C049F0 Slot: 7
	public object Clone() { }

	// RVA: 0x1C04A00 Offset: 0x1C04B01 VA: 0x1C04A00 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x1C04B00 Offset: 0x1C04C01 VA: 0x1C04B00 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x1C04B90 Offset: 0x1C04C91 VA: 0x1C04B90 Slot: 10
	public virtual void Reset() { }
}

