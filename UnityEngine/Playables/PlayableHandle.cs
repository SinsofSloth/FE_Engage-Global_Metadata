// Namespace: UnityEngine.Playables
[NativeHeaderAttribute] // RVA: 0x4412F0 Offset: 0x4413F1 VA: 0x4412F0
[NativeHeaderAttribute] // RVA: 0x4412F0 Offset: 0x4413F1 VA: 0x4412F0
[UsedByNativeCodeAttribute] // RVA: 0x4412F0 Offset: 0x4413F1 VA: 0x4412F0
[NativeHeaderAttribute] // RVA: 0x4412F0 Offset: 0x4413F1 VA: 0x4412F0
public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3996
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal T GetObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2982360 Offset: 0x2982461 VA: 0x2982360
	|-PlayableHandle.GetObject<object>
	*/

	[VisibleToOtherModulesAttribute] // RVA: 0x454B80 Offset: 0x454C81 VA: 0x454B80
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011290 Offset: 0x2011391 VA: 0x2011290
	|-PlayableHandle.IsPlayableOfType<AnimationClipPlayable>
	|
	|-RVA: 0x2011330 Offset: 0x2011431 VA: 0x2011330
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-RVA: 0x20113D0 Offset: 0x20114D1 VA: 0x20113D0
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-RVA: 0x2011470 Offset: 0x2011571 VA: 0x2011470
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x2011510 Offset: 0x2011611 VA: 0x2011510
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-RVA: 0x20115B0 Offset: 0x20116B1 VA: 0x20115B0
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-RVA: 0x2011650 Offset: 0x2011751 VA: 0x2011650
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-RVA: 0x20116F0 Offset: 0x20117F1 VA: 0x20116F0
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-RVA: 0x2011790 Offset: 0x2011891 VA: 0x2011790
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	|
	|-RVA: 0x2011830 Offset: 0x2011931 VA: 0x2011830
	|-PlayableHandle.IsPlayableOfType<object>
	*/

	// RVA: 0x3490070 Offset: 0x3490171 VA: 0x3490070
	public static PlayableHandle get_Null() { }

	// RVA: 0x34911D0 Offset: 0x34912D1 VA: 0x34911D0
	internal Playable GetInput(int inputPort) { }

	// RVA: 0x3491350 Offset: 0x3491451 VA: 0x3491350
	internal bool SetInputWeight(int inputIndex, float weight) { }

	// RVA: 0x34914E0 Offset: 0x34915E1 VA: 0x34914E0
	internal float GetInputWeight(int inputIndex) { }

	// RVA: 0x347CAF0 Offset: 0x347CBF1 VA: 0x347CAF0
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x3491670 Offset: 0x3491771 VA: 0x3491670
	public static bool op_Inequality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x3491710 Offset: 0x3491811 VA: 0x3491710 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x34917F0 Offset: 0x34918F1 VA: 0x34917F0 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x3491890 Offset: 0x3491991 VA: 0x3491890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3491630 Offset: 0x3491731 VA: 0x3491630
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0x3491410 Offset: 0x3491511 VA: 0x3491410
	internal bool CheckInputBounds(int inputIndex) { }

	// RVA: 0x34918D0 Offset: 0x34919D1 VA: 0x34918D0
	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x454B90 Offset: 0x454C91 VA: 0x454B90
	// RVA: 0x3491BF0 Offset: 0x3491CF1 VA: 0x3491BF0
	internal bool IsValid() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x454BA0 Offset: 0x454CA1 VA: 0x454BA0
	[FreeFunctionAttribute] // RVA: 0x454BA0 Offset: 0x454CA1 VA: 0x454BA0
	// RVA: 0x348FE20 Offset: 0x348FF21 VA: 0x348FE20
	internal Type GetPlayableType() { }

	[FreeFunctionAttribute] // RVA: 0x454C00 Offset: 0x454D01 VA: 0x454C00
	[VisibleToOtherModulesAttribute] // RVA: 0x454C00 Offset: 0x454D01 VA: 0x454C00
	// RVA: 0x3491D30 Offset: 0x3491E31 VA: 0x3491D30
	internal void SetScriptInstance(object scriptInstance) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x454C60 Offset: 0x454D61 VA: 0x454C60
	[FreeFunctionAttribute] // RVA: 0x454C60 Offset: 0x454D61 VA: 0x454C60
	// RVA: 0x3491E20 Offset: 0x3491F21 VA: 0x3491E20
	internal PlayState GetPlayState() { }

	[FreeFunctionAttribute] // RVA: 0x454CC0 Offset: 0x454DC1 VA: 0x454CC0
	[VisibleToOtherModulesAttribute] // RVA: 0x454CC0 Offset: 0x454DC1 VA: 0x454CC0
	// RVA: 0x3491F10 Offset: 0x3492011 VA: 0x3491F10
	internal void Play() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x454D20 Offset: 0x454E21 VA: 0x454D20
	[FreeFunctionAttribute] // RVA: 0x454D20 Offset: 0x454E21 VA: 0x454D20
	// RVA: 0x3492000 Offset: 0x3492101 VA: 0x3492000
	internal void Pause() { }

	[FreeFunctionAttribute] // RVA: 0x454D80 Offset: 0x454E81 VA: 0x454D80
	[VisibleToOtherModulesAttribute] // RVA: 0x454D80 Offset: 0x454E81 VA: 0x454D80
	// RVA: 0x34920F0 Offset: 0x34921F1 VA: 0x34920F0
	internal double GetSpeed() { }

	[FreeFunctionAttribute] // RVA: 0x454DE0 Offset: 0x454EE1 VA: 0x454DE0
	[VisibleToOtherModulesAttribute] // RVA: 0x454DE0 Offset: 0x454EE1 VA: 0x454DE0
	// RVA: 0x34921E0 Offset: 0x34922E1 VA: 0x34921E0
	internal void SetSpeed(double value) { }

	[FreeFunctionAttribute] // RVA: 0x454E40 Offset: 0x454F41 VA: 0x454E40
	[VisibleToOtherModulesAttribute] // RVA: 0x454E40 Offset: 0x454F41 VA: 0x454E40
	// RVA: 0x34922E0 Offset: 0x34923E1 VA: 0x34922E0
	internal double GetTime() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x454EA0 Offset: 0x454FA1 VA: 0x454EA0
	[FreeFunctionAttribute] // RVA: 0x454EA0 Offset: 0x454FA1 VA: 0x454EA0
	// RVA: 0x34923D0 Offset: 0x34924D1 VA: 0x34923D0
	internal void SetTime(double value) { }

	[FreeFunctionAttribute] // RVA: 0x454F00 Offset: 0x455001 VA: 0x454F00
	[VisibleToOtherModulesAttribute] // RVA: 0x454F00 Offset: 0x455001 VA: 0x454F00
	// RVA: 0x34924D0 Offset: 0x34925D1 VA: 0x34924D0
	internal bool IsDone() { }

	[FreeFunctionAttribute] // RVA: 0x454F60 Offset: 0x455061 VA: 0x454F60
	[VisibleToOtherModulesAttribute] // RVA: 0x454F60 Offset: 0x455061 VA: 0x454F60
	// RVA: 0x34925C0 Offset: 0x34926C1 VA: 0x34925C0
	internal void SetDone(bool value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x454FC0 Offset: 0x4550C1 VA: 0x454FC0
	[FreeFunctionAttribute] // RVA: 0x454FC0 Offset: 0x4550C1 VA: 0x454FC0
	// RVA: 0x34926B0 Offset: 0x34927B1 VA: 0x34926B0
	internal double GetDuration() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x455020 Offset: 0x455121 VA: 0x455020
	[FreeFunctionAttribute] // RVA: 0x455020 Offset: 0x455121 VA: 0x455020
	// RVA: 0x34927A0 Offset: 0x34928A1 VA: 0x34927A0
	internal void SetDuration(double value) { }

	[FreeFunctionAttribute] // RVA: 0x455080 Offset: 0x455181 VA: 0x455080
	[VisibleToOtherModulesAttribute] // RVA: 0x455080 Offset: 0x455181 VA: 0x455080
	// RVA: 0x34928A0 Offset: 0x34929A1 VA: 0x34928A0
	internal void SetPropagateSetTime(bool value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4550E0 Offset: 0x4551E1 VA: 0x4550E0
	[FreeFunctionAttribute] // RVA: 0x4550E0 Offset: 0x4551E1 VA: 0x4550E0
	// RVA: 0x3492990 Offset: 0x3492A91 VA: 0x3492990
	internal PlayableGraph GetGraph() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x455140 Offset: 0x455241 VA: 0x455140
	[FreeFunctionAttribute] // RVA: 0x455140 Offset: 0x455241 VA: 0x455140
	// RVA: 0x3491B50 Offset: 0x3491C51 VA: 0x3491B50
	internal int GetInputCount() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4551A0 Offset: 0x4552A1 VA: 0x4551A0
	[FreeFunctionAttribute] // RVA: 0x4551A0 Offset: 0x4552A1 VA: 0x4551A0
	// RVA: 0x3492AE0 Offset: 0x3492BE1 VA: 0x3492AE0
	internal void SetInputCount(int value) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x455200 Offset: 0x455301 VA: 0x455200
	[FreeFunctionAttribute] // RVA: 0x455200 Offset: 0x455301 VA: 0x455200
	// RVA: 0x3492BD0 Offset: 0x3492CD1 VA: 0x3492BD0
	internal void SetInputWeight(PlayableHandle input, float weight) { }

	[FreeFunctionAttribute] // RVA: 0x455260 Offset: 0x455361 VA: 0x455260
	[VisibleToOtherModulesAttribute] // RVA: 0x455260 Offset: 0x455361 VA: 0x455260
	// RVA: 0x3492CF0 Offset: 0x3492DF1 VA: 0x3492CF0
	internal double GetPreviousTime() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4552C0 Offset: 0x4553C1 VA: 0x4552C0
	[FreeFunctionAttribute] // RVA: 0x4552C0 Offset: 0x4553C1 VA: 0x4552C0
	// RVA: 0x3492DE0 Offset: 0x3492EE1 VA: 0x3492DE0
	internal void SetTraversalMode(PlayableTraversalMode mode) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x455320 Offset: 0x455421 VA: 0x455320
	[FreeFunctionAttribute] // RVA: 0x455320 Offset: 0x455421 VA: 0x455320
	// RVA: 0x3492ED0 Offset: 0x3492FD1 VA: 0x3492ED0
	internal DirectorWrapMode GetTimeWrapMode() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x455380 Offset: 0x455481 VA: 0x455380
	[FreeFunctionAttribute] // RVA: 0x455380 Offset: 0x455481 VA: 0x455380
	// RVA: 0x3492FC0 Offset: 0x34930C1 VA: 0x3492FC0
	internal void SetTimeWrapMode(DirectorWrapMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x4553E0 Offset: 0x4554E1 VA: 0x4553E0
	// RVA: 0x34930B0 Offset: 0x34931B1 VA: 0x34930B0
	private object GetScriptInstance() { }

	[FreeFunctionAttribute] // RVA: 0x455430 Offset: 0x455531 VA: 0x455430
	// RVA: 0x3491290 Offset: 0x3491391 VA: 0x3491290
	private PlayableHandle GetInputHandle(int index) { }

	[FreeFunctionAttribute] // RVA: 0x455480 Offset: 0x455581 VA: 0x455480
	// RVA: 0x3491430 Offset: 0x3491531 VA: 0x3491430
	private void SetInputWeightFromIndex(int index, float weight) { }

	[FreeFunctionAttribute] // RVA: 0x4554D0 Offset: 0x4555D1 VA: 0x4554D0
	// RVA: 0x3491590 Offset: 0x3491691 VA: 0x3491590
	private float GetInputWeightFromIndex(int index) { }

	// RVA: 0x34932B0 Offset: 0x34933B1 VA: 0x34932B0
	private static void .cctor() { }

	// RVA: 0x3491C90 Offset: 0x3491D91 VA: 0x3491C90
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3491CE0 Offset: 0x3491DE1 VA: 0x3491CE0
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3491DD0 Offset: 0x3491ED1 VA: 0x3491DD0
	private static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance) { }

	// RVA: 0x3491EC0 Offset: 0x3491FC1 VA: 0x3491EC0
	private static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3491FB0 Offset: 0x34920B1 VA: 0x3491FB0
	private static void Play_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x34920A0 Offset: 0x34921A1 VA: 0x34920A0
	private static void Pause_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3492190 Offset: 0x3492291 VA: 0x3492190
	private static double GetSpeed_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3492290 Offset: 0x3492391 VA: 0x3492290
	private static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x3492380 Offset: 0x3492481 VA: 0x3492380
	private static double GetTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3492480 Offset: 0x3492581 VA: 0x3492480
	private static void SetTime_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x3492570 Offset: 0x3492671 VA: 0x3492570
	private static bool IsDone_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3492660 Offset: 0x3492761 VA: 0x3492660
	private static void SetDone_Injected(ref PlayableHandle _unity_self, bool value) { }

	// RVA: 0x3492750 Offset: 0x3492851 VA: 0x3492750
	private static double GetDuration_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3492850 Offset: 0x3492951 VA: 0x3492850
	private static void SetDuration_Injected(ref PlayableHandle _unity_self, double value) { }

	// RVA: 0x3492940 Offset: 0x3492A41 VA: 0x3492940
	private static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value) { }

	// RVA: 0x3492A40 Offset: 0x3492B41 VA: 0x3492A40
	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	// RVA: 0x3492A90 Offset: 0x3492B91 VA: 0x3492A90
	private static int GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3492B80 Offset: 0x3492C81 VA: 0x3492B80
	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) { }

	// RVA: 0x3492C90 Offset: 0x3492D91 VA: 0x3492C90
	private static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight) { }

	// RVA: 0x3492D90 Offset: 0x3492E91 VA: 0x3492D90
	private static double GetPreviousTime_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3492E80 Offset: 0x3492F81 VA: 0x3492E80
	private static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode) { }

	// RVA: 0x3492F70 Offset: 0x3493071 VA: 0x3492F70
	private static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x3493060 Offset: 0x3493161 VA: 0x3493060
	private static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode) { }

	// RVA: 0x3493150 Offset: 0x3493251 VA: 0x3493150
	private static object GetScriptInstance_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x34931A0 Offset: 0x34932A1 VA: 0x34931A0
	private static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret) { }

	// RVA: 0x3493200 Offset: 0x3493301 VA: 0x3493200
	private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight) { }

	// RVA: 0x3493260 Offset: 0x3493361 VA: 0x3493260
	private static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index) { }
}

