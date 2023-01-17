// Namespace: System.IO
internal class StringResultHandler : SearchResultHandler<string> // TypeDefIndex: 628
{
	// Fields
	private bool _includeFiles; // 0x10
	private bool _includeDirs; // 0x11

	// Methods

	// RVA: 0x365A900 Offset: 0x365AA01 VA: 0x365A900
	internal void .ctor(bool includeFiles, bool includeDirs) { }

	// RVA: 0x365A980 Offset: 0x365AA81 VA: 0x365A980 Slot: 4
	internal override bool IsResultIncluded(SearchResult result) { }

	// RVA: 0x365A9F0 Offset: 0x365AAF1 VA: 0x365A9F0 Slot: 5
	internal override string CreateObject(SearchResult result) { }
}

