// Namespace: System
[DefaultMemberAttribute] // RVA: 0x4702B0 Offset: 0x4703B1 VA: 0x4702B0
internal struct DTSubString // TypeDefIndex: 233
{
	// Fields
	internal string s; // 0x0
	internal int index; // 0x8
	internal int length; // 0xC
	internal DTSubStringType type; // 0x10
	internal int value; // 0x14

	// Properties
	internal char Item { get; }

	// Methods

	// RVA: 0x35B03E0 Offset: 0x35B04E1 VA: 0x35B03E0
	internal char get_Item(int relativeIndex) { }
}

