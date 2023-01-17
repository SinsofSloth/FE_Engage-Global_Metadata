// Namespace: System.Net
internal class FtpStatus // TypeDefIndex: 2549
{
	// Fields
	private readonly FtpStatusCode statusCode; // 0x10
	private readonly string statusDescription; // 0x18

	// Properties
	public FtpStatusCode StatusCode { get; }
	public string StatusDescription { get; }

	// Methods

	// RVA: 0x1AE1160 Offset: 0x1AE1261 VA: 0x1AE1160
	public void .ctor(FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1AE11B0 Offset: 0x1AE12B1 VA: 0x1AE11B0
	public FtpStatusCode get_StatusCode() { }

	// RVA: 0x1AE11C0 Offset: 0x1AE12C1 VA: 0x1AE11C0
	public string get_StatusDescription() { }
}

