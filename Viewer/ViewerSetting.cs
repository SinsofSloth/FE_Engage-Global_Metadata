// Namespace: Viewer
internal class ViewerSetting : IMenuElement // TypeDefIndex: 8359
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27F8F0 Offset: 0x27F9F1 VA: 0x27F8F0
	private readonly IMenuElement.DisplayType <DispType>k__BackingField; // 0x64

	// Properties
	protected override IMenuElement.DisplayType DispType { get; }
	public override float Height { get; }
	public int SelectId { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A78C0 Offset: 0x2A79C1 VA: 0x2A78C0
	// RVA: 0x26C5DE0 Offset: 0x26C5EE1 VA: 0x26C5DE0 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x26C5DF0 Offset: 0x26C5EF1 VA: 0x26C5DF0 Slot: 9
	public override float get_Height() { }

	// RVA: 0x26C5E30 Offset: 0x26C5F31 VA: 0x26C5E30
	public int get_SelectId() { }

	// RVA: 0x26C5E40 Offset: 0x26C5F41 VA: 0x26C5E40
	public void .ctor(IMenuElement.DisplayType type, string name, List<IMenuElement> menuItems) { }

	// RVA: 0x26C5EB0 Offset: 0x26C5FB1 VA: 0x26C5EB0 Slot: 20
	protected override void Update() { }

	// RVA: 0x26C5EC0 Offset: 0x26C5FC1 VA: 0x26C5EC0
	public void Apply(string name, string value) { }

	// RVA: 0x26C6020 Offset: 0x26C6121 VA: 0x26C6020
	public string GetValue(string name) { }

	// RVA: 0x26C6180 Offset: 0x26C6281 VA: 0x26C6180
	public string GetSelecting() { }
}

