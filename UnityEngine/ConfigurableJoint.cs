// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x485BE0 Offset: 0x485CE1 VA: 0x485BE0
[NativeClassAttribute] // RVA: 0x485BE0 Offset: 0x485CE1 VA: 0x485BE0
public class ConfigurableJoint : Joint // TypeDefIndex: 4208
{
	// Properties
	public Vector3 secondaryAxis { get; set; }
	public ConfigurableJointMotion xMotion { get; set; }
	public ConfigurableJointMotion yMotion { get; set; }
	public ConfigurableJointMotion zMotion { get; set; }
	public ConfigurableJointMotion angularXMotion { get; set; }
	public ConfigurableJointMotion angularYMotion { get; set; }
	public ConfigurableJointMotion angularZMotion { get; set; }
	public SoftJointLimitSpring linearLimitSpring { get; set; }
	public SoftJointLimitSpring angularXLimitSpring { get; set; }
	public SoftJointLimitSpring angularYZLimitSpring { get; set; }
	public SoftJointLimit linearLimit { get; set; }
	public SoftJointLimit lowAngularXLimit { get; set; }
	public SoftJointLimit highAngularXLimit { get; set; }
	public SoftJointLimit angularYLimit { get; set; }
	public SoftJointLimit angularZLimit { get; set; }
	public Vector3 targetPosition { get; set; }
	public Vector3 targetVelocity { get; set; }
	public JointDrive xDrive { get; set; }
	public JointDrive yDrive { get; set; }
	public JointDrive zDrive { get; set; }
	public Quaternion targetRotation { get; set; }
	public Vector3 targetAngularVelocity { get; set; }
	public RotationDriveMode rotationDriveMode { get; set; }
	public JointDrive angularXDrive { get; set; }
	public JointDrive angularYZDrive { get; set; }
	public JointDrive slerpDrive { get; set; }
	public JointProjectionMode projectionMode { get; set; }
	public float projectionDistance { get; set; }
	public float projectionAngle { get; set; }
	public bool configuredInWorldSpace { get; set; }
	public bool swapBodies { get; set; }

	// Methods

	// RVA: 0x3EE1A10 Offset: 0x3EE1B11 VA: 0x3EE1A10
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x3EE1AC0 Offset: 0x3EE1BC1 VA: 0x3EE1AC0
	public void set_secondaryAxis(Vector3 value) { }

	// RVA: 0x3EE1B70 Offset: 0x3EE1C71 VA: 0x3EE1B70
	public ConfigurableJointMotion get_xMotion() { }

	// RVA: 0x3EE1BC0 Offset: 0x3EE1CC1 VA: 0x3EE1BC0
	public void set_xMotion(ConfigurableJointMotion value) { }

	// RVA: 0x3EE1C10 Offset: 0x3EE1D11 VA: 0x3EE1C10
	public ConfigurableJointMotion get_yMotion() { }

	// RVA: 0x3EE1C60 Offset: 0x3EE1D61 VA: 0x3EE1C60
	public void set_yMotion(ConfigurableJointMotion value) { }

	// RVA: 0x3EE1CB0 Offset: 0x3EE1DB1 VA: 0x3EE1CB0
	public ConfigurableJointMotion get_zMotion() { }

	// RVA: 0x3EE1D00 Offset: 0x3EE1E01 VA: 0x3EE1D00
	public void set_zMotion(ConfigurableJointMotion value) { }

	// RVA: 0x3EE1D50 Offset: 0x3EE1E51 VA: 0x3EE1D50
	public ConfigurableJointMotion get_angularXMotion() { }

	// RVA: 0x3EE1DA0 Offset: 0x3EE1EA1 VA: 0x3EE1DA0
	public void set_angularXMotion(ConfigurableJointMotion value) { }

	// RVA: 0x3EE1DF0 Offset: 0x3EE1EF1 VA: 0x3EE1DF0
	public ConfigurableJointMotion get_angularYMotion() { }

	// RVA: 0x3EE1E40 Offset: 0x3EE1F41 VA: 0x3EE1E40
	public void set_angularYMotion(ConfigurableJointMotion value) { }

	// RVA: 0x3EE1E90 Offset: 0x3EE1F91 VA: 0x3EE1E90
	public ConfigurableJointMotion get_angularZMotion() { }

	// RVA: 0x3EE1EE0 Offset: 0x3EE1FE1 VA: 0x3EE1EE0
	public void set_angularZMotion(ConfigurableJointMotion value) { }

	// RVA: 0x3EE1F30 Offset: 0x3EE2031 VA: 0x3EE1F30
	public SoftJointLimitSpring get_linearLimitSpring() { }

	// RVA: 0x3EE1FE0 Offset: 0x3EE20E1 VA: 0x3EE1FE0
	public void set_linearLimitSpring(SoftJointLimitSpring value) { }

