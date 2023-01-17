// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273E40 Offset: 0x273F41 VA: 0x273E40
[DefaultMemberAttribute] // RVA: 0x273E40 Offset: 0x273F41 VA: 0x273E40
public sealed class CharacterJoint : MonoBehaviour // TypeDefIndex: 8615
{
	// Fields
	private Character _cp; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x282730 Offset: 0x282831 VA: 0x282730
	private bool <IsLateUpdate>k__BackingField; // 0x20
	private bool usePositionCache; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x282740 Offset: 0x282841 VA: 0x282740
	private Vector3 <c_trans_position>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x282750 Offset: 0x282851 VA: 0x282750
	private Vector3 <c_trans_ride_position>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x282760 Offset: 0x282861 VA: 0x282760
	private Vector3 <c_hip_jnt_position>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x282770 Offset: 0x282871 VA: 0x282770
	private Vector3 <c_head_loc_position>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x282780 Offset: 0x282881 VA: 0x282780
	private Vector3 <c_ride_loc_position>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x282790 Offset: 0x282891 VA: 0x282790
	private Vector3 <c_spine2_jnt_position>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x2827A0 Offset: 0x2828A1 VA: 0x2827A0
	private Vector3 <l_wpn1_loc_position>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x2827B0 Offset: 0x2828B1 VA: 0x2827B0
	private Vector3 <r_wpn1_loc_position>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x2827C0 Offset: 0x2828C1 VA: 0x2827C0
	private Vector3 <hand01_jnt_position>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x2827D0 Offset: 0x2828D1 VA: 0x2827D0
	private Vector3 <l_leg_loc_position>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x2827E0 Offset: 0x2828E1 VA: 0x2827E0
	private Vector3 <r_leg_loc_position>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x2827F0 Offset: 0x2828F1 VA: 0x2827F0
	private Vector3 <l_limbF_loc_position>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x282800 Offset: 0x282901 VA: 0x282800
	private Vector3 <l_limbR_loc_position>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x282810 Offset: 0x282911 VA: 0x282810
	private Vector3 <r_limbF_loc_position>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x282820 Offset: 0x282921 VA: 0x282820
	private Vector3 <r_limbR_loc_position>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x282830 Offset: 0x282931 VA: 0x282830
	private Vector3 <camLookAt_loc_position>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x282840 Offset: 0x282941 VA: 0x282840
	private Vector3 <camFollow_loc_position>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x282850 Offset: 0x282951 VA: 0x282850
	private Vector3 <lookAt_loc_position>k__BackingField; // 0xF0
	private Transform _c_trans; // 0x100
	private bool cached_c_trans; // 0x108
	private Transform _c_trans_ride; // 0x110
	private bool cached_c_trans_ride; // 0x118
	private Transform _c_hip_jnt; // 0x120
	private bool cached_c_hip_jnt; // 0x128
	private Transform _c_head_loc; // 0x130
	private bool cached_c_head_loc; // 0x138
	private Transform _c_ride_loc; // 0x140
	private bool cached_c_ride_loc; // 0x148
	private Transform _l_wpn1_loc; // 0x150
	private bool cached_l_wpn1_loc; // 0x158
	private Transform _r_wpn1_loc; // 0x160
	private bool cached_r_wpn1_loc; // 0x168
	private Transform _hand01_jnt; // 0x170
	private bool cached_hand01_jnt; // 0x178
	private Transform _l_leg_loc; // 0x180
	private bool cached_l_leg_loc; // 0x188
	private Transform _r_leg_loc; // 0x190
	private bool cached_r_leg_loc; // 0x198
	private Transform _l_limbF_loc; // 0x1A0
	private bool cached_l_limbF_loc; // 0x1A8
	private Transform _l_limbR_loc; // 0x1B0
	private bool cached_l_limbR_loc; // 0x1B8
	private Transform _r_limbF_loc; // 0x1C0
	private bool cached_r_limbF_loc; // 0x1C8
	private Transform _r_limbR_loc; // 0x1D0
	private bool cached_r_limbR_loc; // 0x1D8
	private Transform _camLookAt_loc; // 0x1E0
	private bool cached_camLookAt_loc; // 0x1E8
	private Transform _camFollow_loc; // 0x1F0
	private bool cached_camFollow_loc; // 0x1F8
	private Transform _lookAt_loc; // 0x200
	private bool cached_lookAt_loc; // 0x208
	private Transform _lookAt_ride_loc; // 0x210
	private bool cached_lookAt_ride_loc; // 0x218
	private Transform _c_neck_jnt; // 0x220
	private bool cached_c_neck_jnt; // 0x228
	private Transform _c_head_jnt; // 0x230
	private bool cached_c_head_jnt; // 0x238
	private Transform _c_spine1_jnt; // 0x240
	private bool cached_c_spine1_jnt; // 0x248
	private Transform _c_spine2_jnt; // 0x250
	private bool cached_c_spine2_jnt; // 0x258
	private Transform _l_cla_jnt; // 0x260
	private bool cached_l_cla_jnt; // 0x268
	private Transform _r_cla_jnt; // 0x270
	private bool cached_r_cla_jnt; // 0x278
	private Transform _l_arm1_jnt; // 0x280
	private bool cached_l_arm1_jnt; // 0x288
	private Transform _r_arm1_jnt; // 0x290
	private bool cached_r_arm1_jnt; // 0x298
	private Transform _l_arm3_jnt; // 0x2A0
	private bool cached_l_arm3_jnt; // 0x2A8
	private Transform _r_arm3_jnt; // 0x2B0
	private bool cached_r_arm3_jnt; // 0x2B8
	private Transform _l_leg1_jnt; // 0x2C0
	private bool cached_l_leg1_jnt; // 0x2C8
	private Transform _r_leg1_jnt; // 0x2D0
	private bool cached_r_leg1_jnt; // 0x2D8
	private Transform _l_leg3_jnt; // 0x2E0
	private bool cached_l_leg3_jnt; // 0x2E8
	private Transform _r_leg3_jnt; // 0x2F0
	private bool cached_r_leg3_jnt; // 0x2F8
	private Transform _l_shldrArmr_jnt; // 0x300
	private bool cached_l_shldrArmr_jnt; // 0x308
	private Transform _r_shldrArmr_jnt; // 0x310
	private bool cached_r_shldrArmr_jnt; // 0x318
	private Transform _l_arm1vol_jnt; // 0x320
	private bool cached_l_arm1vol_jnt; // 0x328
	private Transform _r_arm1vol_jnt; // 0x330
	private bool cached_r_arm1vol_jnt; // 0x338
	private Transform _l_arm2vol_jnt; // 0x340
	private bool cached_l_arm2vol_jnt; // 0x348
	private Transform _r_arm2vol_jnt; // 0x350
	private bool cached_r_arm2vol_jnt; // 0x358
	private Transform _l_leg1vol_jnt; // 0x360
	private bool cached_l_leg1vol_jnt; // 0x368
	private Transform _r_leg1vol_jnt; // 0x370
	private bool cached_r_leg1vol_jnt; // 0x378
	private Transform _l_leg2vol_jnt; // 0x380
	private bool cached_l_leg2vol_jnt; // 0x388
	private Transform _r_leg2vol_jnt; // 0x390
	private bool cached_r_leg2vol_jnt; // 0x398
	private Transform _l_bust_jnt; // 0x3A0
	private bool cached_l_bust_jnt; // 0x3A8
	private Transform _r_bust_jnt; // 0x3B0
	private bool cached_r_bust_jnt; // 0x3B8
	private Transform _c_spine1vol_jnt; // 0x3C0
	private bool cached_c_spine1vol_jnt; // 0x3C8
	private Transform _c_spine2vol_jnt; // 0x3D0
	private bool cached_c_spine2vol_jnt; // 0x3D8

