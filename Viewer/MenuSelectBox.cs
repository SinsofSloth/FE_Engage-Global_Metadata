// Namespace: Viewer
internal class MenuSelectBox : IMenuElement // TypeDefIndex: 8362
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27F910 Offset: 0x27FA11 VA: 0x27F910
	private readonly IMenuElement.DisplayType <DispType>k__BackingField; // 0x64

	// Properties
	protected override IMenuElement.DisplayType DispType { get; }
	public override float Height { get; }
	internal override string Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A78E0 Offset: 0x2A79E1 VA: 0x2A78E0
	// RVA: 0x28653D0 Offset: 0x28654D1 VA: 0x28653D0 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x28653E0 Offset: 0x28654E1 VA: 0x28653E0 Slot: 9
	public override float get_Height() { }

	// RVA: 0x2865430 Offset: 0x2865531 VA: 0x2865430 Slot: 11
	internal override string get_Value() { }

	// RVA: 0x2865510 Offset: 0x2865611 VA: 0x2865510 Slot: 12
	internal override void set_Value(string value) { }

	// RVA: 0x2865720 Offset: 0x2865821 VA: 0x2865720
	public void .ctor(string name, string[] choice, Action<string> callback) { }

	// RVA: 0x2865CF0 Offset: 0x2865DF1 VA: 0x2865CF0 Slot: 18
	public override bool Left() { }

	// RVA: 0x2865D00 Offset: 0x2865E01 VA: 0x2865D00 Slot: 17
	public override bool Right() { }

	// RVA: 0x2865D10 Offset: 0x2865E11 VA: 0x2865D10 Slot: 20
	protected override void Update() { }
}

