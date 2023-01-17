// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x475380 Offset: 0x475481 VA: 0x475380
public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 1219
{
	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x321DC30 Offset: 0x321DD31 VA: 0x321DC30
	public void .ctor() { }

	// RVA: 0x3221F30 Offset: 0x3222031 VA: 0x3221F30 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x3222100 Offset: 0x3222201 VA: 0x3222100
	private static void .cctor() { }
}

