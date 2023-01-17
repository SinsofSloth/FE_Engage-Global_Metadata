// Namespace: Viewer
internal class MenuButton : IMenuElement // TypeDefIndex: 8367
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27F9C0 Offset: 0x27FAC1 VA: 0x27F9C0
	private readonly bool <HasCallback>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x27F9D0 Offset: 0x27FAD1 VA: 0x27F9D0
	private bool <IsDoing>k__BackingField; // 0x65
	[CompilerGeneratedAttribute] // RVA: 0x27F9E0 Offset: 0x27FAE1 VA: 0x27F9E0
	private readonly string <IdelName>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x27F9F0 Offset: 0x27FAF1 VA: 0x27F9F0
	private readonly string <ProcessName>k__BackingField; // 0x70
	private readonly Func<IEnumerator> CallBack; // 0x78

	// Properties
	public override float Height { get; }
	protected override bool HasCallback { get; }
	protected override IMenuElement.DisplayType DispType { get; }
	public bool IsDoing { get; set; }
	public override string Name { get; }
	public string IdelName { get; }
	public string ProcessName { get; }

	// Methods

	// RVA: 0x28625E0 Offset: 0x28626E1 VA: 0x28625E0 Slot: 9
	public override float get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A79C0 Offset: 0x2A7AC1 VA: 0x2A79C0
	// RVA: 0x28625F0 Offset: 0x28626F1 VA: 0x28625F0 Slot: 10
	protected override bool get_HasCallback() { }

	// RVA: 0x2862600 Offset: 0x2862701 VA: 0x2862600 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A79D0 Offset: 0x2A7AD1 VA: 0x2A79D0
	// RVA: 0x2862610 Offset: 0x2862711 VA: 0x2862610
	public bool get_IsDoing() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A79E0 Offset: 0x2A7AE1 VA: 0x2A79E0
	// RVA: 0x2862620 Offset: 0x2862721 VA: 0x2862620
	public void set_IsDoing(bool value) { }

	// RVA: 0x2862630 Offset: 0x2862731 VA: 0x2862630 Slot: 4
	public override string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A79F0 Offset: 0x2A7AF1 VA: 0x2A79F0
	// RVA: 0x2862650 Offset: 0x2862751 VA: 0x2862650
	public string get_IdelName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A00 Offset: 0x2A7B01 VA: 0x2A7A00
	// RVA: 0x2862660 Offset: 0x2862761 VA: 0x2862660
	public string get_ProcessName() { }

	// RVA: 0x2862670 Offset: 0x2862771 VA: 0x2862670
	public void .ctor(string idelName, string processName, Func<IEnumerator> buttonAction) { }

	// RVA: 0x28626E0 Offset: 0x28627E1 VA: 0x28626E0 Slot: 20
	protected override void Update() { }
}

