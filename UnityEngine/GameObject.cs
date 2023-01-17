// Namespace: UnityEngine
[ExcludeFromPresetAttribute] // RVA: 0x43E7F0 Offset: 0x43E8F1 VA: 0x43E7F0
[UsedByNativeCodeAttribute] // RVA: 0x43E7F0 Offset: 0x43E8F1 VA: 0x43E7F0
[NativeHeaderAttribute] // RVA: 0x43E7F0 Offset: 0x43E8F1 VA: 0x43E7F0
public sealed class GameObject : Object // TypeDefIndex: 3594
{
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	[ObsoleteAttribute] // RVA: 0x45A350 Offset: 0x45A451 VA: 0x45A350
	public bool active { get; set; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public bool isStatic { get; set; }
	internal bool isStaticBatchable { get; }
	public string tag { get; set; }
	public Scene scene { get; }
	public ulong sceneCullingMask { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x44F270 Offset: 0x44F371 VA: 0x44F270
	// RVA: 0x2F22170 Offset: 0x2F22271 VA: 0x2F22170
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5050 Offset: 0x22B5151 VA: 0x22B5050
	|-GameObject.GetComponent<AccessoryDetailInfoWindow>
	|-GameObject.GetComponent<AccessoryEquipmentInfo>
	|-GameObject.GetComponent<AccessoryMenuItemContent>
	|-GameObject.GetComponent<AccessoryShopBuyMenuContent>
	|-GameObject.GetComponent<AccessoryShopBuyMenuItemContent>
	|-GameObject.GetComponent<AccessoryShopBuyRoot>
	|-GameObject.GetComponent<AccessoryShopChangeMenuContent>
	|-GameObject.GetComponent<AccessoryShopChangeRoot>
	|-GameObject.GetComponent<AccessoryShopUnitSelectRoot>
	|-GameObject.GetComponent<AchievementMenuContent>
	|-GameObject.GetComponent<AchievementMenuItemContent>
	|-GameObject.GetComponent<AimIK>
	|-GameObject.GetComponent<AkAmbient>
	|-GameObject.GetComponent<AkGameObj>
	|-GameObject.GetComponent<AkRoom>
	|-GameObject.GetComponent<AmiiboAccessoryMenuContent>
	|-GameObject.GetComponent<AmiiboSoundMenuContent>
	|-GameObject.GetComponent<Animation>
	|-GameObject.GetComponent<Animator>
	|-GameObject.GetComponent<ArenaBondGodSelectRoot>
	|-GameObject.GetComponent<ArenaBondLevelSelectRoot>
	|-GameObject.GetComponent<ArenaBondUnitSelectRoot>
	|-GameObject.GetComponent<ArenaExpUnitSelectRoot>
	|-GameObject.GetComponent<ArenaTopMenuContent>
	|-GameObject.GetComponent<BasicItemMenuItemContent>
	|-GameObject.GetComponent<BasicMenuItemContent>
	|-GameObject.GetComponent<BattleRecordLineSetter>
	|-GameObject.GetComponent<BattleRecordSetter>
	|-GameObject.GetComponent<BlinkMonoBehaviour>
	|-GameObject.GetComponent<BondLevelUpSkill>
	|-GameObject.GetComponent<BondPopUpController>
	|-GameObject.GetComponent<BoxCollider>
	|-GameObject.GetComponent<Button>
	|-GameObject.GetComponent<Camera>
	|-GameObject.GetComponent<CameraControllerUnitDetail>
	|-GameObject.GetComponent<Canvas>
	|-GameObject.GetComponent<CanvasGroup>
	|-GameObject.GetComponent<CanvasRenderer>
	|-GameObject.GetComponent<CapeTowerTopMenuRoot>
	|-GameObject.GetComponent<CapsuleCollider>
	|-GameObject.GetComponent<CategorySelectRoot>
	|-GameObject.GetComponent<ChallengeMapSelectRoot>
	|-GameObject.GetComponent<Character>
	|-GameObject.GetComponent<CharacterNodeConstraint>
	|-GameObject.GetComponent<CinemachineBrain>
	|-GameObject.GetComponent<CinemachineDollyCart>
	|-GameObject.GetComponent<CinemachineSmoothPath>
	|-GameObject.GetComponent<CinemachineVirtualCameraBase>
	|-GameObject.GetComponent<ClassChangeRoot>
	|-GameObject.GetComponent<CombatGaugeController>
	|-GameObject.GetComponent<CombatWorld>
	|-GameObject.GetComponent<CommonRewardDialogContent>
	|-GameObject.GetComponent<CommonRewardMenuContent>
	|-GameObject.GetComponent<CommonRingController>
	|-GameObject.GetComponent<ConfigMenuContent>
	|-GameObject.GetComponent<ConfigRoot>
	|-GameObject.GetComponent<CustomOffscreenCamera>
	|-GameObject.GetComponent<DebugUIHandlerCanvas>
	|-GameObject.GetComponent<DebugUIHandlerContainer>
	|-GameObject.GetComponent<DebugUIHandlerPanel>
	|-GameObject.GetComponent<DebugUIHandlerPersistentCanvas>
	|-GameObject.GetComponent<DebugUIHandlerValue>
	|-GameObject.GetComponent<DebugUIHandlerWidget>
	|-GameObject.GetComponent<DiagnosticEventCollector>
	|-GameObject.GetComponent<DiscardItemRoot>
	|-GameObject.GetComponent<DishAllMenuContent>
	|-GameObject.GetComponent<DishResultDialogContent>
	|-GameObject.GetComponent<DishResultDialogParamContent>
	|-GameObject.GetComponent<DragonRideCamera>
	|-GameObject.GetComponent<DragonRideConfig>
	|-GameObject.GetComponent<DragonRideExplode>
	|-GameObject.GetComponent<DragonRideLocatorSetting>
	|-GameObject.GetComponent<DragonRideMenuContent>
	|-GameObject.GetComponent<DragonRideShot>
	|-GameObject.GetComponent<DragonRideSolaImageRender>
	|-GameObject.GetComponent<DragonRideTarget>
	|-GameObject.GetComponent<DragonRideTargetGroup>
	|-GameObject.GetComponent<DragonRideTargetPopup>
	|-GameObject.GetComponent<Dropdown>
	|-GameObject.GetComponent<DynamicsNull>
	|-GameObject.GetComponent<EatUnitsSelectMenuRelianceListContent>
	|-GameObject.GetComponent<EffectHandle>
	|-GameObject.GetComponent<EncountIcon>
	|-GameObject.GetComponent<EncountIconRoot>
	|-GameObject.GetComponent<EndRollSetter>
	|-GameObject.GetComponent<EventPictureController>
	|-GameObject.GetComponent<ExpSetter>
	|-GameObject.GetComponent<FaceImagesController>
	|-GameObject.GetComponent<FishingBattleRader>
	|-GameObject.GetComponent<FishingCharaImageRender>
	|-GameObject.GetComponent<FishingConfig_Base>
	|-GameObject.GetComponent<FishingConfig_Battle>
	|-GameObject.GetComponent<FishingConfig_Defeat>
	|-GameObject.GetComponent<FishingConfig_MoveCircle>
	|-GameObject.GetComponent<FishingConfig_Result>
	|-GameObject.GetComponent<FishingConfig_ThrowIn>
	|-GameObject.GetComponent<FishingConfig_WaitCancel>
	|-GameObject.GetComponent<FishingConfig_WaitCatch>
	|-GameObject.GetComponent<FishingFish>
	|-GameObject.GetComponent<FishingLure>
	|-GameObject.GetComponent<FishingPictureBookMenuContent>
	|-GameObject.GetComponent<FishingRodSelectMenuContent>
	|-GameObject.GetComponent<FleaMarketBuyRoot>
	|-GameObject.GetComponent<FortuneTellingResultMenu>
	|-GameObject.GetComponent<FortuneTellingUnitSelectMenuContent>
	|-GameObject.GetComponent<FriendListContent>
	|-GameObject.GetComponent<FriendListSelectMenuContent>
	|-GameObject.GetComponent<FullBodyBipedIK>
	|-GameObject.GetComponent<GiftContent>
	|-GameObject.GetComponent<GmapCamera>
	|-GameObject.GetComponent<GmapCinemaScope>
	|-GameObject.GetComponent<GmapGroundSphereController>
	|-GameObject.GetComponent<GmapLineRenderer>
	|-GameObject.GetComponent<GmapMapInfoContent>
	|-GameObject.GetComponent<GmapWholeMapController>
	|-GameObject.GetComponent<GodRoomUnitSelectMenuContent>
	|-GameObject.GetComponent<GodSelectRoot>
	|-GameObject.GetComponent<GodUnitSelectMenuContent>
	|-GameObject.GetComponent<GridLayoutGroup>
	|-GameObject.GetComponent<GrounderFBBIK>
	|-GameObject.GetComponent<HUDPopup>
	|-GameObject.GetComponent<HorizontalLayoutGroup>
	|-GameObject.GetComponent<HubAccess>
	|-GameObject.GetComponent<HubAccessCursor>
	|-GameObject.GetComponent<HubAccessHelp>
	|-GameObject.GetComponent<HubAnimalController>
	|-GameObject.GetComponent<HubBalloon>
	|-GameObject.GetComponent<HubCamera>
	|-GameObject.GetComponent<HubCullingPlayerCollider>
	|-GameObject.GetComponent<HubEnv>
	|-GameObject.GetComponent<HubEnvSub>
	|-GameObject.GetComponent<HubManualCulling>
	|-GameObject.GetComponent<HubMascotController>
	|-GameObject.GetComponent<HubParams>
	|-GameObject.GetComponent<HubPlayTalkAfterMenuContent>
	|-GameObject.GetComponent<HubPlayerCollider>
	|-GameObject.GetComponent<HubUnitController>
	|-GameObject.GetComponent<Image>
	|-GameObject.GetComponent<InputField>
	|-GameObject.GetComponent<InventoryPoolItemMenuContent>
	|-GameObject.GetComponent<InventoryRoot>
	|-GameObject.GetComponent<InventoryUnitItemMenuContent>
	|-GameObject.GetComponent<InvestmentMapPoint>
	|-GameObject.GetComponent<InvestmentMenuContent>
	|-GameObject.GetComponent<InvestmentNationDataMenu>
	|-GameObject.GetComponent<Iron19CharacterSuperEngage>
	|-GameObject.GetComponent<ItemHoldingInfoWindow>
	|-GameObject.GetComponent<ItemListDialogItemContent>
	|-GameObject.GetComponent<ItemMenuDetailSetter>
	|-GameObject.GetComponent<ItemShopBuyMenuContent>
	|-GameObject.GetComponent<ItemShopBuyMenuItemContent>
	|-GameObject.GetComponent<ItemShopBuyRoot>
	|-GameObject.GetComponent<JobIntroInfoSetter>
	|-GameObject.GetComponent<JobIntroTitleSetter>
	|-GameObject.GetComponent<KeyHelpController>
	|-GameObject.GetComponent<LaterTalkSetter>
	|-GameObject.GetComponent<LaunchBehaviour>
	|-GameObject.GetComponent<LayoutElement>
	|-GameObject.GetComponent<LevelUpWindowController>
	|-GameObject.GetComponent<Light>
	|-GameObject.GetComponent<LookAtIK>
	|-GameObject.GetComponent<MagicSub>
	|-GameObject.GetComponent<MapAlternateConfirmRoot>
	|-GameObject.GetComponent<MapBattleInfoParamSetter>
	|-GameObject.GetComponent<MapBattleInfoRoot>
	|-GameObject.GetComponent<MapCursorAnimManager>
	|-GameObject.GetComponent<MapCursorLocatorRoot>
	|-GameObject.GetComponent<MapEngageConfirmRoot>
	|-GameObject.GetComponent<MapNavigationMiniMapMenuContent>
	|-GameObject.GetComponent<MapNavigationRoot>
	|-GameObject.GetComponent<MapNavigationStatusMenuContent>
	|-GameObject.GetComponent<MapObject>
	|-GameObject.GetComponent<MapPointerAnimManager>
	|-GameObject.GetComponent<MapPointerLocatorRoot>
	|-GameObject.GetComponent<MapTerrainInfoAlignmentMember>
	|-GameObject.GetComponent<MascotAccChangeContent>
	|-GameObject.GetComponent<MascotColorChangeContent>
	|-GameObject.GetComponent<MascotColorChangeItemContent>
	|-GameObject.GetComponent<MascotFoodSelectContent>
	|-GameObject.GetComponent<MascotFriendlyContent>
	|-GameObject.GetComponent<Mask>
	|-GameObject.GetComponent<MaterialListMenuContent>
	|-GameObject.GetComponent<MenuBg>
	|-GameObject.GetComponent<MeshCollider>
	|-GameObject.GetComponent<MeshFilter>
	|-GameObject.GetComponent<MeshRenderer>
	|-GameObject.GetComponent<MiniMapController>
	|-GameObject.GetComponent<MiniMapCursor>
	|-GameObject.GetComponent<MiniMapPanelDangerAllRenderer>
	|-GameObject.GetComponent<MiniMapPanelDangerRenderer>
	|-GameObject.GetComponent<MiniMapPanelDeployRenderer>
	|-GameObject.GetComponent<MiniMapPanelFrameForDangerAllRenderer>
	|-GameObject.GetComponent<MiniMapPanelRouteRenderer>
	|-GameObject.GetComponent<MiniMapSightRenderer>
	|-GameObject.GetComponent<MiniMapTerrainRenderer>
	|-GameObject.GetComponent<MuscleExercisePrefab>
	|-GameObject.GetComponent<MuscleStartMenuContent>
	|-GameObject.GetComponent<MyRoomMovieMenuContent>
	|-GameObject.GetComponent<MyRoomRelianceSelectContent>
	|-GameObject.GetComponent<MyRoomRelianceSelectRoot>
	|-GameObject.GetComponent<MyRoomRelianceSubSelectContent>
	|-GameObject.GetComponent<MyRoomSoundMenuContent>
	|-GameObject.GetComponent<MyRoomWakeupSelectMenuContent>
	|-GameObject.GetComponent<MyRoomWakeupSelectRoot>
	|-GameObject.GetComponent<object>
	|-GameObject.GetComponent<ObservableDestroyTrigger>
	|-GameObject.GetComponent<Outline>
	|-GameObject.GetComponent<ParticleFadeoutComponent>
	|-GameObject.GetComponent<ParticleSystem>
	|-GameObject.GetComponent<PhotographAllMenuContent>
	|-GameObject.GetComponent<PhotographEditDisposMenuContent>
	|-GameObject.GetComponent<PhotographSelectAreaMenuContent>
	|-GameObject.GetComponent<PhotographSelectBodyAccMenuContent>
	|-GameObject.GetComponent<PhotographSelectCharacterMenuContent>
	|-GameObject.GetComponent<PhotographSelectDisposMenuContent>
	|-GameObject.GetComponent<PhotographSelectFaceAccMenuContent>
	|-GameObject.GetComponent<PhotographSelectPauseMenuContent>
	|-GameObject.GetComponent<PhotographSelectScarfColorMenuContent>
	|-GameObject.GetComponent<PhotographSelectWeaponMenuContent>
	|-GameObject.GetComponent<PlanarReflectionV2>
	|-GameObject.GetComponent<PlayableDirector>
	|-GameObject.GetComponent<ProfileCardAlbumRoot>
	|-GameObject.GetComponent<ProfileCardMyCardRoot>
	|-GameObject.GetComponent<ProfileCardRoot>
	|-GameObject.GetComponent<ProfileCardStampObject>
	|-GameObject.GetComponent<ProfileCardTextListMenuItemContent>
	|-GameObject.GetComponent<ProfileCardTopMenuRoot>
	|-GameObject.GetComponent<RankingMenuContent>
	|-GameObject.GetComponent<RawImage>
	|-GameObject.GetComponent<RectMask2D>
	|-GameObject.GetComponent<RectTransform>
	|-GameObject.GetComponent<RefineGodWeaponRoot>
	|-GameObject.GetComponent<RefineRingResult10Window>
	|-GameObject.GetComponent<RefineRingResult1Window>
	|-GameObject.GetComponent<RefineRingTimesSelectMenuContent>
	|-GameObject.GetComponent<RefineRingTimesSelectRoot>
	|-GameObject.GetComponent<RefineShopEngraveDemoRoot>
	|-GameObject.GetComponent<RefineShopEngraveGodMenuContent>
	|-GameObject.GetComponent<RefineShopEngraveGodRoot>
	|-GameObject.GetComponent<RefineShopEngraveItemSelectRoot>
	|-GameObject.GetComponent<RefineShopExchangeCountMenuContent>
	|-GameObject.GetComponent<RefineShopExchangeResultPopup>
	|-GameObject.GetComponent<RefineShopExchangeRoot>
	|-GameObject.GetComponent<RefineShopExchangeSourceMenuContent>
	|-GameObject.GetComponent<RefineShopExchangeTargetMenuContent>
	|-GameObject.GetComponent<RefineShopGodSymbol>
	|-GameObject.GetComponent<RefineShopRefineBaseMenuContent>
	|-GameObject.GetComponent<RefineShopRefineBaseRoot>
	|-GameObject.GetComponent<RefineShopRefineTargetMenuContent>
	|-GameObject.GetComponent<RefineShopRefineTargetRoot>
	|-GameObject.GetComponent<ReflectionCamera>
	|-GameObject.GetComponent<RefreshUnitSelectRoot>
	|-GameObject.GetComponent<RelayMapSelectRoot>
	|-GameObject.GetComponent<RelayMessageMenuContent>
	|-GameObject.GetComponent<RelayReplaySelectRoot>
	|-GameObject.GetComponent<RelayShowDataDialogContent>
	|-GameObject.GetComponent<RelayWdwMapHelp>
	|-GameObject.GetComponent<RelayWdwPlayerList>
	|-GameObject.GetComponent<ReliancePopUpController>
	|-GameObject.GetComponent<Renderer>
	|-GameObject.GetComponent<ResourceObject>
	|-GameObject.GetComponent<RewindMenuContent>
	|-GameObject.GetComponent<RewindMenuItemContent>
	|-GameObject.GetComponent<Rigidbody>
	|-GameObject.GetComponent<RingCleaningClothAnimationEvent>
	|-GameObject.GetComponent<RingCleaningConditionIcon>
	|-GameObject.GetComponent<RingCleaningGaugeController>
	|-GameObject.GetComponent<RingCleaningRoot>
	|-GameObject.GetComponent<RingCleaningUnitSelectMenuContent>
	|-GameObject.GetComponent<RingCollider>
	|-GameObject.GetComponent<RingColliderPart>
	|-GameObject.GetComponent<RingInfoDirty>
	|-GameObject.GetComponent<RingSelectMenuContent>
	|-GameObject.GetComponent<RingSelectRoot>
	|-GameObject.GetComponent<ScrollRect>
	|-GameObject.GetComponent<Scrollbar>
	|-GameObject.GetComponent<SendItemRoot>
	|-GameObject.GetComponent<ShopSellAccountWindow>
	|-GameObject.GetComponent<ShopSellMenuContent>
	|-GameObject.GetComponent<ShopSellRoot>
	|-GameObject.GetComponent<ShopUnitSelectMenuContent>
	|-GameObject.GetComponent<ShopUnitSelectRoot>
	|-GameObject.GetComponent<ShopUnitSelectStatus>
	|-GameObject.GetComponent<ShopWeaponModelRenderer>
	|-GameObject.GetComponent<SkillEditEquipSkillMenuContent>
	|-GameObject.GetComponent<SkillEditPoolSkillMenuContent>
	|-GameObject.GetComponent<SkillEditRoot>
	|-GameObject.GetComponent<SkillInheritanceMenuContent>
	|-GameObject.GetComponent<SkinnedMeshRenderer>
	|-GameObject.GetComponent<Slider>
	|-GameObject.GetComponent<SolanelInfoMenuContent>
	|-GameObject.GetComponent<SortieTradeItemMenuContent>
	|-GameObject.GetComponent<SphereCollider>
	|-GameObject.GetComponent<SpringBone>
	|-GameObject.GetComponent<SynthesisRingBaseRingMenuContent>
	|-GameObject.GetComponent<SynthesisRingInfoWindow>
	|-GameObject.GetComponent<SynthesisRingRoot>
	|-GameObject.GetComponent<SystemScrollMenuContent>
	|-GameObject.GetComponent<TMP_InputField>
	|-GameObject.GetComponent<TMP_SubMesh>
	|-GameObject.GetComponent<TMP_Text>
	|-GameObject.GetComponent<TalkCharacterController>
	|-GameObject.GetComponent<TalkCharacterSignal>
	|-GameObject.GetComponent<Text>
	|-GameObject.GetComponent<TextMeshProUGUI>
	|-GameObject.GetComponent<TitleBar>
	|-GameObject.GetComponent<Toggle>
	|-GameObject.GetComponent<TradeRoot>
	|-GameObject.GetComponent<Transform>
	|-GameObject.GetComponent<TroopListMenuContent>
	|-GameObject.GetComponent<TroopListRoot>
	|-GameObject.GetComponent<TroopListSortMenu>
	|-GameObject.GetComponent<TutorialListRoot>
	|-GameObject.GetComponent<TutorialListSelectMenuContent>
	|-GameObject.GetComponent<TutorialListSelectMenuItemContent>
	|-GameObject.GetComponent<TutorialListTopMenuContent>
	|-GameObject.GetComponent<UnitIcon>
	|-GameObject.GetComponent<UnitInfoParamSetter>
	|-GameObject.GetComponent<UnitInfoWindowCharaUpdater>
	|-GameObject.GetComponent<UnitModel>
	|-GameObject.GetComponent<UnitSelectMenuContent>
	|-GameObject.GetComponent<UnitSelectRoot>
	|-GameObject.GetComponent<UnitSelectSortieMenuContent>
	|-GameObject.GetComponent<UnitStatusSetter>
	|-GameObject.GetComponent<UniversalAdditionalCameraData>
	|-GameObject.GetComponent<ValueCountController>
	|-GameObject.GetComponent<VersusMapEditContent>
	|-GameObject.GetComponent<VersusMapEditObjListMenuContent>
	|-GameObject.GetComponent<VersusMapEditThemeSelectContent>
	|-GameObject.GetComponent<VersusViolationTopContent>
	|-GameObject.GetComponent<VerticalLayoutGroup>
	|-GameObject.GetComponent<VideoPlayer>
	|-GameObject.GetComponent<WdwTutorialLocatorRoot>
	|-GameObject.GetComponent<WeaponFlying>
	|-GameObject.GetComponent<WeaponHoldingInfoWindow>
	|-GameObject.GetComponent<WeaponShopBuyMenuContent>
	|-GameObject.GetComponent<WeaponShopBuyMenuItemContent>
	|-GameObject.GetComponent<WeaponShopBuyRoot>
	|-GameObject.GetComponent<WindActor>
	|-GameObject.GetComponent<WindSampler>
	|-GameObject.GetComponent<EventDemoSequence.SoundEnv>
	|-GameObject.GetComponent<FaceImagesController.ReturnEntryComponent>
	|-GameObject.GetComponent<RingListSkillMenu.MenuContent>
	|-GameObject.GetComponent<SaveDataMenu.MenuContent>
	|-GameObject.GetComponent<MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuContent>
	|-GameObject.GetComponent<MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuContent>
	|-GameObject.GetComponent<MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuContent>
	|-GameObject.GetComponent<MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuContent>
	|-GameObject.GetComponent<MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuContent>
	|-GameObject.GetComponent<MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuContent>
	|-GameObject.GetComponent<MainMenuSequence.TopMenuSequence.Menu.MenuContent>
	*/

	[TypeInferenceRuleAttribute] // RVA: 0x44F2B0 Offset: 0x44F3B1 VA: 0x44F2B0
	[FreeFunctionAttribute] // RVA: 0x44F2B0 Offset: 0x44F3B1 VA: 0x44F2B0
	// RVA: 0x2F1AA90 Offset: 0x2F1AB91 VA: 0x2F1AA90
	public Component GetComponent(Type type) { }

	[FreeFunctionAttribute] // RVA: 0x44F320 Offset: 0x44F421 VA: 0x44F320
	[NativeWritableSelfAttribute] // RVA: 0x44F320 Offset: 0x44F421 VA: 0x44F320
	// RVA: 0x2F221C0 Offset: 0x2F222C1 VA: 0x2F221C0
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunctionAttribute] // RVA: 0x44F380 Offset: 0x44F481 VA: 0x44F380
	// RVA: 0x2F22220 Offset: 0x2F22321 VA: 0x2F22220
	internal Component GetComponentByName(string type) { }

	// RVA: 0x2F22270 Offset: 0x2F22371 VA: 0x2F22270
	public Component GetComponent(string type) { }

	[FreeFunctionAttribute] // RVA: 0x44F3D0 Offset: 0x44F4D1 VA: 0x44F3D0
	[TypeInferenceRuleAttribute] // RVA: 0x44F3D0 Offset: 0x44F4D1 VA: 0x44F3D0
	// RVA: 0x2F1ABD0 Offset: 0x2F1ACD1 VA: 0x2F1ABD0
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[TypeInferenceRuleAttribute] // RVA: 0x44F440 Offset: 0x44F541 VA: 0x44F440
	// RVA: 0x2F222C0 Offset: 0x2F223C1 VA: 0x2F222C0
	public Component GetComponentInChildren(Type type) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44F460 Offset: 0x44F561 VA: 0x44F460
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5100 Offset: 0x22B5201 VA: 0x22B5100
	|-GameObject.GetComponentInChildren<AmiiboMenuContent>
	|-GameObject.GetComponentInChildren<DragonRideEventFader>
	|-GameObject.GetComponentInChildren<EffectShoot>
	|-GameObject.GetComponentInChildren<EmittersConstraint>
	|-GameObject.GetComponentInChildren<EngageParameters>
	|-GameObject.GetComponentInChildren<FishingEventFader>
	|-GameObject.GetComponentInChildren<Flipbook>
	|-GameObject.GetComponentInChildren<HubUnitController>
	|-GameObject.GetComponentInChildren<Image>
	|-GameObject.GetComponentInChildren<Iron19CharacterFader>
	|-GameObject.GetComponentInChildren<MapInfoRoot>
	|-GameObject.GetComponentInChildren<MeshFilter>
	|-GameObject.GetComponentInChildren<MyRoomFadeRender>
	|-GameObject.GetComponentInChildren<object>
	|-GameObject.GetComponentInChildren<ParticleSystem>
	|-GameObject.GetComponentInChildren<RawImage>
	|-GameObject.GetComponentInChildren<RelayStamp>
	|-GameObject.GetComponentInChildren<SkinnedMeshRenderer>
	|-GameObject.GetComponentInChildren<SpringManager>
	|-GameObject.GetComponentInChildren<TelopInstance>
	|-GameObject.GetComponentInChildren<TextMeshProUGUI>
	|-GameObject.GetComponentInChildren<Dropdown.DropdownItem>
	|-GameObject.GetComponentInChildren<TMP_Dropdown.DropdownItem>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5120 Offset: 0x22B5221 VA: 0x22B5120
	|-GameObject.GetComponentInChildren<MeshFilter>
	|-GameObject.GetComponentInChildren<object>
	*/

	[FreeFunctionAttribute] // RVA: 0x44F470 Offset: 0x44F571 VA: 0x44F470
	[TypeInferenceRuleAttribute] // RVA: 0x44F470 Offset: 0x44F571 VA: 0x44F470
	// RVA: 0x2F22320 Offset: 0x2F22421 VA: 0x2F22320
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[TypeInferenceRuleAttribute] // RVA: 0x44F4E0 Offset: 0x44F5E1 VA: 0x44F4E0
	// RVA: 0x2F1ACB0 Offset: 0x2F1ADB1 VA: 0x2F1ACB0
	public Component GetComponentInParent(Type type) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44F500 Offset: 0x44F601 VA: 0x44F500
	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5200 Offset: 0x22B5301 VA: 0x22B5200
	|-GameObject.GetComponentInParent<MapObject>
	|-GameObject.GetComponentInParent<object>
	|-GameObject.GetComponentInParent<SkinQualityLodAdjuster>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5220 Offset: 0x22B5321 VA: 0x22B5220
	|-GameObject.GetComponentInParent<object>
	*/

	[FreeFunctionAttribute] // RVA: 0x44F510 Offset: 0x44F611 VA: 0x44F510
	// RVA: 0x2F22380 Offset: 0x2F22481 VA: 0x2F22380
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x2F22410 Offset: 0x2F22511 VA: 0x2F22410
	public Component[] GetComponents(Type type) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5300 Offset: 0x22B5401 VA: 0x22B5300
	|-GameObject.GetComponents<AkGameObj>
	|-GameObject.GetComponents<AkTriggerHandler>
	|-GameObject.GetComponents<Component>
	|-GameObject.GetComponents<DynamicsNull>
	|-GameObject.GetComponents<INotificationReceiver>
	|-GameObject.GetComponents<object>
	*/

	// RVA: 0x2F224D0 Offset: 0x2F225D1 VA: 0x2F224D0
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B53F0 Offset: 0x22B54F1 VA: 0x22B53F0
	|-GameObject.GetComponents<Component>
	|-GameObject.GetComponents<object>
	|-GameObject.GetComponents<Volume>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x44F560 Offset: 0x44F661 VA: 0x44F560
	// RVA: 0x2F22540 Offset: 0x2F22641 VA: 0x2F22540
	public Component[] GetComponentsInChildren(Type type) { }

	// RVA: 0x2F22600 Offset: 0x2F22701 VA: 0x2F22600
	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B54C0 Offset: 0x22B55C1 VA: 0x22B54C0
	|-GameObject.GetComponentsInChildren<DynamicsNull>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	|-GameObject.GetComponentsInChildren<SpringBone>
	|-GameObject.GetComponentsInChildren<SpringCapsuleCollider>
	|-GameObject.GetComponentsInChildren<SpringManager>
	|-GameObject.GetComponentsInChildren<SpringPanelCollider>
	|-GameObject.GetComponentsInChildren<SpringSphereCollider>
	|-GameObject.GetComponentsInChildren<TMP_Text>
	|-GameObject.GetComponentsInChildren<Transform>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B55D0 Offset: 0x22B56D1 VA: 0x22B55D0
	|-GameObject.GetComponentsInChildren<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B54A0 Offset: 0x22B55A1 VA: 0x22B54A0
	|-GameObject.GetComponentsInChildren<CharacterJoint>
	|-GameObject.GetComponentsInChildren<HubAccess>
	|-GameObject.GetComponentsInChildren<ISpringManager>
	|-GameObject.GetComponentsInChildren<LookAtIK>
	|-GameObject.GetComponentsInChildren<MeshRenderer>
	|-GameObject.GetComponentsInChildren<object>
	|-GameObject.GetComponentsInChildren<ParticleSystem>
	|-GameObject.GetComponentsInChildren<RectTransform>
	|-GameObject.GetComponentsInChildren<Renderer>
	|-GameObject.GetComponentsInChildren<SkinnedMeshRenderer>
	|-GameObject.GetComponentsInChildren<TalkCharacterController>
	|-GameObject.GetComponentsInChildren<TextMeshProUGUI>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B55B0 Offset: 0x22B56B1 VA: 0x22B55B0
	|-GameObject.GetComponentsInChildren<object>
	*/

	[ExcludeFromDocsAttribute] // RVA: 0x44F570 Offset: 0x44F671 VA: 0x44F570
	// RVA: 0x2F226C0 Offset: 0x2F227C1 VA: 0x2F226C0
	public Component[] GetComponentsInParent(Type type) { }

	// RVA: 0x2F22780 Offset: 0x2F22881 VA: 0x2F22780
	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5790 Offset: 0x22B5891 VA: 0x22B5790
	|-GameObject.GetComponentsInParent<Canvas>
	|-GameObject.GetComponentsInParent<object>
	|-GameObject.GetComponentsInParent<RectMask2D>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B56A0 Offset: 0x22B57A1 VA: 0x22B56A0
	|-GameObject.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5680 Offset: 0x22B5781 VA: 0x22B5680
	|-GameObject.GetComponentsInParent<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5840 Offset: 0x22B5941 VA: 0x22B5840
	|-GameObject.TryGetComponent<Animator>
	|-GameObject.TryGetComponent<Camera>
	|-GameObject.TryGetComponent<Canvas>
	|-GameObject.TryGetComponent<CanvasGroup>
	|-GameObject.TryGetComponent<CanvasManager>
	|-GameObject.TryGetComponent<CanvasScaler>
	|-GameObject.TryGetComponent<Character>
	|-GameObject.TryGetComponent<CombatGaugeController>
	|-GameObject.TryGetComponent<DebugUIHandlerColor>
	|-GameObject.TryGetComponent<DebugUIHandlerToggle>
	|-GameObject.TryGetComponent<DebugWindow>
	|-GameObject.TryGetComponent<HelpItemCharaName>
	|-GameObject.TryGetComponent<HelpItemGodName>
	|-GameObject.TryGetComponent<HelpItemSkill>
	|-GameObject.TryGetComponent<HelpItemUnitItem>
	|-GameObject.TryGetComponent<HubControlMouthSing>
	|-GameObject.TryGetComponent<HubLookAtController>
	|-GameObject.TryGetComponent<HubMiniMap>
	|-GameObject.TryGetComponent<IPaintGetter>
	|-GameObject.TryGetComponent<Image>
	|-GameObject.TryGetComponent<MapBattleInfoSequence>
	|-GameObject.TryGetComponent<MapObject>
	|-GameObject.TryGetComponent<MeshFilter>
	|-GameObject.TryGetComponent<MeshRenderer>
	|-GameObject.TryGetComponent<MiniMapController>
	|-GameObject.TryGetComponent<NavMeshAgent>
	|-GameObject.TryGetComponent<object>
	|-GameObject.TryGetComponent<ParticleBugfixComponent>
	|-GameObject.TryGetComponent<SpringJobManager>
	|-GameObject.TryGetComponent<TalkCharacterSignal>
	|-GameObject.TryGetComponent<TextMeshAnimation>
	|-GameObject.TryGetComponent<TextMeshProUGUI>
	|-GameObject.TryGetComponent<UnitActor>
	|-GameObject.TryGetComponent<UnitMenuItemSetter>
	|-GameObject.TryGetComponent<UniversalAdditionalCameraData>
	|-GameObject.TryGetComponent<UniversalAdditionalLightData>
	|-GameObject.TryGetComponent<FoodstuffMenuContent.CursorController>
	*/

	// RVA: 0x2F22840 Offset: 0x2F22941 VA: 0x2F22840
	public bool TryGetComponent(Type type, out Component component) { }

	[TypeInferenceRuleAttribute] // RVA: 0x44F580 Offset: 0x44F681 VA: 0x44F580
	[FreeFunctionAttribute] // RVA: 0x44F580 Offset: 0x44F681 VA: 0x44F580
	// RVA: 0x2F22900 Offset: 0x2F22A01 VA: 0x2F22900
	internal Component TryGetComponentInternal(Type type) { }

	[FreeFunctionAttribute] // RVA: 0x44F5F0 Offset: 0x44F6F1 VA: 0x44F5F0
	[NativeWritableSelfAttribute] // RVA: 0x44F5F0 Offset: 0x44F6F1 VA: 0x44F5F0
	// RVA: 0x2F22950 Offset: 0x2F22A51 VA: 0x2F22950
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x2F229B0 Offset: 0x2F22AB1 VA: 0x2F229B0
	public static GameObject FindWithTag(string tag) { }

	// RVA: 0x2F22A50 Offset: 0x2F22B51 VA: 0x2F22A50
	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	// RVA: 0x2F22B20 Offset: 0x2F22C21 VA: 0x2F22B20
	public void SendMessage(string methodName, SendMessageOptions options) { }

	// RVA: 0x2F22BF0 Offset: 0x2F22CF1 VA: 0x2F22BF0
	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunctionAttribute] // RVA: 0x44F650 Offset: 0x44F751 VA: 0x44F650
	// RVA: 0x2F22CC0 Offset: 0x2F22DC1 VA: 0x2F22CC0
	internal Component AddComponentInternal(string className) { }

