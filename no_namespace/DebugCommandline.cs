// Namespace: 
public abstract class DebugCommandline.OptBaseAttribute : Attribute // TypeDefIndex: 9085
{
	// Methods

	// RVA: 0x1E12AD0 Offset: 0x1E12BD1 VA: 0x1E12AD0
	protected void .ctor() { }
}

// Namespace: 
[AttributeUsageAttribute] // RVA: 0x275150 Offset: 0x275251 VA: 0x275150
public class DebugCommandline.OptionAttribute : DebugCommandline.OptBaseAttribute // TypeDefIndex: 9086
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286BA0 Offset: 0x286CA1 VA: 0x286BA0
	private string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x1E12EE0 Offset: 0x1E12FE1 VA: 0x1E12EE0
	public void .ctor(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE280 Offset: 0x2AE381 VA: 0x2AE280
	// RVA: 0x1E12F60 Offset: 0x1E13061 VA: 0x1E12F60
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE290 Offset: 0x2AE391 VA: 0x2AE290
	// RVA: 0x1E12F70 Offset: 0x1E13071 VA: 0x1E12F70
	private void set_Name(string value) { }
}

// Namespace: 
[AttributeUsageAttribute] // RVA: 0x275190 Offset: 0x275291 VA: 0x275190
public class DebugCommandline.OptionWildcardAttribute : DebugCommandline.OptBaseAttribute // TypeDefIndex: 9087
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286BB0 Offset: 0x286CB1 VA: 0x286BB0
	private Regex <Regex>k__BackingField; // 0x10

	// Properties
	public Regex Regex { get; set; }

	// Methods

	// RVA: 0x1E12F80 Offset: 0x1E13081 VA: 0x1E12F80
	public void .ctor(string pattern) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE2A0 Offset: 0x2AE3A1 VA: 0x2AE2A0
	// RVA: 0x1E130F0 Offset: 0x1E131F1 VA: 0x1E130F0
	public Regex get_Regex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE2B0 Offset: 0x2AE3B1 VA: 0x2AE2B0
	// RVA: 0x1E13100 Offset: 0x1E13201 VA: 0x1E13100
	private void set_Regex(Regex value) { }
}

// Namespace: 
private abstract class DebugCommandline.Property // TypeDefIndex: 9088
{
	// Fields
	protected const int OptSortValue = 0;
	protected const int OptwSortValue = 10000;
	protected PropertyInfo m_Info; // 0x10

	// Properties
	public abstract int SortValue { get; }

	// Methods

	// RVA: 0x1E12D90 Offset: 0x1E12E91 VA: 0x1E12D90
	public void .ctor(PropertyInfo info) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int Process(object obj, string[] args, int argIndex);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_SortValue();
}

// Namespace: 
private abstract class DebugCommandline.OptProperty.Setter // TypeDefIndex: 9089
{
	// Properties
	public abstract bool IsNeedValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Set(object obj, PropertyInfo propertyInfo, string value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsNeedValue();

	// RVA: 0x1DC1C00 Offset: 0x1DC1D01 VA: 0x1DC1C00
	protected void .ctor() { }
}

// Namespace: 
private class DebugCommandline.OptProperty.IntSetter : DebugCommandline.OptProperty.Setter // TypeDefIndex: 9090
{
	// Properties
	public override bool IsNeedValue { get; }

	// Methods

	// RVA: 0x1DC1CF0 Offset: 0x1DC1DF1 VA: 0x1DC1CF0 Slot: 4
	public override bool Set(object obj, PropertyInfo propertyInfo, string value) { }

	// RVA: 0x1DC1DB0 Offset: 0x1DC1EB1 VA: 0x1DC1DB0 Slot: 5
	public override bool get_IsNeedValue() { }

	// RVA: 0x1DC1DC0 Offset: 0x1DC1EC1 VA: 0x1DC1DC0
	public void .ctor() { }
}

// Namespace: 
private class DebugCommandline.OptProperty.FloatSetter : DebugCommandline.OptProperty.Setter // TypeDefIndex: 9091
{
	// Properties
	public override bool IsNeedValue { get; }

	// Methods

	// RVA: 0x1DC1C10 Offset: 0x1DC1D11 VA: 0x1DC1C10 Slot: 4
	public override bool Set(object obj, PropertyInfo propertyInfo, string value) { }

