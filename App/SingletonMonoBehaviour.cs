// Namespace: App
public class SingletonMonoBehaviour<T> : MonoBehaviour // TypeDefIndex: 9216
{
	// Fields
	private static T s_Instance; // 0x0
	private BindHolder m_Binder; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343AA30 Offset: 0x343AB31 VA: 0x343AA30
	|-SingletonMonoBehaviour<AdhocAssetLoader>.get_Instance
	|-SingletonMonoBehaviour<BmapCamera>.get_Instance
	|-SingletonMonoBehaviour<CameraManager>.get_Instance
	|-SingletonMonoBehaviour<EffectCatalog>.get_Instance
	|-SingletonMonoBehaviour<Framework>.get_Instance
	|-SingletonMonoBehaviour<GameUI>.get_Instance
	|-SingletonMonoBehaviour<GmapCamera>.get_Instance
	|-SingletonMonoBehaviour<GroundOverlap>.get_Instance
	|-SingletonMonoBehaviour<HelpManager>.get_Instance
	|-SingletonMonoBehaviour<HubEffectCatalog>.get_Instance
	|-SingletonMonoBehaviour<LoadingLogo>.get_Instance
	|-SingletonMonoBehaviour<Logo>.get_Instance
	|-SingletonMonoBehaviour<MapBoundingManager>.get_Instance
	|-SingletonMonoBehaviour<MapCollisions>.get_Instance
	|-SingletonMonoBehaviour<MapEditor>.get_Instance
	|-SingletonMonoBehaviour<MapEnvironment>.get_Instance
	|-SingletonMonoBehaviour<MapFadeManager>.get_Instance
	|-SingletonMonoBehaviour<MapGridRender>.get_Instance
	|-SingletonMonoBehaviour<MapInfoCircle>.get_Instance
	|-SingletonMonoBehaviour<MapInfoUnit>.get_Instance
	|-SingletonMonoBehaviour<MapPanelActive>.get_Instance
	|-SingletonMonoBehaviour<MapPanelDanger>.get_Instance
	|-SingletonMonoBehaviour<MapPanelDangerAll>.get_Instance
	|-SingletonMonoBehaviour<MapPanelDeploy>.get_Instance
	|-SingletonMonoBehaviour<MapPanelGimmick>.get_Instance
	|-SingletonMonoBehaviour<MapPanelRoute>.get_Instance
	|-SingletonMonoBehaviour<MapPanelSortie>.get_Instance
	|-SingletonMonoBehaviour<MapPanelTarget>.get_Instance
	|-SingletonMonoBehaviour<MapProjection>.get_Instance
	|-SingletonMonoBehaviour<MapSetting>.get_Instance
	|-SingletonMonoBehaviour<MapUI>.get_Instance
	|-SingletonMonoBehaviour<MapUIGauge>.get_Instance
	|-SingletonMonoBehaviour<MapUIIcon>.get_Instance
	|-SingletonMonoBehaviour<NoticeManager>.get_Instance
	|-SingletonMonoBehaviour<object>.get_Instance
	|-SingletonMonoBehaviour<PostProcessManager>.get_Instance
	|-SingletonMonoBehaviour<PublicObject>.get_Instance
	|-SingletonMonoBehaviour<RelayReplayPlayerName>.get_Instance
	|-SingletonMonoBehaviour<ResourceCache>.get_Instance
	|-SingletonMonoBehaviour<SkipIndicator>.get_Instance
	|-SingletonMonoBehaviour<SkyCastle>.get_Instance
	|-SingletonMonoBehaviour<SoundManager>.get_Instance
	|-SingletonMonoBehaviour<TalkCharacterManager>.get_Instance
	|-SingletonMonoBehaviour<TalkLog>.get_Instance
	|-SingletonMonoBehaviour<TalkUI>.get_Instance
	|-SingletonMonoBehaviour<TelopManager>.get_Instance
	|-SingletonMonoBehaviour<UnitActors>.get_Instance
	|-SingletonMonoBehaviour<WindManager>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343AB60 Offset: 0x343AC61 VA: 0x343AB60
	|-SingletonMonoBehaviour<AdhocAssetLoader>.Awake
	|-SingletonMonoBehaviour<BmapCamera>.Awake
	|-SingletonMonoBehaviour<CameraController>.Awake
	|-SingletonMonoBehaviour<CameraManager>.Awake
	|-SingletonMonoBehaviour<DebugGpuStats>.Awake
	|-SingletonMonoBehaviour<DebugLodCrossFade>.Awake
	|-SingletonMonoBehaviour<DebugLodVisualizer>.Awake
	|-SingletonMonoBehaviour<DebugMipmapVisualizer>.Awake
	|-SingletonMonoBehaviour<DebugMonitor>.Awake
	|-SingletonMonoBehaviour<DebugOverlap>.Awake
	|-SingletonMonoBehaviour<EffectCatalog>.Awake
	|-SingletonMonoBehaviour<Framework>.Awake
	|-SingletonMonoBehaviour<GameUI>.Awake
	|-SingletonMonoBehaviour<GmapCamera>.Awake
	|-SingletonMonoBehaviour<GroundOverlap>.Awake
	|-SingletonMonoBehaviour<HelpManager>.Awake
	|-SingletonMonoBehaviour<HubEffectCatalog>.Awake
	|-SingletonMonoBehaviour<LoadingLogo>.Awake
	|-SingletonMonoBehaviour<Logo>.Awake
	|-SingletonMonoBehaviour<MapBattleDebug>.Awake
	|-SingletonMonoBehaviour<MapBattleInfo>.Awake
	|-SingletonMonoBehaviour<MapBoundingManager>.Awake
	|-SingletonMonoBehaviour<MapCollisions>.Awake
	|-SingletonMonoBehaviour<MapEditor>.Awake
	|-SingletonMonoBehaviour<MapEnvironment>.Awake
	|-SingletonMonoBehaviour<MapFadeManager>.Awake
	|-SingletonMonoBehaviour<MapGridRender>.Awake
	|-SingletonMonoBehaviour<MapInfoCircle>.Awake
	|-SingletonMonoBehaviour<MapInfoDebug>.Awake
	|-SingletonMonoBehaviour<MapInfoTerrain>.Awake
	|-SingletonMonoBehaviour<MapInfoUnit>.Awake
	|-SingletonMonoBehaviour<MapProjection>.Awake
	|-SingletonMonoBehaviour<MapResources>.Awake
	|-SingletonMonoBehaviour<MapSandBox>.Awake
	|-SingletonMonoBehaviour<MapSetting>.Awake
	|-SingletonMonoBehaviour<MapShadow>.Awake
	|-SingletonMonoBehaviour<MapUI>.Awake
	|-SingletonMonoBehaviour<MapUIGauge>.Awake
	|-SingletonMonoBehaviour<MapUIIcon>.Awake
	|-SingletonMonoBehaviour<NoticeManager>.Awake
	|-SingletonMonoBehaviour<object>.Awake
	|-SingletonMonoBehaviour<PostProcessManager>.Awake
	|-SingletonMonoBehaviour<PublicObject>.Awake
	|-SingletonMonoBehaviour<RelayReplayPlayerName>.Awake
	|-SingletonMonoBehaviour<ResourceCache>.Awake
	|-SingletonMonoBehaviour<ScreenShot>.Awake
	|-SingletonMonoBehaviour<SkipIndicator>.Awake
	|-SingletonMonoBehaviour<SkyCastle>.Awake
	|-SingletonMonoBehaviour<SoundManager>.Awake
	|-SingletonMonoBehaviour<TalkCharacterManager>.Awake
	|-SingletonMonoBehaviour<TalkLog>.Awake
	|-SingletonMonoBehaviour<TalkUI>.Awake
	|-SingletonMonoBehaviour<TelopManager>.Awake
	|-SingletonMonoBehaviour<UnitActors>.Awake
	|-SingletonMonoBehaviour<WindManager>.Awake
	*/

