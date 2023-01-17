// Namespace: App
public class UnitFor // TypeDefIndex: 13532
{
	// Methods

	// RVA: 0x23E7650 Offset: 0x23E7751 VA: 0x23E7650
	public static void Each(Force.Type type, Action<Unit> func) { }

	// RVA: 0x23E76E0 Offset: 0x23E77E1 VA: 0x23E76E0
	public static void Reverse(Force.Type type, Action<Unit> func) { }

	// RVA: 0x23E7770 Offset: 0x23E7871 VA: 0x23E7770
	public static void Each(uint forceMask, Action<Unit> func) { }

	// RVA: 0x23E78D0 Offset: 0x23E79D1 VA: 0x23E78D0
	public static void Reverse(uint forceMask, Action<Unit> func) { }

	// RVA: 0x23E7A30 Offset: 0x23E7B31 VA: 0x23E7A30
	public static Unit Find(Force.Type type, Predicate<Unit> pred) { }

	// RVA: 0x23E7AC0 Offset: 0x23E7BC1 VA: 0x23E7AC0
	public static Unit FindLast(Force.Type type, Predicate<Unit> pred) { }

	// RVA: 0x23E7B50 Offset: 0x23E7C51 VA: 0x23E7B50
	public static Unit Find(uint forceMask, Predicate<Unit> pred) { }

	// RVA: 0x23E7C10 Offset: 0x23E7D11 VA: 0x23E7C10
	public static Unit FindLast(uint forceMask, Predicate<Unit> pred) { }

	// RVA: 0x23E7760 Offset: 0x23E7861 VA: 0x23E7760
	public static Unit GetPrev(Unit unit) { }

	// RVA: 0x23E76D0 Offset: 0x23E77D1 VA: 0x23E76D0
	public static Unit GetNext(Unit unit) { }

	// RVA: 0x23E79D0 Offset: 0x23E7AD1 VA: 0x23E79D0
	public static Unit GetPrev(Unit unit, uint forceMask) { }

	// RVA: 0x23E7870 Offset: 0x23E7971 VA: 0x23E7870
	public static Unit GetNext(Unit unit, uint forceMask) { }

	// RVA: 0x23E7CD0 Offset: 0x23E7DD1 VA: 0x23E7CD0
	public void .ctor() { }
}

