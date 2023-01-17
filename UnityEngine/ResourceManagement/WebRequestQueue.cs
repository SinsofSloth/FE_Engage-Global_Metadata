// Namespace: UnityEngine.ResourceManagement
internal static class WebRequestQueue // TypeDefIndex: 5548
{
	// Fields
	internal static int s_MaxRequest; // 0x0
	internal static Queue<WebRequestQueueOperation> s_QueuedOperations; // 0x8
	internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests; // 0x10

	// Methods

	// RVA: 0x3637CE0 Offset: 0x3637DE1 VA: 0x3637CE0
	public static void SetMaxConcurrentRequests(int maxRequests) { }

	// RVA: 0x3625D00 Offset: 0x3625E01 VA: 0x3625D00
	public static WebRequestQueueOperation QueueRequest(UnityWebRequest request) { }

	// RVA: 0x3637DF0 Offset: 0x3637EF1 VA: 0x3637DF0
	private static void OnWebAsyncOpComplete(AsyncOperation operation) { }

	// RVA: 0x36380C0 Offset: 0x36381C1 VA: 0x36380C0
	private static void .cctor() { }
}

