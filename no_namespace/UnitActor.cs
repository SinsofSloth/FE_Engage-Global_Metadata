// Namespace: 
private enum UnitActor.ViewMode // TypeDefIndex: 8972
{
	// Fields
	public int value__; // 0x0
	public const UnitActor.ViewMode None = 0;
	public const UnitActor.ViewMode Hide = 1;
	public const UnitActor.ViewMode Show = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x274D90 Offset: 0x274E91 VA: 0x274D90
public enum UnitActor.Status // TypeDefIndex: 8973
{
	// Fields
	public int value__; // 0x0
	public const UnitActor.Status Stasis = 1;
	public const UnitActor.Status Active = 2;
	public const UnitActor.Status Moved = 4;
	public const UnitActor.Status Reload = 8;
	public const UnitActor.Status GodIn = 16;
	public const UnitActor.Status GodOut = 32;
	public const UnitActor.Status PassHeight = 64;
	public const UnitActor.Status HasEffect = 128;
}

// Namespace: 
public class UnitActor.StatusField : BitFieldTemplate32<UnitActor.Status> // TypeDefIndex: 8974
{
	// Methods

	// RVA: 0x23ABF50 Offset: 0x23AC051 VA: 0x23ABF50 Slot: 5
	protected override int ToInt(UnitActor.Status value) { }

	// RVA: 0x23ABF60 Offset: 0x23AC061 VA: 0x23ABF60
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x274DA0 Offset: 0x274EA1 VA: 0x274DA0
private sealed class UnitActor.<>c__DisplayClass81_0 // TypeDefIndex: 8975
{
	// Fields
	public UnitActor <>4__this; // 0x10
	public int count; // 0x18

	// Methods

	// RVA: 0x23ABE10 Offset: 0x23ABF11 VA: 0x23ABE10
	public void .ctor() { }

	// RVA: 0x23ABE20 Offset: 0x23ABF21 VA: 0x23ABE20
	internal void <PlayEngageCount>b__0(EffectShoot effect) { }
}

