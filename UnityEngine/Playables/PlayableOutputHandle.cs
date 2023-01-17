// Namespace: UnityEngine.Playables
[NativeHeaderAttribute] // RVA: 0x4413B0 Offset: 0x4414B1 VA: 0x4413B0
[NativeHeaderAttribute] // RVA: 0x4413B0 Offset: 0x4414B1 VA: 0x4413B0
[NativeHeaderAttribute] // RVA: 0x4413B0 Offset: 0x4414B1 VA: 0x4413B0
[UsedByNativeCodeAttribute] // RVA: 0x4413B0 Offset: 0x4414B1 VA: 0x4413B0
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 3999
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x3493570 Offset: 0x3493671 VA: 0x3493570
	public static PlayableOutputHandle get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4555B0 Offset: 0x4556B1 VA: 0x4555B0
	// RVA: -1 Offset: -1
	internal bool IsPlayableOutputOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2011D00 Offset: 0x2011E01 VA: 0x2011D00
	|-PlayableOutputHandle.IsPlayableOutputOfType<AnimationPlayableOutput>
	|
	|-RVA: 0x2011DA0 Offset: 0x2011EA1 VA: 0x2011DA0
	|-PlayableOutputHandle.IsPlayableOutputOfType<AudioPlayableOutput>
	|
	|-RVA: 0x2011E40 Offset: 0x2011F41 VA: 0x2011E40
	|-PlayableOutputHandle.IsPlayableOutputOfType<object>
	|
	|-RVA: 0x2011EE0 Offset: 0x2011FE1 VA: 0x2011EE0
	|-PlayableOutputHandle.IsPlayableOutputOfType<ScriptPlayableOutput>
	*/

	// RVA: 0x34935E0 Offset: 0x34936E1 VA: 0x34935E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3493400 Offset: 0x3493501 VA: 0x3493400
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x3493660 Offset: 0x3493761 VA: 0x3493660 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x3493740 Offset: 0x3493841 VA: 0x3493740 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x3493620 Offset: 0x3493721 VA: 0x3493620
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4555C0 Offset: 0x4556C1 VA: 0x4555C0
	// RVA: 0x34937E0 Offset: 0x34938E1 VA: 0x34937E0
	internal bool IsValid() { }

	[FreeFunctionAttribute] // RVA: 0x4555D0 Offset: 0x4556D1 VA: 0x4555D0
	// RVA: 0x34938D0 Offset: 0x34939D1 VA: 0x34938D0
	internal Type GetPlayableOutputType() { }

	[FreeFunctionAttribute] // RVA: 0x455620 Offset: 0x455721 VA: 0x455620
	// RVA: 0x34939C0 Offset: 0x3493AC1 VA: 0x34939C0
	internal void SetReferenceObject(Object target) { }

	[FreeFunctionAttribute] // RVA: 0x455670 Offset: 0x455771 VA: 0x455670
	// RVA: 0x3493AB0 Offset: 0x3493BB1 VA: 0x3493AB0
	internal void SetUserData(Object target) { }

	[FreeFunctionAttribute] // RVA: 0x4556C0 Offset: 0x4557C1 VA: 0x4556C0
	// RVA: 0x3493BA0 Offset: 0x3493CA1 VA: 0x3493BA0
	internal PlayableHandle GetSourcePlayable() { }

	[FreeFunctionAttribute] // RVA: 0x455710 Offset: 0x455811 VA: 0x455710
	// RVA: 0x3493CA0 Offset: 0x3493DA1 VA: 0x3493CA0
	internal void SetSourcePlayable(PlayableHandle target, int port) { }

	[FreeFunctionAttribute] // RVA: 0x455760 Offset: 0x455861 VA: 0x455760
	// RVA: 0x3493DC0 Offset: 0x3493EC1 VA: 0x3493DC0
	internal int GetSourceOutputPort() { }

	[FreeFunctionAttribute] // RVA: 0x4557B0 Offset: 0x4558B1 VA: 0x4557B0
	// RVA: 0x3493EB0 Offset: 0x3493FB1 VA: 0x3493EB0
	internal void SetWeight(float weight) { }

	[FreeFunctionAttribute] // RVA: 0x455800 Offset: 0x455901 VA: 0x455800
	// RVA: 0x3493FB0 Offset: 0x34940B1 VA: 0x3493FB0
	internal void PushNotification(PlayableHandle origin, INotification notification, object context) { }

	[FreeFunctionAttribute] // RVA: 0x455850 Offset: 0x455951 VA: 0x455850
	// RVA: 0x34940F0 Offset: 0x34941F1 VA: 0x34940F0
	internal void AddNotificationReceiver(INotificationReceiver receiver) { }

	// RVA: 0x34941E0 Offset: 0x34942E1 VA: 0x34941E0
	private static void .cctor() { }

	// RVA: 0x3493880 Offset: 0x3493981 VA: 0x3493880
	private static bool IsValid_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x3493970 Offset: 0x3493A71 VA: 0x3493970
	private static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x3493A60 Offset: 0x3493B61 VA: 0x3493A60
	private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0x3493B50 Offset: 0x3493C51 VA: 0x3493B50
	private static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target) { }

	// RVA: 0x3493C50 Offset: 0x3493D51 VA: 0x3493C50
	private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) { }

	// RVA: 0x3493D60 Offset: 0x3493E61 VA: 0x3493D60
	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port) { }

	// RVA: 0x3493E60 Offset: 0x3493F61 VA: 0x3493E60
	private static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self) { }

	// RVA: 0x3493F60 Offset: 0x3494061 VA: 0x3493F60
	private static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight) { }

	// RVA: 0x3494080 Offset: 0x3494181 VA: 0x3494080
	private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, object context) { }

	// RVA: 0x3494190 Offset: 0x3494291 VA: 0x3494190
	private static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver) { }
}

