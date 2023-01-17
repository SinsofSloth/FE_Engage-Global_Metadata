// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x7E6B0 Offset: 0x7E7B1 VA: 0x7E6B0
public static class JsonUtility // TypeDefIndex: 4791
{
	// Methods

	[FreeFunctionAttribute] // RVA: 0x7E6F0 Offset: 0x7E7F1 VA: 0x7E6F0
	[ThreadSafeAttribute] // RVA: 0x7E6F0 Offset: 0x7E7F1 VA: 0x7E6F0
	// RVA: 0x3F0D680 Offset: 0x3F0D781 VA: 0x3F0D680
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[ThreadSafeAttribute] // RVA: 0x7E740 Offset: 0x7E841 VA: 0x7E740
	[FreeFunctionAttribute] // RVA: 0x7E740 Offset: 0x7E841 VA: 0x7E740
	// RVA: 0x3F0D6D0 Offset: 0x3F0D7D1 VA: 0x3F0D6D0
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	// RVA: 0x3F0D730 Offset: 0x3F0D831 VA: 0x3F0D730
	public static string ToJson(object obj) { }

	// RVA: 0x3F0D740 Offset: 0x3F0D841 VA: 0x3F0D740
	public static string ToJson(object obj, bool prettyPrint) { }

	// RVA: -1 Offset: -1
	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295A0B0 Offset: 0x295A1B1 VA: 0x295A0B0
	|-JsonUtility.FromJson<ContentCatalogData>
	|-JsonUtility.FromJson<object>
	|-JsonUtility.FromJson<PackedPlayModeBuildLogs>
	|
	|-RVA: 0x2959FB0 Offset: 0x295A0B1 VA: 0x2959FB0
	|-JsonUtility.FromJson<DiagnosticEvent>
	*/

	// RVA: 0x3F0D8C0 Offset: 0x3F0D9C1 VA: 0x3F0D8C0
	public static object FromJson(string json, Type type) { }
}

