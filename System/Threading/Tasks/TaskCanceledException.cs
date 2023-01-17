// Namespace: System.Threading.Tasks
[Serializable]
public class TaskCanceledException : OperationCanceledException // TypeDefIndex: 847
{
	// Fields
	private Task m_canceledTask; // 0x90

	// Methods

	// RVA: 0x3668D00 Offset: 0x3668E01 VA: 0x3668D00
	public void .ctor() { }

	// RVA: 0x3663370 Offset: 0x3663471 VA: 0x3663370
	public void .ctor(Task task) { }

	// RVA: 0x3668D70 Offset: 0x3668E71 VA: 0x3668D70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

