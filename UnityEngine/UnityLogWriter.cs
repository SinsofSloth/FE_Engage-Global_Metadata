// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43D730 Offset: 0x43D831 VA: 0x43D730
internal class UnityLogWriter : TextWriter // TypeDefIndex: 3535
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x44E090 Offset: 0x44E191 VA: 0x44E090
	// RVA: 0x384C170 Offset: 0x384C271 VA: 0x384C170
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] // RVA: 0x44E0A0 Offset: 0x44E1A1 VA: 0x44E0A0
	// RVA: 0x384C1D0 Offset: 0x384C2D1 VA: 0x384C1D0
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x384C220 Offset: 0x384C321 VA: 0x384C220
	public static void Init() { }

	// RVA: 0x384C370 Offset: 0x384C471 VA: 0x384C370 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x384C380 Offset: 0x384C481 VA: 0x384C380 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x384C3E0 Offset: 0x384C4E1 VA: 0x384C3E0 Slot: 15
	public override void Write(string s) { }

	// RVA: 0x384C440 Offset: 0x384C541 VA: 0x384C440 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x384C300 Offset: 0x384C401 VA: 0x384C300
	public void .ctor() { }
}

