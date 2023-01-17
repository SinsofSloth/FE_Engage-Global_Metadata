// Namespace: 
public class CalculatorManager.CommandList : Dictionary<int, CalculatorCommand> // TypeDefIndex: 13963
{
	// Methods

	// RVA: 0x1F7A5B0 Offset: 0x1F7A6B1 VA: 0x1F7A5B0
	public void .ctor() { }
}

// Namespace: 
private class CalculatorManager.CommandStack // TypeDefIndex: 13964
{
	// Fields
	public Stack<float> ValueStack; // 0x10
	public Stack<int> IndexStack; // 0x18
	public List<float> StackArgs; // 0x20
	public List<float> LocalArgs; // 0x28
	public List<float> TempArgs; // 0x30

	// Methods

	// RVA: 0x1F7A610 Offset: 0x1F7A711 VA: 0x1F7A610
	public void Clear() { }

	// RVA: 0x1F7A6D0 Offset: 0x1F7A7D1 VA: 0x1F7A6D0
	public void .ctor() { }
}

// Namespace: 
private class CalculatorManager.StackPool : Stack<CalculatorManager.CommandStack> // TypeDefIndex: 13965
{
	// Methods

	// RVA: 0x1F7A860 Offset: 0x1F7A961 VA: 0x1F7A860
	public void .ctor() { }
}

