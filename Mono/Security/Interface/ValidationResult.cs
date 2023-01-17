// Namespace: Mono.Security.Interface
public class ValidationResult // TypeDefIndex: 1554
{
	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x1BD9C30 Offset: 0x1BD9D31 VA: 0x1BD9C30
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x1BD9C90 Offset: 0x1BD9D91 VA: 0x1BD9C90
	public bool get_Trusted() { }

	// RVA: 0x1BD9CA0 Offset: 0x1BD9DA1 VA: 0x1BD9CA0
	public bool get_UserDenied() { }
}

