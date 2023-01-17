// Namespace: UnityEngine
[DefaultMemberAttribute] // RVA: 0x34720 Offset: 0x34821 VA: 0x34720
[NativeHeaderAttribute] // RVA: 0x34720 Offset: 0x34821 VA: 0x34720
public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 4082
{
	// Properties
	public AnimationClip clip { get; set; }
	public bool playAutomatically { get; set; }
	public WrapMode wrapMode { get; set; }
	public bool isPlaying { get; }
	public AnimationState Item { get; }
	public bool animatePhysics { get; set; }
	[ObsoleteAttribute] // RVA: 0x39A40 Offset: 0x39B41 VA: 0x39A40
	public bool animateOnlyIfVisible { get; set; }
	public AnimationCullingType cullingType { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0x3ECF900 Offset: 0x3ECFA01 VA: 0x3ECF900
	public AnimationClip get_clip() { }

	// RVA: 0x3ECF950 Offset: 0x3ECFA51 VA: 0x3ECF950
	public void set_clip(AnimationClip value) { }

	// RVA: 0x3ECF9A0 Offset: 0x3ECFAA1 VA: 0x3ECF9A0
	public bool get_playAutomatically() { }

	// RVA: 0x3ECF9F0 Offset: 0x3ECFAF1 VA: 0x3ECF9F0
	public void set_playAutomatically(bool value) { }

	// RVA: 0x3ECFA40 Offset: 0x3ECFB41 VA: 0x3ECFA40
	public WrapMode get_wrapMode() { }

	// RVA: 0x3ECFA90 Offset: 0x3ECFB91 VA: 0x3ECFA90
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x3ECFAE0 Offset: 0x3ECFBE1 VA: 0x3ECFAE0
	public void Stop() { }

	// RVA: 0x3ECFB30 Offset: 0x3ECFC31 VA: 0x3ECFB30
	public void Stop(string name) { }

	[NativeNameAttribute] // RVA: 0x36330 Offset: 0x36431 VA: 0x36330
	// RVA: 0x3ECFB80 Offset: 0x3ECFC81 VA: 0x3ECFB80
	private void StopNamed(string name) { }

	// RVA: 0x3ECFBD0 Offset: 0x3ECFCD1 VA: 0x3ECFBD0
	public void Rewind() { }

	// RVA: 0x3ECFC20 Offset: 0x3ECFD21 VA: 0x3ECFC20
	public void Rewind(string name) { }

	[NativeNameAttribute] // RVA: 0x36370 Offset: 0x36471 VA: 0x36370
	// RVA: 0x3ECFC70 Offset: 0x3ECFD71 VA: 0x3ECFC70
	private void RewindNamed(string name) { }

	// RVA: 0x3ECFCC0 Offset: 0x3ECFDC1 VA: 0x3ECFCC0
	public void Sample() { }

	[NativeNameAttribute] // RVA: 0x363B0 Offset: 0x364B1 VA: 0x363B0
	// RVA: 0x3ECFD10 Offset: 0x3ECFE11 VA: 0x3ECFD10
	public bool get_isPlaying() { }

	// RVA: 0x3ECFD60 Offset: 0x3ECFE61 VA: 0x3ECFD60
	public bool IsPlaying(string name) { }

	// RVA: 0x3ECFDB0 Offset: 0x3ECFEB1 VA: 0x3ECFDB0
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] // RVA: 0x363F0 Offset: 0x364F1 VA: 0x363F0
	// RVA: 0x3ECFE50 Offset: 0x3ECFF51 VA: 0x3ECFE50
	public bool Play() { }

	// RVA: 0x3ECFEA0 Offset: 0x3ECFFA1 VA: 0x3ECFEA0
	public bool Play(PlayMode mode) { }

	[NativeNameAttribute] // RVA: 0x36400 Offset: 0x36501 VA: 0x36400
	// RVA: 0x3ECFEF0 Offset: 0x3ECFFF1 VA: 0x3ECFEF0
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36440 Offset: 0x36541 VA: 0x36440
	// RVA: 0x3ECFF40 Offset: 0x3ED0041 VA: 0x3ECFF40
	public bool Play(string animation) { }

	// RVA: 0x3ECFFA0 Offset: 0x3ED00A1 VA: 0x3ECFFA0
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36450 Offset: 0x36551 VA: 0x36450
	// RVA: 0x3ED0000 Offset: 0x3ED0101 VA: 0x3ED0000
	public void CrossFade(string animation) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36460 Offset: 0x36561 VA: 0x36460
	// RVA: 0x3ED0060 Offset: 0x3ED0161 VA: 0x3ED0060
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x3ED00D0 Offset: 0x3ED01D1 VA: 0x3ED00D0
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36470 Offset: 0x36571 VA: 0x36470
	// RVA: 0x3ED0140 Offset: 0x3ED0241 VA: 0x3ED0140
	public void Blend(string animation) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36480 Offset: 0x36581 VA: 0x36480
	// RVA: 0x3ED01A0 Offset: 0x3ED02A1 VA: 0x3ED01A0
	public void Blend(string animation, float targetWeight) { }

	// RVA: 0x3ED0210 Offset: 0x3ED0311 VA: 0x3ED0210
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36490 Offset: 0x36591 VA: 0x36490
	// RVA: 0x3ED0280 Offset: 0x3ED0381 VA: 0x3ED0280
	public AnimationState CrossFadeQueued(string animation) { }

	[ExcludeFromDocsAttribute] // RVA: 0x364A0 Offset: 0x365A1 VA: 0x364A0
	// RVA: 0x3ED02F0 Offset: 0x3ED03F1 VA: 0x3ED02F0
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	[ExcludeFromDocsAttribute] // RVA: 0x364B0 Offset: 0x365B1 VA: 0x364B0
	// RVA: 0x3ED0360 Offset: 0x3ED0461 VA: 0x3ED0360
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	[FreeFunctionAttribute] // RVA: 0x364C0 Offset: 0x365C1 VA: 0x364C0
	// RVA: 0x3ED03D0 Offset: 0x3ED04D1 VA: 0x3ED03D0
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36510 Offset: 0x36611 VA: 0x36510
	// RVA: 0x3ED0450 Offset: 0x3ED0551 VA: 0x3ED0450
	public AnimationState PlayQueued(string animation) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36520 Offset: 0x36621 VA: 0x36520
	// RVA: 0x3ED04B0 Offset: 0x3ED05B1 VA: 0x3ED04B0
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	[FreeFunctionAttribute] // RVA: 0x36530 Offset: 0x36631 VA: 0x36530
	// RVA: 0x3ED0510 Offset: 0x3ED0611 VA: 0x3ED0510
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x3ED0580 Offset: 0x3ED0681 VA: 0x3ED0580
	public void AddClip(AnimationClip clip, string newName) { }

	[ExcludeFromDocsAttribute] // RVA: 0x36580 Offset: 0x36681 VA: 0x36580
	// RVA: 0x3ED05F0 Offset: 0x3ED06F1 VA: 0x3ED05F0
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x3ED0670 Offset: 0x3ED0771 VA: 0x3ED0670
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x3ED06F0 Offset: 0x3ED07F1 VA: 0x3ED06F0
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x3ED0740 Offset: 0x3ED0841 VA: 0x3ED0740
	public void RemoveClip(string clipName) { }

	[NativeNameAttribute] // RVA: 0x36590 Offset: 0x36691 VA: 0x36590
	// RVA: 0x3ED0790 Offset: 0x3ED0891 VA: 0x3ED0790
	private void RemoveClipNamed(string clipName) { }

	// RVA: 0x3ED07E0 Offset: 0x3ED08E1 VA: 0x3ED07E0
	public int GetClipCount() { }

	[ObsoleteAttribute] // RVA: 0x365D0 Offset: 0x366D1 VA: 0x365D0
	// RVA: 0x3ED0830 Offset: 0x3ED0931 VA: 0x3ED0830
	public bool Play(AnimationPlayMode mode) { }

	[ObsoleteAttribute] // RVA: 0x36610 Offset: 0x36711 VA: 0x36610
	// RVA: 0x3ED0880 Offset: 0x3ED0981 VA: 0x3ED0880
	public bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x3ED08E0 Offset: 0x3ED09E1 VA: 0x3ED08E0
	public void SyncLayer(int layer) { }

	// RVA: 0x3ED0930 Offset: 0x3ED0A31 VA: 0x3ED0930 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunctionAttribute] // RVA: 0x36650 Offset: 0x36751 VA: 0x36650
	// RVA: 0x3ECFE00 Offset: 0x3ECFF01 VA: 0x3ECFE00
	internal AnimationState GetState(string name) { }

	[FreeFunctionAttribute] // RVA: 0x366A0 Offset: 0x367A1 VA: 0x366A0
	// RVA: 0x3ED09F0 Offset: 0x3ED0AF1 VA: 0x3ED09F0
	internal AnimationState GetStateAtIndex(int index) { }

	[NativeNameAttribute] // RVA: 0x366F0 Offset: 0x367F1 VA: 0x366F0
	// RVA: 0x3ED0A40 Offset: 0x3ED0B41 VA: 0x3ED0A40
	internal int GetStateCount() { }

	// RVA: 0x3ED0A90 Offset: 0x3ED0B91 VA: 0x3ED0A90
	public AnimationClip GetClip(string name) { }

	// RVA: 0x3ED0B80 Offset: 0x3ED0C81 VA: 0x3ED0B80
	public bool get_animatePhysics() { }

	// RVA: 0x3ED0BD0 Offset: 0x3ED0CD1 VA: 0x3ED0BD0
	public void set_animatePhysics(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x36730 Offset: 0x36831 VA: 0x36730
	// RVA: 0x3ED0C20 Offset: 0x3ED0D21 VA: 0x3ED0C20
	public bool get_animateOnlyIfVisible() { }

	[FreeFunctionAttribute] // RVA: 0x36780 Offset: 0x36881 VA: 0x36780
	// RVA: 0x3ED0C70 Offset: 0x3ED0D71 VA: 0x3ED0C70
	public void set_animateOnlyIfVisible(bool value) { }

	// RVA: 0x3ED0CC0 Offset: 0x3ED0DC1 VA: 0x3ED0CC0
	public AnimationCullingType get_cullingType() { }

	// RVA: 0x3ED0D10 Offset: 0x3ED0E11 VA: 0x3ED0D10
	public void set_cullingType(AnimationCullingType value) { }

	[NativeNameAttribute] // RVA: 0x367D0 Offset: 0x368D1 VA: 0x367D0
	// RVA: 0x3ED0D60 Offset: 0x3ED0E61 VA: 0x3ED0D60
	public Bounds get_localBounds() { }

	[NativeNameAttribute] // RVA: 0x36810 Offset: 0x36911 VA: 0x36810
	// RVA: 0x3ED0E30 Offset: 0x3ED0F31 VA: 0x3ED0E30
	public void set_localBounds(Bounds value) { }

	// RVA: 0x3ED0ED0 Offset: 0x3ED0FD1 VA: 0x3ED0ED0
	public void .ctor() { }

	// RVA: 0x3ED0DE0 Offset: 0x3ED0EE1 VA: 0x3ED0DE0
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x3ED0E80 Offset: 0x3ED0F81 VA: 0x3ED0E80
	private void set_localBounds_Injected(ref Bounds value) { }
}

