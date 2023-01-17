// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x476B20 Offset: 0x476C21 VA: 0x476B20
[ObsoleteAttribute] // RVA: 0x476B20 Offset: 0x476C21 VA: 0x476B20
[Serializable]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider // TypeDefIndex: 1342
{
	// Fields
	private TextInfo m_text; // 0x10

	// Properties
	public static CaseInsensitiveHashCodeProvider Default { get; }

	// Methods

	// RVA: 0x35192C0 Offset: 0x35193C1 VA: 0x35192C0
	public void .ctor() { }

	// RVA: 0x3519350 Offset: 0x3519451 VA: 0x3519350
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x35193E0 Offset: 0x35194E1 VA: 0x35193E0
	public static CaseInsensitiveHashCodeProvider get_Default() { }

	// RVA: 0x3519470 Offset: 0x3519571 VA: 0x3519470 Slot: 4
	public int GetHashCode(object obj) { }
}

