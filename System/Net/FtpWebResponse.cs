// Namespace: System.Net
public class FtpWebResponse : WebResponse // TypeDefIndex: 2552
{
	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x1AE3230 Offset: 0x1AE3331 VA: 0x1AE3230
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x1AE21A0 Offset: 0x1AE22A1 VA: 0x1AE21A0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1AE69E0 Offset: 0x1AE6AE1 VA: 0x1AE69E0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x1AE77A0 Offset: 0x1AE78A1 VA: 0x1AE77A0 Slot: 13
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1AE7800 Offset: 0x1AE7901 VA: 0x1AE7800 Slot: 12
	public override Uri get_ResponseUri() { }

	// RVA: 0x1AE7810 Offset: 0x1AE7911 VA: 0x1AE7810
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x1AE7820 Offset: 0x1AE7921 VA: 0x1AE7820
	internal void set_BannerMessage(string value) { }

	// RVA: 0x1AE7830 Offset: 0x1AE7931 VA: 0x1AE7830
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x1AE7840 Offset: 0x1AE7941 VA: 0x1AE7840
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x1AE7850 Offset: 0x1AE7951 VA: 0x1AE7850 Slot: 9
	public override void Close() { }

	// RVA: 0x1AE7950 Offset: 0x1AE7A51 VA: 0x1AE7950 Slot: 11
	public override Stream GetResponseStream() { }

	// RVA: 0x1AE7B10 Offset: 0x1AE7C11 VA: 0x1AE7B10
	internal void set_Stream(Stream value) { }

	// RVA: 0x1AE2F80 Offset: 0x1AE3081 VA: 0x1AE2F80
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1AE7A90 Offset: 0x1AE7B91 VA: 0x1AE7A90
	private void CheckDisposed() { }

	// RVA: 0x1AE3D60 Offset: 0x1AE3E61 VA: 0x1AE3D60
	internal bool IsFinal() { }
}

