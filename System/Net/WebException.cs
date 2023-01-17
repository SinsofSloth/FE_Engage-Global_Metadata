// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 2474
{
	// Fields
	private WebExceptionStatus m_Status; // 0x88
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Properties
	public WebExceptionStatus Status { get; }

	// Methods

	// RVA: 0x1949DF0 Offset: 0x1949EF1 VA: 0x1949DF0
	public void .ctor() { }

	// RVA: 0x1949E00 Offset: 0x1949F01 VA: 0x1949E00
	public void .ctor(string message) { }

	// RVA: 0x1949E20 Offset: 0x1949F21 VA: 0x1949E20
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1946D70 Offset: 0x1946E71 VA: 0x1946D70
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x1946E20 Offset: 0x1946F21 VA: 0x1946E20
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x1949E30 Offset: 0x1949F31 VA: 0x1949E30
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1949FC0 Offset: 0x194A0C1 VA: 0x1949FC0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1949EF0 Offset: 0x1949FF1 VA: 0x1949EF0
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x194A0C0 Offset: 0x194A1C1 VA: 0x194A0C0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x194A1C0 Offset: 0x194A2C1 VA: 0x194A1C0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194A1D0 Offset: 0x194A2D1 VA: 0x194A1D0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194A1E0 Offset: 0x194A2E1 VA: 0x194A1E0 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194A1F0 Offset: 0x194A2F1 VA: 0x194A1F0
	public WebExceptionStatus get_Status() { }
}

