// Namespace: App
public class GodRoomPedestalSequence : ProcInst // TypeDefIndex: 10985
{
	// Fields
	private GodRoomPedestalTopMenu.Result2 m_TopMenuResult; // 0x70
	private BasicMenu.Result m_Result; // 0x74
	private RefineRingUnitSelectMenu m_RefineRingUnitSelectMenu; // 0x78
	private RefineRingTimesSelectMenu m_RefineRingTimesSelectMenu; // 0x80
	private GodUnit m_GodUnit; // 0x88
	private int m_RingGachaTimes; // 0x90
	private List<UnitRing> m_UnitRingList; // 0x98
	private List<bool> m_NewRingList; // 0xA0
	private SynthesisRingMenuTop m_SynthesisRingMenu; // 0xA8
	private SynthesisRingMenuTop.Result m_SynthesisResultSet; // 0xB0
	private bool m_GeneratedNewRings; // 0xB8

	// Methods

	// RVA: 0x27AABB0 Offset: 0x27AACB1 VA: 0x27AABB0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x27AACA0 Offset: 0x27AADA1 VA: 0x27AACA0
	private void .ctor() { }

	// RVA: 0x27AACB0 Offset: 0x27AADB1 VA: 0x27AACB0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x27ACB80 Offset: 0x27ACC81 VA: 0x27ACB80
	private void LoadResources() { }

	// RVA: 0x27ACB90 Offset: 0x27ACC91 VA: 0x27ACB90
	private bool IsLoadingResources() { }

	// RVA: 0x27ACBA0 Offset: 0x27ACCA1 VA: 0x27ACBA0
	private void StartSequence() { }

	// RVA: 0x27ACD50 Offset: 0x27ACE51 VA: 0x27ACD50
	private void CreateTopMenu() { }

	// RVA: 0x27AD100 Offset: 0x27AD201 VA: 0x27AD100
	private void CreateSkillInheritance() { }

	// RVA: 0x27AD1B0 Offset: 0x27AD2B1 VA: 0x27AD1B0
	private void DestroySkillInheritance() { }

	// RVA: 0x27AD1C0 Offset: 0x27AD2C1 VA: 0x27AD1C0
	private void LoadResourcesForRefineRing() { }

	// RVA: 0x27AD300 Offset: 0x27AD401 VA: 0x27AD300
	private bool IsLoadingResourcesForRefineRing() { }

	// RVA: 0x27AD460 Offset: 0x27AD561 VA: 0x27AD460
	private void CreateGodSelectMenuForRefineRing() { }

	// RVA: 0x27AD690 Offset: 0x27AD791 VA: 0x27AD690
	private void DestroyGodSelectMenuForRefineRing() { }

	// RVA: 0x27AD720 Offset: 0x27AD821 VA: 0x27AD720
	private void CreateRingGachaTimesSelectMenu() { }

	// RVA: 0x27AD7F0 Offset: 0x27AD8F1 VA: 0x27AD7F0
	private void DestroyRingGachaTimesSelectMenu() { }

	// RVA: 0x27AD830 Offset: 0x27AD931 VA: 0x27AD830
	private void ExecuteRingGacha() { }

	// RVA: 0x27ADA40 Offset: 0x27ADB41 VA: 0x27ADA40
	private void CreateRingGachaDemoSequence() { }

	// RVA: 0x27ADCB0 Offset: 0x27ADDB1 VA: 0x27ADCB0
	private void AddAchieveOfRefineRing() { }

	// RVA: 0x27ADD20 Offset: 0x27ADE21 VA: 0x27ADD20
	private void UnloadResourcesForRefineRing() { }

	// RVA: 0x27ADFA0 Offset: 0x27AE0A1 VA: 0x27ADFA0
	private void LoadResourcesForSynthesisRing() { }

	// RVA: 0x27AE080 Offset: 0x27AE181 VA: 0x27AE080
	private bool IsLoadingResourcesForSynthesisRing() { }

	// RVA: 0x27AE190 Offset: 0x27AE291 VA: 0x27AE190
	private void CreateSynthesisRingMenuTop() { }

	// RVA: 0x27AE430 Offset: 0x27AE531 VA: 0x27AE430
	private void DestroySynthesisRingMenuTop() { }

	// RVA: 0x27AE4D0 Offset: 0x27AE5D1 VA: 0x27AE4D0
	private void ExecuteRingMerge() { }

	// RVA: 0x27AE5E0 Offset: 0x27AE6E1 VA: 0x27AE5E0
	private void CreateRingMergeDemoSequence() { }

	// RVA: 0x27AE840 Offset: 0x27AE941 VA: 0x27AE840
	private void UnloadResourcesForSynthesisRing() { }

