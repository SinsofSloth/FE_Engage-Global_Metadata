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

