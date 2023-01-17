// Namespace: 
public enum MapMaterial.Kinds // TypeDefIndex: 12186
{
	// Fields
	public int value__; // 0x0
	public const MapMaterial.Kinds None = 0;
	public const MapMaterial.Kinds Float = 1;
	public const MapMaterial.Kinds Color = 2;
}

// Namespace: 
public class MapMaterial.Node // TypeDefIndex: 12187
{
	// Fields
	public MapMaterial.Kinds kind; // 0x10
	public string material; // 0x18
	public string property; // 0x20
	public float value; // 0x28
	public Color color; // 0x2C

	// Methods

	// RVA: 0x240CE90 Offset: 0x240CF91 VA: 0x240CE90
	public void .ctor() { }
}

