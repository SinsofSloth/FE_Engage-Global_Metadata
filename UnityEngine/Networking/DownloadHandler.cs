// Namespace: UnityEngine.Networking
[NativeHeaderAttribute] // RVA: 0x6BDC0 Offset: 0x6BEC1 VA: 0x6BDC0
public class DownloadHandler : IDisposable // TypeDefIndex: 4446
{
	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x6BFC0 Offset: 0x6C0C1 VA: 0x6BFC0
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string error { get; }
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x6C280 Offset: 0x6C381 VA: 0x6C280
	// RVA: 0x1C48620 Offset: 0x1C48721 VA: 0x1C48620
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6C2C0 Offset: 0x6C3C1 VA: 0x6C2C0
	// RVA: 0x1C48670 Offset: 0x1C48771 VA: 0x1C48670
	internal void .ctor() { }

	// RVA: 0x1C48680 Offset: 0x1C48781 VA: 0x1C48680 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1C48750 Offset: 0x1C48851 VA: 0x1C48750 Slot: 4
	public void Dispose() { }

	// RVA: 0x1C487D0 Offset: 0x1C488D1 VA: 0x1C487D0
	public string get_error() { }

	// RVA: 0x1C48820 Offset: 0x1C48921 VA: 0x1C48820
	private string GetErrorMsg() { }

	// RVA: 0x1C48870 Offset: 0x1C48971 VA: 0x1C48870
	public byte[] get_data() { }

	// RVA: 0x1C48880 Offset: 0x1C48981 VA: 0x1C48880
	public string get_text() { }

	// RVA: 0x1C48890 Offset: 0x1C48991 VA: 0x1C48890 Slot: 5
	protected virtual byte[] GetData() { }

	// RVA: 0x1C488A0 Offset: 0x1C489A1 VA: 0x1C488A0 Slot: 6
	protected virtual string GetText() { }

	// RVA: 0x1C48940 Offset: 0x1C48A41 VA: 0x1C48940
	private Encoding GetTextEncoder() { }

	// RVA: 0x1C48BD0 Offset: 0x1C48CD1 VA: 0x1C48BD0
	private string GetContentType() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6C2D0 Offset: 0x6C3D1 VA: 0x6C2D0
	// RVA: 0x1C48C20 Offset: 0x1C48D21 VA: 0x1C48C20 Slot: 7
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[ObsoleteAttribute] // RVA: 0x6C2E0 Offset: 0x6C3E1 VA: 0x6C2E0
	// RVA: 0x1C48C30 Offset: 0x1C48D31 VA: 0x1C48C30 Slot: 8
	protected virtual void ReceiveContentLength(int contentLength) { }

	[NativeThrowsAttribute] // RVA: 0x6C320 Offset: 0x6C421 VA: 0x6C320
	[VisibleToOtherModulesAttribute] // RVA: 0x6C320 Offset: 0x6C421 VA: 0x6C320
	// RVA: 0x1C48C40 Offset: 0x1C48D41 VA: 0x1C48C40
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }
}

