// Namespace: 
private enum RankingSequence.Label // TypeDefIndex: 12839
{
	// Fields
	public int value__; // 0x0
	public const RankingSequence.Label Menu = 0;
	public const RankingSequence.Label Ranking = 1;
	public const RankingSequence.Label UploadMenu = 2;
	public const RankingSequence.Label UploadData = 3;
	public const RankingSequence.Label UploadPairsList = 4;
	public const RankingSequence.Label AddUploadPairs = 5;
	public const RankingSequence.Label RandomAddUploadPairs = 6;
	public const RankingSequence.Label ClearUploadPairs = 7;
	public const RankingSequence.Label End = 8;
}

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
private class RankingSequence.TopMenu.ChapterSelect : MenuItem // TypeDefIndex: 12841
{
	// Methods

	// RVA: 0x21F2B10 Offset: 0x21F2C11 VA: 0x21F2B10 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F2B90 Offset: 0x21F2C91 VA: 0x21F2B90 Slot: 5
	public override string GetName() { }

	// RVA: 0x21F2D50 Offset: 0x21F2E51 VA: 0x21F2D50 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }

	// RVA: 0x21F2ED0 Offset: 0x21F2FD1 VA: 0x21F2ED0
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
private class RankingSequence.TopMenu.UploadMenuItem : RankingSequence.TopMenu.BaseMenuItem // TypeDefIndex: 12843
{
	// Properties
	protected override RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F2F80 Offset: 0x21F3081 VA: 0x21F2F80 Slot: 72
	protected override RankingSequence.Label get_Label() { }

	// RVA: 0x21F2F90 Offset: 0x21F3091 VA: 0x21F2F90 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F3010 Offset: 0x21F3111 VA: 0x21F3010
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
private class RankingSequence.UploadPairsMenu.UploadPairMenuItem : RankingSequence.TopMenu.BaseMenuItem // TypeDefIndex: 12845
{
	// Properties
	protected override RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F39F0 Offset: 0x21F3AF1 VA: 0x21F39F0 Slot: 72
	protected override RankingSequence.Label get_Label() { }

	// RVA: 0x21F3A00 Offset: 0x21F3B01 VA: 0x21F3A00 Slot: 5
	public override string GetName() { }

	// RVA: 0x21F3B40 Offset: 0x21F3C41 VA: 0x21F3B40 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F3B50 Offset: 0x21F3C51 VA: 0x21F3B50
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
private class RankingSequence.UploadPairsMenu.UploadGodMenuItem : MenuItem // TypeDefIndex: 12847
{
	// Fields
	private string m_Name; // 0x20

	// Methods

	// RVA: 0x21F3520 Offset: 0x21F3621 VA: 0x21F3520
	public void .ctor() { }

	// RVA: 0x21F35F0 Offset: 0x21F36F1 VA: 0x21F35F0 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F3650 Offset: 0x21F3751 VA: 0x21F3650 Slot: 5
	public override string GetName() { }

	// RVA: 0x21F37C0 Offset: 0x21F38C1 VA: 0x21F37C0 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }

	// RVA: 0x21F38C0 Offset: 0x21F39C1 VA: 0x21F38C0 Slot: 7
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
private class RankingSequence.UploadPairsMenu.RandomAddUploadPairsMenuItem : RankingSequence.TopMenu.BaseMenuItem // TypeDefIndex: 12849
{
	// Properties
	protected override RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F3110 Offset: 0x21F3211 VA: 0x21F3110 Slot: 72
	protected override RankingSequence.Label get_Label() { }

	// RVA: 0x21F3120 Offset: 0x21F3221 VA: 0x21F3120 Slot: 5
	public override string GetName() { }

	// RVA: 0x21F3320 Offset: 0x21F3421 VA: 0x21F3320 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F3330 Offset: 0x21F3431 VA: 0x21F3330 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }

	// RVA: 0x21F3410 Offset: 0x21F3511 VA: 0x21F3410
	public void .ctor() { }
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
private class RankingSequence.UploadPairsMenu.UploadDataMenuItem : RankingSequence.TopMenu.BaseMenuItem // TypeDefIndex: 12851
{
	// Properties
	protected override RankingSequence.Label Label { get; }

	// Methods

	// RVA: 0x21F3420 Offset: 0x21F3521 VA: 0x21F3420 Slot: 72
	protected override RankingSequence.Label get_Label() { }

	// RVA: 0x21F3430 Offset: 0x21F3531 VA: 0x21F3430 Slot: 5
	public override string GetName() { }

	// RVA: 0x21F3480 Offset: 0x21F3581 VA: 0x21F3480 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x21F3510 Offset: 0x21F3611 VA: 0x21F3510
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
protected class RankingSequence.PairMenuItem : MenuItem // TypeDefIndex: 12853
{
	// Fields
	private NexRanking.Data m_Data; // 0x20
	private const uint MaxRatingSlot = 16;

	// Methods

	// RVA: 0x1F2E7C0 Offset: 0x1F2E8C1 VA: 0x1F2E7C0
	public void .ctor(NexRanking.Data data) { }

	// RVA: 0x1F2E7F0 Offset: 0x1F2E8F1 VA: 0x1F2E7F0 Slot: 5
	public override string GetName() { }

	// RVA: 0x1F2E8C0 Offset: 0x1F2E9C1 VA: 0x1F2E8C0 Slot: 7
	public override string GetHelp() { }
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

