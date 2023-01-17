// Namespace: System.Net
[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 2524
{
	// Fields
	private bool m_closed; // 0x18
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x1ADDD20 Offset: 0x1ADDE21 VA: 0x1ADDD20
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[ObsoleteAttribute] // RVA: 0x32400 Offset: 0x32501 VA: 0x32400
	// RVA: 0x1ADE710 Offset: 0x1ADE811 VA: 0x1ADE710
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1ADE950 Offset: 0x1ADEA51 VA: 0x1ADE950 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1ADE960 Offset: 0x1ADEA61 VA: 0x1ADE960 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1ADEB30 Offset: 0x1ADEC31 VA: 0x1ADEB30 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1ADEC30 Offset: 0x1ADED31 VA: 0x1ADEC30 Slot: 12
	public override Uri get_ResponseUri() { }

	// RVA: 0x1ADEBB0 Offset: 0x1ADECB1 VA: 0x1ADEBB0
	private void CheckDisposed() { }

	// RVA: 0x1ADECB0 Offset: 0x1ADEDB1 VA: 0x1ADECB0 Slot: 9
	public override void Close() { }

	// RVA: 0x1ADED60 Offset: 0x1ADEE61 VA: 0x1ADED60 Slot: 14
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1ADEEC0 Offset: 0x1ADEFC1 VA: 0x1ADEEC0 Slot: 11
	public override Stream GetResponseStream() { }
}

