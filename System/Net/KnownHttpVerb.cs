// Namespace: System.Net
internal class KnownHttpVerb // TypeDefIndex: 2470
{
	// Fields
	internal string Name; // 0x10
	internal bool RequireContentBody; // 0x18
	internal bool ContentBodyNotAllowed; // 0x19
	internal bool ConnectRequest; // 0x1A
	internal bool ExpectNoContentResponse; // 0x1B
	private static ListDictionary NamedHeaders; // 0x0
	internal static KnownHttpVerb Get; // 0x8
	internal static KnownHttpVerb Connect; // 0x10
	internal static KnownHttpVerb Head; // 0x18
	internal static KnownHttpVerb Put; // 0x20
	internal static KnownHttpVerb Post; // 0x28
	internal static KnownHttpVerb MkCol; // 0x30

	// Methods

	// RVA: 0x1AC26F0 Offset: 0x1AC27F1 VA: 0x1AC26F0
	internal void .ctor(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse) { }

	// RVA: 0x1AC2770 Offset: 0x1AC2871 VA: 0x1AC2770
	private static void .cctor() { }

	// RVA: 0x1AC2D40 Offset: 0x1AC2E41 VA: 0x1AC2D40
	public static KnownHttpVerb Parse(string name) { }
}

