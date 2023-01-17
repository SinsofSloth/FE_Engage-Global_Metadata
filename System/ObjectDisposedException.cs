// Namespace: System
[ComVisibleAttribute] // RVA: 0x470720 Offset: 0x470821 VA: 0x470720
[Serializable]
public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 283
{
	// Fields
	private string objectName; // 0x88

	// Properties
	public override string Message { get; }
	public string ObjectName { get; }

	// Methods

	// RVA: 0x3863220 Offset: 0x3863321 VA: 0x3863220
	private void .ctor() { }

	// RVA: 0x3863300 Offset: 0x3863401 VA: 0x3863300
	public void .ctor(string objectName) { }

	// RVA: 0x38632B0 Offset: 0x38633B1 VA: 0x38632B0
	public void .ctor(string objectName, string message) { }

	// RVA: 0x3863390 Offset: 0x3863491 VA: 0x3863390 Slot: 5
	public override string get_Message() { }

	// RVA: 0x3863520 Offset: 0x3863621 VA: 0x3863520
	public string get_ObjectName() { }

	// RVA: 0x38635C0 Offset: 0x38636C1 VA: 0x38635C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3863660 Offset: 0x3863761 VA: 0x3863660 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

