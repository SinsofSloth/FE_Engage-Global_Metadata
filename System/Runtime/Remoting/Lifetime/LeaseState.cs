// Namespace: System.Runtime.Remoting.Lifetime
[ComVisibleAttribute] // RVA: 0x474C10 Offset: 0x474D11 VA: 0x474C10
[Serializable]
public enum LeaseState // TypeDefIndex: 1131
{
	// Fields
	public int value__; // 0x0
	public const LeaseState Null = 0;
	public const LeaseState Initial = 1;
	public const LeaseState Active = 2;
	public const LeaseState Renewing = 3;
	public const LeaseState Expired = 4;
}

