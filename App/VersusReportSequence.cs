// Namespace: App
public class VersusReportSequence : ProcInst // TypeDefIndex: 13747
{
	// Fields
	private VersusViolationTopContent m_Content; // 0x70
	private MenuBg m_Bg; // 0x78
	private Texture2D m_MapTexture; // 0x80
	private Screening.ReportCategory m_Category; // 0x88
	private string m_Reason; // 0x90
	private string m_ReasonDisplay; // 0x98
	private bool m_IsReported; // 0xA0

	// Methods

	// RVA: 0x2A4FF00 Offset: 0x2A50001 VA: 0x2A4FF00
	private void LoadResources() { }

	// RVA: 0x2A4FF20 Offset: 0x2A50021 VA: 0x2A4FF20
	private bool IsLoadingResources() { }

	// RVA: 0x2A4FF50 Offset: 0x2A50051 VA: 0x2A4FF50
	private void UnloadResources() { }

	// RVA: 0x2A4FF70 Offset: 0x2A50071 VA: 0x2A4FF70
	private void Start() { }

	// RVA: 0x2A50010 Offset: 0x2A50111 VA: 0x2A50010
	private void Notice() { }

	// RVA: 0x2A500A0 Offset: 0x2A501A1 VA: 0x2A500A0
	private void CreateContent() { }

	// RVA: 0x2A50240 Offset: 0x2A50341 VA: 0x2A50240
	private void OpenMenu() { }

	// RVA: 0x2A502F0 Offset: 0x2A503F1 VA: 0x2A502F0
	private void InputKeyboard() { }

	// RVA: 0x2A50390 Offset: 0x2A50491 VA: 0x2A50390
	private void CheckReason() { }

	// RVA: 0x2A50650 Offset: 0x2A50751 VA: 0x2A50650
	private void OpenConfirmDialog() { }

	// RVA: 0x2A50790 Offset: 0x2A50891 VA: 0x2A50790
	private void Report() { }

	// RVA: 0x2A50D70 Offset: 0x2A50E71 VA: 0x2A50D70
	private void ShowDialog() { }

	// RVA: 0x2A50E60 Offset: 0x2A50F61 VA: 0x2A50E60
	private void End() { }

	// RVA: 0x2A50FD0 Offset: 0x2A510D1 VA: 0x2A50FD0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2A518F0 Offset: 0x2A519F1 VA: 0x2A518F0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2A505A0 Offset: 0x2A506A1 VA: 0x2A505A0
	private void SetCategory(Screening.ReportCategory category) { }

	// RVA: 0x2A504D0 Offset: 0x2A505D1 VA: 0x2A504D0
	private void SetReason(string reason) { }

	// RVA: 0x2A51B50 Offset: 0x2A51C51 VA: 0x2A51B50
	public static string GetCategoryName(Screening.ReportCategory category) { }

	// RVA: 0x2A51870 Offset: 0x2A51971 VA: 0x2A51870
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD2E0 Offset: 0x2CD3E1 VA: 0x2CD2E0
	// RVA: 0x2A51D60 Offset: 0x2A51E61 VA: 0x2A51D60
	private void <OpenMenu>b__14_0(Screening.ReportCategory category) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD2F0 Offset: 0x2CD3F1 VA: 0x2CD2F0
	// RVA: 0x2A51DF0 Offset: 0x2A51EF1 VA: 0x2A51DF0
	private void <OpenConfirmDialog>b__17_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD300 Offset: 0x2CD401 VA: 0x2CD300
	// RVA: 0x2A51E90 Offset: 0x2A51F91 VA: 0x2A51E90
	private void <Report>b__18_0(bool isSucceed) { }
}

