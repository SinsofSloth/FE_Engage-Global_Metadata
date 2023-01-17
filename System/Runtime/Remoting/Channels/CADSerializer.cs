// Namespace: System.Runtime.Remoting.Channels
internal class CADSerializer // TypeDefIndex: 1154
{
	// Methods

	// RVA: 0x3511BA0 Offset: 0x3511CA1 VA: 0x3511BA0
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	// RVA: 0x3511BE0 Offset: 0x3511CE1 VA: 0x3511BE0
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	// RVA: 0x350EEE0 Offset: 0x350EFE1 VA: 0x350EEE0
	internal static object DeserializeObjectSafe(byte[] mem) { }

	// RVA: 0x350ED00 Offset: 0x350EE01 VA: 0x350ED00
	internal static MemoryStream SerializeObject(object obj) { }

	// RVA: 0x3511200 Offset: 0x3511301 VA: 0x3511200
	internal static object DeserializeObject(MemoryStream mem) { }
}

