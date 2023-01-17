// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2 // TypeDefIndex: 1543
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1BC8AE0 Offset: 0x1BC8BE1 VA: 0x1BC8AE0
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1BC92B0 Offset: 0x1BC93B1 VA: 0x1BC92B0
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1BC93E0 Offset: 0x1BC94E1 VA: 0x1BC93E0
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1BC9460 Offset: 0x1BC9561 VA: 0x1BC9460
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1BC9680 Offset: 0x1BC9781 VA: 0x1BC9680
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1BC9CC0 Offset: 0x1BC9DC1 VA: 0x1BC9CC0
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1BC8FC0 Offset: 0x1BC90C1 VA: 0x1BC8FC0
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1BCA0C0 Offset: 0x1BCA1C1 VA: 0x1BCA0C0
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1BC8E40 Offset: 0x1BC8F41 VA: 0x1BC8E40
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1BCA2C0 Offset: 0x1BCA3C1 VA: 0x1BCA2C0
	private static void .cctor() { }
}

