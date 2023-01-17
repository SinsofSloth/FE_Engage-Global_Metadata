// Namespace: System.Runtime.CompilerServices
[Serializable]
public sealed class RuntimeWrappedException : Exception // TypeDefIndex: 1253
{
	// Fields
	private object m_wrappedException; // 0x88

	// Properties
	public object WrappedException { get; }

	// Methods

	// RVA: 0x3607D30 Offset: 0x3607E31 VA: 0x3607D30
	private void .ctor(object thrownObject) { }

	// RVA: 0x3607E00 Offset: 0x3607F01 VA: 0x3607E00
	public object get_WrappedException() { }

	// RVA: 0x3607E10 Offset: 0x3607F11 VA: 0x3607E10 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3607F40 Offset: 0x3608041 VA: 0x3607F40
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3608060 Offset: 0x3608161 VA: 0x3608060
	internal void .ctor() { }
}

