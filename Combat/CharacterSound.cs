// Namespace: Combat
public sealed class CharacterSound : MonoBehaviour // TypeDefIndex: 8648
{
	// Fields
	private Character _cp; // 0x18
	private GameSound.ResultLoad m_LoadObj; // 0x20
	private string m_VoiceID; // 0x28
	private bool m_bLoaded; // 0x30
	private bool m_bWinVoicePlayed; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x282FE0 Offset: 0x2830E1 VA: 0x282FE0
	private int <VoiceCancelTimes>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x282FF0 Offset: 0x2830F1 VA: 0x282FF0
	private float <WalkingSpeed>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x283000 Offset: 0x283101 VA: 0x283000
	private bool <IsMute>k__BackingField; // 0x3C
	[TooltipAttribute] // RVA: 0x283010 Offset: 0x283111 VA: 0x283010
	public bool m_IsVoiceLoad; // 0x3D

	// Properties
	private Character CP { get; }
	public int VoiceCancelTimes { get; set; }
	public float WalkingSpeed { get; set; }
	public bool IsMute { get; set; }
	private bool IsVoiceReady { get; }

	// Methods

	// RVA: 0x29BCF30 Offset: 0x29BD031 VA: 0x29BCF30
	private Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB890 Offset: 0x2AB991 VA: 0x2AB890
	// RVA: 0x29BCFF0 Offset: 0x29BD0F1 VA: 0x29BCFF0
	public int get_VoiceCancelTimes() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB8A0 Offset: 0x2AB9A1 VA: 0x2AB8A0
	// RVA: 0x29BD000 Offset: 0x29BD101 VA: 0x29BD000
	public void set_VoiceCancelTimes(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB8B0 Offset: 0x2AB9B1 VA: 0x2AB8B0
	// RVA: 0x29BD010 Offset: 0x29BD111 VA: 0x29BD010
	public float get_WalkingSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB8C0 Offset: 0x2AB9C1 VA: 0x2AB8C0
	// RVA: 0x29BD020 Offset: 0x29BD121 VA: 0x29BD020
	public void set_WalkingSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB8D0 Offset: 0x2AB9D1 VA: 0x2AB8D0
	// RVA: 0x29BD030 Offset: 0x29BD131 VA: 0x29BD030
	public bool get_IsMute() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB8E0 Offset: 0x2AB9E1 VA: 0x2AB8E0
	// RVA: 0x29BD040 Offset: 0x29BD141 VA: 0x29BD040
	public void set_IsMute(bool value) { }

	// RVA: 0x29BD050 Offset: 0x29BD151 VA: 0x29BD050
	private void Start() { }

	// RVA: 0x29BD0F0 Offset: 0x29BD1F1 VA: 0x29BD0F0
	private void MyStart() { }

	// RVA: 0x29BD660 Offset: 0x29BD761 VA: 0x29BD660
	private void OnDestroy() { }

	// RVA: 0x29BD7A0 Offset: 0x29BD8A1 VA: 0x29BD7A0
	private bool get_IsVoiceReady() { }

	// RVA: 0x29BD590 Offset: 0x29BD691 VA: 0x29BD590
	private void LoadVoice() { }

	// RVA: 0x29BD700 Offset: 0x29BD801 VA: 0x29BD700
	private void UnloadVoice() { }

	// RVA: 0x29B2FE0 Offset: 0x29B30E1 VA: 0x29B2FE0
	public void Play(string eventName) { }

	// RVA: 0x29BDA70 Offset: 0x29BDB71 VA: 0x29BDA70
	public void PlayWithDetail(string eventName) { }

	// RVA: 0x29BDC20 Offset: 0x29BDD21 VA: 0x29BDC20
	public void PlayVoice(string eventName) { }

	// RVA: 0x29BDE50 Offset: 0x29BDF51 VA: 0x29BDE50
	public void PlayVoice_ArenaName(string eventName) { }

	// RVA: 0x29BD880 Offset: 0x29BD981 VA: 0x29BD880
	private string CalculateMobVoiceID() { }

	// RVA: 0x29BE080 Offset: 0x29BE181 VA: 0x29BE080
	public void Footstep() { }

	// RVA: 0x29BE190 Offset: 0x29BE291 VA: 0x29BE190
	public void Swing() { }

	// RVA: 0x29BE290 Offset: 0x29BE391 VA: 0x29BE290
	public void Flap() { }

	// RVA: 0x29BE330 Offset: 0x29BE431 VA: 0x29BE330
	public void WeaponOpen() { }

	// RVA: 0x29BE3F0 Offset: 0x29BE4F1 VA: 0x29BE3F0
	public void WeaponClose() { }

	// RVA: 0x29BE4B0 Offset: 0x29BE5B1 VA: 0x29BE4B0
	public void Shoot() { }

	// RVA: 0x29BE5B0 Offset: 0x29BE6B1 VA: 0x29BE5B0
	public void PlayWinVoice() { }

	// RVA: 0x29BE980 Offset: 0x29BEA81 VA: 0x29BE980
	public void OnDie() { }

	// RVA: 0x29BE600 Offset: 0x29BE701 VA: 0x29BE600
	private static string SelectWinVoice(Character chr) { }

	// RVA: 0x29BEC40 Offset: 0x29BED41 VA: 0x29BEC40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB8F0 Offset: 0x2AB9F1 VA: 0x2AB8F0
	// RVA: 0x29BEC50 Offset: 0x29BED51 VA: 0x29BEC50
	private void <Start>b__20_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB900 Offset: 0x2ABA01 VA: 0x2AB900
	// RVA: 0x29BEC60 Offset: 0x29BED61 VA: 0x29BEC60
	private void <MyStart>b__21_0(Character c) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB910 Offset: 0x2ABA11 VA: 0x2AB910
	// RVA: 0x29BEC90 Offset: 0x29BED91 VA: 0x29BEC90
	private void <MyStart>b__21_1(Character c) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB920 Offset: 0x2ABA21 VA: 0x2AB920
	// RVA: 0x29BECC0 Offset: 0x29BEDC1 VA: 0x29BECC0
	private void <MyStart>b__21_2(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB930 Offset: 0x2ABA31 VA: 0x2AB930
	// RVA: 0x29BED20 Offset: 0x29BEE21 VA: 0x29BED20
	private void <MyStart>b__21_3(Character c) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB940 Offset: 0x2ABA41 VA: 0x2AB940
	// RVA: 0x29BEE90 Offset: 0x29BEF91 VA: 0x29BEE90
	private void <MyStart>b__21_4(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB950 Offset: 0x2ABA51 VA: 0x2AB950
	// RVA: 0x29BEED0 Offset: 0x29BEFD1 VA: 0x29BEED0
	private void <MyStart>b__21_5(Character c) { }
}

