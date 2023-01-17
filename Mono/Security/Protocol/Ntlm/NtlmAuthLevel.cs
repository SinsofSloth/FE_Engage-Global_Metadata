// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmAuthLevel // TypeDefIndex: 1545
{
	// Fields
	public int value__; // 0x0
	public const NtlmAuthLevel LM_and_NTLM = 0;
	public const NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session = 1;
	public const NtlmAuthLevel NTLM_only = 2;
	public const NtlmAuthLevel NTLMv2_only = 3;
}

