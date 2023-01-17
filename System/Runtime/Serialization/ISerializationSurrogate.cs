// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474530 Offset: 0x474631 VA: 0x474530
public interface ISerializationSurrogate // TypeDefIndex: 995
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
}

