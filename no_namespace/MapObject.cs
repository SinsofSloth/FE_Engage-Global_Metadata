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
public enum MapObject.Actions // TypeDefIndex: 9031
{
	// Fields
	public int value__; // 0x0
	public const MapObject.Actions None = 0;
	public const MapObject.Actions Idle = 1;
	public const MapObject.Actions Done = 2;
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
public enum MapObject.LightmapScales // TypeDefIndex: 9033
{
	// Fields
	public int value__; // 0x0
	public const MapObject.LightmapScales 通常 = 0;
	public const MapObject.LightmapScales なし = 1;
	public const MapObject.LightmapScales 遠景x0125 = 2;
	public const MapObject.LightmapScales 縮小x05 = 3;
	public const MapObject.LightmapScales 拡大x2 = 4;
	public const MapObject.LightmapScales 極大x4 = 5;
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
public class MapObject.Pair // TypeDefIndex: 9035
{
	// Fields
	public GameObject src; // 0x10
	public GameObject dst; // 0x18

	// Methods

	// RVA: 0x2411660 Offset: 0x2411761 VA: 0x2411660
	public void .ctor() { }
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
private class MapObject.RigidInfo // TypeDefIndex: 9037
{
	// Fields
	public Transform transform; // 0x10
	public Vector3 position; // 0x18
	public Vector3 scale; // 0x24
	public Quaternion rotation; // 0x30
	public Rigidbody rigidbody; // 0x40

	// Methods

	// RVA: 0x2411670 Offset: 0x2411771 VA: 0x2411670
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
private class MapObject.DitherPair // TypeDefIndex: 9039
{
	// Fields
	private Renderer m_Render; // 0x10
	private Material[] m_Shareds; // 0x18
	private Material[] m_Dithers; // 0x20
	private MapObject.DitherManager m_Manager; // 0x28
	private float m_Alpha; // 0x30

	// Methods

	// RVA: 0x2410E10 Offset: 0x2410F11 VA: 0x2410E10
	public void .ctor(MapObject.DitherManager maanger, Renderer render) { }

	// RVA: 0x2411150 Offset: 0x2411251 VA: 0x2411150
	public void CommitAlpha() { }

	// RVA: 0x24113F0 Offset: 0x24114F1 VA: 0x24113F0
	public void SetAlpha(float alpha) { }

	// RVA: 0x2411650 Offset: 0x2411751 VA: 0x2411650
	public float GetAlpha() { }
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
[CompilerGeneratedAttribute] // RVA: 0x275050 Offset: 0x275151 VA: 0x275050
private sealed class MapObject.<ActionAlphaCoroutine>d__67 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9041
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapObject <>4__this; // 0x20
	public float alpha; // 0x28
	private float <delay>5__2; // 0x2C
	private float <time>5__3; // 0x30
	private float <start>5__4; // 0x34
	private float <end>5__5; // 0x38
	private float <elapsed>5__6; // 0x3C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2ADF80 Offset: 0x2AE081 VA: 0x2ADF80
	// RVA: 0x24106C0 Offset: 0x24107C1 VA: 0x24106C0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2ADF90 Offset: 0x2AE091 VA: 0x2ADF90
	// RVA: 0x24106F0 Offset: 0x24107F1 VA: 0x24106F0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2410700 Offset: 0x2410801 VA: 0x2410700 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2ADFA0 Offset: 0x2AE0A1 VA: 0x2ADFA0
	// RVA: 0x2410820 Offset: 0x2410921 VA: 0x2410820 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2ADFB0 Offset: 0x2AE0B1 VA: 0x2ADFB0
	// RVA: 0x2410830 Offset: 0x2410931 VA: 0x2410830 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2ADFC0 Offset: 0x2AE0C1 VA: 0x2ADFC0
	// RVA: 0x2410870 Offset: 0x2410971 VA: 0x2410870 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275070 Offset: 0x275171 VA: 0x275070
private sealed class MapObject.<RotationCoroutine>d__102 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9043
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MapObject <>4__this; // 0x20
	public Quaternion rotation; // 0x28
	public float time; // 0x38
	private Quaternion <prev>5__2; // 0x3C
	private Quaternion <next>5__3; // 0x4C
	private float <elapsed>5__4; // 0x5C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2AE020 Offset: 0x2AE121 VA: 0x2AE020
	// RVA: 0x2410A90 Offset: 0x2410B91 VA: 0x2410A90
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2AE030 Offset: 0x2AE131 VA: 0x2AE030
	// RVA: 0x2410AC0 Offset: 0x2410BC1 VA: 0x2410AC0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2410AD0 Offset: 0x2410BD1 VA: 0x2410AD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AE040 Offset: 0x2AE141 VA: 0x2AE040
	// RVA: 0x2410BD0 Offset: 0x2410CD1 VA: 0x2410BD0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AE050 Offset: 0x2AE151 VA: 0x2AE050
	// RVA: 0x2410BE0 Offset: 0x2410CE1 VA: 0x2410BE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2AE060 Offset: 0x2AE161 VA: 0x2AE060
	// RVA: 0x2410C20 Offset: 0x2410D21 VA: 0x2410C20 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

