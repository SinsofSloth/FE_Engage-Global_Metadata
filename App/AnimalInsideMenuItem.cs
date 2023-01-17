// Namespace: App
internal class AnimalInsideMenuItem : BasicMenuItem // TypeDefIndex: 10437
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28E070 Offset: 0x28E171 VA: 0x28E070
	private readonly AnimalData <Animal>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28E080 Offset: 0x28E181 VA: 0x28E080
	private bool <IsActive>k__BackingField; // 0x70

	// Properties
	public AnimalData Animal { get; }
	public bool IsActive { get; set; }
	public bool IsActiveSelect { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BE170 Offset: 0x2BE271 VA: 0x2BE170
	// RVA: 0x20F8AB0 Offset: 0x20F8BB1 VA: 0x20F8AB0
	public AnimalData get_Animal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE180 Offset: 0x2BE281 VA: 0x2BE180
	// RVA: 0x20F8AC0 Offset: 0x20F8BC1 VA: 0x20F8AC0
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BE190 Offset: 0x2BE291 VA: 0x2BE190
	// RVA: 0x20F8AD0 Offset: 0x20F8BD1 VA: 0x20F8AD0
	public void set_IsActive(bool value) { }

	// RVA: 0x20F8AE0 Offset: 0x20F8BE1 VA: 0x20F8AE0
	public bool get_IsActiveSelect() { }

	// RVA: 0x20F8150 Offset: 0x20F8251 VA: 0x20F8150
	public void .ctor(AnimalData animal) { }

	// RVA: 0x20F8B30 Offset: 0x20F8C31 VA: 0x20F8B30 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x20F8CF0 Offset: 0x20F8DF1 VA: 0x20F8CF0 Slot: 4
	public override string GetName() { }

	// RVA: 0x20F8D70 Offset: 0x20F8E71 VA: 0x20F8D70
	public string GetCountText() { }

	// RVA: 0x20F9030 Offset: 0x20F9131 VA: 0x20F9030 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x20F9060 Offset: 0x20F9161 VA: 0x20F9060 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20F96E0 Offset: 0x20F97E1 VA: 0x20F96E0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

