// Namespace: App
public class SystemCalculatorInstance<T> : SystemCalculator // TypeDefIndex: 9617
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B33E0 Offset: 0x34B34E1 VA: 0x34B33E0
	|-SystemCalculatorInstance<GameCalculator>.get_Instance
	|-SystemCalculatorInstance<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3510 Offset: 0x34B3611 VA: 0x34B3510
	|-SystemCalculatorInstance<GameCalculator>..ctor
	|-SystemCalculatorInstance<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3520 Offset: 0x34B3621 VA: 0x34B3520
	|-SystemCalculatorInstance<object>..cctor
	*/
}

