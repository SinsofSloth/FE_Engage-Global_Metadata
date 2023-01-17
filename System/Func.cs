// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x46FA70 Offset: 0x46FB71 VA: 0x46FA70
public sealed class Func<TResult> : MulticastDelegate // TypeDefIndex: 146
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6D890 Offset: 0x1E6D991 VA: 0x1E6D890
	|-Func<IObservable<Unit>>..ctor
	|-Func<Task<BufferOffsetSize>>..ctor
	|-Func<Task<WebResponse>>..ctor
	|-Func<CustomEnvSetManager>..ctor
	|-Func<DebugManager>..ctor
	|-Func<Delegate>..ctor
	|-Func<IEnumerator>..ctor
	|-Func<ManualResetEvent>..ctor
	|-Func<object>..ctor
	|-Func<SemaphoreSlim>..ctor
	|-Func<Stream>..ctor
	|-Func<VolumeManager>..ctor
	|-Func<Task.ContingentProperties>..ctor
	|
	|-RVA: 0x1E4D370 Offset: 0x1E4D471 VA: 0x1E4D370
	|-Func<Nullable<int>>..ctor
	|
	|-RVA: 0x1E4D600 Offset: 0x1E4D701 VA: 0x1E4D600
	|-Func<UniTask<UniTask<object>>>..ctor
	|
	|-RVA: 0x1E4D8E0 Offset: 0x1E4D9E1 VA: 0x1E4D8E0
	|-Func<UniTask<ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x1E4DBC0 Offset: 0x1E4DCC1 VA: 0x1E4DBC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x1E4DEB0 Offset: 0x1E4DFB1 VA: 0x1E4DEB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x1E52B00 Offset: 0x1E52C01 VA: 0x1E52B00
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x1E52DA0 Offset: 0x1E52EA1 VA: 0x1E52DA0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x1E53040 Offset: 0x1E53141 VA: 0x1E53040
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x1E53330 Offset: 0x1E53431 VA: 0x1E53330
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x1E535D0 Offset: 0x1E536D1 VA: 0x1E535D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x1E538C0 Offset: 0x1E539C1 VA: 0x1E538C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x1E53BB0 Offset: 0x1E53CB1 VA: 0x1E53BB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x1E53E90 Offset: 0x1E53F91 VA: 0x1E53E90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x1E54180 Offset: 0x1E54281 VA: 0x1E54180
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E54470 Offset: 0x1E54571 VA: 0x1E54470
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x1E54760 Offset: 0x1E54861 VA: 0x1E54760
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x1E54A50 Offset: 0x1E54B51 VA: 0x1E54A50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x1E54D30 Offset: 0x1E54E31 VA: 0x1E54D30
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x1E55020 Offset: 0x1E55121 VA: 0x1E55020
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x1E552C0 Offset: 0x1E553C1 VA: 0x1E552C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x1E555A0 Offset: 0x1E556A1 VA: 0x1E555A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x1E55890 Offset: 0x1E55991 VA: 0x1E55890
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x1E55B80 Offset: 0x1E55C81 VA: 0x1E55B80
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x1E55E70 Offset: 0x1E55F71 VA: 0x1E55E70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x1E56470 Offset: 0x1E56571 VA: 0x1E56470
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E56AA0 Offset: 0x1E56BA1 VA: 0x1E56AA0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E570E0 Offset: 0x1E571E1 VA: 0x1E570E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E57750 Offset: 0x1E57851 VA: 0x1E57750
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E57D50 Offset: 0x1E57E51 VA: 0x1E57D50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x1E58080 Offset: 0x1E58181 VA: 0x1E58080
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x1E58320 Offset: 0x1E58421 VA: 0x1E58320
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x1E585C0 Offset: 0x1E586C1 VA: 0x1E585C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x1E588B0 Offset: 0x1E589B1 VA: 0x1E588B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x1E58B50 Offset: 0x1E58C51 VA: 0x1E58B50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x1E58E40 Offset: 0x1E58F41 VA: 0x1E58E40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x1E59130 Offset: 0x1E59231 VA: 0x1E59130
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x1E59410 Offset: 0x1E59511 VA: 0x1E59410
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x1E59700 Offset: 0x1E59801 VA: 0x1E59700
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E599F0 Offset: 0x1E59AF1 VA: 0x1E599F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x1E59CE0 Offset: 0x1E59DE1 VA: 0x1E59CE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x1E59FD0 Offset: 0x1E5A0D1 VA: 0x1E59FD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x1E5A2B0 Offset: 0x1E5A3B1 VA: 0x1E5A2B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x1E5A5A0 Offset: 0x1E5A6A1 VA: 0x1E5A5A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x1E5A840 Offset: 0x1E5A941 VA: 0x1E5A840
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x1E5AB20 Offset: 0x1E5AC21 VA: 0x1E5AB20
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x1E5AE00 Offset: 0x1E5AF01 VA: 0x1E5AE00
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x1E5B0F0 Offset: 0x1E5B1F1 VA: 0x1E5B0F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x1E5B3E0 Offset: 0x1E5B4E1 VA: 0x1E5B3E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x1E5B6D0 Offset: 0x1E5B7D1 VA: 0x1E5B6D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E5B9D0 Offset: 0x1E5BAD1 VA: 0x1E5B9D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E5BCC0 Offset: 0x1E5BDC1 VA: 0x1E5BCC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E5BFD0 Offset: 0x1E5C0D1 VA: 0x1E5BFD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E5C2D0 Offset: 0x1E5C3D1 VA: 0x1E5C2D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E5C600 Offset: 0x1E5C701 VA: 0x1E5C600
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E5C900 Offset: 0x1E5CA01 VA: 0x1E5C900
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E5CC40 Offset: 0x1E5CD41 VA: 0x1E5CC40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E5CF50 Offset: 0x1E5D051 VA: 0x1E5CF50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E5D2A0 Offset: 0x1E5D3A1 VA: 0x1E5D2A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x1E5DBA0 Offset: 0x1E5DCA1 VA: 0x1E5DBA0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x1E5DE40 Offset: 0x1E5DF41 VA: 0x1E5DE40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x1E5E0E0 Offset: 0x1E5E1E1 VA: 0x1E5E0E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x1E5E3D0 Offset: 0x1E5E4D1 VA: 0x1E5E3D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x1E5E670 Offset: 0x1E5E771 VA: 0x1E5E670
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x1E5E950 Offset: 0x1E5EA51 VA: 0x1E5E950
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x1E5EC30 Offset: 0x1E5ED31 VA: 0x1E5EC30
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x1E5EF10 Offset: 0x1E5F011 VA: 0x1E5EF10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x1E5F1F0 Offset: 0x1E5F2F1 VA: 0x1E5F1F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E5F4D0 Offset: 0x1E5F5D1 VA: 0x1E5F4D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x1E5F7B0 Offset: 0x1E5F8B1 VA: 0x1E5F7B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x1E5FA90 Offset: 0x1E5FB91 VA: 0x1E5FA90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x1E5FD70 Offset: 0x1E5FE71 VA: 0x1E5FD70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x1E60050 Offset: 0x1E60151 VA: 0x1E60050
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x1E602F0 Offset: 0x1E603F1 VA: 0x1E602F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x1E605D0 Offset: 0x1E606D1 VA: 0x1E605D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x1E608B0 Offset: 0x1E609B1 VA: 0x1E608B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x1E60B90 Offset: 0x1E60C91 VA: 0x1E60B90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x1E60E70 Offset: 0x1E60F71 VA: 0x1E60E70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x1E61150 Offset: 0x1E61251 VA: 0x1E61150
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E61450 Offset: 0x1E61551 VA: 0x1E61450
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x1E61740 Offset: 0x1E61841 VA: 0x1E61740
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E61A50 Offset: 0x1E61B51 VA: 0x1E61A50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E61D40 Offset: 0x1E61E41 VA: 0x1E61D40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E62070 Offset: 0x1E62171 VA: 0x1E62070
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E62370 Offset: 0x1E62471 VA: 0x1E62370
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E626B0 Offset: 0x1E627B1 VA: 0x1E626B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E629B0 Offset: 0x1E62AB1 VA: 0x1E629B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E62D10 Offset: 0x1E62E11 VA: 0x1E62D10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x1E63020 Offset: 0x1E63121 VA: 0x1E63020
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E63310 Offset: 0x1E63411 VA: 0x1E63310
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x1E63610 Offset: 0x1E63711 VA: 0x1E63610
	|-Func<UniTask<ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x1E638B0 Offset: 0x1E639B1 VA: 0x1E638B0
	|-Func<UniTask<ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x1E63B50 Offset: 0x1E63C51 VA: 0x1E63B50
	|-Func<UniTask<ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x1E63E40 Offset: 0x1E63F41 VA: 0x1E63E40
	|-Func<UniTask<ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x1E640E0 Offset: 0x1E641E1 VA: 0x1E640E0
	|-Func<UniTask<ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x1E643C0 Offset: 0x1E644C1 VA: 0x1E643C0
	|-Func<UniTask<ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x1E646A0 Offset: 0x1E647A1 VA: 0x1E646A0
	|-Func<UniTask<ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x1E64940 Offset: 0x1E64A41 VA: 0x1E64940
	|-Func<UniTask<ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x1E64C20 Offset: 0x1E64D21 VA: 0x1E64C20
	|-Func<UniTask<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1E64F00 Offset: 0x1E65001 VA: 0x1E64F00
	|-Func<UniTask<ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x1E651E0 Offset: 0x1E652E1 VA: 0x1E651E0
	|-Func<UniTask<ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x1E654C0 Offset: 0x1E655C1 VA: 0x1E654C0
	|-Func<UniTask<ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x1E65760 Offset: 0x1E65861 VA: 0x1E65760
	|-Func<UniTask<ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x1E65A40 Offset: 0x1E65B41 VA: 0x1E65A40
	|-Func<UniTask<ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x1E65CE0 Offset: 0x1E65DE1 VA: 0x1E65CE0
	|-Func<UniTask<ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x1E65FC0 Offset: 0x1E660C1 VA: 0x1E65FC0
	|-Func<UniTask<ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x1E662A0 Offset: 0x1E663A1 VA: 0x1E662A0
	|-Func<UniTask<ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x1E66580 Offset: 0x1E66681 VA: 0x1E66580
	|-Func<UniTask<ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x1E66860 Offset: 0x1E66961 VA: 0x1E66860
	|-Func<UniTask<ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x1E66B40 Offset: 0x1E66C41 VA: 0x1E66B40
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E66E30 Offset: 0x1E66F31 VA: 0x1E66E30
	|-Func<UniTask<ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x1E67110 Offset: 0x1E67211 VA: 0x1E67110
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E67410 Offset: 0x1E67511 VA: 0x1E67410
	|-Func<UniTask<ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E67700 Offset: 0x1E67801 VA: 0x1E67700
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E67A10 Offset: 0x1E67B11 VA: 0x1E67A10
	|-Func<UniTask<ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E67D00 Offset: 0x1E67E01 VA: 0x1E67D00
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E68030 Offset: 0x1E68131 VA: 0x1E68030
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E68330 Offset: 0x1E68431 VA: 0x1E68330
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1E68670 Offset: 0x1E68771 VA: 0x1E68670
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1E68970 Offset: 0x1E68A71 VA: 0x1E68970
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E68CC0 Offset: 0x1E68DC1 VA: 0x1E68CC0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1E68FB0 Offset: 0x1E690B1 VA: 0x1E68FB0
	|-Func<UniTask<AsyncUnit>>..ctor
	|
	|-RVA: 0x1E69250 Offset: 0x1E69351 VA: 0x1E69250
	|-Func<UniTask<bool>>..ctor
	|
	|-RVA: 0x1E694F0 Offset: 0x1E695F1 VA: 0x1E694F0
	|-Func<UniTask<Bounds>>..ctor
	|
	|-RVA: 0x1E697D0 Offset: 0x1E698D1 VA: 0x1E697D0
	|-Func<UniTask<byte>>..ctor
	|
	|-RVA: 0x1E69A70 Offset: 0x1E69B71 VA: 0x1E69A70
	|-Func<UniTask<Color>>..ctor
	|
	|-RVA: 0x1E69D50 Offset: 0x1E69E51 VA: 0x1E69D50
	|-Func<UniTask<double>>..ctor
	|
	|-RVA: 0x1E69FF0 Offset: 0x1E6A0F1 VA: 0x1E69FF0
	|-Func<UniTask<int>>..ctor
	|
	|-RVA: 0x1E6A290 Offset: 0x1E6A391 VA: 0x1E6A290
	|-Func<UniTask<long>>..ctor
	|
	|-RVA: 0x1E6A530 Offset: 0x1E6A631 VA: 0x1E6A530
	|-Func<UniTask<object>>..ctor
	|
	|-RVA: 0x1E6A7D0 Offset: 0x1E6A8D1 VA: 0x1E6A7D0
	|-Func<UniTask<Quaternion>>..ctor
	|
	|-RVA: 0x1E6AAB0 Offset: 0x1E6ABB1 VA: 0x1E6AAB0
	|-Func<UniTask<Rect>>..ctor
	|
	|-RVA: 0x1E6AD90 Offset: 0x1E6AE91 VA: 0x1E6AD90
	|-Func<UniTask<float>>..ctor
	|
	|-RVA: 0x1E6B030 Offset: 0x1E6B131 VA: 0x1E6B030
	|-Func<UniTask<UniTask>>..ctor
	|
	|-RVA: 0x1E6B2D0 Offset: 0x1E6B3D1 VA: 0x1E6B2D0
	|-Func<UniTask<Unit>>..ctor
	|
	|-RVA: 0x1E6B570 Offset: 0x1E6B671 VA: 0x1E6B570
	|-Func<UniTask<Vector2>>..ctor
	|
	|-RVA: 0x1E6B810 Offset: 0x1E6B911 VA: 0x1E6B810
	|-Func<UniTask<Vector3>>..ctor
	|
	|-RVA: 0x1E6BAF0 Offset: 0x1E6BBF1 VA: 0x1E6BAF0
	|-Func<UniTask<Vector4>>..ctor
	|
	|-RVA: 0x1E6BDD0 Offset: 0x1E6BED1 VA: 0x1E6BDD0
	|-Func<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1E6C070 Offset: 0x1E6C171 VA: 0x1E6C070
	|-Func<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x1E6C300 Offset: 0x1E6C401 VA: 0x1E6C300
	|-Func<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1E6C5E0 Offset: 0x1E6C6E1 VA: 0x1E6C5E0
	|-Func<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1E6C8C0 Offset: 0x1E6C9C1 VA: 0x1E6C8C0
	|-Func<bool>..ctor
	|
	|-RVA: 0x1E6CB60 Offset: 0x1E6CC61 VA: 0x1E6CB60
	|-Func<Color>..ctor
	|
	|-RVA: 0x1E6CE00 Offset: 0x1E6CF01 VA: 0x1E6CE00
	|-Func<DownloadStatus>..ctor
	|
	|-RVA: 0x1E6D0E0 Offset: 0x1E6D1E1 VA: 0x1E6D0E0
	|-Func<int>..ctor
	|
	|-RVA: 0x1E6D370 Offset: 0x1E6D471 VA: 0x1E6D370
	|-Func<Int32Enum>..ctor
	|-Func<BasicMenu.Result>..ctor
	|
	|-RVA: 0x1E6D600 Offset: 0x1E6D701 VA: 0x1E6D600
	|-Func<long>..ctor
	|
	|-RVA: 0x1E6DB00 Offset: 0x1E6DC01 VA: 0x1E6DB00
	|-Func<SceneInstance>..ctor
	|
	|-RVA: 0x1E6DDA0 Offset: 0x1E6DEA1 VA: 0x1E6DDA0
	|-Func<float>..ctor
	|
	|-RVA: 0x1E6E030 Offset: 0x1E6E131 VA: 0x1E6E030
	|-Func<uint>..ctor
	|
	|-RVA: 0x1E6E2C0 Offset: 0x1E6E3C1 VA: 0x1E6E2C0
	|-Func<UniTask>..ctor
	|
	|-RVA: 0x1E6E550 Offset: 0x1E6E651 VA: 0x1E6E550
	|-Func<Unit>..ctor
	|
	|-RVA: 0x1E6E7F0 Offset: 0x1E6E8F1 VA: 0x1E6E7F0
	|-Func<Vector2>..ctor
	|
	|-RVA: 0x1E6EA90 Offset: 0x1E6EB91 VA: 0x1E6EA90
	|-Func<Vector3>..ctor
	|
	|-RVA: 0x1E6ED30 Offset: 0x1E6EE31 VA: 0x1E6ED30
	|-Func<Vector4>..ctor
	|
	|-RVA: 0x1E6EFD0 Offset: 0x1E6F0D1 VA: 0x1E6EFD0
	|-Func<VoidTaskResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4D390 Offset: 0x1E4D491 VA: 0x1E4D390
	|-Func<Nullable<int>>.Invoke
	|
	|-RVA: 0x1E6D8B0 Offset: 0x1E6D9B1 VA: 0x1E6D8B0
	|-Func<Task<BufferOffsetSize>>.Invoke
	|-Func<Camera>.Invoke
	|-Func<IEnumerator>.Invoke
	|-Func<Light>.Invoke
	|-Func<object>.Invoke
	|-Func<string>.Invoke
	|
	|-RVA: 0x1E4D620 Offset: 0x1E4D721 VA: 0x1E4D620
	|-Func<UniTask<UniTask<object>>>.Invoke
	|
	|-RVA: 0x1E4D900 Offset: 0x1E4DA01 VA: 0x1E4D900
	|-Func<UniTask<ValueTuple<bool, UniTask<object>>>>.Invoke
	|
	|-RVA: 0x1E4DBE0 Offset: 0x1E4DCE1 VA: 0x1E4DBE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Invoke
	|
	|-RVA: 0x1E4DED0 Offset: 0x1E4DFD1 VA: 0x1E4DED0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Invoke
	|
	|-RVA: 0x1E52B20 Offset: 0x1E52C21 VA: 0x1E52B20
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Invoke
	|
	|-RVA: 0x1E52DC0 Offset: 0x1E52EC1 VA: 0x1E52DC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Invoke
	|
	|-RVA: 0x1E53060 Offset: 0x1E53161 VA: 0x1E53060
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Invoke
	|
	|-RVA: 0x1E53350 Offset: 0x1E53451 VA: 0x1E53350
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Invoke
	|
	|-RVA: 0x1E535F0 Offset: 0x1E536F1 VA: 0x1E535F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Invoke
	|
	|-RVA: 0x1E538E0 Offset: 0x1E539E1 VA: 0x1E538E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Invoke
	|
	|-RVA: 0x1E53BD0 Offset: 0x1E53CD1 VA: 0x1E53BD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Invoke
	|
	|-RVA: 0x1E53EB0 Offset: 0x1E53FB1 VA: 0x1E53EB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Invoke
	|
	|-RVA: 0x1E541A0 Offset: 0x1E542A1 VA: 0x1E541A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E54490 Offset: 0x1E54591 VA: 0x1E54490
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Invoke
	|
	|-RVA: 0x1E54780 Offset: 0x1E54881 VA: 0x1E54780
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Invoke
	|
	|-RVA: 0x1E54A70 Offset: 0x1E54B71 VA: 0x1E54A70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Invoke
	|
	|-RVA: 0x1E54D50 Offset: 0x1E54E51 VA: 0x1E54D50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Invoke
	|
	|-RVA: 0x1E55040 Offset: 0x1E55141 VA: 0x1E55040
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Invoke
	|
	|-RVA: 0x1E552E0 Offset: 0x1E553E1 VA: 0x1E552E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Invoke
	|
	|-RVA: 0x1E555C0 Offset: 0x1E556C1 VA: 0x1E555C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Invoke
	|
	|-RVA: 0x1E558B0 Offset: 0x1E559B1 VA: 0x1E558B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Invoke
	|
	|-RVA: 0x1E55BA0 Offset: 0x1E55CA1 VA: 0x1E55BA0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Invoke
	|
	|-RVA: 0x1E55E90 Offset: 0x1E55F91 VA: 0x1E55E90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Invoke
	|
	|-RVA: 0x1E56490 Offset: 0x1E56591 VA: 0x1E56490
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Invoke
	|
	|-RVA: 0x1E56AC0 Offset: 0x1E56BC1 VA: 0x1E56AC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Invoke
	|
	|-RVA: 0x1E57100 Offset: 0x1E57201 VA: 0x1E57100
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Invoke
	|
	|-RVA: 0x1E57770 Offset: 0x1E57871 VA: 0x1E57770
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Invoke
	|
	|-RVA: 0x1E57D70 Offset: 0x1E57E71 VA: 0x1E57D70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Invoke
	|
	|-RVA: 0x1E580A0 Offset: 0x1E581A1 VA: 0x1E580A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Invoke
	|
	|-RVA: 0x1E58340 Offset: 0x1E58441 VA: 0x1E58340
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Invoke
	|
	|-RVA: 0x1E585E0 Offset: 0x1E586E1 VA: 0x1E585E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Invoke
	|
	|-RVA: 0x1E588D0 Offset: 0x1E589D1 VA: 0x1E588D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Invoke
	|
	|-RVA: 0x1E58B70 Offset: 0x1E58C71 VA: 0x1E58B70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Invoke
	|
	|-RVA: 0x1E58E60 Offset: 0x1E58F61 VA: 0x1E58E60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Invoke
	|
	|-RVA: 0x1E59150 Offset: 0x1E59251 VA: 0x1E59150
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Invoke
	|
	|-RVA: 0x1E59430 Offset: 0x1E59531 VA: 0x1E59430
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Invoke
	|
	|-RVA: 0x1E59720 Offset: 0x1E59821 VA: 0x1E59720
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E59A10 Offset: 0x1E59B11 VA: 0x1E59A10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Invoke
	|
	|-RVA: 0x1E59D00 Offset: 0x1E59E01 VA: 0x1E59D00
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Invoke
	|
	|-RVA: 0x1E59FF0 Offset: 0x1E5A0F1 VA: 0x1E59FF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Invoke
	|
	|-RVA: 0x1E5A2D0 Offset: 0x1E5A3D1 VA: 0x1E5A2D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Invoke
	|
	|-RVA: 0x1E5A5C0 Offset: 0x1E5A6C1 VA: 0x1E5A5C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Invoke
	|
	|-RVA: 0x1E5A860 Offset: 0x1E5A961 VA: 0x1E5A860
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Invoke
	|
	|-RVA: 0x1E5AB40 Offset: 0x1E5AC41 VA: 0x1E5AB40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Invoke
	|
	|-RVA: 0x1E5AE20 Offset: 0x1E5AF21 VA: 0x1E5AE20
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Invoke
	|
	|-RVA: 0x1E5B110 Offset: 0x1E5B211 VA: 0x1E5B110
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Invoke
	|
	|-RVA: 0x1E5B400 Offset: 0x1E5B501 VA: 0x1E5B400
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Invoke
	|
	|-RVA: 0x1E5B6F0 Offset: 0x1E5B7F1 VA: 0x1E5B6F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E5B9F0 Offset: 0x1E5BAF1 VA: 0x1E5B9F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Invoke
	|
	|-RVA: 0x1E5BCE0 Offset: 0x1E5BDE1 VA: 0x1E5BCE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E5BFF0 Offset: 0x1E5C0F1 VA: 0x1E5BFF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Invoke
	|
	|-RVA: 0x1E5C2F0 Offset: 0x1E5C3F1 VA: 0x1E5C2F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E5C620 Offset: 0x1E5C721 VA: 0x1E5C620
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Invoke
	|
	|-RVA: 0x1E5C920 Offset: 0x1E5CA21 VA: 0x1E5C920
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E5CC60 Offset: 0x1E5CD61 VA: 0x1E5CC60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Invoke
	|
	|-RVA: 0x1E5CF70 Offset: 0x1E5D071 VA: 0x1E5CF70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E5D2C0 Offset: 0x1E5D3C1 VA: 0x1E5D2C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Invoke
	|
	|-RVA: 0x1E5DBC0 Offset: 0x1E5DCC1 VA: 0x1E5DBC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Invoke
	|
	|-RVA: 0x1E5DE60 Offset: 0x1E5DF61 VA: 0x1E5DE60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>>.Invoke
	|
	|-RVA: 0x1E5E100 Offset: 0x1E5E201 VA: 0x1E5E100
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Invoke
	|
	|-RVA: 0x1E5E3F0 Offset: 0x1E5E4F1 VA: 0x1E5E3F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>>.Invoke
	|
	|-RVA: 0x1E5E690 Offset: 0x1E5E791 VA: 0x1E5E690
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>>.Invoke
	|
	|-RVA: 0x1E5E970 Offset: 0x1E5EA71 VA: 0x1E5E970
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, double>>>>.Invoke
	|
	|-RVA: 0x1E5EC50 Offset: 0x1E5ED51 VA: 0x1E5EC50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, int>>>>.Invoke
	|
	|-RVA: 0x1E5EF30 Offset: 0x1E5F031 VA: 0x1E5EF30
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, long>>>>.Invoke
	|
	|-RVA: 0x1E5F210 Offset: 0x1E5F311 VA: 0x1E5F210
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, object>>>>.Invoke
	|
	|-RVA: 0x1E5F4F0 Offset: 0x1E5F5F1 VA: 0x1E5F4F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Invoke
	|
	|-RVA: 0x1E5F7D0 Offset: 0x1E5F8D1 VA: 0x1E5F7D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>>.Invoke
	|
	|-RVA: 0x1E5FAB0 Offset: 0x1E5FBB1 VA: 0x1E5FAB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, float>>>>.Invoke
	|
	|-RVA: 0x1E5FD90 Offset: 0x1E5FE91 VA: 0x1E5FD90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Invoke
	|
	|-RVA: 0x1E60070 Offset: 0x1E60171 VA: 0x1E60070
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>>.Invoke
	|
	|-RVA: 0x1E60310 Offset: 0x1E60411 VA: 0x1E60310
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Invoke
	|
	|-RVA: 0x1E605F0 Offset: 0x1E606F1 VA: 0x1E605F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Invoke
	|
	|-RVA: 0x1E608D0 Offset: 0x1E609D1 VA: 0x1E608D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Invoke
	|
	|-RVA: 0x1E60BB0 Offset: 0x1E60CB1 VA: 0x1E60BB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, object>>>>.Invoke
	|
	|-RVA: 0x1E60E90 Offset: 0x1E60F91 VA: 0x1E60E90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object>>>>.Invoke
	|
	|-RVA: 0x1E61170 Offset: 0x1E61271 VA: 0x1E61170
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E61470 Offset: 0x1E61571 VA: 0x1E61470
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>>.Invoke
	|
	|-RVA: 0x1E61760 Offset: 0x1E61861 VA: 0x1E61760
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E61A70 Offset: 0x1E61B71 VA: 0x1E61A70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Invoke
	|
	|-RVA: 0x1E61D60 Offset: 0x1E61E61 VA: 0x1E61D60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E62090 Offset: 0x1E62191 VA: 0x1E62090
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Invoke
	|
	|-RVA: 0x1E62390 Offset: 0x1E62491 VA: 0x1E62390
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E626D0 Offset: 0x1E627D1 VA: 0x1E626D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Invoke
	|
	|-RVA: 0x1E629D0 Offset: 0x1E62AD1 VA: 0x1E629D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E62D30 Offset: 0x1E62E31 VA: 0x1E62D30
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Invoke
	|
	|-RVA: 0x1E63040 Offset: 0x1E63141 VA: 0x1E63040
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E63330 Offset: 0x1E63431 VA: 0x1E63330
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Invoke
	|
	|-RVA: 0x1E63630 Offset: 0x1E63731 VA: 0x1E63630
	|-Func<UniTask<ValueTuple<bool, AsyncUnit>>>.Invoke
	|
	|-RVA: 0x1E638D0 Offset: 0x1E639D1 VA: 0x1E638D0
	|-Func<UniTask<ValueTuple<bool, bool>>>.Invoke
	|
	|-RVA: 0x1E63B70 Offset: 0x1E63C71 VA: 0x1E63B70
	|-Func<UniTask<ValueTuple<bool, Bounds>>>.Invoke
	|
	|-RVA: 0x1E63E60 Offset: 0x1E63F61 VA: 0x1E63E60
	|-Func<UniTask<ValueTuple<bool, byte>>>.Invoke
	|
	|-RVA: 0x1E64100 Offset: 0x1E64201 VA: 0x1E64100
	|-Func<UniTask<ValueTuple<bool, Color>>>.Invoke
	|
	|-RVA: 0x1E643E0 Offset: 0x1E644E1 VA: 0x1E643E0
	|-Func<UniTask<ValueTuple<bool, double>>>.Invoke
	|
	|-RVA: 0x1E646C0 Offset: 0x1E647C1 VA: 0x1E646C0
	|-Func<UniTask<ValueTuple<bool, int>>>.Invoke
	|
	|-RVA: 0x1E64960 Offset: 0x1E64A61 VA: 0x1E64960
	|-Func<UniTask<ValueTuple<bool, long>>>.Invoke
	|
	|-RVA: 0x1E64C40 Offset: 0x1E64D41 VA: 0x1E64C40
	|-Func<UniTask<ValueTuple<bool, object>>>.Invoke
	|
	|-RVA: 0x1E64F20 Offset: 0x1E65021 VA: 0x1E64F20
	|-Func<UniTask<ValueTuple<bool, Quaternion>>>.Invoke
	|
	|-RVA: 0x1E65200 Offset: 0x1E65301 VA: 0x1E65200
	|-Func<UniTask<ValueTuple<bool, Rect>>>.Invoke
	|
	|-RVA: 0x1E654E0 Offset: 0x1E655E1 VA: 0x1E654E0
	|-Func<UniTask<ValueTuple<bool, float>>>.Invoke
	|
	|-RVA: 0x1E65780 Offset: 0x1E65881 VA: 0x1E65780
	|-Func<UniTask<ValueTuple<bool, UniTask>>>.Invoke
	|
	|-RVA: 0x1E65A60 Offset: 0x1E65B61 VA: 0x1E65A60
	|-Func<UniTask<ValueTuple<bool, Unit>>>.Invoke
	|
	|-RVA: 0x1E65D00 Offset: 0x1E65E01 VA: 0x1E65D00
	|-Func<UniTask<ValueTuple<bool, Vector2>>>.Invoke
	|
	|-RVA: 0x1E65FE0 Offset: 0x1E660E1 VA: 0x1E65FE0
	|-Func<UniTask<ValueTuple<bool, Vector3>>>.Invoke
	|
	|-RVA: 0x1E662C0 Offset: 0x1E663C1 VA: 0x1E662C0
	|-Func<UniTask<ValueTuple<bool, Vector4>>>.Invoke
	|
	|-RVA: 0x1E665A0 Offset: 0x1E666A1 VA: 0x1E665A0
	|-Func<UniTask<ValueTuple<int, object>>>.Invoke
	|
	|-RVA: 0x1E66880 Offset: 0x1E66981 VA: 0x1E66880
	|-Func<UniTask<ValueTuple<object, object>>>.Invoke
	|
	|-RVA: 0x1E66B60 Offset: 0x1E66C61 VA: 0x1E66B60
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Invoke
	|
	|-RVA: 0x1E66E50 Offset: 0x1E66F51 VA: 0x1E66E50
	|-Func<UniTask<ValueTuple<object, object, object>>>.Invoke
	|
	|-RVA: 0x1E67130 Offset: 0x1E67231 VA: 0x1E67130
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Invoke
	|
	|-RVA: 0x1E67430 Offset: 0x1E67531 VA: 0x1E67430
	|-Func<UniTask<ValueTuple<object, object, object, object>>>.Invoke
	|
	|-RVA: 0x1E67720 Offset: 0x1E67821 VA: 0x1E67720
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Invoke
	|
	|-RVA: 0x1E67A30 Offset: 0x1E67B31 VA: 0x1E67A30
	|-Func<UniTask<ValueTuple<object, object, object, object, object>>>.Invoke
	|
	|-RVA: 0x1E67D20 Offset: 0x1E67E21 VA: 0x1E67D20
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Invoke
	|
	|-RVA: 0x1E68050 Offset: 0x1E68151 VA: 0x1E68050
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object>>>.Invoke
	|
	|-RVA: 0x1E68350 Offset: 0x1E68451 VA: 0x1E68350
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Invoke
	|
	|-RVA: 0x1E68690 Offset: 0x1E68791 VA: 0x1E68690
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object, object>>>.Invoke
	|
	|-RVA: 0x1E68990 Offset: 0x1E68A91 VA: 0x1E68990
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E68CE0 Offset: 0x1E68DE1 VA: 0x1E68CE0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Invoke
	|
	|-RVA: 0x1E68FD0 Offset: 0x1E690D1 VA: 0x1E68FD0
	|-Func<UniTask<AsyncUnit>>.Invoke
	|
	|-RVA: 0x1E69270 Offset: 0x1E69371 VA: 0x1E69270
	|-Func<UniTask<bool>>.Invoke
	|
	|-RVA: 0x1E69510 Offset: 0x1E69611 VA: 0x1E69510
	|-Func<UniTask<Bounds>>.Invoke
	|
	|-RVA: 0x1E697F0 Offset: 0x1E698F1 VA: 0x1E697F0
	|-Func<UniTask<byte>>.Invoke
	|
	|-RVA: 0x1E69A90 Offset: 0x1E69B91 VA: 0x1E69A90
	|-Func<UniTask<Color>>.Invoke
	|
	|-RVA: 0x1E69D70 Offset: 0x1E69E71 VA: 0x1E69D70
	|-Func<UniTask<double>>.Invoke
	|
	|-RVA: 0x1E6A010 Offset: 0x1E6A111 VA: 0x1E6A010
	|-Func<UniTask<int>>.Invoke
	|
	|-RVA: 0x1E6A2B0 Offset: 0x1E6A3B1 VA: 0x1E6A2B0
	|-Func<UniTask<long>>.Invoke
	|
	|-RVA: 0x1E6A550 Offset: 0x1E6A651 VA: 0x1E6A550
	|-Func<UniTask<object>>.Invoke
	|
	|-RVA: 0x1E6A7F0 Offset: 0x1E6A8F1 VA: 0x1E6A7F0
	|-Func<UniTask<Quaternion>>.Invoke
	|
	|-RVA: 0x1E6AAD0 Offset: 0x1E6ABD1 VA: 0x1E6AAD0
	|-Func<UniTask<Rect>>.Invoke
	|
	|-RVA: 0x1E6ADB0 Offset: 0x1E6AEB1 VA: 0x1E6ADB0
	|-Func<UniTask<float>>.Invoke
	|
	|-RVA: 0x1E6B050 Offset: 0x1E6B151 VA: 0x1E6B050
	|-Func<UniTask<UniTask>>.Invoke
	|
	|-RVA: 0x1E6B2F0 Offset: 0x1E6B3F1 VA: 0x1E6B2F0
	|-Func<UniTask<Unit>>.Invoke
	|
	|-RVA: 0x1E6B590 Offset: 0x1E6B691 VA: 0x1E6B590
	|-Func<UniTask<Vector2>>.Invoke
	|
	|-RVA: 0x1E6B830 Offset: 0x1E6B931 VA: 0x1E6B830
	|-Func<UniTask<Vector3>>.Invoke
	|
	|-RVA: 0x1E6BB10 Offset: 0x1E6BC11 VA: 0x1E6BB10
	|-Func<UniTask<Vector4>>.Invoke
	|
	|-RVA: 0x1E6BDF0 Offset: 0x1E6BEF1 VA: 0x1E6BDF0
	|-Func<ValueTuple<bool, object>>.Invoke
	|
	|-RVA: 0x1E6C090 Offset: 0x1E6C191 VA: 0x1E6C090
	|-Func<ValueTuple<int, int>>.Invoke
	|
	|-RVA: 0x1E6C320 Offset: 0x1E6C421 VA: 0x1E6C320
	|-Func<ValueTuple<object, object, int>>.Invoke
	|
	|-RVA: 0x1E6C600 Offset: 0x1E6C701 VA: 0x1E6C600
	|-Func<ValueTuple<object, bool, bool, object, object>>.Invoke
	|
	|-RVA: 0x1E6C8E0 Offset: 0x1E6C9E1 VA: 0x1E6C8E0
	|-Func<bool>.Invoke
	|
	|-RVA: 0x1E6CB80 Offset: 0x1E6CC81 VA: 0x1E6CB80
	|-Func<Color>.Invoke
	|
	|-RVA: 0x1E6CE20 Offset: 0x1E6CF21 VA: 0x1E6CE20
	|-Func<DownloadStatus>.Invoke
	|
	|-RVA: 0x1E6D100 Offset: 0x1E6D201 VA: 0x1E6D100
	|-Func<int>.Invoke
	|
	|-RVA: 0x1E6D390 Offset: 0x1E6D491 VA: 0x1E6D390
	|-Func<Int32Enum>.Invoke
	|-Func<BasicMenu.Result>.Invoke
	|
	|-RVA: 0x1E6D620 Offset: 0x1E6D721 VA: 0x1E6D620
	|-Func<long>.Invoke
	|
	|-RVA: 0x1E6DB20 Offset: 0x1E6DC21 VA: 0x1E6DB20
	|-Func<SceneInstance>.Invoke
	|
	|-RVA: 0x1E6DDC0 Offset: 0x1E6DEC1 VA: 0x1E6DDC0
	|-Func<float>.Invoke
	|
	|-RVA: 0x1E6E050 Offset: 0x1E6E151 VA: 0x1E6E050
	|-Func<uint>.Invoke
	|
	|-RVA: 0x1E6E2E0 Offset: 0x1E6E3E1 VA: 0x1E6E2E0
	|-Func<UniTask>.Invoke
	|
	|-RVA: 0x1E6E570 Offset: 0x1E6E671 VA: 0x1E6E570
	|-Func<Unit>.Invoke
	|
	|-RVA: 0x1E6E810 Offset: 0x1E6E911 VA: 0x1E6E810
	|-Func<Vector2>.Invoke
	|
	|-RVA: 0x1E6EAB0 Offset: 0x1E6EBB1 VA: 0x1E6EAB0
	|-Func<Vector3>.Invoke
	|
	|-RVA: 0x1E6ED50 Offset: 0x1E6EE51 VA: 0x1E6ED50
	|-Func<Vector4>.Invoke
	|
	|-RVA: 0x1E6EFF0 Offset: 0x1E6F0F1 VA: 0x1E6EFF0
	|-Func<VoidTaskResult>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4D5A0 Offset: 0x1E4D6A1 VA: 0x1E4D5A0
	|-Func<Nullable<int>>.BeginInvoke
	|
	|-RVA: 0x1E4D860 Offset: 0x1E4D961 VA: 0x1E4D860
	|-Func<UniTask<UniTask<object>>>.BeginInvoke
	|
	|-RVA: 0x1E4DB40 Offset: 0x1E4DC41 VA: 0x1E4DB40
	|-Func<UniTask<ValueTuple<bool, UniTask<object>>>>.BeginInvoke
	|
	|-RVA: 0x1E4DE30 Offset: 0x1E4DF31 VA: 0x1E4DE30
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E4E120 Offset: 0x1E4E221 VA: 0x1E4E120
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E52D40 Offset: 0x1E52E41 VA: 0x1E52D40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E52FE0 Offset: 0x1E530E1 VA: 0x1E52FE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E532B0 Offset: 0x1E533B1 VA: 0x1E532B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E53570 Offset: 0x1E53671 VA: 0x1E53570
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E53840 Offset: 0x1E53941 VA: 0x1E53840
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E53B30 Offset: 0x1E53C31 VA: 0x1E53B30
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E53E10 Offset: 0x1E53F11 VA: 0x1E53E10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E54100 Offset: 0x1E54201 VA: 0x1E54100
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E543F0 Offset: 0x1E544F1 VA: 0x1E543F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E546E0 Offset: 0x1E547E1 VA: 0x1E546E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E549D0 Offset: 0x1E54AD1 VA: 0x1E549D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E54CB0 Offset: 0x1E54DB1 VA: 0x1E54CB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E54FA0 Offset: 0x1E550A1 VA: 0x1E54FA0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E55260 Offset: 0x1E55361 VA: 0x1E55260
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E55520 Offset: 0x1E55621 VA: 0x1E55520
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E55810 Offset: 0x1E55911 VA: 0x1E55810
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E55B00 Offset: 0x1E55C01 VA: 0x1E55B00
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E55DF0 Offset: 0x1E55EF1 VA: 0x1E55DF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E560E0 Offset: 0x1E561E1 VA: 0x1E560E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E566E0 Offset: 0x1E567E1 VA: 0x1E566E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E56D10 Offset: 0x1E56E11 VA: 0x1E56D10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E57360 Offset: 0x1E57461 VA: 0x1E57360
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E579D0 Offset: 0x1E57AD1 VA: 0x1E579D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E57FE0 Offset: 0x1E580E1 VA: 0x1E57FE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E582C0 Offset: 0x1E583C1 VA: 0x1E582C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.BeginInvoke
	|
	|-RVA: 0x1E58560 Offset: 0x1E58661 VA: 0x1E58560
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.BeginInvoke
	|
	|-RVA: 0x1E58830 Offset: 0x1E58931 VA: 0x1E58830
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.BeginInvoke
	|
	|-RVA: 0x1E58AF0 Offset: 0x1E58BF1 VA: 0x1E58AF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.BeginInvoke
	|
	|-RVA: 0x1E58DC0 Offset: 0x1E58EC1 VA: 0x1E58DC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.BeginInvoke
	|
	|-RVA: 0x1E590B0 Offset: 0x1E591B1 VA: 0x1E590B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.BeginInvoke
	|
	|-RVA: 0x1E59390 Offset: 0x1E59491 VA: 0x1E59390
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.BeginInvoke
	|
	|-RVA: 0x1E59680 Offset: 0x1E59781 VA: 0x1E59680
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.BeginInvoke
	|
	|-RVA: 0x1E59970 Offset: 0x1E59A71 VA: 0x1E59970
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E59C60 Offset: 0x1E59D61 VA: 0x1E59C60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.BeginInvoke
	|
	|-RVA: 0x1E59F50 Offset: 0x1E5A051 VA: 0x1E59F50
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5A230 Offset: 0x1E5A331 VA: 0x1E5A230
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5A520 Offset: 0x1E5A621 VA: 0x1E5A520
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5A7E0 Offset: 0x1E5A8E1 VA: 0x1E5A7E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5AAA0 Offset: 0x1E5ABA1 VA: 0x1E5AAA0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5AD80 Offset: 0x1E5AE81 VA: 0x1E5AD80
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5B070 Offset: 0x1E5B171 VA: 0x1E5B070
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5B360 Offset: 0x1E5B461 VA: 0x1E5B360
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5B650 Offset: 0x1E5B751 VA: 0x1E5B650
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5B940 Offset: 0x1E5BA41 VA: 0x1E5B940
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5BC40 Offset: 0x1E5BD41 VA: 0x1E5BC40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5BF40 Offset: 0x1E5C041 VA: 0x1E5BF40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5C240 Offset: 0x1E5C341 VA: 0x1E5C240
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5C560 Offset: 0x1E5C661 VA: 0x1E5C560
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5C870 Offset: 0x1E5C971 VA: 0x1E5C870
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5CBA0 Offset: 0x1E5CCA1 VA: 0x1E5CBA0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5CEC0 Offset: 0x1E5CFC1 VA: 0x1E5CEC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5D1F0 Offset: 0x1E5D2F1 VA: 0x1E5D1F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5D520 Offset: 0x1E5D621 VA: 0x1E5D520
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E5DDE0 Offset: 0x1E5DEE1 VA: 0x1E5DDE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.BeginInvoke
	|
	|-RVA: 0x1E5E080 Offset: 0x1E5E181 VA: 0x1E5E080
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>>.BeginInvoke
	|
	|-RVA: 0x1E5E350 Offset: 0x1E5E451 VA: 0x1E5E350
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>>.BeginInvoke
	|
	|-RVA: 0x1E5E610 Offset: 0x1E5E711 VA: 0x1E5E610
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>>.BeginInvoke
	|
	|-RVA: 0x1E5E8D0 Offset: 0x1E5E9D1 VA: 0x1E5E8D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>>.BeginInvoke
	|
	|-RVA: 0x1E5EBB0 Offset: 0x1E5ECB1 VA: 0x1E5EBB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, double>>>>.BeginInvoke
	|
	|-RVA: 0x1E5EE90 Offset: 0x1E5EF91 VA: 0x1E5EE90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, int>>>>.BeginInvoke
	|
	|-RVA: 0x1E5F170 Offset: 0x1E5F271 VA: 0x1E5F170
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, long>>>>.BeginInvoke
	|
	|-RVA: 0x1E5F450 Offset: 0x1E5F551 VA: 0x1E5F450
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E5F730 Offset: 0x1E5F831 VA: 0x1E5F730
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.BeginInvoke
	|
	|-RVA: 0x1E5FA10 Offset: 0x1E5FB11 VA: 0x1E5FA10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>>.BeginInvoke
	|
	|-RVA: 0x1E5FCF0 Offset: 0x1E5FDF1 VA: 0x1E5FCF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, float>>>>.BeginInvoke
	|
	|-RVA: 0x1E5FFD0 Offset: 0x1E600D1 VA: 0x1E5FFD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>>.BeginInvoke
	|
	|-RVA: 0x1E60290 Offset: 0x1E60391 VA: 0x1E60290
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>>.BeginInvoke
	|
	|-RVA: 0x1E60550 Offset: 0x1E60651 VA: 0x1E60550
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>>.BeginInvoke
	|
	|-RVA: 0x1E60830 Offset: 0x1E60931 VA: 0x1E60830
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>>.BeginInvoke
	|
	|-RVA: 0x1E60B10 Offset: 0x1E60C11 VA: 0x1E60B10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>>.BeginInvoke
	|
	|-RVA: 0x1E60DF0 Offset: 0x1E60EF1 VA: 0x1E60DF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E610D0 Offset: 0x1E611D1 VA: 0x1E610D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E613C0 Offset: 0x1E614C1 VA: 0x1E613C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E616C0 Offset: 0x1E617C1 VA: 0x1E616C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E619C0 Offset: 0x1E61AC1 VA: 0x1E619C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E61CC0 Offset: 0x1E61DC1 VA: 0x1E61CC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E61FD0 Offset: 0x1E620D1 VA: 0x1E61FD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E622E0 Offset: 0x1E623E1 VA: 0x1E622E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E62610 Offset: 0x1E62711 VA: 0x1E62610
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E62920 Offset: 0x1E62A21 VA: 0x1E62920
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E62C60 Offset: 0x1E62D61 VA: 0x1E62C60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E62F90 Offset: 0x1E63091 VA: 0x1E62F90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E632A0 Offset: 0x1E633A1 VA: 0x1E632A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E635A0 Offset: 0x1E636A1 VA: 0x1E635A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.BeginInvoke
	|
	|-RVA: 0x1E63850 Offset: 0x1E63951 VA: 0x1E63850
	|-Func<UniTask<ValueTuple<bool, AsyncUnit>>>.BeginInvoke
	|
	|-RVA: 0x1E63AF0 Offset: 0x1E63BF1 VA: 0x1E63AF0
	|-Func<UniTask<ValueTuple<bool, bool>>>.BeginInvoke
	|
	|-RVA: 0x1E63DC0 Offset: 0x1E63EC1 VA: 0x1E63DC0
	|-Func<UniTask<ValueTuple<bool, Bounds>>>.BeginInvoke
	|
	|-RVA: 0x1E64080 Offset: 0x1E64181 VA: 0x1E64080
	|-Func<UniTask<ValueTuple<bool, byte>>>.BeginInvoke
	|
	|-RVA: 0x1E64340 Offset: 0x1E64441 VA: 0x1E64340
	|-Func<UniTask<ValueTuple<bool, Color>>>.BeginInvoke
	|
	|-RVA: 0x1E64620 Offset: 0x1E64721 VA: 0x1E64620
	|-Func<UniTask<ValueTuple<bool, double>>>.BeginInvoke
	|
	|-RVA: 0x1E648E0 Offset: 0x1E649E1 VA: 0x1E648E0
	|-Func<UniTask<ValueTuple<bool, int>>>.BeginInvoke
	|
	|-RVA: 0x1E64BA0 Offset: 0x1E64CA1 VA: 0x1E64BA0
	|-Func<UniTask<ValueTuple<bool, long>>>.BeginInvoke
	|
	|-RVA: 0x1E64E80 Offset: 0x1E64F81 VA: 0x1E64E80
	|-Func<UniTask<ValueTuple<bool, object>>>.BeginInvoke
	|
	|-RVA: 0x1E65160 Offset: 0x1E65261 VA: 0x1E65160
	|-Func<UniTask<ValueTuple<bool, Quaternion>>>.BeginInvoke
	|
	|-RVA: 0x1E65440 Offset: 0x1E65541 VA: 0x1E65440
	|-Func<UniTask<ValueTuple<bool, Rect>>>.BeginInvoke
	|
	|-RVA: 0x1E65700 Offset: 0x1E65801 VA: 0x1E65700
	|-Func<UniTask<ValueTuple<bool, float>>>.BeginInvoke
	|
	|-RVA: 0x1E659C0 Offset: 0x1E65AC1 VA: 0x1E659C0
	|-Func<UniTask<ValueTuple<bool, UniTask>>>.BeginInvoke
	|
	|-RVA: 0x1E65C80 Offset: 0x1E65D81 VA: 0x1E65C80
	|-Func<UniTask<ValueTuple<bool, Unit>>>.BeginInvoke
	|
	|-RVA: 0x1E65F40 Offset: 0x1E66041 VA: 0x1E65F40
	|-Func<UniTask<ValueTuple<bool, Vector2>>>.BeginInvoke
	|
	|-RVA: 0x1E66220 Offset: 0x1E66321 VA: 0x1E66220
	|-Func<UniTask<ValueTuple<bool, Vector3>>>.BeginInvoke
	|
	|-RVA: 0x1E66500 Offset: 0x1E66601 VA: 0x1E66500
	|-Func<UniTask<ValueTuple<bool, Vector4>>>.BeginInvoke
	|
	|-RVA: 0x1E667E0 Offset: 0x1E668E1 VA: 0x1E667E0
	|-Func<UniTask<ValueTuple<int, object>>>.BeginInvoke
	|
	|-RVA: 0x1E66AC0 Offset: 0x1E66BC1 VA: 0x1E66AC0
	|-Func<UniTask<ValueTuple<object, object>>>.BeginInvoke
	|
	|-RVA: 0x1E66DB0 Offset: 0x1E66EB1 VA: 0x1E66DB0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E67090 Offset: 0x1E67191 VA: 0x1E67090
	|-Func<UniTask<ValueTuple<object, object, object>>>.BeginInvoke
	|
	|-RVA: 0x1E67380 Offset: 0x1E67481 VA: 0x1E67380
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E67680 Offset: 0x1E67781 VA: 0x1E67680
	|-Func<UniTask<ValueTuple<object, object, object, object>>>.BeginInvoke
	|
	|-RVA: 0x1E67980 Offset: 0x1E67A81 VA: 0x1E67980
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E67C80 Offset: 0x1E67D81 VA: 0x1E67C80
	|-Func<UniTask<ValueTuple<object, object, object, object, object>>>.BeginInvoke
	|
	|-RVA: 0x1E67F90 Offset: 0x1E68091 VA: 0x1E67F90
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E682A0 Offset: 0x1E683A1 VA: 0x1E682A0
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object>>>.BeginInvoke
	|
	|-RVA: 0x1E685D0 Offset: 0x1E686D1 VA: 0x1E685D0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.BeginInvoke
	|
	|-RVA: 0x1E688E0 Offset: 0x1E689E1 VA: 0x1E688E0
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object, object>>>.BeginInvoke
	|
	|-RVA: 0x1E68C10 Offset: 0x1E68D11 VA: 0x1E68C10
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E68F40 Offset: 0x1E69041 VA: 0x1E68F40
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.BeginInvoke
	|
	|-RVA: 0x1E691F0 Offset: 0x1E692F1 VA: 0x1E691F0
	|-Func<UniTask<AsyncUnit>>.BeginInvoke
	|
	|-RVA: 0x1E69490 Offset: 0x1E69591 VA: 0x1E69490
	|-Func<UniTask<bool>>.BeginInvoke
	|
	|-RVA: 0x1E69750 Offset: 0x1E69851 VA: 0x1E69750
	|-Func<UniTask<Bounds>>.BeginInvoke
	|
	|-RVA: 0x1E69A10 Offset: 0x1E69B11 VA: 0x1E69A10
	|-Func<UniTask<byte>>.BeginInvoke
	|
	|-RVA: 0x1E69CD0 Offset: 0x1E69DD1 VA: 0x1E69CD0
	|-Func<UniTask<Color>>.BeginInvoke
	|
	|-RVA: 0x1E69F90 Offset: 0x1E6A091 VA: 0x1E69F90
	|-Func<UniTask<double>>.BeginInvoke
	|
	|-RVA: 0x1E6A230 Offset: 0x1E6A331 VA: 0x1E6A230
	|-Func<UniTask<int>>.BeginInvoke
	|
	|-RVA: 0x1E6A4D0 Offset: 0x1E6A5D1 VA: 0x1E6A4D0
	|-Func<UniTask<long>>.BeginInvoke
	|
	|-RVA: 0x1E6A770 Offset: 0x1E6A871 VA: 0x1E6A770
	|-Func<UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E6AA30 Offset: 0x1E6AB31 VA: 0x1E6AA30
	|-Func<UniTask<Quaternion>>.BeginInvoke
	|
	|-RVA: 0x1E6AD10 Offset: 0x1E6AE11 VA: 0x1E6AD10
	|-Func<UniTask<Rect>>.BeginInvoke
	|
	|-RVA: 0x1E6AFD0 Offset: 0x1E6B0D1 VA: 0x1E6AFD0
	|-Func<UniTask<float>>.BeginInvoke
	|
	|-RVA: 0x1E6B270 Offset: 0x1E6B371 VA: 0x1E6B270
	|-Func<UniTask<UniTask>>.BeginInvoke
	|
	|-RVA: 0x1E6B510 Offset: 0x1E6B611 VA: 0x1E6B510
	|-Func<UniTask<Unit>>.BeginInvoke
	|
	|-RVA: 0x1E6B7B0 Offset: 0x1E6B8B1 VA: 0x1E6B7B0
	|-Func<UniTask<Vector2>>.BeginInvoke
	|
	|-RVA: 0x1E6BA70 Offset: 0x1E6BB71 VA: 0x1E6BA70
	|-Func<UniTask<Vector3>>.BeginInvoke
	|
	|-RVA: 0x1E6BD50 Offset: 0x1E6BE51 VA: 0x1E6BD50
	|-Func<UniTask<Vector4>>.BeginInvoke
	|
	|-RVA: 0x1E6C010 Offset: 0x1E6C111 VA: 0x1E6C010
	|-Func<ValueTuple<bool, object>>.BeginInvoke
	|
	|-RVA: 0x1E6C2A0 Offset: 0x1E6C3A1 VA: 0x1E6C2A0
	|-Func<ValueTuple<int, int>>.BeginInvoke
	|
	|-RVA: 0x1E6C560 Offset: 0x1E6C661 VA: 0x1E6C560
	|-Func<ValueTuple<object, object, int>>.BeginInvoke
	|
	|-RVA: 0x1E6C840 Offset: 0x1E6C941 VA: 0x1E6C840
	|-Func<ValueTuple<object, bool, bool, object, object>>.BeginInvoke
	|
	|-RVA: 0x1E6CB00 Offset: 0x1E6CC01 VA: 0x1E6CB00
	|-Func<bool>.BeginInvoke
	|
	|-RVA: 0x1E6CDA0 Offset: 0x1E6CEA1 VA: 0x1E6CDA0
	|-Func<Color>.BeginInvoke
	|
	|-RVA: 0x1E6D060 Offset: 0x1E6D161 VA: 0x1E6D060
	|-Func<DownloadStatus>.BeginInvoke
	|
	|-RVA: 0x1E6D310 Offset: 0x1E6D411 VA: 0x1E6D310
	|-Func<int>.BeginInvoke
	|
	|-RVA: 0x1E6D5A0 Offset: 0x1E6D6A1 VA: 0x1E6D5A0
	|-Func<Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1E6D830 Offset: 0x1E6D931 VA: 0x1E6D830
	|-Func<long>.BeginInvoke
	|
	|-RVA: 0x1E6DAC0 Offset: 0x1E6DBC1 VA: 0x1E6DAC0
	|-Func<object>.BeginInvoke
	|
	|-RVA: 0x1E6DD40 Offset: 0x1E6DE41 VA: 0x1E6DD40
	|-Func<SceneInstance>.BeginInvoke
	|
	|-RVA: 0x1E6DFD0 Offset: 0x1E6E0D1 VA: 0x1E6DFD0
	|-Func<float>.BeginInvoke
	|
	|-RVA: 0x1E6E260 Offset: 0x1E6E361 VA: 0x1E6E260
	|-Func<uint>.BeginInvoke
	|
	|-RVA: 0x1E6E4F0 Offset: 0x1E6E5F1 VA: 0x1E6E4F0
	|-Func<UniTask>.BeginInvoke
	|
	|-RVA: 0x1E6E790 Offset: 0x1E6E891 VA: 0x1E6E790
	|-Func<Unit>.BeginInvoke
	|
	|-RVA: 0x1E6EA30 Offset: 0x1E6EB31 VA: 0x1E6EA30
	|-Func<Vector2>.BeginInvoke
	|
	|-RVA: 0x1E6ECD0 Offset: 0x1E6EDD1 VA: 0x1E6ECD0
	|-Func<Vector3>.BeginInvoke
	|
	|-RVA: 0x1E6EF70 Offset: 0x1E6F071 VA: 0x1E6EF70
	|-Func<Vector4>.BeginInvoke
	|
	|-RVA: 0x1E6F210 Offset: 0x1E6F311 VA: 0x1E6F210
	|-Func<VoidTaskResult>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4D5D0 Offset: 0x1E4D6D1 VA: 0x1E4D5D0
	|-Func<Nullable<int>>.EndInvoke
	|
	|-RVA: 0x1E4D890 Offset: 0x1E4D991 VA: 0x1E4D890
	|-Func<UniTask<UniTask<object>>>.EndInvoke
	|
	|-RVA: 0x1E4DB70 Offset: 0x1E4DC71 VA: 0x1E4DB70
	|-Func<UniTask<ValueTuple<bool, UniTask<object>>>>.EndInvoke
	|
	|-RVA: 0x1E4DE60 Offset: 0x1E4DF61 VA: 0x1E4DE60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.EndInvoke
	|
	|-RVA: 0x1E4E150 Offset: 0x1E4E251 VA: 0x1E4E150
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E52D70 Offset: 0x1E52E71 VA: 0x1E52D70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.EndInvoke
	|
	|-RVA: 0x1E53010 Offset: 0x1E53111 VA: 0x1E53010
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.EndInvoke
	|
	|-RVA: 0x1E532E0 Offset: 0x1E533E1 VA: 0x1E532E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.EndInvoke
	|
	|-RVA: 0x1E535A0 Offset: 0x1E536A1 VA: 0x1E535A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.EndInvoke
	|
	|-RVA: 0x1E53870 Offset: 0x1E53971 VA: 0x1E53870
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.EndInvoke
	|
	|-RVA: 0x1E53B60 Offset: 0x1E53C61 VA: 0x1E53B60
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.EndInvoke
	|
	|-RVA: 0x1E53E40 Offset: 0x1E53F41 VA: 0x1E53E40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.EndInvoke
	|
	|-RVA: 0x1E54130 Offset: 0x1E54231 VA: 0x1E54130
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.EndInvoke
	|
	|-RVA: 0x1E54420 Offset: 0x1E54521 VA: 0x1E54420
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E54710 Offset: 0x1E54811 VA: 0x1E54710
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.EndInvoke
	|
	|-RVA: 0x1E54A00 Offset: 0x1E54B01 VA: 0x1E54A00
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.EndInvoke
	|
	|-RVA: 0x1E54CE0 Offset: 0x1E54DE1 VA: 0x1E54CE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.EndInvoke
	|
	|-RVA: 0x1E54FD0 Offset: 0x1E550D1 VA: 0x1E54FD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.EndInvoke
	|
	|-RVA: 0x1E55290 Offset: 0x1E55391 VA: 0x1E55290
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.EndInvoke
	|
	|-RVA: 0x1E55550 Offset: 0x1E55651 VA: 0x1E55550
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.EndInvoke
	|
	|-RVA: 0x1E55840 Offset: 0x1E55941 VA: 0x1E55840
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.EndInvoke
	|
	|-RVA: 0x1E55B30 Offset: 0x1E55C31 VA: 0x1E55B30
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.EndInvoke
	|
	|-RVA: 0x1E55E20 Offset: 0x1E55F21 VA: 0x1E55E20
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E56110 Offset: 0x1E56211 VA: 0x1E56110
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E56710 Offset: 0x1E56811 VA: 0x1E56710
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E56D40 Offset: 0x1E56E41 VA: 0x1E56D40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E57390 Offset: 0x1E57491 VA: 0x1E57390
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E57A00 Offset: 0x1E57B01 VA: 0x1E57A00
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E58010 Offset: 0x1E58111 VA: 0x1E58010
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E582F0 Offset: 0x1E583F1 VA: 0x1E582F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.EndInvoke
	|
	|-RVA: 0x1E58590 Offset: 0x1E58691 VA: 0x1E58590
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.EndInvoke
	|
	|-RVA: 0x1E58860 Offset: 0x1E58961 VA: 0x1E58860
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.EndInvoke
	|
	|-RVA: 0x1E58B20 Offset: 0x1E58C21 VA: 0x1E58B20
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.EndInvoke
	|
	|-RVA: 0x1E58DF0 Offset: 0x1E58EF1 VA: 0x1E58DF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.EndInvoke
	|
	|-RVA: 0x1E590E0 Offset: 0x1E591E1 VA: 0x1E590E0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.EndInvoke
	|
	|-RVA: 0x1E593C0 Offset: 0x1E594C1 VA: 0x1E593C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.EndInvoke
	|
	|-RVA: 0x1E596B0 Offset: 0x1E597B1 VA: 0x1E596B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.EndInvoke
	|
	|-RVA: 0x1E599A0 Offset: 0x1E59AA1 VA: 0x1E599A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E59C90 Offset: 0x1E59D91 VA: 0x1E59C90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.EndInvoke
	|
	|-RVA: 0x1E59F80 Offset: 0x1E5A081 VA: 0x1E59F80
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.EndInvoke
	|
	|-RVA: 0x1E5A260 Offset: 0x1E5A361 VA: 0x1E5A260
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.EndInvoke
	|
	|-RVA: 0x1E5A550 Offset: 0x1E5A651 VA: 0x1E5A550
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.EndInvoke
	|
	|-RVA: 0x1E5A810 Offset: 0x1E5A911 VA: 0x1E5A810
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.EndInvoke
	|
	|-RVA: 0x1E5AAD0 Offset: 0x1E5ABD1 VA: 0x1E5AAD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.EndInvoke
	|
	|-RVA: 0x1E5ADB0 Offset: 0x1E5AEB1 VA: 0x1E5ADB0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.EndInvoke
	|
	|-RVA: 0x1E5B0A0 Offset: 0x1E5B1A1 VA: 0x1E5B0A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.EndInvoke
	|
	|-RVA: 0x1E5B390 Offset: 0x1E5B491 VA: 0x1E5B390
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E5B680 Offset: 0x1E5B781 VA: 0x1E5B680
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E5B970 Offset: 0x1E5BA71 VA: 0x1E5B970
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E5BC70 Offset: 0x1E5BD71 VA: 0x1E5BC70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E5BF70 Offset: 0x1E5C071 VA: 0x1E5BF70
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E5C270 Offset: 0x1E5C371 VA: 0x1E5C270
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E5C590 Offset: 0x1E5C691 VA: 0x1E5C590
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E5C8A0 Offset: 0x1E5C9A1 VA: 0x1E5C8A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E5CBD0 Offset: 0x1E5CCD1 VA: 0x1E5CBD0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E5CEF0 Offset: 0x1E5CFF1 VA: 0x1E5CEF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E5D220 Offset: 0x1E5D321 VA: 0x1E5D220
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E5D550 Offset: 0x1E5D651 VA: 0x1E5D550
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E5DE10 Offset: 0x1E5DF11 VA: 0x1E5DE10
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.EndInvoke
	|
	|-RVA: 0x1E5E0B0 Offset: 0x1E5E1B1 VA: 0x1E5E0B0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, bool>>>>.EndInvoke
	|
	|-RVA: 0x1E5E380 Offset: 0x1E5E481 VA: 0x1E5E380
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Bounds>>>>.EndInvoke
	|
	|-RVA: 0x1E5E640 Offset: 0x1E5E741 VA: 0x1E5E640
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, byte>>>>.EndInvoke
	|
	|-RVA: 0x1E5E900 Offset: 0x1E5EA01 VA: 0x1E5E900
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Color>>>>.EndInvoke
	|
	|-RVA: 0x1E5EBE0 Offset: 0x1E5ECE1 VA: 0x1E5EBE0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, double>>>>.EndInvoke
	|
	|-RVA: 0x1E5EEC0 Offset: 0x1E5EFC1 VA: 0x1E5EEC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, int>>>>.EndInvoke
	|
	|-RVA: 0x1E5F1A0 Offset: 0x1E5F2A1 VA: 0x1E5F1A0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, long>>>>.EndInvoke
	|
	|-RVA: 0x1E5F480 Offset: 0x1E5F581 VA: 0x1E5F480
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, object>>>>.EndInvoke
	|
	|-RVA: 0x1E5F760 Offset: 0x1E5F861 VA: 0x1E5F760
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.EndInvoke
	|
	|-RVA: 0x1E5FA40 Offset: 0x1E5FB41 VA: 0x1E5FA40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Rect>>>>.EndInvoke
	|
	|-RVA: 0x1E5FD20 Offset: 0x1E5FE21 VA: 0x1E5FD20
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, float>>>>.EndInvoke
	|
	|-RVA: 0x1E60000 Offset: 0x1E60101 VA: 0x1E60000
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, UniTask>>>>.EndInvoke
	|
	|-RVA: 0x1E602C0 Offset: 0x1E603C1 VA: 0x1E602C0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Unit>>>>.EndInvoke
	|
	|-RVA: 0x1E60580 Offset: 0x1E60681 VA: 0x1E60580
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector2>>>>.EndInvoke
	|
	|-RVA: 0x1E60860 Offset: 0x1E60961 VA: 0x1E60860
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector3>>>>.EndInvoke
	|
	|-RVA: 0x1E60B40 Offset: 0x1E60C41 VA: 0x1E60B40
	|-Func<UniTask<ValueTuple<bool, ValueTuple<bool, Vector4>>>>.EndInvoke
	|
	|-RVA: 0x1E60E20 Offset: 0x1E60F21 VA: 0x1E60E20
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, object>>>>.EndInvoke
	|
	|-RVA: 0x1E61100 Offset: 0x1E61201 VA: 0x1E61100
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object>>>>.EndInvoke
	|
	|-RVA: 0x1E613F0 Offset: 0x1E614F1 VA: 0x1E613F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E616F0 Offset: 0x1E617F1 VA: 0x1E616F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object>>>>.EndInvoke
	|
	|-RVA: 0x1E619F0 Offset: 0x1E61AF1 VA: 0x1E619F0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E61CF0 Offset: 0x1E61DF1 VA: 0x1E61CF0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object>>>>.EndInvoke
	|
	|-RVA: 0x1E62000 Offset: 0x1E62101 VA: 0x1E62000
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E62310 Offset: 0x1E62411 VA: 0x1E62310
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.EndInvoke
	|
	|-RVA: 0x1E62640 Offset: 0x1E62741 VA: 0x1E62640
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E62950 Offset: 0x1E62A51 VA: 0x1E62950
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.EndInvoke
	|
	|-RVA: 0x1E62C90 Offset: 0x1E62D91 VA: 0x1E62C90
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E62FC0 Offset: 0x1E630C1 VA: 0x1E62FC0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.EndInvoke
	|
	|-RVA: 0x1E632D0 Offset: 0x1E633D1 VA: 0x1E632D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E635D0 Offset: 0x1E636D1 VA: 0x1E635D0
	|-Func<UniTask<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.EndInvoke
	|
	|-RVA: 0x1E63880 Offset: 0x1E63981 VA: 0x1E63880
	|-Func<UniTask<ValueTuple<bool, AsyncUnit>>>.EndInvoke
	|
	|-RVA: 0x1E63B20 Offset: 0x1E63C21 VA: 0x1E63B20
	|-Func<UniTask<ValueTuple<bool, bool>>>.EndInvoke
	|
	|-RVA: 0x1E63DF0 Offset: 0x1E63EF1 VA: 0x1E63DF0
	|-Func<UniTask<ValueTuple<bool, Bounds>>>.EndInvoke
	|
	|-RVA: 0x1E640B0 Offset: 0x1E641B1 VA: 0x1E640B0
	|-Func<UniTask<ValueTuple<bool, byte>>>.EndInvoke
	|
	|-RVA: 0x1E64370 Offset: 0x1E64471 VA: 0x1E64370
	|-Func<UniTask<ValueTuple<bool, Color>>>.EndInvoke
	|
	|-RVA: 0x1E64650 Offset: 0x1E64751 VA: 0x1E64650
	|-Func<UniTask<ValueTuple<bool, double>>>.EndInvoke
	|
	|-RVA: 0x1E64910 Offset: 0x1E64A11 VA: 0x1E64910
	|-Func<UniTask<ValueTuple<bool, int>>>.EndInvoke
	|
	|-RVA: 0x1E64BD0 Offset: 0x1E64CD1 VA: 0x1E64BD0
	|-Func<UniTask<ValueTuple<bool, long>>>.EndInvoke
	|
	|-RVA: 0x1E64EB0 Offset: 0x1E64FB1 VA: 0x1E64EB0
	|-Func<UniTask<ValueTuple<bool, object>>>.EndInvoke
	|
	|-RVA: 0x1E65190 Offset: 0x1E65291 VA: 0x1E65190
	|-Func<UniTask<ValueTuple<bool, Quaternion>>>.EndInvoke
	|
	|-RVA: 0x1E65470 Offset: 0x1E65571 VA: 0x1E65470
	|-Func<UniTask<ValueTuple<bool, Rect>>>.EndInvoke
	|
	|-RVA: 0x1E65730 Offset: 0x1E65831 VA: 0x1E65730
	|-Func<UniTask<ValueTuple<bool, float>>>.EndInvoke
	|
	|-RVA: 0x1E659F0 Offset: 0x1E65AF1 VA: 0x1E659F0
	|-Func<UniTask<ValueTuple<bool, UniTask>>>.EndInvoke
	|
	|-RVA: 0x1E65CB0 Offset: 0x1E65DB1 VA: 0x1E65CB0
	|-Func<UniTask<ValueTuple<bool, Unit>>>.EndInvoke
	|
	|-RVA: 0x1E65F70 Offset: 0x1E66071 VA: 0x1E65F70
	|-Func<UniTask<ValueTuple<bool, Vector2>>>.EndInvoke
	|
	|-RVA: 0x1E66250 Offset: 0x1E66351 VA: 0x1E66250
	|-Func<UniTask<ValueTuple<bool, Vector3>>>.EndInvoke
	|
	|-RVA: 0x1E66530 Offset: 0x1E66631 VA: 0x1E66530
	|-Func<UniTask<ValueTuple<bool, Vector4>>>.EndInvoke
	|
	|-RVA: 0x1E66810 Offset: 0x1E66911 VA: 0x1E66810
	|-Func<UniTask<ValueTuple<int, object>>>.EndInvoke
	|
	|-RVA: 0x1E66AF0 Offset: 0x1E66BF1 VA: 0x1E66AF0
	|-Func<UniTask<ValueTuple<object, object>>>.EndInvoke
	|
	|-RVA: 0x1E66DE0 Offset: 0x1E66EE1 VA: 0x1E66DE0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.EndInvoke
	|
	|-RVA: 0x1E670C0 Offset: 0x1E671C1 VA: 0x1E670C0
	|-Func<UniTask<ValueTuple<object, object, object>>>.EndInvoke
	|
	|-RVA: 0x1E673B0 Offset: 0x1E674B1 VA: 0x1E673B0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.EndInvoke
	|
	|-RVA: 0x1E676B0 Offset: 0x1E677B1 VA: 0x1E676B0
	|-Func<UniTask<ValueTuple<object, object, object, object>>>.EndInvoke
	|
	|-RVA: 0x1E679B0 Offset: 0x1E67AB1 VA: 0x1E679B0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.EndInvoke
	|
	|-RVA: 0x1E67CB0 Offset: 0x1E67DB1 VA: 0x1E67CB0
	|-Func<UniTask<ValueTuple<object, object, object, object, object>>>.EndInvoke
	|
	|-RVA: 0x1E67FC0 Offset: 0x1E680C1 VA: 0x1E67FC0
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.EndInvoke
	|
	|-RVA: 0x1E682D0 Offset: 0x1E683D1 VA: 0x1E682D0
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object>>>.EndInvoke
	|
	|-RVA: 0x1E68600 Offset: 0x1E68701 VA: 0x1E68600
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.EndInvoke
	|
	|-RVA: 0x1E68910 Offset: 0x1E68A11 VA: 0x1E68910
	|-Func<UniTask<ValueTuple<object, object, object, object, object, object, object>>>.EndInvoke
	|
	|-RVA: 0x1E68C40 Offset: 0x1E68D41 VA: 0x1E68C40
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E68F70 Offset: 0x1E69071 VA: 0x1E68F70
	|-Func<UniTask<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.EndInvoke
	|
	|-RVA: 0x1E69220 Offset: 0x1E69321 VA: 0x1E69220
	|-Func<UniTask<AsyncUnit>>.EndInvoke
	|
	|-RVA: 0x1E694C0 Offset: 0x1E695C1 VA: 0x1E694C0
	|-Func<UniTask<bool>>.EndInvoke
	|
	|-RVA: 0x1E69780 Offset: 0x1E69881 VA: 0x1E69780
	|-Func<UniTask<Bounds>>.EndInvoke
	|
	|-RVA: 0x1E69A40 Offset: 0x1E69B41 VA: 0x1E69A40
	|-Func<UniTask<byte>>.EndInvoke
	|
	|-RVA: 0x1E69D00 Offset: 0x1E69E01 VA: 0x1E69D00
	|-Func<UniTask<Color>>.EndInvoke
	|
	|-RVA: 0x1E69FC0 Offset: 0x1E6A0C1 VA: 0x1E69FC0
	|-Func<UniTask<double>>.EndInvoke
	|
	|-RVA: 0x1E6A260 Offset: 0x1E6A361 VA: 0x1E6A260
	|-Func<UniTask<int>>.EndInvoke
	|
	|-RVA: 0x1E6A500 Offset: 0x1E6A601 VA: 0x1E6A500
	|-Func<UniTask<long>>.EndInvoke
	|
	|-RVA: 0x1E6A7A0 Offset: 0x1E6A8A1 VA: 0x1E6A7A0
	|-Func<UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E6AA60 Offset: 0x1E6AB61 VA: 0x1E6AA60
	|-Func<UniTask<Quaternion>>.EndInvoke
	|
	|-RVA: 0x1E6AD40 Offset: 0x1E6AE41 VA: 0x1E6AD40
	|-Func<UniTask<Rect>>.EndInvoke
	|
	|-RVA: 0x1E6B000 Offset: 0x1E6B101 VA: 0x1E6B000
	|-Func<UniTask<float>>.EndInvoke
	|
	|-RVA: 0x1E6B2A0 Offset: 0x1E6B3A1 VA: 0x1E6B2A0
	|-Func<UniTask<UniTask>>.EndInvoke
	|
	|-RVA: 0x1E6B540 Offset: 0x1E6B641 VA: 0x1E6B540
	|-Func<UniTask<Unit>>.EndInvoke
	|
	|-RVA: 0x1E6B7E0 Offset: 0x1E6B8E1 VA: 0x1E6B7E0
	|-Func<UniTask<Vector2>>.EndInvoke
	|
	|-RVA: 0x1E6BAA0 Offset: 0x1E6BBA1 VA: 0x1E6BAA0
	|-Func<UniTask<Vector3>>.EndInvoke
	|
	|-RVA: 0x1E6BD80 Offset: 0x1E6BE81 VA: 0x1E6BD80
	|-Func<UniTask<Vector4>>.EndInvoke
	|
	|-RVA: 0x1E6C040 Offset: 0x1E6C141 VA: 0x1E6C040
	|-Func<ValueTuple<bool, object>>.EndInvoke
	|
	|-RVA: 0x1E6C2D0 Offset: 0x1E6C3D1 VA: 0x1E6C2D0
	|-Func<ValueTuple<int, int>>.EndInvoke
	|
	|-RVA: 0x1E6C590 Offset: 0x1E6C691 VA: 0x1E6C590
	|-Func<ValueTuple<object, object, int>>.EndInvoke
	|
	|-RVA: 0x1E6C870 Offset: 0x1E6C971 VA: 0x1E6C870
	|-Func<ValueTuple<object, bool, bool, object, object>>.EndInvoke
	|
	|-RVA: 0x1E6CB30 Offset: 0x1E6CC31 VA: 0x1E6CB30
	|-Func<bool>.EndInvoke
	|
	|-RVA: 0x1E6CDD0 Offset: 0x1E6CED1 VA: 0x1E6CDD0
	|-Func<Color>.EndInvoke
	|
	|-RVA: 0x1E6D090 Offset: 0x1E6D191 VA: 0x1E6D090
	|-Func<DownloadStatus>.EndInvoke
	|
	|-RVA: 0x1E6D340 Offset: 0x1E6D441 VA: 0x1E6D340
	|-Func<int>.EndInvoke
	|
	|-RVA: 0x1E6D5D0 Offset: 0x1E6D6D1 VA: 0x1E6D5D0
	|-Func<Int32Enum>.EndInvoke
	|
	|-RVA: 0x1E6D860 Offset: 0x1E6D961 VA: 0x1E6D860
	|-Func<long>.EndInvoke
	|
	|-RVA: 0x1E6DAF0 Offset: 0x1E6DBF1 VA: 0x1E6DAF0
	|-Func<object>.EndInvoke
	|
	|-RVA: 0x1E6DD70 Offset: 0x1E6DE71 VA: 0x1E6DD70
	|-Func<SceneInstance>.EndInvoke
	|
	|-RVA: 0x1E6E000 Offset: 0x1E6E101 VA: 0x1E6E000
	|-Func<float>.EndInvoke
	|
	|-RVA: 0x1E6E290 Offset: 0x1E6E391 VA: 0x1E6E290
	|-Func<uint>.EndInvoke
	|
	|-RVA: 0x1E6E520 Offset: 0x1E6E621 VA: 0x1E6E520
	|-Func<UniTask>.EndInvoke
	|
	|-RVA: 0x1E6E7C0 Offset: 0x1E6E8C1 VA: 0x1E6E7C0
	|-Func<Unit>.EndInvoke
	|
	|-RVA: 0x1E6EA60 Offset: 0x1E6EB61 VA: 0x1E6EA60
	|-Func<Vector2>.EndInvoke
	|
	|-RVA: 0x1E6ED00 Offset: 0x1E6EE01 VA: 0x1E6ED00
	|-Func<Vector3>.EndInvoke
	|
	|-RVA: 0x1E6EFA0 Offset: 0x1E6F0A1 VA: 0x1E6EFA0
	|-Func<Vector4>.EndInvoke
	|
	|-RVA: 0x1E6F240 Offset: 0x1E6F341 VA: 0x1E6F240
	|-Func<VoidTaskResult>.EndInvoke
	*/
}

// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x46FAB0 Offset: 0x46FBB1 VA: 0x46FAB0
public sealed class Func<T, TResult> : MulticastDelegate // TypeDefIndex: 147
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E7DE80 Offset: 0x1E7DF81 VA: 0x1E7DE80
	|-Func<<>f__AnonymousType0<SpringBone, int>, SpringBone>..ctor
	|-Func<<>f__AnonymousType8<Type, Attribute[]>, <>f__AnonymousType9<Attribute[], Type>>..ctor
	|-Func<IObserver<Unit>, IDisposable>..ctor
	|-Func<object[], object>..ctor
	|-Func<Action, UnityAction>..ctor
	|-Func<AnimationClip, string>..ctor
	|-Func<Assembly, IEnumerable<Type>>..ctor
	|-Func<AssemblyName, Assembly>..ctor
	|-Func<CatchBlock, CatchBlock>..ctor
	|-Func<Component, string>..ctor
	|-Func<DynValue, DynValue>..ctor
	|-Func<DynValue, object>..ctor
	|-Func<DynValue, string>..ctor
	|-Func<DynamicExpression, WatchItem>..ctor
	|-Func<DynamicsNull, SpringColliderSerialization.TransformSerializer>..ctor
	|-Func<FieldInfo, VolumeParameter>..ctor
	|-Func<GUIContent, string>..ctor
	|-Func<GameObject, Transform>..ctor
	|-Func<IAsyncResult, HttpWebResponse>..ctor
	|-Func<IAsyncResult, Stream>..ctor
	|-Func<IAsyncResult, WebResponse>..ctor
	|-Func<Instruction, string>..ctor
	|-Func<LabelScopeInfo, LabelScopeInfo>..ctor
	|-Func<LightLambda, Delegate>..ctor
	|-Func<MemberHolder, MemberInfo[]>..ctor
	|-Func<MoonSharpHideMemberAttribute, string>..ctor
	|-Func<MoonSharpUserDataMetamethodAttribute, string>..ctor
	|-Func<object, DynValue>..ctor
	|-Func<object, object>..ctor
	|-Func<object, string>..ctor
	|-Func<Object, Component>..ctor
	|-Func<ParameterDescriptor, string>..ctor
	|-Func<ParameterInfo, ParameterDescriptor>..ctor
	|-Func<ParameterInfo, string>..ctor
	|-Func<Processor, WatchItem>..ctor
	|-Func<SkinnedMeshRenderer, Mesh>..ctor
	|-Func<SourceCode, string>..ctor
	|-Func<SpringBone, <>f__AnonymousType0<SpringBone, int>>..ctor
	|-Func<SpringBone, Transform>..ctor
	|-Func<SpringCapsuleCollider, string>..ctor
	|-Func<SpringCapsuleCollider, SpringColliderSerialization.CapsuleColliderSerializer>..ctor
	|-Func<SpringPanelCollider, string>..ctor
	|-Func<SpringPanelCollider, SpringColliderSerialization.PanelColliderSerializer>..ctor
	|-Func<SpringSphereCollider, string>..ctor
	|-Func<SpringSphereCollider, SpringColliderSerialization.SphereColliderSerializer>..ctor
	|-Func<string, GUIContent>..ctor
	|-Func<string, SpringCapsuleCollider>..ctor
	|-Func<string, SpringPanelCollider>..ctor
	|-Func<string, SpringSphereCollider>..ctor
	|-Func<string, string>..ctor
	|-Func<string, SymbolRef>..ctor
	|-Func<string, Transform>..ctor
	|-Func<SymbolRef, DynValue>..ctor
	|-Func<SymbolRef, string>..ctor
	|-Func<SymbolRef, SymbolRefExpression>..ctor
	|-Func<Transform, GameObject>..ctor
	|-Func<Transform, string>..ctor
	|-Func<Transform, SpringBoneSerialization.LengthLimitSerializer>..ctor
	|-Func<Transform, SpringBoneSerialization.PivotSerializer>..ctor
	|-Func<Type, <>f__AnonymousType8<Type, Attribute[]>>..ctor
	|-Func<Type, IEnumerable<Component>>..ctor
	|-Func<Type, string>..ctor
	|-Func<AddressablesImpl.ResourceLocatorInfo, IResourceLocator>..ctor
	|-Func<AddressablesImpl.ResourceLocatorInfo, string>..ctor
	|-Func<AssetBundleBuildMap.AssetBundleEntry, IEnumerable<string>>..ctor
	|-Func<AssetBundleBuildMap.AssetBundleEntry, IEnumerable<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>>..ctor
	|-Func<AssetBundleBuildMap.AssetBundleEntry, string>..ctor
	|-Func<SpringBoneSerialization.LengthLimitSerializer, Transform>..ctor
	|-Func<SpringBoneSerialization.PivotSerializer, string>..ctor
	|-Func<SpringBoneSerialization.SpringBoneSerializer, string>..ctor
	|-Func<SpringColliderSerialization.IColliderSerializer, string>..ctor
	|-Func<SpringColliderSerialization.TransformSerializer, string>..ctor
	|
	|-RVA: 0x1E7D2E0 Offset: 0x1E7D3E1 VA: 0x1E7D2E0
	|-Func<<>f__AnonymousType8<Type, Attribute[]>, bool>..ctor
	|-Func<IList<bool>, bool>..ctor
	|-Func<AsyncDebugger, bool>..ctor
	|-Func<Character, bool>..ctor
	|-Func<Component, bool>..ctor
	|-Func<DebugUIHandlerWidget, bool>..ctor
	|-Func<DynValue, bool>..ctor
	|-Func<Expression, bool>..ctor
	|-Func<FieldInfo, bool>..ctor
	|-Func<FoodstuffData, bool>..ctor
	|-Func<GmapSpot, bool>..ctor
	|-Func<IOverloadableMemberDescriptor, bool>..ctor
	|-Func<IResourceProvider, bool>..ctor
	|-Func<Mesh, bool>..ctor
	|-Func<MethodInfo, bool>..ctor
	|-Func<object, bool>..ctor
	|-Func<ParameterDescriptor, bool>..ctor
	|-Func<ParameterInfo, bool>..ctor
	|-Func<SkillData, bool>..ctor
	|-Func<SkinnedMeshRenderer, bool>..ctor
	|-Func<SourceCode, bool>..ctor
	|-Func<SpringBone, bool>..ctor
	|-Func<SpringCapsuleCollider, bool>..ctor
	|-Func<SpringPanelCollider, bool>..ctor
	|-Func<SpringSphereCollider, bool>..ctor
	|-Func<string, bool>..ctor
	|-Func<SwitchCase, bool>..ctor
	|-Func<TasteData, bool>..ctor
	|-Func<Toggle, bool>..ctor
	|-Func<Transform, bool>..ctor
	|-Func<Type, bool>..ctor
	|-Func<TypedStringToValueMap, bool>..ctor
	|-Func<AddressablesImpl.ResourceLocatorInfo, bool>..ctor
	|-Func<AssetBundleBuildMap.AssetBundleEntry, bool>..ctor
	|-Func<DebugUI.Widget, bool>..ctor
	|-Func<PlayerEditorConnectionEvents.MessageTypeSubscribers, bool>..ctor
	|-Func<SpringBoneSerialization.LengthLimitSerializer, bool>..ctor
	|-Func<SpringBoneSerialization.SpringBoneSerializer, bool>..ctor
	|-Func<SpringColliderSerialization.IColliderSerializer, bool>..ctor
	|-Func<SpringColliderSerialization.TransformSerializer, bool>..ctor
	|-Func<TextRecordParsing.Record, bool>..ctor
	|
	|-RVA: 0x1E71A80 Offset: 0x1E71B81 VA: 0x1E71A80
	|-Func<AsyncOperationHandle<List<string>>, AsyncOperationHandle<List<IResourceLocator>>>..ctor
	|-Func<AsyncOperationHandle<ContentCatalogData>, AsyncOperationHandle<IResourceLocator>>..ctor
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1E71EC0 Offset: 0x1E71FC1 VA: 0x1E71EC0
	|-Func<AsyncOperationHandle<SceneInstance>, AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x1E72300 Offset: 0x1E72401 VA: 0x1E72300
	|-Func<KeyValuePair<int, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x1E72650 Offset: 0x1E72751 VA: 0x1E72650
	|-Func<KeyValuePair<int, object>, bool>..ctor
	|
	|-RVA: 0x1E729A0 Offset: 0x1E72AA1 VA: 0x1E729A0
	|-Func<KeyValuePair<object, int>, int>..ctor
	|-Func<KeyValuePair<Unit, int>, int>..ctor
	|
	|-RVA: 0x1E72CE0 Offset: 0x1E72DE1 VA: 0x1E72CE0
	|-Func<KeyValuePair<object, int>, object>..ctor
	|-Func<KeyValuePair<Unit, int>, Unit>..ctor
	|
	|-RVA: 0x1E73000 Offset: 0x1E73101 VA: 0x1E73000
	|-Func<KeyValuePair<object, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x1E73350 Offset: 0x1E73451 VA: 0x1E73350
	|-Func<KeyValuePair<object, object>, UniTask<object>>..ctor
	|
	|-RVA: 0x1E736A0 Offset: 0x1E737A1 VA: 0x1E736A0
	|-Func<KeyValuePair<object, object>, bool>..ctor
	|-Func<KeyValuePair<string, object>, bool>..ctor
	|
	|-RVA: 0x1E739F0 Offset: 0x1E73AF1 VA: 0x1E739F0
	|-Func<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x1E73D30 Offset: 0x1E73E31 VA: 0x1E73D30
	|-Func<KeyValuePair<object, object>, object>..ctor
	|-Func<KeyValuePair<string, object>, string>..ctor
	|-Func<KeyValuePair<Type, IUserDataDescriptor>, Type>..ctor
	|
	|-RVA: 0x1E74050 Offset: 0x1E74151 VA: 0x1E74050
	|-Func<KeyValuePair<object, object>, UniTask>..ctor
	|
	|-RVA: 0x1E74390 Offset: 0x1E74491 VA: 0x1E74390
	|-Func<Pair<int>, Pair<int>>..ctor
	|
	|-RVA: 0x1E746C0 Offset: 0x1E747C1 VA: 0x1E746C0
	|-Func<UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x1E74A10 Offset: 0x1E74B11 VA: 0x1E74A10
	|-Func<UniTask<object>, bool>..ctor
	|
	|-RVA: 0x1E74D60 Offset: 0x1E74E61 VA: 0x1E74D60
	|-Func<ValueTuple<object, object>, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x1E750B0 Offset: 0x1E751B1 VA: 0x1E750B0
	|-Func<ValueTuple<float, int>, ValueTuple<float, int>>..ctor
	|
	|-RVA: 0x1E753E0 Offset: 0x1E754E1 VA: 0x1E753E0
	|-Func<ValueTuple<float, int>, bool>..ctor
	|
	|-RVA: 0x1E75710 Offset: 0x1E75811 VA: 0x1E75710
	|-Func<ValueTuple<float, Int32Enum>, ValueTuple<float, Int32Enum>>..ctor
	|
	|-RVA: 0x1E75A40 Offset: 0x1E75B41 VA: 0x1E75A40
	|-Func<ValueTuple<float, Int32Enum>, bool>..ctor
	|
	|-RVA: 0x1E7B740 Offset: 0x1E7B841 VA: 0x1E7B740
	|-Func<AsyncDebugger, KeyValuePair<int, string>>..ctor
	|-Func<object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x1E7D6C0 Offset: 0x1E7D7C1 VA: 0x1E7D6C0
	|-Func<AsyncDebugger, int>..ctor
	|-Func<DynValue, int>..ctor
	|-Func<FieldInfo, int>..ctor
	|-Func<object, int>..ctor
	|-Func<string, int>..ctor
	|
	|-RVA: 0x1E765F0 Offset: 0x1E766F1 VA: 0x1E765F0
	|-Func<AsyncOperationHandle, AsyncOperationHandle<IList<IAssetBundleResource>>>..ctor
	|-Func<AsyncOperationHandle, AsyncOperationHandle<IList<IResourceLocation>>>..ctor
	|-Func<AsyncOperationHandle, AsyncOperationHandle<GameObject>>..ctor
	|-Func<AsyncOperationHandle, AsyncOperationHandle<IResourceLocator>>..ctor
	|-Func<AsyncOperationHandle, AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x1E75D70 Offset: 0x1E75E71 VA: 0x1E75D70
	|-Func<AsyncOperationHandle, AsyncOperationHandle<bool>>..ctor
	|
	|-RVA: 0x1E761B0 Offset: 0x1E762B1 VA: 0x1E761B0
	|-Func<AsyncOperationHandle, AsyncOperationHandle<long>>..ctor
	|
	|-RVA: 0x1E76A30 Offset: 0x1E76B31 VA: 0x1E76A30
	|-Func<AsyncOperationHandle, AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0x1E76E70 Offset: 0x1E76F71 VA: 0x1E76E70
	|-Func<bool, bool>..ctor
	|
	|-RVA: 0x1E77190 Offset: 0x1E77291 VA: 0x1E77190
	|-Func<bool, object>..ctor
	|
	|-RVA: 0x1E77490 Offset: 0x1E77591 VA: 0x1E77490
	|-Func<CancellationToken, Task<ValueTuple<int, int>>>..ctor
	|-Func<CancellationToken, Task<HttpWebResponse>>..ctor
	|-Func<CancellationToken, Task<Stream>>..ctor
	|-Func<CancellationToken, object>..ctor
	|
	|-RVA: 0x1E777A0 Offset: 0x1E778A1 VA: 0x1E777A0
	|-Func<char, bool>..ctor
	|
	|-RVA: 0x1E77AB0 Offset: 0x1E77BB1 VA: 0x1E77AB0
	|-Func<char, char>..ctor
	|
	|-RVA: 0x1E77DC0 Offset: 0x1E77EC1 VA: 0x1E77DC0
	|-Func<Color, bool>..ctor
	|
	|-RVA: 0x1E78150 Offset: 0x1E78251 VA: 0x1E78150
	|-Func<ContourVertex, bool>..ctor
	|
	|-RVA: 0x1E78550 Offset: 0x1E78651 VA: 0x1E78550
	|-Func<ContourVertex, Color>..ctor
	|
	|-RVA: 0x1E78950 Offset: 0x1E78A51 VA: 0x1E78950
	|-Func<ContourVertex, Vector3>..ctor
	|
	|-RVA: 0x1E78D50 Offset: 0x1E78E51 VA: 0x1E78D50
	|-Func<ContourVertex, float3>..ctor
	|
	|-RVA: 0x1E79150 Offset: 0x1E79251 VA: 0x1E79150
	|-Func<DiagnosticEvent, int>..ctor
	|
	|-RVA: 0x1E79590 Offset: 0x1E79691 VA: 0x1E79590
	|-Func<double, double>..ctor
	|
	|-RVA: 0x1E7EA00 Offset: 0x1E7EB01 VA: 0x1E7EA00
	|-Func<Glyph, uint>..ctor
	|-Func<KerningPair, uint>..ctor
	|-Func<object, uint>..ctor
	|-Func<TMP_Character, uint>..ctor
	|-Func<TMP_GlyphPairAdjustmentRecord, uint>..ctor
	|-Func<TMP_SpriteCharacter, uint>..ctor
	|-Func<TMP_SpriteGlyph, uint>..ctor
	|
	|-RVA: 0x1E7F5A0 Offset: 0x1E7F6A1 VA: 0x1E7F5A0
	|-Func<IAsyncResult, Unit>..ctor
	|-Func<object, Unit>..ctor
	|
	|-RVA: 0x1E7E620 Offset: 0x1E7E721 VA: 0x1E7E620
	|-Func<ILayoutElement, float>..ctor
	|-Func<object, float>..ctor
	|
	|-RVA: 0x1E798B0 Offset: 0x1E799B1 VA: 0x1E798B0
	|-Func<int, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x1E79BC0 Offset: 0x1E79CC1 VA: 0x1E79BC0
	|-Func<int, UniTask<object>>..ctor
	|
	|-RVA: 0x1E79ED0 Offset: 0x1E79FD1 VA: 0x1E79ED0
	|-Func<int, bool>..ctor
	|
	|-RVA: 0x1E7A1E0 Offset: 0x1E7A2E1 VA: 0x1E7A1E0
	|-Func<int, int>..ctor
	|
	|-RVA: 0x1E7A4F0 Offset: 0x1E7A5F1 VA: 0x1E7A4F0
	|-Func<int, object>..ctor
	|-Func<int, Transform>..ctor
	|
	|-RVA: 0x1E7A7E0 Offset: 0x1E7A8E1 VA: 0x1E7A7E0
	|-Func<int, UniTask>..ctor
	|
	|-RVA: 0x1E7AAF0 Offset: 0x1E7ABF1 VA: 0x1E7AAF0
	|-Func<Int32Enum, bool>..ctor
	|
	|-RVA: 0x1E7AE30 Offset: 0x1E7AF31 VA: 0x1E7AE30
	|-Func<long, bool>..ctor
	|
	|-RVA: 0x1E7B140 Offset: 0x1E7B241 VA: 0x1E7B140
	|-Func<long, long>..ctor
	|
	|-RVA: 0x1E7B450 Offset: 0x1E7B551 VA: 0x1E7B450
	|-Func<long, object>..ctor
	|
	|-RVA: 0x1E7BB20 Offset: 0x1E7BC21 VA: 0x1E7BB20
	|-Func<object, Nullable<int>>..ctor
	|
	|-RVA: 0x1E7BF00 Offset: 0x1E7C001 VA: 0x1E7BF00
	|-Func<object, UniTask<object>>..ctor
	|
	|-RVA: 0x1E7C2E0 Offset: 0x1E7C3E1 VA: 0x1E7C2E0
	|-Func<object, ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1E7C6C0 Offset: 0x1E7C7C1 VA: 0x1E7C6C0
	|-Func<object, ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x1E7CAA0 Offset: 0x1E7CBA1 VA: 0x1E7CAA0
	|-Func<object, ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1E7CEC0 Offset: 0x1E7CFC1 VA: 0x1E7CEC0
	|-Func<object, ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1E7DAA0 Offset: 0x1E7DBA1 VA: 0x1E7DAA0
	|-Func<object, long>..ctor
	|
	|-RVA: 0x1E7E240 Offset: 0x1E7E341 VA: 0x1E7E240
	|-Func<object, SceneInstance>..ctor
	|
	|-RVA: 0x1E7EDE0 Offset: 0x1E7EEE1 VA: 0x1E7EDE0
	|-Func<object, ulong>..ctor
	|
	|-RVA: 0x1E7F1C0 Offset: 0x1E7F2C1 VA: 0x1E7F1C0
	|-Func<object, UniTask>..ctor
	|
	|-RVA: 0x1E7F990 Offset: 0x1E7FA91 VA: 0x1E7F990
	|-Func<object, VoidTaskResult>..ctor
	|
	|-RVA: 0x1E7FD80 Offset: 0x1E7FE81 VA: 0x1E7FD80
	|-Func<float, bool>..ctor
	|
	|-RVA: 0x1E800A0 Offset: 0x1E801A1 VA: 0x1E800A0
	|-Func<float, float>..ctor
	|
	|-RVA: 0x1E803C0 Offset: 0x1E804C1 VA: 0x1E803C0
	|-Func<TablePair, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x1E80710 Offset: 0x1E80811 VA: 0x1E80710
	|-Func<TablePair, UniTask<object>>..ctor
	|
	|-RVA: 0x1E80A60 Offset: 0x1E80B61 VA: 0x1E80A60
	|-Func<TablePair, bool>..ctor
	|
	|-RVA: 0x1E810F0 Offset: 0x1E811F1 VA: 0x1E810F0
	|-Func<TablePair, DynValue>..ctor
	|-Func<TablePair, object>..ctor
	|
	|-RVA: 0x1E80DB0 Offset: 0x1E80EB1 VA: 0x1E80DB0
	|-Func<TablePair, int>..ctor
	|
	|-RVA: 0x1E81410 Offset: 0x1E81511 VA: 0x1E81410
	|-Func<TablePair, TablePair>..ctor
	|
	|-RVA: 0x1E81760 Offset: 0x1E81861 VA: 0x1E81760
	|-Func<TablePair, UniTask>..ctor
	|
	|-RVA: 0x1E81AA0 Offset: 0x1E81BA1 VA: 0x1E81AA0
	|-Func<ulong, object>..ctor
	|
	|-RVA: 0x1E81D90 Offset: 0x1E81E91 VA: 0x1E81D90
	|-Func<ulong, ulong>..ctor
	|
	|-RVA: 0x1E820A0 Offset: 0x1E821A1 VA: 0x1E820A0
	|-Func<UniTask, bool>..ctor
	|
	|-RVA: 0x1E823D0 Offset: 0x1E824D1 VA: 0x1E823D0
	|-Func<UniTask, UniTask>..ctor
	|
	|-RVA: 0x1E82700 Offset: 0x1E82801 VA: 0x1E82700
	|-Func<Unit, bool>..ctor
	|
	|-RVA: 0x1E82A40 Offset: 0x1E82B41 VA: 0x1E82A40
	|-Func<Unit, object>..ctor
	|
	|-RVA: 0x1E82D50 Offset: 0x1E82E51 VA: 0x1E82D50
	|-Func<Unit, Unit>..ctor
	|
	|-RVA: 0x1E83090 Offset: 0x1E83191 VA: 0x1E83090
	|-Func<Vector3, bool>..ctor
	|
	|-RVA: 0x1E83420 Offset: 0x1E83521 VA: 0x1E83420
	|-Func<float3, bool>..ctor
	|
	|-RVA: 0x1E837B0 Offset: 0x1E838B1 VA: 0x1E837B0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x1E83B00 Offset: 0x1E83C01 VA: 0x1E83B00
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>..ctor
	|
	|-RVA: 0x1E83E50 Offset: 0x1E83F51 VA: 0x1E83E50
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, bool>..ctor
	|
	|-RVA: 0x1E841A0 Offset: 0x1E842A1 VA: 0x1E841A0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>..ctor
	|
	|-RVA: 0x1E844E0 Offset: 0x1E845E1 VA: 0x1E844E0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>..ctor
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, string>..ctor
	|
	|-RVA: 0x1E84800 Offset: 0x1E84901 VA: 0x1E84800
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E71AA0 Offset: 0x1E71BA1 VA: 0x1E71AA0
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>.Invoke
	|
	|-RVA: 0x1E71EE0 Offset: 0x1E71FE1 VA: 0x1E71EE0
	|-Func<AsyncOperationHandle<SceneInstance>, AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0x1E72320 Offset: 0x1E72421 VA: 0x1E72320
	|-Func<KeyValuePair<int, object>, KeyValuePair<int, object>>.Invoke
	|
	|-RVA: 0x1E72670 Offset: 0x1E72771 VA: 0x1E72670
	|-Func<KeyValuePair<int, object>, bool>.Invoke
	|
	|-RVA: 0x1E729C0 Offset: 0x1E72AC1 VA: 0x1E729C0
	|-Func<KeyValuePair<object, int>, int>.Invoke
	|
	|-RVA: 0x1E72D00 Offset: 0x1E72E01 VA: 0x1E72D00
	|-Func<KeyValuePair<object, int>, object>.Invoke
	|
	|-RVA: 0x1E73020 Offset: 0x1E73121 VA: 0x1E73020
	|-Func<KeyValuePair<object, object>, KeyValuePair<int, object>>.Invoke
	|
	|-RVA: 0x1E73370 Offset: 0x1E73471 VA: 0x1E73370
	|-Func<KeyValuePair<object, object>, UniTask<object>>.Invoke
	|
	|-RVA: 0x1E736C0 Offset: 0x1E737C1 VA: 0x1E736C0
	|-Func<KeyValuePair<object, object>, bool>.Invoke
	|
	|-RVA: 0x1E73A10 Offset: 0x1E73B11 VA: 0x1E73A10
	|-Func<KeyValuePair<object, object>, int>.Invoke
	|
	|-RVA: 0x1E73D50 Offset: 0x1E73E51 VA: 0x1E73D50
	|-Func<KeyValuePair<object, object>, object>.Invoke
	|
	|-RVA: 0x1E74070 Offset: 0x1E74171 VA: 0x1E74070
	|-Func<KeyValuePair<object, object>, UniTask>.Invoke
	|
	|-RVA: 0x1E743B0 Offset: 0x1E744B1 VA: 0x1E743B0
	|-Func<Pair<int>, Pair<int>>.Invoke
	|
	|-RVA: 0x1E746E0 Offset: 0x1E747E1 VA: 0x1E746E0
	|-Func<UniTask<object>, UniTask<object>>.Invoke
	|
	|-RVA: 0x1E74A30 Offset: 0x1E74B31 VA: 0x1E74A30
	|-Func<UniTask<object>, bool>.Invoke
	|
	|-RVA: 0x1E74D80 Offset: 0x1E74E81 VA: 0x1E74D80
	|-Func<ValueTuple<object, object>, ValueTuple<object, object>>.Invoke
	|
	|-RVA: 0x1E750D0 Offset: 0x1E751D1 VA: 0x1E750D0
	|-Func<ValueTuple<float, int>, ValueTuple<float, int>>.Invoke
	|
	|-RVA: 0x1E75400 Offset: 0x1E75501 VA: 0x1E75400
	|-Func<ValueTuple<float, int>, bool>.Invoke
	|
	|-RVA: 0x1E75730 Offset: 0x1E75831 VA: 0x1E75730
	|-Func<ValueTuple<float, Int32Enum>, ValueTuple<float, Int32Enum>>.Invoke
	|
	|-RVA: 0x1E75A60 Offset: 0x1E75B61 VA: 0x1E75A60
	|-Func<ValueTuple<float, Int32Enum>, bool>.Invoke
	|
	|-RVA: 0x1E7DEA0 Offset: 0x1E7DFA1 VA: 0x1E7DEA0
	|-Func<AssemblyName, Assembly>.Invoke
	|-Func<DynValue, object>.Invoke
	|-Func<GameObject, Transform>.Invoke
	|-Func<IResourceLocation, string>.Invoke
	|-Func<LightLambda, Delegate>.Invoke
	|-Func<object, DynValue>.Invoke
	|-Func<object, object>.Invoke
	|-Func<SourceCode, string>.Invoke
	|-Func<Stream, Task>.Invoke
	|-Func<string, string>.Invoke
	|
	|-RVA: 0x1E75D90 Offset: 0x1E75E91 VA: 0x1E75D90
	|-Func<AsyncOperationHandle, AsyncOperationHandle<bool>>.Invoke
	|
	|-RVA: 0x1E761D0 Offset: 0x1E762D1 VA: 0x1E761D0
	|-Func<AsyncOperationHandle, AsyncOperationHandle<long>>.Invoke
	|
	|-RVA: 0x1E76610 Offset: 0x1E76711 VA: 0x1E76610
	|-Func<AsyncOperationHandle, AsyncOperationHandle<object>>.Invoke
	|
	|-RVA: 0x1E76A50 Offset: 0x1E76B51 VA: 0x1E76A50
	|-Func<AsyncOperationHandle, AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0x1E76E90 Offset: 0x1E76F91 VA: 0x1E76E90
	|-Func<bool, bool>.Invoke
	|
	|-RVA: 0x1E771B0 Offset: 0x1E772B1 VA: 0x1E771B0
	|-Func<bool, GameObject>.Invoke
	|-Func<bool, object>.Invoke
	|
	|-RVA: 0x1E774B0 Offset: 0x1E775B1 VA: 0x1E774B0
	|-Func<CancellationToken, IEnumerator>.Invoke
	|-Func<CancellationToken, object>.Invoke
	|
	|-RVA: 0x1E777C0 Offset: 0x1E778C1 VA: 0x1E777C0
	|-Func<char, bool>.Invoke
	|
	|-RVA: 0x1E77AD0 Offset: 0x1E77BD1 VA: 0x1E77AD0
	|-Func<char, char>.Invoke
	|
	|-RVA: 0x1E7D300 Offset: 0x1E7D401 VA: 0x1E7D300
	|-Func<Character, bool>.Invoke
	|-Func<Exception, bool>.Invoke
	|-Func<GmapSpot, bool>.Invoke
	|-Func<object, bool>.Invoke
	|-Func<SkillData, bool>.Invoke
	|-Func<string, bool>.Invoke
	|-Func<Transform, bool>.Invoke
	|
	|-RVA: 0x1E77DE0 Offset: 0x1E77EE1 VA: 0x1E77DE0
	|-Func<Color, bool>.Invoke
	|
	|-RVA: 0x1E78170 Offset: 0x1E78271 VA: 0x1E78170
	|-Func<ContourVertex, bool>.Invoke
	|
	|-RVA: 0x1E78570 Offset: 0x1E78671 VA: 0x1E78570
	|-Func<ContourVertex, Color>.Invoke
	|
	|-RVA: 0x1E78970 Offset: 0x1E78A71 VA: 0x1E78970
	|-Func<ContourVertex, Vector3>.Invoke
	|
	|-RVA: 0x1E78D70 Offset: 0x1E78E71 VA: 0x1E78D70
	|-Func<ContourVertex, float3>.Invoke
	|
	|-RVA: 0x1E79170 Offset: 0x1E79271 VA: 0x1E79170
	|-Func<DiagnosticEvent, int>.Invoke
	|
	|-RVA: 0x1E795B0 Offset: 0x1E796B1 VA: 0x1E795B0
	|-Func<double, double>.Invoke
	|
	|-RVA: 0x1E7E640 Offset: 0x1E7E741 VA: 0x1E7E640
	|-Func<ILayoutElement, float>.Invoke
	|-Func<object, float>.Invoke
	|
	|-RVA: 0x1E798D0 Offset: 0x1E799D1 VA: 0x1E798D0
	|-Func<int, KeyValuePair<int, object>>.Invoke
	|
	|-RVA: 0x1E79BE0 Offset: 0x1E79CE1 VA: 0x1E79BE0
	|-Func<int, UniTask<object>>.Invoke
	|
	|-RVA: 0x1E79EF0 Offset: 0x1E79FF1 VA: 0x1E79EF0
	|-Func<int, bool>.Invoke
	|
	|-RVA: 0x1E7A200 Offset: 0x1E7A301 VA: 0x1E7A200
	|-Func<int, int>.Invoke
	|
	|-RVA: 0x1E7A510 Offset: 0x1E7A611 VA: 0x1E7A510
	|-Func<int, object>.Invoke
	|
	|-RVA: 0x1E7A800 Offset: 0x1E7A901 VA: 0x1E7A800
	|-Func<int, UniTask>.Invoke
	|
	|-RVA: 0x1E7AB10 Offset: 0x1E7AC11 VA: 0x1E7AB10
	|-Func<Int32Enum, bool>.Invoke
	|-Func<NativeInputUpdateType, bool>.Invoke
	|
	|-RVA: 0x1E7AE50 Offset: 0x1E7AF51 VA: 0x1E7AE50
	|-Func<long, bool>.Invoke
	|
	|-RVA: 0x1E7B160 Offset: 0x1E7B261 VA: 0x1E7B160
	|-Func<long, long>.Invoke
	|
	|-RVA: 0x1E7B470 Offset: 0x1E7B571 VA: 0x1E7B470
	|-Func<long, object>.Invoke
	|
	|-RVA: 0x1E7D6E0 Offset: 0x1E7D7E1 VA: 0x1E7D6E0
	|-Func<LuaState, int>.Invoke
	|-Func<object, int>.Invoke
	|-Func<string, int>.Invoke
	|
	|-RVA: 0x1E7B760 Offset: 0x1E7B861 VA: 0x1E7B760
	|-Func<object, KeyValuePair<int, object>>.Invoke
	|
	|-RVA: 0x1E7BB40 Offset: 0x1E7BC41 VA: 0x1E7BB40
	|-Func<object, Nullable<int>>.Invoke
	|
	|-RVA: 0x1E7BF20 Offset: 0x1E7C021 VA: 0x1E7BF20
	|-Func<object, UniTask<object>>.Invoke
	|
	|-RVA: 0x1E7C300 Offset: 0x1E7C401 VA: 0x1E7C300
	|-Func<object, ValueTuple<bool, object>>.Invoke
	|
	|-RVA: 0x1E7C6E0 Offset: 0x1E7C7E1 VA: 0x1E7C6E0
	|-Func<object, ValueTuple<int, int>>.Invoke
	|
	|-RVA: 0x1E7CAC0 Offset: 0x1E7CBC1 VA: 0x1E7CAC0
	|-Func<object, ValueTuple<object, object, int>>.Invoke
	|
	|-RVA: 0x1E7CEE0 Offset: 0x1E7CFE1 VA: 0x1E7CEE0
	|-Func<object, ValueTuple<object, bool, bool, object, object>>.Invoke
	|
	|-RVA: 0x1E7DAC0 Offset: 0x1E7DBC1 VA: 0x1E7DAC0
	|-Func<object, long>.Invoke
	|
	|-RVA: 0x1E7E260 Offset: 0x1E7E361 VA: 0x1E7E260
	|-Func<object, SceneInstance>.Invoke
	|
	|-RVA: 0x1E7EA20 Offset: 0x1E7EB21 VA: 0x1E7EA20
	|-Func<object, uint>.Invoke
	|
	|-RVA: 0x1E7EE00 Offset: 0x1E7EF01 VA: 0x1E7EE00
	|-Func<object, ulong>.Invoke
	|
	|-RVA: 0x1E7F1E0 Offset: 0x1E7F2E1 VA: 0x1E7F1E0
	|-Func<object, UniTask>.Invoke
	|
	|-RVA: 0x1E7F5C0 Offset: 0x1E7F6C1 VA: 0x1E7F5C0
	|-Func<object, Unit>.Invoke
	|
	|-RVA: 0x1E7F9B0 Offset: 0x1E7FAB1 VA: 0x1E7F9B0
	|-Func<object, VoidTaskResult>.Invoke
	|
	|-RVA: 0x1E7FDA0 Offset: 0x1E7FEA1 VA: 0x1E7FDA0
	|-Func<float, bool>.Invoke
	|
	|-RVA: 0x1E800C0 Offset: 0x1E801C1 VA: 0x1E800C0
	|-Func<float, float>.Invoke
	|
	|-RVA: 0x1E803E0 Offset: 0x1E804E1 VA: 0x1E803E0
	|-Func<TablePair, KeyValuePair<int, object>>.Invoke
	|
	|-RVA: 0x1E80730 Offset: 0x1E80831 VA: 0x1E80730
	|-Func<TablePair, UniTask<object>>.Invoke
	|
	|-RVA: 0x1E80A80 Offset: 0x1E80B81 VA: 0x1E80A80
	|-Func<TablePair, bool>.Invoke
	|
	|-RVA: 0x1E80DD0 Offset: 0x1E80ED1 VA: 0x1E80DD0
	|-Func<TablePair, int>.Invoke
	|
	|-RVA: 0x1E81110 Offset: 0x1E81211 VA: 0x1E81110
	|-Func<TablePair, object>.Invoke
	|
	|-RVA: 0x1E81430 Offset: 0x1E81531 VA: 0x1E81430
	|-Func<TablePair, TablePair>.Invoke
	|
	|-RVA: 0x1E81780 Offset: 0x1E81881 VA: 0x1E81780
	|-Func<TablePair, UniTask>.Invoke
	|
	|-RVA: 0x1E81AC0 Offset: 0x1E81BC1 VA: 0x1E81AC0
	|-Func<ulong, object>.Invoke
	|
	|-RVA: 0x1E81DB0 Offset: 0x1E81EB1 VA: 0x1E81DB0
	|-Func<ulong, ulong>.Invoke
	|
	|-RVA: 0x1E820C0 Offset: 0x1E821C1 VA: 0x1E820C0
	|-Func<UniTask, bool>.Invoke
	|
	|-RVA: 0x1E823F0 Offset: 0x1E824F1 VA: 0x1E823F0
	|-Func<UniTask, UniTask>.Invoke
	|
	|-RVA: 0x1E82720 Offset: 0x1E82821 VA: 0x1E82720
	|-Func<Unit, bool>.Invoke
	|
	|-RVA: 0x1E82A60 Offset: 0x1E82B61 VA: 0x1E82A60
	|-Func<Unit, object>.Invoke
	|
	|-RVA: 0x1E82D70 Offset: 0x1E82E71 VA: 0x1E82D70
	|-Func<Unit, Unit>.Invoke
	|
	|-RVA: 0x1E830B0 Offset: 0x1E831B1 VA: 0x1E830B0
	|-Func<Vector3, bool>.Invoke
	|
	|-RVA: 0x1E83440 Offset: 0x1E83541 VA: 0x1E83440
	|-Func<float3, bool>.Invoke
	|
	|-RVA: 0x1E837D0 Offset: 0x1E838D1 VA: 0x1E837D0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Invoke
	|
	|-RVA: 0x1E83B20 Offset: 0x1E83C21 VA: 0x1E83B20
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Invoke
	|
	|-RVA: 0x1E83E70 Offset: 0x1E83F71 VA: 0x1E83E70
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, bool>.Invoke
	|
	|-RVA: 0x1E841C0 Offset: 0x1E842C1 VA: 0x1E841C0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Invoke
	|
	|-RVA: 0x1E84500 Offset: 0x1E84601 VA: 0x1E84500
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Invoke
	|
	|-RVA: 0x1E84820 Offset: 0x1E84921 VA: 0x1E84820
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T arg, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E71DE0 Offset: 0x1E71EE1 VA: 0x1E71DE0
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>.BeginInvoke
	|
	|-RVA: 0x1E72220 Offset: 0x1E72321 VA: 0x1E72220
	|-Func<AsyncOperationHandle<SceneInstance>, AsyncOperationHandle<SceneInstance>>.BeginInvoke
	|
	|-RVA: 0x1E72590 Offset: 0x1E72691 VA: 0x1E72590
	|-Func<KeyValuePair<int, object>, KeyValuePair<int, object>>.BeginInvoke
	|
	|-RVA: 0x1E728E0 Offset: 0x1E729E1 VA: 0x1E728E0
	|-Func<KeyValuePair<int, object>, bool>.BeginInvoke
	|
	|-RVA: 0x1E72C20 Offset: 0x1E72D21 VA: 0x1E72C20
	|-Func<KeyValuePair<object, int>, int>.BeginInvoke
	|
	|-RVA: 0x1E72F60 Offset: 0x1E73061 VA: 0x1E72F60
	|-Func<KeyValuePair<object, int>, object>.BeginInvoke
	|
	|-RVA: 0x1E73290 Offset: 0x1E73391 VA: 0x1E73290
	|-Func<KeyValuePair<object, object>, KeyValuePair<int, object>>.BeginInvoke
	|
	|-RVA: 0x1E735E0 Offset: 0x1E736E1 VA: 0x1E735E0
	|-Func<KeyValuePair<object, object>, UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E73930 Offset: 0x1E73A31 VA: 0x1E73930
	|-Func<KeyValuePair<object, object>, bool>.BeginInvoke
	|
	|-RVA: 0x1E73C70 Offset: 0x1E73D71 VA: 0x1E73C70
	|-Func<KeyValuePair<object, object>, int>.BeginInvoke
	|
	|-RVA: 0x1E73FB0 Offset: 0x1E740B1 VA: 0x1E73FB0
	|-Func<KeyValuePair<object, object>, object>.BeginInvoke
	|
	|-RVA: 0x1E742D0 Offset: 0x1E743D1 VA: 0x1E742D0
	|-Func<KeyValuePair<object, object>, UniTask>.BeginInvoke
	|
	|-RVA: 0x1E74600 Offset: 0x1E74701 VA: 0x1E74600
	|-Func<Pair<int>, Pair<int>>.BeginInvoke
	|
	|-RVA: 0x1E74950 Offset: 0x1E74A51 VA: 0x1E74950
	|-Func<UniTask<object>, UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E74CA0 Offset: 0x1E74DA1 VA: 0x1E74CA0
	|-Func<UniTask<object>, bool>.BeginInvoke
	|
	|-RVA: 0x1E74FF0 Offset: 0x1E750F1 VA: 0x1E74FF0
	|-Func<ValueTuple<object, object>, ValueTuple<object, object>>.BeginInvoke
	|
	|-RVA: 0x1E75320 Offset: 0x1E75421 VA: 0x1E75320
	|-Func<ValueTuple<float, int>, ValueTuple<float, int>>.BeginInvoke
	|
	|-RVA: 0x1E75650 Offset: 0x1E75751 VA: 0x1E75650
	|-Func<ValueTuple<float, int>, bool>.BeginInvoke
	|
	|-RVA: 0x1E75980 Offset: 0x1E75A81 VA: 0x1E75980
	|-Func<ValueTuple<float, Int32Enum>, ValueTuple<float, Int32Enum>>.BeginInvoke
	|
	|-RVA: 0x1E75CB0 Offset: 0x1E75DB1 VA: 0x1E75CB0
	|-Func<ValueTuple<float, Int32Enum>, bool>.BeginInvoke
	|
	|-RVA: 0x1E760D0 Offset: 0x1E761D1 VA: 0x1E760D0
	|-Func<AsyncOperationHandle, AsyncOperationHandle<bool>>.BeginInvoke
	|
	|-RVA: 0x1E76510 Offset: 0x1E76611 VA: 0x1E76510
	|-Func<AsyncOperationHandle, AsyncOperationHandle<long>>.BeginInvoke
	|
	|-RVA: 0x1E76950 Offset: 0x1E76A51 VA: 0x1E76950
	|-Func<AsyncOperationHandle, AsyncOperationHandle<object>>.BeginInvoke
	|
	|-RVA: 0x1E76D90 Offset: 0x1E76E91 VA: 0x1E76D90
	|-Func<AsyncOperationHandle, AsyncOperationHandle<SceneInstance>>.BeginInvoke
	|
	|-RVA: 0x1E770C0 Offset: 0x1E771C1 VA: 0x1E770C0
	|-Func<bool, bool>.BeginInvoke
	|
	|-RVA: 0x1E773E0 Offset: 0x1E774E1 VA: 0x1E773E0
	|-Func<bool, object>.BeginInvoke
	|
	|-RVA: 0x1E77700 Offset: 0x1E77801 VA: 0x1E77700
	|-Func<CancellationToken, object>.BeginInvoke
	|
	|-RVA: 0x1E779F0 Offset: 0x1E77AF1 VA: 0x1E779F0
	|-Func<char, bool>.BeginInvoke
	|
	|-RVA: 0x1E77D00 Offset: 0x1E77E01 VA: 0x1E77D00
	|-Func<char, char>.BeginInvoke
	|
	|-RVA: 0x1E78080 Offset: 0x1E78181 VA: 0x1E78080
	|-Func<Color, bool>.BeginInvoke
	|
	|-RVA: 0x1E78490 Offset: 0x1E78591 VA: 0x1E78490
	|-Func<ContourVertex, bool>.BeginInvoke
	|
	|-RVA: 0x1E78890 Offset: 0x1E78991 VA: 0x1E78890
	|-Func<ContourVertex, Color>.BeginInvoke
	|
	|-RVA: 0x1E78C90 Offset: 0x1E78D91 VA: 0x1E78C90
	|-Func<ContourVertex, Vector3>.BeginInvoke
	|
	|-RVA: 0x1E79090 Offset: 0x1E79191 VA: 0x1E79090
	|-Func<ContourVertex, float3>.BeginInvoke
	|
	|-RVA: 0x1E794D0 Offset: 0x1E795D1 VA: 0x1E794D0
	|-Func<DiagnosticEvent, int>.BeginInvoke
	|
	|-RVA: 0x1E797F0 Offset: 0x1E798F1 VA: 0x1E797F0
	|-Func<double, double>.BeginInvoke
	|
	|-RVA: 0x1E79B00 Offset: 0x1E79C01 VA: 0x1E79B00
	|-Func<int, KeyValuePair<int, object>>.BeginInvoke
	|
	|-RVA: 0x1E79E10 Offset: 0x1E79F11 VA: 0x1E79E10
	|-Func<int, UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E7A120 Offset: 0x1E7A221 VA: 0x1E7A120
	|-Func<int, bool>.BeginInvoke
	|
	|-RVA: 0x1E7A430 Offset: 0x1E7A531 VA: 0x1E7A430
	|-Func<int, int>.BeginInvoke
	|
	|-RVA: 0x1E7A740 Offset: 0x1E7A841 VA: 0x1E7A740
	|-Func<int, object>.BeginInvoke
	|
	|-RVA: 0x1E7AA30 Offset: 0x1E7AB31 VA: 0x1E7AA30
	|-Func<int, UniTask>.BeginInvoke
	|
	|-RVA: 0x1E7AD70 Offset: 0x1E7AE71 VA: 0x1E7AD70
	|-Func<Int32Enum, bool>.BeginInvoke
	|
	|-RVA: 0x1E7B080 Offset: 0x1E7B181 VA: 0x1E7B080
	|-Func<long, bool>.BeginInvoke
	|
	|-RVA: 0x1E7B390 Offset: 0x1E7B491 VA: 0x1E7B390
	|-Func<long, long>.BeginInvoke
	|
	|-RVA: 0x1E7B6A0 Offset: 0x1E7B7A1 VA: 0x1E7B6A0
	|-Func<long, object>.BeginInvoke
	|
	|-RVA: 0x1E7BAC0 Offset: 0x1E7BBC1 VA: 0x1E7BAC0
	|-Func<object, KeyValuePair<int, object>>.BeginInvoke
	|
	|-RVA: 0x1E7BEA0 Offset: 0x1E7BFA1 VA: 0x1E7BEA0
	|-Func<object, Nullable<int>>.BeginInvoke
	|
	|-RVA: 0x1E7C280 Offset: 0x1E7C381 VA: 0x1E7C280
	|-Func<object, UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E7C660 Offset: 0x1E7C761 VA: 0x1E7C660
	|-Func<object, ValueTuple<bool, object>>.BeginInvoke
	|
	|-RVA: 0x1E7CA40 Offset: 0x1E7CB41 VA: 0x1E7CA40
	|-Func<object, ValueTuple<int, int>>.BeginInvoke
	|
	|-RVA: 0x1E7CE40 Offset: 0x1E7CF41 VA: 0x1E7CE40
	|-Func<object, ValueTuple<object, object, int>>.BeginInvoke
	|
	|-RVA: 0x1E7D260 Offset: 0x1E7D361 VA: 0x1E7D260
	|-Func<object, ValueTuple<object, bool, bool, object, object>>.BeginInvoke
	|
	|-RVA: 0x1E7D660 Offset: 0x1E7D761 VA: 0x1E7D660
	|-Func<object, bool>.BeginInvoke
	|
	|-RVA: 0x1E7DA40 Offset: 0x1E7DB41 VA: 0x1E7DA40
	|-Func<object, int>.BeginInvoke
	|
	|-RVA: 0x1E7DE20 Offset: 0x1E7DF21 VA: 0x1E7DE20
	|-Func<object, long>.BeginInvoke
	|
	|-RVA: 0x1E7E200 Offset: 0x1E7E301 VA: 0x1E7E200
	|-Func<object, object>.BeginInvoke
	|
	|-RVA: 0x1E7E5C0 Offset: 0x1E7E6C1 VA: 0x1E7E5C0
	|-Func<object, SceneInstance>.BeginInvoke
	|
	|-RVA: 0x1E7E9A0 Offset: 0x1E7EAA1 VA: 0x1E7E9A0
	|-Func<object, float>.BeginInvoke
	|
	|-RVA: 0x1E7ED80 Offset: 0x1E7EE81 VA: 0x1E7ED80
	|-Func<object, uint>.BeginInvoke
	|
	|-RVA: 0x1E7F160 Offset: 0x1E7F261 VA: 0x1E7F160
	|-Func<object, ulong>.BeginInvoke
	|
	|-RVA: 0x1E7F540 Offset: 0x1E7F641 VA: 0x1E7F540
	|-Func<object, UniTask>.BeginInvoke
	|
	|-RVA: 0x1E7F930 Offset: 0x1E7FA31 VA: 0x1E7F930
	|-Func<object, Unit>.BeginInvoke
	|
	|-RVA: 0x1E7FD20 Offset: 0x1E7FE21 VA: 0x1E7FD20
	|-Func<object, VoidTaskResult>.BeginInvoke
	|
	|-RVA: 0x1E7FFE0 Offset: 0x1E800E1 VA: 0x1E7FFE0
	|-Func<float, bool>.BeginInvoke
	|
	|-RVA: 0x1E80300 Offset: 0x1E80401 VA: 0x1E80300
	|-Func<float, float>.BeginInvoke
	|
	|-RVA: 0x1E80650 Offset: 0x1E80751 VA: 0x1E80650
	|-Func<TablePair, KeyValuePair<int, object>>.BeginInvoke
	|
	|-RVA: 0x1E809A0 Offset: 0x1E80AA1 VA: 0x1E809A0
	|-Func<TablePair, UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E80CF0 Offset: 0x1E80DF1 VA: 0x1E80CF0
	|-Func<TablePair, bool>.BeginInvoke
	|
	|-RVA: 0x1E81030 Offset: 0x1E81131 VA: 0x1E81030
	|-Func<TablePair, int>.BeginInvoke
	|
	|-RVA: 0x1E81370 Offset: 0x1E81471 VA: 0x1E81370
	|-Func<TablePair, object>.BeginInvoke
	|
	|-RVA: 0x1E816A0 Offset: 0x1E817A1 VA: 0x1E816A0
	|-Func<TablePair, TablePair>.BeginInvoke
	|
	|-RVA: 0x1E819E0 Offset: 0x1E81AE1 VA: 0x1E819E0
	|-Func<TablePair, UniTask>.BeginInvoke
	|
	|-RVA: 0x1E81CF0 Offset: 0x1E81DF1 VA: 0x1E81CF0
	|-Func<ulong, object>.BeginInvoke
	|
	|-RVA: 0x1E81FE0 Offset: 0x1E820E1 VA: 0x1E81FE0
	|-Func<ulong, ulong>.BeginInvoke
	|
	|-RVA: 0x1E82310 Offset: 0x1E82411 VA: 0x1E82310
	|-Func<UniTask, bool>.BeginInvoke
	|
	|-RVA: 0x1E82640 Offset: 0x1E82741 VA: 0x1E82640
	|-Func<UniTask, UniTask>.BeginInvoke
	|
	|-RVA: 0x1E82980 Offset: 0x1E82A81 VA: 0x1E82980
	|-Func<Unit, bool>.BeginInvoke
	|
	|-RVA: 0x1E82CB0 Offset: 0x1E82DB1 VA: 0x1E82CB0
	|-Func<Unit, object>.BeginInvoke
	|
	|-RVA: 0x1E82FD0 Offset: 0x1E830D1 VA: 0x1E82FD0
	|-Func<Unit, Unit>.BeginInvoke
	|
	|-RVA: 0x1E83350 Offset: 0x1E83451 VA: 0x1E83350
	|-Func<Vector3, bool>.BeginInvoke
	|
	|-RVA: 0x1E836E0 Offset: 0x1E837E1 VA: 0x1E836E0
	|-Func<float3, bool>.BeginInvoke
	|
	|-RVA: 0x1E83A40 Offset: 0x1E83B41 VA: 0x1E83A40
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.BeginInvoke
	|
	|-RVA: 0x1E83D90 Offset: 0x1E83E91 VA: 0x1E83D90
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E840E0 Offset: 0x1E841E1 VA: 0x1E840E0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, bool>.BeginInvoke
	|
	|-RVA: 0x1E84420 Offset: 0x1E84521 VA: 0x1E84420
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.BeginInvoke
	|
	|-RVA: 0x1E84760 Offset: 0x1E84861 VA: 0x1E84760
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.BeginInvoke
	|
	|-RVA: 0x1E84A80 Offset: 0x1E84B81 VA: 0x1E84A80
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E71E70 Offset: 0x1E71F71 VA: 0x1E71E70
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>.EndInvoke
	|
	|-RVA: 0x1E722B0 Offset: 0x1E723B1 VA: 0x1E722B0
	|-Func<AsyncOperationHandle<SceneInstance>, AsyncOperationHandle<SceneInstance>>.EndInvoke
	|
	|-RVA: 0x1E72620 Offset: 0x1E72721 VA: 0x1E72620
	|-Func<KeyValuePair<int, object>, KeyValuePair<int, object>>.EndInvoke
	|
	|-RVA: 0x1E72970 Offset: 0x1E72A71 VA: 0x1E72970
	|-Func<KeyValuePair<int, object>, bool>.EndInvoke
	|
	|-RVA: 0x1E72CB0 Offset: 0x1E72DB1 VA: 0x1E72CB0
	|-Func<KeyValuePair<object, int>, int>.EndInvoke
	|
	|-RVA: 0x1E72FF0 Offset: 0x1E730F1 VA: 0x1E72FF0
	|-Func<KeyValuePair<object, int>, object>.EndInvoke
	|
	|-RVA: 0x1E73320 Offset: 0x1E73421 VA: 0x1E73320
	|-Func<KeyValuePair<object, object>, KeyValuePair<int, object>>.EndInvoke
	|
	|-RVA: 0x1E73670 Offset: 0x1E73771 VA: 0x1E73670
	|-Func<KeyValuePair<object, object>, UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E739C0 Offset: 0x1E73AC1 VA: 0x1E739C0
	|-Func<KeyValuePair<object, object>, bool>.EndInvoke
	|
	|-RVA: 0x1E73D00 Offset: 0x1E73E01 VA: 0x1E73D00
	|-Func<KeyValuePair<object, object>, int>.EndInvoke
	|
	|-RVA: 0x1E74040 Offset: 0x1E74141 VA: 0x1E74040
	|-Func<KeyValuePair<object, object>, object>.EndInvoke
	|
	|-RVA: 0x1E74360 Offset: 0x1E74461 VA: 0x1E74360
	|-Func<KeyValuePair<object, object>, UniTask>.EndInvoke
	|
	|-RVA: 0x1E74690 Offset: 0x1E74791 VA: 0x1E74690
	|-Func<Pair<int>, Pair<int>>.EndInvoke
	|
	|-RVA: 0x1E749E0 Offset: 0x1E74AE1 VA: 0x1E749E0
	|-Func<UniTask<object>, UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E74D30 Offset: 0x1E74E31 VA: 0x1E74D30
	|-Func<UniTask<object>, bool>.EndInvoke
	|
	|-RVA: 0x1E75080 Offset: 0x1E75181 VA: 0x1E75080
	|-Func<ValueTuple<object, object>, ValueTuple<object, object>>.EndInvoke
	|
	|-RVA: 0x1E753B0 Offset: 0x1E754B1 VA: 0x1E753B0
	|-Func<ValueTuple<float, int>, ValueTuple<float, int>>.EndInvoke
	|
	|-RVA: 0x1E756E0 Offset: 0x1E757E1 VA: 0x1E756E0
	|-Func<ValueTuple<float, int>, bool>.EndInvoke
	|
	|-RVA: 0x1E75A10 Offset: 0x1E75B11 VA: 0x1E75A10
	|-Func<ValueTuple<float, Int32Enum>, ValueTuple<float, Int32Enum>>.EndInvoke
	|
	|-RVA: 0x1E75D40 Offset: 0x1E75E41 VA: 0x1E75D40
	|-Func<ValueTuple<float, Int32Enum>, bool>.EndInvoke
	|
	|-RVA: 0x1E76160 Offset: 0x1E76261 VA: 0x1E76160
	|-Func<AsyncOperationHandle, AsyncOperationHandle<bool>>.EndInvoke
	|
	|-RVA: 0x1E765A0 Offset: 0x1E766A1 VA: 0x1E765A0
	|-Func<AsyncOperationHandle, AsyncOperationHandle<long>>.EndInvoke
	|
	|-RVA: 0x1E769E0 Offset: 0x1E76AE1 VA: 0x1E769E0
	|-Func<AsyncOperationHandle, AsyncOperationHandle<object>>.EndInvoke
	|
	|-RVA: 0x1E76E20 Offset: 0x1E76F21 VA: 0x1E76E20
	|-Func<AsyncOperationHandle, AsyncOperationHandle<SceneInstance>>.EndInvoke
	|
	|-RVA: 0x1E77160 Offset: 0x1E77261 VA: 0x1E77160
	|-Func<bool, bool>.EndInvoke
	|
	|-RVA: 0x1E77480 Offset: 0x1E77581 VA: 0x1E77480
	|-Func<bool, object>.EndInvoke
	|
	|-RVA: 0x1E77790 Offset: 0x1E77891 VA: 0x1E77790
	|-Func<CancellationToken, object>.EndInvoke
	|
	|-RVA: 0x1E77A80 Offset: 0x1E77B81 VA: 0x1E77A80
	|-Func<char, bool>.EndInvoke
	|
	|-RVA: 0x1E77D90 Offset: 0x1E77E91 VA: 0x1E77D90
	|-Func<char, char>.EndInvoke
	|
	|-RVA: 0x1E78120 Offset: 0x1E78221 VA: 0x1E78120
	|-Func<Color, bool>.EndInvoke
	|
	|-RVA: 0x1E78520 Offset: 0x1E78621 VA: 0x1E78520
	|-Func<ContourVertex, bool>.EndInvoke
	|
	|-RVA: 0x1E78920 Offset: 0x1E78A21 VA: 0x1E78920
	|-Func<ContourVertex, Color>.EndInvoke
	|
	|-RVA: 0x1E78D20 Offset: 0x1E78E21 VA: 0x1E78D20
	|-Func<ContourVertex, Vector3>.EndInvoke
	|
	|-RVA: 0x1E79120 Offset: 0x1E79221 VA: 0x1E79120
	|-Func<ContourVertex, float3>.EndInvoke
	|
	|-RVA: 0x1E79560 Offset: 0x1E79661 VA: 0x1E79560
	|-Func<DiagnosticEvent, int>.EndInvoke
	|
	|-RVA: 0x1E79880 Offset: 0x1E79981 VA: 0x1E79880
	|-Func<double, double>.EndInvoke
	|
	|-RVA: 0x1E79B90 Offset: 0x1E79C91 VA: 0x1E79B90
	|-Func<int, KeyValuePair<int, object>>.EndInvoke
	|
	|-RVA: 0x1E79EA0 Offset: 0x1E79FA1 VA: 0x1E79EA0
	|-Func<int, UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E7A1B0 Offset: 0x1E7A2B1 VA: 0x1E7A1B0
	|-Func<int, bool>.EndInvoke
	|
	|-RVA: 0x1E7A4C0 Offset: 0x1E7A5C1 VA: 0x1E7A4C0
	|-Func<int, int>.EndInvoke
	|
	|-RVA: 0x1E7A7D0 Offset: 0x1E7A8D1 VA: 0x1E7A7D0
	|-Func<int, object>.EndInvoke
	|
	|-RVA: 0x1E7AAC0 Offset: 0x1E7ABC1 VA: 0x1E7AAC0
	|-Func<int, UniTask>.EndInvoke
	|
	|-RVA: 0x1E7AE00 Offset: 0x1E7AF01 VA: 0x1E7AE00
	|-Func<Int32Enum, bool>.EndInvoke
	|
	|-RVA: 0x1E7B110 Offset: 0x1E7B211 VA: 0x1E7B110
	|-Func<long, bool>.EndInvoke
	|
	|-RVA: 0x1E7B420 Offset: 0x1E7B521 VA: 0x1E7B420
	|-Func<long, long>.EndInvoke
	|
	|-RVA: 0x1E7B730 Offset: 0x1E7B831 VA: 0x1E7B730
	|-Func<long, object>.EndInvoke
	|
	|-RVA: 0x1E7BAF0 Offset: 0x1E7BBF1 VA: 0x1E7BAF0
	|-Func<object, KeyValuePair<int, object>>.EndInvoke
	|
	|-RVA: 0x1E7BED0 Offset: 0x1E7BFD1 VA: 0x1E7BED0
	|-Func<object, Nullable<int>>.EndInvoke
	|
	|-RVA: 0x1E7C2B0 Offset: 0x1E7C3B1 VA: 0x1E7C2B0
	|-Func<object, UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E7C690 Offset: 0x1E7C791 VA: 0x1E7C690
	|-Func<object, ValueTuple<bool, object>>.EndInvoke
	|
	|-RVA: 0x1E7CA70 Offset: 0x1E7CB71 VA: 0x1E7CA70
	|-Func<object, ValueTuple<int, int>>.EndInvoke
	|
	|-RVA: 0x1E7CE70 Offset: 0x1E7CF71 VA: 0x1E7CE70
	|-Func<object, ValueTuple<object, object, int>>.EndInvoke
	|
	|-RVA: 0x1E7D290 Offset: 0x1E7D391 VA: 0x1E7D290
	|-Func<object, ValueTuple<object, bool, bool, object, object>>.EndInvoke
	|
	|-RVA: 0x1E7D690 Offset: 0x1E7D791 VA: 0x1E7D690
	|-Func<object, bool>.EndInvoke
	|
	|-RVA: 0x1E7DA70 Offset: 0x1E7DB71 VA: 0x1E7DA70
	|-Func<object, int>.EndInvoke
	|
	|-RVA: 0x1E7DE50 Offset: 0x1E7DF51 VA: 0x1E7DE50
	|-Func<object, long>.EndInvoke
	|
	|-RVA: 0x1E7E230 Offset: 0x1E7E331 VA: 0x1E7E230
	|-Func<object, object>.EndInvoke
	|
	|-RVA: 0x1E7E5F0 Offset: 0x1E7E6F1 VA: 0x1E7E5F0
	|-Func<object, SceneInstance>.EndInvoke
	|
	|-RVA: 0x1E7E9D0 Offset: 0x1E7EAD1 VA: 0x1E7E9D0
	|-Func<object, float>.EndInvoke
	|
	|-RVA: 0x1E7EDB0 Offset: 0x1E7EEB1 VA: 0x1E7EDB0
	|-Func<object, uint>.EndInvoke
	|
	|-RVA: 0x1E7F190 Offset: 0x1E7F291 VA: 0x1E7F190
	|-Func<object, ulong>.EndInvoke
	|
	|-RVA: 0x1E7F570 Offset: 0x1E7F671 VA: 0x1E7F570
	|-Func<object, UniTask>.EndInvoke
	|
	|-RVA: 0x1E7F960 Offset: 0x1E7FA61 VA: 0x1E7F960
	|-Func<object, Unit>.EndInvoke
	|
	|-RVA: 0x1E7FD50 Offset: 0x1E7FE51 VA: 0x1E7FD50
	|-Func<object, VoidTaskResult>.EndInvoke
	|
	|-RVA: 0x1E80070 Offset: 0x1E80171 VA: 0x1E80070
	|-Func<float, bool>.EndInvoke
	|
	|-RVA: 0x1E80390 Offset: 0x1E80491 VA: 0x1E80390
	|-Func<float, float>.EndInvoke
	|
	|-RVA: 0x1E806E0 Offset: 0x1E807E1 VA: 0x1E806E0
	|-Func<TablePair, KeyValuePair<int, object>>.EndInvoke
	|
	|-RVA: 0x1E80A30 Offset: 0x1E80B31 VA: 0x1E80A30
	|-Func<TablePair, UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E80D80 Offset: 0x1E80E81 VA: 0x1E80D80
	|-Func<TablePair, bool>.EndInvoke
	|
	|-RVA: 0x1E810C0 Offset: 0x1E811C1 VA: 0x1E810C0
	|-Func<TablePair, int>.EndInvoke
	|
	|-RVA: 0x1E81400 Offset: 0x1E81501 VA: 0x1E81400
	|-Func<TablePair, object>.EndInvoke
	|
	|-RVA: 0x1E81730 Offset: 0x1E81831 VA: 0x1E81730
	|-Func<TablePair, TablePair>.EndInvoke
	|
	|-RVA: 0x1E81A70 Offset: 0x1E81B71 VA: 0x1E81A70
	|-Func<TablePair, UniTask>.EndInvoke
	|
	|-RVA: 0x1E81D80 Offset: 0x1E81E81 VA: 0x1E81D80
	|-Func<ulong, object>.EndInvoke
	|
	|-RVA: 0x1E82070 Offset: 0x1E82171 VA: 0x1E82070
	|-Func<ulong, ulong>.EndInvoke
	|
	|-RVA: 0x1E823A0 Offset: 0x1E824A1 VA: 0x1E823A0
	|-Func<UniTask, bool>.EndInvoke
	|
	|-RVA: 0x1E826D0 Offset: 0x1E827D1 VA: 0x1E826D0
	|-Func<UniTask, UniTask>.EndInvoke
	|
	|-RVA: 0x1E82A10 Offset: 0x1E82B11 VA: 0x1E82A10
	|-Func<Unit, bool>.EndInvoke
	|
	|-RVA: 0x1E82D40 Offset: 0x1E82E41 VA: 0x1E82D40
	|-Func<Unit, object>.EndInvoke
	|
	|-RVA: 0x1E83060 Offset: 0x1E83161 VA: 0x1E83060
	|-Func<Unit, Unit>.EndInvoke
	|
	|-RVA: 0x1E833F0 Offset: 0x1E834F1 VA: 0x1E833F0
	|-Func<Vector3, bool>.EndInvoke
	|
	|-RVA: 0x1E83780 Offset: 0x1E83881 VA: 0x1E83780
	|-Func<float3, bool>.EndInvoke
	|
	|-RVA: 0x1E83AD0 Offset: 0x1E83BD1 VA: 0x1E83AD0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.EndInvoke
	|
	|-RVA: 0x1E83E20 Offset: 0x1E83F21 VA: 0x1E83E20
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E84170 Offset: 0x1E84271 VA: 0x1E84170
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, bool>.EndInvoke
	|
	|-RVA: 0x1E844B0 Offset: 0x1E845B1 VA: 0x1E844B0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.EndInvoke
	|
	|-RVA: 0x1E847F0 Offset: 0x1E848F1 VA: 0x1E847F0
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.EndInvoke
	|
	|-RVA: 0x1E84B10 Offset: 0x1E84C11 VA: 0x1E84B10
	|-Func<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.EndInvoke
	*/
}

// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x46FAF0 Offset: 0x46FBF1 VA: 0x46FAF0
public sealed class Func<T1, T2, TResult> : MulticastDelegate // TypeDefIndex: 148
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E86BF0 Offset: 0x1E86CF1 VA: 0x1E86BF0
	|-Func<IObserver<byte[]>, CancellationToken, IEnumerator>..ctor
	|-Func<IObserver<AssetBundle>, CancellationToken, IEnumerator>..ctor
	|-Func<IObserver<AsyncOperation>, CancellationToken, IEnumerator>..ctor
	|-Func<IObserver<long>, CancellationToken, IEnumerator>..ctor
	|-Func<IObserver<string>, CancellationToken, IEnumerator>..ctor
	|-Func<IObserver<Unit>, CancellationToken, IEnumerator>..ctor
	|-Func<IObserver<WWW>, CancellationToken, IEnumerator>..ctor
	|-Func<object, CancellationToken, object>..ctor
	|
	|-RVA: 0x1E89230 Offset: 0x1E89331 VA: 0x1E89230
	|-Func<AsyncCallback, object, IAsyncResult>..ctor
	|-Func<Dropdown, IObserver<int>, IDisposable>..ctor
	|-Func<InputField, IObserver<string>, IDisposable>..ctor
	|-Func<object, object, object>..ctor
	|-Func<Script, object, DynValue>..ctor
	|-Func<ScriptExecutionContext, CallbackArguments, DynValue>..ctor
	|-Func<ScrollRect, IObserver<Vector2>, IDisposable>..ctor
	|-Func<Scrollbar, IObserver<float>, IDisposable>..ctor
	|-Func<Slider, IObserver<float>, IDisposable>..ctor
	|-Func<string, float[], float[]>..ctor
	|-Func<Toggle, IObserver<bool>, IDisposable>..ctor
	|
	|-RVA: 0x1E84B40 Offset: 0x1E84C41 VA: 0x1E84B40
	|-Func<bool, bool, bool>..ctor
	|
	|-RVA: 0x1E84E90 Offset: 0x1E84F91 VA: 0x1E84E90
	|-Func<bool, int, bool>..ctor
	|
	|-RVA: 0x1E88E30 Offset: 0x1E88F31 VA: 0x1E88E30
	|-Func<DebugMenu, string, MenuItem.Result>..ctor
	|-Func<object, object, Int32Enum>..ctor
	|
	|-RVA: 0x1E851F0 Offset: 0x1E852F1 VA: 0x1E851F0
	|-Func<double, double, double>..ctor
	|
	|-RVA: 0x1E85530 Offset: 0x1E85631 VA: 0x1E85530
	|-Func<int, int, bool>..ctor
	|
	|-RVA: 0x1E85870 Offset: 0x1E85971 VA: 0x1E85870
	|-Func<int, IntPtr, bool>..ctor
	|
	|-RVA: 0x1E85BD0 Offset: 0x1E85CD1 VA: 0x1E85BD0
	|-Func<int, object, object>..ctor
	|-Func<int, string, TMP_SpriteAsset>..ctor
	|
	|-RVA: 0x1E85EE0 Offset: 0x1E85FE1 VA: 0x1E85EE0
	|-Func<long, int, bool>..ctor
	|
	|-RVA: 0x1E86580 Offset: 0x1E86681 VA: 0x1E86580
	|-Func<long, long, DynValue>..ctor
	|-Func<long, long, object>..ctor
	|
	|-RVA: 0x1E86240 Offset: 0x1E86341 VA: 0x1E86240
	|-Func<long, long, long>..ctor
	|
	|-RVA: 0x1E868A0 Offset: 0x1E869A1 VA: 0x1E868A0
	|-Func<long, Unit, long>..ctor
	|
	|-RVA: 0x1E87040 Offset: 0x1E87141 VA: 0x1E87040
	|-Func<object, int, UniTask<object>>..ctor
	|
	|-RVA: 0x1E874B0 Offset: 0x1E875B1 VA: 0x1E874B0
	|-Func<object, int, bool>..ctor
	|
	|-RVA: 0x1E87920 Offset: 0x1E87A21 VA: 0x1E87920
	|-Func<object, int, object>..ctor
	|
	|-RVA: 0x1E87D70 Offset: 0x1E87E71 VA: 0x1E87D70
	|-Func<object, int, UniTask>..ctor
	|
	|-RVA: 0x1E881E0 Offset: 0x1E882E1 VA: 0x1E881E0
	|-Func<object, long, object>..ctor
	|
	|-RVA: 0x1E88630 Offset: 0x1E88731 VA: 0x1E88630
	|-Func<object, object, Nullable<int>>..ctor
	|
	|-RVA: 0x1E88A30 Offset: 0x1E88B31 VA: 0x1E88A30
	|-Func<object, object, int>..ctor
	|-Func<Stream, IAsyncResult, int>..ctor
	|
	|-RVA: 0x1E89610 Offset: 0x1E89711 VA: 0x1E89610
	|-Func<object, object, VoidTaskResult>..ctor
	|-Func<Stream, IAsyncResult, VoidTaskResult>..ctor
	|
	|-RVA: 0x1E89A20 Offset: 0x1E89B21 VA: 0x1E89A20
	|-Func<object, Unit, object>..ctor
	|
	|-RVA: 0x1E89E70 Offset: 0x1E89F71 VA: 0x1E89E70
	|-Func<uint, uint, uint>..ctor
	|
	|-RVA: 0x1E8A1A0 Offset: 0x1E8A2A1 VA: 0x1E8A1A0
	|-Func<ulong, ulong, DynValue>..ctor
	|-Func<ulong, ulong, object>..ctor
	|
	|-RVA: 0x1E8A4C0 Offset: 0x1E8A5C1 VA: 0x1E8A4C0
	|-Func<ulong, ulong, ulong>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E89250 Offset: 0x1E89351 VA: 0x1E89250
	|-Func<AsyncCallback, object, IAsyncResult>.Invoke
	|-Func<object, object[], object>.Invoke
	|-Func<object, object, object>.Invoke
	|-Func<Script, object, DynValue>.Invoke
	|-Func<ScriptExecutionContext, CallbackArguments, DynValue>.Invoke
	|-Func<string, int[], int[]>.Invoke
	|-Func<string, float[], float[]>.Invoke
	|
	|-RVA: 0x1E84B60 Offset: 0x1E84C61 VA: 0x1E84B60
	|-Func<bool, bool, bool>.Invoke
	|
	|-RVA: 0x1E84EB0 Offset: 0x1E84FB1 VA: 0x1E84EB0
	|-Func<bool, int, bool>.Invoke
	|
	|-RVA: 0x1E88E50 Offset: 0x1E88F51 VA: 0x1E88E50
	|-Func<DebugMenu, string, MenuItem.Result>.Invoke
	|-Func<object, object, Int32Enum>.Invoke
	|
	|-RVA: 0x1E85210 Offset: 0x1E85311 VA: 0x1E85210
	|-Func<double, double, double>.Invoke
	|
	|-RVA: 0x1E85550 Offset: 0x1E85651 VA: 0x1E85550
	|-Func<int, int, bool>.Invoke
	|
	|-RVA: 0x1E85890 Offset: 0x1E85991 VA: 0x1E85890
	|-Func<int, IntPtr, bool>.Invoke
	|
	|-RVA: 0x1E85BF0 Offset: 0x1E85CF1 VA: 0x1E85BF0
	|-Func<int, object, object>.Invoke
	|-Func<int, string, TMP_FontAsset>.Invoke
	|-Func<int, string, TMP_SpriteAsset>.Invoke
	|
	|-RVA: 0x1E85F00 Offset: 0x1E86001 VA: 0x1E85F00
	|-Func<long, int, bool>.Invoke
	|
	|-RVA: 0x1E865A0 Offset: 0x1E866A1 VA: 0x1E865A0
	|-Func<long, long, DynValue>.Invoke
	|-Func<long, long, object>.Invoke
	|
	|-RVA: 0x1E86260 Offset: 0x1E86361 VA: 0x1E86260
	|-Func<long, long, long>.Invoke
	|
	|-RVA: 0x1E868C0 Offset: 0x1E869C1 VA: 0x1E868C0
	|-Func<long, Unit, long>.Invoke
	|
	|-RVA: 0x1E86C10 Offset: 0x1E86D11 VA: 0x1E86C10
	|-Func<object, CancellationToken, object>.Invoke
	|
	|-RVA: 0x1E87060 Offset: 0x1E87161 VA: 0x1E87060
	|-Func<object, int, UniTask<object>>.Invoke
	|
	|-RVA: 0x1E874D0 Offset: 0x1E875D1 VA: 0x1E874D0
	|-Func<object, int, bool>.Invoke
	|
	|-RVA: 0x1E87940 Offset: 0x1E87A41 VA: 0x1E87940
	|-Func<object, int, object>.Invoke
	|-Func<RTHandleSystem, int, RTHandle>.Invoke
	|
	|-RVA: 0x1E87D90 Offset: 0x1E87E91 VA: 0x1E87D90
	|-Func<object, int, UniTask>.Invoke
	|
	|-RVA: 0x1E88200 Offset: 0x1E88301 VA: 0x1E88200
	|-Func<object, long, object>.Invoke
	|
	|-RVA: 0x1E88650 Offset: 0x1E88751 VA: 0x1E88650
	|-Func<object, object, Nullable<int>>.Invoke
	|
	|-RVA: 0x1E88A50 Offset: 0x1E88B51 VA: 0x1E88A50
	|-Func<object, object, int>.Invoke
	|
	|-RVA: 0x1E89630 Offset: 0x1E89731 VA: 0x1E89630
	|-Func<object, object, VoidTaskResult>.Invoke
	|
	|-RVA: 0x1E89A40 Offset: 0x1E89B41 VA: 0x1E89A40
	|-Func<object, Unit, object>.Invoke
	|
	|-RVA: 0x1E89E90 Offset: 0x1E89F91 VA: 0x1E89E90
	|-Func<uint, uint, uint>.Invoke
	|
	|-RVA: 0x1E8A1C0 Offset: 0x1E8A2C1 VA: 0x1E8A1C0
	|-Func<ulong, ulong, DynValue>.Invoke
	|-Func<ulong, ulong, object>.Invoke
	|
	|-RVA: 0x1E8A4E0 Offset: 0x1E8A5E1 VA: 0x1E8A4E0
	|-Func<ulong, ulong, ulong>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E84DB0 Offset: 0x1E84EB1 VA: 0x1E84DB0
	|-Func<bool, bool, bool>.BeginInvoke
	|
	|-RVA: 0x1E85100 Offset: 0x1E85201 VA: 0x1E85100
	|-Func<bool, int, bool>.BeginInvoke
	|
	|-RVA: 0x1E85450 Offset: 0x1E85551 VA: 0x1E85450
	|-Func<double, double, double>.BeginInvoke
	|
	|-RVA: 0x1E857A0 Offset: 0x1E858A1 VA: 0x1E857A0
	|-Func<int, int, bool>.BeginInvoke
	|
	|-RVA: 0x1E85AE0 Offset: 0x1E85BE1 VA: 0x1E85AE0
	|-Func<int, IntPtr, bool>.BeginInvoke
	|
	|-RVA: 0x1E85E30 Offset: 0x1E85F31 VA: 0x1E85E30
	|-Func<int, object, object>.BeginInvoke
	|
	|-RVA: 0x1E86150 Offset: 0x1E86251 VA: 0x1E86150
	|-Func<long, int, bool>.BeginInvoke
	|
	|-RVA: 0x1E864A0 Offset: 0x1E865A1 VA: 0x1E864A0
	|-Func<long, long, long>.BeginInvoke
	|
	|-RVA: 0x1E867E0 Offset: 0x1E868E1 VA: 0x1E867E0
	|-Func<long, long, object>.BeginInvoke
	|
	|-RVA: 0x1E86B00 Offset: 0x1E86C01 VA: 0x1E86B00
	|-Func<long, Unit, long>.BeginInvoke
	|
	|-RVA: 0x1E86F90 Offset: 0x1E87091 VA: 0x1E86F90
	|-Func<object, CancellationToken, object>.BeginInvoke
	|
	|-RVA: 0x1E873E0 Offset: 0x1E874E1 VA: 0x1E873E0
	|-Func<object, int, UniTask<object>>.BeginInvoke
	|
	|-RVA: 0x1E87850 Offset: 0x1E87951 VA: 0x1E87850
	|-Func<object, int, bool>.BeginInvoke
	|
	|-RVA: 0x1E87CC0 Offset: 0x1E87DC1 VA: 0x1E87CC0
	|-Func<object, int, object>.BeginInvoke
	|
	|-RVA: 0x1E88110 Offset: 0x1E88211 VA: 0x1E88110
	|-Func<object, int, UniTask>.BeginInvoke
	|
	|-RVA: 0x1E88580 Offset: 0x1E88681 VA: 0x1E88580
	|-Func<object, long, object>.BeginInvoke
	|
	|-RVA: 0x1E889D0 Offset: 0x1E88AD1 VA: 0x1E889D0
	|-Func<object, object, Nullable<int>>.BeginInvoke
	|
	|-RVA: 0x1E88DD0 Offset: 0x1E88ED1 VA: 0x1E88DD0
	|-Func<object, object, int>.BeginInvoke
	|
	|-RVA: 0x1E891D0 Offset: 0x1E892D1 VA: 0x1E891D0
	|-Func<object, object, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1E895D0 Offset: 0x1E896D1 VA: 0x1E895D0
	|-Func<object, object, object>.BeginInvoke
	|
	|-RVA: 0x1E899C0 Offset: 0x1E89AC1 VA: 0x1E899C0
	|-Func<object, object, VoidTaskResult>.BeginInvoke
	|
	|-RVA: 0x1E89DC0 Offset: 0x1E89EC1 VA: 0x1E89DC0
	|-Func<object, Unit, object>.BeginInvoke
	|
	|-RVA: 0x1E8A0D0 Offset: 0x1E8A1D1 VA: 0x1E8A0D0
	|-Func<uint, uint, uint>.BeginInvoke
	|
	|-RVA: 0x1E8A400 Offset: 0x1E8A501 VA: 0x1E8A400
	|-Func<ulong, ulong, object>.BeginInvoke
	|
	|-RVA: 0x1E8A720 Offset: 0x1E8A821 VA: 0x1E8A720
	|-Func<ulong, ulong, ulong>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E84E60 Offset: 0x1E84F61 VA: 0x1E84E60
	|-Func<bool, bool, bool>.EndInvoke
	|
	|-RVA: 0x1E851C0 Offset: 0x1E852C1 VA: 0x1E851C0
	|-Func<bool, int, bool>.EndInvoke
	|
	|-RVA: 0x1E85500 Offset: 0x1E85601 VA: 0x1E85500
	|-Func<double, double, double>.EndInvoke
	|
	|-RVA: 0x1E85840 Offset: 0x1E85941 VA: 0x1E85840
	|-Func<int, int, bool>.EndInvoke
	|
	|-RVA: 0x1E85BA0 Offset: 0x1E85CA1 VA: 0x1E85BA0
	|-Func<int, IntPtr, bool>.EndInvoke
	|
	|-RVA: 0x1E85ED0 Offset: 0x1E85FD1 VA: 0x1E85ED0
	|-Func<int, object, object>.EndInvoke
	|
	|-RVA: 0x1E86210 Offset: 0x1E86311 VA: 0x1E86210
	|-Func<long, int, bool>.EndInvoke
	|
	|-RVA: 0x1E86550 Offset: 0x1E86651 VA: 0x1E86550
	|-Func<long, long, long>.EndInvoke
	|
	|-RVA: 0x1E86890 Offset: 0x1E86991 VA: 0x1E86890
	|-Func<long, long, object>.EndInvoke
	|
	|-RVA: 0x1E86BC0 Offset: 0x1E86CC1 VA: 0x1E86BC0
	|-Func<long, Unit, long>.EndInvoke
	|
	|-RVA: 0x1E87030 Offset: 0x1E87131 VA: 0x1E87030
	|-Func<object, CancellationToken, object>.EndInvoke
	|
	|-RVA: 0x1E87480 Offset: 0x1E87581 VA: 0x1E87480
	|-Func<object, int, UniTask<object>>.EndInvoke
	|
	|-RVA: 0x1E878F0 Offset: 0x1E879F1 VA: 0x1E878F0
	|-Func<object, int, bool>.EndInvoke
	|
	|-RVA: 0x1E87D60 Offset: 0x1E87E61 VA: 0x1E87D60
	|-Func<object, int, object>.EndInvoke
	|
	|-RVA: 0x1E881B0 Offset: 0x1E882B1 VA: 0x1E881B0
	|-Func<object, int, UniTask>.EndInvoke
	|
	|-RVA: 0x1E88620 Offset: 0x1E88721 VA: 0x1E88620
	|-Func<object, long, object>.EndInvoke
	|
	|-RVA: 0x1E88A00 Offset: 0x1E88B01 VA: 0x1E88A00
	|-Func<object, object, Nullable<int>>.EndInvoke
	|
	|-RVA: 0x1E88E00 Offset: 0x1E88F01 VA: 0x1E88E00
	|-Func<object, object, int>.EndInvoke
	|
	|-RVA: 0x1E89200 Offset: 0x1E89301 VA: 0x1E89200
	|-Func<object, object, Int32Enum>.EndInvoke
	|
	|-RVA: 0x1E89600 Offset: 0x1E89701 VA: 0x1E89600
	|-Func<object, object, object>.EndInvoke
	|
	|-RVA: 0x1E899F0 Offset: 0x1E89AF1 VA: 0x1E899F0
	|-Func<object, object, VoidTaskResult>.EndInvoke
	|
	|-RVA: 0x1E89E60 Offset: 0x1E89F61 VA: 0x1E89E60
	|-Func<object, Unit, object>.EndInvoke
	|
	|-RVA: 0x1E8A170 Offset: 0x1E8A271 VA: 0x1E8A170
	|-Func<uint, uint, uint>.EndInvoke
	|
	|-RVA: 0x1E8A4B0 Offset: 0x1E8A5B1 VA: 0x1E8A4B0
	|-Func<ulong, ulong, object>.EndInvoke
	|
	|-RVA: 0x1E8A7D0 Offset: 0x1E8A8D1 VA: 0x1E8A7D0
	|-Func<ulong, ulong, ulong>.EndInvoke
	*/
}

// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x46FB30 Offset: 0x46FC31 VA: 0x46FB30
public sealed class Func<T1, T2, T3, TResult> : MulticastDelegate // TypeDefIndex: 149
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8A800 Offset: 0x1E8A901 VA: 0x1E8A800
	|-Func<Assembly, string, bool, Type>..ctor
	|-Func<object, object, bool, object>..ctor
	|
	|-RVA: 0x1E8AC80 Offset: 0x1E8AD81 VA: 0x1E8AC80
	|-Func<EndPoint, AsyncCallback, object, IAsyncResult>..ctor
	|-Func<object, object, object, object>..ctor
	|-Func<object, ScriptExecutionContext, CallbackArguments, DynValue>..ctor
	|-Func<object, ScriptExecutionContext, CallbackArguments, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8A820 Offset: 0x1E8A921 VA: 0x1E8A820
	|-Func<Assembly, string, bool, Type>.Invoke
	|-Func<object, object, bool, object>.Invoke
	|
	|-RVA: 0x1E8ACA0 Offset: 0x1E8ADA1 VA: 0x1E8ACA0
	|-Func<object, object, object, object>.Invoke
	|-Func<object, ScriptExecutionContext, CallbackArguments, DynValue>.Invoke
	|-Func<object, ScriptExecutionContext, CallbackArguments, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8ABC0 Offset: 0x1E8ACC1 VA: 0x1E8ABC0
	|-Func<object, object, bool, object>.BeginInvoke
	|
	|-RVA: 0x1E8B040 Offset: 0x1E8B141 VA: 0x1E8B040
	|-Func<object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8AC70 Offset: 0x1E8AD71 VA: 0x1E8AC70
	|-Func<object, object, bool, object>.EndInvoke
	|
	|-RVA: 0x1E8B070 Offset: 0x1E8B171 VA: 0x1E8B070
	|-Func<object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x46FB70 Offset: 0x46FC71 VA: 0x46FB70
