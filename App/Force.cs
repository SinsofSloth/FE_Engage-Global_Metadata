// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x278D40 Offset: 0x278E41 VA: 0x278D40
public class Force // TypeDefIndex: 13463
{
	// Fields
	private Unit m_Head; // 0x10
	private Unit m_Tail; // 0x18
	private Force.Type m_Type; // 0x20

	// Properties
	public Unit First { get; set; }
	public Unit Last { get; set; }
	public Force.Type ForceType { get; }
	public uint ForceMask { get; }

	// Methods

	// RVA: 0x2A01850 Offset: 0x2A01951 VA: 0x2A01850
	public static Force Get(Force.Type type) { }

	// RVA: 0x2A01860 Offset: 0x2A01961 VA: 0x2A01860
	public static Unit GetUnitFromEmpty() { }

	// RVA: 0x2A01880 Offset: 0x2A01981 VA: 0x2A01880
	public static Color GetColor(Force.Type type) { }

	// RVA: 0x2A01930 Offset: 0x2A01A31 VA: 0x2A01930
	public static string GetName(Force.Type type) { }

	// RVA: 0x2A019B0 Offset: 0x2A01AB1 VA: 0x2A019B0
	public void Initialize(Force.Type type) { }

	// RVA: 0x2A019F0 Offset: 0x2A01AF1 VA: 0x2A019F0
	public void JoinFirst(Unit unit) { }

	// RVA: 0x2A01A80 Offset: 0x2A01B81 VA: 0x2A01A80
	public void JoinLast(Unit unit) { }

	// RVA: 0x2A01B00 Offset: 0x2A01C01 VA: 0x2A01B00
	public void Insert(Unit insUnit, Unit prevUnit) { }

	// RVA: 0x2A01C30 Offset: 0x2A01D31 VA: 0x2A01C30
	public void Remove(Unit unit) { }

	// RVA: 0x2A01CF0 Offset: 0x2A01DF1 VA: 0x2A01CF0
	public void Transfer(Force.Type type, bool isLast = True) { }

	// RVA: 0x2A01D40 Offset: 0x2A01E41 VA: 0x2A01D40
	public void TransferForSortie(Force.Type type, bool isLast = True) { }

	// RVA: 0x2A01D90 Offset: 0x2A01E91 VA: 0x2A01D90
	public bool IsAllied(Force.Type type) { }

	// RVA: 0x2A01E40 Offset: 0x2A01F41 VA: 0x2A01E40
	public int GetCount() { }

	// RVA: 0x2A01E70 Offset: 0x2A01F71 VA: 0x2A01E70
	public int GetIndex(Unit target) { }

	// RVA: 0x2A01EB0 Offset: 0x2A01FB1 VA: 0x2A01EB0
	public Unit GetHeroUnit() { }

	// RVA: 0x2A01EF0 Offset: 0x2A01FF1 VA: 0x2A01EF0
	public Unit GetUnitFromPerson(PersonData person) { }

	// RVA: 0x2A01FA0 Offset: 0x2A020A1 VA: 0x2A01FA0
	public Unit GetUnitFromPerson(string pid) { }

	// RVA: 0x2A020D0 Offset: 0x2A021D1 VA: 0x2A020D0
	public Unit GetUnitFromFace(PersonData person, bool considerRelay = False) { }

	// RVA: 0x2A02220 Offset: 0x2A02321 VA: 0x2A02220
	public Unit get_First() { }

	// RVA: 0x2A02230 Offset: 0x2A02331 VA: 0x2A02230
	public void set_First(Unit value) { }

	// RVA: 0x2A02240 Offset: 0x2A02341 VA: 0x2A02240
	public Unit get_Last() { }

	// RVA: 0x2A02250 Offset: 0x2A02351 VA: 0x2A02250
	public void set_Last(Unit value) { }

	// RVA: 0x2A02260 Offset: 0x2A02361 VA: 0x2A02260
	public Force.Type get_ForceType() { }

	// RVA: 0x2A02270 Offset: 0x2A02371 VA: 0x2A02270
	public uint get_ForceMask() { }

	// RVA: 0x2A02280 Offset: 0x2A02381 VA: 0x2A02280
	public static uint GetMask(Force.Type type) { }

	// RVA: 0x2A02290 Offset: 0x2A02391 VA: 0x2A02290
	public static uint GetMask(Force.Type type1, Force.Type type2) { }

	// RVA: 0x2A022B0 Offset: 0x2A023B1 VA: 0x2A022B0
	public static uint GetMask(Force.Type type1, Force.Type type2, Force.Type type3) { }

	// RVA: 0x2A022D0 Offset: 0x2A023D1 VA: 0x2A022D0
	public static uint GetMask(Force.Type type1, Force.Type type2, Force.Type type3, Force.Type type4) { }

	// RVA: 0x2A02300 Offset: 0x2A02401 VA: 0x2A02300
	public static uint GetMaskOnUsed() { }

	// RVA: 0x2A02310 Offset: 0x2A02411 VA: 0x2A02310
	public static uint GetMaskOnMap() { }

	// RVA: 0x2A02320 Offset: 0x2A02421 VA: 0x2A02320
	public static uint GetMaskOnSortie() { }

	// RVA: 0x2A02330 Offset: 0x2A02431 VA: 0x2A02330
	public static uint GetMaskOnChapterSave() { }

	// RVA: 0x2A02340 Offset: 0x2A02441 VA: 0x2A02340
	public static uint GetMaskSameForce(Force.Type type) { }

	// RVA: 0x2A02360 Offset: 0x2A02461 VA: 0x2A02360
	public static bool IsPlayer(Force.Type type) { }

	// RVA: 0x2A02380 Offset: 0x2A02481 VA: 0x2A02380
	public static bool IsOnMap(Force.Type type) { }

	// RVA: 0x2A02390 Offset: 0x2A02491 VA: 0x2A02390
	public static bool IsOnMap(Unit unit) { }

	// RVA: 0x2A023C0 Offset: 0x2A024C1 VA: 0x2A023C0
	public void .ctor() { }
}

