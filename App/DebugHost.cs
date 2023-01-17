// Namespace: App
public static class DebugHost // TypeDefIndex: 9099
{
	// Properties
	public static bool IsConnected { get; }
	public static string Root { get; }

	// Methods

	// RVA: 0x2E9D5D0 Offset: 0x2E9D6D1 VA: 0x2E9D5D0
	public static void Setup(string root) { }

	// RVA: 0x2E9D5E0 Offset: 0x2E9D6E1 VA: 0x2E9D5E0
	public static void Cleanup() { }

	// RVA: 0x2E9D5F0 Offset: 0x2E9D6F1 VA: 0x2E9D5F0
	public static bool HasEnv(string name) { }

	// RVA: 0x2E9D600 Offset: 0x2E9D701 VA: 0x2E9D600
	public static string GetEnv(string name) { }

	// RVA: 0x2E9D610 Offset: 0x2E9D711 VA: 0x2E9D610
	public static string GetUserName() { }

	// RVA: 0x2E9D620 Offset: 0x2E9D721 VA: 0x2E9D620
	public static bool get_IsConnected() { }

	// RVA: 0x2E9D630 Offset: 0x2E9D731 VA: 0x2E9D630
	public static string get_Root() { }

	// RVA: 0x2E9D640 Offset: 0x2E9D741 VA: 0x2E9D640
	public static bool WriteToHost(string path, string text) { }

	// RVA: 0x2E9D650 Offset: 0x2E9D751 VA: 0x2E9D650
	public static bool WriteToHost(string path, byte[] data) { }

	// RVA: 0x2E9D660 Offset: 0x2E9D761 VA: 0x2E9D660
	public static bool WriteToSdCard(string path, string text) { }

	// RVA: 0x2E9D670 Offset: 0x2E9D771 VA: 0x2E9D670
	public static bool WriteToSdCard(string path, byte[] data) { }

	// RVA: 0x2E9D680 Offset: 0x2E9D781 VA: 0x2E9D680
	public static bool Exists(string path) { }

	// RVA: 0x2E9D690 Offset: 0x2E9D791 VA: 0x2E9D690
	public static byte[] Load(string path) { }
}