	// Properties
	public Character CP { get; }
	public Transform Item { get; }
	public bool IsLateUpdate { get; set; }
	public bool IsAvailable { get; }
	public Vector3 c_trans_position { get; set; }
	public Vector3 c_trans_ride_position { get; set; }
	public Vector3 c_hip_jnt_position { get; set; }
	public Vector3 c_head_loc_position { get; set; }
	public Vector3 c_ride_loc_position { get; set; }
	public Vector3 c_spine2_jnt_position { get; set; }
	public Vector3 l_wpn1_loc_position { get; set; }
	public Vector3 r_wpn1_loc_position { get; set; }
	public Vector3 hand01_jnt_position { get; set; }
	public Vector3 l_leg_loc_position { get; set; }
	public Vector3 r_leg_loc_position { get; set; }
	public Vector3 l_limbF_loc_position { get; set; }
	public Vector3 l_limbR_loc_position { get; set; }
	public Vector3 r_limbF_loc_position { get; set; }
	public Vector3 r_limbR_loc_position { get; set; }
	public Vector3 camLookAt_loc_position { get; set; }
	public Vector3 camFollow_loc_position { get; set; }
	public Vector3 lookAt_loc_position { get; set; }
	public Transform c_trans { get; }
	public Transform c_trans_ride { get; }
	public Transform c_hip_jnt { get; }
	public Transform c_head_loc { get; }
	public Transform c_ride_loc { get; }
	public Transform l_wpn1_loc { get; }
	public Transform r_wpn1_loc { get; }
	public Transform hand01_jnt { get; }
	public Transform l_leg_loc { get; }
	public Transform r_leg_loc { get; }
	public Transform l_limbF_loc { get; }
	public Transform l_limbR_loc { get; }
	public Transform r_limbF_loc { get; }
	public Transform r_limbR_loc { get; }
	public Transform camLookAt_loc { get; }
	public Transform camFollow_loc { get; }
	public Transform lookAt_loc { get; }
	public Transform lookAt_ride_loc { get; }
	public Transform c_neck_jnt { get; }
	public Transform c_head_jnt { get; }
	public Transform c_spine1_jnt { get; }
	public Transform c_spine2_jnt { get; }
	public Transform l_cla_jnt { get; }
	public Transform r_cla_jnt { get; }
	public Transform l_arm1_jnt { get; }
	public Transform r_arm1_jnt { get; }
	public Transform l_arm3_jnt { get; }
	public Transform r_arm3_jnt { get; }
	public Transform l_leg1_jnt { get; }
	public Transform r_leg1_jnt { get; }
	public Transform l_leg3_jnt { get; }
	public Transform r_leg3_jnt { get; }
	public Transform l_shldrArmr_jnt { get; }
	public Transform r_shldrArmr_jnt { get; }
	public Transform l_arm1vol_jnt { get; }
	public Transform r_arm1vol_jnt { get; }
	public Transform l_arm2vol_jnt { get; }
	public Transform r_arm2vol_jnt { get; }
	public Transform l_leg1vol_jnt { get; }
	public Transform r_leg1vol_jnt { get; }
	public Transform l_leg2vol_jnt { get; }
	public Transform r_leg2vol_jnt { get; }
	public Transform l_bust_jnt { get; }
	public Transform r_bust_jnt { get; }
	public Transform c_spine1vol_jnt { get; }
	public Transform c_spine2vol_jnt { get; }

