// Namespace: Viewer
internal class MenuSlider : IMenuElement // TypeDefIndex: 8370
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FA60 Offset: 0x27FB61 VA: 0x27FA60
	private readonly bool <HasCallback>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x27FA70 Offset: 0x27FB71 VA: 0x27FA70
	private readonly Action<string, float> <Callback>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x27FA80 Offset: 0x27FB81 VA: 0x27FA80
	private float <InnerValue>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x27FA90 Offset: 0x27FB91 VA: 0x27FA90
	private float <IncrementValue>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x27FAA0 Offset: 0x27FBA1 VA: 0x27FAA0
	private readonly float <SliderMin>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x27FAB0 Offset: 0x27FBB1 VA: 0x27FAB0
	private readonly float <SliderMax>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x27FAC0 Offset: 0x27FBC1 VA: 0x27FAC0
	private readonly bool <IsLoop>k__BackingField; // 0x80
	private int m_LastChangeFrame; // 0x84
	private int m_ChangeFrame; // 0x88

	// Properties
	public override float Height { get; }
	protected override bool HasCallback { get; }
	private Action<string, float> Callback { get; }
	protected override IMenuElement.DisplayType DispType { get; }
	internal override string Value { get; set; }
	internal float InnerValue { get; set; }
	internal float IncrementValue { get; set; }
	protected override float SliderMin { get; }
	protected override float SliderMax { get; }
	private bool IsLoop { get; }

	// Methods

	// RVA: 0x2865D20 Offset: 0x2865E21 VA: 0x2865D20 Slot: 9
	public override float get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7AA0 Offset: 0x2A7BA1 VA: 0x2A7AA0
	// RVA: 0x2865D30 Offset: 0x2865E31 VA: 0x2865D30 Slot: 10
	protected override bool get_HasCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7AB0 Offset: 0x2A7BB1 VA: 0x2A7AB0
	// RVA: 0x2865D40 Offset: 0x2865E41 VA: 0x2865D40
	private Action<string, float> get_Callback() { }

	// RVA: 0x2865D50 Offset: 0x2865E51 VA: 0x2865D50 Slot: 8
	protected override IMenuElement.DisplayType get_DispType() { }

	// RVA: 0x2865D60 Offset: 0x2865E61 VA: 0x2865D60 Slot: 11
	internal override string get_Value() { }

	// RVA: 0x2865E30 Offset: 0x2865F31 VA: 0x2865E30 Slot: 12
	internal override void set_Value(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7AC0 Offset: 0x2A7BC1 VA: 0x2A7AC0
	// RVA: 0x2865E60 Offset: 0x2865F61 VA: 0x2865E60
	internal float get_InnerValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7AD0 Offset: 0x2A7BD1 VA: 0x2A7AD0
	// RVA: 0x2865E70 Offset: 0x2865F71 VA: 0x2865E70
	internal void set_InnerValue(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7AE0 Offset: 0x2A7BE1 VA: 0x2A7AE0
	// RVA: 0x2865E80 Offset: 0x2865F81 VA: 0x2865E80
	internal float get_IncrementValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7AF0 Offset: 0x2A7BF1 VA: 0x2A7AF0
	// RVA: 0x2865E90 Offset: 0x2865F91 VA: 0x2865E90
	internal void set_IncrementValue(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7B00 Offset: 0x2A7C01 VA: 0x2A7B00
	// RVA: 0x2865EA0 Offset: 0x2865FA1 VA: 0x2865EA0 Slot: 13
	protected override float get_SliderMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7B10 Offset: 0x2A7C11 VA: 0x2A7B10
	// RVA: 0x2865EB0 Offset: 0x2865FB1 VA: 0x2865EB0 Slot: 14
	protected override float get_SliderMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7B20 Offset: 0x2A7C21 VA: 0x2A7B20
	// RVA: 0x2865EC0 Offset: 0x2865FC1 VA: 0x2865EC0
	private bool get_IsLoop() { }

	// RVA: 0x2863490 Offset: 0x2863591 VA: 0x2863490
	public void .ctor(string name, float inc, float min, float max, Action<string, float> callback, bool isLoop = False) { }

	// RVA: 0x2865ED0 Offset: 0x2865FD1 VA: 0x2865ED0 Slot: 19
	public override void Tick() { }

	// RVA: 0x2865F60 Offset: 0x2866061 VA: 0x2865F60 Slot: 17
	public override bool Right() { }

	// RVA: 0x2866050 Offset: 0x2866151 VA: 0x2866050 Slot: 18
	public override bool Left() { }
}

