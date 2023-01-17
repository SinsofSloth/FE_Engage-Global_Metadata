// Namespace: UnityEngine.Video
[RequiredByNativeCodeAttribute] // RVA: 0x66770 Offset: 0x66871 VA: 0x66770
[NativeHeaderAttribute] // RVA: 0x66770 Offset: 0x66871 VA: 0x66770
[RequireComponent] // RVA: 0x66770 Offset: 0x66871 VA: 0x66770
public sealed class VideoPlayer : Behaviour // TypeDefIndex: 7596
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x66810 Offset: 0x66911 VA: 0x66810
	[CompilerGeneratedAttribute] // RVA: 0x66810 Offset: 0x66911 VA: 0x66810
	private VideoPlayer.EventHandler prepareCompleted; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x66850 Offset: 0x66951 VA: 0x66850
	[DebuggerBrowsableAttribute] // RVA: 0x66850 Offset: 0x66951 VA: 0x66850
	private VideoPlayer.EventHandler loopPointReached; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x66890 Offset: 0x66991 VA: 0x66890
	[CompilerGeneratedAttribute] // RVA: 0x66890 Offset: 0x66991 VA: 0x66890
	private VideoPlayer.EventHandler started; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x668D0 Offset: 0x669D1 VA: 0x668D0
	[CompilerGeneratedAttribute] // RVA: 0x668D0 Offset: 0x669D1 VA: 0x668D0
	private VideoPlayer.EventHandler frameDropped; // 0x30
	[DebuggerBrowsableAttribute] // RVA: 0x66910 Offset: 0x66A11 VA: 0x66910
	[CompilerGeneratedAttribute] // RVA: 0x66910 Offset: 0x66A11 VA: 0x66910
	private VideoPlayer.ErrorEventHandler errorReceived; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x66950 Offset: 0x66A51 VA: 0x66950
	[DebuggerBrowsableAttribute] // RVA: 0x66950 Offset: 0x66A51 VA: 0x66950
	private VideoPlayer.EventHandler seekCompleted; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x66990 Offset: 0x66A91 VA: 0x66990
	[DebuggerBrowsableAttribute] // RVA: 0x66990 Offset: 0x66A91 VA: 0x66990
	private VideoPlayer.TimeEventHandler clockResyncOccurred; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x669D0 Offset: 0x66AD1 VA: 0x669D0
	[DebuggerBrowsableAttribute] // RVA: 0x669D0 Offset: 0x66AD1 VA: 0x669D0
	private VideoPlayer.FrameReadyEventHandler frameReady; // 0x50

	// Properties
	public VideoSource source { get; set; }
	[NativeNameAttribute] // RVA: 0x66E90 Offset: 0x66F91 VA: 0x66E90
	public string url { get; set; }
	[NativeNameAttribute] // RVA: 0x66ED0 Offset: 0x66FD1 VA: 0x66ED0
	public VideoClip clip { get; set; }
	public VideoRenderMode renderMode { get; set; }
	[NativeHeaderAttribute] // RVA: 0x66F10 Offset: 0x67011 VA: 0x66F10
	public Camera targetCamera { get; set; }
	[NativeHeaderAttribute] // RVA: 0x66F50 Offset: 0x67051 VA: 0x66F50
	public RenderTexture targetTexture { get; set; }
	[NativeHeaderAttribute] // RVA: 0x66F90 Offset: 0x67091 VA: 0x66F90
	public Renderer targetMaterialRenderer { get; set; }
	public string targetMaterialProperty { get; set; }
	public VideoAspectRatio aspectRatio { get; set; }
	public float targetCameraAlpha { get; set; }
	public Video3DLayout targetCamera3DLayout { get; set; }
	[NativeHeaderAttribute] // RVA: 0x66FD0 Offset: 0x670D1 VA: 0x66FD0
	public Texture texture { get; }
	public bool isPrepared { get; }
	public bool waitForFirstFrame { get; set; }
	public bool playOnAwake { get; set; }
	public bool isPlaying { get; }
	public bool isPaused { get; }
	public bool canSetTime { get; }
	[NativeNameAttribute] // RVA: 0x67010 Offset: 0x67111 VA: 0x67010
	public double time { get; set; }
	[NativeNameAttribute] // RVA: 0x67050 Offset: 0x67151 VA: 0x67050
	public long frame { get; set; }
	public double clockTime { get; }
	public bool canStep { get; }
	public bool canSetPlaybackSpeed { get; }
	public float playbackSpeed { get; set; }
	[NativeNameAttribute] // RVA: 0x67090 Offset: 0x67191 VA: 0x67090
	public bool isLooping { get; set; }
	public bool canSetTimeSource { get; }
	public VideoTimeSource timeSource { get; set; }
	public VideoTimeReference timeReference { get; set; }
	public double externalReferenceTime { get; set; }
	public bool canSetSkipOnDrop { get; }
	public bool skipOnDrop { get; set; }
	public ulong frameCount { get; }
	public float frameRate { get; }
	[NativeNameAttribute] // RVA: 0x670D0 Offset: 0x671D1 VA: 0x670D0
	public double length { get; }
	public uint width { get; }
	public uint height { get; }
	public uint pixelAspectRatioNumerator { get; }
	public uint pixelAspectRatioDenominator { get; }
	public ushort audioTrackCount { get; }
	public static ushort controlledAudioTrackMaxCount { get; }
	public ushort controlledAudioTrackCount { get; set; }
	public VideoAudioOutputMode audioOutputMode { get; set; }
	public bool canSetDirectAudioVolume { get; }
	public bool sendFrameReadyEvents { get; set; }

	// Methods

	// RVA: 0x1C5D8E0 Offset: 0x1C5D9E1 VA: 0x1C5D8E0
	public VideoSource get_source() { }

	// RVA: 0x1C5D930 Offset: 0x1C5DA31 VA: 0x1C5D930
	public void set_source(VideoSource value) { }

	// RVA: 0x1C5D980 Offset: 0x1C5DA81 VA: 0x1C5D980
	public string get_url() { }

	// RVA: 0x1C5D9D0 Offset: 0x1C5DAD1 VA: 0x1C5D9D0
	public void set_url(string value) { }

	// RVA: 0x1C5DA20 Offset: 0x1C5DB21 VA: 0x1C5DA20
	public VideoClip get_clip() { }

	// RVA: 0x1C5DA70 Offset: 0x1C5DB71 VA: 0x1C5DA70
	public void set_clip(VideoClip value) { }

	// RVA: 0x1C5DAC0 Offset: 0x1C5DBC1 VA: 0x1C5DAC0
	public VideoRenderMode get_renderMode() { }

	// RVA: 0x1C5DB10 Offset: 0x1C5DC11 VA: 0x1C5DB10
	public void set_renderMode(VideoRenderMode value) { }

	// RVA: 0x1C5DB60 Offset: 0x1C5DC61 VA: 0x1C5DB60
	public Camera get_targetCamera() { }

	// RVA: 0x1C5DBB0 Offset: 0x1C5DCB1 VA: 0x1C5DBB0
	public void set_targetCamera(Camera value) { }

	// RVA: 0x1C5DC00 Offset: 0x1C5DD01 VA: 0x1C5DC00
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1C5DC50 Offset: 0x1C5DD51 VA: 0x1C5DC50
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x1C5DCA0 Offset: 0x1C5DDA1 VA: 0x1C5DCA0
	public Renderer get_targetMaterialRenderer() { }

	// RVA: 0x1C5DCF0 Offset: 0x1C5DDF1 VA: 0x1C5DCF0
	public void set_targetMaterialRenderer(Renderer value) { }

	// RVA: 0x1C5DD40 Offset: 0x1C5DE41 VA: 0x1C5DD40
	public string get_targetMaterialProperty() { }

	// RVA: 0x1C5DD90 Offset: 0x1C5DE91 VA: 0x1C5DD90
	public void set_targetMaterialProperty(string value) { }

	// RVA: 0x1C5DDE0 Offset: 0x1C5DEE1 VA: 0x1C5DDE0
	public VideoAspectRatio get_aspectRatio() { }

	// RVA: 0x1C5DE30 Offset: 0x1C5DF31 VA: 0x1C5DE30
	public void set_aspectRatio(VideoAspectRatio value) { }

	// RVA: 0x1C5DE80 Offset: 0x1C5DF81 VA: 0x1C5DE80
	public float get_targetCameraAlpha() { }

	// RVA: 0x1C5DED0 Offset: 0x1C5DFD1 VA: 0x1C5DED0
	public void set_targetCameraAlpha(float value) { }

	// RVA: 0x1C5DF20 Offset: 0x1C5E021 VA: 0x1C5DF20
	public Video3DLayout get_targetCamera3DLayout() { }

	// RVA: 0x1C5DF70 Offset: 0x1C5E071 VA: 0x1C5DF70
	public void set_targetCamera3DLayout(Video3DLayout value) { }

	// RVA: 0x1C5DFC0 Offset: 0x1C5E0C1 VA: 0x1C5DFC0
	public Texture get_texture() { }

	// RVA: 0x1C5E010 Offset: 0x1C5E111 VA: 0x1C5E010
	public void Prepare() { }

	[NativeNameAttribute] // RVA: 0x66A10 Offset: 0x66B11 VA: 0x66A10
	// RVA: 0x1C5E060 Offset: 0x1C5E161 VA: 0x1C5E060
	public bool get_isPrepared() { }

	// RVA: 0x1C5E0B0 Offset: 0x1C5E1B1 VA: 0x1C5E0B0
	public bool get_waitForFirstFrame() { }

	// RVA: 0x1C5E100 Offset: 0x1C5E201 VA: 0x1C5E100
	public void set_waitForFirstFrame(bool value) { }

	// RVA: 0x1C5E150 Offset: 0x1C5E251 VA: 0x1C5E150
	public bool get_playOnAwake() { }

	// RVA: 0x1C5E1A0 Offset: 0x1C5E2A1 VA: 0x1C5E1A0
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1C5E1F0 Offset: 0x1C5E2F1 VA: 0x1C5E1F0
	public void Play() { }

	// RVA: 0x1C5E240 Offset: 0x1C5E341 VA: 0x1C5E240
	public void Pause() { }

	// RVA: 0x1C5E290 Offset: 0x1C5E391 VA: 0x1C5E290
	public void Stop() { }

	[NativeNameAttribute] // RVA: 0x66A50 Offset: 0x66B51 VA: 0x66A50
	// RVA: 0x1C5E2E0 Offset: 0x1C5E3E1 VA: 0x1C5E2E0
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0x66A90 Offset: 0x66B91 VA: 0x66A90
	// RVA: 0x1C5E330 Offset: 0x1C5E431 VA: 0x1C5E330
	public bool get_isPaused() { }

	[NativeNameAttribute] // RVA: 0x66AD0 Offset: 0x66BD1 VA: 0x66AD0
	// RVA: 0x1C5E380 Offset: 0x1C5E481 VA: 0x1C5E380
	public bool get_canSetTime() { }

	// RVA: 0x1C5E3D0 Offset: 0x1C5E4D1 VA: 0x1C5E3D0
	public double get_time() { }

	// RVA: 0x1C5E420 Offset: 0x1C5E521 VA: 0x1C5E420
	public void set_time(double value) { }

	// RVA: 0x1C5E470 Offset: 0x1C5E571 VA: 0x1C5E470
	public long get_frame() { }

	// RVA: 0x1C5E4C0 Offset: 0x1C5E5C1 VA: 0x1C5E4C0
	public void set_frame(long value) { }

	// RVA: 0x1C5E510 Offset: 0x1C5E611 VA: 0x1C5E510
	public double get_clockTime() { }

	[NativeNameAttribute] // RVA: 0x66B10 Offset: 0x66C11 VA: 0x66B10
	// RVA: 0x1C5E560 Offset: 0x1C5E661 VA: 0x1C5E560
	public bool get_canStep() { }

	// RVA: 0x1C5E5B0 Offset: 0x1C5E6B1 VA: 0x1C5E5B0
	public void StepForward() { }

	[NativeNameAttribute] // RVA: 0x66B50 Offset: 0x66C51 VA: 0x66B50
	// RVA: 0x1C5E600 Offset: 0x1C5E701 VA: 0x1C5E600
	public bool get_canSetPlaybackSpeed() { }

	// RVA: 0x1C5E650 Offset: 0x1C5E751 VA: 0x1C5E650
	public float get_playbackSpeed() { }

	// RVA: 0x1C5E6A0 Offset: 0x1C5E7A1 VA: 0x1C5E6A0
	public void set_playbackSpeed(float value) { }

	// RVA: 0x1C5E6F0 Offset: 0x1C5E7F1 VA: 0x1C5E6F0
	public bool get_isLooping() { }

	// RVA: 0x1C5E740 Offset: 0x1C5E841 VA: 0x1C5E740
	public void set_isLooping(bool value) { }

	[NativeNameAttribute] // RVA: 0x66B90 Offset: 0x66C91 VA: 0x66B90
	// RVA: 0x1C5E790 Offset: 0x1C5E891 VA: 0x1C5E790
	public bool get_canSetTimeSource() { }

	// RVA: 0x1C5E7E0 Offset: 0x1C5E8E1 VA: 0x1C5E7E0
	public VideoTimeSource get_timeSource() { }

	// RVA: 0x1C5E830 Offset: 0x1C5E931 VA: 0x1C5E830
	public void set_timeSource(VideoTimeSource value) { }

	// RVA: 0x1C5E880 Offset: 0x1C5E981 VA: 0x1C5E880
	public VideoTimeReference get_timeReference() { }

	// RVA: 0x1C5E8D0 Offset: 0x1C5E9D1 VA: 0x1C5E8D0
	public void set_timeReference(VideoTimeReference value) { }

	// RVA: 0x1C5E920 Offset: 0x1C5EA21 VA: 0x1C5E920
	public double get_externalReferenceTime() { }

	// RVA: 0x1C5E970 Offset: 0x1C5EA71 VA: 0x1C5E970
	public void set_externalReferenceTime(double value) { }

	[NativeNameAttribute] // RVA: 0x66BD0 Offset: 0x66CD1 VA: 0x66BD0
	// RVA: 0x1C5E9C0 Offset: 0x1C5EAC1 VA: 0x1C5E9C0
	public bool get_canSetSkipOnDrop() { }

	// RVA: 0x1C5EA10 Offset: 0x1C5EB11 VA: 0x1C5EA10
	public bool get_skipOnDrop() { }

	// RVA: 0x1C5EA60 Offset: 0x1C5EB61 VA: 0x1C5EA60
	public void set_skipOnDrop(bool value) { }

	// RVA: 0x1C5EAB0 Offset: 0x1C5EBB1 VA: 0x1C5EAB0
	public ulong get_frameCount() { }

	// RVA: 0x1C5EB00 Offset: 0x1C5EC01 VA: 0x1C5EB00
	public float get_frameRate() { }

	// RVA: 0x1C5EB50 Offset: 0x1C5EC51 VA: 0x1C5EB50
	public double get_length() { }

	// RVA: 0x1C5EBA0 Offset: 0x1C5ECA1 VA: 0x1C5EBA0
	public uint get_width() { }

	// RVA: 0x1C5EBF0 Offset: 0x1C5ECF1 VA: 0x1C5EBF0
	public uint get_height() { }

	// RVA: 0x1C5EC40 Offset: 0x1C5ED41 VA: 0x1C5EC40
	public uint get_pixelAspectRatioNumerator() { }

	// RVA: 0x1C5EC90 Offset: 0x1C5ED91 VA: 0x1C5EC90
	public uint get_pixelAspectRatioDenominator() { }

	// RVA: 0x1C5ECE0 Offset: 0x1C5EDE1 VA: 0x1C5ECE0
	public ushort get_audioTrackCount() { }

	// RVA: 0x1C5ED30 Offset: 0x1C5EE31 VA: 0x1C5ED30
	public string GetAudioLanguageCode(ushort trackIndex) { }

	// RVA: 0x1C5ED80 Offset: 0x1C5EE81 VA: 0x1C5ED80
	public ushort GetAudioChannelCount(ushort trackIndex) { }

	// RVA: 0x1C5EDD0 Offset: 0x1C5EED1 VA: 0x1C5EDD0
	public uint GetAudioSampleRate(ushort trackIndex) { }

	// RVA: 0x1C5EE20 Offset: 0x1C5EF21 VA: 0x1C5EE20
	public static ushort get_controlledAudioTrackMaxCount() { }

	// RVA: 0x1C5EE60 Offset: 0x1C5EF61 VA: 0x1C5EE60
	public ushort get_controlledAudioTrackCount() { }

	// RVA: 0x1C5EF00 Offset: 0x1C5F001 VA: 0x1C5EF00
	public void set_controlledAudioTrackCount(ushort value) { }

	// RVA: 0x1C5EEB0 Offset: 0x1C5EFB1 VA: 0x1C5EEB0
	private ushort GetControlledAudioTrackCount() { }

	// RVA: 0x1C5F010 Offset: 0x1C5F111 VA: 0x1C5F010
	private void SetControlledAudioTrackCount(ushort value) { }

	// RVA: 0x1C5F060 Offset: 0x1C5F161 VA: 0x1C5F060
	public void EnableAudioTrack(ushort trackIndex, bool enabled) { }

	// RVA: 0x1C5F0C0 Offset: 0x1C5F1C1 VA: 0x1C5F0C0
	public bool IsAudioTrackEnabled(ushort trackIndex) { }

	// RVA: 0x1C5F110 Offset: 0x1C5F211 VA: 0x1C5F110
	public VideoAudioOutputMode get_audioOutputMode() { }

	// RVA: 0x1C5F160 Offset: 0x1C5F261 VA: 0x1C5F160
	public void set_audioOutputMode(VideoAudioOutputMode value) { }

	[NativeNameAttribute] // RVA: 0x66C10 Offset: 0x66D11 VA: 0x66C10
	// RVA: 0x1C5F1B0 Offset: 0x1C5F2B1 VA: 0x1C5F1B0
	public bool get_canSetDirectAudioVolume() { }

	// RVA: 0x1C5F200 Offset: 0x1C5F301 VA: 0x1C5F200
	public float GetDirectAudioVolume(ushort trackIndex) { }

	// RVA: 0x1C5F250 Offset: 0x1C5F351 VA: 0x1C5F250
	public void SetDirectAudioVolume(ushort trackIndex, float volume) { }

	// RVA: 0x1C5F2B0 Offset: 0x1C5F3B1 VA: 0x1C5F2B0
	public bool GetDirectAudioMute(ushort trackIndex) { }

	// RVA: 0x1C5F300 Offset: 0x1C5F401 VA: 0x1C5F300
	public void SetDirectAudioMute(ushort trackIndex, bool mute) { }

	[NativeHeaderAttribute] // RVA: 0x66C50 Offset: 0x66D51 VA: 0x66C50
	// RVA: 0x1C5F360 Offset: 0x1C5F461 VA: 0x1C5F360
	public AudioSource GetTargetAudioSource(ushort trackIndex) { }

	// RVA: 0x1C5F3B0 Offset: 0x1C5F4B1 VA: 0x1C5F3B0
	public void SetTargetAudioSource(ushort trackIndex, AudioSource source) { }

	[CompilerGeneratedAttribute] // RVA: 0x66C90 Offset: 0x66D91 VA: 0x66C90
	// RVA: 0x1C5F410 Offset: 0x1C5F511 VA: 0x1C5F410
	public void add_prepareCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66CA0 Offset: 0x66DA1 VA: 0x66CA0
	// RVA: 0x1C5F4C0 Offset: 0x1C5F5C1 VA: 0x1C5F4C0
	public void remove_prepareCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66CB0 Offset: 0x66DB1 VA: 0x66CB0
	// RVA: 0x1C5F570 Offset: 0x1C5F671 VA: 0x1C5F570
	public void add_loopPointReached(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66CC0 Offset: 0x66DC1 VA: 0x66CC0
	// RVA: 0x1C5F620 Offset: 0x1C5F721 VA: 0x1C5F620
	public void remove_loopPointReached(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66CD0 Offset: 0x66DD1 VA: 0x66CD0
	// RVA: 0x1C5F6D0 Offset: 0x1C5F7D1 VA: 0x1C5F6D0
	public void add_started(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66CE0 Offset: 0x66DE1 VA: 0x66CE0
	// RVA: 0x1C5F780 Offset: 0x1C5F881 VA: 0x1C5F780
	public void remove_started(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66CF0 Offset: 0x66DF1 VA: 0x66CF0
	// RVA: 0x1C5F830 Offset: 0x1C5F931 VA: 0x1C5F830
	public void add_frameDropped(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66D00 Offset: 0x66E01 VA: 0x66D00
	// RVA: 0x1C5F8E0 Offset: 0x1C5F9E1 VA: 0x1C5F8E0
	public void remove_frameDropped(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66D10 Offset: 0x66E11 VA: 0x66D10
	// RVA: 0x1C5F990 Offset: 0x1C5FA91 VA: 0x1C5F990
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66D20 Offset: 0x66E21 VA: 0x66D20
	// RVA: 0x1C5FA40 Offset: 0x1C5FB41 VA: 0x1C5FA40
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66D30 Offset: 0x66E31 VA: 0x66D30
	// RVA: 0x1C5FAF0 Offset: 0x1C5FBF1 VA: 0x1C5FAF0
	public void add_seekCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66D40 Offset: 0x66E41 VA: 0x66D40
	// RVA: 0x1C5FBA0 Offset: 0x1C5FCA1 VA: 0x1C5FBA0
	public void remove_seekCompleted(VideoPlayer.EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66D50 Offset: 0x66E51 VA: 0x66D50
	// RVA: 0x1C5FC50 Offset: 0x1C5FD51 VA: 0x1C5FC50
	public void add_clockResyncOccurred(VideoPlayer.TimeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66D60 Offset: 0x66E61 VA: 0x66D60
	// RVA: 0x1C5FD00 Offset: 0x1C5FE01 VA: 0x1C5FD00
	public void remove_clockResyncOccurred(VideoPlayer.TimeEventHandler value) { }

	[NativeNameAttribute] // RVA: 0x66D70 Offset: 0x66E71 VA: 0x66D70
	// RVA: 0x1C5FDB0 Offset: 0x1C5FEB1 VA: 0x1C5FDB0
	public bool get_sendFrameReadyEvents() { }

	[NativeNameAttribute] // RVA: 0x66DB0 Offset: 0x66EB1 VA: 0x66DB0
	// RVA: 0x1C5FE00 Offset: 0x1C5FF01 VA: 0x1C5FE00
	public void set_sendFrameReadyEvents(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66DF0 Offset: 0x66EF1 VA: 0x66DF0
	// RVA: 0x1C5FE50 Offset: 0x1C5FF51 VA: 0x1C5FE50
	public void add_frameReady(VideoPlayer.FrameReadyEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x66E00 Offset: 0x66F01 VA: 0x66E00
	// RVA: 0x1C5FF00 Offset: 0x1C60001 VA: 0x1C5FF00
	public void remove_frameReady(VideoPlayer.FrameReadyEventHandler value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E10 Offset: 0x66F11 VA: 0x66E10
	// RVA: 0x1C5FFB0 Offset: 0x1C600B1 VA: 0x1C5FFB0
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E20 Offset: 0x66F21 VA: 0x66E20
	// RVA: 0x1C60330 Offset: 0x1C60431 VA: 0x1C60330
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E30 Offset: 0x66F31 VA: 0x66E30
	// RVA: 0x1C606C0 Offset: 0x1C607C1 VA: 0x1C606C0
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E40 Offset: 0x66F41 VA: 0x66E40
	// RVA: 0x1C606E0 Offset: 0x1C607E1 VA: 0x1C606E0
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E50 Offset: 0x66F51 VA: 0x66E50
	// RVA: 0x1C60700 Offset: 0x1C60801 VA: 0x1C60700
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E60 Offset: 0x66F61 VA: 0x66E60
	// RVA: 0x1C60720 Offset: 0x1C60821 VA: 0x1C60720
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E70 Offset: 0x66F71 VA: 0x66E70
	// RVA: 0x1C60AB0 Offset: 0x1C60BB1 VA: 0x1C60AB0
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x66E80 Offset: 0x66F81 VA: 0x66E80
	// RVA: 0x1C60AD0 Offset: 0x1C60BD1 VA: 0x1C60AD0
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	// RVA: 0x1C60E60 Offset: 0x1C60F61 VA: 0x1C60E60
	public void .ctor() { }
}

