// Namespace: App.RingCleaning
public class RingCleaningVoice // TypeDefIndex: 14181
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29DB50 Offset: 0x29DC51 VA: 0x29DB50
	private static bool <IsPlayableFinishVoice>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x29DB60 Offset: 0x29DC61 VA: 0x29DB60
	private static GodUnit <GodUnit>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x29DB70 Offset: 0x29DC71 VA: 0x29DB70
	private static string <GodSoundID>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29DB80 Offset: 0x29DC81 VA: 0x29DB80
	private static Character <GodChara>k__BackingField; // 0x18
	private static readonly string[] SeEventNames; // 0x20
	private static int SeIndex; // 0x28
	private static readonly string[] SeStrongEventNames; // 0x30
	private static int SeStrongIndex; // 0x38

	// Properties
	private static bool IsPlayableFinishVoice { get; set; }
	private static GodUnit GodUnit { get; set; }
	private static string GodSoundID { get; set; }
	public static Character GodChara { get; set; }
	private static string NowSeEvent { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDEC0 Offset: 0x2CDFC1 VA: 0x2CDEC0
	// RVA: 0x26836C0 Offset: 0x26837C1 VA: 0x26836C0
	private static bool get_IsPlayableFinishVoice() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDED0 Offset: 0x2CDFD1 VA: 0x2CDED0
	// RVA: 0x2683730 Offset: 0x2683831 VA: 0x2683730
	private static void set_IsPlayableFinishVoice(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDEE0 Offset: 0x2CDFE1 VA: 0x2CDEE0
	// RVA: 0x26837B0 Offset: 0x26838B1 VA: 0x26837B0
	private static GodUnit get_GodUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDEF0 Offset: 0x2CDFF1 VA: 0x2CDEF0
	// RVA: 0x2683820 Offset: 0x2683921 VA: 0x2683820
	private static void set_GodUnit(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF00 Offset: 0x2CE001 VA: 0x2CDF00
	// RVA: 0x26838A0 Offset: 0x26839A1 VA: 0x26838A0
	private static string get_GodSoundID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF10 Offset: 0x2CE011 VA: 0x2CDF10
	// RVA: 0x2683910 Offset: 0x2683A11 VA: 0x2683910
	private static void set_GodSoundID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF20 Offset: 0x2CE021 VA: 0x2CDF20
	// RVA: 0x2683990 Offset: 0x2683A91 VA: 0x2683990
	public static Character get_GodChara() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDF30 Offset: 0x2CE031 VA: 0x2CDF30
	// RVA: 0x2683A00 Offset: 0x2683B01 VA: 0x2683A00
	public static void set_GodChara(Character value) { }

	// RVA: 0x267E730 Offset: 0x267E831 VA: 0x267E730
	public static void Setup(GodUnit god) { }

	// RVA: 0x2681D50 Offset: 0x2681E51 VA: 0x2681D50
	public static void Unload() { }

	// RVA: 0x2683B30 Offset: 0x2683C31 VA: 0x2683B30
	private static bool IsFinish() { }

	// RVA: 0x2683C00 Offset: 0x2683D01 VA: 0x2683C00
	private static RingCleaningVoiceData PlayVoice(RingCleaningVoiceData.Situation situation) { }

	// RVA: 0x267F730 Offset: 0x267F831 VA: 0x267F730
	public static RingCleaningVoiceData PlayStartVoice() { }

	// RVA: 0x2681000 Offset: 0x2681101 VA: 0x2681000
	public static RingCleaningVoiceData PlayCleaningCriticalPointVoice() { }

	// RVA: 0x26813F0 Offset: 0x26814F1 VA: 0x26813F0
	public static RingCleaningVoiceData PlayStrongCleaningNotCriticalPointVoice() { }

	// RVA: 0x2681330 Offset: 0x2681431 VA: 0x2681330
	public static RingCleaningVoiceData PlayStrongCleaningCriticalPointVoice() { }

	// RVA: 0x26815B0 Offset: 0x26816B1 VA: 0x26815B0
	public static void PlayFinishCleaningVoice() { }

	// RVA: 0x2684170 Offset: 0x2684271 VA: 0x2684170
	private static string get_NowSeEvent() { }

	// RVA: 0x26806F0 Offset: 0x26807F1 VA: 0x26806F0
	public static void PlayCleaningSE() { }

	// RVA: 0x2684200 Offset: 0x2684301 VA: 0x2684200
	public static void PlayStartStrongSE() { }

	// RVA: 0x2680BD0 Offset: 0x2680CD1 VA: 0x2680BD0
	public static void PlayStrongCleaningSE() { }

	// RVA: 0x2684280 Offset: 0x2684381 VA: 0x2684280
	public void .ctor() { }

	// RVA: 0x2684290 Offset: 0x2684391 VA: 0x2684290
	private static void .cctor() { }
}

