// Namespace: UniRx.Async.Triggers
[ExtensionAttribute] // RVA: 0x284A0 Offset: 0x285A1 VA: 0x284A0
public static class AsyncTriggerExtensions // TypeDefIndex: 5199
{
	// Methods

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27385D0 Offset: 0x27386D1 VA: 0x27385D0
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncAnimatorTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncAwakeTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncBeginDragTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncCancelTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncCanvasGroupChangedTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncCollision2DTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncCollisionTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncDeselectTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncDestroyTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncDragTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncDropTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncEnableDisableTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncEndDragTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncFixedUpdateTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncInitializePotentialDragTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncJointTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncLateUpdateTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncMouseTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncMoveTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncParticleTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncPointerClickTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncPointerDownTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncPointerEnterTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncPointerExitTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncPointerUpTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncRectTransformTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncScrollTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncSelectTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncStartTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncSubmitTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncTransformChangedTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncTrigger2DTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncTriggerTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncUpdateSelectedTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncUpdateTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<AsyncVisibleTrigger>
	|-AsyncTriggerExtensions.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x2E550 Offset: 0x2E651 VA: 0x2E550
	// RVA: 0x2E7AAE0 Offset: 0x2E7ABE1 VA: 0x2E7AAE0
	public static UniTask OnDestroyAsync(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E560 Offset: 0x2E661 VA: 0x2E560
	// RVA: 0x2E7ABA0 Offset: 0x2E7ACA1 VA: 0x2E7ABA0
	public static UniTask OnDestroyAsync(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E570 Offset: 0x2E671 VA: 0x2E570
	// RVA: 0x2E7AC60 Offset: 0x2E7AD61 VA: 0x2E7AC60
	public static CancellationToken GetCancellationTokenOnDestroy(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E580 Offset: 0x2E681 VA: 0x2E580
	// RVA: 0x2E7AD20 Offset: 0x2E7AE21 VA: 0x2E7AD20
	public static CancellationToken GetCancellationTokenOnDestroy(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E590 Offset: 0x2E691 VA: 0x2E590
	// RVA: 0x2E7ADE0 Offset: 0x2E7AEE1 VA: 0x2E7ADE0
	public static UniTask StartAsync(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E5A0 Offset: 0x2E6A1 VA: 0x2E5A0
	// RVA: 0x2E7AEA0 Offset: 0x2E7AFA1 VA: 0x2E7AEA0
	public static UniTask StartAsync(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E5B0 Offset: 0x2E6B1 VA: 0x2E5B0
	// RVA: 0x2E7AF60 Offset: 0x2E7B061 VA: 0x2E7AF60
	public static UniTask AwakeAsync(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E5C0 Offset: 0x2E6C1 VA: 0x2E5C0
	// RVA: 0x2E7B020 Offset: 0x2E7B121 VA: 0x2E7B020
	public static UniTask AwakeAsync(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E5D0 Offset: 0x2E6D1 VA: 0x2E5D0
	// RVA: 0x2E7B0E0 Offset: 0x2E7B1E1 VA: 0x2E7B0E0
	public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E5E0 Offset: 0x2E6E1 VA: 0x2E5E0
	// RVA: 0x2E7B140 Offset: 0x2E7B241 VA: 0x2E7B140
	public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E5F0 Offset: 0x2E6F1 VA: 0x2E5F0
	// RVA: 0x2E7AFC0 Offset: 0x2E7B0C1 VA: 0x2E7AFC0
	public static AsyncAwakeTrigger GetAsyncAwakeTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E600 Offset: 0x2E701 VA: 0x2E600
	// RVA: 0x2E7B080 Offset: 0x2E7B181 VA: 0x2E7B080
	public static AsyncAwakeTrigger GetAsyncAwakeTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E610 Offset: 0x2E711 VA: 0x2E610
	// RVA: 0x2E7B1A0 Offset: 0x2E7B2A1 VA: 0x2E7B1A0
	public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E620 Offset: 0x2E721 VA: 0x2E620
	// RVA: 0x2E7B200 Offset: 0x2E7B301 VA: 0x2E7B200
	public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E630 Offset: 0x2E731 VA: 0x2E630
	// RVA: 0x2E7B260 Offset: 0x2E7B361 VA: 0x2E7B260
	public static AsyncCancelTrigger GetAsyncCancelTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E640 Offset: 0x2E741 VA: 0x2E640
	// RVA: 0x2E7B2C0 Offset: 0x2E7B3C1 VA: 0x2E7B2C0
	public static AsyncCancelTrigger GetAsyncCancelTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E650 Offset: 0x2E751 VA: 0x2E650
	// RVA: 0x2E7B320 Offset: 0x2E7B421 VA: 0x2E7B320
	public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E660 Offset: 0x2E761 VA: 0x2E660
	// RVA: 0x2E7B380 Offset: 0x2E7B481 VA: 0x2E7B380
	public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E670 Offset: 0x2E771 VA: 0x2E670
	// RVA: 0x2E7B3E0 Offset: 0x2E7B4E1 VA: 0x2E7B3E0
	public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E680 Offset: 0x2E781 VA: 0x2E680
	// RVA: 0x2E7B440 Offset: 0x2E7B541 VA: 0x2E7B440
	public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E690 Offset: 0x2E791 VA: 0x2E690
	// RVA: 0x2E7B4A0 Offset: 0x2E7B5A1 VA: 0x2E7B4A0
	public static AsyncCollisionTrigger GetAsyncCollisionTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E6A0 Offset: 0x2E7A1 VA: 0x2E6A0
	// RVA: 0x2E7B500 Offset: 0x2E7B601 VA: 0x2E7B500
	public static AsyncCollisionTrigger GetAsyncCollisionTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E6B0 Offset: 0x2E7B1 VA: 0x2E6B0
	// RVA: 0x2E7B560 Offset: 0x2E7B661 VA: 0x2E7B560
	public static AsyncDeselectTrigger GetAsyncDeselectTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E6C0 Offset: 0x2E7C1 VA: 0x2E6C0
	// RVA: 0x2E7B5C0 Offset: 0x2E7B6C1 VA: 0x2E7B5C0
	public static AsyncDeselectTrigger GetAsyncDeselectTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E6D0 Offset: 0x2E7D1 VA: 0x2E6D0
	// RVA: 0x2E7AB40 Offset: 0x2E7AC41 VA: 0x2E7AB40
	public static AsyncDestroyTrigger GetAsyncDestroyTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E6E0 Offset: 0x2E7E1 VA: 0x2E6E0
	// RVA: 0x2E7AC00 Offset: 0x2E7AD01 VA: 0x2E7AC00
	public static AsyncDestroyTrigger GetAsyncDestroyTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E6F0 Offset: 0x2E7F1 VA: 0x2E6F0
	// RVA: 0x2E7B620 Offset: 0x2E7B721 VA: 0x2E7B620
	public static AsyncDragTrigger GetAsyncDragTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E700 Offset: 0x2E801 VA: 0x2E700
	// RVA: 0x2E7B680 Offset: 0x2E7B781 VA: 0x2E7B680
	public static AsyncDragTrigger GetAsyncDragTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E710 Offset: 0x2E811 VA: 0x2E710
	// RVA: 0x2E7B6E0 Offset: 0x2E7B7E1 VA: 0x2E7B6E0
	public static AsyncDropTrigger GetAsyncDropTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E720 Offset: 0x2E821 VA: 0x2E720
	// RVA: 0x2E7B740 Offset: 0x2E7B841 VA: 0x2E7B740
	public static AsyncDropTrigger GetAsyncDropTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E730 Offset: 0x2E831 VA: 0x2E730
	// RVA: 0x2E7B7A0 Offset: 0x2E7B8A1 VA: 0x2E7B7A0
	public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E740 Offset: 0x2E841 VA: 0x2E740
	// RVA: 0x2E7B800 Offset: 0x2E7B901 VA: 0x2E7B800
	public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E750 Offset: 0x2E851 VA: 0x2E750
	// RVA: 0x2E7B860 Offset: 0x2E7B961 VA: 0x2E7B860
	public static AsyncEndDragTrigger GetAsyncEndDragTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E760 Offset: 0x2E861 VA: 0x2E760
	// RVA: 0x2E7B8C0 Offset: 0x2E7B9C1 VA: 0x2E7B8C0
	public static AsyncEndDragTrigger GetAsyncEndDragTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E770 Offset: 0x2E871 VA: 0x2E770
	// RVA: 0x2E7B920 Offset: 0x2E7BA21 VA: 0x2E7B920
	public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E780 Offset: 0x2E881 VA: 0x2E780
	// RVA: 0x2E7B980 Offset: 0x2E7BA81 VA: 0x2E7B980
	public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E790 Offset: 0x2E891 VA: 0x2E790
	// RVA: 0x2E7B9E0 Offset: 0x2E7BAE1 VA: 0x2E7B9E0
	public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E7A0 Offset: 0x2E8A1 VA: 0x2E7A0
	// RVA: 0x2E7BA40 Offset: 0x2E7BB41 VA: 0x2E7BA40
	public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E7B0 Offset: 0x2E8B1 VA: 0x2E7B0
	// RVA: 0x2E7BAA0 Offset: 0x2E7BBA1 VA: 0x2E7BAA0
	public static AsyncJointTrigger GetAsyncJointTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E7C0 Offset: 0x2E8C1 VA: 0x2E7C0
	// RVA: 0x2E7BB00 Offset: 0x2E7BC01 VA: 0x2E7BB00
	public static AsyncJointTrigger GetAsyncJointTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E7D0 Offset: 0x2E8D1 VA: 0x2E7D0
	// RVA: 0x2E7BB60 Offset: 0x2E7BC61 VA: 0x2E7BB60
	public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E7E0 Offset: 0x2E8E1 VA: 0x2E7E0
	// RVA: 0x2E7BBC0 Offset: 0x2E7BCC1 VA: 0x2E7BBC0
	public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E7F0 Offset: 0x2E8F1 VA: 0x2E7F0
	// RVA: 0x2E7BC20 Offset: 0x2E7BD21 VA: 0x2E7BC20
	public static AsyncMouseTrigger GetAsyncMouseTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E800 Offset: 0x2E901 VA: 0x2E800
	// RVA: 0x2E7BC80 Offset: 0x2E7BD81 VA: 0x2E7BC80
	public static AsyncMouseTrigger GetAsyncMouseTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E810 Offset: 0x2E911 VA: 0x2E810
	// RVA: 0x2E7BCE0 Offset: 0x2E7BDE1 VA: 0x2E7BCE0
	public static AsyncMoveTrigger GetAsyncMoveTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E820 Offset: 0x2E921 VA: 0x2E820
	// RVA: 0x2E7BD40 Offset: 0x2E7BE41 VA: 0x2E7BD40
	public static AsyncMoveTrigger GetAsyncMoveTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E830 Offset: 0x2E931 VA: 0x2E830
	// RVA: 0x2E7BDA0 Offset: 0x2E7BEA1 VA: 0x2E7BDA0
	public static AsyncParticleTrigger GetAsyncParticleTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E840 Offset: 0x2E941 VA: 0x2E840
	// RVA: 0x2E7BE00 Offset: 0x2E7BF01 VA: 0x2E7BE00
	public static AsyncParticleTrigger GetAsyncParticleTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E850 Offset: 0x2E951 VA: 0x2E850
	// RVA: 0x2E7BE60 Offset: 0x2E7BF61 VA: 0x2E7BE60
	public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E860 Offset: 0x2E961 VA: 0x2E860
	// RVA: 0x2E7BEC0 Offset: 0x2E7BFC1 VA: 0x2E7BEC0
	public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E870 Offset: 0x2E971 VA: 0x2E870
	// RVA: 0x2E7BF20 Offset: 0x2E7C021 VA: 0x2E7BF20
	public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E880 Offset: 0x2E981 VA: 0x2E880
	// RVA: 0x2E7BF80 Offset: 0x2E7C081 VA: 0x2E7BF80
	public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E890 Offset: 0x2E991 VA: 0x2E890
	// RVA: 0x2E7BFE0 Offset: 0x2E7C0E1 VA: 0x2E7BFE0
	public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E8A0 Offset: 0x2E9A1 VA: 0x2E8A0
	// RVA: 0x2E7C040 Offset: 0x2E7C141 VA: 0x2E7C040
	public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E8B0 Offset: 0x2E9B1 VA: 0x2E8B0
	// RVA: 0x2E7C0A0 Offset: 0x2E7C1A1 VA: 0x2E7C0A0
	public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E8C0 Offset: 0x2E9C1 VA: 0x2E8C0
	// RVA: 0x2E7C100 Offset: 0x2E7C201 VA: 0x2E7C100
	public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E8D0 Offset: 0x2E9D1 VA: 0x2E8D0
	// RVA: 0x2E7C160 Offset: 0x2E7C261 VA: 0x2E7C160
	public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E8E0 Offset: 0x2E9E1 VA: 0x2E8E0
	// RVA: 0x2E7C1C0 Offset: 0x2E7C2C1 VA: 0x2E7C1C0
	public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E8F0 Offset: 0x2E9F1 VA: 0x2E8F0
	// RVA: 0x2E7C220 Offset: 0x2E7C321 VA: 0x2E7C220
	public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E900 Offset: 0x2EA01 VA: 0x2E900
	// RVA: 0x2E7C280 Offset: 0x2E7C381 VA: 0x2E7C280
	public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E910 Offset: 0x2EA11 VA: 0x2E910
	// RVA: 0x2E7C2E0 Offset: 0x2E7C3E1 VA: 0x2E7C2E0
	public static AsyncScrollTrigger GetAsyncScrollTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E920 Offset: 0x2EA21 VA: 0x2E920
	// RVA: 0x2E7C340 Offset: 0x2E7C441 VA: 0x2E7C340
	public static AsyncScrollTrigger GetAsyncScrollTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E930 Offset: 0x2EA31 VA: 0x2E930
	// RVA: 0x2E7C3A0 Offset: 0x2E7C4A1 VA: 0x2E7C3A0
	public static AsyncSelectTrigger GetAsyncSelectTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E940 Offset: 0x2EA41 VA: 0x2E940
	// RVA: 0x2E7C400 Offset: 0x2E7C501 VA: 0x2E7C400
	public static AsyncSelectTrigger GetAsyncSelectTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E950 Offset: 0x2EA51 VA: 0x2E950
	// RVA: 0x2E7AE40 Offset: 0x2E7AF41 VA: 0x2E7AE40
	public static AsyncStartTrigger GetAsyncStartTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E960 Offset: 0x2EA61 VA: 0x2E960
	// RVA: 0x2E7AF00 Offset: 0x2E7B001 VA: 0x2E7AF00
	public static AsyncStartTrigger GetAsyncStartTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E970 Offset: 0x2EA71 VA: 0x2E970
	// RVA: 0x2E7C460 Offset: 0x2E7C561 VA: 0x2E7C460
	public static AsyncSubmitTrigger GetAsyncSubmitTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E980 Offset: 0x2EA81 VA: 0x2E980
	// RVA: 0x2E7C4C0 Offset: 0x2E7C5C1 VA: 0x2E7C4C0
	public static AsyncSubmitTrigger GetAsyncSubmitTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E990 Offset: 0x2EA91 VA: 0x2E990
	// RVA: 0x2E7C520 Offset: 0x2E7C621 VA: 0x2E7C520
	public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E9A0 Offset: 0x2EAA1 VA: 0x2E9A0
	// RVA: 0x2E7C580 Offset: 0x2E7C681 VA: 0x2E7C580
	public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E9B0 Offset: 0x2EAB1 VA: 0x2E9B0
	// RVA: 0x2E7C5E0 Offset: 0x2E7C6E1 VA: 0x2E7C5E0
	public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E9C0 Offset: 0x2EAC1 VA: 0x2E9C0
	// RVA: 0x2E7C640 Offset: 0x2E7C741 VA: 0x2E7C640
	public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E9D0 Offset: 0x2EAD1 VA: 0x2E9D0
	// RVA: 0x2E7C6A0 Offset: 0x2E7C7A1 VA: 0x2E7C6A0
	public static AsyncTriggerTrigger GetAsyncTriggerTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2E9E0 Offset: 0x2EAE1 VA: 0x2E9E0
	// RVA: 0x2E7C700 Offset: 0x2E7C801 VA: 0x2E7C700
	public static AsyncTriggerTrigger GetAsyncTriggerTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2E9F0 Offset: 0x2EAF1 VA: 0x2E9F0
	// RVA: 0x2E7C760 Offset: 0x2E7C861 VA: 0x2E7C760
	public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2EA00 Offset: 0x2EB01 VA: 0x2EA00
	// RVA: 0x2E7C7C0 Offset: 0x2E7C8C1 VA: 0x2E7C7C0
	public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2EA10 Offset: 0x2EB11 VA: 0x2EA10
	// RVA: 0x2E7C820 Offset: 0x2E7C921 VA: 0x2E7C820
	public static AsyncUpdateTrigger GetAsyncUpdateTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2EA20 Offset: 0x2EB21 VA: 0x2EA20
	// RVA: 0x2E7C880 Offset: 0x2E7C981 VA: 0x2E7C880
	public static AsyncUpdateTrigger GetAsyncUpdateTrigger(Component component) { }

	[ExtensionAttribute] // RVA: 0x2EA30 Offset: 0x2EB31 VA: 0x2EA30
	// RVA: 0x2E7C8E0 Offset: 0x2E7C9E1 VA: 0x2E7C8E0
	public static AsyncVisibleTrigger GetAsyncVisibleTrigger(GameObject gameObject) { }

	[ExtensionAttribute] // RVA: 0x2EA40 Offset: 0x2EB41 VA: 0x2EA40
	// RVA: 0x2E7C940 Offset: 0x2E7CA41 VA: 0x2E7C940
	public static AsyncVisibleTrigger GetAsyncVisibleTrigger(Component component) { }
}

