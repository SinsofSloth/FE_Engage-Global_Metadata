// Namespace: System.Dynamic.Utils
internal static class ContractUtils // TypeDefIndex: 3275
{
	// Properties
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42590 Offset: 0x42691 VA: 0x42590
	public static Exception Unreachable { get; }

	// Methods

	// RVA: 0x2E46420 Offset: 0x2E46521 VA: 0x2E46420
	public static Exception get_Unreachable() { }

	// RVA: 0x2E562B0 Offset: 0x2E563B1 VA: 0x2E562B0
	public static void Requires(bool precondition, string paramName) { }

	// RVA: 0x2E51DB0 Offset: 0x2E51EB1 VA: 0x2E51DB0
	public static void RequiresNotNull(object value, string paramName) { }

	// RVA: 0x2E56370 Offset: 0x2E56471 VA: 0x2E56370
	public static void RequiresNotNull(object value, string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229C120 Offset: 0x229C221 VA: 0x229C120
	|-ContractUtils.RequiresNotNullItems<CatchBlock>
	|-ContractUtils.RequiresNotNullItems<object>
	*/

	// RVA: 0x2E563D0 Offset: 0x2E564D1 VA: 0x2E563D0
	private static string GetParamName(string paramName, int index) { }
}

