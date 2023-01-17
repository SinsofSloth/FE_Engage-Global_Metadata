// Namespace: 
[Serializable]
private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1372
{
	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x35F2950 Offset: 0x35F2A51 VA: 0x35F2950
	internal void .ctor(Queue q) { }

	// RVA: 0x35F29E0 Offset: 0x35F2AE1 VA: 0x35F29E0 Slot: 7
	public object Clone() { }

	// RVA: 0x35F29F0 Offset: 0x35F2AF1 VA: 0x35F29F0 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x35F2AE0 Offset: 0x35F2BE1 VA: 0x35F2AE0 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x35F2B80 Offset: 0x35F2C81 VA: 0x35F2B80 Slot: 10
	public virtual void Reset() { }
}

