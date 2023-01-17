// Namespace: Unity.Mathematics
public static class math // TypeDefIndex: 4768
{
	// Methods

	// RVA: 0x1C3A940 Offset: 0x1C3AA41 VA: 0x1C3A940
	public static float2 float2(float x, float y) { }

	// RVA: 0x1C3A950 Offset: 0x1C3AA51 VA: 0x1C3A950
	public static uint hash(float2 v) { }

	// RVA: 0x1C3A990 Offset: 0x1C3AA91 VA: 0x1C3A990
	public static float3 float3(float x, float y, float z) { }

	// RVA: 0x1C3A9A0 Offset: 0x1C3AAA1 VA: 0x1C3A9A0
	public static float3 float3(float x, float2 yz) { }

	// RVA: 0x1C3A9B0 Offset: 0x1C3AAB1 VA: 0x1C3A9B0
	public static uint hash(float3 v) { }

	// RVA: 0x1C3AA00 Offset: 0x1C3AB01 VA: 0x1C3AA00
	public static uint hash(float3x3 v) { }

	// RVA: 0x1C3AAC0 Offset: 0x1C3ABC1 VA: 0x1C3AAC0
	public static float4 float4(float x, float y, float z, float w) { }

	// RVA: 0x1C3AAD0 Offset: 0x1C3ABD1 VA: 0x1C3AAD0
	public static float4 float4(float3 xyz, float w) { }

	// RVA: 0x1C3AAE0 Offset: 0x1C3ABE1 VA: 0x1C3AAE0
	public static uint hash(float4 v) { }

