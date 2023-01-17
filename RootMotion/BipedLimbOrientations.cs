// Namespace: RootMotion
[Serializable]
public class BipedLimbOrientations // TypeDefIndex: 14293
{
	// Fields
	public BipedLimbOrientations.LimbOrientation leftArm; // 0x10
	public BipedLimbOrientations.LimbOrientation rightArm; // 0x18
	public BipedLimbOrientations.LimbOrientation leftLeg; // 0x20
	public BipedLimbOrientations.LimbOrientation rightLeg; // 0x28

	// Properties
	public static BipedLimbOrientations UMA { get; }
	public static BipedLimbOrientations MaxBiped { get; }

	// Methods

	// RVA: 0x2267D00 Offset: 0x2267E01 VA: 0x2267D00
	public void .ctor(BipedLimbOrientations.LimbOrientation leftArm, BipedLimbOrientations.LimbOrientation rightArm, BipedLimbOrientations.LimbOrientation leftLeg, BipedLimbOrientations.LimbOrientation rightLeg) { }

	// RVA: 0x2267D80 Offset: 0x2267E81 VA: 0x2267D80
	public static BipedLimbOrientations get_UMA() { }

	// RVA: 0x2268030 Offset: 0x2268131 VA: 0x2268030
	public static BipedLimbOrientations get_MaxBiped() { }
}

