// Namespace: App
public class MuscleExerciseSequence : ProcInst // TypeDefIndex: 11289
{
	// Fields
	private MuscleExercisePrefab m_RootPrefab; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x297660 Offset: 0x297761 VA: 0x297660
	private int <SelectType>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x297670 Offset: 0x297771 VA: 0x297670
	private int <SelectLevel>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x297680 Offset: 0x297781 VA: 0x297680
	private bool <IsAssist>k__BackingField; // 0x80

	// Properties
	public int SelectType { get; set; }
	public int SelectLevel { get; set; }
	public bool IsAssist { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C4670 Offset: 0x2C4771 VA: 0x2C4670
	// RVA: 0x2283BB0 Offset: 0x2283CB1 VA: 0x2283BB0
	public int get_SelectType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4680 Offset: 0x2C4781 VA: 0x2C4680
	// RVA: 0x2283BC0 Offset: 0x2283CC1 VA: 0x2283BC0
	public void set_SelectType(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4690 Offset: 0x2C4791 VA: 0x2C4690
	// RVA: 0x2283BD0 Offset: 0x2283CD1 VA: 0x2283BD0
	public int get_SelectLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C46A0 Offset: 0x2C47A1 VA: 0x2C46A0
	// RVA: 0x2283BE0 Offset: 0x2283CE1 VA: 0x2283BE0
	public void set_SelectLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C46B0 Offset: 0x2C47B1 VA: 0x2C46B0
	// RVA: 0x2283BF0 Offset: 0x2283CF1 VA: 0x2283BF0
	public bool get_IsAssist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C46C0 Offset: 0x2C47C1 VA: 0x2C46C0
	// RVA: 0x2283C00 Offset: 0x2283D01 VA: 0x2283C00
	public void set_IsAssist(bool value) { }

	// RVA: 0x2283C10 Offset: 0x2283D11 VA: 0x2283C10
	public void .ctor() { }

	// RVA: 0x2283C20 Offset: 0x2283D21 VA: 0x2283C20
	private void Init() { }

	// RVA: 0x2283C30 Offset: 0x2283D31 VA: 0x2283C30
	private void LoadResources() { }

	// RVA: 0x2283CD0 Offset: 0x2283DD1 VA: 0x2283CD0
	private bool IsLoading() { }

	// RVA: 0x2283D50 Offset: 0x2283E51 VA: 0x2283D50
	private void Setup() { }

	// RVA: 0x2283D80 Offset: 0x2283E81 VA: 0x2283D80
	private bool CheckJumpSquat() { }

	// RVA: 0x2283D90 Offset: 0x2283E91 VA: 0x2283D90
	private bool CheckJumpPushUp() { }

	// RVA: 0x2283DA0 Offset: 0x2283EA1 VA: 0x2283DA0
	private bool CheckJumpSitUp() { }

	// RVA: 0x2283DB0 Offset: 0x2283EB1 VA: 0x2283DB0
	private void Tick() { }

	// RVA: 0x2284000 Offset: 0x2284101 VA: 0x2284000
	private void CreatePushUpSequence() { }

	// RVA: 0x2285400 Offset: 0x2285501 VA: 0x2285400
	private void CreateSitUpSequence() { }

	// RVA: 0x22854A0 Offset: 0x22855A1 VA: 0x22854A0
	private void CreateSquatSequence() { }

	// RVA: 0x2285540 Offset: 0x2285641 VA: 0x2285540
	private void IncreasePlayCounter() { }

	// RVA: 0x22858A0 Offset: 0x22859A1 VA: 0x22858A0
	private void Final() { }

	// RVA: 0x2285990 Offset: 0x2285A91 VA: 0x2285990
	private void UnloadResources() { }

	// RVA: 0x2285A10 Offset: 0x2285B11 VA: 0x2285A10
	public static void CreateBind(ProcInst super, int type, int level, bool isAssist) { }

	// RVA: 0x2286580 Offset: 0x2286681 VA: 0x2286580
	public static void RegistFlag() { }
}

