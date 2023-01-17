// Namespace: App
internal class AnimalOutsideMenuItem : BasicMenuItem // TypeDefIndex: 10447
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E1C0 Offset: 0x28E2C1 VA: 0x28E1C0
	private AnimalData <Animal>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28E1D0 Offset: 0x28E2D1 VA: 0x28E1D0
	private bool <IsLastMenu>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28E1E0 Offset: 0x28E2E1 VA: 0x28E1E0
	private bool <IsActive>k__BackingField; // 0x71
	private readonly string m_pid; // 0x78

	// Properties
	public AnimalData Animal { get; set; }
	public bool IsLastMenu { get; set; }
	public bool IsActive { get; set; }
	public bool IsActiveSelect { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BE3A0 Offset: 0x2BE4A1 VA: 0x2BE3A0
	// RVA: 0x20FE340 Offset: 0x20FE441 VA: 0x20FE340
	public AnimalData get_Animal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE3B0 Offset: 0x2BE4B1 VA: 0x2BE3B0
	// RVA: 0x20FE350 Offset: 0x20FE451 VA: 0x20FE350
	public void set_Animal(AnimalData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE3C0 Offset: 0x2BE4C1 VA: 0x2BE3C0
	// RVA: 0x20FE360 Offset: 0x20FE461 VA: 0x20FE360
	public bool get_IsLastMenu() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE3D0 Offset: 0x2BE4D1 VA: 0x2BE3D0
	// RVA: 0x20FE370 Offset: 0x20FE471 VA: 0x20FE370
	public void set_IsLastMenu(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE3E0 Offset: 0x2BE4E1 VA: 0x2BE3E0
	// RVA: 0x20FE380 Offset: 0x20FE481 VA: 0x20FE380
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE3F0 Offset: 0x2BE4F1 VA: 0x2BE3F0
	// RVA: 0x20FE390 Offset: 0x20FE491 VA: 0x20FE390
	public void set_IsActive(bool value) { }

	// RVA: 0x20FE3A0 Offset: 0x20FE4A1 VA: 0x20FE3A0
	public bool get_IsActiveSelect() { }

	// RVA: 0x20FDC20 Offset: 0x20FDD21 VA: 0x20FDC20
	public void .ctor(string pid, bool lastMenu) { }

	// RVA: 0x20FE470 Offset: 0x20FE571 VA: 0x20FE470 Slot: 4
	public override string GetName() { }

	// RVA: 0x20FE510 Offset: 0x20FE611 VA: 0x20FE510 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x20FE540 Offset: 0x20FE641 VA: 0x20FE540 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x20FE610 Offset: 0x20FE711 VA: 0x20FE610 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20FEA00 Offset: 0x20FEB01 VA: 0x20FEA00 Slot: 19
	public override BasicMenu.Result BCall() { }
}

