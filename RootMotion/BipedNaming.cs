// Namespace: RootMotion
public static class BipedNaming // TypeDefIndex: 14296
{
	// Fields
	public static string[] typeLeft; // 0x0
	public static string[] typeRight; // 0x8
	public static string[] typeSpine; // 0x10
	public static string[] typeHead; // 0x18
	public static string[] typeArm; // 0x20
	public static string[] typeLeg; // 0x28
	public static string[] typeTail; // 0x30
	public static string[] typeEye; // 0x38
	public static string[] typeExclude; // 0x40
	public static string[] typeExcludeSpine; // 0x48
	public static string[] typeExcludeHead; // 0x50
	public static string[] typeExcludeArm; // 0x58
	public static string[] typeExcludeLeg; // 0x60
	public static string[] typeExcludeTail; // 0x68
	public static string[] typeExcludeEye; // 0x70
	public static string[] pelvis; // 0x78
	public static string[] hand; // 0x80
	public static string[] foot; // 0x88

	// Methods

	// RVA: 0x22682E0 Offset: 0x22683E1 VA: 0x22682E0
	public static Transform[] GetBonesOfType(BipedNaming.BoneType boneType, Transform[] bones) { }

	// RVA: 0x2268680 Offset: 0x2268781 VA: 0x2268680
	public static Transform[] GetBonesOfSide(BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x2268920 Offset: 0x2268A21 VA: 0x2268920
	public static Transform[] GetBonesOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x22689B0 Offset: 0x2268AB1 VA: 0x22689B0
	public static Transform GetFirstBoneOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x2268AB0 Offset: 0x2268BB1 VA: 0x2268AB0
	public static Transform GetNamingMatch(Transform[] transforms, string[][] namings) { }

	// RVA: 0x22684C0 Offset: 0x22685C1 VA: 0x22684C0
	public static BipedNaming.BoneType GetBoneType(string boneName) { }

	// RVA: 0x2268860 Offset: 0x2268961 VA: 0x2268860
	public static BipedNaming.BoneSide GetBoneSide(string boneName) { }

	// RVA: 0x2269690 Offset: 0x2269791 VA: 0x2269690
	public static Transform GetBone(Transform[] transforms, BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide = 0, string[][] namings) { }

	// RVA: 0x2269350 Offset: 0x2269451 VA: 0x2269350
	private static bool isLeft(string boneName) { }

	// RVA: 0x22694F0 Offset: 0x22695F1 VA: 0x22694F0
	private static bool isRight(string boneName) { }

	// RVA: 0x2268CF0 Offset: 0x2268DF1 VA: 0x2268CF0
	private static bool isSpine(string boneName) { }

	// RVA: 0x2268E00 Offset: 0x2268F01 VA: 0x2268E00
	private static bool isHead(string boneName) { }

	// RVA: 0x2268F10 Offset: 0x2269011 VA: 0x2268F10
	private static bool isArm(string boneName) { }

	// RVA: 0x2269020 Offset: 0x2269121 VA: 0x2269020
	private static bool isLeg(string boneName) { }

	// RVA: 0x2269130 Offset: 0x2269231 VA: 0x2269130
	private static bool isTail(string boneName) { }

	// RVA: 0x2269240 Offset: 0x2269341 VA: 0x2269240
	private static bool isEye(string boneName) { }

	// RVA: 0x22698E0 Offset: 0x22699E1 VA: 0x22698E0
	private static bool isTypeExclude(string boneName) { }

	// RVA: 0x2268BD0 Offset: 0x2268CD1 VA: 0x2268BD0
	private static bool matchesNaming(string boneName, string[] namingConvention) { }

	// RVA: 0x2269850 Offset: 0x2269951 VA: 0x2269850
	private static bool excludesNaming(string boneName, string[] namingConvention) { }

	// RVA: 0x2269960 Offset: 0x2269A61 VA: 0x2269960
	private static bool matchesLastLetter(string boneName, string[] namingConvention) { }

	// RVA: 0x2269A50 Offset: 0x2269B51 VA: 0x2269A50
	private static bool LastLetterIs(string boneName, string letter) { }

	// RVA: 0x22697E0 Offset: 0x22698E1 VA: 0x22697E0
	private static string firstLetter(string boneName) { }

	// RVA: 0x2269770 Offset: 0x2269871 VA: 0x2269770
	private static string lastLetter(string boneName) { }

	// RVA: 0x2269A90 Offset: 0x2269B91 VA: 0x2269A90
	private static void .cctor() { }
}

