// Namespace: 
protected class RankingSequence.TopMenu.BaseMenuItem : MenuItem // TypeDefIndex: 12840
{
	// Properties
	protected virtual RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F2950 Offset: 0x21F2A51 VA: 0x21F2950 Slot: 72
	protected virtual RankingSequence.Label get_Label() { }

	// RVA: 0x21F2960 Offset: 0x21F2A61 VA: 0x21F2960 Slot: 5
	public override string GetName() { }

	// RVA: 0x21F2A00 Offset: 0x21F2B01 VA: 0x21F2A00 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x21F2B00 Offset: 0x21F2C01 VA: 0x21F2B00
	public void .ctor() { }
}

// Namespace: 
private class RankingSequence.TopMenu.RankingMenuItem : RankingSequence.TopMenu.BaseMenuItem // TypeDefIndex: 12842
{
	// Properties
	protected override RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F2EE0 Offset: 0x21F2FE1 VA: 0x21F2EE0 Slot: 72
	protected override RankingSequence.Label get_Label() { }

	// RVA: 0x21F2EF0 Offset: 0x21F2FF1 VA: 0x21F2EF0 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F2F70 Offset: 0x21F3071 VA: 0x21F2F70
	public void .ctor() { }
}

// Namespace: 
private class RankingSequence.TopMenu // TypeDefIndex: 12844
{
	// Methods

	// RVA: 0x1F2EA80 Offset: 0x1F2EB81 VA: 0x1F2EA80
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1F2EBE0 Offset: 0x1F2ECE1 VA: 0x1F2EBE0
	public void .ctor() { }
}

// Namespace: 
private class RankingSequence.UploadPairsMenu.UploadPersonMenuItem : MenuItem // TypeDefIndex: 12846
{
	// Fields
	private string m_Name; // 0x20

	// Methods

	// RVA: 0x21F3B60 Offset: 0x21F3C61 VA: 0x21F3B60
	public void .ctor() { }

	// RVA: 0x21F3C30 Offset: 0x21F3D31 VA: 0x21F3C30 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F3C90 Offset: 0x21F3D91 VA: 0x21F3C90 Slot: 5
	public override string GetName() { }

	// RVA: 0x21F3E00 Offset: 0x21F3F01 VA: 0x21F3E00 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }

	// RVA: 0x21F3F00 Offset: 0x21F4001 VA: 0x21F3F00 Slot: 7
	public override string GetHelp() { }
}

// Namespace: 
private class RankingSequence.UploadPairsMenu.AddUploadPairsMenuItem : RankingSequence.TopMenu.BaseMenuItem // TypeDefIndex: 12848
{
	// Fields
	private RankingSequence.UploadPairsMenu.UploadPersonMenuItem m_UploadPersonMenuItem; // 0x20
	private RankingSequence.UploadPairsMenu.UploadGodMenuItem m_UploadGodMenuItem; // 0x28

	// Properties
	protected override RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F3020 Offset: 0x21F3121 VA: 0x21F3020 Slot: 72
	protected override RankingSequence.Label get_Label() { }

	// RVA: 0x21F3030 Offset: 0x21F3131 VA: 0x21F3030
	public void .ctor(RankingSequence.UploadPairsMenu.UploadPersonMenuItem personItem, RankingSequence.UploadPairsMenu.UploadGodMenuItem godItem) { }

	// RVA: 0x21F3080 Offset: 0x21F3181 VA: 0x21F3080 Slot: 22
	public override bool IsEnable() { }
}

// Namespace: 
private class RankingSequence.UploadPairsMenu.ClearUploadPairsMenuItem : RankingSequence.TopMenu.BaseMenuItem // TypeDefIndex: 12850
{
	// Properties
	protected override RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F30E0 Offset: 0x21F31E1 VA: 0x21F30E0 Slot: 72
	protected override RankingSequence.Label get_Label() { }

	// RVA: 0x21F30F0 Offset: 0x21F31F1 VA: 0x21F30F0 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F3100 Offset: 0x21F3201 VA: 0x21F3100
	public void .ctor() { }
}

// Namespace: 
private class RankingSequence.UploadPairsMenu : RankingSequence.TopMenu // TypeDefIndex: 12852
{
	// Methods

	// RVA: 0x1F2EBF0 Offset: 0x1F2ECF1 VA: 0x1F2EBF0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1F2EE60 Offset: 0x1F2EF61 VA: 0x1F2EE60
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2787C0 Offset: 0x2788C1 VA: 0x2787C0
private sealed class RankingSequence.<>c__DisplayClass23_0 // TypeDefIndex: 12854
{
	// Fields
	public NexRanking.Data pair; // 0x10
	public bool isContinue; // 0x18

	// Methods

	// RVA: 0x1F2E750 Offset: 0x1F2E851 VA: 0x1F2E750
	public void .ctor() { }

	// RVA: 0x1F2E760 Offset: 0x1F2E861 VA: 0x1F2E760
	internal bool <RandomAddUploadPairs>b__0(PersonData p) { }

	// RVA: 0x1F2E790 Offset: 0x1F2E891 VA: 0x1F2E790
	internal bool <RandomAddUploadPairs>b__1(GodData g) { }
}

