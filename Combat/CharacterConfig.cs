// Namespace: Combat
public sealed class CharacterConfig : MonoBehaviour // TypeDefIndex: 8593
{
	// Fields
	[SerializeField] // RVA: 0x282450 Offset: 0x282551 VA: 0x282450
	private float InitialDebugPlaybackRate; // 0x18
	[SerializeField] // RVA: 0x282460 Offset: 0x282561 VA: 0x282460
	private float InitialBackwardCancelRatio; // 0x1C
	[SerializeField] // RVA: 0x282470 Offset: 0x282571 VA: 0x282470
	private float InitialHeavinessFactor; // 0x20
	[SerializeField] // RVA: 0x282480 Offset: 0x282581 VA: 0x282480
	private float InitialAgilityFactor; // 0x24
	[SerializeField] // RVA: 0x282490 Offset: 0x282591 VA: 0x282490
	private float InitialHitRatio; // 0x28
	[SerializeField] // RVA: 0x2824A0 Offset: 0x2825A1 VA: 0x2824A0
	private float InitialCriticalRatio; // 0x2C
	[SerializeField] // RVA: 0x2824B0 Offset: 0x2825B1 VA: 0x2824B0
	private float InitialGuardRatio; // 0x30
	[SerializeField] // RVA: 0x2824C0 Offset: 0x2825C1 VA: 0x2824C0
	private float InitialDamageRatio; // 0x34
	[SerializeField] // RVA: 0x2824D0 Offset: 0x2825D1 VA: 0x2824D0
	private float InitialAttackRatio; // 0x38
	private ReactiveProperty<float> rxDebugPlaybackRate; // 0x40
	private ReactiveProperty<float> rxBackwardCancelRatio; // 0x48
	private ReactiveProperty<float> rxHeavinessFactor; // 0x50
	private ReactiveProperty<float> rxAgilityFactor; // 0x58
	private ReactiveProperty<float> rxHitRatio; // 0x60
	private ReactiveProperty<float> rxCriticalRatio; // 0x68
	private ReactiveProperty<float> rxGuardRatio; // 0x70
	private ReactiveProperty<float> rxDamageRatio; // 0x78
	private ReactiveProperty<float> rxAttackRatio; // 0x80
	private Character _cp; // 0x88

	// Properties
	public float DebugPlaybackRate { get; set; }
	public float BackwardCancelRatio { get; set; }
	public float HeavinessFactor { get; set; }
	public float AgilityFactor { get; set; }
	public float HitRatio { get; set; }
	public float CriticalRatio { get; set; }
	public float GuardRatio { get; set; }
	public float DamageRatio { get; set; }
	public float AttackRatio { get; set; }
	private Character CP { get; }

	// Methods

	// RVA: 0x2B6F650 Offset: 0x2B6F751 VA: 0x2B6F650
	public void set_DebugPlaybackRate(float value) { }

	// RVA: 0x2B6F6C0 Offset: 0x2B6F7C1 VA: 0x2B6F6C0
	public float get_DebugPlaybackRate() { }

	// RVA: 0x2B6F710 Offset: 0x2B6F811 VA: 0x2B6F710
	public void set_BackwardCancelRatio(float value) { }

	// RVA: 0x2B6F780 Offset: 0x2B6F881 VA: 0x2B6F780
	public float get_BackwardCancelRatio() { }

	// RVA: 0x2B6F7D0 Offset: 0x2B6F8D1 VA: 0x2B6F7D0
	public void set_HeavinessFactor(float value) { }

	// RVA: 0x2B6F840 Offset: 0x2B6F941 VA: 0x2B6F840
	public float get_HeavinessFactor() { }

	// RVA: 0x2B6F890 Offset: 0x2B6F991 VA: 0x2B6F890
	public void set_AgilityFactor(float value) { }

	// RVA: 0x2B6F900 Offset: 0x2B6FA01 VA: 0x2B6F900
	public float get_AgilityFactor() { }

	// RVA: 0x2B6F950 Offset: 0x2B6FA51 VA: 0x2B6F950
	public void set_HitRatio(float value) { }

	// RVA: 0x2B6F9C0 Offset: 0x2B6FAC1 VA: 0x2B6F9C0
	public float get_HitRatio() { }

	// RVA: 0x2B6FA10 Offset: 0x2B6FB11 VA: 0x2B6FA10
	public void set_CriticalRatio(float value) { }

	// RVA: 0x2B6FA80 Offset: 0x2B6FB81 VA: 0x2B6FA80
	public float get_CriticalRatio() { }

	// RVA: 0x2B6FAD0 Offset: 0x2B6FBD1 VA: 0x2B6FAD0
	public void set_GuardRatio(float value) { }

	// RVA: 0x2B6FB40 Offset: 0x2B6FC41 VA: 0x2B6FB40
	public float get_GuardRatio() { }

	// RVA: 0x2B6FB90 Offset: 0x2B6FC91 VA: 0x2B6FB90
	public void set_DamageRatio(float value) { }

	// RVA: 0x2B6FC00 Offset: 0x2B6FD01 VA: 0x2B6FC00
	public float get_DamageRatio() { }

	// RVA: 0x2B6FC50 Offset: 0x2B6FD51 VA: 0x2B6FC50
	public void set_AttackRatio(float value) { }

	// RVA: 0x2B6FCC0 Offset: 0x2B6FDC1 VA: 0x2B6FCC0
	public float get_AttackRatio() { }

	// RVA: 0x2B6FD10 Offset: 0x2B6FE11 VA: 0x2B6FD10
	private void Reset() { }

	// RVA: 0x2B6FF20 Offset: 0x2B70021 VA: 0x2B6FF20
	private void Load() { }

	// RVA: 0x2B70140 Offset: 0x2B70241 VA: 0x2B70140
	public void Save() { }

	// RVA: 0x2B702F0 Offset: 0x2B703F1 VA: 0x2B702F0
	private Character get_CP() { }

	// RVA: 0x2B703B0 Offset: 0x2B704B1 VA: 0x2B703B0
	private void Start() { }

	// RVA: 0x2B70450 Offset: 0x2B70551 VA: 0x2B70450
	public void StartImpl() { }

	// RVA: 0x2B70460 Offset: 0x2B70561 VA: 0x2B70460
	private void OnDestroy() { }

	// RVA: 0x2B70940 Offset: 0x2B70A41 VA: 0x2B70940
	private void InternalGUI() { }

	// RVA: 0x2B70D80 Offset: 0x2B70E81 VA: 0x2B70D80
	public int GetAttackSideByDice() { }

	// RVA: 0x2B70E70 Offset: 0x2B70F71 VA: 0x2B70E70
	public Phase MakePhaseD() { }

	// RVA: 0x2B70E40 Offset: 0x2B70F41 VA: 0x2B70E40
	private static bool IN(float value) { }

	// RVA: 0x2B71160 Offset: 0x2B71261 VA: 0x2B71160
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA8D0 Offset: 0x2AA9D1 VA: 0x2AA8D0
	// RVA: 0x2B71310 Offset: 0x2B71411 VA: 0x2B71310
	private void <InternalGUI>b__54_0() { }
}

