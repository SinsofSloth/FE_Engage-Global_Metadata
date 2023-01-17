// Namespace: App
public class RefineGodWeaponParamMenuItem : BasicMenuItem // TypeDefIndex: 11057
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x296340 Offset: 0x296441 VA: 0x296340
	private GodUnit <m_GodUnit>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x296350 Offset: 0x296451 VA: 0x296350
	private GodWeaponRefineData <m_GodWeaponRefineData>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x296360 Offset: 0x296461 VA: 0x296360
	private GodWeaponRefineData.Kind <m_RefineKind>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x296370 Offset: 0x296471 VA: 0x296370
	private int <m_RefineLevel>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x296380 Offset: 0x296481 VA: 0x296380
	private int <m_RefineLevelNext>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x296390 Offset: 0x296491 VA: 0x296390
	private bool <m_HasNextLevel>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x2963A0 Offset: 0x2964A1 VA: 0x2963A0
	private int <m_Capacity>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x2963B0 Offset: 0x2964B1 VA: 0x2963B0
	private int <m_Material>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x2963C0 Offset: 0x2964C1 VA: 0x2963C0
	private bool <m_IsSkill>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x2963D0 Offset: 0x2964D1 VA: 0x2963D0
	private bool <m_EnoughCapacity>k__BackingField; // 0x91
	[CompilerGeneratedAttribute] // RVA: 0x2963E0 Offset: 0x2964E1 VA: 0x2963E0
	private bool <m_EnoughMaterial>k__BackingField; // 0x92
	[CompilerGeneratedAttribute] // RVA: 0x2963F0 Offset: 0x2964F1 VA: 0x2963F0
	private bool <m_Empty>k__BackingField; // 0x93
	private bool m_RefineOrReset; // 0x94
	protected RefineGodWeaponParamMenu.SelectEventHandler m_SelectEventHandler; // 0x98
	protected RefineGodWeaponParamMenu.DecideEventHandler m_DecideEventHandler; // 0xA0
	protected RefineGodWeaponParamMenu.RequestCloseEventHandler m_RequestCloseEventHandler; // 0xA8

	// Properties
	public GodUnit m_GodUnit { get; set; }
	public GodWeaponRefineData m_GodWeaponRefineData { get; set; }
	public GodWeaponRefineData.Kind m_RefineKind { get; set; }
	public int m_RefineLevel { get; set; }
	public int m_RefineLevelNext { get; set; }
	public bool m_HasNextLevel { get; set; }
	public int m_Capacity { get; set; }
	public int m_Material { get; set; }
	public bool m_IsSkill { get; set; }
	public bool m_EnoughCapacity { get; set; }
	public bool m_EnoughMaterial { get; set; }
	public bool m_Empty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3190 Offset: 0x2C3291 VA: 0x2C3190
	// RVA: 0x2777400 Offset: 0x2777501 VA: 0x2777400
	public GodUnit get_m_GodUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C31A0 Offset: 0x2C32A1 VA: 0x2C31A0
	// RVA: 0x2777410 Offset: 0x2777511 VA: 0x2777410
	private void set_m_GodUnit(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C31B0 Offset: 0x2C32B1 VA: 0x2C31B0
	// RVA: 0x2777420 Offset: 0x2777521 VA: 0x2777420
	public GodWeaponRefineData get_m_GodWeaponRefineData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C31C0 Offset: 0x2C32C1 VA: 0x2C31C0
	// RVA: 0x2777430 Offset: 0x2777531 VA: 0x2777430
	private void set_m_GodWeaponRefineData(GodWeaponRefineData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C31D0 Offset: 0x2C32D1 VA: 0x2C31D0
	// RVA: 0x2777440 Offset: 0x2777541 VA: 0x2777440
	public GodWeaponRefineData.Kind get_m_RefineKind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C31E0 Offset: 0x2C32E1 VA: 0x2C31E0
	// RVA: 0x2777450 Offset: 0x2777551 VA: 0x2777450
	private void set_m_RefineKind(GodWeaponRefineData.Kind value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C31F0 Offset: 0x2C32F1 VA: 0x2C31F0
	// RVA: 0x2777460 Offset: 0x2777561 VA: 0x2777460
	public int get_m_RefineLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3200 Offset: 0x2C3301 VA: 0x2C3200
	// RVA: 0x2777470 Offset: 0x2777571 VA: 0x2777470
	private void set_m_RefineLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3210 Offset: 0x2C3311 VA: 0x2C3210
	// RVA: 0x2777480 Offset: 0x2777581 VA: 0x2777480
	public int get_m_RefineLevelNext() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3220 Offset: 0x2C3321 VA: 0x2C3220
	// RVA: 0x2777490 Offset: 0x2777591 VA: 0x2777490
	private void set_m_RefineLevelNext(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3230 Offset: 0x2C3331 VA: 0x2C3230
	// RVA: 0x27774A0 Offset: 0x27775A1 VA: 0x27774A0
	public bool get_m_HasNextLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3240 Offset: 0x2C3341 VA: 0x2C3240
	// RVA: 0x27774B0 Offset: 0x27775B1 VA: 0x27774B0
	private void set_m_HasNextLevel(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3250 Offset: 0x2C3351 VA: 0x2C3250
	// RVA: 0x27774C0 Offset: 0x27775C1 VA: 0x27774C0
	public int get_m_Capacity() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3260 Offset: 0x2C3361 VA: 0x2C3260
	// RVA: 0x27774D0 Offset: 0x27775D1 VA: 0x27774D0
	private void set_m_Capacity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3270 Offset: 0x2C3371 VA: 0x2C3270
	// RVA: 0x27774E0 Offset: 0x27775E1 VA: 0x27774E0
	public int get_m_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3280 Offset: 0x2C3381 VA: 0x2C3280
	// RVA: 0x27774F0 Offset: 0x27775F1 VA: 0x27774F0
	private void set_m_Material(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3290 Offset: 0x2C3391 VA: 0x2C3290
	// RVA: 0x2777500 Offset: 0x2777601 VA: 0x2777500
	public bool get_m_IsSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C32A0 Offset: 0x2C33A1 VA: 0x2C32A0
	// RVA: 0x2777510 Offset: 0x2777611 VA: 0x2777510
	private void set_m_IsSkill(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C32B0 Offset: 0x2C33B1 VA: 0x2C32B0
	// RVA: 0x2777520 Offset: 0x2777621 VA: 0x2777520
	public bool get_m_EnoughCapacity() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C32C0 Offset: 0x2C33C1 VA: 0x2C32C0
	// RVA: 0x2777530 Offset: 0x2777631 VA: 0x2777530
	private void set_m_EnoughCapacity(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C32D0 Offset: 0x2C33D1 VA: 0x2C32D0
	// RVA: 0x2777540 Offset: 0x2777641 VA: 0x2777540
	public bool get_m_EnoughMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C32E0 Offset: 0x2C33E1 VA: 0x2C32E0
	// RVA: 0x2777550 Offset: 0x2777651 VA: 0x2777550
	private void set_m_EnoughMaterial(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C32F0 Offset: 0x2C33F1 VA: 0x2C32F0
	// RVA: 0x2777560 Offset: 0x2777661 VA: 0x2777560
	public bool get_m_Empty() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3300 Offset: 0x2C3401 VA: 0x2C3300
	// RVA: 0x2777570 Offset: 0x2777671 VA: 0x2777570
	protected void set_m_Empty(bool value) { }

	// RVA: 0x2773F20 Offset: 0x2774021 VA: 0x2773F20
	public void .ctor(GodUnit godUnit, ItemData godWeapon, GodWeaponRefineData godWeaponRefineData, GodWeaponRefineData.Kind refineKind, int refineLevel, bool refineOrReset, RefineGodWeaponParamMenu.SelectEventHandler selectEventHandler, RefineGodWeaponParamMenu.DecideEventHandler decideEventHandler, RefineGodWeaponParamMenu.RequestCloseEventHandler requestCloseEventHandler) { }

	// RVA: 0x2777580 Offset: 0x2777681 VA: 0x2777580 Slot: 4
	public override string GetName() { }

	// RVA: 0x2777590 Offset: 0x2777691 VA: 0x2777590 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x27775D0 Offset: 0x27776D1 VA: 0x27775D0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x27776E0 Offset: 0x27777E1 VA: 0x27776E0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x27775E0 Offset: 0x27776E1 VA: 0x27775E0
	public void SetInitialColor() { }

	// RVA: 0x27743E0 Offset: 0x27744E1 VA: 0x27743E0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x27776F0 Offset: 0x27777F1 VA: 0x27776F0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2777750 Offset: 0x2777851 VA: 0x2777750 Slot: 19
	public override BasicMenu.Result BCall() { }
}

