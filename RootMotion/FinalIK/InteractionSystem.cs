// Namespace: RootMotion.FinalIK
[AddComponentMenu] // RVA: 0x279FA0 Offset: 0x27A0A1 VA: 0x279FA0
[HelpURLAttribute] // RVA: 0x279FA0 Offset: 0x27A0A1 VA: 0x279FA0
public class InteractionSystem : MonoBehaviour // TypeDefIndex: 14416
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A2E20 Offset: 0x2A2F21 VA: 0x2A2E20
	public string targetTag; // 0x18
	[TooltipAttribute] // RVA: 0x2A2E60 Offset: 0x2A2F61 VA: 0x2A2E60
	public float fadeInTime; // 0x20
	[TooltipAttribute] // RVA: 0x2A2EA0 Offset: 0x2A2FA1 VA: 0x2A2EA0
	public float speed; // 0x24
	[TooltipAttribute] // RVA: 0x2A2EE0 Offset: 0x2A2FE1 VA: 0x2A2EE0
	public float resetToDefaultsSpeed; // 0x28
	[TooltipAttribute] // RVA: 0x2A2F20 Offset: 0x2A3021 VA: 0x2A2F20
	[FormerlySerializedAsAttribute] // RVA: 0x2A2F20 Offset: 0x2A3021 VA: 0x2A2F20
	[HeaderAttribute] // RVA: 0x2A2F20 Offset: 0x2A3021 VA: 0x2A2F20
	public Collider characterCollider; // 0x30
	[TooltipAttribute] // RVA: 0x2A2FB0 Offset: 0x2A30B1 VA: 0x2A2FB0
	[FormerlySerializedAsAttribute] // RVA: 0x2A2FB0 Offset: 0x2A30B1 VA: 0x2A2FB0
	public Transform FPSCamera; // 0x38
	[TooltipAttribute] // RVA: 0x2A3010 Offset: 0x2A3111 VA: 0x2A3010
	public LayerMask camRaycastLayers; // 0x40
	[TooltipAttribute] // RVA: 0x2A3050 Offset: 0x2A3151 VA: 0x2A3050
	public float camRaycastDistance; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x2A3090 Offset: 0x2A3191 VA: 0x2A3090
	private List<InteractionTrigger> <triggersInRange>k__BackingField; // 0x48
	private List<InteractionTrigger> inContact; // 0x50
	private List<int> bestRangeIndexes; // 0x58
	public InteractionSystem.InteractionDelegate OnInteractionStart; // 0x60
	public InteractionSystem.InteractionDelegate OnInteractionPause; // 0x68
	public InteractionSystem.InteractionDelegate OnInteractionPickUp; // 0x70
	public InteractionSystem.InteractionDelegate OnInteractionResume; // 0x78
	public InteractionSystem.InteractionDelegate OnInteractionStop; // 0x80
	public InteractionSystem.InteractionEventDelegate OnInteractionEvent; // 0x88
	public RaycastHit raycastHit; // 0x90
	[SerializeField] // RVA: 0x2A30A0 Offset: 0x2A31A1 VA: 0x2A30A0
	[SpaceAttribute] // RVA: 0x2A30A0 Offset: 0x2A31A1 VA: 0x2A30A0
	[TooltipAttribute] // RVA: 0x2A30A0 Offset: 0x2A31A1 VA: 0x2A30A0
	private FullBodyBipedIK fullBody; // 0xC0
	[TooltipAttribute] // RVA: 0x2A3100 Offset: 0x2A3201 VA: 0x2A3100
	public InteractionLookAt lookAt; // 0xC8
	private InteractionEffector[] interactionEffectors; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x2A3140 Offset: 0x2A3241 VA: 0x2A3140
	private bool <initiated>k__BackingField; // 0xD8
	private Collider lastCollider; // 0xE0
	private Collider c; // 0xE8

	// Properties
	public bool inInteraction { get; }
	public FullBodyBipedIK ik { get; set; }
	public List<InteractionTrigger> triggersInRange { get; set; }
	public bool initiated { get; set; }

	// Methods

	[ContextMenu] // RVA: 0x2CFE40 Offset: 0x2CFF41 VA: 0x2CFE40
	// RVA: 0x2C532D0 Offset: 0x2C533D1 VA: 0x2C532D0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CFE80 Offset: 0x2CFF81 VA: 0x2CFE80
	// RVA: 0x2C53320 Offset: 0x2C53421 VA: 0x2C53320
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2CFEC0 Offset: 0x2CFFC1 VA: 0x2CFEC0
	// RVA: 0x2C53370 Offset: 0x2C53471 VA: 0x2C53370
	private void OpenTutorial1() { }

	[ContextMenu] // RVA: 0x2CFF00 Offset: 0x2D0001 VA: 0x2CFF00
	// RVA: 0x2C533C0 Offset: 0x2C534C1 VA: 0x2C533C0
	private void OpenTutorial2() { }

	[ContextMenu] // RVA: 0x2CFF40 Offset: 0x2D0041 VA: 0x2CFF40
	// RVA: 0x2C53410 Offset: 0x2C53511 VA: 0x2C53410
	private void OpenTutorial3() { }

	[ContextMenu] // RVA: 0x2CFF80 Offset: 0x2D0081 VA: 0x2CFF80
	// RVA: 0x2C53460 Offset: 0x2C53561 VA: 0x2C53460
	private void OpenTutorial4() { }

	[ContextMenu] // RVA: 0x2CFFC0 Offset: 0x2D00C1 VA: 0x2CFFC0
	// RVA: 0x2C534B0 Offset: 0x2C535B1 VA: 0x2C534B0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2D0000 Offset: 0x2D0101 VA: 0x2D0000
	// RVA: 0x2C53500 Offset: 0x2C53601 VA: 0x2C53500
	private void ASThread() { }

	// RVA: 0x2C53550 Offset: 0x2C53651 VA: 0x2C53550
	public bool get_inInteraction() { }

	// RVA: 0x2C53760 Offset: 0x2C53861 VA: 0x2C53760
	public bool IsInInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C53870 Offset: 0x2C53971 VA: 0x2C53870
	public bool IsPaused(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C53980 Offset: 0x2C53A81 VA: 0x2C53980
	public bool IsPaused() { }

	// RVA: 0x2C53A90 Offset: 0x2C53B91 VA: 0x2C53A90
	public bool IsInSync() { }

	// RVA: 0x2C53BE0 Offset: 0x2C53CE1 VA: 0x2C53BE0
	public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) { }

	// RVA: 0x2C53CF0 Offset: 0x2C53DF1 VA: 0x2C53CF0
	public bool PauseInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C53D80 Offset: 0x2C53E81 VA: 0x2C53D80
	public bool ResumeInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C53E90 Offset: 0x2C53F91 VA: 0x2C53E90
	public bool StopInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C53F20 Offset: 0x2C54021 VA: 0x2C53F20
	public void PauseAll() { }

	// RVA: 0x2C53FA0 Offset: 0x2C540A1 VA: 0x2C53FA0
	public void ResumeAll() { }

	// RVA: 0x2C540B0 Offset: 0x2C541B1 VA: 0x2C540B0
	public void StopAll() { }

	// RVA: 0x2C54120 Offset: 0x2C54221 VA: 0x2C54120
	public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C541B0 Offset: 0x2C542B1 VA: 0x2C541B0
	public float GetProgress(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2C542B0 Offset: 0x2C543B1 VA: 0x2C542B0
	public float GetMinActiveProgress() { }

	// RVA: 0x2C54440 Offset: 0x2C54541 VA: 0x2C54440
	public bool TriggerInteraction(int index, bool interrupt) { }

	// RVA: 0x2C54700 Offset: 0x2C54801 VA: 0x2C54700
	public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject) { }

	// RVA: 0x2C548E0 Offset: 0x2C549E1 VA: 0x2C548E0
	public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget) { }

	// RVA: 0x2C54B60 Offset: 0x2C54C61 VA: 0x2C54B60
	public InteractionTrigger.Range GetClosestInteractionRange() { }

	// RVA: 0x2C54E20 Offset: 0x2C54F21 VA: 0x2C54E20
	public InteractionObject GetClosestInteractionObjectInRange() { }

	// RVA: 0x2C54E60 Offset: 0x2C54F61 VA: 0x2C54E60
	public InteractionTarget GetClosestInteractionTargetInRange() { }

	// RVA: 0x2C54ED0 Offset: 0x2C54FD1 VA: 0x2C54ED0
	public InteractionObject[] GetClosestInteractionObjectsInRange() { }

	// RVA: 0x2C55010 Offset: 0x2C55111 VA: 0x2C55010
	public InteractionTarget[] GetClosestInteractionTargetsInRange() { }

	// RVA: 0x2C551C0 Offset: 0x2C552C1 VA: 0x2C551C0
	public bool TriggerEffectorsReady(int index) { }

	// RVA: 0x2C55440 Offset: 0x2C55541 VA: 0x2C55440
	public InteractionTrigger.Range GetTriggerRange(int index) { }

	// RVA: 0x2C54C70 Offset: 0x2C54D71 VA: 0x2C54C70
	public int GetClosestTriggerIndex() { }

	// RVA: 0x2C55580 Offset: 0x2C55681 VA: 0x2C55580
	public FullBodyBipedIK get_ik() { }

	// RVA: 0x2C55590 Offset: 0x2C55691 VA: 0x2C55590
	public void set_ik(FullBodyBipedIK value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0040 Offset: 0x2D0141 VA: 0x2D0040
	// RVA: 0x2C555A0 Offset: 0x2C556A1 VA: 0x2C555A0
	public List<InteractionTrigger> get_triggersInRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0050 Offset: 0x2D0151 VA: 0x2D0050
	// RVA: 0x2C555B0 Offset: 0x2C556B1 VA: 0x2C555B0
	private void set_triggersInRange(List<InteractionTrigger> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0060 Offset: 0x2D0161 VA: 0x2D0060
	// RVA: 0x2C555C0 Offset: 0x2C556C1 VA: 0x2C555C0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0070 Offset: 0x2D0171 VA: 0x2D0070
	// RVA: 0x2C555D0 Offset: 0x2C556D1 VA: 0x2C555D0
	private void set_initiated(bool value) { }

	// RVA: 0x2C555E0 Offset: 0x2C556E1 VA: 0x2C555E0
	public void Start() { }

	// RVA: 0x2C55DD0 Offset: 0x2C55ED1 VA: 0x2C55DD0
	private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x2C55DE0 Offset: 0x2C55EE1 VA: 0x2C55DE0
	private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x2C55DF0 Offset: 0x2C55EF1 VA: 0x2C55DF0
	private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x2C55E00 Offset: 0x2C55F01 VA: 0x2C55E00
	private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x2C55EC0 Offset: 0x2C55FC1 VA: 0x2C55EC0
	public void OnTriggerEnter(Collider c) { }

	// RVA: 0x2C55FF0 Offset: 0x2C560F1 VA: 0x2C55FF0
	public void OnTriggerExit(Collider c) { }

	// RVA: 0x2C560F0 Offset: 0x2C561F1 VA: 0x2C560F0
	private bool ContactIsInRange(int index, out int bestRangeIndex) { }

	// RVA: 0x2C562B0 Offset: 0x2C563B1 VA: 0x2C562B0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2C563E0 Offset: 0x2C564E1 VA: 0x2C563E0
	public void Update() { }

	// RVA: 0x2C56620 Offset: 0x2C56721 VA: 0x2C56620
	private void Raycasting() { }

	// RVA: 0x2C55B30 Offset: 0x2C55C31 VA: 0x2C55B30
	private void UpdateTriggerEventBroadcasting() { }

	// RVA: 0x2C56750 Offset: 0x2C56851 VA: 0x2C56750
	private void UpdateEffectors() { }

	// RVA: 0x2C56870 Offset: 0x2C56971 VA: 0x2C56870
	private void OnPreFBBIK() { }

	// RVA: 0x2C56910 Offset: 0x2C56A11 VA: 0x2C56910
	private void OnPostFBBIK() { }

	// RVA: 0x2C56A70 Offset: 0x2C56B71 VA: 0x2C56A70
	private void OnFixTransforms() { }

	// RVA: 0x2C56B20 Offset: 0x2C56C21 VA: 0x2C56B20
	private void OnDestroy() { }

	// RVA: 0x2C53660 Offset: 0x2C53761 VA: 0x2C53660
	private bool IsValid(bool log) { }

	// RVA: 0x2C545D0 Offset: 0x2C546D1 VA: 0x2C545D0
	private bool TriggerIndexIsValid(int index) { }

	// RVA: 0x2C56F00 Offset: 0x2C57001 VA: 0x2C56F00
	public void .ctor() { }
}