	// RVA: 0x3EE2090 Offset: 0x3EE2191 VA: 0x3EE2090
	public SoftJointLimitSpring get_angularXLimitSpring() { }

	// RVA: 0x3EE2140 Offset: 0x3EE2241 VA: 0x3EE2140
	public void set_angularXLimitSpring(SoftJointLimitSpring value) { }

	// RVA: 0x3EE21F0 Offset: 0x3EE22F1 VA: 0x3EE21F0
	public SoftJointLimitSpring get_angularYZLimitSpring() { }

	// RVA: 0x3EE22A0 Offset: 0x3EE23A1 VA: 0x3EE22A0
	public void set_angularYZLimitSpring(SoftJointLimitSpring value) { }

	// RVA: 0x3EE2350 Offset: 0x3EE2451 VA: 0x3EE2350
	public SoftJointLimit get_linearLimit() { }

	// RVA: 0x3EE2400 Offset: 0x3EE2501 VA: 0x3EE2400
	public void set_linearLimit(SoftJointLimit value) { }

	// RVA: 0x3EE24B0 Offset: 0x3EE25B1 VA: 0x3EE24B0
	public SoftJointLimit get_lowAngularXLimit() { }

	// RVA: 0x3EE2560 Offset: 0x3EE2661 VA: 0x3EE2560
	public void set_lowAngularXLimit(SoftJointLimit value) { }

	// RVA: 0x3EE2610 Offset: 0x3EE2711 VA: 0x3EE2610
	public SoftJointLimit get_highAngularXLimit() { }

	// RVA: 0x3EE26C0 Offset: 0x3EE27C1 VA: 0x3EE26C0
	public void set_highAngularXLimit(SoftJointLimit value) { }

	// RVA: 0x3EE2770 Offset: 0x3EE2871 VA: 0x3EE2770
	public SoftJointLimit get_angularYLimit() { }

	// RVA: 0x3EE2820 Offset: 0x3EE2921 VA: 0x3EE2820
	public void set_angularYLimit(SoftJointLimit value) { }

	// RVA: 0x3EE28D0 Offset: 0x3EE29D1 VA: 0x3EE28D0
	public SoftJointLimit get_angularZLimit() { }

	// RVA: 0x3EE2980 Offset: 0x3EE2A81 VA: 0x3EE2980
	public void set_angularZLimit(SoftJointLimit value) { }

	// RVA: 0x3EE2A30 Offset: 0x3EE2B31 VA: 0x3EE2A30
	public Vector3 get_targetPosition() { }

	// RVA: 0x3EE2AE0 Offset: 0x3EE2BE1 VA: 0x3EE2AE0
	public void set_targetPosition(Vector3 value) { }

	// RVA: 0x3EE2B90 Offset: 0x3EE2C91 VA: 0x3EE2B90
	public Vector3 get_targetVelocity() { }

	// RVA: 0x3EE2C40 Offset: 0x3EE2D41 VA: 0x3EE2C40
	public void set_targetVelocity(Vector3 value) { }

	// RVA: 0x3EE2CF0 Offset: 0x3EE2DF1 VA: 0x3EE2CF0
	public JointDrive get_xDrive() { }

	// RVA: 0x3EE2DA0 Offset: 0x3EE2EA1 VA: 0x3EE2DA0
	public void set_xDrive(JointDrive value) { }

	// RVA: 0x3EE2E50 Offset: 0x3EE2F51 VA: 0x3EE2E50
	public JointDrive get_yDrive() { }

	// RVA: 0x3EE2F00 Offset: 0x3EE3001 VA: 0x3EE2F00
	public void set_yDrive(JointDrive value) { }

	// RVA: 0x3EE2FB0 Offset: 0x3EE30B1 VA: 0x3EE2FB0
	public JointDrive get_zDrive() { }

	// RVA: 0x3EE3060 Offset: 0x3EE3161 VA: 0x3EE3060
	public void set_zDrive(JointDrive value) { }

	// RVA: 0x3EE3110 Offset: 0x3EE3211 VA: 0x3EE3110
	public Quaternion get_targetRotation() { }

	// RVA: 0x3EE31C0 Offset: 0x3EE32C1 VA: 0x3EE31C0
	public void set_targetRotation(Quaternion value) { }

	// RVA: 0x3EE3270 Offset: 0x3EE3371 VA: 0x3EE3270
	public Vector3 get_targetAngularVelocity() { }

	// RVA: 0x3EE3320 Offset: 0x3EE3421 VA: 0x3EE3320
	public void set_targetAngularVelocity(Vector3 value) { }

	// RVA: 0x3EE33D0 Offset: 0x3EE34D1 VA: 0x3EE33D0
	public RotationDriveMode get_rotationDriveMode() { }

