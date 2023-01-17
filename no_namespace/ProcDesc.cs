// Namespace: 
public enum ProcDesc.Type // TypeDefIndex: 13867
{
	// Fields
	public int value__; // 0x0
	public const ProcDesc.Type End = 0;
	public const ProcDesc.Type Halt = 1;
	public const ProcDesc.Type Jump = 2;
	public const ProcDesc.Type Label = 3;
	public const ProcDesc.Type Push = 4;
	public const ProcDesc.Type Pop = 5;
	public const ProcDesc.Type Persistent = 6;
	public const ProcDesc.Type WaitTime = 7;
	public const ProcDesc.Type WaitFrame = 8;
	public const ProcDesc.Type Yield = 9;
	public const ProcDesc.Type Call = 10;
	public const ProcDesc.Type Tick = 11;
	public const ProcDesc.Type Args = 12;
	public const ProcDesc.Type WaitFunc = 13;
	public const ProcDesc.Type JumpFunc = 14;
	public const ProcDesc.Type User = 15;
	public const ProcDesc.Type Max = 16;
}

// Namespace: 
public enum ProcDesc.Result // TypeDefIndex: 13868
{
	// Fields
	public int value__; // 0x0
	public const ProcDesc.Result End = 0;
	public const ProcDesc.Result Keep = 1;
	public const ProcDesc.Result Next = 2;
	public const ProcDesc.Result NextImm = 3;
	public const ProcDesc.Result CalledNext = 4;
	public const ProcDesc.Result CalledNextImm = 5;
	public const ProcDesc.Result Jump = 6;
	public const ProcDesc.Result Push = 7;
	public const ProcDesc.Result Pop = 8;
}