	// RVA: 0x1C3AB40 Offset: 0x1C3AC41 VA: 0x1C3AB40
	public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3) { }

	// RVA: 0x1C3AB90 Offset: 0x1C3AC91 VA: 0x1C3AB90
	public static float3 rotate(float4x4 a, float3 b) { }

	// RVA: 0x1C3ABF0 Offset: 0x1C3ACF1 VA: 0x1C3ABF0
	public static float3 transform(float4x4 a, float3 b) { }

	// RVA: 0x1C3AC60 Offset: 0x1C3AD61 VA: 0x1C3AC60
	public static uint hash(float4x4 v) { }

	// RVA: 0x1C3ADD0 Offset: 0x1C3AED1 VA: 0x1C3ADD0
	public static int asint(float x) { }

	// RVA: 0x1C3ADE0 Offset: 0x1C3AEE1 VA: 0x1C3ADE0
	public static uint asuint(float x) { }

	// RVA: 0x1C3ADF0 Offset: 0x1C3AEF1 VA: 0x1C3ADF0
	public static uint2 asuint(float2 x) { }

	// RVA: 0x1C3AE00 Offset: 0x1C3AF01 VA: 0x1C3AE00
	public static uint3 asuint(float3 x) { }

	// RVA: 0x1C3AE20 Offset: 0x1C3AF21 VA: 0x1C3AE20
	public static uint4 asuint(float4 x) { }

	// RVA: 0x1C3AE40 Offset: 0x1C3AF41 VA: 0x1C3AE40
	public static float asfloat(int x) { }

	// RVA: 0x1C3AE50 Offset: 0x1C3AF51 VA: 0x1C3AE50
	public static float asfloat(uint x) { }

	// RVA: 0x1C3AE60 Offset: 0x1C3AF61 VA: 0x1C3AE60
	public static float2 asfloat(uint2 x) { }

	// RVA: 0x1C3AE70 Offset: 0x1C3AF71 VA: 0x1C3AE70
	public static float3 asfloat(uint3 x) { }

	// RVA: 0x1C3AE90 Offset: 0x1C3AF91 VA: 0x1C3AE90
	public static float4 asfloat(uint4 x) { }

	// RVA: 0x1C3AEB0 Offset: 0x1C3AFB1 VA: 0x1C3AEB0
	public static int min(int x, int y) { }

	// RVA: 0x1C3AEC0 Offset: 0x1C3AFC1 VA: 0x1C3AEC0
	public static float min(float x, float y) { }

	// RVA: 0x1C3AF00 Offset: 0x1C3B001 VA: 0x1C3AF00
	public static float3 min(float3 x, float3 y) { }

	// RVA: 0x1C3AFB0 Offset: 0x1C3B0B1 VA: 0x1C3AFB0
	public static int max(int x, int y) { }

	// RVA: 0x1C3AFC0 Offset: 0x1C3B0C1 VA: 0x1C3AFC0
	public static float max(float x, float y) { }

	// RVA: 0x1C3B000 Offset: 0x1C3B101 VA: 0x1C3B000
	public static float3 max(float3 x, float3 y) { }

	// RVA: 0x1C3B0B0 Offset: 0x1C3B1B1 VA: 0x1C3B0B0
	public static float3 lerp(float3 x, float3 y, float s) { }

	// RVA: 0x1C3B0E0 Offset: 0x1C3B1E1 VA: 0x1C3B0E0
	public static float4 lerp(float4 x, float4 y, float s) { }

	// RVA: 0x1C3B120 Offset: 0x1C3B221 VA: 0x1C3B120
	public static float clamp(float x, float a, float b) { }

	// RVA: 0x1C3B190 Offset: 0x1C3B291 VA: 0x1C3B190
	public static float abs(float x) { }

	// RVA: 0x1C3B1A0 Offset: 0x1C3B2A1 VA: 0x1C3B1A0
	public static float2 abs(float2 x) { }

	// RVA: 0x1C3B1B0 Offset: 0x1C3B2B1 VA: 0x1C3B1B0
	public static float3 abs(float3 x) { }

	// RVA: 0x1C3B1C0 Offset: 0x1C3B2C1 VA: 0x1C3B1C0
	public static float dot(float2 x, float2 y) { }

	// RVA: 0x1C3B1D0 Offset: 0x1C3B2D1 VA: 0x1C3B1D0
	public static float dot(float3 x, float3 y) { }

	// RVA: 0x1C3B1F0 Offset: 0x1C3B2F1 VA: 0x1C3B1F0
	public static float dot(float4 x, float4 y) { }

	// RVA: 0x1C3B210 Offset: 0x1C3B311 VA: 0x1C3B210
	public static float cos(float x) { }

	// RVA: 0x1C3B280 Offset: 0x1C3B381 VA: 0x1C3B280
	public static float acos(float x) { }

	// RVA: 0x1C3B2F0 Offset: 0x1C3B3F1 VA: 0x1C3B2F0
	public static float sin(float x) { }

	// RVA: 0x1C3B360 Offset: 0x1C3B461 VA: 0x1C3B360
	public static float asin(float x) { }

	// RVA: 0x1C3B3D0 Offset: 0x1C3B4D1 VA: 0x1C3B3D0
	public static float floor(float x) { }

	// RVA: 0x1C3B440 Offset: 0x1C3B541 VA: 0x1C3B440
	public static float2 floor(float2 x) { }

	// RVA: 0x1C3B500 Offset: 0x1C3B601 VA: 0x1C3B500
	public static float3 floor(float3 x) { }

	// RVA: 0x1C3B610 Offset: 0x1C3B711 VA: 0x1C3B610
	public static float3 frac(float3 x) { }

	// RVA: 0x1C3B720 Offset: 0x1C3B821 VA: 0x1C3B720
	public static float rcp(float x) { }

	// RVA: 0x1C3B730 Offset: 0x1C3B831 VA: 0x1C3B730
	public static float sqrt(float x) { }

	// RVA: 0x1C3B7C0 Offset: 0x1C3B8C1 VA: 0x1C3B7C0
	public static float rsqrt(float x) { }

	// RVA: 0x1C3B850 Offset: 0x1C3B951 VA: 0x1C3B850
	public static float2 normalize(float2 x) { }

	// RVA: 0x1C3B900 Offset: 0x1C3BA01 VA: 0x1C3B900
	public static float3 normalize(float3 x) { }

	// RVA: 0x1C3B9C0 Offset: 0x1C3BAC1 VA: 0x1C3B9C0
	public static float4 normalize(float4 x) { }

	// RVA: 0x1C3BA90 Offset: 0x1C3BB91 VA: 0x1C3BA90
	public static float length(float2 x) { }

	// RVA: 0x1C3BB20 Offset: 0x1C3BC21 VA: 0x1C3BB20
	public static float length(float3 x) { }

	// RVA: 0x1C3BBC0 Offset: 0x1C3BCC1 VA: 0x1C3BBC0
	public static float3 cross(float3 x, float3 y) { }

	// RVA: 0x1C3BBF0 Offset: 0x1C3BCF1 VA: 0x1C3BBF0
	public static uint select(uint a, uint b, bool c) { }

	// RVA: 0x1C3BC00 Offset: 0x1C3BD01 VA: 0x1C3BC00
	public static float3 reflect(float3 i, float3 n) { }

	// RVA: 0x1C3BC40 Offset: 0x1C3BD41 VA: 0x1C3BC40
	public static void sincos(float x, out float s, out float c) { }

	// RVA: 0x1C3BD30 Offset: 0x1C3BE31 VA: 0x1C3BD30
	public static float radians(float x) { }

	// RVA: 0x1C3BD50 Offset: 0x1C3BE51 VA: 0x1C3BD50
	public static float degrees(float x) { }

	// RVA: 0x1C3BD70 Offset: 0x1C3BE71 VA: 0x1C3BD70
	public static uint csum(uint2 x) { }

	// RVA: 0x1C3BD80 Offset: 0x1C3BE81 VA: 0x1C3BD80
	public static uint csum(uint3 x) { }

	// RVA: 0x1C3BD90 Offset: 0x1C3BE91 VA: 0x1C3BD90
	public static uint csum(uint4 x) { }

	// RVA: 0x1C3BDB0 Offset: 0x1C3BEB1 VA: 0x1C3BDB0
	public static float3x3 float3x3(quaternion rotation) { }

	// RVA: 0x1C3BE90 Offset: 0x1C3BF91 VA: 0x1C3BE90
	public static float4x4 mul(float4x4 a, float4x4 b) { }

	// RVA: 0x1C3C0F0 Offset: 0x1C3C1F1 VA: 0x1C3C0F0
	public static quaternion quaternion(float4 value) { }

	// RVA: 0x1C3C100 Offset: 0x1C3C201 VA: 0x1C3C100
	public static quaternion inverse(quaternion q) { }

	// RVA: 0x1C3C150 Offset: 0x1C3C251 VA: 0x1C3C150
	public static float dot(quaternion a, quaternion b) { }

	// RVA: 0x1C3C170 Offset: 0x1C3C271 VA: 0x1C3C170
	public static quaternion normalize(quaternion q) { }

	// RVA: 0x1C3C240 Offset: 0x1C3C341 VA: 0x1C3C240
	public static quaternion mul(quaternion a, quaternion b) { }

	// RVA: 0x1C3C2C0 Offset: 0x1C3C3C1 VA: 0x1C3C2C0
	public static float3 mul(quaternion q, float3 v) { }

	// RVA: 0x1C3C340 Offset: 0x1C3C441 VA: 0x1C3C340
	public static quaternion nlerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x1C3C470 Offset: 0x1C3C571 VA: 0x1C3C470
	public static uint hash(quaternion q) { }

	// RVA: 0x1C3C4D0 Offset: 0x1C3C5D1 VA: 0x1C3C4D0
	public static uint2 uint2(uint x, uint y) { }

	// RVA: 0x1C3C4E0 Offset: 0x1C3C5E1 VA: 0x1C3C4E0
	public static uint hash(uint2 v) { }

	// RVA: 0x1C3C510 Offset: 0x1C3C611 VA: 0x1C3C510
	public static uint3 uint3(uint x, uint y, uint z) { }

	// RVA: 0x1C3C520 Offset: 0x1C3C621 VA: 0x1C3C520
	public static uint hash(uint3 v) { }

	// RVA: 0x1C3C560 Offset: 0x1C3C661 VA: 0x1C3C560
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

	// RVA: 0x1C3C580 Offset: 0x1C3C681 VA: 0x1C3C580
	public static uint4 uint4(int v) { }

	// RVA: 0x1C3C590 Offset: 0x1C3C691 VA: 0x1C3C590
	public static uint hash(uint4 v) { }
}

