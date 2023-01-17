// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceT<TObject> : AssetReference // TypeDefIndex: 7284
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2410 Offset: 0x32D2511 VA: 0x32D2410
	|-AssetReferenceT<GameObject>..ctor
	|-AssetReferenceT<object>..ctor
	|-AssetReferenceT<Sprite>..ctor
	|-AssetReferenceT<Texture>..ctor
	|-AssetReferenceT<Texture2D>..ctor
	|-AssetReferenceT<Texture3D>..ctor
	*/

	[ObsoleteAttribute] // RVA: 0x662C0 Offset: 0x663C1 VA: 0x662C0
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2420 Offset: 0x32D2521 VA: 0x32D2420
	|-AssetReferenceT<object>.LoadAsset
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2470 Offset: 0x32D2571 VA: 0x32D2470
	|-AssetReferenceT<GameObject>.LoadAssetAsync
	|-AssetReferenceT<object>.LoadAssetAsync
	|-AssetReferenceT<Sprite>.LoadAssetAsync
	|-AssetReferenceT<Texture>.LoadAssetAsync
	|-AssetReferenceT<Texture2D>.LoadAssetAsync
	|-AssetReferenceT<Texture3D>.LoadAssetAsync
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override bool ValidateAsset(Object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D24E0 Offset: 0x32D25E1 VA: 0x32D24E0
	|-AssetReferenceT<GameObject>.ValidateAsset
	|-AssetReferenceT<object>.ValidateAsset
	|-AssetReferenceT<Sprite>.ValidateAsset
	|-AssetReferenceT<Texture>.ValidateAsset
	|-AssetReferenceT<Texture2D>.ValidateAsset
	|-AssetReferenceT<Texture3D>.ValidateAsset
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override bool ValidateAsset(string mainAssetPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x32D2580 Offset: 0x32D2681 VA: 0x32D2580
	|-AssetReferenceT<GameObject>.ValidateAsset
	|-AssetReferenceT<object>.ValidateAsset
	|-AssetReferenceT<Texture>.ValidateAsset
	|-AssetReferenceT<Texture2D>.ValidateAsset
	|-AssetReferenceT<Texture3D>.ValidateAsset
	*/
}

