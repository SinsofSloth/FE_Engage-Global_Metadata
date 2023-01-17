// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43B8C0 Offset: 0x43B9C1 VA: 0x43B8C0
public struct SortingLayer // TypeDefIndex: 3396
{
	// Fields
	private int m_Id; // 0x0

	// Properties
	public int id { get; }
	public int value { get; }
	public static SortingLayer[] layers { get; }

	// Methods

	// RVA: 0x31EC440 Offset: 0x31EC541 VA: 0x31EC440
	public int get_id() { }

	// RVA: 0x31EC450 Offset: 0x31EC551 VA: 0x31EC450
	public int get_value() { }

	// RVA: 0x31EC4F0 Offset: 0x31EC5F1 VA: 0x31EC4F0
	public static SortingLayer[] get_layers() { }

	[FreeFunctionAttribute] // RVA: 0x445C90 Offset: 0x445D91 VA: 0x445C90
	// RVA: 0x31EC5C0 Offset: 0x31EC6C1 VA: 0x31EC5C0
	private static int[] GetSortingLayerIDsInternal() { }

	[FreeFunctionAttribute] // RVA: 0x445CD0 Offset: 0x445DD1 VA: 0x445CD0
	// RVA: 0x31EC4A0 Offset: 0x31EC5A1 VA: 0x31EC4A0
	public static int GetLayerValueFromID(int id) { }

	[FreeFunctionAttribute] // RVA: 0x445D10 Offset: 0x445E11 VA: 0x445D10
	// RVA: 0x31EC600 Offset: 0x31EC701 VA: 0x31EC600
	public static string IDToName(int id) { }
}

