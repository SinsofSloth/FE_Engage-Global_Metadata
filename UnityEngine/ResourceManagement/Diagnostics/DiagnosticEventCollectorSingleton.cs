// Namespace: UnityEngine.ResourceManagement.Diagnostics
public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton> // TypeDefIndex: 5608
{
	// Fields
	private static Guid s_editorConnectionGuid; // 0x0
	internal Dictionary<int, DiagnosticEvent> m_CreatedEvents; // 0x18
	internal List<DiagnosticEvent> m_UnhandledEvents; // 0x20
	internal DelegateList<DiagnosticEvent> s_EventHandlers; // 0x28
	private float m_lastTickSent; // 0x30
	private int m_lastFrame; // 0x34
	private float fpsAvg; // 0x38

	// Properties
	public static Guid PlayerConnectionGuid { get; }

	// Methods

	// RVA: 0x362AA40 Offset: 0x362AB41 VA: 0x362AA40
	public static Guid get_PlayerConnectionGuid() { }

	// RVA: 0x362B1A0 Offset: 0x362B2A1 VA: 0x362B1A0 Slot: 4
	protected override string GetGameObjectName() { }

	// RVA: 0x362AD70 Offset: 0x362AE71 VA: 0x362AD70
	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	// RVA: 0x362B1F0 Offset: 0x362B2F1 VA: 0x362B1F0
	internal void RegisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x362AEA0 Offset: 0x362AFA1 VA: 0x362AEA0
	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

	// RVA: 0x362AFD0 Offset: 0x362B0D1 VA: 0x362AFD0
	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	// RVA: 0x362B6A0 Offset: 0x362B7A1 VA: 0x362B6A0
	private void Awake() { }

	// RVA: 0x362B7C0 Offset: 0x362B8C1 VA: 0x362B7C0
	private void Update() { }

	// RVA: 0x362BA40 Offset: 0x362BB41 VA: 0x362BA40
	public void .ctor() { }
}

