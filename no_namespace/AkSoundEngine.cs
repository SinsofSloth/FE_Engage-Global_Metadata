// Namespace: 
public sealed class AkSoundEngine.GameObjectHashFunction : MulticastDelegate // TypeDefIndex: 7910
{
	// Methods

	// RVA: 0x1F5AEC0 Offset: 0x1F5AFC1 VA: 0x1F5AEC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F5AEE0 Offset: 0x1F5AFE1 VA: 0x1F5AEE0 Slot: 13
	public virtual ulong Invoke(GameObject gameObject) { }

	// RVA: 0x1F5B240 Offset: 0x1F5B341 VA: 0x1F5B240 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameObject gameObject, AsyncCallback callback, object object) { }

	// RVA: 0x1F5B270 Offset: 0x1F5B371 VA: 0x1F5B270 Slot: 15
	public virtual ulong EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class AkSoundEngine // TypeDefIndex: 7912
{
	// Fields
	public const int AK_SIMD_ALIGNMENT = 16;
	public const int AK_BUFFER_ALIGNMENT = 16;
	public const int AK_MAX_PATH = 260;
	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;
	public const uint AK_INVALID_PLUGINID = 4294967295;
	public const ulong AK_INVALID_GAME_OBJECT = 18446744073709551615;
	public const uint AK_INVALID_UNIQUE_ID = 0;
	public const uint AK_INVALID_RTPC_ID = 0;
	public const uint AK_INVALID_LISTENER_INDEX = 4294967295;
	public const uint AK_INVALID_PLAYING_ID = 0;
	public const uint AK_DEFAULT_SWITCH_STATE = 0;
	public const int AK_INVALID_POOL_ID = -1;
	public const int AK_DEFAULT_POOL_ID = -1;
	public const uint AK_INVALID_AUX_ID = 0;
	public const uint AK_INVALID_FILE_ID = 4294967295;
	public const uint AK_INVALID_DEVICE_ID = 4294967295;
	public const uint AK_INVALID_BANK_ID = 0;
	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0;
	public const uint AK_INVALID_CHANNELMASK = 0;
	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0;
	public const uint AK_MIXER_FX_SLOT = 4294967295;
	public const ulong AK_DEFAULT_LISTENER_OBJ = 0;
	public const uint AK_DEFAULT_PRIORITY = 50;
	public const uint AK_MIN_PRIORITY = 0;
	public const uint AK_MAX_PRIORITY = 100;
	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50;
	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576;
	public const uint AKCOMPANYID_AUDIOKINETIC = 0;
	public const uint AK_LISTENERS_MASK_ALL = 4294967295;
	public const int NULL = 0;
	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5;
	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32;
	public const int AKCOMPANYID_PLUGINDEV_MIN = 64;
	public const int AKCOMPANYID_PLUGINDEV_MAX = 255;
	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1;
	public const int AKCOMPANYID_MCDSP = 256;
	public const int AKCOMPANYID_WAVEARTS = 257;
	public const int AKCOMPANYID_PHONETICARTS = 258;
	public const int AKCOMPANYID_IZOTOPE = 259;
	public const int AKCOMPANYID_CRANKCASEAUDIO = 261;
	public const int AKCOMPANYID_IOSONO = 262;
	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263;
	public const int AKCOMPANYID_DOLBY = 264;
	public const int AKCOMPANYID_TWOBIGEARS = 265;
	public const int AKCOMPANYID_OCULUS = 266;
	public const int AKCOMPANYID_BLUERIPPLESOUND = 267;
	public const int AKCOMPANYID_ENZIEN = 268;
	public const int AKCOMPANYID_KROTOS = 269;
	public const int AKCOMPANYID_NURULIZE = 270;
	public const int AKCOMPANYID_SUPERPOWERED = 271;
	public const int AKCOMPANYID_GOOGLE = 272;
	public const int AKCOMPANYID_VISISONICS = 277;
	public const int AKCODECID_BANK = 0;
	public const int AKCODECID_PCM = 1;
	public const int AKCODECID_ADPCM = 2;
	public const int AKCODECID_XMA = 3;
	public const int AKCODECID_VORBIS = 4;
	public const int AKCODECID_WIIADPCM = 5;
	public const int AKCODECID_PCMEX = 7;
	public const int AKCODECID_EXTERNAL_SOURCE = 8;
	public const int AKCODECID_XWMA = 9;
	public const int AKCODECID_AAC = 10;
	public const int AKCODECID_FILE_PACKAGE = 11;
	public const int AKCODECID_ATRAC9 = 12;
	public const int AKCODECID_VAG = 13;
	public const int AKCODECID_PROFILERCAPTURE = 14;
	public const int AKCODECID_ANALYSISFILE = 15;
	public const int AKCODECID_MIDI = 16;
	public const int AKCODECID_OPUSNX = 17;
	public const int AKCODECID_CAF = 18;
	public const int AKCODECID_AKOPUS = 19;
	public const int AKCODECID_AKOPUS_WEM = 20;
	public const int AKPLUGINID_METER = 129;
	public const int AKPLUGINID_RECORDER = 132;
	public const int AKEXTENSIONID_SPATIALAUDIO = 800;
	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801;
	public const int AKEXTENSIONID_EVENTMGRTHREAD = 900;
	public const int AK_WAVE_FORMAT_VAG = 65531;
	public const int AK_WAVE_FORMAT_AT9 = 65532;
	public const int AK_WAVE_FORMAT_VORBIS = 65535;
	public const int AK_WAVE_FORMAT_AAC = 43712;
	public const int AK_WAVE_FORMAT_OPUSNX = 12345;
	public const int AK_WAVE_FORMAT_OPUS = 12352;
	public const int AK_WAVE_FORMAT_OPUS_WEM = 12353;
	public const int WAVE_FORMAT_XMA2 = 358;
	public const int AK_PANNER_NUM_STORAGE_BITS = 3;
	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3;
	public const int AK_SPAT_NUM_STORAGE_BITS = 3;
	public const int AK_MAX_BITS_METERING_FLAGS = 5;
	public const int AK_OS_STRUCT_ALIGN = 4;
	public const int AK_64B_OS_STRUCT_ALIGN = 8;
	public const bool AK_ASYNC_OPEN_DEFAULT = False;
	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024;
	public const int AK_MIDI_EVENT_TYPE_INVALID = 0;
	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128;
	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144;
	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160;
	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176;
	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192;
	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208;
	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224;
	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240;
	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247;
	public const int AK_MIDI_EVENT_TYPE_META = 255;
	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0;
	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1;
	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2;
	public const int AK_MIDI_CC_CTRL_3_COARSE = 3;
	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4;
	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5;
	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6;
	public const int AK_MIDI_CC_VOLUME_COARSE = 7;
	public const int AK_MIDI_CC_BALANCE_COARSE = 8;
	public const int AK_MIDI_CC_CTRL_9_COARSE = 9;
	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10;
	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11;
	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12;
	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13;
	public const int AK_MIDI_CC_CTRL_14_COARSE = 14;
	public const int AK_MIDI_CC_CTRL_15_COARSE = 15;
	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16;
	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17;
	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18;
	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19;
	public const int AK_MIDI_CC_CTRL_20_COARSE = 20;
	public const int AK_MIDI_CC_CTRL_21_COARSE = 21;
	public const int AK_MIDI_CC_CTRL_22_COARSE = 22;
	public const int AK_MIDI_CC_CTRL_23_COARSE = 23;
	public const int AK_MIDI_CC_CTRL_24_COARSE = 24;
	public const int AK_MIDI_CC_CTRL_25_COARSE = 25;
	public const int AK_MIDI_CC_CTRL_26_COARSE = 26;
	public const int AK_MIDI_CC_CTRL_27_COARSE = 27;
	public const int AK_MIDI_CC_CTRL_28_COARSE = 28;
	public const int AK_MIDI_CC_CTRL_29_COARSE = 29;
	public const int AK_MIDI_CC_CTRL_30_COARSE = 30;
	public const int AK_MIDI_CC_CTRL_31_COARSE = 31;
	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32;
	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33;
	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34;
	public const int AK_MIDI_CC_CTRL_3_FINE = 35;
	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36;
	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37;
	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38;
	public const int AK_MIDI_CC_VOLUME_FINE = 39;
	public const int AK_MIDI_CC_BALANCE_FINE = 40;
	public const int AK_MIDI_CC_CTRL_9_FINE = 41;
	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42;
	public const int AK_MIDI_CC_EXPRESSION_FINE = 43;
	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44;
	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45;
	public const int AK_MIDI_CC_CTRL_14_FINE = 46;
	public const int AK_MIDI_CC_CTRL_15_FINE = 47;
	public const int AK_MIDI_CC_CTRL_20_FINE = 52;
	public const int AK_MIDI_CC_CTRL_21_FINE = 53;
	public const int AK_MIDI_CC_CTRL_22_FINE = 54;
	public const int AK_MIDI_CC_CTRL_23_FINE = 55;
	public const int AK_MIDI_CC_CTRL_24_FINE = 56;
	public const int AK_MIDI_CC_CTRL_25_FINE = 57;
	public const int AK_MIDI_CC_CTRL_26_FINE = 58;
	public const int AK_MIDI_CC_CTRL_27_FINE = 59;
	public const int AK_MIDI_CC_CTRL_28_FINE = 60;
	public const int AK_MIDI_CC_CTRL_29_FINE = 61;
	public const int AK_MIDI_CC_CTRL_30_FINE = 62;
	public const int AK_MIDI_CC_CTRL_31_FINE = 63;
	public const int AK_MIDI_CC_HOLD_PEDAL = 64;
	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65;
	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66;
	public const int AK_MIDI_CC_SOFT_PEDAL = 67;
	public const int AK_MIDI_CC_LEGATO_PEDAL = 68;
	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69;
	public const int AK_MIDI_CC_SOUND_VARIATION = 70;
	public const int AK_MIDI_CC_SOUND_TIMBRE = 71;
	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72;
	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73;
	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74;
	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75;
	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76;
	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77;
	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78;
	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79;
	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80;
	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81;
	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82;
	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83;
	public const int AK_MIDI_CC_REVERB_LEVEL = 91;
	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92;
	public const int AK_MIDI_CC_CHORUS_LEVEL = 93;
	public const int AK_MIDI_CC_CELESTE_LEVEL = 94;
	public const int AK_MIDI_CC_PHASER_LEVEL = 95;
	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96;
	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97;
	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98;
	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99;
	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120;
	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121;
	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122;
	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123;
	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124;
	public const int AK_MIDI_CC_OMNI_MODE_ON = 125;
	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126;
	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127;
	public const int AK_SPEAKER_FRONT_LEFT = 1;
	public const int AK_SPEAKER_FRONT_RIGHT = 2;
	public const int AK_SPEAKER_FRONT_CENTER = 4;
	public const int AK_SPEAKER_LOW_FREQUENCY = 8;
	public const int AK_SPEAKER_BACK_LEFT = 16;
	public const int AK_SPEAKER_BACK_RIGHT = 32;
	public const int AK_SPEAKER_BACK_CENTER = 256;
	public const int AK_SPEAKER_SIDE_LEFT = 512;
	public const int AK_SPEAKER_SIDE_RIGHT = 1024;
	public const int AK_SPEAKER_TOP = 2048;
	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096;
	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192;
	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384;
	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768;
	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536;
	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072;
	public const int AK_SPEAKER_SETUP_MONO = 4;
	public const int AK_SPEAKER_SETUP_0POINT1 = 8;
	public const int AK_SPEAKER_SETUP_1POINT1 = 12;
	public const int AK_SPEAKER_SETUP_STEREO = 3;
	public const int AK_SPEAKER_SETUP_2POINT1 = 11;
	public const int AK_SPEAKER_SETUP_3STEREO = 7;
	public const int AK_SPEAKER_SETUP_3POINT1 = 15;
	public const int AK_SPEAKER_SETUP_4 = 1539;
	public const int AK_SPEAKER_SETUP_4POINT1 = 1547;
	public const int AK_SPEAKER_SETUP_5 = 1543;
	public const int AK_SPEAKER_SETUP_5POINT1 = 1551;
	public const int AK_SPEAKER_SETUP_6 = 1587;
	public const int AK_SPEAKER_SETUP_6POINT1 = 1595;
	public const int AK_SPEAKER_SETUP_7 = 1591;
	public const int AK_SPEAKER_SETUP_7POINT1 = 1599;
	public const int AK_SPEAKER_SETUP_SURROUND = 259;
	public const int AK_SPEAKER_SETUP_DPL2 = 1539;
	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320;
	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512;
	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048;
	public const int AK_SPEAKER_SETUP_AURO_222 = 22019;
	public const int AK_SPEAKER_SETUP_AURO_8 = 185859;
	public const int AK_SPEAKER_SETUP_AURO_9 = 185863;
	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871;
	public const int AK_SPEAKER_SETUP_AURO_10 = 187911;
	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919;
	public const int AK_SPEAKER_SETUP_AURO_11 = 196103;
	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111;
	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911;
	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919;
	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151;
	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159;
	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023;
	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031;
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067;
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075;
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907;
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915;
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071;
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079;
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911;
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919;
	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951;
	public const int AK_IDX_SETUP_FRONT_LEFT = 0;
	public const int AK_IDX_SETUP_FRONT_RIGHT = 1;
	public const int AK_IDX_SETUP_CENTER = 2;
	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2;
	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3;
	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4;
	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5;
	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3;
	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4;
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5;
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6;
	public const int AK_IDX_SETUP_0_LFE = 0;
	public const int AK_IDX_SETUP_1_CENTER = 0;
	public const int AK_IDX_SETUP_1_LFE = 1;
	public const int AK_IDX_SETUP_2_LEFT = 0;
	public const int AK_IDX_SETUP_2_RIGHT = 1;
	public const int AK_IDX_SETUP_2_LFE = 2;
	public const int AK_IDX_SETUP_3_LEFT = 0;
	public const int AK_IDX_SETUP_3_RIGHT = 1;
	public const int AK_IDX_SETUP_3_CENTER = 2;
	public const int AK_IDX_SETUP_3_LFE = 3;
	public const int AK_IDX_SETUP_4_FRONTLEFT = 0;
	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1;
	public const int AK_IDX_SETUP_4_REARLEFT = 2;
	public const int AK_IDX_SETUP_4_REARRIGHT = 3;
	public const int AK_IDX_SETUP_4_LFE = 4;
	public const int AK_IDX_SETUP_5_FRONTLEFT = 0;
	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1;
	public const int AK_IDX_SETUP_5_CENTER = 2;
	public const int AK_IDX_SETUP_5_REARLEFT = 3;
	public const int AK_IDX_SETUP_5_REARRIGHT = 4;
	public const int AK_IDX_SETUP_5_LFE = 5;
	public const int AK_IDX_SETUP_6_FRONTLEFT = 0;
	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1;
	public const int AK_IDX_SETUP_6_REARLEFT = 2;
	public const int AK_IDX_SETUP_6_REARRIGHT = 3;
	public const int AK_IDX_SETUP_6_SIDELEFT = 4;
	public const int AK_IDX_SETUP_6_SIDERIGHT = 5;
	public const int AK_IDX_SETUP_6_LFE = 6;
	public const int AK_IDX_SETUP_7_FRONTLEFT = 0;
	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1;
	public const int AK_IDX_SETUP_7_CENTER = 2;
	public const int AK_IDX_SETUP_7_REARLEFT = 3;
	public const int AK_IDX_SETUP_7_REARRIGHT = 4;
	public const int AK_IDX_SETUP_7_SIDELEFT = 5;
	public const int AK_IDX_SETUP_7_SIDERIGHT = 6;
	public const int AK_IDX_SETUP_7_LFE = 7;
	public const int AK_SPEAKER_SETUP_0_1 = 8;
	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4;
	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12;
	public const int AK_SPEAKER_SETUP_2_0 = 3;
	public const int AK_SPEAKER_SETUP_2_1 = 11;
	public const int AK_SPEAKER_SETUP_3_0 = 7;
	public const int AK_SPEAKER_SETUP_3_1 = 15;
	public const int AK_SPEAKER_SETUP_FRONT = 7;
	public const int AK_SPEAKER_SETUP_4_0 = 1539;
	public const int AK_SPEAKER_SETUP_4_1 = 1547;
	public const int AK_SPEAKER_SETUP_5_0 = 1543;
	public const int AK_SPEAKER_SETUP_5_1 = 1551;
	public const int AK_SPEAKER_SETUP_6_0 = 1587;
	public const int AK_SPEAKER_SETUP_6_1 = 1595;
	public const int AK_SPEAKER_SETUP_7_0 = 1591;
	public const int AK_SPEAKER_SETUP_7_1 = 1599;
	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599;
	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951;
	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8;
	public const int AK_MAX_AMBISONICS_ORDER = 5;
	public const int AK_MAX_NUM_TEXTURE = 4;
	public const int AK_MAX_REFLECT_ORDER = 4;
	public const int AK_MAX_REFLECTION_PATH_LENGTH = 8;
	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8;
	public const double AK_DEFAULT_DIFFR_SHADOW_DEGREES = 30;
	public const double AK_DEFAULT_DIFFR_SHADOW_ATTEN = 1;
	public const double AK_DEFAULT_MOVEMENT_THRESHOLD = 1;
	public const int AK_DEFAULT_REFLECTIONS_ORDER = 1;
	public const double AK_SA_EPSILON = 0.001;
	public const double AK_SA_DIFFRACTION_EPSILON = 0.002;
	public const double AK_SA_DIFFRACTION_DOT_EPSILON = 2E-06;
	public const double AK_SA_PLANE_THICKNESS_RATIO = 0.005;
	private static AkSoundEngine.GameObjectHashFunction gameObjectHash; // 0x0
	public const string Deprecation_2018_1_2 = "This functionality is deprecated as of Wwise v2018.1.2 and will be removed in a future release.";
	public const string Deprecation_2018_1_6 = "This functionality is deprecated as of Wwise v2018.1.6 and will be removed in a future release.";
	public const string Deprecation_2019_2_0 = "This functionality is deprecated as of Wwise v2019.2.0 and will be removed in a future release.";
	public const string Deprecation_2019_2_2 = "This functionality is deprecated as of Wwise v2019.2.2 and will be removed in a future release.";
	private static readonly HashSet<ulong> RegisteredGameObjects; // 0x8

	// Properties
	public static uint AK_SOUNDBANK_VERSION { get; }
	public static ushort AK_INT { get; }
	public static ushort AK_FLOAT { get; }
	public static byte AK_INTERLEAVED { get; }
	public static byte AK_NONINTERLEAVED { get; }
	public static uint AK_LE_NATIVE_BITSPERSAMPLE { get; }
	public static uint AK_LE_NATIVE_SAMPLETYPE { get; }
	public static uint AK_LE_NATIVE_INTERLEAVE { get; }
	public static byte AK_INVALID_MIDI_CHANNEL { get; }
	public static byte AK_INVALID_MIDI_NOTE { get; }
	public static float kDefaultMaxPathLength { get; }
	public static uint kDefaultDiffractionMaxEdges { get; }
	public static uint kDefaultDiffractionMaxPaths { get; }
	public static float kMaxDiffraction { get; }
	public static uint kDiffractionMaxEdges { get; }
	public static uint kDiffractionMaxPaths { get; }
	public static uint kPortalToPortalDiffractionMaxPaths { get; }
	public static AkSoundEngine.GameObjectHashFunction GameObjectHash { set; }
	public static string WwiseVersion { get; }

	// Methods

	// RVA: 0x20B8C10 Offset: 0x20B8D11 VA: 0x20B8C10
	public static uint get_AK_SOUNDBANK_VERSION() { }

	// RVA: 0x20B8C90 Offset: 0x20B8D91 VA: 0x20B8C90
	public static ushort get_AK_INT() { }

	// RVA: 0x20B8D10 Offset: 0x20B8E11 VA: 0x20B8D10
	public static ushort get_AK_FLOAT() { }

	// RVA: 0x20B8D90 Offset: 0x20B8E91 VA: 0x20B8D90
	public static byte get_AK_INTERLEAVED() { }

	// RVA: 0x20B8E10 Offset: 0x20B8F11 VA: 0x20B8E10
	public static byte get_AK_NONINTERLEAVED() { }

	// RVA: 0x20B8E90 Offset: 0x20B8F91 VA: 0x20B8E90
	public static uint get_AK_LE_NATIVE_BITSPERSAMPLE() { }

	// RVA: 0x20B8F10 Offset: 0x20B9011 VA: 0x20B8F10
	public static uint get_AK_LE_NATIVE_SAMPLETYPE() { }

	// RVA: 0x20B8F90 Offset: 0x20B9091 VA: 0x20B8F90
	public static uint get_AK_LE_NATIVE_INTERLEAVE() { }

	// RVA: 0x20B9010 Offset: 0x20B9111 VA: 0x20B9010
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType) { }

