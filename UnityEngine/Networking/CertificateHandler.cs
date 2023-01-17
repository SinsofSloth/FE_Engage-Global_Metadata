// Namespace: UnityEngine.Networking
[NativeHeaderAttribute] // RVA: 0x6BD80 Offset: 0x6BE81 VA: 0x6BD80
public class CertificateHandler // TypeDefIndex: 4445
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethodAttribute] // RVA: 0x6C230 Offset: 0x6C331 VA: 0x6C230
	// RVA: 0x1C48530 Offset: 0x1C48631 VA: 0x1C48530
	private void Release() { }

	// RVA: 0x1C48580 Offset: 0x1C48681 VA: 0x1C48580 Slot: 4
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6C270 Offset: 0x6C371 VA: 0x6C270
	// RVA: 0x1C48590 Offset: 0x1C48691 VA: 0x1C48590
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x1C485A0 Offset: 0x1C486A1 VA: 0x1C485A0 Slot: 5
	public void Dispose() { }
}

