// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276700 Offset: 0x276801 VA: 0x276700
internal class VersusRewardData : StructData<VersusRewardData> // TypeDefIndex: 10119
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28D9D0 Offset: 0x28DAD1 VA: 0x28D9D0
	private string <TypeID>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28D9E0 Offset: 0x28DAE1 VA: 0x28D9E0
	private string[] <Iids>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28D9F0 Offset: 0x28DAF1 VA: 0x28D9F0
	private int[] <Nums>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28DA00 Offset: 0x28DB01 VA: 0x28DA00
	private string[] <Conditions>k__BackingField; // 0x38

	// Properties
	public string TypeID { get; set; }
	public string[] Iids { get; set; }
	public int[] Nums { get; set; }
	public string[] Conditions { get; set; }

	// Methods

	// RVA: 0x2A51EA0 Offset: 0x2A51FA1 VA: 0x2A51EA0
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD2F0 Offset: 0x2BD3F1 VA: 0x2BD2F0
	// RVA: 0x2A51F50 Offset: 0x2A52051 VA: 0x2A51F50
	public string get_TypeID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD300 Offset: 0x2BD401 VA: 0x2BD300
	// RVA: 0x2A51F60 Offset: 0x2A52061 VA: 0x2A51F60
	private void set_TypeID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD310 Offset: 0x2BD411 VA: 0x2BD310
	// RVA: 0x2A51F70 Offset: 0x2A52071 VA: 0x2A51F70
	public string[] get_Iids() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD320 Offset: 0x2BD421 VA: 0x2BD320
	// RVA: 0x2A51F80 Offset: 0x2A52081 VA: 0x2A51F80
	private void set_Iids(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD330 Offset: 0x2BD431 VA: 0x2BD330
	// RVA: 0x2A51F90 Offset: 0x2A52091 VA: 0x2A51F90
	public int[] get_Nums() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD340 Offset: 0x2BD441 VA: 0x2BD340
	// RVA: 0x2A51FA0 Offset: 0x2A520A1 VA: 0x2A51FA0
	private void set_Nums(int[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD350 Offset: 0x2BD451 VA: 0x2BD350
	// RVA: 0x2A51FB0 Offset: 0x2A520B1 VA: 0x2A51FB0
	public string[] get_Conditions() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD360 Offset: 0x2BD461 VA: 0x2BD360
	// RVA: 0x2A51FC0 Offset: 0x2A520C1 VA: 0x2A51FC0
	private void set_Conditions(string[] value) { }

	// RVA: 0x2A51FD0 Offset: 0x2A520D1 VA: 0x2A51FD0 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x2A51FE0 Offset: 0x2A520E1 VA: 0x2A51FE0 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x2A51FF0 Offset: 0x2A520F1 VA: 0x2A51FF0
	public bool TryGetRandomItem(out string iid, out int num) { }

	// RVA: 0x2A521C0 Offset: 0x2A522C1 VA: 0x2A521C0
	public void .ctor() { }
}

