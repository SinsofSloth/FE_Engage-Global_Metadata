// Namespace: App
public class UnitAnim // TypeDefIndex: 8980
{
	// Fields
	private static string[,] s_StateNames; // 0x0
	private static readonly AnimatorClipInfo s_NullClip; // 0x8
	private static readonly AnimatorStateInfo s_NullState; // 0x10

	// Methods

	// RVA: 0x23DA890 Offset: 0x23DA991 VA: 0x23DA890
	public static void Initialize() { }

	// RVA: 0x23DAB60 Offset: 0x23DAC61 VA: 0x23DAB60
	private static float GetTime(UnitAnim.Times time) { }

	// RVA: 0x23DAB90 Offset: 0x23DAC91 VA: 0x23DAB90
	private static float GetTime(UnitAnim.Times time, Animator animator) { }

	// RVA: 0x23DACA0 Offset: 0x23DADA1 VA: 0x23DACA0
	public static bool IsLoop(UnitAnim.Types type) { }

	// RVA: 0x23DACB0 Offset: 0x23DADB1 VA: 0x23DACB0
	public static bool IsExitToIdle(UnitAnim.Types type) { }

	// RVA: 0x23DACC0 Offset: 0x23DADC1 VA: 0x23DACC0
	public static int GetPriority(UnitAnim.Types type) { }

	// RVA: 0x23DACD0 Offset: 0x23DADD1 VA: 0x23DACD0
	public static bool HasState(Animator animator, string name) { }

	// RVA: 0x23DADC0 Offset: 0x23DAEC1 VA: 0x23DADC0
	public static void Play(Animator animator, string name, UnitAnim.Times transitionDuration = 0) { }

	// RVA: 0x23DAF20 Offset: 0x23DB021 VA: 0x23DAF20
	public static void Play(Animator animator, UnitAnim.Types type, ItemData.Kinds kind, UnitAnim.Times transitionDuration = 0) { }

	// RVA: 0x23DB030 Offset: 0x23DB131 VA: 0x23DB030
	public static void Play(Animator[] animators, UnitAnim.Types type, ItemData.Kinds kind, UnitAnim.Times transitionDuration = 0) { }

	// RVA: 0x23DB110 Offset: 0x23DB211 VA: 0x23DB110
	public static AnimatorClipInfo GetCurrentClipInfo(Animator animator) { }

	// RVA: 0x23DB260 Offset: 0x23DB361 VA: 0x23DB260
	public static AnimatorStateInfo GetCurrentStateInfo(Animator animator) { }

	// RVA: 0x23DB450 Offset: 0x23DB551 VA: 0x23DB450
	public static bool IsFinished(Animator animator, UnitAnim.Times restTime) { }

	// RVA: 0x23DB5B0 Offset: 0x23DB6B1 VA: 0x23DB5B0
	public static bool IsFinished(Animator[] animators, UnitAnim.Times restTime) { }

	// RVA: 0x23DB680 Offset: 0x23DB781 VA: 0x23DB680
	public static void SetSpeed(Animator[] animators, float speed) { }

	// RVA: 0x23DB700 Offset: 0x23DB801 VA: 0x23DB700
	public void .ctor() { }

	// RVA: 0x23DB710 Offset: 0x23DB811 VA: 0x23DB710
	private static void .cctor() { }
}

