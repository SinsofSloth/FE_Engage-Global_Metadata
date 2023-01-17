// Namespace: System.Net
[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 2487
{
	// Properties
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x19529C0 Offset: 0x1952AC1 VA: 0x19529C0
	protected void .ctor() { }

	// RVA: 0x19529D0 Offset: 0x1952AD1 VA: 0x19529D0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x19529E0 Offset: 0x1952AE1 VA: 0x19529E0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x19529F0 Offset: 0x1952AF1 VA: 0x19529F0 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1952A00 Offset: 0x1952B01 VA: 0x1952A00 Slot: 9
	public virtual void Close() { }

	// RVA: 0x1952A10 Offset: 0x1952B11 VA: 0x1952A10 Slot: 7
	public void Dispose() { }

	// RVA: 0x1952A90 Offset: 0x1952B91 VA: 0x1952A90 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1952B30 Offset: 0x1952C31 VA: 0x1952B30 Slot: 11
	public virtual Stream GetResponseStream() { }

	// RVA: 0x1952B60 Offset: 0x1952C61 VA: 0x1952B60 Slot: 12
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x1952B90 Offset: 0x1952C91 VA: 0x1952B90 Slot: 13
	public virtual WebHeaderCollection get_Headers() { }
}

