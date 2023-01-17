// Namespace: 
public enum TimelineAsset.DurationMode // TypeDefIndex: 5643
{
	// Fields
	public int value__; // 0x0
	public const TimelineAsset.DurationMode BasedOnClips = 0;
	public const TimelineAsset.DurationMode FixedLength = 1;
}

// Namespace: 
[Serializable]
public class TimelineAsset.EditorSettings // TypeDefIndex: 5644
{
	// Fields
	internal static readonly float kMinFps; // 0x0
	internal static readonly float kMaxFps; // 0x4
	internal static readonly float kDefaultFps; // 0x8
	[SerializeField] // RVA: 0x57880 Offset: 0x57981 VA: 0x57880
	[HideInInspector] // RVA: 0x57880 Offset: 0x57981 VA: 0x57880
	private float m_Framerate; // 0x10
	[HideInInspector] // RVA: 0x578C0 Offset: 0x579C1 VA: 0x578C0
	[SerializeField] // RVA: 0x578C0 Offset: 0x579C1 VA: 0x578C0
	private bool m_ScenePreview; // 0x14

	// Properties
	public float fps { get; set; }

	// Methods

	// RVA: 0x36B9FA0 Offset: 0x36BA0A1 VA: 0x36B9FA0
	public float get_fps() { }

	// RVA: 0x36AC220 Offset: 0x36AC321 VA: 0x36AC220
	public void set_fps(float value) { }

	// RVA: 0x36AF6F0 Offset: 0x36AF7F1 VA: 0x36AF6F0
	public void .ctor() { }

	// RVA: 0x36B9FB0 Offset: 0x36BA0B1 VA: 0x36B9FB0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x56AB0 Offset: 0x56BB1 VA: 0x56AB0
private sealed class TimelineAsset.<get_outputs>d__27 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable // TypeDefIndex: 5645
{
	// Fields
	private int <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x38
	public TimelineAsset <>4__this; // 0x40
	private IEnumerator<TrackAsset> <>7__wrap1; // 0x48
	private IEnumerator<PlayableBinding> <>7__wrap2; // 0x50

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x58010 Offset: 0x58111 VA: 0x58010
	// RVA: 0x36AB500 Offset: 0x36AB601 VA: 0x36AB500
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x58020 Offset: 0x58121 VA: 0x58020
	// RVA: 0x36B95A0 Offset: 0x36B96A1 VA: 0x36B95A0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x36B98E0 Offset: 0x36B99E1 VA: 0x36B98E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x36B9820 Offset: 0x36B9921 VA: 0x36B9820
	private void <>m__Finally1() { }

	// RVA: 0x36B9760 Offset: 0x36B9861 VA: 0x36B9760
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x58030 Offset: 0x58131 VA: 0x58030
	// RVA: 0x36B9E00 Offset: 0x36B9F01 VA: 0x36B9E00 Slot: 6
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x58040 Offset: 0x58141 VA: 0x58040
	// RVA: 0x36B9E20 Offset: 0x36B9F21 VA: 0x36B9E20 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x58050 Offset: 0x58151 VA: 0x58050
	// RVA: 0x36B9E60 Offset: 0x36B9F61 VA: 0x36B9E60 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x58060 Offset: 0x58161 VA: 0x58060
	// RVA: 0x36B9ED0 Offset: 0x36B9FD1 VA: 0x36B9ED0 Slot: 4
	private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x58070 Offset: 0x58171 VA: 0x58070
	// RVA: 0x36B9F90 Offset: 0x36BA091 VA: 0x36B9F90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

