// Namespace: 
public enum AnimationPlayableAsset.LoopMode // TypeDefIndex: 5627
{
	// Fields
	public int value__; // 0x0
	[TooltipAttribute] // RVA: 0x57070 Offset: 0x57171 VA: 0x57070
	public const AnimationPlayableAsset.LoopMode UseSourceAsset = 0;
	[TooltipAttribute] // RVA: 0x570B0 Offset: 0x571B1 VA: 0x570B0
	public const AnimationPlayableAsset.LoopMode On = 1;
	[TooltipAttribute] // RVA: 0x570F0 Offset: 0x571F1 VA: 0x570F0
	public const AnimationPlayableAsset.LoopMode Off = 2;
}

// Namespace: 
private static class AnimationPlayableAsset.AnimationPlayableAssetUpgrade // TypeDefIndex: 5628
{
	// Methods

	// RVA: 0x369F5B0 Offset: 0x369F6B1 VA: 0x369F5B0
	public static void ConvertRotationToEuler(AnimationPlayableAsset asset) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x569B0 Offset: 0x56AB1 VA: 0x569B0
private sealed class AnimationPlayableAsset.<get_outputs>d__45 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable // TypeDefIndex: 5629
{
	// Fields
	private int <>1__state; // 0x10
	private PlayableBinding <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x38
	public AnimationPlayableAsset <>4__this; // 0x40

	// Properties
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x57E10 Offset: 0x57F11 VA: 0x57E10
	// RVA: 0x369EC00 Offset: 0x369ED01 VA: 0x369EC00
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x57E20 Offset: 0x57F21 VA: 0x57E20
	// RVA: 0x36B8FA0 Offset: 0x36B90A1 VA: 0x36B8FA0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x36B8FB0 Offset: 0x36B90B1 VA: 0x36B8FB0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x57E30 Offset: 0x57F31 VA: 0x57E30
	// RVA: 0x36B9050 Offset: 0x36B9151 VA: 0x36B9050 Slot: 6
	private PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x57E40 Offset: 0x57F41 VA: 0x57E40
	// RVA: 0x36B9070 Offset: 0x36B9171 VA: 0x36B9070 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x57E50 Offset: 0x57F51 VA: 0x57E50
	// RVA: 0x36B90B0 Offset: 0x36B91B1 VA: 0x36B90B0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x57E60 Offset: 0x57F61 VA: 0x57E60
	// RVA: 0x36B9120 Offset: 0x36B9221 VA: 0x36B9120 Slot: 4
	private IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x57E70 Offset: 0x57F71 VA: 0x57E70
	// RVA: 0x36B91E0 Offset: 0x36B92E1 VA: 0x36B91E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

