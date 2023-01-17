// Namespace: App
public class StructCalculatorData<T> : StructData<T> // TypeDefIndex: 9815
{
	// Fields
	private List<CalculatorCommand> m_Commands; // 0x0

	// Properties
	protected virtual CalculatorManager Calculator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual CalculatorManager get_Calculator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5320 Offset: 0x36C5421 VA: 0x36C5320
	|-StructCalculatorData<object>.get_Calculator
	*/

	// RVA: -1 Offset: -1
	protected CalculatorCommand AddCommand(string name, string func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5330 Offset: 0x36C5431 VA: 0x36C5330
	|-StructCalculatorData<CalculatorData>.AddCommand
	|-StructCalculatorData<object>.AddCommand
	|-StructCalculatorData<SkillData>.AddCommand
	*/

	// RVA: -1 Offset: -1
	public ConditionGetterCommand AddConditionGetterCommand(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5420 Offset: 0x36C5521 VA: 0x36C5420
	|-StructCalculatorData<CalculatorData>.AddConditionGetterCommand
	|-StructCalculatorData<object>.AddConditionGetterCommand
	*/

	// RVA: -1 Offset: -1
	protected void ReleaseCommand() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5500 Offset: 0x36C5601 VA: 0x36C5500
	|-StructCalculatorData<CalculatorData>.ReleaseCommand
	|-StructCalculatorData<object>.ReleaseCommand
	|-StructCalculatorData<SkillData>.ReleaseCommand
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36C5600 Offset: 0x36C5701 VA: 0x36C5600
	|-StructCalculatorData<CalculatorData>..ctor
	|-StructCalculatorData<object>..ctor
	|-StructCalculatorData<SkillData>..ctor
	*/
}

