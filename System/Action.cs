// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x46F970 Offset: 0x46FA71 VA: 0x46F970
public sealed class Action : MulticastDelegate // TypeDefIndex: 142
{
	// Methods

	// RVA: 0x3559710 Offset: 0x3559811 VA: 0x3559710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3559730 Offset: 0x3559831 VA: 0x3559730 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x3559940 Offset: 0x3559A41 VA: 0x3559940 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x3559970 Offset: 0x3559A71 VA: 0x3559970 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System
[TypeForwardedFromAttribute] // RVA: 0x46F9F0 Offset: 0x46FAF1 VA: 0x46F9F0
public sealed class Action<T1, T2, T3> : MulticastDelegate // TypeDefIndex: 144
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF0310 Offset: 0x1FF0411 VA: 0x1FF0310
	|-Action<int, Int32Enum, int>..ctor
	|
	|-RVA: 0x1FF0670 Offset: 0x1FF0771 VA: 0x1FF0670
	|-Action<int, ulong, Int32Enum>..ctor
	|
	|-RVA: 0x1FF09F0 Offset: 0x1FF0AF1 VA: 0x1FF09F0
	|-Action<object, bool, DebugScreenCapture>..ctor
	|
	|-RVA: 0x1FF1040 Offset: 0x1FF1141 VA: 0x1FF1040
	|-Action<object, int, int>..ctor
	|-Action<SkillData, int, int>..ctor
	|-Action<Unit, int, int>..ctor
	|
	|-RVA: 0x1FF14C0 Offset: 0x1FF15C1 VA: 0x1FF14C0
	|-Action<object, object, object>..ctor
	|
	|-RVA: 0x1FF18C0 Offset: 0x1FF19C1 VA: 0x1FF18C0
	|-Action<object, object, Playable>..ctor
	|
	|-RVA: 0x1FF1D60 Offset: 0x1FF1E61 VA: 0x1FF1D60
	|-Action<object, float, float>..ctor
	|-Action<HelpManager.Item, float, float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF0330 Offset: 0x1FF0431 VA: 0x1FF0330
	|-Action<int, Int32Enum, int>.Invoke
	|-Action<int, ItemData.Kinds, int>.Invoke
	|
	|-RVA: 0x1FF0690 Offset: 0x1FF0791 VA: 0x1FF0690
	|-Action<int, ulong, Int32Enum>.Invoke
	|-Action<int, ulong, NexVersus.TargetSlotList.Results>.Invoke
	|
	|-RVA: 0x1FF0A10 Offset: 0x1FF0B11 VA: 0x1FF0A10
	|-Action<object, bool, DebugScreenCapture>.Invoke
	|-Action<string, bool, DebugScreenCapture>.Invoke
	|
	|-RVA: 0x1FF1060 Offset: 0x1FF1161 VA: 0x1FF1060
	|-Action<object, int, int>.Invoke
	|-Action<SkillData, int, int>.Invoke
	|-Action<Unit, int, int>.Invoke
	|
	|-RVA: 0x1FF14E0 Offset: 0x1FF15E1 VA: 0x1FF14E0
	|-Action<object, object, object>.Invoke
	|
	|-RVA: 0x1FF18E0 Offset: 0x1FF19E1 VA: 0x1FF18E0
	|-Action<object, object, Playable>.Invoke
	|-Action<TimelineClip, GameObject, Playable>.Invoke
	|-Action<TrackAsset, GameObject, Playable>.Invoke
	|
	|-RVA: 0x1FF1D80 Offset: 0x1FF1E81 VA: 0x1FF1D80
	|-Action<object, float, float>.Invoke
	|-Action<HelpManager.Item, float, float>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF0590 Offset: 0x1FF0691 VA: 0x1FF0590
	|-Action<int, Int32Enum, int>.BeginInvoke
	|
	|-RVA: 0x1FF08F0 Offset: 0x1FF09F1 VA: 0x1FF08F0
	|-Action<int, ulong, Int32Enum>.BeginInvoke
	|
	|-RVA: 0x1FF0F60 Offset: 0x1FF1061 VA: 0x1FF0F60
	|-Action<object, bool, DebugScreenCapture>.BeginInvoke
	|
	|-RVA: 0x1FF1400 Offset: 0x1FF1501 VA: 0x1FF1400
	|-Action<object, int, int>.BeginInvoke
	|
	|-RVA: 0x1FF1880 Offset: 0x1FF1981 VA: 0x1FF1880
	|-Action<object, object, object>.BeginInvoke
	|
	|-RVA: 0x1FF1CA0 Offset: 0x1FF1DA1 VA: 0x1FF1CA0
	|-Action<object, object, Playable>.BeginInvoke
	|
	|-RVA: 0x1FF2120 Offset: 0x1FF2221 VA: 0x1FF2120
	|-Action<object, float, float>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF0660 Offset: 0x1FF0761 VA: 0x1FF0660
	|-Action<int, Int32Enum, int>.EndInvoke
	|
	|-RVA: 0x1FF09E0 Offset: 0x1FF0AE1 VA: 0x1FF09E0
	|-Action<int, ulong, Int32Enum>.EndInvoke
	|
	|-RVA: 0x1FF1030 Offset: 0x1FF1131 VA: 0x1FF1030
	|-Action<object, bool, DebugScreenCapture>.EndInvoke
	|
	|-RVA: 0x1FF14B0 Offset: 0x1FF15B1 VA: 0x1FF14B0
	|-Action<object, int, int>.EndInvoke
	|
	|-RVA: 0x1FF18B0 Offset: 0x1FF19B1 VA: 0x1FF18B0
	|-Action<object, object, object>.EndInvoke
	|
	|-RVA: 0x1FF1D50 Offset: 0x1FF1E51 VA: 0x1FF1D50
	|-Action<object, object, Playable>.EndInvoke
	|
	|-RVA: 0x1FF21D0 Offset: 0x1FF22D1 VA: 0x1FF21D0
	|-Action<object, float, float>.EndInvoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6> : MulticastDelegate // TypeDefIndex: 152
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF42D0 Offset: 0x1FF43D1 VA: 0x1FF42D0
	|-Action<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF42F0 Offset: 0x1FF43F1 VA: 0x1FF42F0
	|-Action<object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF46D0 Offset: 0x1FF47D1 VA: 0x1FF46D0
	|-Action<object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF4710 Offset: 0x1FF4811 VA: 0x1FF4710
	|-Action<object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8> : MulticastDelegate // TypeDefIndex: 154
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF4B80 Offset: 0x1FF4C81 VA: 0x1FF4B80
	|-Action<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF4BA0 Offset: 0x1FF4CA1 VA: 0x1FF4BA0
	|-Action<object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF4FA0 Offset: 0x1FF50A1 VA: 0x1FF4FA0
	|-Action<object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF4FE0 Offset: 0x1FF50E1 VA: 0x1FF4FE0
	|-Action<object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : MulticastDelegate // TypeDefIndex: 2704
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE6700 Offset: 0x1FE6801 VA: 0x1FE6700
	|-Action<object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE6720 Offset: 0x1FE6821 VA: 0x1FE6720
	|-Action<object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE6B20 Offset: 0x1FE6C21 VA: 0x1FE6B20
	|-Action<object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE6B70 Offset: 0x1FE6C71 VA: 0x1FE6B70
	|-Action<object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : MulticastDelegate // TypeDefIndex: 2706
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE7030 Offset: 0x1FE7131 VA: 0x1FE7030
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE7050 Offset: 0x1FE7151 VA: 0x1FE7050
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE7490 Offset: 0x1FE7591 VA: 0x1FE7490
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE74E0 Offset: 0x1FE75E1 VA: 0x1FE74E0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : MulticastDelegate // TypeDefIndex: 2708
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE79E0 Offset: 0x1FE7AE1 VA: 0x1FE79E0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE7A00 Offset: 0x1FE7B01 VA: 0x1FE7A00
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE7EB0 Offset: 0x1FE7FB1 VA: 0x1FE7EB0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE7F10 Offset: 0x1FE8011 VA: 0x1FE7F10
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : MulticastDelegate // TypeDefIndex: 2710
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE84A0 Offset: 0x1FE85A1 VA: 0x1FE84A0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE84C0 Offset: 0x1FE85C1 VA: 0x1FE84C0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE89E0 Offset: 0x1FE8AE1 VA: 0x1FE89E0
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FE8A50 Offset: 0x1FE8B51 VA: 0x1FE8A50
	|-Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

