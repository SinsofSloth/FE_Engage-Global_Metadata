// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279530 Offset: 0x279631 VA: 0x279530
[Serializable]
private sealed class LoadingLogo.UnitDotObject.<>c // TypeDefIndex: 14070
{
	// Fields
	public static readonly LoadingLogo.UnitDotObject.<>c <>9; // 0x0
	public static StructData.EachFuncVoid<PersonData> <>9__8_0; // 0x8

	// Methods

	// RVA: 0x1DD2140 Offset: 0x1DD2241 VA: 0x1DD2140
	private static void .cctor() { }

	// RVA: 0x1DD21B0 Offset: 0x1DD22B1 VA: 0x1DD21B0
	public void .ctor() { }

	// RVA: 0x1DD21C0 Offset: 0x1DD22C1 VA: 0x1DD21C0
	internal void <LoadUnitDotTextureAll>b__8_0(PersonData person) { }
}

// Namespace: 
private class LoadingLogo.UnitDotObject // TypeDefIndex: 14071
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private RawImage m_Image; // 0x18
	private Animator m_Animator; // 0x20
	private Material m_Material; // 0x28

	// Methods

	// RVA: 0x22314E0 Offset: 0x22315E1 VA: 0x22314E0
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x22315D0 Offset: 0x22316D1 VA: 0x22315D0
	public bool Setup(PersonData person, bool isFemale) { }

	// RVA: 0x2231940 Offset: 0x2231A41 VA: 0x2231940
	public void Clear() { }

	// RVA: 0x2231820 Offset: 0x2231921 VA: 0x2231820
	public static string GetUnitDotTexturePath(PersonData person, bool isFemale) { }

	// RVA: 0x2231A30 Offset: 0x2231B31 VA: 0x2231A30
	public static void LoadUnitDotTextureAll() { }
}

// Namespace: 
private enum LoadingLogo.Sequences // TypeDefIndex: 14072
{
	// Fields
	public int value__; // 0x0
	public const LoadingLogo.Sequences None = 0;
	public const LoadingLogo.Sequences Show = 1;
	public const LoadingLogo.Sequences Idle = 2;
	public const LoadingLogo.Sequences Change = 3;
	public const LoadingLogo.Sequences Hide = 4;
}

