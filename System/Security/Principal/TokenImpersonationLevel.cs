// Namespace: System.Security.Principal
[ComVisibleAttribute] // RVA: 0x473B50 Offset: 0x473C51 VA: 0x473B50
[Serializable]
public enum TokenImpersonationLevel // TypeDefIndex: 893
{
	// Fields
	public int value__; // 0x0
	public const TokenImpersonationLevel Anonymous = 1;
	public const TokenImpersonationLevel Delegation = 4;
	public const TokenImpersonationLevel Identification = 2;
	public const TokenImpersonationLevel Impersonation = 3;
	public const TokenImpersonationLevel None = 0;
}

