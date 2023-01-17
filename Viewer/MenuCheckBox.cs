// Namespace: Viewer
internal class MenuCheckBox : IMenuElement // TypeDefIndex: 8368
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FA00 Offset: 0x27FB01 VA: 0x27FA00
	private Action<int> <Callback>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x27FA10 Offset: 0x27FB11 VA: 0x27FA10
	private int <InnerValue>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x27FA20 Offset: 0x27FB21 VA: 0x27FA20
	private readonly string[] <DispValue>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x27FA30 Offset: 0x27FB31 VA: 0x27FA30
	private readonly bool <HasCallback>k__BackingField; // 0x80

	// Properties
	private Action<int> Callback { get; set; }
	private int InnerValue { get; set; }
	private string[] DispValue { get; }
	protected override bool HasCallback { get; }
	internal override string Value { get; set; }
	public override float Height { get; }
	protected override IMenuElement.DisplayType DispType { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7A10 Offset: 0x2A7B11 VA: 0x2A7A10
	// RVA: 0x2862860 Offset: 0x2862961 VA: 0x2862860
	private Action<int> get_Callback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A20 Offset: 0x2A7B21 VA: 0x2A7A20
	// RVA: 0x2862870 Offset: 0x2862971 VA: 0x2862870
	private void set_Callback(Action<int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A30 Offset: 0x2A7B31 VA: 0x2A7A30
	// RVA: 0x2862880 Offset: 0x2862981 VA: 0x2862880
	private int get_InnerValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A40 Offset: 0x2A7B41 VA: 0x2A7A40
	// RVA: 0x2862890 Offset: 0x2862991 VA: 0x2862890
	private void set_InnerValue(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A50 Offset: 0x2A7B51 VA: 0x2A7A50
	// RVA: 0x28628A0 Offset: 0x28629A1 VA: 0x28628A0
	private string[] get_DispValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7A60 Offset: 0x2A7B61 VA: 0x2A7A60
	// RVA: 0x28628B0 Offset: 0x28629B1 VA: 0x28628B0 Slot: 10
	protected override bool get_HasCallback() { }

	// RVA: 0x28628C0 Offset: 0x28629C1 VA: 0x28628C0 Slot: 11
	internal override string get_Value() { }

	// RVA: 0x2862900 Offset: 0x2862A01 VA: 0x2862900 Slot: 12
	internal override void set_Value(string value) { }

	// RVA: 0x28629A0 Offset: 0x2862AA1 VA: 0x28629A0
	public void .ctor(string name, int defaultValue = 0, Action<int> callback, string[] dispVal) { }

	// RVA: 0x2862B30 Offset: 0x2862C31 VA: 0x2862B30 Slot: 9
	public override float get_Height() { }

	// RVA: 0x2862B40 Offset: 0x2862C41 VA: 0x2862B40 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x2862B50 Offset: 0x2862C51 VA: 0x2862B50 Slot: 20
	protected override void Update() { }
}

