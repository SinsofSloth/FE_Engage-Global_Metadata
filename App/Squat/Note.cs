// Namespace: App.Squat
public class Note // TypeDefIndex: 14184
{
	// Fields
	private const string cUIRootPath = "UI/Hub/MuscleExercises/Prefabs/";
	private const string cUINotesLeft = "Notes_Left";
	private const string cUINotesRight = "Notes_Right";
	private const string cUINotesUp = "Notes_Up";
	private const string cUINotesDown = "Notes_Down";
	private const string cUINotesClockwise = "Notes_RightRotation";
	private const string cUINotesUnclockwise = "Notes_LeftRotation";
	private const float DisplayHeight = 1200;
	private GameObject m_NodeImage; // 0x10
	private Animator m_ImageAnime; // 0x18
	private RectTransform m_ImageTrans; // 0x20
	private RectTransform m_StickImageTrans; // 0x28
	private Transform m_BaseTrans; // 0x30
	private float m_BaseHeightPerFrame; // 0x38
	private float m_BaseDiffLength; // 0x3C
	private float m_StickRangeMult; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x29DB90 Offset: 0x29DC91 VA: 0x29DB90
	private Note.Type <NoteType>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x29DBA0 Offset: 0x29DCA1 VA: 0x29DBA0
	private bool <IsFinish>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x29DBB0 Offset: 0x29DCB1 VA: 0x29DBB0
	private bool <IsTrigger>k__BackingField; // 0x49
	[CompilerGeneratedAttribute] // RVA: 0x29DBC0 Offset: 0x29DCC1 VA: 0x29DBC0
	private bool <IsAccepted>k__BackingField; // 0x4A
	[CompilerGeneratedAttribute] // RVA: 0x29DBD0 Offset: 0x29DCD1 VA: 0x29DBD0
	private bool <IsClockwiseCheck>k__BackingField; // 0x4B
	[CompilerGeneratedAttribute] // RVA: 0x29DBE0 Offset: 0x29DCE1 VA: 0x29DBE0
	private Note.ResultRank <Result>k__BackingField; // 0x4C
	private float m_Timer; // 0x50
	private float m_ClockwiseTimer; // 0x54
	private float m_TimeMult; // 0x58
	private bool m_IsPlayClockwiseInputAnime; // 0x5C
	private float m_FirstP; // 0x60
	private float m_FirstG; // 0x64
	private float m_FirstB; // 0x68
	private float m_LatterP; // 0x6C
	private float m_LatterG; // 0x70
	private float m_LatterB; // 0x74

	// Properties
	private Note.Type NoteType { get; set; }
	public bool IsFinish { get; set; }
	public bool IsTrigger { get; set; }
	public bool IsAccepted { get; set; }
	public bool IsClockwiseCheck { get; set; }
	public Note.ResultRank Result { get; set; }
	public Vector3 RectPos { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDF40 Offset: 0x2CE041 VA: 0x2CDF40
	// RVA: 0x2359E80 Offset: 0x2359F81 VA: 0x2359E80
	private Note.Type get_NoteType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF50 Offset: 0x2CE051 VA: 0x2CDF50
	// RVA: 0x2359E90 Offset: 0x2359F91 VA: 0x2359E90
	private void set_NoteType(Note.Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF60 Offset: 0x2CE061 VA: 0x2CDF60
	// RVA: 0x2359EA0 Offset: 0x2359FA1 VA: 0x2359EA0
	public bool get_IsFinish() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF70 Offset: 0x2CE071 VA: 0x2CDF70
	// RVA: 0x2359EB0 Offset: 0x2359FB1 VA: 0x2359EB0
	private void set_IsFinish(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF80 Offset: 0x2CE081 VA: 0x2CDF80
	// RVA: 0x2359EC0 Offset: 0x2359FC1 VA: 0x2359EC0
	public bool get_IsTrigger() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF90 Offset: 0x2CE091 VA: 0x2CDF90
	// RVA: 0x2359ED0 Offset: 0x2359FD1 VA: 0x2359ED0
	private void set_IsTrigger(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDFA0 Offset: 0x2CE0A1 VA: 0x2CDFA0
	// RVA: 0x2359EE0 Offset: 0x2359FE1 VA: 0x2359EE0
	public bool get_IsAccepted() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDFB0 Offset: 0x2CE0B1 VA: 0x2CDFB0
	// RVA: 0x2359EF0 Offset: 0x2359FF1 VA: 0x2359EF0
	public void set_IsAccepted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDFC0 Offset: 0x2CE0C1 VA: 0x2CDFC0
	// RVA: 0x2359F00 Offset: 0x235A001 VA: 0x2359F00
	public bool get_IsClockwiseCheck() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDFD0 Offset: 0x2CE0D1 VA: 0x2CDFD0
	// RVA: 0x2359F10 Offset: 0x235A011 VA: 0x2359F10
	private void set_IsClockwiseCheck(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDFE0 Offset: 0x2CE0E1 VA: 0x2CDFE0
	// RVA: 0x2359F20 Offset: 0x235A021 VA: 0x2359F20
	public Note.ResultRank get_Result() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDFF0 Offset: 0x2CE0F1 VA: 0x2CDFF0
	// RVA: 0x2359F30 Offset: 0x235A031 VA: 0x2359F30
	private void set_Result(Note.ResultRank value) { }

	// RVA: 0x2359F40 Offset: 0x235A041 VA: 0x2359F40
	public Vector3 get_RectPos() { }

	// RVA: 0x2359F50 Offset: 0x235A051 VA: 0x2359F50
	public void .ctor() { }

	// RVA: 0x2359F90 Offset: 0x235A091 VA: 0x2359F90
	public void SetJudgeParam(MuscleSquatJudgeAreaData setJudge) { }

	// RVA: 0x2359FD0 Offset: 0x235A0D1 VA: 0x2359FD0
	public void CreateArrow(bool isRight, ref GameObject canvas, Note.Type setType, float setTime, float moveHeightPF, Transform baseTrans, float firstTimeMult) { }

	// RVA: 0x235A280 Offset: 0x235A381 VA: 0x235A280
	public void CreateClockWise(bool isRight, ref GameObject canvas, Note.Type setType, float startTime, float endTime, float moveHeightPF, Transform baseTrans, float firstTimeMult, int radiusCount) { }

	// RVA: 0x235A5D0 Offset: 0x235A6D1 VA: 0x235A5D0
	public void Destroy() { }

	// RVA: 0x235A640 Offset: 0x235A741 VA: 0x235A640
	public void Tick(float timeMult, ref Stick stick, float heightPF, bool isTop, float setfb, float setfg, float setfp, float setlp, float setlg, float setlb, float overwriteRange = -1) { }

	// RVA: 0x235AA30 Offset: 0x235AB31 VA: 0x235AA30
	private void TickArrow(bool isTop, float center, float notCheckArea, ref Stick stick) { }

	// RVA: 0x235AB50 Offset: 0x235AC51 VA: 0x235AB50
	private void TickArrowJudge(float center, float notCheckArea, ref Stick stick) { }

	// RVA: 0x235A7C0 Offset: 0x235A8C1 VA: 0x235A7C0
	private void TickClockwise(bool isTop, ref Stick stick, float overwriteRange) { }

	// RVA: 0x235AD00 Offset: 0x235AE01 VA: 0x235AD00
	private void TickClockwiseJudge(ref Stick stick) { }
}

