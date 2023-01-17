// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474760 Offset: 0x474861 VA: 0x474760
[Serializable]
public class SerializationException : SystemException // TypeDefIndex: 1018
{
	// Fields
	private static string _nullMessage; // 0x0

	// Methods

	// RVA: 0x36192C0 Offset: 0x36193C1 VA: 0x36192C0
	public void .ctor() { }

	// RVA: 0x3607670 Offset: 0x3607771 VA: 0x3607670
	public void .ctor(string message) { }

	// RVA: 0x3619350 Offset: 0x3619451 VA: 0x3619350
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x3619390 Offset: 0x3619491 VA: 0x3619390
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x36193A0 Offset: 0x36194A1 VA: 0x36193A0
	private static void .cctor() { }
}

