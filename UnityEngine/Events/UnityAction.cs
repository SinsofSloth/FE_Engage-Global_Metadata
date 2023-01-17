// Namespace: UnityEngine.Events
public sealed class UnityAction : MulticastDelegate // TypeDefIndex: 3695
{
	// Methods

	// RVA: 0x384AE30 Offset: 0x384AF31 VA: 0x384AE30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x384AE50 Offset: 0x384AF51 VA: 0x384AE50 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x384B060 Offset: 0x384B161 VA: 0x384B060 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x384B090 Offset: 0x384B191 VA: 0x384B090 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 3697
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF2C90 Offset: 0x2DF2D91 VA: 0x2DF2C90
	|-UnityAction<List<IEventSystemHandler>>..ctor
	|-UnityAction<CinemachineBrain>..ctor
	|-UnityAction<CommandBuffer>..ctor
	|-UnityAction<Component>..ctor
	|-UnityAction<LayoutRebuilder>..ctor
	|-UnityAction<MessageEventArgs>..ctor
	|-UnityAction<object>..ctor
	|
	|-RVA: 0x2DF2010 Offset: 0x2DF2111 VA: 0x2DF2010
	|-UnityAction<bool>..ctor
	|
	|-RVA: 0x2DF2310 Offset: 0x2DF2411 VA: 0x2DF2310
	|-UnityAction<Color>..ctor
	|
	|-RVA: 0x2DF2680 Offset: 0x2DF2781 VA: 0x2DF2680
	|-UnityAction<int>..ctor
	|
	|-RVA: 0x2DF2970 Offset: 0x2DF2A71 VA: 0x2DF2970
	|-UnityAction<Int32Enum>..ctor
	|
	|-RVA: 0x2DF3050 Offset: 0x2DF3151 VA: 0x2DF3050
	|-UnityAction<Scene>..ctor
	|
	|-RVA: 0x2DF3360 Offset: 0x2DF3461 VA: 0x2DF3360
	|-UnityAction<float>..ctor
	|
	|-RVA: 0x2DF3650 Offset: 0x2DF3751 VA: 0x2DF3650
	|-UnityAction<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF2030 Offset: 0x2DF2131 VA: 0x2DF2030
	|-UnityAction<bool>.Invoke
	|
	|-RVA: 0x2DF2330 Offset: 0x2DF2431 VA: 0x2DF2330
	|-UnityAction<Color>.Invoke
	|
	|-RVA: 0x2DF2CB0 Offset: 0x2DF2DB1 VA: 0x2DF2CB0
	|-UnityAction<Component>.Invoke
	|-UnityAction<object>.Invoke
	|
	|-RVA: 0x2DF26A0 Offset: 0x2DF27A1 VA: 0x2DF26A0
	|-UnityAction<int>.Invoke
	|
	|-RVA: 0x2DF2990 Offset: 0x2DF2A91 VA: 0x2DF2990
	|-UnityAction<Int32Enum>.Invoke
	|
	|-RVA: 0x2DF3070 Offset: 0x2DF3171 VA: 0x2DF3070
	|-UnityAction<Scene>.Invoke
	|
	|-RVA: 0x2DF3380 Offset: 0x2DF3481 VA: 0x2DF3380
	|-UnityAction<float>.Invoke
	|
	|-RVA: 0x2DF3670 Offset: 0x2DF3771 VA: 0x2DF3670
	|-UnityAction<Vector2>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF2260 Offset: 0x2DF2361 VA: 0x2DF2260
	|-UnityAction<bool>.BeginInvoke
	|
	|-RVA: 0x2DF25D0 Offset: 0x2DF26D1 VA: 0x2DF25D0
	|-UnityAction<Color>.BeginInvoke
	|
	|-RVA: 0x2DF28D0 Offset: 0x2DF29D1 VA: 0x2DF28D0
	|-UnityAction<int>.BeginInvoke
	|
	|-RVA: 0x2DF2BF0 Offset: 0x2DF2CF1 VA: 0x2DF2BF0
	|-UnityAction<Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2DF3010 Offset: 0x2DF3111 VA: 0x2DF3010
	|-UnityAction<object>.BeginInvoke
	|
	|-RVA: 0x2DF32C0 Offset: 0x2DF33C1 VA: 0x2DF32C0
	|-UnityAction<Scene>.BeginInvoke
	|
	|-RVA: 0x2DF35B0 Offset: 0x2DF36B1 VA: 0x2DF35B0
	|-UnityAction<float>.BeginInvoke
	|
	|-RVA: 0x2DF38E0 Offset: 0x2DF39E1 VA: 0x2DF38E0
	|-UnityAction<Vector2>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF2300 Offset: 0x2DF2401 VA: 0x2DF2300
	|-UnityAction<bool>.EndInvoke
	|
	|-RVA: 0x2DF2670 Offset: 0x2DF2771 VA: 0x2DF2670
	|-UnityAction<Color>.EndInvoke
	|
	|-RVA: 0x2DF2960 Offset: 0x2DF2A61 VA: 0x2DF2960
	|-UnityAction<int>.EndInvoke
	|
	|-RVA: 0x2DF2C80 Offset: 0x2DF2D81 VA: 0x2DF2C80
	|-UnityAction<Int32Enum>.EndInvoke
	|
	|-RVA: 0x2DF3040 Offset: 0x2DF3141 VA: 0x2DF3040
	|-UnityAction<object>.EndInvoke
	|
	|-RVA: 0x2DF3350 Offset: 0x2DF3451 VA: 0x2DF3350
	|-UnityAction<Scene>.EndInvoke
	|
	|-RVA: 0x2DF3640 Offset: 0x2DF3741 VA: 0x2DF3640
	|-UnityAction<float>.EndInvoke
	|
	|-RVA: 0x2DF3970 Offset: 0x2DF3A71 VA: 0x2DF3970
	|-UnityAction<Vector2>.EndInvoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 3699
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF3980 Offset: 0x2DF3A81 VA: 0x2DF3980
	|-UnityAction<object, object>..ctor
	|
	|-RVA: 0x2DF3D50 Offset: 0x2DF3E51 VA: 0x2DF3D50
	|-UnityAction<Scene, Int32Enum>..ctor
	|-UnityAction<Scene, LoadSceneMode>..ctor
	|
	|-RVA: 0x2DF40B0 Offset: 0x2DF41B1 VA: 0x2DF40B0
	|-UnityAction<Scene, Scene>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF39A0 Offset: 0x2DF3AA1 VA: 0x2DF39A0
	|-UnityAction<object, object>.Invoke
	|
	|-RVA: 0x2DF3D70 Offset: 0x2DF3E71 VA: 0x2DF3D70
	|-UnityAction<Scene, Int32Enum>.Invoke
	|-UnityAction<Scene, LoadSceneMode>.Invoke
	|
	|-RVA: 0x2DF40D0 Offset: 0x2DF41D1 VA: 0x2DF40D0
	|-UnityAction<Scene, Scene>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF3D10 Offset: 0x2DF3E11 VA: 0x2DF3D10
	|-UnityAction<object, object>.BeginInvoke
	|
	|-RVA: 0x2DF3FE0 Offset: 0x2DF40E1 VA: 0x2DF3FE0
	|-UnityAction<Scene, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x2DF4340 Offset: 0x2DF4441 VA: 0x2DF4340
	|-UnityAction<Scene, Scene>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF3D40 Offset: 0x2DF3E41 VA: 0x2DF3D40
	|-UnityAction<object, object>.EndInvoke
	|
	|-RVA: 0x2DF40A0 Offset: 0x2DF41A1 VA: 0x2DF40A0
	|-UnityAction<Scene, Int32Enum>.EndInvoke
	|
	|-RVA: 0x2DF43F0 Offset: 0x2DF44F1 VA: 0x2DF43F0
	|-UnityAction<Scene, Scene>.EndInvoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 3701
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF4400 Offset: 0x2DF4501 VA: 0x2DF4400
	|-UnityAction<object, int, int>..ctor
	|
	|-RVA: 0x2DF4880 Offset: 0x2DF4981 VA: 0x2DF4880
	|-UnityAction<object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF4420 Offset: 0x2DF4521 VA: 0x2DF4420
	|-UnityAction<object, int, int>.Invoke
	|
	|-RVA: 0x2DF48A0 Offset: 0x2DF49A1 VA: 0x2DF48A0
	|-UnityAction<object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF47C0 Offset: 0x2DF48C1 VA: 0x2DF47C0
	|-UnityAction<object, int, int>.BeginInvoke
	|
	|-RVA: 0x2DF4C40 Offset: 0x2DF4D41 VA: 0x2DF4C40
	|-UnityAction<object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF4870 Offset: 0x2DF4971 VA: 0x2DF4870
	|-UnityAction<object, int, int>.EndInvoke
	|
	|-RVA: 0x2DF4C70 Offset: 0x2DF4D71 VA: 0x2DF4C70
	|-UnityAction<object, object, object>.EndInvoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 3703
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF4C80 Offset: 0x2DF4D81 VA: 0x2DF4C80
	|-UnityAction<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF4CA0 Offset: 0x2DF4DA1 VA: 0x2DF4CA0
	|-UnityAction<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF5060 Offset: 0x2DF5161 VA: 0x2DF5060
	|-UnityAction<object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF50A0 Offset: 0x2DF51A1 VA: 0x2DF50A0
	|-UnityAction<object, object, object, object>.EndInvoke
	*/
}

