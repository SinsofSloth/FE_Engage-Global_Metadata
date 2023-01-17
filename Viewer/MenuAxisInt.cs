// Namespace: Viewer
internal class MenuAxisInt : IMenuElement // TypeDefIndex: 8363
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27F920 Offset: 0x27FA21 VA: 0x27F920
	private readonly IMenuElement.DisplayType <DispType>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x27F930 Offset: 0x27FA31 VA: 0x27F930
	private readonly Func<string, int[], int[]> <Callback>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x27F940 Offset: 0x27FA41 VA: 0x27F940
	private int[] <Axis>k__BackingField; // 0x70

	// Properties
	protected override IMenuElement.DisplayType DispType { get; }
	public override float Height { get; }
	private Func<string, int[], int[]> Callback { get; }
	private int[] Axis { get; set; }
	internal override string Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A78F0 Offset: 0x2A79F1 VA: 0x2A78F0
	// RVA: 0x28614D0 Offset: 0x28615D1 VA: 0x28614D0 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x28614E0 Offset: 0x28615E1 VA: 0x28614E0 Slot: 9
	public override float get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7900 Offset: 0x2A7A01 VA: 0x2A7900
	// RVA: 0x28614F0 Offset: 0x28615F1 VA: 0x28614F0
	private Func<string, int[], int[]> get_Callback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7910 Offset: 0x2A7A11 VA: 0x2A7910
	// RVA: 0x2861500 Offset: 0x2861601 VA: 0x2861500
	private int[] get_Axis() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7920 Offset: 0x2A7A21 VA: 0x2A7920
	// RVA: 0x2861510 Offset: 0x2861611 VA: 0x2861510
	private void set_Axis(int[] value) { }

	// RVA: 0x2861520 Offset: 0x2861621 VA: 0x2861520 Slot: 11
	internal override string get_Value() { }

	// RVA: 0x2861600 Offset: 0x2861701 VA: 0x2861600 Slot: 12
	internal override void set_Value(string value) { }

	// RVA: 0x2861630 Offset: 0x2861731 VA: 0x2861630
	public static int[] StringToAxis(string axisStr) { }

	// RVA: 0x2861530 Offset: 0x2861631 VA: 0x2861530
	public static string AxisToString(int[] axis) { }

	// RVA: 0x2861760 Offset: 0x2861861 VA: 0x2861760
	public void .ctor(string name, Func<string, int[], int[]> callback, int[] defaultAxis) { }

	// RVA: 0x28618D0 Offset: 0x28619D1 VA: 0x28618D0 Slot: 19
	public override void Tick() { }

	// RVA: 0x2861A30 Offset: 0x2861B31 VA: 0x2861A30 Slot: 15
	public override bool Up() { }

	// RVA: 0x2861B90 Offset: 0x2861C91 VA: 0x2861B90 Slot: 16
	public override bool Down() { }

	// RVA: 0x2861CF0 Offset: 0x2861DF1 VA: 0x2861CF0 Slot: 17
	public override bool Right() { }

	// RVA: 0x2861E50 Offset: 0x2861F51 VA: 0x2861E50 Slot: 18
	public override bool Left() { }
}

