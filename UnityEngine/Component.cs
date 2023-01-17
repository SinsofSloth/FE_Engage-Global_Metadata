// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43E640 Offset: 0x43E741 VA: 0x43E640
[NativeClassAttribute] // RVA: 0x43E640 Offset: 0x43E741 VA: 0x43E640
[NativeHeaderAttribute] // RVA: 0x43E640 Offset: 0x43E741 VA: 0x43E640
public class Component : Object // TypeDefIndex: 3587
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }
	public string tag { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x44F080 Offset: 0x44F181 VA: 0x44F080
	// RVA: 0x2F1A970 Offset: 0x2F1AA71 VA: 0x2F1A970
	public Transform get_transform() { }

	[FreeFunctionAttribute] // RVA: 0x44F0D0 Offset: 0x44F1D1 VA: 0x44F0D0
	// RVA: 0x2F1A9C0 Offset: 0x2F1AAC1 VA: 0x2F1A9C0
	public GameObject get_gameObject() { }

	[TypeInferenceRuleAttribute] // RVA: 0x44F120 Offset: 0x44F221 VA: 0x44F120
	// RVA: 0x2F1AA10 Offset: 0x2F1AB11 VA: 0x2F1AA10
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] // RVA: 0x44F140 Offset: 0x44F241 VA: 0x44F140
	// RVA: 0x2F1AAE0 Offset: 0x2F1ABE1 VA: 0x2F1AAE0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B140 Offset: 0x229B241 VA: 0x229B140
	|-Component.GetComponent<AkAudioListener>
	|-Component.GetComponent<AkEnvironment>
	|-Component.GetComponent<AkEnvironmentPortal>
	|-Component.GetComponent<AkGameObj>
	|-Component.GetComponent<AkRoomPortal>
	|-Component.GetComponent<Animation>
	|-Component.GetComponent<Animator>
	|-Component.GetComponent<AnimatorInEditor>
	|-Component.GetComponent<BasicMenuItemContent>
	|-Component.GetComponent<BoxCollider>
	|-Component.GetComponent<Camera>
	|-Component.GetComponent<CameraPositionData>
	|-Component.GetComponent<CameraSwitch>
	|-Component.GetComponent<Canvas>
	|-Component.GetComponent<CanvasGroup>
	|-Component.GetComponent<CanvasManager>
	|-Component.GetComponent<CanvasRenderer>
	|-Component.GetComponent<CapsuleCollider>
	|-Component.GetComponent<Character>
	|-Component.GetComponent<CharacterAssetForm>
	|-Component.GetComponent<CharacterAura>
	|-Component.GetComponent<CharacterBuilder>
	|-Component.GetComponent<CharacterConfig>
	|-Component.GetComponent<CharacterHUD>
	|-Component.GetComponent<CharacterIKAim>
	|-Component.GetComponent<CharacterIKFoot>
	|-Component.GetComponent<CharacterIKLookAt>
	|-Component.GetComponent<CharacterIllusion>
	|-Component.GetComponent<CharacterJoint>
	|-Component.GetComponent<CharacterMove>
	|-Component.GetComponent<CharacterProportion>
	|-Component.GetComponent<CharacterSignal>
	|-Component.GetComponent<CharacterSignalObserver>
	|-Component.GetComponent<CharacterSound>
	|-Component.GetComponent<CharacterTimespace>
	|-Component.GetComponent<CharacterTurn>
	|-Component.GetComponent<CharacterWeapon>
	|-Component.GetComponent<CinemachineBrain>
	|-Component.GetComponent<CinemachineCollider>
	|-Component.GetComponent<CinemachineFreeLook>
	|-Component.GetComponent<CinemachinePipeline>
	|-Component.GetComponent<CinemachineSmoothPath>
	|-Component.GetComponent<CinemachineTargetGroup>
	|-Component.GetComponent<CinemachineVirtualCamera>
	|-Component.GetComponent<CinemachineVirtualCameraBase>
	|-Component.GetComponent<Collider>
	|-Component.GetComponent<Collider2D>
	|-Component.GetComponent<CombatConfig>
	|-Component.GetComponent<CombatInput>
	|-Component.GetComponent<CombatObservable>
	|-Component.GetComponent<CombatSkip>
	|-Component.GetComponent<CombatStaging>
	|-Component.GetComponent<CombatTimespace>
	|-Component.GetComponent<Component>
	|-Component.GetComponent<CompositeShadowCaster2D>
	|-Component.GetComponent<CustomOffscreenCamera>
	|-Component.GetComponent<DebugUIHandlerContainer>
	|-Component.GetComponent<DebugUIHandlerWidget>
	|-Component.GetComponent<DragonRideShot>
	|-Component.GetComponent<DragonRideTarget>
	|-Component.GetComponent<EventCamera>
	|-Component.GetComponent<EventCharacterLookAtController>
	|-Component.GetComponent<EventCharacterMouthController>
	|-Component.GetComponent<EventSystem>
	|-Component.GetComponent<FullBodyBipedIK>
	|-Component.GetComponent<GmapGroundCollider>
	|-Component.GetComponent<GmapLineRenderer>
	|-Component.GetComponent<GodUnitSelectMenuContent>
	|-Component.GetComponent<Graphic>
	|-Component.GetComponent<HorizontalLayoutGroup>
	|-Component.GetComponent<HubAccess>
	|-Component.GetComponent<HubEffectArea>
	|-Component.GetComponent<HubEventArea>
	|-Component.GetComponent<HubLookAtController>
	|-Component.GetComponent<HubManualCulling>
	|-Component.GetComponent<HubManualCullingManager>
	|-Component.GetComponent<HubUnitController>
	|-Component.GetComponent<ICinemachineTargetGroup>
	|-Component.GetComponent<IK>
	|-Component.GetComponent<ILayoutController>
	|-Component.GetComponent<Image>
	|-Component.GetComponent<InteractionTarget>
	|-Component.GetComponent<InteractionTrigger>
	|-Component.GetComponent<Iron19CharacterFader>
	|-Component.GetComponent<Iron19CharacterSuperEngage>
	|-Component.GetComponent<Joint>
	|-Component.GetComponent<LaunchBehaviour>
	|-Component.GetComponent<LayoutElement>
	|-Component.GetComponent<LayoutGroup>
	|-Component.GetComponent<Light>
	|-Component.GetComponent<LineRenderer>
	|-Component.GetComponent<LookAtIK>
	|-Component.GetComponent<MagicFlying>
	|-Component.GetComponent<MapCollision>
	|-Component.GetComponent<MapCursorAnim>
	|-Component.GetComponent<MapCursorColor>
	|-Component.GetComponent<MeshCollider>
	|-Component.GetComponent<MeshFilter>
	|-Component.GetComponent<MeshRenderer>
	|-Component.GetComponent<object>
	|-Component.GetComponent<ParticleSystem>
	|-Component.GetComponent<PhotographSelectAreaMenuItemContent>
	|-Component.GetComponent<PlanarReflectionV2>
	|-Component.GetComponent<PlayableDirector>
	|-Component.GetComponent<Poser>
	|-Component.GetComponent<Projector>
	|-Component.GetComponent<RectMask2D>
	|-Component.GetComponent<RectTransform>
	|-Component.GetComponent<ReflectionCamera>
	|-Component.GetComponent<ReflectionManager>
	|-Component.GetComponent<Renderer>
	|-Component.GetComponent<Rigidbody>
	|-Component.GetComponent<Rigidbody2D>
	|-Component.GetComponent<RingColliderPart>
	|-Component.GetComponent<RotationLimit>
	|-Component.GetComponent<ShadowCaster2D>
	|-Component.GetComponent<SimpleAnimation>
	|-Component.GetComponent<SkinnedMeshRenderer>
	|-Component.GetComponent<Skybox>
	|-Component.GetComponent<SphereCollider>
	|-Component.GetComponent<SpringBonePivot>
	|-Component.GetComponent<StandaloneInputModule>
	|-Component.GetComponent<StandaloneInputModule18>
	|-Component.GetComponent<TMP_SpriteAnimator>
	|-Component.GetComponent<TMP_Text>
	|-Component.GetComponent<TalkCharacterController>
	|-Component.GetComponent<TerrainExporter>
	|-Component.GetComponent<Text>
	|-Component.GetComponent<TextMeshPro>
	|-Component.GetComponent<TextMeshProUGUI>
	|-Component.GetComponent<Toggle>
	|-Component.GetComponent<Transform>
	|-Component.GetComponent<TriggerEventBroadcaster>
	|-Component.GetComponent<UnitInfoCharaImageMaskOffset>
	|-Component.GetComponent<UniversalAdditionalCameraData>
	|-Component.GetComponent<UniversalAdditionalLightData>
	|-Component.GetComponent<VRIK>
	|-Component.GetComponent<VRIKRootController>
	|-Component.GetComponent<Volume>
	|-Component.GetComponent<MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuItemContent>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B6E0 Offset: 0x229B7E1 VA: 0x229B6E0
	|-Component.TryGetComponent<Animator>
	|-Component.TryGetComponent<Camera>
	|-Component.TryGetComponent<Canvas>
	|-Component.TryGetComponent<CanvasGroup>
	|-Component.TryGetComponent<CharacterCollision>
	|-Component.TryGetComponent<CinemachineVirtualCameraBase>
	|-Component.TryGetComponent<Collider>
	|-Component.TryGetComponent<HelpItemSkill>
	|-Component.TryGetComponent<Image>
	|-Component.TryGetComponent<Iron19CharacterFader>
	|-Component.TryGetComponent<MapBounding>
	|-Component.TryGetComponent<MeshFilter>
	|-Component.TryGetComponent<MeshRenderer>
	|-Component.TryGetComponent<object>
	|-Component.TryGetComponent<PixelPerfectCamera>
	|-Component.TryGetComponent<ProfileCardFontSetter>
	|-Component.TryGetComponent<Renderer>
	|-Component.TryGetComponent<Skybox>
	|-Component.TryGetComponent<SphereCollider>
	|-Component.TryGetComponent<SpringBone>
	|-Component.TryGetComponent<SpringCollider>
	|-Component.TryGetComponent<TextMeshProUGUI>
	|-Component.TryGetComponent<UniversalAdditionalCameraData>
	|-Component.TryGetComponent<WeaponModelManager>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0x44F180 Offset: 0x44F281 VA: 0x44F180
	// RVA: 0x2F1AB40 Offset: 0x2F1AC41 VA: 0x2F1AB40
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B2D0 Offset: 0x229B3D1 VA: 0x229B2D0
	|-Component.GetComponentInChildren<Iron19CharacterFader>
	|-Component.GetComponentInChildren<LookAtIK>
	|-Component.GetComponentInChildren<Mask>
	|-Component.GetComponentInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x44F1A0 Offset: 0x44F2A1 VA: 0x44F1A0
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B1F0 Offset: 0x229B2F1 VA: 0x229B1F0
	|-Component.GetComponentInChildren<AimIK>
	|-Component.GetComponentInChildren<Animation>
	|-Component.GetComponentInChildren<Animator>
	|-Component.GetComponentInChildren<CharacterBuilder>
	|-Component.GetComponentInChildren<CharacterJoint>
	|-Component.GetComponentInChildren<CharacterLying>
	|-Component.GetComponentInChildren<CharacterProportion>
	|-Component.GetComponentInChildren<CharacterSignal>
	|-Component.GetComponentInChildren<CharacterViewerLookTarget>
	|-Component.GetComponentInChildren<CinemachineDollyCart>
	|-Component.GetComponentInChildren<CinemachineSmoothPath>
	|-Component.GetComponentInChildren<EventCharacterMouthController>
	|-Component.GetComponentInChildren<FullBodyBipedIK>
	|-Component.GetComponentInChildren<HubUnitController>
	|-Component.GetComponentInChildren<Iron19CharacterFader>
	|-Component.GetComponentInChildren<LookAtIK>
	|-Component.GetComponentInChildren<MapInfoGaugeMainLocatorRoot>
	|-Component.GetComponentInChildren<MapInfoUnitLocatorRoot>
	|-Component.GetComponentInChildren<MeshRenderer>
	|-Component.GetComponentInChildren<object>
	|-Component.GetComponentInChildren<ParticleSystem>
	|-Component.GetComponentInChildren<ReinsController>
	|-Component.GetComponentInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentInChildren<Text>
	|-Component.GetComponentInChildren<TextMeshAnimation>
	|-Component.GetComponentInChildren<TextMeshProUGUI>
	|-Component.GetComponentInChildren<Throwing>
	|-Component.GetComponentInChildren<Toggle>
	|-Component.GetComponentInChildren<TrailMesh>
	|-Component.GetComponentInChildren<UnitSignal>
	|-Component.GetComponentInChildren<VRIK>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B580 Offset: 0x229B681 VA: 0x229B580
	|-Component.GetComponentsInChildren<Animator>
	|-Component.GetComponentsInChildren<CharacterProportion>
	|-Component.GetComponentsInChildren<CinemachineVirtualCameraBase>
	|-Component.GetComponentsInChildren<EventCharacterMouthController>
	|-Component.GetComponentsInChildren<FullBodyBipedIK>
	|-Component.GetComponentsInChildren<GrounderFBBIK>
	|-Component.GetComponentsInChildren<GrounderQuadruped>
	|-Component.GetComponentsInChildren<ISpringManager>
	|-Component.GetComponentsInChildren<MapUIUnitIndexAsUV2>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<RectTransform>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<SolverManager>
	|-Component.GetComponentsInChildren<SpringBone>
	|-Component.GetComponentsInChildren<SpringCollider>
	|-Component.GetComponentsInChildren<Transform>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B5E0 Offset: 0x229B6E1 VA: 0x229B5E0
	|-Component.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B560 Offset: 0x229B661 VA: 0x229B560
	|-Component.GetComponentsInChildren<Animator>
	|-Component.GetComponentsInChildren<BoxCollider>
	|-Component.GetComponentsInChildren<CharacterJoint>
	|-Component.GetComponentsInChildren<CinemachineExtension>
	|-Component.GetComponentsInChildren<Collider>
	|-Component.GetComponentsInChildren<DebugUIHandlerWidget>
	|-Component.GetComponentsInChildren<FullBodyBipedIK>
	|-Component.GetComponentsInChildren<Grounder>
	|-Component.GetComponentsInChildren<GrounderFBBIK>
	|-Component.GetComponentsInChildren<GrounderQuadruped>
	|-Component.GetComponentsInChildren<IK>
	|-Component.GetComponentsInChildren<ISpringManager>
	|-Component.GetComponentsInChildren<InteractionTarget>
	|-Component.GetComponentsInChildren<LODGroup>
	|-Component.GetComponentsInChildren<LimbIK>
	|-Component.GetComponentsInChildren<LookAtIK>
	|-Component.GetComponentsInChildren<MapCursorAnim>
	|-Component.GetComponentsInChildren<MapInfoGaugeSubLocatorRoot>
	|-Component.GetComponentsInChildren<MapObject>
	|-Component.GetComponentsInChildren<MeshFilter>
	|-Component.GetComponentsInChildren<MeshRenderer>
	|-Component.GetComponentsInChildren<MonoBehaviour>
	|-Component.GetComponentsInChildren<object>
	|-Component.GetComponentsInChildren<ParticleSystem>
	|-Component.GetComponentsInChildren<ParticleSystemRenderer>
	|-Component.GetComponentsInChildren<Renderer>
	|-Component.GetComponentsInChildren<Rigidbody>
	|-Component.GetComponentsInChildren<RotationLimit>
	|-Component.GetComponentsInChildren<Selectable>
	|-Component.GetComponentsInChildren<SkinnedMeshRenderer>
	|-Component.GetComponentsInChildren<TMP_SubMesh>
	|-Component.GetComponentsInChildren<TMP_SubMeshUI>
	|-Component.GetComponentsInChildren<TextMeshAnimation>
	|-Component.GetComponentsInChildren<TextMeshProUGUI>
	|-Component.GetComponentsInChildren<Transform>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B5C0 Offset: 0x229B6C1 VA: 0x229B5C0
	|-Component.GetComponentsInChildren<Component>
	|-Component.GetComponentsInChildren<object>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0x44F1B0 Offset: 0x44F2B1 VA: 0x44F1B0
	// RVA: 0x2F1AC30 Offset: 0x2F1AD31 VA: 0x2F1AC30
	public Component GetComponentInParent(Type t) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B3B0 Offset: 0x229B4B1 VA: 0x229B3B0
	|-Component.GetComponentInParent<Canvas>
	|-Component.GetComponentInParent<CanvasGroup>
	|-Component.GetComponentInParent<CanvasManager>
	|-Component.GetComponentInParent<CanvasScaler>
	|-Component.GetComponentInParent<Character>
	|-Component.GetComponentInParent<CharacterNodeConstraint>
	|-Component.GetComponentInParent<Dropdown>
	|-Component.GetComponentInParent<FullBodyBipedIK>
	|-Component.GetComponentInParent<MapObject>
	|-Component.GetComponentInParent<object>
	|-Component.GetComponentInParent<ResourceObject>
	|-Component.GetComponentInParent<SpringBone>
	|-Component.GetComponentInParent<TMP_Dropdown>
	|-Component.GetComponentInParent<Terrain>
	|-Component.GetComponentInParent<TextMeshPro>
	|-Component.GetComponentInParent<TextMeshProUGUI>
	|-Component.GetComponentInParent<UnitActor>
	|-Component.GetComponentInParent<UnitModel>
	|-Component.GetComponentInParent<VRIK>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B650 Offset: 0x229B751 VA: 0x229B650
	|-Component.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B690 Offset: 0x229B791 VA: 0x229B690
	|-Component.GetComponentsInParent<Canvas>
	|-Component.GetComponentsInParent<object>
	|-Component.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B630 Offset: 0x229B731 VA: 0x229B630
	|-Component.GetComponentsInParent<BaseRaycaster>
	|-Component.GetComponentsInParent<IScrollHandler>
	|-Component.GetComponentsInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0x44F1D0 Offset: 0x44F2D1 VA: 0x44F1D0
	// RVA: 0x2F1AD10 Offset: 0x2F1AE11 VA: 0x2F1AD10
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x2F1AD70 Offset: 0x2F1AE71 VA: 0x2F1AD70
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B4C0 Offset: 0x229B5C1 VA: 0x229B4C0
	|-Component.GetComponents<BaseInputModule>
	|-Component.GetComponents<CanvasGroup>
	|-Component.GetComponents<Collider>
	|-Component.GetComponents<Component>
	|-Component.GetComponents<IMaterialModifier>
	|-Component.GetComponents<Mask>
	|-Component.GetComponents<object>
	*/

	// RVA: 0x2F1ADD0 Offset: 0x2F1AED1 VA: 0x2F1ADD0
	public string get_tag() { }

	// RVA: 0x2F1AEA0 Offset: 0x2F1AFA1 VA: 0x2F1AEA0
	public void set_tag(string value) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B490 Offset: 0x229B591 VA: 0x229B490
	|-Component.GetComponents<BaseInput>
	|-Component.GetComponents<BaseRaycaster>
	|-Component.GetComponents<CinemachineComponentBase>
	|-Component.GetComponents<CinemachineVirtualCameraBase>
	|-Component.GetComponents<MonoBehaviour>
	|-Component.GetComponents<object>
	|-Component.GetComponents<Renderer>
	*/

	// RVA: 0x2F1AF70 Offset: 0x2F1B071 VA: 0x2F1AF70
	public bool CompareTag(string tag) { }

	// RVA: 0x2F0BC90 Offset: 0x2F0BD91 VA: 0x2F0BC90
	public void .ctor() { }
}

