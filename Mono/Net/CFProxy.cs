// Namespace: Mono.Net
internal class CFProxy // TypeDefIndex: 2171
{
	// Fields
	private static IntPtr kCFProxyAutoConfigurationJavaScriptKey; // 0x0
	private static IntPtr kCFProxyAutoConfigurationURLKey; // 0x8
	private static IntPtr kCFProxyHostNameKey; // 0x10
	private static IntPtr kCFProxyPasswordKey; // 0x18
	private static IntPtr kCFProxyPortNumberKey; // 0x20
	private static IntPtr kCFProxyTypeKey; // 0x28
	private static IntPtr kCFProxyUsernameKey; // 0x30
	private static IntPtr kCFProxyTypeAutoConfigurationURL; // 0x38
	private static IntPtr kCFProxyTypeAutoConfigurationJavaScript; // 0x40
	private static IntPtr kCFProxyTypeFTP; // 0x48
	private static IntPtr kCFProxyTypeHTTP; // 0x50
	private static IntPtr kCFProxyTypeHTTPS; // 0x58
	private static IntPtr kCFProxyTypeSOCKS; // 0x60
	private CFDictionary settings; // 0x10

	// Properties
	public IntPtr AutoConfigurationJavaScript { get; }
	public IntPtr AutoConfigurationUrl { get; }
	public string HostName { get; }
	public string Password { get; }
	public int Port { get; }
	public CFProxyType ProxyType { get; }
	public string Username { get; }

	// Methods

	// RVA: 0x1B46200 Offset: 0x1B46301 VA: 0x1B46200
	private static void .cctor() { }

	// RVA: 0x1B44520 Offset: 0x1B44621 VA: 0x1B44520
	internal void .ctor(CFDictionary settings) { }

	// RVA: 0x1B46590 Offset: 0x1B46691 VA: 0x1B46590
	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	// RVA: 0x1B46780 Offset: 0x1B46881 VA: 0x1B46780
	public IntPtr get_AutoConfigurationJavaScript() { }

	// RVA: 0x1B46900 Offset: 0x1B46A01 VA: 0x1B46900
	public IntPtr get_AutoConfigurationUrl() { }

	// RVA: 0x1B46A80 Offset: 0x1B46B81 VA: 0x1B46A80
	public string get_HostName() { }

	// RVA: 0x1B46EA0 Offset: 0x1B46FA1 VA: 0x1B46EA0
	public string get_Password() { }

	// RVA: 0x1B47020 Offset: 0x1B47121 VA: 0x1B47020
	public int get_Port() { }

	// RVA: 0x1B47250 Offset: 0x1B47351 VA: 0x1B47250
	public CFProxyType get_ProxyType() { }

	// RVA: 0x1B473D0 Offset: 0x1B474D1 VA: 0x1B473D0
	public string get_Username() { }
}

