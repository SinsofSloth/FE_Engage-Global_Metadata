// Namespace: System
[Serializable]
internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 360
{
	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0x3727A70 Offset: 0x3727B71 VA: 0x3727A70
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x3727280 Offset: 0x3727381 VA: 0x3727280
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x3727D10 Offset: 0x3727E11 VA: 0x3727D10 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3727D50 Offset: 0x3727E51 VA: 0x3727D50 Slot: 5
	public object GetRealObject(StreamingContext context) { }
}

