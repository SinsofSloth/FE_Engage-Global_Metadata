// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474550 Offset: 0x474651 VA: 0x474550
public interface ISurrogateSelector // TypeDefIndex: 996
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
}