	// RVA: -1 Offset: -1
	public static GameObject Find(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343AD80 Offset: 0x343AE81 VA: 0x343AD80
	|-SingletonMonoBehaviour<MapResources>.Find
	|-SingletonMonoBehaviour<object>.Find
	|-SingletonMonoBehaviour<SoundManager>.Find
	*/

	// RVA: -1 Offset: -1
	public static C Find<C>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2554F10 Offset: 0x2555011 VA: 0x2554F10
	|-SingletonMonoBehaviour<object>.Find<object>
	*/

	// RVA: -1 Offset: -1
	public static void Bind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343B090 Offset: 0x343B191 VA: 0x343B090
	|-SingletonMonoBehaviour<CameraController>.Bind
	|-SingletonMonoBehaviour<NoticeManager>.Bind
	|-SingletonMonoBehaviour<object>.Bind
	*/

	// RVA: -1 Offset: -1
	public static void Unbind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343B380 Offset: 0x343B481 VA: 0x343B380
	|-SingletonMonoBehaviour<CameraController>.Unbind
	|-SingletonMonoBehaviour<NoticeManager>.Unbind
	|-SingletonMonoBehaviour<object>.Unbind
	*/

	// RVA: -1 Offset: -1
	public static bool IsBind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343B670 Offset: 0x343B771 VA: 0x343B670
	|-SingletonMonoBehaviour<CameraController>.IsBind
	|-SingletonMonoBehaviour<GmapCamera>.IsBind
	|-SingletonMonoBehaviour<LoadingLogo>.IsBind
	|-SingletonMonoBehaviour<NoticeManager>.IsBind
	|-SingletonMonoBehaviour<object>.IsBind
	*/

	// RVA: -1 Offset: -1
	public static GameObject TryCreateInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343B970 Offset: 0x343BA71 VA: 0x343B970
	|-SingletonMonoBehaviour<object>.TryCreateInstance
	|-SingletonMonoBehaviour<UnitActors>.TryCreateInstance
	*/

	// RVA: -1 Offset: -1
	public static void TryDeleteInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343BD60 Offset: 0x343BE61 VA: 0x343BD60
	|-SingletonMonoBehaviour<MapCollisions>.TryDeleteInstance
	|-SingletonMonoBehaviour<MapResources>.TryDeleteInstance
	|-SingletonMonoBehaviour<object>.TryDeleteInstance
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetGameObejct() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C070 Offset: 0x343C171 VA: 0x343C070
	|-SingletonMonoBehaviour<object>.GetGameObejct
	|-SingletonMonoBehaviour<TelopManager>.GetGameObejct
	*/

	// RVA: -1 Offset: -1
	public static bool op_Implicit(SingletonMonoBehaviour<T> exists) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C240 Offset: 0x343C341 VA: 0x343C240
	|-SingletonMonoBehaviour<BmapCamera>.op_Implicit
	|-SingletonMonoBehaviour<MapEnvironment>.op_Implicit
	|-SingletonMonoBehaviour<MapPanelGimmick>.op_Implicit
	|-SingletonMonoBehaviour<MapProjection>.op_Implicit
	|-SingletonMonoBehaviour<MapSetting>.op_Implicit
	|-SingletonMonoBehaviour<object>.op_Implicit
	|-SingletonMonoBehaviour<PostProcessManager>.op_Implicit
	|-SingletonMonoBehaviour<SoundManager>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C2B0 Offset: 0x343C3B1 VA: 0x343C2B0
	|-SingletonMonoBehaviour<AdhocAssetLoader>..ctor
	|-SingletonMonoBehaviour<BmapCamera>..ctor
	|-SingletonMonoBehaviour<CameraController>..ctor
	|-SingletonMonoBehaviour<CameraManager>..ctor
	|-SingletonMonoBehaviour<DebugGpuStats>..ctor
	|-SingletonMonoBehaviour<DebugLodCrossFade>..ctor
	|-SingletonMonoBehaviour<DebugLodVisualizer>..ctor
	|-SingletonMonoBehaviour<DebugMipmapVisualizer>..ctor
	|-SingletonMonoBehaviour<DebugMonitor>..ctor
	|-SingletonMonoBehaviour<DebugOverlap>..ctor
	|-SingletonMonoBehaviour<EffectCatalog>..ctor
	|-SingletonMonoBehaviour<Framework>..ctor
	|-SingletonMonoBehaviour<GameUI>..ctor
	|-SingletonMonoBehaviour<GmapCamera>..ctor
	|-SingletonMonoBehaviour<GroundOverlap>..ctor
	|-SingletonMonoBehaviour<HelpManager>..ctor
	|-SingletonMonoBehaviour<HubEffectCatalog>..ctor
	|-SingletonMonoBehaviour<LoadingLogo>..ctor
	|-SingletonMonoBehaviour<Logo>..ctor
	|-SingletonMonoBehaviour<MapBattleDebug>..ctor
	|-SingletonMonoBehaviour<MapBattleInfo>..ctor
	|-SingletonMonoBehaviour<MapBoundingManager>..ctor
	|-SingletonMonoBehaviour<MapCollisions>..ctor
	|-SingletonMonoBehaviour<MapEditor>..ctor
	|-SingletonMonoBehaviour<MapEnvironment>..ctor
	|-SingletonMonoBehaviour<MapFadeManager>..ctor
	|-SingletonMonoBehaviour<MapGridRender>..ctor
	|-SingletonMonoBehaviour<MapInfoCircle>..ctor
	|-SingletonMonoBehaviour<MapInfoDebug>..ctor
	|-SingletonMonoBehaviour<MapInfoTerrain>..ctor
	|-SingletonMonoBehaviour<MapInfoUnit>..ctor
	|-SingletonMonoBehaviour<MapProjection>..ctor
	|-SingletonMonoBehaviour<MapResources>..ctor
	|-SingletonMonoBehaviour<MapSandBox>..ctor
	|-SingletonMonoBehaviour<MapSetting>..ctor
	|-SingletonMonoBehaviour<MapShadow>..ctor
	|-SingletonMonoBehaviour<MapUI>..ctor
	|-SingletonMonoBehaviour<MapUIGauge>..ctor
	|-SingletonMonoBehaviour<MapUIIcon>..ctor
	|-SingletonMonoBehaviour<NoticeManager>..ctor
	|-SingletonMonoBehaviour<object>..ctor
	|-SingletonMonoBehaviour<PostProcessManager>..ctor
	|-SingletonMonoBehaviour<PublicObject>..ctor
	|-SingletonMonoBehaviour<RelayReplayPlayerName>..ctor
	|-SingletonMonoBehaviour<ResourceCache>..ctor
	|-SingletonMonoBehaviour<ScreenShot>..ctor
	|-SingletonMonoBehaviour<SkipIndicator>..ctor
	|-SingletonMonoBehaviour<SkyCastle>..ctor
	|-SingletonMonoBehaviour<SoundManager>..ctor
	|-SingletonMonoBehaviour<TalkCharacterManager>..ctor
	|-SingletonMonoBehaviour<TalkLog>..ctor
	|-SingletonMonoBehaviour<TalkUI>..ctor
	|-SingletonMonoBehaviour<TelopManager>..ctor
	|-SingletonMonoBehaviour<UnitActors>..ctor
	|-SingletonMonoBehaviour<WindManager>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C330 Offset: 0x343C431 VA: 0x343C330
	|-SingletonMonoBehaviour<object>..cctor
	*/
}

