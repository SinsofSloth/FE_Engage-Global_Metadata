// Namespace: System.IO
internal sealed class SearchResult // TypeDefIndex: 629
{
	// Fields
	private string fullPath; // 0x10
	private string userPath; // 0x18
	private Win32Native.WIN32_FIND_DATA findData; // 0x20

	// Properties
	internal string UserPath { get; }
	internal Win32Native.WIN32_FIND_DATA FindData { get; }

	// Methods

	// RVA: 0x3611D60 Offset: 0x3611E61 VA: 0x3611D60
	internal void .ctor(string fullPath, string userPath, Win32Native.WIN32_FIND_DATA findData) { }

	// RVA: 0x3611DD0 Offset: 0x3611ED1 VA: 0x3611DD0
	internal string get_UserPath() { }

	// RVA: 0x3611DE0 Offset: 0x3611EE1 VA: 0x3611DE0
	internal Win32Native.WIN32_FIND_DATA get_FindData() { }
}