	[FreeFunctionAttribute] // RVA: 0x44F6A0 Offset: 0x44F7A1 VA: 0x44F6A0
	// RVA: 0x2F22D10 Offset: 0x2F22E11 VA: 0x2F22D10
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRuleAttribute] // RVA: 0x44F6F0 Offset: 0x44F7F1 VA: 0x44F6F0
	// RVA: 0x2F22D60 Offset: 0x2F22E61 VA: 0x2F22D60
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4F40 Offset: 0x22B5041 VA: 0x22B4F40
	|-GameObject.AddComponent<AkGameObj>
	|-GameObject.AddComponent<AnimalAccessCamera>
	|-GameObject.AddComponent<Animation>
	|-GameObject.AddComponent<Animator>
	|-GameObject.AddComponent<BakedMesh>
	|-GameObject.AddComponent<BaseInput>
	|-GameObject.AddComponent<BlinkMonoBehaviour>
	|-GameObject.AddComponent<BoxCollider>
	|-GameObject.AddComponent<Button>
	|-GameObject.AddComponent<Canvas>
	|-GameObject.AddComponent<CanvasRenderer>
	|-GameObject.AddComponent<CanvasScaler>
	|-GameObject.AddComponent<CharacterJoint>
	|-GameObject.AddComponent<CharacterLyingHorse>
	|-GameObject.AddComponent<CharacterLyingHuman>
	|-GameObject.AddComponent<CharacterLyingPegasus>
	|-GameObject.AddComponent<CharacterSignal>
	|-GameObject.AddComponent<CharacterSound>
	|-GameObject.AddComponent<CinemachineComposer>
	|-GameObject.AddComponent<CinemachineOrbitalTransposer>
	|-GameObject.AddComponent<CinemachinePipeline>
	|-GameObject.AddComponent<CinemachineVirtualCamera>
	|-GameObject.AddComponent<CommonRingController>
	|-GameObject.AddComponent<CustomOffscreenCamera>
	|-GameObject.AddComponent<Dropdown>
	|-GameObject.AddComponent<DynamicsNull>
	|-GameObject.AddComponent<EffectHandle>
	|-GameObject.AddComponent<EventCharacterLookAtController>
	|-GameObject.AddComponent<EventCharacterSimpleAnimation>
	|-GameObject.AddComponent<EventSystem>
	|-GameObject.AddComponent<FieldGrid>
	|-GameObject.AddComponent<FlareLayer>
	|-GameObject.AddComponent<GmapMenuContent>
	|-GameObject.AddComponent<GraphicRaycaster>
	|-GameObject.AddComponent<GridLayoutGroup>
	|-GameObject.AddComponent<HUDPopupGroup>
	|-GameObject.AddComponent<HorizontalLayoutGroup>
	|-GameObject.AddComponent<HubAccess>
	|-GameObject.AddComponent<HubAnimalController>
	|-GameObject.AddComponent<HubControlMouthSing>
	|-GameObject.AddComponent<HubFruitsController>
	|-GameObject.AddComponent<HubLensFlare>
	|-GameObject.AddComponent<HubLookAtController>
	|-GameObject.AddComponent<HubMascotCamera>
	|-GameObject.AddComponent<HubMascotController>
	|-GameObject.AddComponent<HubMenuContent>
	|-GameObject.AddComponent<HubMiniMap>
	|-GameObject.AddComponent<HubPlayTalkAfterMenuContent>
	|-GameObject.AddComponent<HubUnitController>
	|-GameObject.AddComponent<Image>
	|-GameObject.AddComponent<InputField>
	|-GameObject.AddComponent<Iron19CharacterSuperEngage>
	|-GameObject.AddComponent<LODGroup>
	|-GameObject.AddComponent<LayoutElement>
	|-GameObject.AddComponent<MagicSignalProcessor>
	|-GameObject.AddComponent<MainThreadDispatcher>
	|-GameObject.AddComponent<Mask>
	|-GameObject.AddComponent<MeshFilter>
	|-GameObject.AddComponent<MeshRenderer>
	|-GameObject.AddComponent<NavMeshAgent>
	|-GameObject.AddComponent<object>
	|-GameObject.AddComponent<ObservableDestroyTrigger>
	|-GameObject.AddComponent<Outline>
	|-GameObject.AddComponent<RawImage>
	|-GameObject.AddComponent<RectMask2D>
	|-GameObject.AddComponent<RectTransform>
	|-GameObject.AddComponent<ReflectionCamera>
	|-GameObject.AddComponent<ReflectionCamera>
	|-GameObject.AddComponent<RelayMapMenuContent>
	|-GameObject.AddComponent<RelayModeMenuContent>
	|-GameObject.AddComponent<Renderer>
	|-GameObject.AddComponent<Rigidbody>
	|-GameObject.AddComponent<ScrollRect>
	|-GameObject.AddComponent<Scrollbar>
	|-GameObject.AddComponent<Slider>
	|-GameObject.AddComponent<SphereCollider>
	|-GameObject.AddComponent<SpringBone>
	|-GameObject.AddComponent<SpringBonePivot>
	|-GameObject.AddComponent<SpringCapsuleCollider>
	|-GameObject.AddComponent<SpringCollider>
	|-GameObject.AddComponent<SpringJobManager>
	|-GameObject.AddComponent<SpringJobScheduler>
	|-GameObject.AddComponent<SpringManager>
	|-GameObject.AddComponent<SpringPanelCollider>
	|-GameObject.AddComponent<SpringSphereCollider>
	|-GameObject.AddComponent<StandaloneInputModule>
	|-GameObject.AddComponent<StandaloneInputModule18>
	|-GameObject.AddComponent<TMP_Dropdown>
	|-GameObject.AddComponent<TMP_InputField>
	|-GameObject.AddComponent<TMP_SpriteAnimator>
	|-GameObject.AddComponent<TMP_SubMeshUI>
	|-GameObject.AddComponent<TalkCharacterController>
	|-GameObject.AddComponent<Text>
	|-GameObject.AddComponent<TextMesh>
	|-GameObject.AddComponent<TextMeshProUGUI>
	|-GameObject.AddComponent<Toggle>
	|-GameObject.AddComponent<TriggerEventBroadcaster>
	|-GameObject.AddComponent<UnitSignal>
	|-GameObject.AddComponent<UniversalAdditionalCameraData>
	|-GameObject.AddComponent<VRIKRootController>
	|-GameObject.AddComponent<VersusFriendMenuContent>
	|-GameObject.AddComponent<VersusMapMenuContent>
	|-GameObject.AddComponent<VersusMyInfoContent>
	|-GameObject.AddComponent<VersusProfileMenuContent>
	|-GameObject.AddComponent<VersusTopMenuContent>
	|-GameObject.AddComponent<VerticalLayoutGroup>
	|-GameObject.AddComponent<Volume>
	|-GameObject.AddComponent<WeaponFlying>
	|-GameObject.AddComponent<Dropdown.DropdownItem>
	|-GameObject.AddComponent<EffectController.AutoDelete>
	|-GameObject.AddComponent<FaceImagesController.ReturnEntryComponent>
	|-GameObject.AddComponent<FoodstuffMenuContent.CursorController>
	|-GameObject.AddComponent<SpringJobScheduler.OriginalWindForceProvider>
	|-GameObject.AddComponent<TMP_Dropdown.DropdownItem>
	|-GameObject.AddComponent<GmapSequence.GmapFreeCameraSequence.SelfDestroy>
	|-GameObject.AddComponent<RingListSequence.GodAndRingListWindow.MenuContent>
	|-GameObject.AddComponent<RingListSequence.GodAndRingListWindow.MenuItemContent>
	*/

	[FreeFunctionAttribute] // RVA: 0x44F710 Offset: 0x44F811 VA: 0x44F710
	// RVA: 0x2F22DB0 Offset: 0x2F22EB1 VA: 0x2F22DB0
	public Transform get_transform() { }

	// RVA: 0x2F22E00 Offset: 0x2F22F01 VA: 0x2F22E00
	public int get_layer() { }

	// RVA: 0x2F22E50 Offset: 0x2F22F51 VA: 0x2F22E50
	public void set_layer(int value) { }

	[NativeMethodAttribute] // RVA: 0x44F760 Offset: 0x44F861 VA: 0x44F760
	// RVA: 0x2F22EA0 Offset: 0x2F22FA1 VA: 0x2F22EA0
	public bool get_active() { }

	[NativeMethodAttribute] // RVA: 0x44F7B0 Offset: 0x44F8B1 VA: 0x44F7B0
	// RVA: 0x2F22EF0 Offset: 0x2F22FF1 VA: 0x2F22EF0
	public void set_active(bool value) { }

	[NativeMethodAttribute] // RVA: 0x44F800 Offset: 0x44F901 VA: 0x44F800
	// RVA: 0x2F22F40 Offset: 0x2F23041 VA: 0x2F22F40
	public void SetActive(bool value) { }

	[NativeMethodAttribute] // RVA: 0x44F850 Offset: 0x44F951 VA: 0x44F850
	// RVA: 0x2F22F90 Offset: 0x2F23091 VA: 0x2F22F90
	public bool get_activeSelf() { }

	[NativeMethodAttribute] // RVA: 0x44F8A0 Offset: 0x44F9A1 VA: 0x44F8A0
	// RVA: 0x2F22FE0 Offset: 0x2F230E1 VA: 0x2F22FE0
	public bool get_activeInHierarchy() { }

	[ObsoleteAttribute] // RVA: 0x44F8F0 Offset: 0x44F9F1 VA: 0x44F8F0
	[NativeMethodAttribute] // RVA: 0x44F8F0 Offset: 0x44F9F1 VA: 0x44F8F0
	// RVA: 0x2F23030 Offset: 0x2F23131 VA: 0x2F23030
	public void SetActiveRecursively(bool state) { }

	[NativeMethodAttribute] // RVA: 0x44F960 Offset: 0x44FA61 VA: 0x44F960
	// RVA: 0x2F23080 Offset: 0x2F23181 VA: 0x2F23080
	public bool get_isStatic() { }

	[NativeMethodAttribute] // RVA: 0x44F9B0 Offset: 0x44FAB1 VA: 0x44F9B0
	// RVA: 0x2F230D0 Offset: 0x2F231D1 VA: 0x2F230D0
	public void set_isStatic(bool value) { }

	[NativeMethodAttribute] // RVA: 0x44FA00 Offset: 0x44FB01 VA: 0x44FA00
	// RVA: 0x2F23120 Offset: 0x2F23221 VA: 0x2F23120
	internal bool get_isStaticBatchable() { }

	[FreeFunctionAttribute] // RVA: 0x44FA50 Offset: 0x44FB51 VA: 0x44FA50
	// RVA: 0x2F1AE50 Offset: 0x2F1AF51 VA: 0x2F1AE50
	public string get_tag() { }

	[FreeFunctionAttribute] // RVA: 0x44FAA0 Offset: 0x44FBA1 VA: 0x44FAA0
	// RVA: 0x2F1AF20 Offset: 0x2F1B021 VA: 0x2F1AF20
	public void set_tag(string value) { }

	[FreeFunctionAttribute] // RVA: 0x44FAF0 Offset: 0x44FBF1 VA: 0x44FAF0
	// RVA: 0x2F1AFF0 Offset: 0x2F1B0F1 VA: 0x2F1AFF0
	public bool CompareTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0x44FB40 Offset: 0x44FC41 VA: 0x44FB40
	// RVA: 0x2F22A00 Offset: 0x2F22B01 VA: 0x2F22A00
	public static GameObject FindGameObjectWithTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0x44FB90 Offset: 0x44FC91 VA: 0x44FB90
	// RVA: 0x2F23170 Offset: 0x2F23271 VA: 0x2F23170
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	[FreeFunctionAttribute] // RVA: 0x44FBE0 Offset: 0x44FCE1 VA: 0x44FBE0
	// RVA: 0x2F22AB0 Offset: 0x2F22BB1 VA: 0x2F22AB0
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44FC30 Offset: 0x44FD31 VA: 0x44FC30
	// RVA: 0x2F231C0 Offset: 0x2F232C1 VA: 0x2F231C0
	public void SendMessageUpwards(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44FC40 Offset: 0x44FD41 VA: 0x44FC40
	// RVA: 0x2F23220 Offset: 0x2F23321 VA: 0x2F23220
	public void SendMessageUpwards(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x44FC50 Offset: 0x44FD51 VA: 0x44FC50
	// RVA: 0x2F22B80 Offset: 0x2F22C81 VA: 0x2F22B80
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44FCA0 Offset: 0x44FDA1 VA: 0x44FCA0
	// RVA: 0x2F23280 Offset: 0x2F23381 VA: 0x2F23280
	public void SendMessage(string methodName, object value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44FCB0 Offset: 0x44FDB1 VA: 0x44FCB0
	// RVA: 0x2F232E0 Offset: 0x2F233E1 VA: 0x2F232E0
	public void SendMessage(string methodName) { }

	[FreeFunctionAttribute] // RVA: 0x44FCC0 Offset: 0x44FDC1 VA: 0x44FCC0
	// RVA: 0x2F22C50 Offset: 0x2F22D51 VA: 0x2F22C50
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44FD10 Offset: 0x44FE11 VA: 0x44FD10
	// RVA: 0x2F23340 Offset: 0x2F23441 VA: 0x2F23340
	public void BroadcastMessage(string methodName, object parameter) { }

	[ExcludeFromDocsAttribute] // RVA: 0x44FD20 Offset: 0x44FE21 VA: 0x44FD20
	// RVA: 0x2F233A0 Offset: 0x2F234A1 VA: 0x2F233A0
	public void BroadcastMessage(string methodName) { }

	// RVA: 0x2F23400 Offset: 0x2F23501 VA: 0x2F23400
	public void .ctor(string name) { }

	// RVA: 0x2F234F0 Offset: 0x2F235F1 VA: 0x2F234F0
	public void .ctor() { }

	// RVA: 0x2F23590 Offset: 0x2F23691 VA: 0x2F23590
	public void .ctor(string name, Type[] components) { }

	[FreeFunctionAttribute] // RVA: 0x44FD30 Offset: 0x44FE31 VA: 0x44FD30
	// RVA: 0x2F234A0 Offset: 0x2F235A1 VA: 0x2F234A0
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunctionAttribute] // RVA: 0x44FD80 Offset: 0x44FE81 VA: 0x44FD80
	// RVA: 0x2F236C0 Offset: 0x2F237C1 VA: 0x2F236C0
	public static GameObject Find(string name) { }

	[FreeFunctionAttribute] // RVA: 0x44FDD0 Offset: 0x44FED1 VA: 0x44FDD0
	// RVA: 0x2F23710 Offset: 0x2F23811 VA: 0x2F23710
	public Scene get_scene() { }

	[FreeFunctionAttribute] // RVA: 0x44FE20 Offset: 0x44FF21 VA: 0x44FE20
	// RVA: 0x2F237C0 Offset: 0x2F238C1 VA: 0x2F237C0
	public ulong get_sceneCullingMask() { }

	// RVA: 0x2F23810 Offset: 0x2F23911 VA: 0x2F23810
	public GameObject get_gameObject() { }

	// RVA: 0x2F23770 Offset: 0x2F23871 VA: 0x2F23770
	private void get_scene_Injected(out Scene ret) { }
}

