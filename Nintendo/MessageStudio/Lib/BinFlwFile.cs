// Namespace: Nintendo.MessageStudio.Lib
public class BinFlwFile : BinLibmsFileBase // TypeDefIndex: 15024
{
	// Methods

	// RVA: 0x22638B0 Offset: 0x22639B1 VA: 0x22638B0 Slot: 5
	protected override IntPtr InitObject(IntPtr resourcePtr) { }

	// RVA: 0x2263920 Offset: 0x2263A21 VA: 0x2263920 Slot: 6
	protected override void CloseObject(IntPtr objectPtr) { }

	// RVA: 0x2263990 Offset: 0x2263A91 VA: 0x2263990
	public int GetNodeNum() { }

	// RVA: 0x2263A00 Offset: 0x2263B01 VA: 0x2263A00
	public int GetEntryNodeIndex(string label) { }

	// RVA: 0x2263A80 Offset: 0x2263B81 VA: 0x2263A80
	public LMSFlowNodeData GetNodeData(int index) { }

	// RVA: 0x2263C70 Offset: 0x2263D71 VA: 0x2263C70
	public ushort[] GetCaseIndexesFromBranchNode(int index) { }

	// RVA: 0x2263E30 Offset: 0x2263F31 VA: 0x2263E30
	public string GetFlowParamText(int offset) { }

	[ConditionalAttribute] // RVA: 0x2D2110 Offset: 0x2D2211 VA: 0x2D2110
	// RVA: 0x2263EF0 Offset: 0x2263FF1 VA: 0x2263EF0
	public void GetIndexTest(int index) { }

	// RVA: 0x2263F70 Offset: 0x2264071 VA: 0x2263F70
	public void .ctor() { }
}

