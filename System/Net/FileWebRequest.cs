// Namespace: System.Net
[Serializable]
public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 2521
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private IWebProxy m_proxy; // 0x68
	private ManualResetEvent m_readerEvent; // 0x70
	private bool m_readPending; // 0x78
	private WebResponse m_response; // 0x80
	private Stream m_stream; // 0x88
	private bool m_syncHint; // 0x90
	private int m_timeout; // 0x94
	private Uri m_uri; // 0x98
	private bool m_writePending; // 0xA0
	private bool m_writing; // 0xA1
	private LazyAsyncResult m_WriteAResult; // 0xA8
	private LazyAsyncResult m_ReadAResult; // 0xB0
	private int m_Aborted; // 0xB8

	// Properties
	internal bool Aborted { get; }
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; }

	// Methods

	// RVA: 0x1ADBAB0 Offset: 0x1ADBBB1 VA: 0x1ADBAB0
	internal void .ctor(Uri uri) { }

	[ObsoleteAttribute] // RVA: 0x323C0 Offset: 0x324C1 VA: 0x323C0
	// RVA: 0x1ADBC50 Offset: 0x1ADBD51 VA: 0x1ADBC50
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1ADC010 Offset: 0x1ADC111 VA: 0x1ADC010 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1ADC020 Offset: 0x1ADC121 VA: 0x1ADC020 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1ADC2E0 Offset: 0x1ADC3E1 VA: 0x1ADC2E0
	internal bool get_Aborted() { }

	// RVA: 0x1ADC2F0 Offset: 0x1ADC3F1 VA: 0x1ADC2F0 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x1ADC300 Offset: 0x1ADC401 VA: 0x1ADC300 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x1ADC310 Offset: 0x1ADC411 VA: 0x1ADC310 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1ADC320 Offset: 0x1ADC421 VA: 0x1ADC320 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1ADC330 Offset: 0x1ADC431 VA: 0x1ADC330 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1ADC340 Offset: 0x1ADC441 VA: 0x1ADC340 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1ADC430 Offset: 0x1ADC531 VA: 0x1ADC430 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1ADC440 Offset: 0x1ADC541 VA: 0x1ADC440 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1ADC450 Offset: 0x1ADC551 VA: 0x1ADC450 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x1ADC460 Offset: 0x1ADC561 VA: 0x1ADC460 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1ADC470 Offset: 0x1ADC571 VA: 0x1ADC470 Slot: 23
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	// RVA: 0x1ADC9C0 Offset: 0x1ADCAC1 VA: 0x1ADC9C0 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1ADC940 Offset: 0x1ADCA41 VA: 0x1ADC940
	private bool CanGetRequestStream() { }

	// RVA: 0x1ADCD80 Offset: 0x1ADCE81 VA: 0x1ADCD80 Slot: 24
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	// RVA: 0x1ADD080 Offset: 0x1ADD181 VA: 0x1ADD080 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1ADD380 Offset: 0x1ADD481 VA: 0x1ADD380 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1ADD6E0 Offset: 0x1ADD7E1 VA: 0x1ADD6E0
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x1ADDA00 Offset: 0x1ADDB01 VA: 0x1ADDA00
	private static void GetResponseCallback(object state) { }

	// RVA: 0x1ADE060 Offset: 0x1ADE161 VA: 0x1ADE060
	internal void UnblockReader() { }

	// RVA: 0x1ADE140 Offset: 0x1ADE241 VA: 0x1ADE140 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1ADE170 Offset: 0x1ADE271 VA: 0x1ADE170 Slot: 26
	public override void Abort() { }

	// RVA: 0x1ADE4D0 Offset: 0x1ADE5D1 VA: 0x1ADE4D0
	private static void .cctor() { }
}

