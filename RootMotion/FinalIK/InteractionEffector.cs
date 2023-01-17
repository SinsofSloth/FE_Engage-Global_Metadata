// Namespace: RootMotion.FinalIK
[Serializable]
public class InteractionEffector // TypeDefIndex: 14405
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2A2780 Offset: 0x2A2881 VA: 0x2A2780
	private FullBodyBipedEffector <effectorType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2A2790 Offset: 0x2A2891 VA: 0x2A2790
	private bool <isPaused>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x2A27A0 Offset: 0x2A28A1 VA: 0x2A27A0
	private InteractionObject <interactionObject>k__BackingField; // 0x18
	private Poser poser; // 0x20
	private IKEffector effector; // 0x28
	private float timer; // 0x30
	private float length; // 0x34
	private float weight; // 0x38
	private float fadeInSpeed; // 0x3C
	private float defaultPositionWeight; // 0x40
	private float defaultRotationWeight; // 0x44
	private float defaultPull; // 0x48
	private float defaultReach; // 0x4C
	private float defaultPush; // 0x50
	private float defaultPushParent; // 0x54
	private float defaultBendGoalWeight; // 0x58
	private float resetTimer; // 0x5C
	private bool positionWeightUsed; // 0x60
	private bool rotationWeightUsed; // 0x61
	private bool pullUsed; // 0x62
	private bool reachUsed; // 0x63
	private bool pushUsed; // 0x64
	private bool pushParentUsed; // 0x65
	private bool bendGoalWeightUsed; // 0x66
	private bool pickedUp; // 0x67
	private bool defaults; // 0x68
	private bool pickUpOnPostFBBIK; // 0x69
	private Vector3 pickUpPosition; // 0x6C
	private Vector3 pausePositionRelative; // 0x78
	private Quaternion pickUpRotation; // 0x84
	private Quaternion pauseRotationRelative; // 0x94
	private InteractionTarget interactionTarget; // 0xA8
	private Transform target; // 0xB0
	private List<bool> triggered; // 0xB8
	private InteractionSystem interactionSystem; // 0xC0
	private bool started; // 0xC8

	// Properties
	public FullBodyBipedEffector effectorType { get; set; }
	public bool isPaused { get; set; }
	public InteractionObject interactionObject { get; set; }
	public bool inInteraction { get; }
	public float progress { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CFBA0 Offset: 0x2CFCA1 VA: 0x2CFBA0
	// RVA: 0x2C4F720 Offset: 0x2C4F821 VA: 0x2C4F720
	public FullBodyBipedEffector get_effectorType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFBB0 Offset: 0x2CFCB1 VA: 0x2CFBB0
	// RVA: 0x2C4F730 Offset: 0x2C4F831 VA: 0x2C4F730
	private void set_effectorType(FullBodyBipedEffector value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFBC0 Offset: 0x2CFCC1 VA: 0x2CFBC0
	// RVA: 0x2C4F740 Offset: 0x2C4F841 VA: 0x2C4F740
	public bool get_isPaused() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFBD0 Offset: 0x2CFCD1 VA: 0x2CFBD0
	// RVA: 0x2C4F750 Offset: 0x2C4F851 VA: 0x2C4F750
	private void set_isPaused(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFBE0 Offset: 0x2CFCE1 VA: 0x2CFBE0
	// RVA: 0x2C4F760 Offset: 0x2C4F861 VA: 0x2C4F760
	public InteractionObject get_interactionObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CFBF0 Offset: 0x2CFCF1 VA: 0x2CFBF0
	// RVA: 0x2C4F770 Offset: 0x2C4F871 VA: 0x2C4F770
	private void set_interactionObject(InteractionObject value) { }

	// RVA: 0x2C4F780 Offset: 0x2C4F881 VA: 0x2C4F780
	public bool get_inInteraction() { }

	// RVA: 0x2C4F800 Offset: 0x2C4F901 VA: 0x2C4F800
	public void .ctor(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C4F8A0 Offset: 0x2C4F9A1 VA: 0x2C4F8A0
	public void Initiate(InteractionSystem interactionSystem) { }

	// RVA: 0x2C4F950 Offset: 0x2C4FA51 VA: 0x2C4F950
	private void StoreDefaults() { }

	// RVA: 0x2C4FA50 Offset: 0x2C4FB51 VA: 0x2C4FA50
	public bool ResetToDefaults(float speed) { }

	// RVA: 0x2C4FD50 Offset: 0x2C4FE51 VA: 0x2C4FD50
	public bool Pause() { }

	// RVA: 0x2C4FE50 Offset: 0x2C4FF51 VA: 0x2C4FE50
	public bool Resume() { }

	// RVA: 0x2C4FF10 Offset: 0x2C50011 VA: 0x2C4FF10
	public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt) { }

	// RVA: 0x2C50870 Offset: 0x2C50971 VA: 0x2C50870
	public void Update(Transform root, float speed) { }

	// RVA: 0x2C51C80 Offset: 0x2C51D81 VA: 0x2C51C80
	public float get_progress() { }

	// RVA: 0x2C51330 Offset: 0x2C51431 VA: 0x2C51330
	private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause) { }

	// RVA: 0x2C51530 Offset: 0x2C51631 VA: 0x2C51530
	private void PickUp(Transform root) { }

	// RVA: 0x2C51AC0 Offset: 0x2C51BC1 VA: 0x2C51AC0
	public bool Stop() { }

	// RVA: 0x2C51DD0 Offset: 0x2C51ED1 VA: 0x2C51DD0
	public void OnPostFBBIK() { }
}

