// Namespace: UnityEngine.Playables
[NativeHeaderAttribute] // RVA: 0x441230 Offset: 0x441331 VA: 0x441230
[NativeHeaderAttribute] // RVA: 0x441230 Offset: 0x441331 VA: 0x441230
[UsedByNativeCodeAttribute] // RVA: 0x441230 Offset: 0x441331 VA: 0x441230
[NativeHeaderAttribute] // RVA: 0x441230 Offset: 0x441331 VA: 0x441230
[NativeHeaderAttribute] // RVA: 0x441230 Offset: 0x441331 VA: 0x441230
public struct PlayableGraph // TypeDefIndex: 3994
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8

	// Methods

	// RVA: -1 Offset: -1
	public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2981D30 Offset: 0x2981E31 VA: 0x2981D30
	|-PlayableGraph.Connect<AnimationMixerPlayable, Playable>
	|
	|-RVA: 0x2981DC0 Offset: 0x2981EC1 VA: 0x2981DC0
	|-PlayableGraph.Connect<Playable, ScriptPlayable<object>>
	|-PlayableGraph.Connect<Playable, ScriptPlayable<TimeNotificationBehaviour>>
	|
	|-RVA: 0x2981F00 Offset: 0x2982001 VA: 0x2981F00
	|-PlayableGraph.Connect<Playable, AnimationLayerMixerPlayable>
	|
	|-RVA: 0x2981F90 Offset: 0x2982091 VA: 0x2981F90
	|-PlayableGraph.Connect<Playable, AnimationMixerPlayable>
	|
	|-RVA: 0x2982020 Offset: 0x2982121 VA: 0x2982020
	|-PlayableGraph.Connect<Playable, AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x29820B0 Offset: 0x29821B1 VA: 0x29820B0
	|-PlayableGraph.Connect<Playable, AnimationOffsetPlayable>
	|
	|-RVA: 0x2982140 Offset: 0x2982241 VA: 0x2982140
	|-PlayableGraph.Connect<Playable, AnimationRemoveScalePlayable>
	|
	|-RVA: 0x29821D0 Offset: 0x29822D1 VA: 0x29821D0
	|-PlayableGraph.Connect<Playable, Playable>
	*/

	// RVA: -1 Offset: -1
	public void Disconnect<U>(U input, int inputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2982300 Offset: 0x2982401 VA: 0x2982300
	|-PlayableGraph.Disconnect<AnimationMixerPlayable>
	*/

	// RVA: -1 Offset: -1
	public void DestroyPlayable<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2982260 Offset: 0x2982361 VA: 0x2982260
	|-PlayableGraph.DestroyPlayable<Playable>
	*/

	// RVA: -1 Offset: -1
	public void DestroySubgraph<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29822B0 Offset: 0x29823B1 VA: 0x29822B0
	|-PlayableGraph.DestroySubgraph<Playable>
	*/

	// RVA: 0x3490740 Offset: 0x3490841 VA: 0x3490740
	public void Evaluate() { }

	// RVA: 0x34907E0 Offset: 0x34908E1 VA: 0x34907E0
	public static PlayableGraph Create() { }

	// RVA: 0x3490840 Offset: 0x3490941 VA: 0x3490840
	public static PlayableGraph Create(string name) { }

	[FreeFunctionAttribute] // RVA: 0x454770 Offset: 0x454871 VA: 0x454770
	// RVA: 0x34908F0 Offset: 0x34909F1 VA: 0x34908F0
	public void Destroy() { }

	// RVA: 0x3490990 Offset: 0x3490A91 VA: 0x3490990
	public bool IsValid() { }

	[FreeFunctionAttribute] // RVA: 0x4547C0 Offset: 0x4548C1 VA: 0x4547C0
	// RVA: 0x3490A30 Offset: 0x3490B31 VA: 0x3490A30
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0x454810 Offset: 0x454911 VA: 0x454810
	// RVA: 0x3490AD0 Offset: 0x3490BD1 VA: 0x3490AD0
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0x454860 Offset: 0x454961 VA: 0x454860
	// RVA: 0x3490790 Offset: 0x3490891 VA: 0x3490790
	public void Evaluate(float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0x4548B0 Offset: 0x4549B1 VA: 0x4548B0
	// RVA: 0x3490BC0 Offset: 0x3490CC1 VA: 0x3490BC0
	public void SetTimeUpdateMode(DirectorUpdateMode value) { }

	[FreeFunctionAttribute] // RVA: 0x454900 Offset: 0x454A01 VA: 0x454900
	// RVA: 0x3490C60 Offset: 0x3490D61 VA: 0x3490C60
	public IExposedPropertyTable GetResolver() { }

	[FreeFunctionAttribute] // RVA: 0x454950 Offset: 0x454A51 VA: 0x454950
	// RVA: 0x3490D00 Offset: 0x3490E01 VA: 0x3490D00
	public int GetPlayableCount() { }

	[FreeFunctionAttribute] // RVA: 0x4549A0 Offset: 0x454AA1 VA: 0x4549A0
	// RVA: 0x348FD00 Offset: 0x348FE01 VA: 0x348FD00
	internal PlayableHandle CreatePlayableHandle() { }

	[FreeFunctionAttribute] // RVA: 0x4549F0 Offset: 0x454AF1 VA: 0x4549F0
	// RVA: 0x3490DF0 Offset: 0x3490EF1 VA: 0x3490DF0
	internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0x454A40 Offset: 0x454B41 VA: 0x454A40
	// RVA: 0x3490EB0 Offset: 0x3490FB1 VA: 0x3490EB0
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	[FreeFunctionAttribute] // RVA: 0x454A90 Offset: 0x454B91 VA: 0x454A90
	// RVA: 0x3490FA0 Offset: 0x34910A1 VA: 0x3490FA0
	private void DisconnectInternal(PlayableHandle playable, int inputPort) { }

	[FreeFunctionAttribute] // RVA: 0x454AE0 Offset: 0x454BE1 VA: 0x454AE0
	// RVA: 0x3491070 Offset: 0x3491171 VA: 0x3491070
	private void DestroyPlayableInternal(PlayableHandle playable) { }

	[FreeFunctionAttribute] // RVA: 0x454B30 Offset: 0x454C31 VA: 0x454B30
	// RVA: 0x3491120 Offset: 0x3491221 VA: 0x3491120
	private void DestroySubgraphInternal(PlayableHandle playable) { }

	// RVA: 0x34908A0 Offset: 0x34909A1 VA: 0x34908A0
	private static void Create_Injected(string name, out PlayableGraph ret) { }

	// RVA: 0x3490940 Offset: 0x3490A41 VA: 0x3490940
	private static void Destroy_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x34909E0 Offset: 0x3490AE1 VA: 0x34909E0
	private static bool IsValid_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x3490A80 Offset: 0x3490B81 VA: 0x3490A80
	private static void Play_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x3490B20 Offset: 0x3490C21 VA: 0x3490B20
	private static void Stop_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x3490B70 Offset: 0x3490C71 VA: 0x3490B70
	private static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime) { }

	// RVA: 0x3490C10 Offset: 0x3490D11 VA: 0x3490C10
	private static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value) { }

	// RVA: 0x3490CB0 Offset: 0x3490DB1 VA: 0x3490CB0
	private static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x3490D50 Offset: 0x3490E51 VA: 0x3490D50
	private static int GetPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x3490DA0 Offset: 0x3490EA1 VA: 0x3490DA0
	private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) { }

	// RVA: 0x3490E50 Offset: 0x3490F51 VA: 0x3490E50
	private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle) { }

	// RVA: 0x3490F30 Offset: 0x3491031 VA: 0x3490F30
	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort) { }

	// RVA: 0x3491010 Offset: 0x3491111 VA: 0x3491010
	private static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort) { }

	// RVA: 0x34910D0 Offset: 0x34911D1 VA: 0x34910D0
	private static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable) { }

	// RVA: 0x3491180 Offset: 0x3491281 VA: 0x3491180
	private static void DestroySubgraphInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable) { }
}

