// Namespace: App
public class TResourceHandle<T> : ResourceHandle // TypeDefIndex: 13914
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B83D0 Offset: 0x34B84D1 VA: 0x34B83D0
	|-TResourceHandle<AnimationClip>..ctor
	|-TResourceHandle<GameObject>..ctor
	|-TResourceHandle<object>..ctor
	|-TResourceHandle<RuntimeAnimatorController>..ctor
	|-TResourceHandle<Sprite>..ctor
	|-TResourceHandle<SpriteAtlas>..ctor
	|-TResourceHandle<Texture2D>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string path, Action<T> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B83E0 Offset: 0x34B84E1 VA: 0x34B83E0
	|-TResourceHandle<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T GetAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8440 Offset: 0x34B8541 VA: 0x34B8440
	|-TResourceHandle<AnimationClip>.GetAsset
	|-TResourceHandle<GameObject>.GetAsset
	|-TResourceHandle<object>.GetAsset
	|-TResourceHandle<RuntimeAnimatorController>.GetAsset
	|-TResourceHandle<SpriteAtlas>.GetAsset
	*/

	// RVA: -1 Offset: -1
	public void LoadAsync(string path, Action<T> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8460 Offset: 0x34B8561 VA: 0x34B8460
	|-TResourceHandle<AnimationClip>.LoadAsync
	|-TResourceHandle<GameObject>.LoadAsync
	|-TResourceHandle<object>.LoadAsync
	|-TResourceHandle<RuntimeAnimatorController>.LoadAsync
	|-TResourceHandle<Sprite>.LoadAsync
	|-TResourceHandle<SpriteAtlas>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	public T Instantiate(GameObject parent, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8480 Offset: 0x34B8581 VA: 0x34B8480
	|-TResourceHandle<GameObject>.Instantiate
	|-TResourceHandle<object>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public T Instantiate(Transform parent, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B8560 Offset: 0x34B8661 VA: 0x34B8560
	|-TResourceHandle<GameObject>.Instantiate
	|-TResourceHandle<object>.Instantiate
	*/
}

