// Namespace: App
public class Framework : SingletonMonoBehaviour<Framework> // TypeDefIndex: 8965
{
	// Fields
	private static int s_PauseCount; // 0x0
	private static long s_TotalMemory; // 0x8
	private static int s_GCCount; // 0x10
	private static BindHolder s_GCBind; // 0x18
	private static Queue<Object> s_DestoryObjects; // 0x20
	private static object s_LockDestroy; // 0x28
	private static Thread s_MainThread; // 0x30
	private const ThreadPriority LoadingPriority_Default = 1;
	private const ThreadPriority LoadingPriority_Loading = 4;
	private const int AsyncUploadTimeSlice_Default = 2;
	private const int AsyncUploadTimeSlice_Loading = 33;

	// Methods

	// RVA: 0x2A06610 Offset: 0x2A06711 VA: 0x2A06610
	public static bool IsBoostMode() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x2ADBE0 Offset: 0x2ADCE1 VA: 0x2ADBE0
	// RVA: 0x2A06630 Offset: 0x2A06731 VA: 0x2A06630
	private static void OnBeforeSceneLoadRuntimeMethod() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x2ADC00 Offset: 0x2ADD01 VA: 0x2ADC00
	// RVA: 0x2A06760 Offset: 0x2A06861 VA: 0x2A06760
	private static void OnAfterSceneLoadRuntimeMethod() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x2ADC20 Offset: 0x2ADD21 VA: 0x2ADC20
	// RVA: 0x2A06830 Offset: 0x2A06931 VA: 0x2A06830
	private static void OnRuntimeMethodLoad() { }

	// RVA: 0x2A068D0 Offset: 0x2A069D1 VA: 0x2A068D0
	public static void UpdateResolution() { }

	// RVA: 0x2A068E0 Offset: 0x2A069E1 VA: 0x2A068E0
	private static void NotificationMessageReceived(Notification.Message message) { }

	// RVA: 0x2A06A10 Offset: 0x2A06B11 VA: 0x2A06A10
	public static void ResetSetting() { }

	// RVA: 0x2A066F0 Offset: 0x2A067F1 VA: 0x2A066F0
	private static void InitTotalMemory() { }

	// RVA: 0x2A06B40 Offset: 0x2A06C41 VA: 0x2A06B40
	public static long GetTotalMemory() { }

	// RVA: 0x2A06BB0 Offset: 0x2A06CB1 VA: 0x2A06BB0
	public static long GetAllocatableMemory() { }

	// RVA: 0x2A06BC0 Offset: 0x2A06CC1 VA: 0x2A06BC0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2A071C0 Offset: 0x2A072C1 VA: 0x2A071C0
	private void OnDestroy() { }

	// RVA: 0x2A072A0 Offset: 0x2A073A1 VA: 0x2A072A0
	private void Start() { }

	// RVA: 0x2A07310 Offset: 0x2A07411 VA: 0x2A07310
	private void UpdatePause() { }

	// RVA: 0x2A07320 Offset: 0x2A07421 VA: 0x2A07320
	public static void CpuBoostOn() { }

	// RVA: 0x2A07350 Offset: 0x2A07451 VA: 0x2A07350
	public static void CpuBoostOff() { }

	// RVA: 0x2A07380 Offset: 0x2A07481 VA: 0x2A07380
	public static void CpuBoostOnForLoading() { }

	// RVA: 0x2A07430 Offset: 0x2A07531 VA: 0x2A07430
	public static void CpuBoostOffForLoading() { }

	// RVA: 0x2A074E0 Offset: 0x2A075E1 VA: 0x2A074E0
	private void Update() { }

	// RVA: 0x2A07620 Offset: 0x2A07721 VA: 0x2A07620
	private void LateUpdate() { }

	// RVA: 0x2A078D0 Offset: 0x2A079D1 VA: 0x2A078D0
	public static bool IsPausing() { }

	// RVA: 0x2A078E0 Offset: 0x2A079E1 VA: 0x2A078E0
	public static void Shoutdown() { }

	// RVA: 0x2A078F0 Offset: 0x2A079F1 VA: 0x2A078F0
	public static void GCBegin() { }

	// RVA: 0x2A07900 Offset: 0x2A07A01 VA: 0x2A07900
	public static void GCEnd() { }

	// RVA: 0x2A07910 Offset: 0x2A07A11 VA: 0x2A07910
	public static void GCCollect() { }

	// RVA: 0x2A079D0 Offset: 0x2A07AD1 VA: 0x2A079D0
	public static void GCCollectLow() { }

	// RVA: 0x2A079C0 Offset: 0x2A07AC1 VA: 0x2A079C0
	private static void GCCommit() { }

	// RVA: 0x2A07A70 Offset: 0x2A07B71 VA: 0x2A07A70
	public static void GCBind() { }

	// RVA: 0x2A07B50 Offset: 0x2A07C51 VA: 0x2A07B50
	public static void GCUnbind() { }

	[IteratorStateMachineAttribute] // RVA: 0x2ADC30 Offset: 0x2ADD31 VA: 0x2ADC30
	// RVA: 0x2A07C40 Offset: 0x2A07D41 VA: 0x2A07C40
	public static IEnumerator CollectCoroutine(float time) { }

	// RVA: 0x2A07CB0 Offset: 0x2A07DB1 VA: 0x2A07CB0
	public static void AddDestroy(Object obj) { }

	// RVA: 0x2A07690 Offset: 0x2A07791 VA: 0x2A07690
	private static void UpdateDestroy() { }

	// RVA: 0x2A07EE0 Offset: 0x2A07FE1 VA: 0x2A07EE0
	public void .ctor() { }

	// RVA: 0x2A07F60 Offset: 0x2A08061 VA: 0x2A07F60
	private static void .cctor() { }
}

