// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x3B100 Offset: 0x3B201 VA: 0x3B100
public struct RenderGraphDebugData.PassDebugData // TypeDefIndex: 4465
{
	// Fields
	public string name; // 0x0
	public List<int>[] resourceReadLists; // 0x8
	public List<int>[] resourceWriteLists; // 0x10
	public bool culled; // 0x18
	public bool generateDebugData; // 0x19
}

// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x3B140 Offset: 0x3B241 VA: 0x3B140
public struct RenderGraphDebugData.ResourceDebugData // TypeDefIndex: 4466
{
	// Fields
	public string name; // 0x0
	public bool imported; // 0x8
	public int creationPassIndex; // 0xC
	public int releasePassIndex; // 0x10
	public List<int> consumerList; // 0x18
	public List<int> producerList; // 0x20
}

