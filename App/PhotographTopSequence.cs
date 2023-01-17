// Namespace: App
public class PhotographTopSequence : SingletonProcInst<PhotographTopSequence> // TypeDefIndex: 11537
{
	// Fields
	private PhotographTopSequence.Label m_NextLabel; // 0x74
	private PhotographSpotData m_SelectAreaData; // 0x78
	private List<PhotographTopSequence.UnitAccDataSet> m_UnitAccDataSetList; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x2988D0 Offset: 0x2989D1 VA: 0x2988D0
	private AccessoryData <MascotBodyAccData>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x2988E0 Offset: 0x2989E1 VA: 0x2988E0
	private AccessoryData <MascotFaceAccData>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x2988F0 Offset: 0x2989F1 VA: 0x2988F0
	private int <MascotColorIdx>k__BackingField; // 0x98

	// Properties
	public PhotographTopSequence.Label NextLabel { set; }
	public PhotographSpotData SelectAreaData { get; set; }
	public AccessoryData MascotBodyAccData { get; set; }
	public AccessoryData MascotFaceAccData { get; set; }
	public int MascotColorIdx { get; set; }

	// Methods

	// RVA: 0x29CF630 Offset: 0x29CF731 VA: 0x29CF630
	public void set_NextLabel(PhotographTopSequence.Label value) { }

	// RVA: 0x29CF640 Offset: 0x29CF741 VA: 0x29CF640
	public PhotographSpotData get_SelectAreaData() { }

	// RVA: 0x29CF650 Offset: 0x29CF751 VA: 0x29CF650
	public void set_SelectAreaData(PhotographSpotData value) { }

	// RVA: 0x29CF660 Offset: 0x29CF761 VA: 0x29CF660
	public PhotographTopSequence.UnitAccDataSet GetAccDataSet(Unit unit) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5C40 Offset: 0x2C5D41 VA: 0x2C5C40
	// RVA: 0x29CF7E0 Offset: 0x29CF8E1 VA: 0x29CF7E0
	public AccessoryData get_MascotBodyAccData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5C50 Offset: 0x2C5D51 VA: 0x2C5C50
	// RVA: 0x29CF7F0 Offset: 0x29CF8F1 VA: 0x29CF7F0
	public void set_MascotBodyAccData(AccessoryData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5C60 Offset: 0x2C5D61 VA: 0x2C5C60
	// RVA: 0x29CF800 Offset: 0x29CF901 VA: 0x29CF800
	public AccessoryData get_MascotFaceAccData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5C70 Offset: 0x2C5D71 VA: 0x2C5C70
	// RVA: 0x29CF810 Offset: 0x29CF911 VA: 0x29CF810
	public void set_MascotFaceAccData(AccessoryData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5C80 Offset: 0x2C5D81 VA: 0x2C5C80
	// RVA: 0x29CF820 Offset: 0x29CF921 VA: 0x29CF820
	public int get_MascotColorIdx() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5C90 Offset: 0x2C5D91 VA: 0x2C5C90
	// RVA: 0x29CF830 Offset: 0x29CF931 VA: 0x29CF830
	public void set_MascotColorIdx(int value) { }

	// RVA: 0x29CF840 Offset: 0x29CF941 VA: 0x29CF840
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x29CF9A0 Offset: 0x29CFAA1 VA: 0x29CF9A0
	public ProcDesc[] CreateDesc() { }

	// RVA: 0x29D09A0 Offset: 0x29D0AA1 VA: 0x29D09A0
	private void StartSequence() { }

	// RVA: 0x29D0BD0 Offset: 0x29D0CD1 VA: 0x29D0BD0
	private void OpenSelectAreaMenu() { }

	// RVA: 0x29D0D60 Offset: 0x29D0E61 VA: 0x29D0D60
	private void CloseSelectAreaMenu() { }

	// RVA: 0x29D0E30 Offset: 0x29D0F31 VA: 0x29D0E30
	private void StartPhotographSequence() { }

	// RVA: 0x29D10D0 Offset: 0x29D11D1 VA: 0x29D10D0
	private void EndPhotographSequence() { }

	// RVA: 0x29D1230 Offset: 0x29D1331 VA: 0x29D1230
	private void EndSequence() { }

	// RVA: 0x29D12A0 Offset: 0x29D13A1 VA: 0x29D12A0
	private void LoadResource() { }

	// RVA: 0x29D1310 Offset: 0x29D1411 VA: 0x29D1310
	private bool IsLoadingResource() { }

	// RVA: 0x29D1380 Offset: 0x29D1481 VA: 0x29D1380
	private void UnloadResource() { }

	// RVA: 0x29CF8C0 Offset: 0x29CF9C1 VA: 0x29CF8C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5CA0 Offset: 0x2C5DA1 VA: 0x2C5CA0
	// RVA: 0x29D13F0 Offset: 0x29D14F1 VA: 0x29D13F0
	private bool <CreateDesc>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5CB0 Offset: 0x2C5DB1 VA: 0x2C5CB0
	// RVA: 0x29D1400 Offset: 0x29D1501 VA: 0x29D1400
	private bool <CreateDesc>b__24_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5CC0 Offset: 0x2C5DC1 VA: 0x2C5CC0
	// RVA: 0x29D1410 Offset: 0x29D1511 VA: 0x29D1410
	private bool <CreateDesc>b__24_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5CD0 Offset: 0x2C5DD1 VA: 0x2C5CD0
	// RVA: 0x29D1420 Offset: 0x29D1521 VA: 0x29D1420
	private bool <CreateDesc>b__24_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5CE0 Offset: 0x2C5DE1 VA: 0x2C5CE0
	// RVA: 0x29D1430 Offset: 0x29D1531 VA: 0x29D1430
	private void <StartSequence>b__25_0(Unit unit) { }
}