	// RVA: 0x20B9330 Offset: 0x20B9431 VA: 0x20B9330
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) { }

	// RVA: 0x20B9560 Offset: 0x20B9661 VA: 0x20B9560
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID) { }

	// RVA: 0x20B96F0 Offset: 0x20B97F1 VA: 0x20B96F0
	public static AKRESULT DynamicSequenceClose(uint in_playingID) { }

	// RVA: 0x20B9770 Offset: 0x20B9871 VA: 0x20B9770
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20B9800 Offset: 0x20B9901 VA: 0x20B9800
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration) { }

	// RVA: 0x20B9880 Offset: 0x20B9981 VA: 0x20B9880
	public static AKRESULT DynamicSequencePlay(uint in_playingID) { }

	// RVA: 0x20B9900 Offset: 0x20B9A01 VA: 0x20B9900
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20B9990 Offset: 0x20B9A91 VA: 0x20B9990
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration) { }

	// RVA: 0x20B9A10 Offset: 0x20B9B11 VA: 0x20B9A10
	public static AKRESULT DynamicSequencePause(uint in_playingID) { }

	// RVA: 0x20B9A90 Offset: 0x20B9B91 VA: 0x20B9A90
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20B9B20 Offset: 0x20B9C21 VA: 0x20B9B20
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration) { }

	// RVA: 0x20B9BA0 Offset: 0x20B9CA1 VA: 0x20B9BA0
	public static AKRESULT DynamicSequenceResume(uint in_playingID) { }

	// RVA: 0x20B9C20 Offset: 0x20B9D21 VA: 0x20B9C20
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20B9CB0 Offset: 0x20B9DB1 VA: 0x20B9CB0
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration) { }

	// RVA: 0x20B9D30 Offset: 0x20B9E31 VA: 0x20B9D30
	public static AKRESULT DynamicSequenceStop(uint in_playingID) { }

	// RVA: 0x20B9DB0 Offset: 0x20B9EB1 VA: 0x20B9DB0
	public static AKRESULT DynamicSequenceBreak(uint in_playingID) { }

	// RVA: 0x20B9E30 Offset: 0x20B9F31 VA: 0x20B9E30
	public static AKRESULT Seek(uint in_playingID, int in_iPosition, bool in_bSeekToNearestMarker) { }

	// RVA: 0x20B9EC0 Offset: 0x20B9FC1 VA: 0x20B9EC0
	public static AKRESULT Seek(uint in_playingID, float in_fPercent, bool in_bSeekToNearestMarker) { }

	// RVA: 0x20B9F50 Offset: 0x20BA051 VA: 0x20B9F50
	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration) { }

	// RVA: 0x20B9FE0 Offset: 0x20BA0E1 VA: 0x20B9FE0
	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID) { }

	// RVA: 0x20BA0D0 Offset: 0x20BA1D1 VA: 0x20BA0D0
	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID) { }

	// RVA: 0x20BA150 Offset: 0x20BA251 VA: 0x20BA150
	public static bool IsInitialized() { }

	// RVA: 0x20BA1E0 Offset: 0x20BA2E1 VA: 0x20BA1E0
	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings) { }

	// RVA: 0x20BA270 Offset: 0x20BA371 VA: 0x20BA270
	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput) { }

	// RVA: 0x20BA330 Offset: 0x20BA431 VA: 0x20BA330
	public static AkChannelConfig GetSpeakerConfiguration() { }

	// RVA: 0x20BA3E0 Offset: 0x20BA4E1 VA: 0x20BA3E0
	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput) { }

	// RVA: 0x20BA460 Offset: 0x20BA561 VA: 0x20BA460
	public static AKRESULT GetPanningRule(out int out_ePanningRule) { }

	// RVA: 0x20BA4E0 Offset: 0x20BA5E1 VA: 0x20BA4E0
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput) { }

	// RVA: 0x20BA560 Offset: 0x20BA661 VA: 0x20BA560
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule) { }

	// RVA: 0x20BA5E0 Offset: 0x20BA6E1 VA: 0x20BA5E0
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput) { }

	// RVA: 0x20BA680 Offset: 0x20BA781 VA: 0x20BA680
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle) { }

	// RVA: 0x20BA720 Offset: 0x20BA821 VA: 0x20BA720
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput) { }

	// RVA: 0x20BA7D0 Offset: 0x20BA8D1 VA: 0x20BA7D0
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle) { }

	// RVA: 0x20BA870 Offset: 0x20BA971 VA: 0x20BA870
	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB) { }

	// RVA: 0x20BA8F0 Offset: 0x20BA9F1 VA: 0x20BA8F0
	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices) { }

	// RVA: 0x20BA970 Offset: 0x20BAA71 VA: 0x20BA970
	public static AKRESULT RenderAudio(bool in_bAllowSyncRender) { }

	// RVA: 0x20BA9F0 Offset: 0x20BAAF1 VA: 0x20BA9F0
	public static AKRESULT RenderAudio() { }

	// RVA: 0x20BAA70 Offset: 0x20BAB71 VA: 0x20BAA70
	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath) { }

	// RVA: 0x20BAB80 Offset: 0x20BAC81 VA: 0x20BAB80
	public static AKRESULT RegisterPluginDLL(string in_DllName) { }

	// RVA: 0x20BAC50 Offset: 0x20BAD51 VA: 0x20BAC50
	public static uint GetIDFromString(string in_pszString) { }

	// RVA: 0x20BAD20 Offset: 0x20BAE21 VA: 0x20BAD20
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) { }

	// RVA: 0x20BAF90 Offset: 0x20BB091 VA: 0x20BAF90
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }

	// RVA: 0x20BB1F0 Offset: 0x20BB2F1 VA: 0x20BB1F0
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) { }

	// RVA: 0x20BB420 Offset: 0x20BB521 VA: 0x20BB420
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID) { }

	// RVA: 0x20BB5C0 Offset: 0x20BB6C1 VA: 0x20BB5C0
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) { }

	// RVA: 0x20BB8C0 Offset: 0x20BB9C1 VA: 0x20BB8C0
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }

	// RVA: 0x20BBBA0 Offset: 0x20BBCA1 VA: 0x20BBBA0
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) { }

	// RVA: 0x20BBE40 Offset: 0x20BBF41 VA: 0x20BBE40
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID) { }

	// RVA: 0x20BC020 Offset: 0x20BC121 VA: 0x20BC020
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) { }

	// RVA: 0x20BC1B0 Offset: 0x20BC2B1 VA: 0x20BC1B0
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20BC330 Offset: 0x20BC431 VA: 0x20BC330
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration) { }

	// RVA: 0x20BC4B0 Offset: 0x20BC5B1 VA: 0x20BC4B0
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID) { }

	// RVA: 0x20BC620 Offset: 0x20BC721 VA: 0x20BC620
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType) { }

	// RVA: 0x20BC6A0 Offset: 0x20BC7A1 VA: 0x20BC6A0
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID) { }

	// RVA: 0x20BC8B0 Offset: 0x20BC9B1 VA: 0x20BC8B0
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20BCAB0 Offset: 0x20BCBB1 VA: 0x20BCAB0
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration) { }

	// RVA: 0x20BCC90 Offset: 0x20BCD91 VA: 0x20BCC90
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID) { }

	// RVA: 0x20BCE50 Offset: 0x20BCF51 VA: 0x20BCE50
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType) { }

	// RVA: 0x20BCF20 Offset: 0x20BD021 VA: 0x20BCF20
	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts) { }

	// RVA: 0x20BD0A0 Offset: 0x20BD1A1 VA: 0x20BD0A0
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID) { }

	// RVA: 0x20BD200 Offset: 0x20BD301 VA: 0x20BD200
	public static AKRESULT StopMIDIOnEvent(uint in_eventID) { }

	// RVA: 0x20BD280 Offset: 0x20BD381 VA: 0x20BD280
	public static AKRESULT StopMIDIOnEvent() { }

	// RVA: 0x20BD300 Offset: 0x20BD401 VA: 0x20BD300
	public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority) { }

	// RVA: 0x20BD390 Offset: 0x20BD491 VA: 0x20BD390
	public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority) { }

	// RVA: 0x20BD480 Offset: 0x20BD581 VA: 0x20BD480
	public static AKRESULT UnpinEventInStreamCache(uint in_eventID) { }

	// RVA: 0x20BD500 Offset: 0x20BD601 VA: 0x20BD500
	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName) { }

	// RVA: 0x20BD5D0 Offset: 0x20BD6D1 VA: 0x20BD5D0
	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull) { }

	// RVA: 0x20BD660 Offset: 0x20BD761 VA: 0x20BD660
	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull) { }

	// RVA: 0x20BD750 Offset: 0x20BD851 VA: 0x20BD750
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) { }

	// RVA: 0x20BD8D0 Offset: 0x20BD9D1 VA: 0x20BD8D0
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) { }

	// RVA: 0x20BDA50 Offset: 0x20BDB51 VA: 0x20BDA50
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition) { }

	// RVA: 0x20BDBC0 Offset: 0x20BDCC1 VA: 0x20BDBC0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID) { }

	// RVA: 0x20BDDC0 Offset: 0x20BDEC1 VA: 0x20BDDC0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker) { }

	// RVA: 0x20BDFA0 Offset: 0x20BE0A1 VA: 0x20BDFA0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition) { }

	// RVA: 0x20BE160 Offset: 0x20BE261 VA: 0x20BE160
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) { }

	// RVA: 0x20BE2F0 Offset: 0x20BE3F1 VA: 0x20BE2F0
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) { }

	// RVA: 0x20BE470 Offset: 0x20BE571 VA: 0x20BE470
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent) { }

	// RVA: 0x20BE5E0 Offset: 0x20BE6E1 VA: 0x20BE5E0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID) { }

	// RVA: 0x20BE7E0 Offset: 0x20BE8E1 VA: 0x20BE7E0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker) { }

	// RVA: 0x20BE9C0 Offset: 0x20BEAC1 VA: 0x20BE9C0
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent) { }

	// RVA: 0x20BEB90 Offset: 0x20BEC91 VA: 0x20BEB90
	public static void CancelEventCallbackCookie(object in_pCookie) { }

	// RVA: 0x20BEC00 Offset: 0x20BED01 VA: 0x20BEC00
	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID) { }

	// RVA: 0x20BED50 Offset: 0x20BEE51 VA: 0x20BED50
	public static void CancelEventCallback(uint in_playingID) { }

	// RVA: 0x20BEDC0 Offset: 0x20BEEC1 VA: 0x20BEDC0
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate) { }

	// RVA: 0x20BEE50 Offset: 0x20BEF51 VA: 0x20BEE50
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition) { }

	// RVA: 0x20BEED0 Offset: 0x20BEFD1 VA: 0x20BEED0
	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering) { }

	// RVA: 0x20BEF60 Offset: 0x20BF061 VA: 0x20BEF60
	public static void StopAll(GameObject in_gameObjectID) { }

	// RVA: 0x20BF0B0 Offset: 0x20BF1B1 VA: 0x20BF0B0
	public static void StopAll() { }

	// RVA: 0x20BF130 Offset: 0x20BF231 VA: 0x20BF130
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20BF1C0 Offset: 0x20BF2C1 VA: 0x20BF1C0
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration) { }

	// RVA: 0x20BF240 Offset: 0x20BF341 VA: 0x20BF240
	public static void StopPlayingID(uint in_playingID) { }

	// RVA: 0x20BF2C0 Offset: 0x20BF3C1 VA: 0x20BF2C0
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20BF360 Offset: 0x20BF461 VA: 0x20BF360
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration) { }

	// RVA: 0x20BF3F0 Offset: 0x20BF4F1 VA: 0x20BF3F0
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID) { }

	// RVA: 0x20BF470 Offset: 0x20BF571 VA: 0x20BF470
	public static void SetRandomSeed(uint in_uSeed) { }

	// RVA: 0x20BF4F0 Offset: 0x20BF5F1 VA: 0x20BF4F0
	public static void MuteBackgroundMusic(bool in_bMute) { }

	// RVA: 0x20BF570 Offset: 0x20BF671 VA: 0x20BF570
	public static bool GetBackgroundMusicMute() { }

	// RVA: 0x20BF600 Offset: 0x20BF701 VA: 0x20BF600
	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes) { }

	// RVA: 0x20BF7A0 Offset: 0x20BF8A1 VA: 0x20BF7A0
	public static AKRESULT UnregisterAllGameObj() { }

	// RVA: 0x20BF820 Offset: 0x20BF921 VA: 0x20BF820
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }

	// RVA: 0x20BF950 Offset: 0x20BFA51 VA: 0x20BF950
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions) { }

	// RVA: 0x20BFA80 Offset: 0x20BFB81 VA: 0x20BFA80
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType) { }

	// RVA: 0x20BFBB0 Offset: 0x20BFCB1 VA: 0x20BFBB0
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions) { }

	// RVA: 0x20BFCE0 Offset: 0x20BFDE1 VA: 0x20BFCE0
	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor) { }

	// RVA: 0x20BFE00 Offset: 0x20BFF01 VA: 0x20BFE00
	public static AKRESULT ClearBanks() { }

	// RVA: 0x20BFE80 Offset: 0x20BFF81 VA: 0x20BFE80
	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority) { }

	// RVA: 0x20BFF10 Offset: 0x20C0011 VA: 0x20BFF10
	public static AKRESULT LoadBank(string in_pszString, out uint out_bankID) { }

	// RVA: 0x20BFFE0 Offset: 0x20C00E1 VA: 0x20BFFE0
	public static AKRESULT LoadBank(uint in_bankID) { }

	// RVA: 0x20C0060 Offset: 0x20C0161 VA: 0x20C0060
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID) { }

	// RVA: 0x20C00F0 Offset: 0x20C01F1 VA: 0x20C00F0
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID) { }

	// RVA: 0x20C0180 Offset: 0x20C0281 VA: 0x20C0180
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) { }

	// RVA: 0x20C0300 Offset: 0x20C0401 VA: 0x20C0300
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C0400 Offset: 0x20C0501 VA: 0x20C0400
	public static AKRESULT LoadBankMemoryView(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) { }

	// RVA: 0x20C0520 Offset: 0x20C0621 VA: 0x20C0520
	public static AKRESULT LoadBankMemoryCopy(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID) { }

	// RVA: 0x20C0640 Offset: 0x20C0741 VA: 0x20C0640
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr) { }

	// RVA: 0x20C0710 Offset: 0x20C0811 VA: 0x20C0710
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr) { }

	// RVA: 0x20C0790 Offset: 0x20C0891 VA: 0x20C0790
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C0910 Offset: 0x20C0A11 VA: 0x20C0910
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C0A20 Offset: 0x20C0B21 VA: 0x20C0A20
	public static void CancelBankCallbackCookie(object in_pCookie) { }

	// RVA: 0x20C0A90 Offset: 0x20C0B91 VA: 0x20C0A90
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags) { }

	// RVA: 0x20C0B90 Offset: 0x20C0C91 VA: 0x20C0B90
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString) { }

	// RVA: 0x20C0C70 Offset: 0x20C0D71 VA: 0x20C0C70
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags) { }

	// RVA: 0x20C0D00 Offset: 0x20C0E01 VA: 0x20C0D00
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID) { }

	// RVA: 0x20C0D80 Offset: 0x20C0E81 VA: 0x20C0D80
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags) { }

	// RVA: 0x20C0F20 Offset: 0x20C1021 VA: 0x20C0F20
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C10A0 Offset: 0x20C11A1 VA: 0x20C10A0
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags) { }

	// RVA: 0x20C11C0 Offset: 0x20C12C1 VA: 0x20C11C0
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C12D0 Offset: 0x20C13D1 VA: 0x20C12D0
	public static AKRESULT ClearPreparedEvents() { }

	// RVA: 0x20C1350 Offset: 0x20C1451 VA: 0x20C1350
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent) { }

	// RVA: 0x20C1650 Offset: 0x20C1751 VA: 0x20C1650
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent) { }

	// RVA: 0x20C16F0 Offset: 0x20C17F1 VA: 0x20C16F0
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C1A70 Offset: 0x20C1B71 VA: 0x20C1A70
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C1B90 Offset: 0x20C1C91 VA: 0x20C1B90
	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings) { }

	// RVA: 0x20C1C20 Offset: 0x20C1D21 VA: 0x20C1C20
	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings) { }

	// RVA: 0x20C1CB0 Offset: 0x20C1DB1 VA: 0x20C1CB0
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs) { }

	// RVA: 0x20C2030 Offset: 0x20C2131 VA: 0x20C2030
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs) { }

	// RVA: 0x20C20E0 Offset: 0x20C21E1 VA: 0x20C20E0
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C2500 Offset: 0x20C2601 VA: 0x20C2500
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie) { }

	// RVA: 0x20C2640 Offset: 0x20C2741 VA: 0x20C2640
	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj) { }

	// RVA: 0x20C2830 Offset: 0x20C2931 VA: 0x20C2830
	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj) { }

	// RVA: 0x20C2A20 Offset: 0x20C2B21 VA: 0x20C2A20
	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj) { }

	// RVA: 0x20C2B70 Offset: 0x20C2C71 VA: 0x20C2B70
	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj) { }

	// RVA: 0x20C2CC0 Offset: 0x20C2DC1 VA: 0x20C2CC0
	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj) { }

	// RVA: 0x20C2E10 Offset: 0x20C2F11 VA: 0x20C2E10
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets) { }

	// RVA: 0x20C2FB0 Offset: 0x20C30B1 VA: 0x20C2FB0
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig) { }

	// RVA: 0x20C3130 Offset: 0x20C3231 VA: 0x20C3130
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) { }

	// RVA: 0x20C32C0 Offset: 0x20C33C1 VA: 0x20C32C0
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20C3450 Offset: 0x20C3551 VA: 0x20C3450
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration) { }

	// RVA: 0x20C35D0 Offset: 0x20C36D1 VA: 0x20C35D0
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID) { }

	// RVA: 0x20C3740 Offset: 0x20C3841 VA: 0x20C3740
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value) { }

	// RVA: 0x20C37D0 Offset: 0x20C38D1 VA: 0x20C37D0
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) { }

	// RVA: 0x20C39F0 Offset: 0x20C3AF1 VA: 0x20C39F0
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20C3BF0 Offset: 0x20C3CF1 VA: 0x20C3BF0
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration) { }

	// RVA: 0x20C3DD0 Offset: 0x20C3ED1 VA: 0x20C3DD0
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID) { }

	// RVA: 0x20C3FA0 Offset: 0x20C40A1 VA: 0x20C3FA0
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value) { }

	// RVA: 0x20C4090 Offset: 0x20C4191 VA: 0x20C4090
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) { }

	// RVA: 0x20C4150 Offset: 0x20C4251 VA: 0x20C4150
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20C4200 Offset: 0x20C4301 VA: 0x20C4200
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration) { }

	// RVA: 0x20C42A0 Offset: 0x20C43A1 VA: 0x20C42A0
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID) { }

	// RVA: 0x20C4330 Offset: 0x20C4431 VA: 0x20C4330
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) { }

	// RVA: 0x20C4480 Offset: 0x20C4581 VA: 0x20C4480
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20C45B0 Offset: 0x20C46B1 VA: 0x20C45B0
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration) { }

	// RVA: 0x20C46C0 Offset: 0x20C47C1 VA: 0x20C46C0
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID) { }

	// RVA: 0x20C47B0 Offset: 0x20C48B1 VA: 0x20C47B0
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) { }

	// RVA: 0x20C4930 Offset: 0x20C4A31 VA: 0x20C4930
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20C4AB0 Offset: 0x20C4BB1 VA: 0x20C4AB0
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration) { }

	// RVA: 0x20C4C20 Offset: 0x20C4D21 VA: 0x20C4C20
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID) { }

	// RVA: 0x20C4D80 Offset: 0x20C4E81 VA: 0x20C4D80
	public static AKRESULT ResetRTPCValue(uint in_rtpcID) { }

	// RVA: 0x20C4E00 Offset: 0x20C4F01 VA: 0x20C4E00
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation) { }

	// RVA: 0x20C5000 Offset: 0x20C5101 VA: 0x20C5000
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve) { }

	// RVA: 0x20C51E0 Offset: 0x20C52E1 VA: 0x20C51E0
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration) { }

	// RVA: 0x20C53A0 Offset: 0x20C54A1 VA: 0x20C53A0
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID) { }

	// RVA: 0x20C5550 Offset: 0x20C5651 VA: 0x20C5550
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName) { }

	// RVA: 0x20C5620 Offset: 0x20C5721 VA: 0x20C5620
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID) { }

	// RVA: 0x20C5790 Offset: 0x20C5891 VA: 0x20C5790
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID) { }

	// RVA: 0x20C5990 Offset: 0x20C5A91 VA: 0x20C5990
	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID) { }

	// RVA: 0x20C5AF0 Offset: 0x20C5BF1 VA: 0x20C5AF0
	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID) { }

	// RVA: 0x20C5CA0 Offset: 0x20C5DA1 VA: 0x20C5CA0
	public static AKRESULT SetState(uint in_stateGroup, uint in_state) { }

	// RVA: 0x20C5D20 Offset: 0x20C5E21 VA: 0x20C5D20
	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState) { }

	// RVA: 0x20C5E30 Offset: 0x20C5F31 VA: 0x20C5E30
	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues) { }

	// RVA: 0x20C5FA0 Offset: 0x20C60A1 VA: 0x20C5FA0
	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue) { }

	// RVA: 0x20C61A0 Offset: 0x20C62A1 VA: 0x20C61A0
	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID) { }

	// RVA: 0x20C6230 Offset: 0x20C6331 VA: 0x20C6230
	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID) { }

	// RVA: 0x20C62C0 Offset: 0x20C63C1 VA: 0x20C62C0
	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID) { }

	// RVA: 0x20C63B0 Offset: 0x20C64B1 VA: 0x20C63B0
	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID) { }

	// RVA: 0x20C6430 Offset: 0x20C6531 VA: 0x20C6430
	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID) { }

	// RVA: 0x20C6500 Offset: 0x20C6601 VA: 0x20C6500
	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig) { }

	// RVA: 0x20C6590 Offset: 0x20C6691 VA: 0x20C6590
	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig) { }

	// RVA: 0x20C6670 Offset: 0x20C6771 VA: 0x20C6670
	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel) { }

	// RVA: 0x20C6880 Offset: 0x20C6981 VA: 0x20C6880
	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction) { }

	// RVA: 0x20C6AA0 Offset: 0x20C6BA1 VA: 0x20C6AA0
	public static AKRESULT StartOutputCapture(string in_CaptureFileName) { }

	// RVA: 0x20C6B70 Offset: 0x20C6C71 VA: 0x20C6B70
	public static AKRESULT StopOutputCapture() { }

	// RVA: 0x20C6BF0 Offset: 0x20C6CF1 VA: 0x20C6BF0
	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText) { }

	// RVA: 0x20C6CC0 Offset: 0x20C6DC1 VA: 0x20C6CC0
	public static AKRESULT StartProfilerCapture(string in_CaptureFileName) { }

	// RVA: 0x20C6D90 Offset: 0x20C6E91 VA: 0x20C6D90
	public static AKRESULT StopProfilerCapture() { }

	// RVA: 0x20C6E10 Offset: 0x20C6F11 VA: 0x20C6E10
	public static AKRESULT RemoveOutput(ulong in_idOutput) { }

	// RVA: 0x20C6E90 Offset: 0x20C6F91 VA: 0x20C6E90
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId) { }

	// RVA: 0x20C6F30 Offset: 0x20C7031 VA: 0x20C6F30
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId) { }

	// RVA: 0x20C6FC0 Offset: 0x20C70C1 VA: 0x20C6FC0
	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice) { }

	// RVA: 0x20C7040 Offset: 0x20C7141 VA: 0x20C7040
	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice) { }

	// RVA: 0x20C7110 Offset: 0x20C7211 VA: 0x20C7110
	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice) { }

	// RVA: 0x20C7190 Offset: 0x20C7291 VA: 0x20C7190
	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName) { }

	// RVA: 0x20C72A0 Offset: 0x20C73A1 VA: 0x20C72A0
	public static AKRESULT GetDeviceList(uint in_ulCompanyID, uint in_ulPluginID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) { }

	// RVA: 0x20C7350 Offset: 0x20C7451 VA: 0x20C7350
	public static AKRESULT GetDeviceList(uint in_audioDeviceShareSetID, out uint io_maxNumDevices, AkDeviceDescriptionArray out_deviceDescriptions) { }

	// RVA: 0x20C73F0 Offset: 0x20C74F1 VA: 0x20C73F0
	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume) { }

	// RVA: 0x20C7480 Offset: 0x20C7581 VA: 0x20C7480
	public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice) { }

	// RVA: 0x20C7500 Offset: 0x20C7601 VA: 0x20C7500
	public static AKRESULT Suspend(bool in_bRenderAnyway) { }

	// RVA: 0x20C7580 Offset: 0x20C7681 VA: 0x20C7580
	public static AKRESULT Suspend() { }

	// RVA: 0x20C7600 Offset: 0x20C7701 VA: 0x20C7600
	public static AKRESULT WakeupFromSuspend() { }

	// RVA: 0x20C7680 Offset: 0x20C7781 VA: 0x20C7680
	public static uint GetBufferTick() { }

	// RVA: 0x20C7700 Offset: 0x20C7801 VA: 0x20C7700
	public static byte get_AK_INVALID_MIDI_CHANNEL() { }

	// RVA: 0x20C7780 Offset: 0x20C7881 VA: 0x20C7780
	public static byte get_AK_INVALID_MIDI_NOTE() { }

	// RVA: 0x20C7800 Offset: 0x20C7901 VA: 0x20C7800
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate) { }

	// RVA: 0x20C78D0 Offset: 0x20C79D1 VA: 0x20C78D0
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo) { }

	// RVA: 0x20C79A0 Offset: 0x20C7AA1 VA: 0x20C79A0
	public static void LocalOutput(AkMonitorErrorCode in_eErrorCode, string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID) { }

	// RVA: 0x20C7B80 Offset: 0x20C7C81 VA: 0x20C7B80
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus) { }

	// RVA: 0x20C7D10 Offset: 0x20C7E11 VA: 0x20C7D10
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID) { }

	// RVA: 0x20C7E90 Offset: 0x20C7F91 VA: 0x20C7E90
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID) { }

	// RVA: 0x20C8010 Offset: 0x20C8111 VA: 0x20C8010
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID) { }

	// RVA: 0x20C80A0 Offset: 0x20C81A1 VA: 0x20C80A0
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel) { }

	// RVA: 0x20C8120 Offset: 0x20C8221 VA: 0x20C8120
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus) { }

	// RVA: 0x20C8330 Offset: 0x20C8431 VA: 0x20C8330
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID) { }

	// RVA: 0x20C8530 Offset: 0x20C8631 VA: 0x20C8530
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID) { }

	// RVA: 0x20C8710 Offset: 0x20C8811 VA: 0x20C8710
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID) { }

	// RVA: 0x20C8800 Offset: 0x20C8901 VA: 0x20C8800
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel) { }

	// RVA: 0x20C88D0 Offset: 0x20C89D1 VA: 0x20C88D0
	public static int GetTimeStamp() { }

	// RVA: 0x20C8950 Offset: 0x20C8A51 VA: 0x20C8950
	public static uint GetNumNonZeroBits(uint in_uWord) { }

	// RVA: 0x20C89D0 Offset: 0x20C8AD1 VA: 0x20C89D0
	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties) { }

	// RVA: 0x20C8B00 Offset: 0x20C8C01 VA: 0x20C8B00
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence) { }

	// RVA: 0x20C8BA0 Offset: 0x20C8CA1 VA: 0x20C8BA0
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments) { }

	// RVA: 0x20C8C40 Offset: 0x20C8D41 VA: 0x20C8C40
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue) { }

	// RVA: 0x20C8CD0 Offset: 0x20C8DD1 VA: 0x20C8CD0
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue) { }

	// RVA: 0x20C8D60 Offset: 0x20C8E61 VA: 0x20C8D60
	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition) { }

	// RVA: 0x20C8F00 Offset: 0x20C9001 VA: 0x20C8F00
	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition) { }

	// RVA: 0x20C9090 Offset: 0x20C9191 VA: 0x20C9090
	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) { }

	// RVA: 0x20C9210 Offset: 0x20C9311 VA: 0x20C9210
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType) { }

	// RVA: 0x20C9410 Offset: 0x20C9511 VA: 0x20C9410
	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState) { }

	// RVA: 0x20C9580 Offset: 0x20C9681 VA: 0x20C9580
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState) { }

	// RVA: 0x20C9700 Offset: 0x20C9801 VA: 0x20C9700
	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState) { }

	// RVA: 0x20C9780 Offset: 0x20C9881 VA: 0x20C9780
	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState) { }

	// RVA: 0x20C9850 Offset: 0x20C9951 VA: 0x20C9850
	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues) { }

	// RVA: 0x20C99C0 Offset: 0x20C9AC1 VA: 0x20C99C0
	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue) { }

	// RVA: 0x20C9BC0 Offset: 0x20C9CC1 VA: 0x20C9BC0
	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel) { }

	// RVA: 0x20C9DD0 Offset: 0x20C9ED1 VA: 0x20C9DD0
	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos) { }

	// RVA: 0x20C9E70 Offset: 0x20C9F71 VA: 0x20C9E70
	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos) { }

	// RVA: 0x20C9F70 Offset: 0x20CA071 VA: 0x20C9F70
	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo) { }

	// RVA: 0x20CA000 Offset: 0x20CA101 VA: 0x20CA000
	public static bool GetIsGameObjectActive(GameObject in_GameObjId) { }

	// RVA: 0x20CA170 Offset: 0x20CA271 VA: 0x20CA170
	public static float GetMaxRadius(GameObject in_GameObjId) { }

	// RVA: 0x20CA2C0 Offset: 0x20CA3C1 VA: 0x20CA2C0
	public static uint GetEventIDFromPlayingID(uint in_playingID) { }

	// RVA: 0x20CA340 Offset: 0x20CA441 VA: 0x20CA340
	public static ulong GetGameObjectFromPlayingID(uint in_playingID) { }

	// RVA: 0x20CA3C0 Offset: 0x20CA4C1 VA: 0x20CA3C0
	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs) { }

	// RVA: 0x20CA6E0 Offset: 0x20CA7E1 VA: 0x20CA6E0
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue) { }

	// RVA: 0x20CA770 Offset: 0x20CA871 VA: 0x20CA770
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue) { }

	// RVA: 0x20CA800 Offset: 0x20CA901 VA: 0x20CA800
	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask) { }

	// RVA: 0x20CA880 Offset: 0x20CA981 VA: 0x20CA880
	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask) { }

	// RVA: 0x20CA900 Offset: 0x20CAA01 VA: 0x20CA900
	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask) { }

	// RVA: 0x20CA980 Offset: 0x20CAA81 VA: 0x20CA980
	public static byte ChannelMaskToNumChannels(uint in_uChannelMask) { }

	// RVA: 0x20CAA00 Offset: 0x20CAB01 VA: 0x20CAA00
	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels) { }

	// RVA: 0x20CAA80 Offset: 0x20CAB81 VA: 0x20CAA80
	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask) { }

	// RVA: 0x20CAB00 Offset: 0x20CAC01 VA: 0x20CAB00
	public static bool HasSurroundChannels(uint in_uChannelMask) { }

	// RVA: 0x20CABA0 Offset: 0x20CACA1 VA: 0x20CABA0
	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask) { }

	// RVA: 0x20CAC40 Offset: 0x20CAD41 VA: 0x20CAC40
	public static bool HasSideAndRearChannels(uint in_uChannelMask) { }

	// RVA: 0x20CACE0 Offset: 0x20CADE1 VA: 0x20CACE0
	public static bool HasHeightChannels(uint in_uChannelMask) { }

	// RVA: 0x20CAD80 Offset: 0x20CAE81 VA: 0x20CAD80
	public static uint BackToSideChannels(uint in_uChannelMask) { }

	// RVA: 0x20CAE00 Offset: 0x20CAF01 VA: 0x20CAE00
	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx) { }

	// RVA: 0x20CAE90 Offset: 0x20CAF91 VA: 0x20CAE90
	public static float get_kDefaultMaxPathLength() { }

	// RVA: 0x20CAF10 Offset: 0x20CB011 VA: 0x20CAF10
	public static uint get_kDefaultDiffractionMaxEdges() { }

	// RVA: 0x20CAF90 Offset: 0x20CB091 VA: 0x20CAF90
	public static uint get_kDefaultDiffractionMaxPaths() { }

	// RVA: 0x20CB010 Offset: 0x20CB111 VA: 0x20CB010
	public static float get_kMaxDiffraction() { }

	// RVA: 0x20CB090 Offset: 0x20CB191 VA: 0x20CB090
	public static uint get_kDiffractionMaxEdges() { }

	// RVA: 0x20CB110 Offset: 0x20CB211 VA: 0x20CB110
	public static uint get_kDiffractionMaxPaths() { }

	// RVA: 0x20CB190 Offset: 0x20CB291 VA: 0x20CB190
	public static uint get_kPortalToPortalDiffractionMaxPaths() { }

	// RVA: 0x20CB210 Offset: 0x20CB311 VA: 0x20CB210
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID, GameObject in_gameObjectID) { }

	// RVA: 0x20CB3A0 Offset: 0x20CB4A1 VA: 0x20CB3A0
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID) { }

	// RVA: 0x20CB510 Offset: 0x20CB611 VA: 0x20CB510
	public static AKRESULT ClearImageSources(uint in_AuxBusID, GameObject in_gameObjectID) { }

	// RVA: 0x20CB670 Offset: 0x20CB771 VA: 0x20CB670
	public static AKRESULT ClearImageSources(uint in_AuxBusID) { }

	// RVA: 0x20CB6F0 Offset: 0x20CB7F1 VA: 0x20CB6F0
	public static AKRESULT ClearImageSources() { }

	// RVA: 0x20CB770 Offset: 0x20CB871 VA: 0x20CB770
	public static AKRESULT RemoveGeometry(ulong in_SetID) { }

	// RVA: 0x20CB7F0 Offset: 0x20CB8F1 VA: 0x20CB7F0
	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize) { }

	// RVA: 0x20CB980 Offset: 0x20CBA81 VA: 0x20CB980
	public static AKRESULT RemoveRoom(ulong in_RoomID) { }

	// RVA: 0x20CBA00 Offset: 0x20CBB01 VA: 0x20CBA00
	public static AKRESULT RemovePortal(ulong in_PortalID) { }

	// RVA: 0x20CBA80 Offset: 0x20CBB81 VA: 0x20CBA80
	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID) { }

	// RVA: 0x20CBBE0 Offset: 0x20CBCE1 VA: 0x20CBBE0
	public static AKRESULT SetReflectionsOrder(uint in_uReflectionsOrder, bool in_bUpdatePaths) { }

	// RVA: 0x20CBC60 Offset: 0x20CBD61 VA: 0x20CBC60
	public static AKRESULT SetNumberOfPrimaryRays(uint in_uNbPrimaryRays) { }

	// RVA: 0x20CBCE0 Offset: 0x20CBDE1 VA: 0x20CBCE0
	public static AKRESULT SetEarlyReflectionsAuxSend(GameObject in_gameObjectID, uint in_auxBusID) { }

	// RVA: 0x20CBE40 Offset: 0x20CBF41 VA: 0x20CBE40
	public static AKRESULT SetEarlyReflectionsVolume(GameObject in_gameObjectID, float in_fSendVolume) { }

	// RVA: 0x20B78A0 Offset: 0x20B79A1 VA: 0x20B78A0
	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion) { }

	// RVA: 0x20CBFB0 Offset: 0x20CC0B1 VA: 0x20CBFB0
	public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction) { }

	// RVA: 0x20CC030 Offset: 0x20CC131 VA: 0x20CC030
	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, ref Vector3 out_listenerPos, ref Vector3 out_emitterPos, AkDiffractionPathInfoArray out_aPaths, out uint io_uArraySize) { }

	// RVA: 0x20CC1C0 Offset: 0x20CC2C1 VA: 0x20CC1C0
	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger) { }

	// RVA: 0x20CC250 Offset: 0x20CC351 VA: 0x20CC250
	public static void SetErrorLogger() { }

	// RVA: 0x20CC2D0 Offset: 0x20CC3D1 VA: 0x20CC2D0
	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat) { }

	// RVA: 0x20CC3A0 Offset: 0x20CC4A1 VA: 0x20CC3A0
	public static AKRESULT Init(AkInitializationSettings settings) { }

	// RVA: 0x20CC430 Offset: 0x20CC531 VA: 0x20CC430
	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings) { }

	// RVA: 0x20CC560 Offset: 0x20CC661 VA: 0x20CC560
	public static AKRESULT InitCommunication(AkCommunicationSettings settings) { }

	// RVA: 0x20CC5F0 Offset: 0x20CC6F1 VA: 0x20CC5F0
	public static void Term() { }

	// RVA: 0x20CC670 Offset: 0x20CC771 VA: 0x20CC670
	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj) { }

	// RVA: 0x20CC780 Offset: 0x20CC881 VA: 0x20CC780
	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj) { }

	// RVA: 0x20CC890 Offset: 0x20CC991 VA: 0x20CC890
	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName) { }

	// RVA: 0x20CCA00 Offset: 0x20CCB01 VA: 0x20CCA00
	public static AKRESULT SetBasePath(string in_pszBasePath) { }

	// RVA: 0x20CCAD0 Offset: 0x20CCBD1 VA: 0x20CCAD0
	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath) { }

	// RVA: 0x20CCBA0 Offset: 0x20CCCA1 VA: 0x20CCBA0
	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID) { }

	// RVA: 0x20CCC70 Offset: 0x20CCD71 VA: 0x20CCC70
	public static AKRESULT AddBasePath(string in_pszBasePath) { }

	// RVA: 0x20CCD40 Offset: 0x20CCE41 VA: 0x20CCD40
	public static AKRESULT SetGameName(string in_GameName) { }

	// RVA: 0x20CCE10 Offset: 0x20CCF11 VA: 0x20CCE10
	public static AKRESULT SetDecodedBankPath(string in_DecodedPath) { }

	// RVA: 0x20CCEE0 Offset: 0x20CCFE1 VA: 0x20CCEE0
	public static AKRESULT LoadAndDecodeBank(string in_pszString, bool in_bSaveDecodedBank, out uint out_bankID) { }

	// RVA: 0x20CCFD0 Offset: 0x20CD0D1 VA: 0x20CCFD0
	public static AKRESULT LoadAndDecodeBankFromMemory(IntPtr in_BankData, uint in_BankDataSize, bool in_bSaveDecodedBank, string in_DecodedBankName, bool in_bIsLanguageSpecific, out uint out_bankID) { }

	// RVA: 0x20CD110 Offset: 0x20CD211 VA: 0x20CD110
	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) { }

	// RVA: 0x20CD340 Offset: 0x20CD441 VA: 0x20CD340
	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }

	// RVA: 0x20CD550 Offset: 0x20CD651 VA: 0x20CD550
	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) { }

	// RVA: 0x20CD720 Offset: 0x20CD821 VA: 0x20CD720
	public static uint PostEventOnRoom(string in_pszEventName, ulong in_roomID) { }

	// RVA: 0x20CD830 Offset: 0x20CD931 VA: 0x20CD830
	public static string GetCurrentLanguage() { }

	// RVA: 0x20CD990 Offset: 0x20CDA91 VA: 0x20CD990
	public static AKRESULT UnloadFilePackage(uint in_uPackageID) { }

	// RVA: 0x20CDA10 Offset: 0x20CDB11 VA: 0x20CDA10
	public static AKRESULT UnloadAllFilePackages() { }

	// RVA: 0x20CDA90 Offset: 0x20CDB91 VA: 0x20CDA90
	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, Vector3 Pos, Vector3 Front, Vector3 Top) { }

	// RVA: 0x20CDC10 Offset: 0x20CDD11 VA: 0x20CDC10
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate) { }

	// RVA: 0x20CDF00 Offset: 0x20CE001 VA: 0x20CDF00
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions) { }

	// RVA: 0x20CE1E0 Offset: 0x20CE2E1 VA: 0x20CE1E0
	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners) { }

	// RVA: 0x20CE350 Offset: 0x20CE451 VA: 0x20CE350
	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners) { }

	// RVA: 0x20CE3E0 Offset: 0x20CE4E1 VA: 0x20CE3E0
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners) { }

	// RVA: 0x20CE490 Offset: 0x20CE591 VA: 0x20CE490
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs) { }

	// RVA: 0x20CE540 Offset: 0x20CE641 VA: 0x20CE540
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID) { }

	// RVA: 0x20CE5D0 Offset: 0x20CE6D1 VA: 0x20CE5D0
	public static AKRESULT AddOutput(AkOutputSettings in_Settings) { }

	// RVA: 0x20CE660 Offset: 0x20CE761 VA: 0x20CE660
	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings) { }

	// RVA: 0x20CE790 Offset: 0x20CE891 VA: 0x20CE790
	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings) { }

	// RVA: 0x20CE820 Offset: 0x20CE921 VA: 0x20CE820
	public static void GetDefaultMusicSettings(AkMusicSettings out_settings) { }

	// RVA: 0x20CE8B0 Offset: 0x20CE9B1 VA: 0x20CE8B0
	public static void GetDefaultInitSettings(AkInitSettings out_settings) { }

	// RVA: 0x20CE940 Offset: 0x20CEA41 VA: 0x20CE940
	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings) { }

	// RVA: 0x20CE9D0 Offset: 0x20CEAD1 VA: 0x20CE9D0
	public static uint GetMajorMinorVersion() { }

	// RVA: 0x20CEA50 Offset: 0x20CEB51 VA: 0x20CEA50
	public static uint GetSubminorBuildVersion() { }

	// RVA: 0x20CEAD0 Offset: 0x20CEBD1 VA: 0x20CEAD0
	public static void StartResourceMonitoring() { }

	// RVA: 0x20CEB50 Offset: 0x20CEC51 VA: 0x20CEB50
	public static void StopResourceMonitoring() { }

	// RVA: 0x20CEBD0 Offset: 0x20CECD1 VA: 0x20CEBD0
	public static void GetResourceMonitorDataSummary(AkResourceMonitorDataSummary resourceMonitorDataSummary) { }

	// RVA: 0x20CEC60 Offset: 0x20CED61 VA: 0x20CEC60
	public static AKRESULT SetRoomPortal(ulong in_PortalID, AkTransform Transform, Vector3 Extent, bool bEnabled, ulong FrontRoom, ulong BackRoom) { }

	// RVA: 0x20CED70 Offset: 0x20CEE71 VA: 0x20CED70
	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, string in_pName) { }

	// RVA: 0x20CEE80 Offset: 0x20CEF81 VA: 0x20CEE80
	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID) { }

	// RVA: 0x20CEFD0 Offset: 0x20CF0D1 VA: 0x20CEFD0
	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID) { }

	// RVA: 0x20CF120 Offset: 0x20CF221 VA: 0x20CF120
	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, Vector3[] Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, ulong RoomID, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges) { }

	// RVA: 0x20CF280 Offset: 0x20CF381 VA: 0x20CF280
	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID) { }

	// RVA: 0x20CF420 Offset: 0x20CF521 VA: 0x20CF420
	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources) { }

	// RVA: 0x20CF5B0 Offset: 0x20CF6B1 VA: 0x20CF5B0
	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie) { }

	// RVA: 0x20CF710 Offset: 0x20CF811 VA: 0x20CF710
	public static uint PostEventOnRoom(uint in_eventID, ulong in_roomID) { }

	// RVA: 0x20CF7E0 Offset: 0x20CF8E1 VA: 0x20CF7E0
	public static string StringFromIntPtrString(IntPtr ptr) { }

	// RVA: 0x20CF850 Offset: 0x20CF951 VA: 0x20CF850
	public static string StringFromIntPtrWString(IntPtr ptr) { }

	// RVA: 0x20CF8C0 Offset: 0x20CF9C1 VA: 0x20CF8C0
	private static ulong InternalGameObjectHash(GameObject gameObject) { }

	// RVA: 0x20CF960 Offset: 0x20CFA61 VA: 0x20CF960
	public static void set_GameObjectHash(AkSoundEngine.GameObjectHashFunction value) { }

	// RVA: 0x20B9230 Offset: 0x20B9331 VA: 0x20B9230
	public static ulong GetAkGameObjectID(GameObject gameObject) { }

	// RVA: 0x20CFA30 Offset: 0x20CFB31 VA: 0x20CFA30
	public static AKRESULT RegisterGameObj(GameObject gameObject) { }

	// RVA: 0x20CFC50 Offset: 0x20CFD51 VA: 0x20CFC50
	public static AKRESULT RegisterGameObj(GameObject gameObject, string name) { }

	// RVA: 0x20CFDE0 Offset: 0x20CFEE1 VA: 0x20CFDE0
	public static AKRESULT UnregisterGameObj(GameObject gameObject) { }

	// RVA: 0x20D0000 Offset: 0x20D0101 VA: 0x20D0000
	public static string get_WwiseVersion() { }

	// RVA: 0x20D02A0 Offset: 0x20D03A1 VA: 0x20D02A0
	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform) { }

	// RVA: 0x20D0430 Offset: 0x20D0531 VA: 0x20D0430
	public static AKRESULT SetObjectPosition(GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ) { }

	// RVA: 0x20B92B0 Offset: 0x20B93B1 VA: 0x20B92B0
	public static void PreGameObjectAPICall(GameObject gameObject, ulong id) { }

	// RVA: 0x20D05A0 Offset: 0x20D06A1 VA: 0x20D05A0
	private static void PreGameObjectAPICallUserHook(GameObject gameObject, ulong id) { }

	// RVA: 0x20CFBA0 Offset: 0x20CFCA1 VA: 0x20CFBA0
	private static void PostRegisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id) { }

	// RVA: 0x20CFF50 Offset: 0x20D0051 VA: 0x20CFF50
	private static void PostUnregisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id) { }

	// RVA: 0x20CD8E0 Offset: 0x20CD9E1 VA: 0x20CD8E0
	public static string StringFromIntPtrOSString(IntPtr ptr) { }

	// RVA: 0x20D07B0 Offset: 0x20D08B1 VA: 0x20D07B0
	private static void AutoRegister(GameObject gameObject, ulong id) { }

	// RVA: 0x20D0720 Offset: 0x20D0821 VA: 0x20D0720
	private static bool IsInRegisteredList(ulong id) { }

	// RVA: 0x20D08F0 Offset: 0x20D09F1 VA: 0x20D08F0
	public static bool IsGameObjectRegistered(GameObject in_gameObject) { }

	// RVA: 0x20D0A20 Offset: 0x20D0B21 VA: 0x20D0A20
	public void .ctor() { }

	// RVA: 0x20D0A30 Offset: 0x20D0B31 VA: 0x20D0A30
	private static void .cctor() { }
}

