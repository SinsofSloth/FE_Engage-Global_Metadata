// Namespace: System.Text.RegularExpressions
[Serializable]
public class Group : Capture // TypeDefIndex: 2260
{
	// Fields
	internal static Group _emptygroup; // 0x0
	internal int[] _caps; // 0x20
	internal int _capcount; // 0x28
	[OptionalFieldAttribute] // RVA: 0x31580 Offset: 0x31681 VA: 0x31580
	internal string _name; // 0x30

	// Properties
	public bool Success { get; }

	// Methods

	// RVA: 0x1AE83B0 Offset: 0x1AE84B1 VA: 0x1AE83B0
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public bool get_Success() { }

	// RVA: 0x1AE8460 Offset: 0x1AE8561 VA: 0x1AE8460
	private static void .cctor() { }

	// RVA: 0x1AE8560 Offset: 0x1AE8661 VA: 0x1AE8560
	internal void .ctor() { }
}

