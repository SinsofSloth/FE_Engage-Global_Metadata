// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x472920 Offset: 0x472A21 VA: 0x472920
[Serializable]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 596
{
	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x365AA00 Offset: 0x365AB01 VA: 0x365AA00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x365ABF0 Offset: 0x365ACF1 VA: 0x365ABF0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x365AD50 Offset: 0x365AE51 VA: 0x365AD50 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}

