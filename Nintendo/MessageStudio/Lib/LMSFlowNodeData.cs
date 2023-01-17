// Namespace: Nintendo.MessageStudio.Lib
public struct LMSFlowNodeData // TypeDefIndex: 15031
{
	// Fields
	public LMSFlowNodeType NodeType; // 0x0
	public LMSFlowParamType ParamType; // 0x1
	public ushort Reserved; // 0x2
	public uint ParamValue; // 0x4
	public ushort Rawdata0; // 0x8
	public ushort Rawdata1; // 0xA
	public ushort Rawdata2; // 0xC
	public ushort Rawdata3; // 0xE
	public LMSFlowEntry Entry; // 0x8
	public LMSFlowMessage Message; // 0x8
	public LMSFlowBranch Branch; // 0x8
	public LMSFlowEvent Event; // 0x8
	public LMSFlowJump Jump; // 0x8
}

