// Namespace: App
internal class VersusSendReportSequence : ProcInst // TypeDefIndex: 13735
{
	// Fields
	private VersusSendReportSequence.UploadInfo m_Info; // 0x70
	private VersusSendReportSequence.EndCallback m_EndCallback; // 0x78
	private bool m_IsSucceed; // 0x80
	private static int s_SendCount; // 0x0
	private const int MAX_SEND_COUNT = 10;

	// Methods

	// RVA: 0x2A52240 Offset: 0x2A52341 VA: 0x2A52240
	private void .ctor(VersusSendReportSequence.UploadInfo info, VersusSendReportSequence.EndCallback endCallback) { }

	// RVA: 0x2A52290 Offset: 0x2A52391 VA: 0x2A52290
	private void SendReport() { }

	// RVA: 0x2A52380 Offset: 0x2A52481 VA: 0x2A52380
	private void AddList() { }

	// RVA: 0x2A52410 Offset: 0x2A52511 VA: 0x2A52410
	private NexVersus.Results GetResult(out string message) { }

	// RVA: 0x2A524B0 Offset: 0x2A525B1 VA: 0x2A524B0
	private void Branch() { }

	// RVA: 0x2A525C0 Offset: 0x2A526C1 VA: 0x2A525C0
	private void Invoke() { }

	// RVA: 0x2A50910 Offset: 0x2A50A11 VA: 0x2A50910
	public static void CreateBind(ProcInst super, VersusSendReportSequence.UploadInfo info, VersusSendReportSequence.EndCallback endCallback) { }

	// RVA: 0x2A525E0 Offset: 0x2A526E1 VA: 0x2A525E0
	private static void .cctor() { }
}

