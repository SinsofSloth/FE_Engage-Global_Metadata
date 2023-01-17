// Namespace: 
private sealed class AIOrder.Func : MulticastDelegate // TypeDefIndex: 9264
{
	// Methods

	// RVA: 0x2F31F00 Offset: 0x2F32001 VA: 0x2F31F00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2F31F20 Offset: 0x2F32021 VA: 0x2F31F20 Slot: 13
	public virtual void Invoke(AIOrder order) { }

	// RVA: 0x2F32280 Offset: 0x2F32381 VA: 0x2F32280 Slot: 14
	public virtual IAsyncResult BeginInvoke(AIOrder order, AsyncCallback callback, object object) { }

	// RVA: 0x2F322B0 Offset: 0x2F323B1 VA: 0x2F322B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2753A0 Offset: 0x2754A1 VA: 0x2753A0
private sealed class AIOrder.<>c__DisplayClass55_0 // TypeDefIndex: 9266
{
	// Fields
	public int score; // 0x10

	// Methods

	// RVA: 0x2F31C40 Offset: 0x2F31D41 VA: 0x2F31C40
	public void .ctor() { }

	// RVA: 0x2F31C50 Offset: 0x2F31D51 VA: 0x2F31C50
	internal void <GetDistanceFromEnemy>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2753C0 Offset: 0x2754C1 VA: 0x2753C0
[Serializable]
private sealed class AIOrder.<>c // TypeDefIndex: 9268
{
	// Fields
	public static readonly AIOrder.<>c <>9; // 0x0
	public static MapFor.UnitFunction <>9__68_0; // 0x8
	public static MapFor.UnitFunction <>9__68_1; // 0x10
	public static MapFor.UnitFunction <>9__80_0; // 0x18
	public static MapFor.UnitFunction <>9__87_0; // 0x20

	// Methods

	// RVA: 0x2F31A10 Offset: 0x2F31B11 VA: 0x2F31A10
	private static void .cctor() { }

	// RVA: 0x2F31A80 Offset: 0x2F31B81 VA: 0x2F31A80
	public void .ctor() { }

	// RVA: 0x2F31A90 Offset: 0x2F31B91 VA: 0x2F31A90
	internal void <UpdateAskHeal>b__68_0(Unit unit) { }

	// RVA: 0x2F31B00 Offset: 0x2F31C01 VA: 0x2F31B00
	internal void <UpdateAskHeal>b__68_1(Unit unit) { }

	// RVA: 0x2F31B70 Offset: 0x2F31C71 VA: 0x2F31B70
	internal void <EntrustUpdateIdle>b__80_0(Unit unit) { }

	// RVA: 0x2F31BE0 Offset: 0x2F31CE1 VA: 0x2F31BE0
	internal void <UncontrollUpdateIdle>b__87_0(Unit unit) { }
}