	// RVA: 0x1DC1CD0 Offset: 0x1DC1DD1 VA: 0x1DC1CD0 Slot: 5
	public override bool get_IsNeedValue() { }

	// RVA: 0x1DC1CE0 Offset: 0x1DC1DE1 VA: 0x1DC1CE0
	public void .ctor() { }
}

// Namespace: 
private class DebugCommandline.OptProperty.StringSetter : DebugCommandline.OptProperty.Setter // TypeDefIndex: 9092
{
	// Properties
	public override bool IsNeedValue { get; }

	// Methods

	// RVA: 0x1DC1DD0 Offset: 0x1DC1ED1 VA: 0x1DC1DD0 Slot: 4
	public override bool Set(object obj, PropertyInfo propertyInfo, string value) { }

	// RVA: 0x1DC1E00 Offset: 0x1DC1F01 VA: 0x1DC1E00 Slot: 5
	public override bool get_IsNeedValue() { }

	// RVA: 0x1DC1E10 Offset: 0x1DC1F11 VA: 0x1DC1E10
	public void .ctor() { }
}

// Namespace: 
private class DebugCommandline.OptProperty.BoolSetter : DebugCommandline.OptProperty.Setter // TypeDefIndex: 9093
{
	// Properties
	public override bool IsNeedValue { get; }

	// Methods

	// RVA: 0x1DC1B50 Offset: 0x1DC1C51 VA: 0x1DC1B50 Slot: 4
	public override bool Set(object obj, PropertyInfo propertyInfo, string value) { }

	// RVA: 0x1DC1BE0 Offset: 0x1DC1CE1 VA: 0x1DC1BE0 Slot: 5
	public override bool get_IsNeedValue() { }

	// RVA: 0x1DC1BF0 Offset: 0x1DC1CF1 VA: 0x1DC1BF0
	public void .ctor() { }
}

// Namespace: 
private class DebugCommandline.OptProperty : DebugCommandline.Property // TypeDefIndex: 9094
{
	// Fields
	private DebugCommandline.OptionAttribute m_Attribute; // 0x18
	private DebugCommandline.OptProperty.Setter m_Setter; // 0x20

	// Properties
	public override int SortValue { get; }

	// Methods

	// RVA: 0x1E12AE0 Offset: 0x1E12BE1 VA: 0x1E12AE0
	public void .ctor(PropertyInfo info, DebugCommandline.OptionAttribute attribute) { }

	// RVA: 0x1E12DD0 Offset: 0x1E12ED1 VA: 0x1E12DD0 Slot: 4
	public override int Process(object obj, string[] args, int argIndex) { }

	// RVA: 0x1E12ED0 Offset: 0x1E12FD1 VA: 0x1E12ED0 Slot: 5
	public override int get_SortValue() { }
}

// Namespace: 
private class DebugCommandline.OptwProperty : DebugCommandline.Property // TypeDefIndex: 9095
{
	// Fields
	private DebugCommandline.OptionWildcardAttribute m_Attribute; // 0x18
	private bool m_IsValid; // 0x20

	// Properties
	public override int SortValue { get; }

	// Methods

	// RVA: 0x1E13110 Offset: 0x1E13211 VA: 0x1E13110
	public void .ctor(PropertyInfo info, DebugCommandline.OptionWildcardAttribute attribute) { }

	// RVA: 0x1E13210 Offset: 0x1E13311 VA: 0x1E13210 Slot: 4
	public override int Process(object obj, string[] args, int argIndex) { }

	// RVA: 0x1E132B0 Offset: 0x1E133B1 VA: 0x1E132B0 Slot: 5
	public override int get_SortValue() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2751D0 Offset: 0x2752D1 VA: 0x2751D0
[Serializable]
private sealed class DebugCommandline.<>c__6<T> // TypeDefIndex: 9096
{
	// Fields
	public static readonly DebugCommandline.<>c__6<T> <>9; // 0x0
	public static Comparison<DebugCommandline.Property> <>9__6_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36C10 Offset: 0x2B36D11 VA: 0x2B36C10
	|-DebugCommandline.<>c__6<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36CF0 Offset: 0x2B36DF1 VA: 0x2B36CF0
	|-DebugCommandline.<>c__6<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <Parse>b__6_0(DebugCommandline.Property a, DebugCommandline.Property b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B36D00 Offset: 0x2B36E01 VA: 0x2B36D00
	|-DebugCommandline.<>c__6<object>.<Parse>b__6_0
	*/
}