public sealed class Func<T1, T2, T3, T4, TResult> : MulticastDelegate // TypeDefIndex: 150
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8B080 Offset: 0x1E8B181 VA: 0x1E8B080
	|-Func<object, int, long, int, object>..ctor
	|
	|-RVA: 0x1E8B550 Offset: 0x1E8B651 VA: 0x1E8B550
	|-Func<object, int, object, int, object>..ctor
	|
	|-RVA: 0x1E8BA00 Offset: 0x1E8BB01 VA: 0x1E8BA00
	|-Func<object, int, Unit, int, object>..ctor
	|
	|-RVA: 0x1E8BED0 Offset: 0x1E8BFD1 VA: 0x1E8BED0
	|-Func<object, object, bool, object, object>..ctor
	|
	|-RVA: 0x1E8C370 Offset: 0x1E8C471 VA: 0x1E8C370
	|-Func<object, object, object, object, object>..ctor
	|
	|-RVA: 0x1E8C7A0 Offset: 0x1E8C8A1 VA: 0x1E8C7A0
	|-Func<object, Stream.ReadWriteParameters, object, object, object>..ctor
	|-Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8BEF0 Offset: 0x1E8BFF1 VA: 0x1E8BEF0
	|-Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>.Invoke
	|-Func<object, object, bool, object, object>.Invoke
	|
	|-RVA: 0x1E8B0A0 Offset: 0x1E8B1A1 VA: 0x1E8B0A0
	|-Func<object, int, long, int, object>.Invoke
	|
	|-RVA: 0x1E8B570 Offset: 0x1E8B671 VA: 0x1E8B570
	|-Func<object, int, object, int, object>.Invoke
	|
	|-RVA: 0x1E8BA20 Offset: 0x1E8BB21 VA: 0x1E8BA20
	|-Func<object, int, Unit, int, object>.Invoke
	|
	|-RVA: 0x1E8C390 Offset: 0x1E8C491 VA: 0x1E8C390
	|-Func<object, object, object, object, object>.Invoke
	|
	|-RVA: 0x1E8C7C0 Offset: 0x1E8C8C1 VA: 0x1E8C7C0
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8B460 Offset: 0x1E8B561 VA: 0x1E8B460
	|-Func<object, int, long, int, object>.BeginInvoke
	|
	|-RVA: 0x1E8B930 Offset: 0x1E8BA31 VA: 0x1E8B930
	|-Func<object, int, object, int, object>.BeginInvoke
	|
	|-RVA: 0x1E8BDE0 Offset: 0x1E8BEE1 VA: 0x1E8BDE0
	|-Func<object, int, Unit, int, object>.BeginInvoke
	|
	|-RVA: 0x1E8C2B0 Offset: 0x1E8C3B1 VA: 0x1E8C2B0
	|-Func<object, object, bool, object, object>.BeginInvoke
	|
	|-RVA: 0x1E8C750 Offset: 0x1E8C851 VA: 0x1E8C750
	|-Func<object, object, object, object, object>.BeginInvoke
	|
	|-RVA: 0x1E8CBA0 Offset: 0x1E8CCA1 VA: 0x1E8CBA0
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8B540 Offset: 0x1E8B641 VA: 0x1E8B540
	|-Func<object, int, long, int, object>.EndInvoke
	|
	|-RVA: 0x1E8B9F0 Offset: 0x1E8BAF1 VA: 0x1E8B9F0
	|-Func<object, int, object, int, object>.EndInvoke
	|
	|-RVA: 0x1E8BEC0 Offset: 0x1E8BFC1 VA: 0x1E8BEC0
	|-Func<object, int, Unit, int, object>.EndInvoke
	|
	|-RVA: 0x1E8C360 Offset: 0x1E8C461 VA: 0x1E8C360
	|-Func<object, object, bool, object, object>.EndInvoke
	|
	|-RVA: 0x1E8C790 Offset: 0x1E8C891 VA: 0x1E8C790
	|-Func<object, object, object, object, object>.EndInvoke
	|
	|-RVA: 0x1E8CC50 Offset: 0x1E8CD51 VA: 0x1E8CC50
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, TResult> : MulticastDelegate // TypeDefIndex: 155
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8CC60 Offset: 0x1E8CD61 VA: 0x1E8CC60
	|-Func<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8CC80 Offset: 0x1E8CD81 VA: 0x1E8CC80
	|-Func<object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D060 Offset: 0x1E8D161 VA: 0x1E8D060
	|-Func<object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D0A0 Offset: 0x1E8D1A1 VA: 0x1E8D0A0
	|-Func<object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, TResult> : MulticastDelegate // TypeDefIndex: 156
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D0B0 Offset: 0x1E8D1B1 VA: 0x1E8D0B0
	|-Func<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D0D0 Offset: 0x1E8D1D1 VA: 0x1E8D0D0
	|-Func<object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D4B0 Offset: 0x1E8D5B1 VA: 0x1E8D4B0
	|-Func<object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D4F0 Offset: 0x1E8D5F1 VA: 0x1E8D4F0
	|-Func<object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, TResult> : MulticastDelegate // TypeDefIndex: 157
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D500 Offset: 0x1E8D601 VA: 0x1E8D500
	|-Func<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D520 Offset: 0x1E8D621 VA: 0x1E8D520
	|-Func<object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D920 Offset: 0x1E8DA21 VA: 0x1E8D920
	|-Func<object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D960 Offset: 0x1E8DA61 VA: 0x1E8D960
	|-Func<object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : MulticastDelegate // TypeDefIndex: 158
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D970 Offset: 0x1E8DA71 VA: 0x1E8D970
	|-Func<object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8D990 Offset: 0x1E8DA91 VA: 0x1E8D990
	|-Func<object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8DD90 Offset: 0x1E8DE91 VA: 0x1E8DD90
	|-Func<object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E8DDD0 Offset: 0x1E8DED1 VA: 0x1E8DDD0
	|-Func<object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : MulticastDelegate // TypeDefIndex: 2711
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6F270 Offset: 0x1E6F371 VA: 0x1E6F270
	|-Func<object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6F290 Offset: 0x1E6F391 VA: 0x1E6F290
	|-Func<object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6F6A0 Offset: 0x1E6F7A1 VA: 0x1E6F6A0
	|-Func<object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6F6E0 Offset: 0x1E6F7E1 VA: 0x1E6F6E0
	|-Func<object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : MulticastDelegate // TypeDefIndex: 2712
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6F6F0 Offset: 0x1E6F7F1 VA: 0x1E6F6F0
	|-Func<object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6F710 Offset: 0x1E6F811 VA: 0x1E6F710
	|-Func<object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6FB10 Offset: 0x1E6FC11 VA: 0x1E6FB10
	|-Func<object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6FB60 Offset: 0x1E6FC61 VA: 0x1E6FB60
	|-Func<object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : MulticastDelegate // TypeDefIndex: 2713
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6FB70 Offset: 0x1E6FC71 VA: 0x1E6FB70
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6FB90 Offset: 0x1E6FC91 VA: 0x1E6FB90
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E6FFC0 Offset: 0x1E700C1 VA: 0x1E6FFC0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70010 Offset: 0x1E70111 VA: 0x1E70010
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : MulticastDelegate // TypeDefIndex: 2714
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70020 Offset: 0x1E70121 VA: 0x1E70020
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70040 Offset: 0x1E70141 VA: 0x1E70040
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70480 Offset: 0x1E70581 VA: 0x1E70480
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E704D0 Offset: 0x1E705D1 VA: 0x1E704D0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : MulticastDelegate // TypeDefIndex: 2715
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E704E0 Offset: 0x1E705E1 VA: 0x1E704E0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70500 Offset: 0x1E70601 VA: 0x1E70500
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70980 Offset: 0x1E70A81 VA: 0x1E70980
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E709D0 Offset: 0x1E70AD1 VA: 0x1E709D0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : MulticastDelegate // TypeDefIndex: 2716
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E709E0 Offset: 0x1E70AE1 VA: 0x1E709E0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70A00 Offset: 0x1E70B01 VA: 0x1E70A00
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70EC0 Offset: 0x1E70FC1 VA: 0x1E70EC0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70F20 Offset: 0x1E71021 VA: 0x1E70F20
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : MulticastDelegate // TypeDefIndex: 2717
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70F30 Offset: 0x1E71031 VA: 0x1E70F30
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E70F50 Offset: 0x1E71051 VA: 0x1E70F50
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E71440 Offset: 0x1E71541 VA: 0x1E71440
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E714A0 Offset: 0x1E715A1 VA: 0x1E714A0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : MulticastDelegate // TypeDefIndex: 2718
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E714B0 Offset: 0x1E715B1 VA: 0x1E714B0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E714D0 Offset: 0x1E715D1 VA: 0x1E714D0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E71A00 Offset: 0x1E71B01 VA: 0x1E71A00
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E71A70 Offset: 0x1E71B71 VA: 0x1E71A70
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

