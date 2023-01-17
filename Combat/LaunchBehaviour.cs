// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2746B0 Offset: 0x2747B1 VA: 0x2746B0
public abstract class LaunchBehaviour : MonoBehaviour // TypeDefIndex: 8775
{
	// Fields
	private Character _cp; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284330 Offset: 0x284431 VA: 0x284330
	private GameObject <WeaponInstance>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x284340 Offset: 0x284441 VA: 0x284340
	private float <FlyingTime>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x284350 Offset: 0x284451 VA: 0x284350
	private float <WorldHitTime>k__BackingField; // 0x2C
	protected CompositeDisposable m_CompositeDisposable; // 0x30

	// Properties
	protected Character CP { get; }
	public GameObject WeaponInstance { get; set; }
	public float FlyingTime { get; set; }
	public float WorldHitTime { get; set; }

	// Methods

	// RVA: 0x1F81C20 Offset: 0x1F81D21 VA: 0x1F81C20
	protected Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACAF0 Offset: 0x2ACBF1 VA: 0x2ACAF0
	// RVA: 0x1F81CE0 Offset: 0x1F81DE1 VA: 0x1F81CE0
	public GameObject get_WeaponInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACB00 Offset: 0x2ACC01 VA: 0x2ACB00
	// RVA: 0x1F81CF0 Offset: 0x1F81DF1 VA: 0x1F81CF0
	protected void set_WeaponInstance(GameObject value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnCharacterSetup(Character owner);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnEnterAttack();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnHitTimePredicted(float worldHitTime);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void RecalcFlyingTime();

	[CompilerGeneratedAttribute] // RVA: 0x2ACB10 Offset: 0x2ACC11 VA: 0x2ACB10
	// RVA: 0x1F81D00 Offset: 0x1F81E01 VA: 0x1F81D00
	public float get_FlyingTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACB20 Offset: 0x2ACC21 VA: 0x2ACB20
	// RVA: 0x1F81D10 Offset: 0x1F81E11 VA: 0x1F81D10
	protected void set_FlyingTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACB30 Offset: 0x2ACC31 VA: 0x2ACB30
	// RVA: 0x1F81D20 Offset: 0x1F81E21 VA: 0x1F81D20
	public float get_WorldHitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACB40 Offset: 0x2ACC41 VA: 0x2ACB40
	// RVA: 0x1F81D30 Offset: 0x1F81E31 VA: 0x1F81D30
	protected void set_WorldHitTime(float value) { }

	// RVA: 0x1F81D40 Offset: 0x1F81E41 VA: 0x1F81D40
	public void Stop() { }

	// RVA: 0x1F81E30 Offset: 0x1F81F31 VA: 0x1F81E30
	private void OnDestroy() { }

	// RVA: 0x1F81E40 Offset: 0x1F81F41 VA: 0x1F81E40
	public void MakeAvoidObserver(Character chr, float timeToHit) { }

	// RVA: 0x1F82120 Offset: 0x1F82221 VA: 0x1F82120
	protected void .ctor() { }
}

