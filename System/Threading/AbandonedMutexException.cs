// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x4732A0 Offset: 0x4733A1 VA: 0x4732A0
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 750
{
	// Fields
	private int m_MutexIndex; // 0x88
	private Mutex m_Mutex; // 0x90

	// Methods

	// RVA: 0x3559500 Offset: 0x3559601 VA: 0x3559500
	public void .ctor() { }

	// RVA: 0x3559580 Offset: 0x3559681 VA: 0x3559580
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x3559670 Offset: 0x3559771 VA: 0x3559670
	private void SetupException(int location, WaitHandle handle) { }

	// RVA: 0x3559700 Offset: 0x3559801 VA: 0x3559700
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

