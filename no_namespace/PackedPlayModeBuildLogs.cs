// Namespace: 
[Serializable]
public struct PackedPlayModeBuildLogs.RuntimeBuildLog // TypeDefIndex: 7247
{
	// Fields
	public LogType Type; // 0x0
	public string Message; // 0x8

	// Methods

	// RVA: 0x30A3330 Offset: 0x30A3431 VA: 0x30A3330
	public void .ctor(LogType type, string message) { }
}

// Namespace: 
[Serializable]
public class PackedPlayModeBuildLogs // TypeDefIndex: 7248
{
	// Fields
	[SerializeField] // RVA: 0x65590 Offset: 0x65691 VA: 0x65590
	private List<PackedPlayModeBuildLogs.RuntimeBuildLog> m_RuntimeBuildLogs; // 0x10

	// Properties
	public List<PackedPlayModeBuildLogs.RuntimeBuildLog> RuntimeBuildLogs { get; set; }

	// Methods

	// RVA: 0x309E1D0 Offset: 0x309E2D1 VA: 0x309E1D0
	public List<PackedPlayModeBuildLogs.RuntimeBuildLog> get_RuntimeBuildLogs() { }

	// RVA: 0x309E1E0 Offset: 0x309E2E1 VA: 0x309E1E0
	public void set_RuntimeBuildLogs(List<PackedPlayModeBuildLogs.RuntimeBuildLog> value) { }

	// RVA: 0x309E1F0 Offset: 0x309E2F1 VA: 0x309E1F0
	public void .ctor() { }
}

