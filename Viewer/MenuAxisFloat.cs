// Namespace: Viewer
internal class MenuAxisFloat : IMenuElement // TypeDefIndex: 8364
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27F950 Offset: 0x27FA51 VA: 0x27F950
	private readonly IMenuElement.DisplayType <DispType>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x27F960 Offset: 0x27FA61 VA: 0x27F960
	private readonly Func<string, float[], float[]> <Callback>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x27F970 Offset: 0x27FA71 VA: 0x27F970
	private float[] <Axis>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x27F980 Offset: 0x27FA81 VA: 0x27F980
	private float <IncrementValue>k__BackingField; // 0x78
	private int m_LastChangeFrame; // 0x7C
	private int m_ChangeFrame; // 0x80
	private int m_Diff; // 0x84

	// Properties
	protected override IMenuElement.DisplayType DispType { get; }
	public override float Height { get; }
	private Func<string, float[], float[]> Callback { get; }
	private float[] Axis { get; set; }
	private float IncrementValue { get; set; }
	internal override string Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7930 Offset: 0x2A7A31 VA: 0x2A7930
	// RVA: 0x2860D20 Offset: 0x2860E21 VA: 0x2860D20 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x2860D30 Offset: 0x2860E31 VA: 0x2860D30 Slot: 9
	public override float get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7940 Offset: 0x2A7A41 VA: 0x2A7940
	// RVA: 0x2860D40 Offset: 0x2860E41 VA: 0x2860D40
	private Func<string, float[], float[]> get_Callback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7950 Offset: 0x2A7A51 VA: 0x2A7950
	// RVA: 0x2860D50 Offset: 0x2860E51 VA: 0x2860D50
	private float[] get_Axis() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7960 Offset: 0x2A7A61 VA: 0x2A7960
	// RVA: 0x2860D60 Offset: 0x2860E61 VA: 0x2860D60
	private void set_Axis(float[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7970 Offset: 0x2A7A71 VA: 0x2A7970
	// RVA: 0x2860D70 Offset: 0x2860E71 VA: 0x2860D70
	private float get_IncrementValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7980 Offset: 0x2A7A81 VA: 0x2A7980
	// RVA: 0x2860D80 Offset: 0x2860E81 VA: 0x2860D80
	private void set_IncrementValue(float value) { }

	// RVA: 0x2860D90 Offset: 0x2860E91 VA: 0x2860D90 Slot: 11
	internal override string get_Value() { }

	// RVA: 0x2860E70 Offset: 0x2860F71 VA: 0x2860E70 Slot: 12
	internal override void set_Value(string value) { }

	// RVA: 0x2860EA0 Offset: 0x2860FA1 VA: 0x2860EA0
	public static float[] StringToAxis(string axisStr) { }

	// RVA: 0x2860DA0 Offset: 0x2860EA1 VA: 0x2860DA0
	public static string AxisToString(float[] axis) { }

	// RVA: 0x2860FD0 Offset: 0x28610D1 VA: 0x2860FD0
	public void .ctor(string name, Func<string, float[], float[]> callback, float[] defaultAxis, float diff) { }

	// RVA: 0x28611A0 Offset: 0x28612A1 VA: 0x28611A0 Slot: 19
	public override void Tick() { }

	// RVA: 0x2861350 Offset: 0x2861451 VA: 0x2861350 Slot: 15
	public override bool Up() { }

	// RVA: 0x28613B0 Offset: 0x28614B1 VA: 0x28613B0 Slot: 16
	public override bool Down() { }

	// RVA: 0x2861410 Offset: 0x2861511 VA: 0x2861410 Slot: 17
	public override bool Right() { }

	// RVA: 0x2861470 Offset: 0x2861571 VA: 0x2861470 Slot: 18
	public override bool Left() { }
}

