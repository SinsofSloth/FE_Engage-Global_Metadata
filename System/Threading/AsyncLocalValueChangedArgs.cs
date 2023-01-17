// Namespace: System.Threading
public struct AsyncLocalValueChangedArgs<T> // TypeDefIndex: 753
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x479080 Offset: 0x479181 VA: 0x479080
	private T <PreviousValue>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x479090 Offset: 0x479191 VA: 0x479090
	private T <CurrentValue>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x4790A0 Offset: 0x4791A1 VA: 0x4790A0
	private bool <ThreadContextChanged>k__BackingField; // 0x0

	// Properties
	private T PreviousValue { set; }
	public T CurrentValue { get; set; }
	private bool ThreadContextChanged { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x47C5C0 Offset: 0x47C6C1 VA: 0x47C5C0
	// RVA: -1 Offset: -1
	private void set_PreviousValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2590 Offset: 0x32D2691 VA: 0x32D2590
	|-AsyncLocalValueChangedArgs<object>.set_PreviousValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x47C5D0 Offset: 0x47C6D1 VA: 0x47C5D0
	// RVA: -1 Offset: -1
	public T get_CurrentValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D25A0 Offset: 0x32D26A1 VA: 0x32D25A0
	|-AsyncLocalValueChangedArgs<CultureInfo>.get_CurrentValue
	|-AsyncLocalValueChangedArgs<object>.get_CurrentValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x47C5E0 Offset: 0x47C6E1 VA: 0x47C5E0
	// RVA: -1 Offset: -1
	private void set_CurrentValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D25B0 Offset: 0x32D26B1 VA: 0x32D25B0
	|-AsyncLocalValueChangedArgs<object>.set_CurrentValue
	*/

	[CompilerGeneratedAttribute] // RVA: 0x47C5F0 Offset: 0x47C6F1 VA: 0x47C5F0
	// RVA: -1 Offset: -1
	private void set_ThreadContextChanged(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D25C0 Offset: 0x32D26C1 VA: 0x32D25C0
	|-AsyncLocalValueChangedArgs<object>.set_ThreadContextChanged
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T previousValue, T currentValue, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D25D0 Offset: 0x32D26D1 VA: 0x32D25D0
	|-AsyncLocalValueChangedArgs<object>..ctor
	*/
}

