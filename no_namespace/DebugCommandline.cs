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

