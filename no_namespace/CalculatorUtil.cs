// Namespace: 
public enum CalculatorUtil.Type // TypeDefIndex: 13934
{
	// Fields
	public int value__; // 0x0
	public const CalculatorUtil.Type None = 0;
	public const CalculatorUtil.Type Add = 1;
	public const CalculatorUtil.Type Sub = 2;
	public const CalculatorUtil.Type Mul = 3;
	public const CalculatorUtil.Type Div = 4;
	public const CalculatorUtil.Type Per = 5;
	public const CalculatorUtil.Type Or = 6;
	public const CalculatorUtil.Type And = 7;
	public const CalculatorUtil.Type Xor = 8;
	public const CalculatorUtil.Type LShift = 9;
	public const CalculatorUtil.Type RShift = 10;
	public const CalculatorUtil.Type Equal = 11;
	public const CalculatorUtil.Type Nequal = 12;
	public const CalculatorUtil.Type Less = 13;
	public const CalculatorUtil.Type Lequal = 14;
	public const CalculatorUtil.Type Greater = 15;
	public const CalculatorUtil.Type Gequal = 16;
	public const CalculatorUtil.Type Assign = 17;
	public const CalculatorUtil.Type OrAssign = 18;
	public const CalculatorUtil.Type AndAssign = 19;
	public const CalculatorUtil.Type XorAssign = 20;
	public const CalculatorUtil.Type AddAssign = 21;
	public const CalculatorUtil.Type SubAssign = 22;
	public const CalculatorUtil.Type MulAssign = 23;
	public const CalculatorUtil.Type DivAssign = 24;
	public const CalculatorUtil.Type PerAssign = 25;
	public const CalculatorUtil.Type LSAssign = 26;
	public const CalculatorUtil.Type RSAssign = 27;
	public const CalculatorUtil.Type Open = 28;
	public const CalculatorUtil.Type Close = 29;
	public const CalculatorUtil.Type Comma = 30;
	public const CalculatorUtil.Type LogOr = 31;
	public const CalculatorUtil.Type LogAnd = 32;
	public const CalculatorUtil.Type Negative = 33;
	public const CalculatorUtil.Type Number = 34;
	public const CalculatorUtil.Type Variable = 35;
	public const CalculatorUtil.Type Function = 36;
	public const CalculatorUtil.Type Args = 37;
	public const CalculatorUtil.Type String = 38;
}

// Namespace: 
public class CalculatorUtil.Entity // TypeDefIndex: 13935
{
	// Fields
	private CalculatorUtil.Type m_Type; // 0x10
	private string m_Name; // 0x18
	private float m_Value; // 0x20
	private int m_Code; // 0x24

	// Properties
	public CalculatorUtil.Type Type { get; }
	public string Name { get; }
	public float Value { get; }
	public int Code { get; }

	// Methods

	// RVA: 0x1DFC680 Offset: 0x1DFC781 VA: 0x1DFC680
	public CalculatorUtil.Type get_Type() { }

	// RVA: 0x1DFC690 Offset: 0x1DFC791 VA: 0x1DFC690
	public string get_Name() { }

	// RVA: 0x1DFC6A0 Offset: 0x1DFC7A1 VA: 0x1DFC6A0
	public float get_Value() { }

	// RVA: 0x1DFC6B0 Offset: 0x1DFC7B1 VA: 0x1DFC6B0
	public int get_Code() { }

	// RVA: 0x1DFC6C0 Offset: 0x1DFC7C1 VA: 0x1DFC6C0
	public void .ctor(CalculatorUtil.Type type, string name, float value = 0) { }
}