	// RVA: 0x3EE3420 Offset: 0x3EE3521 VA: 0x3EE3420
	public void set_rotationDriveMode(RotationDriveMode value) { }

	// RVA: 0x3EE3470 Offset: 0x3EE3571 VA: 0x3EE3470
	public JointDrive get_angularXDrive() { }

	// RVA: 0x3EE3520 Offset: 0x3EE3621 VA: 0x3EE3520
	public void set_angularXDrive(JointDrive value) { }

	// RVA: 0x3EE35D0 Offset: 0x3EE36D1 VA: 0x3EE35D0
	public JointDrive get_angularYZDrive() { }

	// RVA: 0x3EE3680 Offset: 0x3EE3781 VA: 0x3EE3680
	public void set_angularYZDrive(JointDrive value) { }

	// RVA: 0x3EE3730 Offset: 0x3EE3831 VA: 0x3EE3730
	public JointDrive get_slerpDrive() { }

	// RVA: 0x3EE37E0 Offset: 0x3EE38E1 VA: 0x3EE37E0
	public void set_slerpDrive(JointDrive value) { }

	// RVA: 0x3EE3890 Offset: 0x3EE3991 VA: 0x3EE3890
	public JointProjectionMode get_projectionMode() { }

	// RVA: 0x3EE38E0 Offset: 0x3EE39E1 VA: 0x3EE38E0
	public void set_projectionMode(JointProjectionMode value) { }

	// RVA: 0x3EE3930 Offset: 0x3EE3A31 VA: 0x3EE3930
	public float get_projectionDistance() { }

	// RVA: 0x3EE3980 Offset: 0x3EE3A81 VA: 0x3EE3980
	public void set_projectionDistance(float value) { }

	// RVA: 0x3EE39D0 Offset: 0x3EE3AD1 VA: 0x3EE39D0
	public float get_projectionAngle() { }

	// RVA: 0x3EE3A20 Offset: 0x3EE3B21 VA: 0x3EE3A20
	public void set_projectionAngle(float value) { }

	// RVA: 0x3EE3A70 Offset: 0x3EE3B71 VA: 0x3EE3A70
	public bool get_configuredInWorldSpace() { }

	// RVA: 0x3EE3AC0 Offset: 0x3EE3BC1 VA: 0x3EE3AC0
	public void set_configuredInWorldSpace(bool value) { }

	// RVA: 0x3EE3B10 Offset: 0x3EE3C11 VA: 0x3EE3B10
	public bool get_swapBodies() { }

	// RVA: 0x3EE3B60 Offset: 0x3EE3C61 VA: 0x3EE3B60
	public void set_swapBodies(bool value) { }

	// RVA: 0x3EE3BB0 Offset: 0x3EE3CB1 VA: 0x3EE3BB0
	public void .ctor() { }

	// RVA: 0x3EE1A70 Offset: 0x3EE1B71 VA: 0x3EE1A70
	private void get_secondaryAxis_Injected(out Vector3 ret) { }

	// RVA: 0x3EE1B20 Offset: 0x3EE1C21 VA: 0x3EE1B20
	private void set_secondaryAxis_Injected(ref Vector3 value) { }

	// RVA: 0x3EE1F90 Offset: 0x3EE2091 VA: 0x3EE1F90
	private void get_linearLimitSpring_Injected(out SoftJointLimitSpring ret) { }

	// RVA: 0x3EE2040 Offset: 0x3EE2141 VA: 0x3EE2040
	private void set_linearLimitSpring_Injected(ref SoftJointLimitSpring value) { }

	// RVA: 0x3EE20F0 Offset: 0x3EE21F1 VA: 0x3EE20F0
	private void get_angularXLimitSpring_Injected(out SoftJointLimitSpring ret) { }

	// RVA: 0x3EE21A0 Offset: 0x3EE22A1 VA: 0x3EE21A0
	private void set_angularXLimitSpring_Injected(ref SoftJointLimitSpring value) { }

	// RVA: 0x3EE2250 Offset: 0x3EE2351 VA: 0x3EE2250
	private void get_angularYZLimitSpring_Injected(out SoftJointLimitSpring ret) { }

	// RVA: 0x3EE2300 Offset: 0x3EE2401 VA: 0x3EE2300
	private void set_angularYZLimitSpring_Injected(ref SoftJointLimitSpring value) { }

	// RVA: 0x3EE23B0 Offset: 0x3EE24B1 VA: 0x3EE23B0
	private void get_linearLimit_Injected(out SoftJointLimit ret) { }

	// RVA: 0x3EE2460 Offset: 0x3EE2561 VA: 0x3EE2460
	private void set_linearLimit_Injected(ref SoftJointLimit value) { }

