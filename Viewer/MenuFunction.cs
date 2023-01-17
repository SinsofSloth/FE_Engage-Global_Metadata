// Namespace: Viewer
internal class MenuFunction : IMenuElement // TypeDefIndex: 8365
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27F990 Offset: 0x27FA91 VA: 0x27F990
	private readonly IMenuElement.DisplayType <DispType>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x27F9A0 Offset: 0x27FAA1 VA: 0x27F9A0
	private readonly bool <HasCallback>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x27F9B0 Offset: 0x27FAB1 VA: 0x27F9B0
	private readonly Action<string> <Callback>k__BackingField; // 0x70

	// Properties
	protected override IMenuElement.DisplayType DispType { get; }
	public override float Height { get; }
	protected override bool HasCallback { get; }
	private Action<string> Callback { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7990 Offset: 0x2A7A91 VA: 0x2A7990
	// RVA: 0x2863940 Offset: 0x2863A41 VA: 0x2863940 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x2863950 Offset: 0x2863A51 VA: 0x2863950 Slot: 9
	public override float get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A79A0 Offset: 0x2A7AA1 VA: 0x2A79A0
	// RVA: 0x2863960 Offset: 0x2863A61 VA: 0x2863960 Slot: 10
	protected override bool get_HasCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A79B0 Offset: 0x2A7AB1 VA: 0x2A79B0
	// RVA: 0x2863970 Offset: 0x2863A71 VA: 0x2863970
	private Action<string> get_Callback() { }

	// RVA: 0x2863980 Offset: 0x2863A81 VA: 0x2863980
	public void .ctor(string name, Action<string> callback, string value) { }

	// RVA: 0x2863A00 Offset: 0x2863B01 VA: 0x2863A00 Slot: 20
	protected override void Update() { }
}

