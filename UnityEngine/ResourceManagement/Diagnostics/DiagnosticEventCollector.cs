// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollector : MonoBehaviour // TypeDefIndex: 5609
{
	// Fields
	private static DiagnosticEventCollector s_Collector; // 0x0

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x362AA30 Offset: 0x362AB31 VA: 0x362AA30
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x362AB70 Offset: 0x362AC71 VA: 0x362AB70
	public static DiagnosticEventCollector FindOrCreateGlobalInstance() { }

	// RVA: 0x362AD60 Offset: 0x362AE61 VA: 0x362AD60
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x362AE40 Offset: 0x362AF41 VA: 0x362AE40
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x362AF50 Offset: 0x362B051 VA: 0x362AF50
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x362B190 Offset: 0x362B291 VA: 0x362B190
	public void .ctor() { }
}