	// RVA: 0x27AE910 Offset: 0x27AEA11 VA: 0x27AE910
	private void CreateRingCleaningMenu() { }

	// RVA: 0x27AEA90 Offset: 0x27AEB91 VA: 0x27AEA90
	private void DestroyRingCleaningMenu() { }

	// RVA: 0x27AEB60 Offset: 0x27AEC61 VA: 0x27AEB60
	private void CreateRefineGodWeapon() { }

	// RVA: 0x27AEB70 Offset: 0x27AEC71 VA: 0x27AEB70
	private void DestroyRefineGodWeapon() { }

	// RVA: 0x27AEC40 Offset: 0x27AED41 VA: 0x27AEC40
	private void EndSequence() { }

	// RVA: 0x27ADE60 Offset: 0x27ADF61 VA: 0x27ADE60
	private void TransitTopTitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2B70 Offset: 0x2C2C71 VA: 0x2C2B70
	// RVA: 0x27AED60 Offset: 0x27AEE61 VA: 0x27AED60
	private bool <CreateDesc>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2B80 Offset: 0x2C2C81 VA: 0x2C2B80
	// RVA: 0x27AED70 Offset: 0x27AEE71 VA: 0x27AED70
	private bool <CreateDesc>b__14_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2B90 Offset: 0x2C2C91 VA: 0x2C2B90
	// RVA: 0x27AED80 Offset: 0x27AEE81 VA: 0x27AED80
	private bool <CreateDesc>b__14_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2BA0 Offset: 0x2C2CA1 VA: 0x2C2BA0
	// RVA: 0x27AED90 Offset: 0x27AEE91 VA: 0x27AED90
	private bool <CreateDesc>b__14_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2BB0 Offset: 0x2C2CB1 VA: 0x2C2BB0
	// RVA: 0x27AEDA0 Offset: 0x27AEEA1 VA: 0x27AEDA0
	private bool <CreateDesc>b__14_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2BC0 Offset: 0x2C2CC1 VA: 0x2C2BC0
	// RVA: 0x27AEDB0 Offset: 0x27AEEB1 VA: 0x27AEDB0
	private bool <CreateDesc>b__14_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2BD0 Offset: 0x2C2CD1 VA: 0x2C2BD0
	// RVA: 0x27AEDC0 Offset: 0x27AEEC1 VA: 0x27AEDC0
	private bool <CreateDesc>b__14_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2BE0 Offset: 0x2C2CE1 VA: 0x2C2BE0
	// RVA: 0x27AEDD0 Offset: 0x27AEED1 VA: 0x27AEDD0
	private bool <CreateDesc>b__14_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2BF0 Offset: 0x2C2CF1 VA: 0x2C2BF0
	// RVA: 0x27AEDE0 Offset: 0x27AEEE1 VA: 0x27AEDE0
	private bool <CreateDesc>b__14_8() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C00 Offset: 0x2C2D01 VA: 0x2C2C00
	// RVA: 0x27AEDF0 Offset: 0x27AEEF1 VA: 0x27AEDF0
	private bool <CreateDesc>b__14_9() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C10 Offset: 0x2C2D11 VA: 0x2C2C10
	// RVA: 0x27AEE00 Offset: 0x27AEF01 VA: 0x27AEE00
	private bool <CreateDesc>b__14_10() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C20 Offset: 0x2C2D21 VA: 0x2C2C20
	// RVA: 0x27AEE10 Offset: 0x27AEF11 VA: 0x27AEE10
	private bool <CreateDesc>b__14_11() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C30 Offset: 0x2C2D31 VA: 0x2C2C30
	// RVA: 0x27AEE20 Offset: 0x27AEF21 VA: 0x27AEE20
	private void <CreateTopMenu>b__18_0(GodRoomPedestalTopMenu.Result2 r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C40 Offset: 0x2C2D41 VA: 0x2C2C40
	// RVA: 0x27AF0E0 Offset: 0x27AF1E1 VA: 0x27AF0E0
	private void <CreateGodSelectMenuForRefineRing>b__23_0(BasicMenu.Result result, GodUnit god, RingCleaningSequence.GodType _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C50 Offset: 0x2C2D51 VA: 0x2C2C50
	// RVA: 0x27AF260 Offset: 0x27AF361 VA: 0x27AF260
	private void <CreateRingGachaTimesSelectMenu>b__25_0(BasicMenu.Result result, int times) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C2C60 Offset: 0x2C2D61 VA: 0x2C2C60
	// RVA: 0x27AF270 Offset: 0x27AF371 VA: 0x27AF270
	private void <CreateSynthesisRingMenuTop>b__33_0(SynthesisRingMenuTop.Result result) { }
}

