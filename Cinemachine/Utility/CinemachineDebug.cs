// Namespace: Cinemachine.Utility
public class CinemachineDebug // TypeDefIndex: 5898
{
	// Fields
	private static HashSet<Object> mClients; // 0x0
	public static CinemachineDebug.OnGUIDelegate OnGUIHandlers; // 0x8
	private static List<StringBuilder> mAvailableStringBuilders; // 0x10

	// Methods

	// RVA: 0x1B96ED0 Offset: 0x1B96FD1 VA: 0x1B96ED0
	public static void ReleaseScreenPos(Object client) { }

	// RVA: 0x1B96F90 Offset: 0x1B97091 VA: 0x1B96F90
	public static Rect GetScreenPos(Object client, string text, GUIStyle style) { }

	// RVA: 0x1B97270 Offset: 0x1B97371 VA: 0x1B97270
	public static StringBuilder SBFromPool() { }

	// RVA: 0x1B97360 Offset: 0x1B97461 VA: 0x1B97360
	public static void ReturnToPool(StringBuilder sb) { }

	// RVA: 0x1B97440 Offset: 0x1B97541 VA: 0x1B97440
	public void .ctor() { }
}

