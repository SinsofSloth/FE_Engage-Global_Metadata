// Namespace: App
internal class FunctionCommand : CalculatorCommand // TypeDefIndex: 13959
{
	// Fields
	private string m_Name; // 0x18
	private StringCalculator m_Function; // 0x20

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x26A0680 Offset: 0x26A0781 VA: 0x26A0680
	public void .ctor(string name, string func) { }

	// RVA: 0x26A0720 Offset: 0x26A0821 VA: 0x26A0720 Slot: 4
	public override string get_Name() { }

	// RVA: 0x26A0730 Offset: 0x26A0831 VA: 0x26A0730 Slot: 10
	public override float Get(object obj) { }

	// RVA: 0x26A0740 Offset: 0x26A0841 VA: 0x26A0740 Slot: 11
	public override float Get(object obj1, object obj2) { }

	// RVA: 0x26A0750 Offset: 0x26A0851 VA: 0x26A0750 Slot: 25
	public override float Func(List<float> args, object obj) { }

	// RVA: 0x26A0770 Offset: 0x26A0871 VA: 0x26A0770 Slot: 26
	public override float Func(List<float> args, object obj1, object obj2) { }
}

