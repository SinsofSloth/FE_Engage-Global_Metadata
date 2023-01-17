// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278AD0 Offset: 0x278BD1 VA: 0x278AD0
private sealed class RingSelectMenu.RingMenuItem.<>c__DisplayClass14_0 // TypeDefIndex: 13231
{
	// Fields
	public Unit unit; // 0x10
	public RingSelectMenu.RingMenuItem <>4__this; // 0x18

	// Methods

	// RVA: 0x21F7DB0 Offset: 0x21F7EB1 VA: 0x21F7DB0
	public void .ctor() { }

	// RVA: 0x21F7DC0 Offset: 0x21F7EC1 VA: 0x21F7DC0
	internal void <OnSelect>b__0() { }
}

// Namespace: 
public class RingSelectMenu.RingMenuItem : BasicMenuItem // TypeDefIndex: 13232
{
	// Fields
	private bool m_isGod; // 0x64
	private GodUnit m_god; // 0x68
	private UnitRing m_ring; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29BCD0 Offset: 0x29BDD1 VA: 0x29BCD0
	private int <RingSortId>k__BackingField; // 0x78

	// Properties
	public int RingSortId { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB670 Offset: 0x2CB771 VA: 0x2CB670
	// RVA: 0x1F57010 Offset: 0x1F57111 VA: 0x1F57010
	public int get_RingSortId() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB680 Offset: 0x2CB781 VA: 0x2CB680
	// RVA: 0x1F57020 Offset: 0x1F57121 VA: 0x1F57020
	private void set_RingSortId(int value) { }

	// RVA: 0x1F57030 Offset: 0x1F57131 VA: 0x1F57030
	public void .ctor(bool isGod, GodUnit god, UnitRing ring, int ringSortId = 0) { }

	// RVA: 0x1F570A0 Offset: 0x1F571A1 VA: 0x1F570A0
	public bool IsGod() { }

	// RVA: 0x1F570B0 Offset: 0x1F571B1 VA: 0x1F570B0
	public GodUnit GetGod() { }

	// RVA: 0x1F570C0 Offset: 0x1F571C1 VA: 0x1F570C0
	public UnitRing GetCommon() { }

	// RVA: 0x1F570D0 Offset: 0x1F571D1 VA: 0x1F570D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F57170 Offset: 0x1F57271 VA: 0x1F57170
	public static BasicMenuItem.Attribute CalcAttribute(Unit unit, GodUnit god, UnitRing ring) { }

	// RVA: 0x1F57650 Offset: 0x1F57751 VA: 0x1F57650 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F579B0 Offset: 0x1F57AB1 VA: 0x1F579B0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278AE0 Offset: 0x278BE1 VA: 0x278AE0
[Serializable]
private sealed class RingSelectMenu.<>c // TypeDefIndex: 13233
{
	// Fields
	public static readonly RingSelectMenu.<>c <>9; // 0x0
	public static Comparison<BasicMenuItem> <>9__16_0; // 0x8
	public static RingListSkillMenu.CancelEventHandler <>9__26_1; // 0x10

	// Methods

	// RVA: 0x1F56E20 Offset: 0x1F56F21 VA: 0x1F56E20
	private static void .cctor() { }

	// RVA: 0x1F56E90 Offset: 0x1F56F91 VA: 0x1F56E90
	public void .ctor() { }

	// RVA: 0x1F56EA0 Offset: 0x1F56FA1 VA: 0x1F56EA0
	internal int <CreateMenuItemList>b__16_0(BasicMenuItem a, BasicMenuItem b) { }

	// RVA: 0x1F56F40 Offset: 0x1F57041 VA: 0x1F56F40
	internal BasicMenu.Result <CustomCall>b__26_1() { }
}

