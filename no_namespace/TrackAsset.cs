// Namespace: 
private struct TrackAsset.TransientBuildData // TypeDefIndex: 5647
{
	// Fields
	public List<TrackAsset> trackList; // 0x0
	public List<TimelineClip> clipList; // 0x8
	public List<IMarker> markerList; // 0x10

	// Methods

	// RVA: 0x36B8CA0 Offset: 0x36B8DA1 VA: 0x36B8CA0
	public static TrackAsset.TransientBuildData Create() { }

	// RVA: 0x36B68E0 Offset: 0x36B69E1 VA: 0x36B68E0
	public void Clear() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x56AD0 Offset: 0x56BD1 VA: 0x56AD0
private sealed class TrackAsset.<get_outputs>d__65 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable // TypeDefIndex: 5648
{
	// Fields
	private int <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x38
	public TrackAsset <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x58130 Offset: 0x58231 VA: 0x58130
	// RVA: 0x36B3E90 Offset: 0x36B3F91 VA: 0x36B3E90
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x58140 Offset: 0x58241 VA: 0x58140
	// RVA: 0x36BA190 Offset: 0x36BA291 VA: 0x36BA190 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x36BA1A0 Offset: 0x36BA2A1 VA: 0x36BA1A0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x58150 Offset: 0x58251 VA: 0x58150
	// RVA: 0x36BA400 Offset: 0x36BA501 VA: 0x36BA400 Slot: 6
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x58160 Offset: 0x58261 VA: 0x58160
	// RVA: 0x36BA420 Offset: 0x36BA521 VA: 0x36BA420 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x58170 Offset: 0x58271 VA: 0x58170
	// RVA: 0x36BA460 Offset: 0x36BA561 VA: 0x36BA460 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x58180 Offset: 0x58281 VA: 0x58180
	// RVA: 0x36BA4D0 Offset: 0x36BA5D1 VA: 0x36BA4D0 Slot: 4
	private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x58190 Offset: 0x58291 VA: 0x58190
	// RVA: 0x36BA590 Offset: 0x36BA691 VA: 0x36BA590 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x56AE0 Offset: 0x56BE1 VA: 0x56AE0
[Serializable]
private sealed class TrackAsset.<>c // TypeDefIndex: 5649
{
	// Fields
	public static readonly TrackAsset.<>c <>9; // 0x0
	public static Comparison<TimelineClip> <>9__121_0; // 0x8

	// Methods

	// RVA: 0x36BA0E0 Offset: 0x36BA1E1 VA: 0x36BA0E0
	private static void .cctor() { }

	// RVA: 0x36BA150 Offset: 0x36BA251 VA: 0x36BA150
	public void .ctor() { }

	// RVA: 0x36BA160 Offset: 0x36BA261 VA: 0x36BA160
	internal int <SortClips>b__121_0(TimelineClip clip1, TimelineClip clip2) { }
}

