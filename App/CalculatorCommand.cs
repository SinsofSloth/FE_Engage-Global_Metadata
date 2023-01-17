// Namespace: App
public class CalculatorCommand // TypeDefIndex: 13938
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29CC50 Offset: 0x29CD51 VA: 0x29CC50
	private CalculatorManager <Manager>k__BackingField; // 0x10

	// Properties
	public virtual string Name { get; }
	public virtual string Header { get; }
	public virtual string Footer { get; }
	public string FullName { get; }
	public int HashCode { get; }
	public virtual int ArgNum { get; }
	public virtual string Help { get; }
	public CalculatorManager Manager { get; set; }

	// Methods

	// RVA: 0x2C7BDE0 Offset: 0x2C7BEE1 VA: 0x2C7BDE0 Slot: 4
	public virtual string get_Name() { }

	// RVA: 0x2C7BE30 Offset: 0x2C7BF31 VA: 0x2C7BE30 Slot: 5
	public virtual string get_Header() { }

	// RVA: 0x2C7BE80 Offset: 0x2C7BF81 VA: 0x2C7BE80 Slot: 6
	public virtual string get_Footer() { }

	// RVA: 0x2C7BED0 Offset: 0x2C7BFD1 VA: 0x2C7BED0
	public string get_FullName() { }

	// RVA: 0x2C7BF40 Offset: 0x2C7C041 VA: 0x2C7BF40
	public int get_HashCode() { }

	// RVA: 0x2C7BFC0 Offset: 0x2C7C0C1 VA: 0x2C7BFC0 Slot: 7
	public virtual int get_ArgNum() { }

	// RVA: 0x2C7BFD0 Offset: 0x2C7C0D1 VA: 0x2C7BFD0 Slot: 8
	public virtual string get_Help() { }

	// RVA: 0x2C7BFE0 Offset: 0x2C7C0E1 VA: 0x2C7BFE0 Slot: 9
	public virtual float Get() { }

	// RVA: 0x2C7BFF0 Offset: 0x2C7C0F1 VA: 0x2C7BFF0 Slot: 10
	public virtual float Get(object obj) { }

	// RVA: 0x2C7C000 Offset: 0x2C7C101 VA: 0x2C7C000 Slot: 11
	public virtual float Get(object obj1, object obj2) { }

	// RVA: 0x2C7C010 Offset: 0x2C7C111 VA: 0x2C7C010 Slot: 12
	public virtual void Set(float value) { }

	// RVA: 0x2C7C020 Offset: 0x2C7C121 VA: 0x2C7C020 Slot: 13
	public virtual void Set(float value, object obj) { }

	// RVA: 0x2C7C030 Offset: 0x2C7C131 VA: 0x2C7C030 Slot: 14
	public virtual void Set(float value, object obj1, object obj2) { }

	// RVA: 0x2C7C040 Offset: 0x2C7C141 VA: 0x2C7C040 Slot: 15
	public virtual void Add(float value) { }

	// RVA: 0x2C7C090 Offset: 0x2C7C191 VA: 0x2C7C090 Slot: 16
	public virtual void Add(float value, object obj) { }

	// RVA: 0x2C7C0E0 Offset: 0x2C7C1E1 VA: 0x2C7C0E0 Slot: 17
	public virtual void Add(float value, object obj1, object obj2) { }

	// RVA: 0x2C7C140 Offset: 0x2C7C241 VA: 0x2C7C140 Slot: 18
	public virtual void Scale(float value) { }

	// RVA: 0x2C7C190 Offset: 0x2C7C291 VA: 0x2C7C190 Slot: 19
	public virtual void Scale(float value, object obj) { }

	// RVA: 0x2C7C1E0 Offset: 0x2C7C2E1 VA: 0x2C7C1E0 Slot: 20
	public virtual void Scale(float value, object obj1, object obj2) { }

	// RVA: 0x2C7C240 Offset: 0x2C7C341 VA: 0x2C7C240 Slot: 21
	public virtual float Func() { }

	// RVA: 0x2C7C2C0 Offset: 0x2C7C3C1 VA: 0x2C7C2C0 Slot: 22
	public virtual float Func(object obj) { }

	// RVA: 0x2C7C350 Offset: 0x2C7C451 VA: 0x2C7C350 Slot: 23
	public virtual float Func(object obj1, object obj2) { }

	// RVA: 0x2C7C3F0 Offset: 0x2C7C4F1 VA: 0x2C7C3F0 Slot: 24
	public virtual float Func(List<float> args) { }

	// RVA: 0x2C7C400 Offset: 0x2C7C501 VA: 0x2C7C400 Slot: 25
	public virtual float Func(List<float> args, object obj) { }

	// RVA: 0x2C7C410 Offset: 0x2C7C511 VA: 0x2C7C410 Slot: 26
	public virtual float Func(List<float> args, object obj1, object obj2) { }

	// RVA: 0x2C7C420 Offset: 0x2C7C521 VA: 0x2C7C420 Slot: 27
	public virtual float Func(string arg) { }

	// RVA: 0x2C7C430 Offset: 0x2C7C531 VA: 0x2C7C430 Slot: 28
	public virtual float Func(string arg, object obj) { }

	// RVA: 0x2C7C440 Offset: 0x2C7C541 VA: 0x2C7C440 Slot: 29
	public virtual float Func(string arg, object obj1, object obj2) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDA40 Offset: 0x2CDB41 VA: 0x2CDA40
	// RVA: 0x2C7C450 Offset: 0x2C7C551 VA: 0x2C7C450
	public CalculatorManager get_Manager() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDA50 Offset: 0x2CDB51 VA: 0x2CDA50
	// RVA: 0x2C7C460 Offset: 0x2C7C561 VA: 0x2C7C460
	public void set_Manager(CalculatorManager value) { }

	// RVA: 0x2C7C470 Offset: 0x2C7C571 VA: 0x2C7C470
	public bool IsDebugDump() { }

	// RVA: 0x2C7C480 Offset: 0x2C7C581 VA: 0x2C7C480
	public CalculatorCommand SetDebugDump(bool enable) { }

	// RVA: 0x2C76800 Offset: 0x2C76901 VA: 0x2C76800
	public void .ctor() { }
}

