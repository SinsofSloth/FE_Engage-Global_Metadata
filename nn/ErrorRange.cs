// Namespace: nn
public struct ErrorRange // TypeDefIndex: 14496
{
	// Fields
	private int _module; // 0x0
	private int _descriptionBegin; // 0x4
	private int _descriptionEnd; // 0x8

	// Properties
	public int Module { get; }
	public int DescriptionBegin { get; }
	public int DescriptionEnd { get; }

	// Methods

	// RVA: 0x26057A0 Offset: 0x26058A1 VA: 0x26057A0
	internal void .ctor(int Module, int DescriptionBegin, int DescriptionEnd) { }

	// RVA: 0x26057B0 Offset: 0x26058B1 VA: 0x26057B0
	public int get_Module() { }

	// RVA: 0x26057C0 Offset: 0x26058C1 VA: 0x26057C0
	public int get_DescriptionBegin() { }

	// RVA: 0x26057D0 Offset: 0x26058D1 VA: 0x26057D0
	public int get_DescriptionEnd() { }

	// RVA: 0x26057E0 Offset: 0x26058E1 VA: 0x26057E0
	public bool Includes(Result result) { }
}

