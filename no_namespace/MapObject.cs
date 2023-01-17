// Namespace: 
public enum MapObject.Kinds // TypeDefIndex: 9030
{
	// Fields
	public int value__; // 0x0
	public const MapObject.Kinds 無し = 0;
	public const MapObject.Kinds 屋根 = 1;
	public const MapObject.Kinds 扉 = 2;
	public const MapObject.Kinds 宝箱 = 3;
	public const MapObject.Kinds 村 = 4;
	public const MapObject.Kinds 遠景 = 5;
	public const MapObject.Kinds 可動 = 6;
	public const MapObject.Kinds 吊橋 = 7;
	public const MapObject.Kinds 砲台 = 8;
	public const MapObject.Kinds 松明 = 9;
	public const MapObject.Kinds 破壊 = 10;
	public const MapObject.Kinds 地面 = 11;
	public const MapObject.Kinds 復帰 = 12;
}

// Namespace: 
public enum MapObject.Lods // TypeDefIndex: 9032
{
	// Fields
	public int value__; // 0x0
	public const MapObject.Lods 切替早 = 0;
	public const MapObject.Lods 切替中 = 1;
	public const MapObject.Lods 切替遅 = 2;
	public const MapObject.Lods 切替早_Cull = 3;
}

// Namespace: 
public enum MapObject.BakeTypes // TypeDefIndex: 9034
{
	// Fields
	public int value__; // 0x0
	public const MapObject.BakeTypes 通常 = 0;
	public const MapObject.BakeTypes 変化前をベイク = 1;
	public const MapObject.BakeTypes 変化後をベイク = 2;
	public const MapObject.BakeTypes 変化前を強制ベイク = 3;
	public const MapObject.BakeTypes 変化後を強制ベイク = 4;
}

// Namespace: 
[Serializable]
public class MapObject.State // TypeDefIndex: 9036
{
	// Fields
	public GameObject[] 対象オブジェクト; // 0x10
	public GameObject エフェクト; // 0x18

	// Methods

	// RVA: 0x2411D30 Offset: 0x2411E31 VA: 0x2411D30
	public void SetActive(bool enable) { }

	// RVA: 0x2411E40 Offset: 0x2411F41 VA: 0x2411E40
	public void .ctor() { }
}

// Namespace: 
private class MapObject.RigidList : List<MapObject.RigidInfo> // TypeDefIndex: 9038
{
	// Methods

	// RVA: 0x2411680 Offset: 0x2411781 VA: 0x2411680
	public void Add(GameObject[] objects) { }

	// RVA: 0x2411780 Offset: 0x2411881 VA: 0x2411780
	public void Add(GameObject go) { }

	// RVA: 0x2411960 Offset: 0x2411A61 VA: 0x2411960
	public void SetBreak(bool enabled) { }

	// RVA: 0x2411B50 Offset: 0x2411C51 VA: 0x2411B50
	public void Explosion(Vector3 hit, float pow) { }

	// RVA: 0x2411CB0 Offset: 0x2411DB1 VA: 0x2411CB0
	public void .ctor() { }
}

// Namespace: 
private class MapObject.DitherManager // TypeDefIndex: 9040
{
	// Fields
	private List<MapObject.DitherPair> m_Pairs; // 0x10
	private Dictionary<Renderer, MapObject.DitherPair> m_Renderers; // 0x18
	private float m_Alpha; // 0x20

	// Methods

	// RVA: 0x2410C30 Offset: 0x2410D31 VA: 0x2410C30
	public void Setup(GameObject root) { }

	// RVA: 0x24110B0 Offset: 0x24111B1 VA: 0x24110B0
	private void CommitAlpha() { }

	// RVA: 0x24112A0 Offset: 0x24113A1 VA: 0x24112A0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2411350 Offset: 0x2411451 VA: 0x2411350
	public float GetAlpha() { }

	// RVA: 0x2411360 Offset: 0x2411461 VA: 0x2411360
	public void SetRenderAlpha(Renderer render, float alpha) { }

	// RVA: 0x2411400 Offset: 0x2411501 VA: 0x2411400
	public void SetRendersAlpha(Renderer[] renders, float alpha) { }

	// RVA: 0x2411560 Offset: 0x2411661 VA: 0x2411560
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275060 Offset: 0x275161 VA: 0x275060
private sealed class MapObject.<BreakCoroutine>d__94 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9042
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapObject <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2ADFD0 Offset: 0x2AE0D1 VA: 0x2ADFD0
	// RVA: 0x2410880 Offset: 0x2410981 VA: 0x2410880
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2ADFE0 Offset: 0x2AE0E1 VA: 0x2ADFE0
	// RVA: 0x24108B0 Offset: 0x24109B1 VA: 0x24108B0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x24108C0 Offset: 0x24109C1 VA: 0x24108C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2ADFF0 Offset: 0x2AE0F1 VA: 0x2ADFF0
	// RVA: 0x2410A30 Offset: 0x2410B31 VA: 0x2410A30 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AE000 Offset: 0x2AE101 VA: 0x2AE000
	// RVA: 0x2410A40 Offset: 0x2410B41 VA: 0x2410A40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AE010 Offset: 0x2AE111 VA: 0x2AE010
	// RVA: 0x2410A80 Offset: 0x2410B81 VA: 0x2410A80 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