	// RVA: 0x3EE2510 Offset: 0x3EE2611 VA: 0x3EE2510
	private void get_lowAngularXLimit_Injected(out SoftJointLimit ret) { }

	// RVA: 0x3EE25C0 Offset: 0x3EE26C1 VA: 0x3EE25C0
	private void set_lowAngularXLimit_Injected(ref SoftJointLimit value) { }

	// RVA: 0x3EE2670 Offset: 0x3EE2771 VA: 0x3EE2670
	private void get_highAngularXLimit_Injected(out SoftJointLimit ret) { }

	// RVA: 0x3EE2720 Offset: 0x3EE2821 VA: 0x3EE2720
	private void set_highAngularXLimit_Injected(ref SoftJointLimit value) { }

	// RVA: 0x3EE27D0 Offset: 0x3EE28D1 VA: 0x3EE27D0
	private void get_angularYLimit_Injected(out SoftJointLimit ret) { }

	// RVA: 0x3EE2880 Offset: 0x3EE2981 VA: 0x3EE2880
	private void set_angularYLimit_Injected(ref SoftJointLimit value) { }

	// RVA: 0x3EE2930 Offset: 0x3EE2A31 VA: 0x3EE2930
	private void get_angularZLimit_Injected(out SoftJointLimit ret) { }

	// RVA: 0x3EE29E0 Offset: 0x3EE2AE1 VA: 0x3EE29E0
	private void set_angularZLimit_Injected(ref SoftJointLimit value) { }

	// RVA: 0x3EE2A90 Offset: 0x3EE2B91 VA: 0x3EE2A90
	private void get_targetPosition_Injected(out Vector3 ret) { }

	// RVA: 0x3EE2B40 Offset: 0x3EE2C41 VA: 0x3EE2B40
	private void set_targetPosition_Injected(ref Vector3 value) { }

	// RVA: 0x3EE2BF0 Offset: 0x3EE2CF1 VA: 0x3EE2BF0
	private void get_targetVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x3EE2CA0 Offset: 0x3EE2DA1 VA: 0x3EE2CA0
	private void set_targetVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x3EE2D50 Offset: 0x3EE2E51 VA: 0x3EE2D50
	private void get_xDrive_Injected(out JointDrive ret) { }

	// RVA: 0x3EE2E00 Offset: 0x3EE2F01 VA: 0x3EE2E00
	private void set_xDrive_Injected(ref JointDrive value) { }

	// RVA: 0x3EE2EB0 Offset: 0x3EE2FB1 VA: 0x3EE2EB0
	private void get_yDrive_Injected(out JointDrive ret) { }

	// RVA: 0x3EE2F60 Offset: 0x3EE3061 VA: 0x3EE2F60
	private void set_yDrive_Injected(ref JointDrive value) { }

	// RVA: 0x3EE3010 Offset: 0x3EE3111 VA: 0x3EE3010
	private void get_zDrive_Injected(out JointDrive ret) { }

	// RVA: 0x3EE30C0 Offset: 0x3EE31C1 VA: 0x3EE30C0
	private void set_zDrive_Injected(ref JointDrive value) { }

	// RVA: 0x3EE3170 Offset: 0x3EE3271 VA: 0x3EE3170
	private void get_targetRotation_Injected(out Quaternion ret) { }

	// RVA: 0x3EE3220 Offset: 0x3EE3321 VA: 0x3EE3220
	private void set_targetRotation_Injected(ref Quaternion value) { }

	// RVA: 0x3EE32D0 Offset: 0x3EE33D1 VA: 0x3EE32D0
	private void get_targetAngularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x3EE3380 Offset: 0x3EE3481 VA: 0x3EE3380
	private void set_targetAngularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x3EE34D0 Offset: 0x3EE35D1 VA: 0x3EE34D0
	private void get_angularXDrive_Injected(out JointDrive ret) { }

	// RVA: 0x3EE3580 Offset: 0x3EE3681 VA: 0x3EE3580
	private void set_angularXDrive_Injected(ref JointDrive value) { }

	// RVA: 0x3EE3630 Offset: 0x3EE3731 VA: 0x3EE3630
	private void get_angularYZDrive_Injected(out JointDrive ret) { }

	// RVA: 0x3EE36E0 Offset: 0x3EE37E1 VA: 0x3EE36E0
	private void set_angularYZDrive_Injected(ref JointDrive value) { }

	// RVA: 0x3EE3790 Offset: 0x3EE3891 VA: 0x3EE3790
	private void get_slerpDrive_Injected(out JointDrive ret) { }

	// RVA: 0x3EE3840 Offset: 0x3EE3941 VA: 0x3EE3840
	private void set_slerpDrive_Injected(ref JointDrive value) { }
}