	// Methods

	// RVA: 0x2B7D6D0 Offset: 0x2B7D7D1 VA: 0x2B7D6D0
	public Character get_CP() { }

	// RVA: 0x2B713D0 Offset: 0x2B714D1 VA: 0x2B713D0
	public Transform get_Item(string name) { }

	// RVA: 0x2B72250 Offset: 0x2B72351 VA: 0x2B72250
	public TR GetTR_AtoB(string s) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AACA0 Offset: 0x2AADA1 VA: 0x2AACA0
	// RVA: 0x2B7D930 Offset: 0x2B7DA31 VA: 0x2B7D930
	public bool get_IsLateUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AACB0 Offset: 0x2AADB1 VA: 0x2AACB0
	// RVA: 0x2B7D940 Offset: 0x2B7DA41 VA: 0x2B7D940
	private void set_IsLateUpdate(bool value) { }

	// RVA: 0x2B7D950 Offset: 0x2B7DA51 VA: 0x2B7D950
	public bool get_IsAvailable() { }

	// RVA: 0x2B6F220 Offset: 0x2B6F321 VA: 0x2B6F220
	public void RunScheduler() { }

	// RVA: 0x2B7D9E0 Offset: 0x2B7DAE1 VA: 0x2B7D9E0
	private void Update() { }

