// Namespace: System.Runtime.CompilerServices
[AttributeUsageAttribute] // RVA: 0x475930 Offset: 0x475A31 VA: 0x475930
public sealed class FixedBufferAttribute : Attribute // TypeDefIndex: 1271
{
	// Fields
	private Type elementType; // 0x10
	private int length; // 0x18

	// Properties
	public Type ElementType { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x38B37F0 Offset: 0x38B38F1 VA: 0x38B37F0
	public void .ctor(Type elementType, int length) { }

	// RVA: 0x38B3840 Offset: 0x38B3941 VA: 0x38B3840
	public Type get_ElementType() { }

	// RVA: 0x38B3850 Offset: 0x38B3951 VA: 0x38B3850
	public int get_Length() { }
}

