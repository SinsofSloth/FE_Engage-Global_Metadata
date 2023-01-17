// Namespace: System.Net
[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 2563
{
	// Fields
	private Uri uri; // 0x18
	private WebHeaderCollection webHeaders; // 0x20
	private CookieCollection cookieCollection; // 0x28
	private string method; // 0x30
	private Version version; // 0x38
	private HttpStatusCode statusCode; // 0x40
	private string statusDescription; // 0x48
	private long contentLength; // 0x50
	private string contentType; // 0x58
	private CookieContainer cookie_container; // 0x60
	private bool disposed; // 0x68
	private Stream stream; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x1AF0A50 Offset: 0x1AF0B51 VA: 0x1AF0A50
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x1AF0B50 Offset: 0x1AF0C51 VA: 0x1AF0B50
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[ObsoleteAttribute] // RVA: 0x327D0 Offset: 0x328D1 VA: 0x327D0
	// RVA: 0x1AF10A0 Offset: 0x1AF11A1 VA: 0x1AF10A0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1AF1450 Offset: 0x1AF1551 VA: 0x1AF1450 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1AF1460 Offset: 0x1AF1561 VA: 0x1AF1460 Slot: 12
	public override Uri get_ResponseUri() { }

	// RVA: 0x1AF1560 Offset: 0x1AF1661 VA: 0x1AF1560 Slot: 14
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1AF1570 Offset: 0x1AF1671 VA: 0x1AF1570 Slot: 15
	public virtual string get_StatusDescription() { }

	// RVA: 0x1AF15F0 Offset: 0x1AF16F1 VA: 0x1AF15F0 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1AF16F0 Offset: 0x1AF17F1 VA: 0x1AF16F0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1AF1700 Offset: 0x1AF1801 VA: 0x1AF1700 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1AF18D0 Offset: 0x1AF19D1 VA: 0x1AF18D0 Slot: 9
	public override void Close() { }

	// RVA: 0x1AF1910 Offset: 0x1AF1A11 VA: 0x1AF1910 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF1920 Offset: 0x1AF1A21 VA: 0x1AF1920 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AF14E0 Offset: 0x1AF15E1 VA: 0x1AF14E0
	private void CheckDisposed() { }

	// RVA: 0x1AF0E80 Offset: 0x1AF0F81 VA: 0x1AF0E80
	private void FillCookies() { }

	[EditorBrowsableAttribute] // RVA: 0x32810 Offset: 0x32911 VA: 0x32810
	[ObsoleteAttribute] // RVA: 0x32810 Offset: 0x32911 VA: 0x32810
	// RVA: 0x1AF1940 Offset: 0x1AF1A41 VA: 0x1AF1940
	public void .ctor() { }
}

