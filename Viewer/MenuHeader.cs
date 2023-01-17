// Namespace: Viewer
internal class MenuHeader : IMenuElement // TypeDefIndex: 8360
{
	// Fields
	private readonly bool m_Selectable; // 0x64
	private readonly string m_Name; // 0x68

	// Properties
	public override float Height { get; }
	protected override IMenuElement.DisplayType DispType { get; }
	protected override bool HasCallback { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x2863AA0 Offset: 0x2863BA1 VA: 0x2863AA0 Slot: 9
	public override float get_Height() { }

	// RVA: 0x2863AB0 Offset: 0x2863BB1 VA: 0x2863AB0 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x2863AD0 Offset: 0x2863BD1 VA: 0x2863AD0 Slot: 20
	protected override void Update() { }

	// RVA: 0x2863AE0 Offset: 0x2863BE1 VA: 0x2863AE0 Slot: 10
	protected override bool get_HasCallback() { }

	// RVA: 0x2863AF0 Offset: 0x2863BF1 VA: 0x2863AF0 Slot: 4
	public override string get_Name() { }

	// RVA: 0x2861150 Offset: 0x2861251 VA: 0x2861150
	public void .ctor(string name, bool selectable = False) { }
}

