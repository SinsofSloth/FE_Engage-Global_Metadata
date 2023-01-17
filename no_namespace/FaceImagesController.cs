// Namespace: 
public enum FaceImagesController.PlayPattern // TypeDefIndex: 14172
{
	// Fields
	public int value__; // 0x0
	public const FaceImagesController.PlayPattern Anything = 0;
	public const FaceImagesController.PlayPattern HitWeak = 1;
	public const FaceImagesController.PlayPattern HitStrong = 2;
	public const FaceImagesController.PlayPattern Clear = 3;
}

// Namespace: 
public enum FaceImagesController.AnimType // TypeDefIndex: 14173
{
	// Fields
	public int value__; // 0x0
	public const FaceImagesController.AnimType None = -1;
	public const FaceImagesController.AnimType Normal = 0;
	public const FaceImagesController.AnimType Surprise = 1;
	public const FaceImagesController.AnimType Smile = 2;
	public const FaceImagesController.AnimType Die = 3;
	public const FaceImagesController.AnimType Relax = 4;
	public const FaceImagesController.AnimType Shy = 5;
}

// Namespace: 
private class FaceImagesController.ReturnEntryComponent : MonoBehaviour // TypeDefIndex: 14174
{
	// Fields
	private Character m_Character; // 0x18
	private Animator m_Animator; // 0x20
	private string m_NowAnimName; // 0x28
	private string m_ChangeAnimName; // 0x30
	private float m_Time; // 0x38

	// Methods

	// RVA: 0x22D90F0 Offset: 0x22D91F1 VA: 0x22D90F0
	public void SetCharacter(Character chara, string nowAnimName, string changeAnimName) { }

	// RVA: 0x22D9170 Offset: 0x22D9271 VA: 0x22D9170
	private void Update() { }

	// RVA: 0x22D9310 Offset: 0x22D9411 VA: 0x22D9310
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2797B0 Offset: 0x2798B1 VA: 0x2797B0
private sealed class FaceImagesController.<>c__DisplayClass16_0 // TypeDefIndex: 14175
{
	// Fields
	public Character chara; // 0x10
	public FaceImagesController <>4__this; // 0x18

	// Methods

	// RVA: 0x22D8D90 Offset: 0x22D8E91 VA: 0x22D8D90
	public void .ctor() { }

	// RVA: 0x22D8DA0 Offset: 0x22D8EA1 VA: 0x22D8DA0
	internal void <Start>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2797C0 Offset: 0x2798C1 VA: 0x2797C0
private sealed class FaceImagesController.<>c__DisplayClass16_1 // TypeDefIndex: 14176
{
	// Fields
	public Character chara; // 0x10
	public FaceImagesController <>4__this; // 0x18

	// Methods

	// RVA: 0x22D8EB0 Offset: 0x22D8FB1 VA: 0x22D8EB0
	public void .ctor() { }

	// RVA: 0x22D8EC0 Offset: 0x22D8FC1 VA: 0x22D8EC0
	internal void <Start>b__1() { }
}

