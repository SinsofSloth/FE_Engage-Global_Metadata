// Namespace: Combat
public abstract class Decorator // TypeDefIndex: 8448
{
	// Fields
	protected int m_Side; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x27FE50 Offset: 0x27FF51 VA: 0x27FE50
	private Phase <m_Phase>k__BackingField; // 0x18
	protected CompositeDisposable m_ActionDisposer; // 0x20

	// Properties
	public abstract string Name { get; }
	public Phase m_Phase { get; set; }
	public Character[] m_Chrs { get; }
	public Character m_Master { get; }
	public Character m_Enemy { get; }
	public Character m_Grandew { get; }
	public Character m_EnemyGrandew { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_Name();

	[CompilerGeneratedAttribute] // RVA: 0x2A8840 Offset: 0x2A8941 VA: 0x2A8840
	// RVA: 0x236F510 Offset: 0x236F611 VA: 0x236F510
	public Phase get_m_Phase() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8850 Offset: 0x2A8951 VA: 0x2A8850
	// RVA: 0x236F520 Offset: 0x236F621 VA: 0x236F520
	protected void set_m_Phase(Phase value) { }

	// RVA: 0x236F530 Offset: 0x236F631 VA: 0x236F530
	public Character[] get_m_Chrs() { }

	// RVA: 0x236F550 Offset: 0x236F651 VA: 0x236F550
	public Character get_m_Master() { }

	// RVA: 0x236F5A0 Offset: 0x236F6A1 VA: 0x236F5A0
	public Character get_m_Enemy() { }

	// RVA: 0x236F5B0 Offset: 0x236F6B1 VA: 0x236F5B0
	public Character get_m_Grandew() { }

	// RVA: 0x236F5C0 Offset: 0x236F6C1 VA: 0x236F5C0
	public Character get_m_EnemyGrandew() { }

	// RVA: 0x236F5D0 Offset: 0x236F6D1 VA: 0x236F5D0
	public void Activate(int side, Phase phase, CompositeDisposable cd) { }

	// RVA: 0x236F610 Offset: 0x236F711 VA: 0x236F610
	public void UseOnArrivalTimePredicted() { }

	// RVA: 0x236F790 Offset: 0x236F891 VA: 0x236F790
	public void UseOnHitTimePredicted() { }

	// RVA: 0x236F910 Offset: 0x236FA11 VA: 0x236F910
	public void UseOnEnemyDamage() { }

	// RVA: 0x236FA80 Offset: 0x236FB81 VA: 0x236FA80
	public void UseOnBackwardCancel(Character chr) { }

	// RVA: 0x236FBD0 Offset: 0x236FCD1 VA: 0x236FBD0 Slot: 5
	public virtual void OnEnter() { }

	// RVA: 0x236FBE0 Offset: 0x236FCE1 VA: 0x236FBE0 Slot: 6
	public virtual void OnEnterAttack() { }

	// RVA: 0x236FBF0 Offset: 0x236FCF1 VA: 0x236FBF0 Slot: 7
	public virtual void OnUpdate() { }

	// RVA: 0x236FC00 Offset: 0x236FD01 VA: 0x236FC00 Slot: 8
	public virtual void OnExit() { }

	// RVA: 0x236FC10 Offset: 0x236FD11 VA: 0x236FC10 Slot: 9
	public virtual void OnArrivalTimePredicted_(float worldArrivalTime) { }

	// RVA: 0x236FC20 Offset: 0x236FD21 VA: 0x236FC20 Slot: 10
	public virtual void OnHitTimePredicted_(float worldHitTime, WeaponStyle weaponStyle) { }

	// RVA: 0x236FC30 Offset: 0x236FD31 VA: 0x236FC30 Slot: 11
	public virtual void OnShoot(AnimationEvent ev) { }

	// RVA: 0x236FC40 Offset: 0x236FD41 VA: 0x236FC40 Slot: 12
	public virtual void OnMissPassed(AnimationEvent ev) { }

	// RVA: 0x236FC50 Offset: 0x236FD51 VA: 0x236FC50 Slot: 13
	public virtual void OnHitPassed(AnimationEvent ev) { }

	// RVA: 0x236FC60 Offset: 0x236FD61 VA: 0x236FC60 Slot: 14
	public virtual void OnEnemyDamage_(AnimationEvent ev) { }

	// RVA: 0x236FC70 Offset: 0x236FD71 VA: 0x236FC70 Slot: 15
	public virtual void OnBackwardCancel_() { }

	// RVA: 0x236F500 Offset: 0x236F601 VA: 0x236F500
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8860 Offset: 0x2A8961 VA: 0x2A8860
	// RVA: 0x236FC80 Offset: 0x236FD81 VA: 0x236FC80
	private void <UseOnArrivalTimePredicted>b__19_0(ValueTuple<float, int> pair) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8870 Offset: 0x2A8971 VA: 0x2A8870
	// RVA: 0x236FC90 Offset: 0x236FD91 VA: 0x236FC90
	private void <UseOnHitTimePredicted>b__20_0(ValueTuple<float, WeaponStyle> pair) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8880 Offset: 0x2A8981 VA: 0x2A8880
	// RVA: 0x236FCB0 Offset: 0x236FDB1 VA: 0x236FCB0
	private void <UseOnEnemyDamage>b__21_0(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8890 Offset: 0x2A8991 VA: 0x2A8890
	// RVA: 0x236FCC0 Offset: 0x236FDC1 VA: 0x236FCC0
	private void <UseOnBackwardCancel>b__22_0(Character _) { }
}

