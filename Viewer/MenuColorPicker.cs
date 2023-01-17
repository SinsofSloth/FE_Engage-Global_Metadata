// Namespace: Viewer
internal class MenuColorPicker : IMenuElement // TypeDefIndex: 8369
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FA40 Offset: 0x27FB41 VA: 0x27FA40
	private readonly Action<string, Color> <Callback>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x27FA50 Offset: 0x27FB51 VA: 0x27FA50
	private Color <FontColor>k__BackingField; // 0x70

	// Properties
	protected override IMenuElement.DisplayType DispType { get; }
	public override float Height { get; }
	private Action<string, Color> Callback { get; }
	protected override Color FontColor { get; set; }
	internal override string Value { get; set; }

	// Methods

	// RVA: 0x2862BD0 Offset: 0x2862CD1 VA: 0x2862BD0 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x2862BE0 Offset: 0x2862CE1 VA: 0x2862BE0 Slot: 9
	public override float get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A70 Offset: 0x2A7B71 VA: 0x2A7A70
	// RVA: 0x2862BF0 Offset: 0x2862CF1 VA: 0x2862BF0
	private Action<string, Color> get_Callback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A80 Offset: 0x2A7B81 VA: 0x2A7A80
	// RVA: 0x2862C00 Offset: 0x2862D01 VA: 0x2862C00 Slot: 6
	protected override Color get_FontColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A90 Offset: 0x2A7B91 VA: 0x2A7A90
	// RVA: 0x2862C10 Offset: 0x2862D11 VA: 0x2862C10 Slot: 7
	protected override void set_FontColor(Color value) { }

	// RVA: 0x2862C30 Offset: 0x2862D31 VA: 0x2862C30 Slot: 11
	internal override string get_Value() { }

	// RVA: 0x2862D80 Offset: 0x2862E81 VA: 0x2862D80 Slot: 12
	internal override void set_Value(string value) { }

	// RVA: 0x28631B0 Offset: 0x28632B1 VA: 0x28631B0
	public void .ctor(string name, Action<string, Color> callback) { }

	// RVA: 0x2863530 Offset: 0x2863631 VA: 0x2863530 Slot: 19
	public override void Tick() { }

	// RVA: 0x2863820 Offset: 0x2863921 VA: 0x2863820 Slot: 17
	public override bool Right() { }

	// RVA: 0x28638B0 Offset: 0x28639B1 VA: 0x28638B0 Slot: 18
	public override bool Left() { }
}

