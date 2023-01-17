// Namespace: System.Threading.Tasks
[FriendAccessAllowedAttribute] // RVA: 0x473740 Offset: 0x473841 VA: 0x473740
internal enum AsyncCausalityStatus // TypeDefIndex: 816
{
	// Fields
	public int value__; // 0x0
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;
}

