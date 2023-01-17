// Namespace: App
public class CalculatorManager : CalculatorUtil // TypeDefIndex: 13966
{
	// Fields
	private static object s_lockObject; // 0x0
	private CalculatorManager.CommandList m_CommandList; // 0x10
	private const int STACK_MAX = 32;
	private const int ARGS_MAX = 16;
	private CalculatorManager.StackPool m_Pool; // 0x18

	// Methods

	// RVA: 0x2C7C850 Offset: 0x2C7C951 VA: 0x2C7C850
	public void .ctor() { }

	// RVA: 0x2C7CE90 Offset: 0x2C7CF91 VA: 0x2C7CE90
	public CalculatorCommand FindCommand(int key) { }

	// RVA: 0x2C7CF10 Offset: 0x2C7D011 VA: 0x2C7CF10
	public CalculatorCommand FindCommand(string name) { }

	// RVA: 0x2C7CD70 Offset: 0x2C7CE71 VA: 0x2C7CD70
	public CalculatorCommand AddCommand(CalculatorCommand command) { }

	// RVA: 0x2C7CFA0 Offset: 0x2C7D0A1 VA: 0x2C7CFA0
	public CalculatorCommand AddCommand(string name, string func) { }

	// RVA: 0x2C7D020 Offset: 0x2C7D121 VA: 0x2C7D020
	public CalculatorCommand AddCommand(string name, float value) { }

	// RVA: 0x2C7D0A0 Offset: 0x2C7D1A1 VA: 0x2C7D0A0
	public void RemoveCommand(CalculatorCommand command) { }

	// RVA: 0x2C7D1A0 Offset: 0x2C7D2A1 VA: 0x2C7D1A0
	public void RemoveCommand(string name) { }

	// RVA: -1 Offset: -1
	public void RemoveCommand<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229A0F0 Offset: 0x229A1F1 VA: 0x229A0F0
	|-CalculatorManager.RemoveCommand<object>
	*/

	// RVA: 0x2C7D250 Offset: 0x2C7D351 VA: 0x2C7D250
	public void ClearCommand() { }

	// RVA: 0x2C7D2B0 Offset: 0x2C7D3B1 VA: 0x2C7D2B0
	public float RunCommand(string name) { }

	// RVA: 0x2C7D360 Offset: 0x2C7D461 VA: 0x2C7D360
	public float RunCommand(string name, object obj1, object obj2) { }

	// RVA: 0x2C7D420 Offset: 0x2C7D521 VA: 0x2C7D420
	public float RunCommand(string name, List<float> args) { }

	// RVA: 0x2C7D4D0 Offset: 0x2C7D5D1 VA: 0x2C7D4D0
	public float RunCommand(string name, List<float> args, object obj1, object obj2) { }

	[ConditionalAttribute] // RVA: 0x2CDA60 Offset: 0x2CDB61 VA: 0x2CDA60
	// RVA: 0x2C7D5A0 Offset: 0x2C7D6A1 VA: 0x2C7D5A0
	public void Dump() { }

	// RVA: 0x2C7D850 Offset: 0x2C7D951 VA: 0x2C7D850
	public float Calculate(string name, object obj1, object obj2) { }

	// RVA: 0x2C7D930 Offset: 0x2C7DA31 VA: 0x2C7D930
	public float Calculate(StringCalculator calcurator, object obj1, object obj2) { }

	// RVA: 0x2C7EAF0 Offset: 0x2C7EBF1 VA: 0x2C7EAF0
	public float Calculate(StringCalculator calcurator, CalculatorCommand command, List<float> args, object obj1, object obj2) { }

	// RVA: 0x2C7D9D0 Offset: 0x2C7DAD1 VA: 0x2C7D9D0
	public float Calculate(StringCalculator calcurator, List<float> args, object obj1, object obj2) { }

	// RVA: 0x2C7EB10 Offset: 0x2C7EC11 VA: 0x2C7EB10
	public float Execute(string name, object obj1, object obj2) { }

	// RVA: 0x2C7EBD0 Offset: 0x2C7ECD1 VA: 0x2C7EBD0
	private float GetValueImpl(CalculatorUtil.Entity entity, object obj1, object obj2) { }

	// RVA: 0x2C7EC80 Offset: 0x2C7ED81 VA: 0x2C7EC80
	private float GetArgsImpl(CalculatorUtil.Entity entity, CalculatorManager.CommandStack stack) { }

	// RVA: 0x2C7ED30 Offset: 0x2C7EE31 VA: 0x2C7ED30
	private float FuncImpl(CalculatorCommand command, List<float> args, object obj1, object obj2) { }

	// RVA: 0x2C7EDD0 Offset: 0x2C7EED1 VA: 0x2C7EDD0
	private float FuncImpl(CalculatorUtil.Entity entity, CalculatorManager.CommandStack stack, float value, object obj1, object obj2) { }

	// RVA: 0x2C7F020 Offset: 0x2C7F121 VA: 0x2C7F020
	private float FuncImpl(CalculatorUtil.Entity entity, string arg, object obj1, object obj2) { }

	// RVA: 0x2C7F0D0 Offset: 0x2C7F1D1 VA: 0x2C7F0D0
	private float FuncImpl(CalculatorUtil.Entity entity, object obj1, object obj2) { }

	// RVA: 0x2C7F180 Offset: 0x2C7F281 VA: 0x2C7F180
	private void SetValueImpl(CalculatorUtil.Entity entity, float value, object obj1, object obj2) { }

	// RVA: 0x2C7F230 Offset: 0x2C7F331 VA: 0x2C7F230
	public Dictionary.ValueCollection<int, CalculatorCommand> GetCommandCollection() { }

	// RVA: 0x2C7F290 Offset: 0x2C7F391 VA: 0x2C7F290
	private static void .cctor() { }
}