	// RVA: 0x2B7E110 Offset: 0x2B7E211 VA: 0x2B7E110
	private void LateUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AACC0 Offset: 0x2AADC1 VA: 0x2AACC0
	// RVA: 0x2B7E130 Offset: 0x2B7E231 VA: 0x2B7E130
	public Vector3 get_c_trans_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AACD0 Offset: 0x2AADD1 VA: 0x2AACD0
	// RVA: 0x2B7E140 Offset: 0x2B7E241 VA: 0x2B7E140
	private void set_c_trans_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AACE0 Offset: 0x2AADE1 VA: 0x2AACE0
	// RVA: 0x2B7E150 Offset: 0x2B7E251 VA: 0x2B7E150
	public Vector3 get_c_trans_ride_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AACF0 Offset: 0x2AADF1 VA: 0x2AACF0
	// RVA: 0x2B7E160 Offset: 0x2B7E261 VA: 0x2B7E160
	private void set_c_trans_ride_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD00 Offset: 0x2AAE01 VA: 0x2AAD00
	// RVA: 0x2B7E170 Offset: 0x2B7E271 VA: 0x2B7E170
	public Vector3 get_c_hip_jnt_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD10 Offset: 0x2AAE11 VA: 0x2AAD10
	// RVA: 0x2B7E180 Offset: 0x2B7E281 VA: 0x2B7E180
	private void set_c_hip_jnt_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD20 Offset: 0x2AAE21 VA: 0x2AAD20
	// RVA: 0x2B7E190 Offset: 0x2B7E291 VA: 0x2B7E190
	public Vector3 get_c_head_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD30 Offset: 0x2AAE31 VA: 0x2AAD30
	// RVA: 0x2B7E1A0 Offset: 0x2B7E2A1 VA: 0x2B7E1A0
	private void set_c_head_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD40 Offset: 0x2AAE41 VA: 0x2AAD40
	// RVA: 0x2B7E1B0 Offset: 0x2B7E2B1 VA: 0x2B7E1B0
	public Vector3 get_c_ride_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD50 Offset: 0x2AAE51 VA: 0x2AAD50
	// RVA: 0x2B7E1C0 Offset: 0x2B7E2C1 VA: 0x2B7E1C0
	private void set_c_ride_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD60 Offset: 0x2AAE61 VA: 0x2AAD60
	// RVA: 0x2B7E1D0 Offset: 0x2B7E2D1 VA: 0x2B7E1D0
	public Vector3 get_c_spine2_jnt_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD70 Offset: 0x2AAE71 VA: 0x2AAD70
	// RVA: 0x2B7E1E0 Offset: 0x2B7E2E1 VA: 0x2B7E1E0
	private void set_c_spine2_jnt_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD80 Offset: 0x2AAE81 VA: 0x2AAD80
	// RVA: 0x2B7E1F0 Offset: 0x2B7E2F1 VA: 0x2B7E1F0
	public Vector3 get_l_wpn1_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAD90 Offset: 0x2AAE91 VA: 0x2AAD90
	// RVA: 0x2B7E200 Offset: 0x2B7E301 VA: 0x2B7E200
	private void set_l_wpn1_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AADA0 Offset: 0x2AAEA1 VA: 0x2AADA0
	// RVA: 0x2B7E210 Offset: 0x2B7E311 VA: 0x2B7E210
	public Vector3 get_r_wpn1_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AADB0 Offset: 0x2AAEB1 VA: 0x2AADB0
	// RVA: 0x2B7E220 Offset: 0x2B7E321 VA: 0x2B7E220
	private void set_r_wpn1_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AADC0 Offset: 0x2AAEC1 VA: 0x2AADC0
	// RVA: 0x2B7E230 Offset: 0x2B7E331 VA: 0x2B7E230
	public Vector3 get_hand01_jnt_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AADD0 Offset: 0x2AAED1 VA: 0x2AADD0
	// RVA: 0x2B7E240 Offset: 0x2B7E341 VA: 0x2B7E240
	private void set_hand01_jnt_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AADE0 Offset: 0x2AAEE1 VA: 0x2AADE0
	// RVA: 0x2B7E250 Offset: 0x2B7E351 VA: 0x2B7E250
	public Vector3 get_l_leg_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AADF0 Offset: 0x2AAEF1 VA: 0x2AADF0
	// RVA: 0x2B7E260 Offset: 0x2B7E361 VA: 0x2B7E260
	private void set_l_leg_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE00 Offset: 0x2AAF01 VA: 0x2AAE00
	// RVA: 0x2B7E270 Offset: 0x2B7E371 VA: 0x2B7E270
	public Vector3 get_r_leg_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE10 Offset: 0x2AAF11 VA: 0x2AAE10
	// RVA: 0x2B7E280 Offset: 0x2B7E381 VA: 0x2B7E280
	private void set_r_leg_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE20 Offset: 0x2AAF21 VA: 0x2AAE20
	// RVA: 0x2B7E290 Offset: 0x2B7E391 VA: 0x2B7E290
	public Vector3 get_l_limbF_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE30 Offset: 0x2AAF31 VA: 0x2AAE30
	// RVA: 0x2B7E2A0 Offset: 0x2B7E3A1 VA: 0x2B7E2A0
	private void set_l_limbF_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE40 Offset: 0x2AAF41 VA: 0x2AAE40
	// RVA: 0x2B7E2B0 Offset: 0x2B7E3B1 VA: 0x2B7E2B0
	public Vector3 get_l_limbR_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE50 Offset: 0x2AAF51 VA: 0x2AAE50
	// RVA: 0x2B7E2C0 Offset: 0x2B7E3C1 VA: 0x2B7E2C0
	private void set_l_limbR_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE60 Offset: 0x2AAF61 VA: 0x2AAE60
	// RVA: 0x2B7E2D0 Offset: 0x2B7E3D1 VA: 0x2B7E2D0
	public Vector3 get_r_limbF_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE70 Offset: 0x2AAF71 VA: 0x2AAE70
	// RVA: 0x2B7E2E0 Offset: 0x2B7E3E1 VA: 0x2B7E2E0
	private void set_r_limbF_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE80 Offset: 0x2AAF81 VA: 0x2AAE80
	// RVA: 0x2B7E2F0 Offset: 0x2B7E3F1 VA: 0x2B7E2F0
	public Vector3 get_r_limbR_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAE90 Offset: 0x2AAF91 VA: 0x2AAE90
	// RVA: 0x2B7E300 Offset: 0x2B7E401 VA: 0x2B7E300
	private void set_r_limbR_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAEA0 Offset: 0x2AAFA1 VA: 0x2AAEA0
	// RVA: 0x2B7E310 Offset: 0x2B7E411 VA: 0x2B7E310
	public Vector3 get_camLookAt_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAEB0 Offset: 0x2AAFB1 VA: 0x2AAEB0
	// RVA: 0x2B7E320 Offset: 0x2B7E421 VA: 0x2B7E320
	private void set_camLookAt_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAEC0 Offset: 0x2AAFC1 VA: 0x2AAEC0
	// RVA: 0x2B7E330 Offset: 0x2B7E431 VA: 0x2B7E330
	public Vector3 get_camFollow_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAED0 Offset: 0x2AAFD1 VA: 0x2AAED0
	// RVA: 0x2B7E340 Offset: 0x2B7E441 VA: 0x2B7E340
	private void set_camFollow_loc_position(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAEE0 Offset: 0x2AAFE1 VA: 0x2AAEE0
	// RVA: 0x2B7E350 Offset: 0x2B7E451 VA: 0x2B7E350
	public Vector3 get_lookAt_loc_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAEF0 Offset: 0x2AAFF1 VA: 0x2AAEF0
	// RVA: 0x2B7E360 Offset: 0x2B7E461 VA: 0x2B7E360
	private void set_lookAt_loc_position(Vector3 value) { }

	// RVA: 0x2B7DA00 Offset: 0x2B7DB01 VA: 0x2B7DA00
	private void UpdatePositionCache() { }

	// RVA: 0x2B7D790 Offset: 0x2B7D891 VA: 0x2B7D790
	public Transform get_c_trans() { }

	// RVA: 0x2B7D860 Offset: 0x2B7D961 VA: 0x2B7D860
	public Transform get_c_trans_ride() { }

	// RVA: 0x2B6AE00 Offset: 0x2B6AF01 VA: 0x2B6AE00
	public Transform get_c_hip_jnt() { }

	// RVA: 0x2B73FA0 Offset: 0x2B740A1 VA: 0x2B73FA0
	public Transform get_c_head_loc() { }

	// RVA: 0x2B6AED0 Offset: 0x2B6AFD1 VA: 0x2B6AED0
	public Transform get_c_ride_loc() { }

	// RVA: 0x2B7E440 Offset: 0x2B7E541 VA: 0x2B7E440
	public Transform get_l_wpn1_loc() { }

	// RVA: 0x2B7E510 Offset: 0x2B7E611 VA: 0x2B7E510
	public Transform get_r_wpn1_loc() { }

	// RVA: 0x2B7E5E0 Offset: 0x2B7E6E1 VA: 0x2B7E5E0
	public Transform get_hand01_jnt() { }

	// RVA: 0x2B7E6B0 Offset: 0x2B7E7B1 VA: 0x2B7E6B0
	public Transform get_l_leg_loc() { }

	// RVA: 0x2B7E780 Offset: 0x2B7E881 VA: 0x2B7E780
	public Transform get_r_leg_loc() { }

	// RVA: 0x2B7E850 Offset: 0x2B7E951 VA: 0x2B7E850
	public Transform get_l_limbF_loc() { }

	// RVA: 0x2B7E920 Offset: 0x2B7EA21 VA: 0x2B7E920
	public Transform get_l_limbR_loc() { }

	// RVA: 0x2B7E9F0 Offset: 0x2B7EAF1 VA: 0x2B7E9F0
	public Transform get_r_limbF_loc() { }

	// RVA: 0x2B7EAC0 Offset: 0x2B7EBC1 VA: 0x2B7EAC0
	public Transform get_r_limbR_loc() { }

	// RVA: 0x2B7EB90 Offset: 0x2B7EC91 VA: 0x2B7EB90
	public Transform get_camLookAt_loc() { }

	// RVA: 0x2B7EC60 Offset: 0x2B7ED61 VA: 0x2B7EC60
	public Transform get_camFollow_loc() { }

	// RVA: 0x2B7ED30 Offset: 0x2B7EE31 VA: 0x2B7ED30
	public Transform get_lookAt_loc() { }

	// RVA: 0x2B7EE00 Offset: 0x2B7EF01 VA: 0x2B7EE00
	public Transform get_lookAt_ride_loc() { }

	// RVA: 0x2B7EED0 Offset: 0x2B7EFD1 VA: 0x2B7EED0
	public Transform get_c_neck_jnt() { }

	// RVA: 0x2B7EFA0 Offset: 0x2B7F0A1 VA: 0x2B7EFA0
	public Transform get_c_head_jnt() { }

	// RVA: 0x2B7F070 Offset: 0x2B7F171 VA: 0x2B7F070
	public Transform get_c_spine1_jnt() { }

	// RVA: 0x2B7E370 Offset: 0x2B7E471 VA: 0x2B7E370
	public Transform get_c_spine2_jnt() { }

	// RVA: 0x2B79E90 Offset: 0x2B79F91 VA: 0x2B79E90
	public Transform get_l_cla_jnt() { }

	// RVA: 0x2B7F140 Offset: 0x2B7F241 VA: 0x2B7F140
	public Transform get_r_cla_jnt() { }

	// RVA: 0x2B7F210 Offset: 0x2B7F311 VA: 0x2B7F210
	public Transform get_l_arm1_jnt() { }

	// RVA: 0x2B7F2E0 Offset: 0x2B7F3E1 VA: 0x2B7F2E0
	public Transform get_r_arm1_jnt() { }

	// RVA: 0x2B7F3B0 Offset: 0x2B7F4B1 VA: 0x2B7F3B0
	public Transform get_l_arm3_jnt() { }

	// RVA: 0x2B7F480 Offset: 0x2B7F581 VA: 0x2B7F480
	public Transform get_r_arm3_jnt() { }

	// RVA: 0x2B7F550 Offset: 0x2B7F651 VA: 0x2B7F550
	public Transform get_l_leg1_jnt() { }

	// RVA: 0x2B7F620 Offset: 0x2B7F721 VA: 0x2B7F620
	public Transform get_r_leg1_jnt() { }

	// RVA: 0x2B7F6F0 Offset: 0x2B7F7F1 VA: 0x2B7F6F0
	public Transform get_l_leg3_jnt() { }

	// RVA: 0x2B7F7C0 Offset: 0x2B7F8C1 VA: 0x2B7F7C0
	public Transform get_r_leg3_jnt() { }

	// RVA: 0x2B7F890 Offset: 0x2B7F991 VA: 0x2B7F890
	public Transform get_l_shldrArmr_jnt() { }

	// RVA: 0x2B7F960 Offset: 0x2B7FA61 VA: 0x2B7F960
	public Transform get_r_shldrArmr_jnt() { }

	// RVA: 0x2B7FA30 Offset: 0x2B7FB31 VA: 0x2B7FA30
	public Transform get_l_arm1vol_jnt() { }

	// RVA: 0x2B7FB00 Offset: 0x2B7FC01 VA: 0x2B7FB00
	public Transform get_r_arm1vol_jnt() { }

	// RVA: 0x2B7FBD0 Offset: 0x2B7FCD1 VA: 0x2B7FBD0
	public Transform get_l_arm2vol_jnt() { }

	// RVA: 0x2B7FCA0 Offset: 0x2B7FDA1 VA: 0x2B7FCA0
	public Transform get_r_arm2vol_jnt() { }

	// RVA: 0x2B7FD70 Offset: 0x2B7FE71 VA: 0x2B7FD70
	public Transform get_l_leg1vol_jnt() { }

	// RVA: 0x2B7FE40 Offset: 0x2B7FF41 VA: 0x2B7FE40
	public Transform get_r_leg1vol_jnt() { }

	// RVA: 0x2B7FF10 Offset: 0x2B80011 VA: 0x2B7FF10
	public Transform get_l_leg2vol_jnt() { }

	// RVA: 0x2B7FFE0 Offset: 0x2B800E1 VA: 0x2B7FFE0
	public Transform get_r_leg2vol_jnt() { }

	// RVA: 0x2B800B0 Offset: 0x2B801B1 VA: 0x2B800B0
	public Transform get_l_bust_jnt() { }

	// RVA: 0x2B80180 Offset: 0x2B80281 VA: 0x2B80180
	public Transform get_r_bust_jnt() { }

	// RVA: 0x2B80250 Offset: 0x2B80351 VA: 0x2B80250
	public Transform get_c_spine1vol_jnt() { }

	// RVA: 0x2B80320 Offset: 0x2B80421 VA: 0x2B80320
	public Transform get_c_spine2vol_jnt() { }

	// RVA: 0x2B6DF00 Offset: 0x2B6E001 VA: 0x2B6DF00
	public void ImportCacheFromHierarchyCache(HierarchyCache hc) { }

	// RVA: 0x2B803F0 Offset: 0x2B804F1 VA: 0x2B803F0
	public void Flush() { }

	// RVA: 0x2B807B0 Offset: 0x2B808B1 VA: 0x2B807B0
	public void .ctor() { }
}

