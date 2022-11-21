namespace Mastermattie.FreeStyler.Client
{
    /// <summary>
    /// Send Command
    /// </summary>
    public enum FreeStylerCommand : ushort
    {
        /// <summary>
        /// Toggle all fixtures
        /// </summary>
        ToggleAllFixtures = 0,

        /// <summary>
        /// Toggle favorite
        /// </summary>
        ToggleFavorite = 1,

        /// <summary>
        /// Toggle blackout
        /// </summary>
        ToggleBlackout = 2,

        /// <summary>
        /// Toggle Freeze
        /// </summary>
        ToggleFreeze = 123,

        /// <summary>
        /// Release all
        /// </summary>
        ReleaseAll = 24,

        /// <summary>
        /// Fog / Smoke
        /// </summary>
        FogSmoke = 176,

        /// <summary>
        /// Fog level
        /// </summary>
        FogLevel = 304,

        /// <summary>
        /// Fog fan level
        /// </summary>
        FogFanLevel = 305,

        /// <summary>
        /// Lock MIDI input
        /// </summary>
        LockMidiInput = 181,

        /// <summary>
        /// Open all
        /// </summary>
        OpenAll = 569,

        /// <summary>
        /// Open gobo
        /// </summary>
        OpenGobo = 3,

        /// <summary>
        /// Open color
        /// </summary>
        OpenColor = 4,

        /// <summary>
        /// Open Pan/Tilt
        /// </summary>
        OpenPanTilt = 5,

        /// <summary>
        /// Open beam
        /// </summary>
        OpenBeam = 6,

        /// <summary>
        /// Open macro
        /// </summary>
        OpenMacro = 7,

        /// <summary>
        /// Open dmx400
        /// </summary>
        OpenDmx400 = 8,

        /// <summary>
        /// Open Lamp
        /// </summary>
        OpenLamp = 10,

        /// <summary>
        /// Open create sequence
        /// </summary>
        OpenCreateSequence = 11,

        /// <summary>
        /// Open cue
        /// </summary>
        OpenCue = 12,

        /// <summary>
        /// Open sound
        /// </summary>
        OpenSound = 13,

        /// <summary>
        /// Open output
        /// </summary>
        OpenOutput = 14,

        /// <summary>
        /// Open framing
        /// </summary>
        OpenFraming = 29,

        /// <summary>
        /// Open override buttons
        /// </summary>
        OpenOverrideButtons = 570,

        /// <summary>
        /// Open commandline
        /// </summary>
        OpenCommandLine = 571,

        /// <summary>
        /// Open master
        /// </summary>
        OpenMaster = 572,

        /// <summary>
        /// Open submaster
        /// </summary>
        OpenSubmaster = 573,

        /// <summary>
        /// Open smoke
        /// </summary>
        OpenSmoke = 574,

        /// <summary>
        /// Show sliders
        /// </summary>
        ShowSliders = 15,

        /// <summary>
        /// Next gobo
        /// </summary>
        NextGobo1 = 16,

        /// <summary>
        /// Next color
        /// </summary>
        NextColor1 = 17,

        /// <summary>
        /// Next gobo2
        /// </summary>
        NextGobo2 = 18,

        /// <summary>
        /// Next color2
        /// </summary>
        NextColor2 = 19,

        /// <summary>
        /// Previous Gobo
        /// </summary>
        PreviousGobo1 = 177,

        /// <summary>
        /// Previous Color
        /// </summary>
        PreviousColor1 = 178,

        /// <summary>
        /// Previous Gobo2
        /// </summary>
        PreviousGobo2 = 179,

        /// <summary>
        /// Previous Color2
        /// </summary>
        PreviousColor2 = 180,

        /// <summary>
        /// Pan right
        /// </summary>
        PanRight = 20,

        /// <summary>
        /// Pan 16 right
        /// </summary>
        Pan16Right = 585,

        /// <summary>
        /// Pan left
        /// </summary>
        PanLeft = 21,

        /// <summary>
        /// Pan 16 left
        /// </summary>
        Pan16Left = 586,

        /// <summary>
        /// Center
        /// </summary>
        Center = 566,

        /// <summary>
        /// Tilt up
        /// </summary>
        TiltUp = 22,

        /// <summary>
        /// Tilt 16 up
        /// </summary>
        Tilt16Up = 587,

        /// <summary>
        /// Tilt down
        /// </summary>
        TiltDown = 23,

        /// <summary>
        /// Tilt 16 down
        /// </summary>
        Tilt16Down = 588,

        /// <summary>
        /// Pan lock
        /// </summary>
        PanLock = 567,

        /// <summary>
        /// Tilt lock
        /// </summary>
        TiltLock = 568,

        /// <summary>
        /// Flip
        /// </summary>
        Flip = 565,

        /// <summary>
        /// Enable joystick
        /// </summary>
        EnableJoystick = 44,

        /// <summary>
        /// Toggle Joystick Pan/Tilt
        /// </summary>
        ToggleJoystickPanTilt = 122,

        /// <summary>
        /// Toggle Relative Pan-Tilt
        /// </summary>
        ToggleRelativePanTilt = 150,

        /// <summary>
        /// New sequence
        /// </summary>
        NewSequence = 25,

        /// <summary>
        /// Insert scene
        /// </summary>
        InsertScene = 26,

        /// <summary>
        /// scene
        /// </summary>
        RemoveScene = 27,

        /// <summary>
        /// Add scene
        /// </summary>
        AddScene = 28,

        /// <summary>
        /// Next scene
        /// </summary>
        NextScene = 575,

        /// <summary>
        /// Previous scene
        /// </summary>
        PreviousScene = 576,

        /// <summary>
        /// Play sequence
        /// </summary>
        PlaySecuence = 577,

        /// <summary>
        /// Fade time +1
        /// </summary>
        FadeTimeIncrease = 589,

        /// <summary>
        /// Fade time -1
        /// </summary>
        FadeTimeDecrease = 590,

        /// <summary>
        /// Speed time +1
        /// </summary>
        SpeedTimeIncrease = 591,

        /// <summary>
        /// Speed time -1
        /// </summary>
        SpeedTimeDecrease = 592,

        /// <summary>
        /// Open sequence
        /// </summary>
        OpenSequence = 593,

        /// <summary>
        /// Save sequence
        /// </summary>
        SaveSequence = 594,

        /// <summary>
        /// Quicksave
        /// </summary>
        QuickSave = 578,

        /// <summary>
        /// Save to all
        /// </summary>
        SaveToAAll = 579,

        /// <summary>
        /// Undo
        /// </summary>
        Undo = 580,

        /// <summary>
        /// Open FX
        /// </summary>
        OpenFX = 581,

        /// <summary>
        /// Zone 1
        /// </summary>
        Zone1 = 30,

        /// <summary>
        /// Zone 2
        /// </summary>
        Zone2 = 31,

        /// <summary>
        /// Zone 3
        /// </summary>
        Zone3 = 32,

        /// <summary>
        /// Zone 4
        /// </summary>
        Zone4 = 33,

        /// <summary>
        /// Select next fixture
        /// </summary>
        SelectNextFixture = 288,

        /// <summary>
        /// Select previous fixture
        /// </summary>
        SelectPreviousFixture = 289,

        /// <summary>
        /// Select even fixtures
        /// </summary>
        SelectEvenFixtures = 290,

        /// <summary>
        /// Select odd fixtures
        /// </summary>
        SelectOddFixtures = 291,

        /// <summary>
        /// Select same even fixtures
        /// </summary>
        SelectSameEvenFixtures = 292,

        /// <summary>
        /// Select same odd fixtures
        /// </summary>
        SelectSameOddFixtures = 293,

        /// <summary>
        /// Locate selected fixtures
        /// </summary>
        LocateSelectedFixtures = 294,

        /// <summary>
        /// Enable sound selected fixtures
        /// </summary>
        EnableSoundSelectedFixtures = 295,

        /// <summary>
        /// Previous group
        /// </summary>
        PreviousGroup = 296,

        /// <summary>
        /// Next Group
        /// </summary>
        NextGroup = 297,

        /// <summary>
        /// Group 1
        /// </summary>
        Group1 = 34,

        /// <summary>
        /// Group 2
        /// </summary>
        Group2 = 35,

        /// <summary>
        /// Group 3
        /// </summary>
        Group3 = 36,

        /// <summary>
        /// Group 4
        /// </summary>
        Group4 = 37,

        /// <summary>
        /// Group 5
        /// </summary>
        Group5 = 38,

        /// <summary>
        /// Group 6
        /// </summary>
        Group6 = 39,

        /// <summary>
        /// Group 7
        /// </summary>
        Group7 = 40,

        /// <summary>
        /// Group 8
        /// </summary>
        Group8 = 41,

        /// <summary>
        /// Group 9
        /// </summary>
        Group9 = 42,

        /// <summary>
        /// Group 10
        /// </summary>
        Group10 = 43,

        /// <summary>
        /// Group 11
        /// </summary>
        Group11 = 550,

        /// <summary>
        /// Group 12
        /// </summary>
        Group12 = 551,

        /// <summary>
        /// Group 13
        /// </summary>
        Group13 = 552,

        /// <summary>
        /// Group 14
        /// </summary>
        Group14 = 553,

        /// <summary>
        /// Group 15
        /// </summary>
        Group15 = 554,

        /// <summary>
        /// Group 16
        /// </summary>
        Group16 = 555,

        /// <summary>
        /// Group 17
        /// </summary>
        Group17 = 556,

        /// <summary>
        /// Group 18
        /// </summary>
        Group18 = 557,

        /// <summary>
        /// Group 19
        /// </summary>
        Group19 = 558,

        /// <summary>
        /// Group 20
        /// </summary>
        Group20 = 559,

        /// <summary>
        /// Group 21
        /// </summary>
        Group21 = 560,

        /// <summary>
        /// Group 22
        /// </summary>
        Group22 = 561,

        /// <summary>
        /// Group 23
        /// </summary>
        Group23 = 562,

        /// <summary>
        /// Group 24
        /// </summary>
        Group24 = 563,

        /// <summary>
        /// Blackout group 1
        /// </summary>
        BlackoutGroup1 = 98,

        /// <summary>
        /// Blackout group 2
        /// </summary>
        BlackoutGroup2 = 99,

        /// <summary>
        /// Blackout group 3
        /// </summary>
        BlackoutGroup3 = 100,

        /// <summary>
        /// Blackout group 4
        /// </summary>
        BlackoutGroup4 = 101,

        /// <summary>
        /// Blackout group 5
        /// </summary>
        BlackoutGroup5 = 102,

        /// <summary>
        /// Blackout group 6
        /// </summary>
        BlackoutGroup6 = 103,

        /// <summary>
        /// Blackout group 7
        /// </summary>
        BlackoutGroup7 = 104,

        /// <summary>
        /// Blackout group 8
        /// </summary>
        BlackoutGroup8 = 105,

        /// <summary>
        /// Blackout group 9
        /// </summary>
        BlackoutGroup9 = 106,

        /// <summary>
        /// Blackout group 10
        /// </summary>
        BlackoutGroup10 = 107,

        /// <summary>
        /// Blackout group 11
        /// </summary>
        BlackoutGroup11 = 108,

        /// <summary>
        /// Blackout group 12
        /// </summary>
        BlackoutGroup12 = 109,

        /// <summary>
        /// Blackout group 13
        /// </summary>
        BlackoutGroup13 = 110,

        /// <summary>
        /// Blackout group 14
        /// </summary>
        BlackoutGroup14 = 111,

        /// <summary>
        /// Blackout group 15
        /// </summary>
        BlackoutGroup15 = 112,

        /// <summary>
        /// Blackout group 16
        /// </summary>
        BlackoutGroup16 = 113,

        /// <summary>
        /// Blackout group 17
        /// </summary>
        BlackoutGroup17 = 114,

        /// <summary>
        /// Blackout group 18
        /// </summary>
        BlackoutGroup18 = 115,

        /// <summary>
        /// Blackout group 19
        /// </summary>
        BlackoutGroup19 = 116,

        /// <summary>
        /// Blackout group 20
        /// </summary>
        BlackoutGroup20 = 117,

        /// <summary>
        /// Blackout group 21
        /// </summary>
        BlackoutGroup21 = 118,

        /// <summary>
        /// Blackout group 22
        /// </summary>
        BlackoutGroup22 = 119,

        /// <summary>
        /// Blackout group 23
        /// </summary>
        BlackoutGroup23 = 120,

        /// <summary>
        /// Blackout group 24
        /// </summary>
        BlackoutGroup24 = 121,

        /// <summary>
        /// Dis. fixture override
        /// </summary>
        DisableFixtureOverride = 233,

        /// <summary>
        /// Dis. override group 1
        /// </summary>
        DisableOverrideGroup1 = 240,

        /// <summary>
        /// Dis. override group 2
        /// </summary>
        DisableOverrideGroup2 = 241,

        /// <summary>
        /// Dis. override group 3
        /// </summary>
        DisableOverrideGroup3 = 242,

        /// <summary>
        /// Dis. override group 4
        /// </summary>
        DisableOverrideGroup4 = 243,

        /// <summary>
        /// Dis. override group 5
        /// </summary>
        DisableOverrideGroup5 = 244,

        /// <summary>
        /// Dis. override group 6
        /// </summary>
        DisableOverrideGroup6 = 245,

        /// <summary>
        /// Dis. override group 7
        /// </summary>
        DisableOverrideGroup7 = 246,

        /// <summary>
        /// Dis. override group 8
        /// </summary>
        DisableOverrideGroup8 = 247,

        /// <summary>
        /// Dis. override group 9
        /// </summary>
        DisableOverrideGroup9 = 248,

        /// <summary>
        /// Dis. override group 10
        /// </summary>
        DisableOverrideGroup10 = 249,

        /// <summary>
        /// Dis. override group 11
        /// </summary>
        DisableOverrideGroup11 = 250,

        /// <summary>
        /// Dis. override group 12
        /// </summary>
        DisableOverrideGroup12 = 251,

        /// <summary>
        /// Dis. override group 13
        /// </summary>
        DisableOverrideGroup13 = 252,

        /// <summary>
        /// Dis. override group 144
        /// </summary>
        DisableOverrideGroup14 = 253,

        /// <summary>
        /// Dis. override group 15
        /// </summary>
        DisableOverrideGroup15 = 254,

        /// <summary>
        /// Dis. override group 16
        /// </summary>
        DisableOverrideGroup16 = 255,

        /// <summary>
        /// Dis. override group 17
        /// </summary>
        DisableOverrideGroup17 = 256,

        /// <summary>
        /// Dis. override group 18
        /// </summary>
        DisableOverrideGroup18 = 257,

        /// <summary>
        /// Dis. override group 19
        /// </summary>
        DisableOverrideGroup19 = 258,

        /// <summary>
        /// Dis. override group 20
        /// </summary>
        DisableOverrideGroup20 = 259,

        /// <summary>
        /// Dis. override group 21
        /// </summary>
        DisableOverrideGroup21 = 260,

        /// <summary>
        /// Dis. override group 22
        /// </summary>
        DisableOverrideGroup22 = 261,

        /// <summary>
        /// Dis. override group 23
        /// </summary>
        DisableOverrideGroup23 = 262,

        /// <summary>
        /// Dis. override group 24
        /// </summary>
        DisableOverrideGroup24 = 263,

        /// <summary>
        /// Multiselect sequence
        /// </summary>
        MultiselectSequence = 45,

        /// <summary>
        /// Toggle Sequence 1
        /// </summary>
        ToggleSequence1 = 46,

        /// <summary>
        /// Toggle Sequence 2
        /// </summary>
        ToggleSequence2 = 47,

        /// <summary>
        /// Toggle Sequence 3
        /// </summary>
        ToggleSequence3 = 48,

        /// <summary>
        /// Toggle Sequence 4
        /// </summary>
        ToggleSequence4 = 49,

        /// <summary>
        /// Toggle Sequence 5
        /// </summary>
        ToggleSequence5 = 50,

        /// <summary>
        /// Toggle Sequence 6
        /// </summary>
        ToggleSequence6 = 51,

        /// <summary>
        /// Toggle Sequence 7
        /// </summary>
        ToggleSequence7 = 52,

        /// <summary>
        /// Toggle Sequence 8
        /// </summary>
        ToggleSequence8 = 53,

        /// <summary>
        /// Toggle Sequence 9
        /// </summary>
        ToggleSequence9 = 54,

        /// <summary>
        /// Toggle Sequence 10
        /// </summary>
        ToggleSequence10 = 55,

        /// <summary>
        /// Toggle Sequence 11
        /// </summary>
        ToggleSequence11 = 56,

        /// <summary>
        /// Toggle Sequence 12
        /// </summary>
        ToggleSequence12 = 57,

        /// <summary>
        /// Toggle Sequence 13
        /// </summary>
        ToggleSequence13 = 58,

        /// <summary>
        /// Toggle Sequence 14
        /// </summary>
        ToggleSequence14 = 59,

        /// <summary>
        /// Toggle Sequence 15
        /// </summary>
        ToggleSequence15 = 60,

        /// <summary>
        /// Toggle Sequence 16
        /// </summary>
        ToggleSequence16 = 61,

        /// <summary>
        /// Toggle Sequence 17
        /// </summary>
        ToggleSequence17 = 62,

        /// <summary>
        /// Toggle Sequence 18
        /// </summary>
        ToggleSequence18 = 63,

        /// <summary>
        /// Toggle Sequence 19
        /// </summary>
        ToggleSequence19 = 64,

        /// <summary>
        /// Toggle Sequence 20
        /// </summary>
        ToggleSequence20 = 65,

        /// <summary>
        /// Start sequence 1
        /// </summary>
        StartSequence1 = 505,

        /// <summary>
        /// Start sequence 2
        /// </summary>
        StartSequence2 = 506,

        /// <summary>
        /// Start sequence 3
        /// </summary>
        StartSequence3 = 507,

        /// <summary>
        /// Start sequence 4
        /// </summary>
        StartSequence4 = 508,

        /// <summary>
        /// Start sequence 5
        /// </summary>
        StartSequence5 = 509,

        /// <summary>
        /// Start sequence 6
        /// </summary>
        StartSequence6 = 510,

        /// <summary>
        /// Start sequence 7
        /// </summary>
        StartSequence7 = 511,

        /// <summary>
        /// Start sequence 8
        /// </summary>
        StartSequence8 = 512,

        /// <summary>
        /// Start sequence 9
        /// </summary>
        StartSequence9 = 513,

        /// <summary>
        /// Start sequence 10
        /// </summary>
        StartSequence10 = 514,

        /// <summary>
        /// Start sequence 11
        /// </summary>
        StartSequence11 = 515,

        /// <summary>
        /// Start sequence 12
        /// </summary>
        StartSequence12 = 516,

        /// <summary>
        /// Start sequence 13
        /// </summary>
        StartSequence13 = 517,

        /// <summary>
        /// Start sequence 14
        /// </summary>
        StartSequence14 = 518,

        /// <summary>
        /// Start sequence 15
        /// </summary>
        StartSequence15 = 519,

        /// <summary>
        /// Start sequence 16
        /// </summary>
        StartSequence16 = 520,

        /// <summary>
        /// Start sequence 17
        /// </summary>
        StartSequence17 = 521,

        /// <summary>
        /// Start sequence 18
        /// </summary>
        StartSequence18 = 522,

        /// <summary>
        /// Start sequence 19
        /// </summary>
        StartSequence19 = 523,

        /// <summary>
        /// Start sequence 20
        /// </summary>
        StartSequence20 = 524,

        /// <summary>
        /// Start sequence 1
        /// </summary>
        StopSequence1 = 525,

        /// <summary>
        /// Start sequence 2
        /// </summary>
        StopSequence2 = 526,

        /// <summary>
        /// Start sequence 3
        /// </summary>
        StopSequence3 = 527,

        /// <summary>
        /// Start sequence 44
        /// </summary>
        StopSequence4 = 528,

        /// <summary>
        /// Start sequence 5
        /// </summary>
        StopSequence5 = 529,

        /// <summary>
        /// Start sequence 6
        /// </summary>
        StopSequence6 = 530,

        /// <summary>
        /// Start sequence 7
        /// </summary>
        StopSequence7 = 531,

        /// <summary>
        /// Start sequence 8
        /// </summary>
        StopSequence8 = 532,

        /// <summary>
        /// Start sequence 9
        /// </summary>
        StopSequence9 = 533,

        /// <summary>
        /// Start sequence 10
        /// </summary>
        StopSequence10 = 534,

        /// <summary>
        /// Start sequence 11
        /// </summary>
        StopSequence11 = 535,

        /// <summary>
        /// Start sequence 12
        /// </summary>
        StopSequence12 = 536,

        /// <summary>
        /// Start sequence 13
        /// </summary>
        StopSequence13 = 537,

        /// <summary>
        /// Start sequence 14
        /// </summary>
        StopSequence14 = 538,

        /// <summary>
        /// Start sequence 15
        /// </summary>
        StopSequence15 = 539,

        /// <summary>
        /// Start sequence 16
        /// </summary>
        StopSequence16 = 540,

        /// <summary>
        /// Start sequence 17
        /// </summary>
        StopSequence17 = 541,

        /// <summary>
        /// Start sequence 18
        /// </summary>
        StopSequence18 = 542,

        /// <summary>
        /// Start sequence 19
        /// </summary>
        StopSequence19 = 543,

        /// <summary>
        /// Start sequence 20
        /// </summary>
        StopSequence20 = 544,

        /// <summary>
        /// Masterspeed
        /// </summary>
        Masterspeed = 206,

        /// <summary>
        /// Sequence 1 speed
        /// </summary>
        Sequence1Speed = 156,

        /// <summary>
        /// Sequence 2 speed
        /// </summary>
        Sequence2Speed = 157,

        /// <summary>
        /// Sequence 3 speed
        /// </summary>
        Sequence3Speed = 158,

        /// <summary>
        /// Sequence 4 speed
        /// </summary>
        Sequence4Speed = 159,

        /// <summary>
        /// Sequence 5 speed
        /// </summary>
        Sequence5Speed = 160,

        /// <summary>
        /// Sequence 6 speed
        /// </summary>
        Sequence6Speed = 161,

        /// <summary>
        /// Sequence 7 speed
        /// </summary>
        Sequence7Speed = 162,

        /// <summary>
        /// Sequence 8 speed
        /// </summary>
        Sequence8Speed = 163,

        /// <summary>
        /// Sequence 9 speed
        /// </summary>
        Sequence9Speed = 164,

        /// <summary>
        /// Sequence 10 speed
        /// </summary>
        Sequence10Speed = 165,

        /// <summary>
        /// Sequence 11 speed
        /// </summary>
        Sequence11Speed = 166,

        /// <summary>
        /// Sequence 12 speed
        /// </summary>
        Sequence12Speed = 167,

        /// <summary>
        /// Sequence 13 speed
        /// </summary>
        Sequence13Speed = 168,

        /// <summary>
        /// Sequence 14 speed
        /// </summary>
        Sequence14Speed = 169,

        /// <summary>
        /// Sequence 15 speed
        /// </summary>
        Sequence15Speed = 170,

        /// <summary>
        /// Sequence 16 speed
        /// </summary>
        Sequence16Speed = 171,

        /// <summary>
        /// Sequence 17 speed
        /// </summary>
        Sequence17Speed = 172,

        /// <summary>
        /// Sequence 18 speed
        /// </summary>
        Sequence18Speed = 173,

        /// <summary>
        /// Sequence 19 speed
        /// </summary>
        Sequence19Speed = 174,

        /// <summary>
        /// Sequence 20 speed
        /// </summary>
        Sequence20Speed = 175,

        /// <summary>
        /// Disable all buttons
        /// </summary>
        DisableAllButtons = 265,

        /// <summary>
        /// Previous Overr. tab
        /// </summary>
        PreviousOverrideTab = 298,

        /// <summary>
        /// Next overr. tab
        /// </summary>
        NextOverrideTab = 299,

        /// <summary>
        /// Overridebuttons tab 1
        /// </summary>
        OverrideButtonsTab1 = 234,

        /// <summary>
        /// Overridebuttons tab 2
        /// </summary>
        OverrideButtonsTab2 = 235,

        /// <summary>
        /// Overridebuttons tab 3
        /// </summary>
        OverrideButtonsTab3 = 236,

        /// <summary>
        /// Overridebuttons tab 4
        /// </summary>
        OverrideButtonsTab4 = 237,

        /// <summary>
        /// Overridebuttons tab 5
        /// </summary>
        OverrideButtonsTab5 = 238,

        /// <summary>
        /// Overridebuttons tab 6
        /// </summary>
        OverrideButtonsTab6 = 239,

        /// <summary>
        /// Override button 1
        /// </summary>
        OverrideButton1 = 66,

        /// <summary>
        /// Override button 2
        /// </summary>
        OverrideButton2 = 67,

        /// <summary>
        /// Override button 3
        /// </summary>
        OverrideButton3 = 68,

        /// <summary>
        /// Override button 4
        /// </summary>
        OverrideButton4 = 69,

        /// <summary>
        /// Override button 5
        /// </summary>
        OverrideButton5 = 70,

        /// <summary>
        /// Override button 6
        /// </summary>
        OverrideButton6 = 71,

        /// <summary>
        /// Override button 7
        /// </summary>
        OverrideButton7 = 72,

        /// <summary>
        /// Override button 8
        /// </summary>
        OverrideButton8 = 73,

        /// <summary>
        /// Override button 9
        /// </summary>
        OverrideButton9 = 74,

        /// <summary>
        /// Override button 10
        /// </summary>
        OverrideButton10 = 75,

        /// <summary>
        /// Override button 11
        /// </summary>
        OverrideButton11 = 76,

        /// <summary>
        /// Override button 12
        /// </summary>
        OverrideButton12 = 77,

        /// <summary>
        /// Override button 13
        /// </summary>
        OverrideButton13 = 78,

        /// <summary>
        /// Override button 14
        /// </summary>
        OverrideButton14 = 79,

        /// <summary>
        /// Override button 15
        /// </summary>
        OverrideButton15 = 80,

        /// <summary>
        /// Override button 16
        /// </summary>
        OverrideButton16 = 81,

        /// <summary>
        /// Override button 17
        /// </summary>
        OverrideButton17 = 82,

        /// <summary>
        /// Override button 18
        /// </summary>
        OverrideButton18 = 83,

        /// <summary>
        /// Override button 19
        /// </summary>
        OverrideButton19 = 84,

        /// <summary>
        /// Override button 20
        /// </summary>
        OverrideButton20 = 85,

        /// <summary>
        /// Override button 21
        /// </summary>
        OverrideButton21 = 86,

        /// <summary>
        /// Override button 22
        /// </summary>
        OverrideButton22 = 87,

        /// <summary>
        /// Override button 23
        /// </summary>
        OverrideButton23 = 88,

        /// <summary>
        /// Override button 24
        /// </summary>
        OverrideButton24 = 89,

        /// <summary>
        /// Override button 25
        /// </summary>
        OverrideButton25 = 90,

        /// <summary>
        /// Override button 26
        /// </summary>
        OverrideButton26 = 91,

        /// <summary>
        /// Override button 27
        /// </summary>
        OverrideButton27 = 92,

        /// <summary>
        /// Override button 28
        /// </summary>
        OverrideButton28 = 93,

        /// <summary>
        /// Override button 29
        /// </summary>
        OverrideButton29 = 94,

        /// <summary>
        /// Override button 30
        /// </summary>
        OverrideButton30 = 95,

        /// <summary>
        /// Override button 31
        /// </summary>
        OverrideButton31 = 96,

        /// <summary>
        /// Override button 32
        /// </summary>
        OverrideButton32 = 97,

        /// <summary>
        /// Overridebutton ...
        /// </summary>
        OverrideButton = 384,

        /// <summary>
        /// Gobo 1 channel
        /// </summary>
        Gobo1Channel = 124,

        /// <summary>
        /// Gobo 2 channel
        /// </summary>
        Gobo2Channel = 125,

        /// <summary>
        /// Gobo Rotation channel
        /// </summary>
        Gobo1RotationChannel = 126,

        /// <summary>
        /// Gobo 2 Rotation channel
        /// </summary>
        Gobo2RotationChannel = 127,

        /// <summary>
        /// Color channel
        /// </summary>
        Color1Channel = 128,

        /// <summary>
        /// Color 2 channel
        /// </summary>
        Color2Channel = 129,

        /// <summary>
        /// Cyan channel
        /// </summary>
        CyanChannel = 130,

        /// <summary>
        /// Magenta channel
        /// </summary>
        MagentaChannel = 131,

        /// <summary>
        /// Yellow channel
        /// </summary>
        YellowChannel = 132,

        /// <summary>
        /// CTO/Amber channel
        /// </summary>
        CTOAmberChannel = 582,

        /// <summary>
        /// White1 channel
        /// </summary>
        White1Channel = 583,

        /// <summary>
        /// White2 channel
        /// </summary>
        White2Channel = 584,

        /// <summary>
        /// Pan 8bit channel
        /// </summary>
        Pan8BitChannel = 133,

        /// <summary>
        /// Tilt 8bit channel
        /// </summary>
        Tilt8BitChannel = 135,

        /// <summary>
        /// Shutter channel
        /// </summary>
        ShutterChannel = 137,

        /// <summary>
        /// Intensity channel
        /// </summary>
        IntensityChannel = 138,

        /// <summary>
        /// Prism channel
        /// </summary>
        PrismChannel = 139,

        /// <summary>
        /// Prism rotation channel
        /// </summary>
        PrismRotationChannel = 140,

        /// <summary>
        /// Focus channel
        /// </summary>
        FocusChannel = 141,

        /// <summary>
        /// Zoom channel
        /// </summary>
        ZoomChannel = 142,

        /// <summary>
        /// Iris channel
        /// </summary>
        IrisChannel = 143,

        /// <summary>
        /// Frost channel
        /// </summary>
        FrostChannel = 144,

        /// <summary>
        /// Gobo ch. + 1
        /// </summary>
        Gobo1ChannelIncrease = 340,

        /// <summary>
        /// Gobo ch. - 1
        /// </summary>
        Gobo1ChannelDecrease = 341,

        /// <summary>
        /// Gobo2 ch. + 1
        /// </summary>
        Gobo2ChannelIncrease = 342,

        /// <summary>
        /// Gobo2 ch. - 1
        /// </summary>
        Gobo2ChannelDecrease = 343,

        /// <summary>
        /// Gobo3 ch. + 1
        /// </summary>
        Gobo3ChannelIncrease = 344,

        /// <summary>
        /// Gobo3 ch. - 1
        /// </summary>
        Gobo3ChannelDecrease = 345,

        /// <summary>
        /// Color ch. + 1
        /// </summary>
        Color1ChannelIncrease = 346,

        /// <summary>
        /// Color ch. - 1
        /// </summary>
        Color1ChannelDecrease = 347,

        /// <summary>
        /// Color2 ch. + 1
        /// </summary>
        Color2ChannelIncrease = 348,

        /// <summary>
        /// Color2 ch. - 1
        /// </summary>
        Color2ChannelDecrease = 349,

        /// <summary>
        /// GoboRot ch. + 1
        /// </summary>
        GoboRot1ChannelIncrease = 350,

        /// <summary>
        /// GoboRot ch. - 1
        /// </summary>
        GoboRot1ChannelDecrease = 351,

        /// <summary>
        /// GoboRot2 ch. + 1
        /// </summary>
        GoboRot2ChannelIncrease = 352,

        /// <summary>
        /// GoboRot2 ch. - 1
        /// </summary>
        GoboRot2ChannelDecrease = 353,

        /// <summary>
        /// Cyan ch. + 1
        /// </summary>
        CyanChannelIncrease = 354,

        /// <summary>
        /// Cyan ch. - 1
        /// </summary>
        CyanChannelDecrease = 355,

        /// <summary>
        /// Magenta ch. + 1
        /// </summary>
        MagentaChannelIncrease = 356,

        /// <summary>
        /// Magenta ch. - 1
        /// </summary>
        MagentaChannelDecrease = 357,

        /// <summary>
        /// Yellow ch. + 1
        /// </summary>
        YellowChannelIncrease = 358,

        /// <summary>
        /// Yellow ch. - 1
        /// </summary>
        YellowChannelDecrease = 359,

        /// <summary>
        /// Pan ch. + 1
        /// </summary>
        PanChannelIncrease = 360,

        /// <summary>
        /// Pan ch. - 1
        /// </summary>
        PanChannelDecrease = 361,

        /// <summary>
        /// Tilt ch. + 1
        /// </summary>
        TiltChannelIncrease = 362,

        /// <summary>
        /// Tilt ch. - 1
        /// </summary>
        TiltChannelDecrease = 363,

        /// <summary>
        /// Pan16 ch. + 1
        /// </summary>
        Pan16ChannelIncrease = 364,

        /// <summary>
        /// Pan16 ch. - 1
        /// </summary>
        Pan16ChannelDecrease = 365,

        /// <summary>
        /// Tilt16 ch. + 1
        /// </summary>
        Tilt16ChannelIncrease = 366,

        /// <summary>
        /// Tilt16 ch. - 1
        /// </summary>
        Tilt16ChannelDecrease = 367,

        /// <summary>
        /// Shutter ch. + 1
        /// </summary>
        ShutterChannelIncrease = 368,

        /// <summary>
        /// Schutter ch. - 1
        /// </summary>
        ShutterChannelDecrease = 369,

        /// <summary>
        /// Dimmer ch. + 1
        /// </summary>
        DimmerChannelIncrease = 370,

        /// <summary>
        /// Dimmer ch. - 1
        /// </summary>
        DimmerChannelDecrease = 371,

        /// <summary>
        /// Prism ch. + 1
        /// </summary>
        PrismChannelIncrease = 372,

        /// <summary>
        /// Prism ch. - 1
        /// </summary>
        PrismChannelDecrease = 373,

        /// <summary>
        /// PrismRot ch. + 1
        /// </summary>
        PrismRotChannelIncrease = 374,

        /// <summary>
        /// PrismRot ch. - 1
        /// </summary>
        PrismRotChannelDecrease = 375,

        /// <summary>
        /// Focus ch. + 1
        /// </summary>
        FocusChannelIncrease = 376,

        /// <summary>
        /// Focus ch. - 1
        /// </summary>
        FocusChannelDecrease = 377,

        /// <summary>
        /// Zoom ch. + 1
        /// </summary>
        ZoomChannelIncrease = 378,

        /// <summary>
        /// Zoom ch. - 1
        /// </summary>
        ZoomChannelDecrease = 379,

        /// <summary>
        /// Iris ch. + 1
        /// </summary>
        IrisChannelIncrease = 380,

        /// <summary>
        /// Iris ch. - 1
        /// </summary>
        IrisChannelDecrease = 381,

        /// <summary>
        /// Frost ch. + 1
        /// </summary>
        FrostChannelIncrease = 382,

        /// <summary>
        /// Frost ch. - 1
        /// </summary>
        FrostChannelDecrease = 383,

        /// <summary>
        /// Shutter open
        /// </summary>
        ShutterOpen = 545,

        /// <summary>
        /// Shutter closed
        /// </summary>
        ShutterClosed = 546,

        /// <summary>
        /// Strobe Low
        /// </summary>
        StrobeLow = 547,

        /// <summary>
        /// Strobe Med
        /// </summary>
        StrobeMedium = 548,

        /// <summary>
        /// Strobe High
        /// </summary>
        StrobeHight = 549,

        /// <summary>
        /// Random Gobo 1
        /// </summary>
        RandomGobo1 = 485,

        /// <summary>
        /// Random Color 1
        /// </summary>
        RandomColor1 = 486,

        /// <summary>
        /// Random Iris
        /// </summary>
        RandomIris = 487,

        /// <summary>
        /// Random Strobe
        /// </summary>
        RandomStrobe = 488,

        /// <summary>
        /// Random Dimmer
        /// </summary>
        RandomDimmer = 489,

        /// <summary>
        /// Random RGB
        /// </summary>
        RandomRGB = 490,

        /// <summary>
        /// Random Pan/Tilt
        /// </summary>
        RandomPanTilt = 491,

        /// <summary>
        /// Random Gobo 1 by group
        /// </summary>
        RandomGobo1ByGroup = 492,

        /// <summary>
        /// Random Color 1 by group
        /// </summary>
        RandomColor1ByGroup = 493,

        /// <summary>
        /// Random Iris by group
        /// </summary>
        RandomIrisByGroup = 494,

        /// <summary>
        /// Random Strobe by group
        /// </summary>
        RandomStrobeByGroup = 495,

        /// <summary>
        /// Random Dimmer by group
        /// </summary>
        RandomDimmerByGroup = 496,

        /// <summary>
        /// Random RGB by group
        /// </summary>
        RandomRGBByGroup = 497,

        /// <summary>
        /// Random Pan/Tilt by group
        /// </summary>
        randomPanTiltByGroup = 498,

        /// <summary>
        /// Tap Sync
        /// </summary>
        TapSync = 9,

        /// <summary>
        /// Manual trigger
        /// </summary>
        ManualTrigger = 207,

        /// <summary>
        /// Sound To Light trigger
        /// </summary>
        SoundToLightTrigger = 232,

        /// <summary>
        /// Disable tap / manual trigger
        /// </summary>
        DisableTapManualTrigger = 134,

        /// <summary>
        /// Empty
        /// </summary>
        Empty = 136,

        /// <summary>
        /// Midi Page 1
        /// </summary>
        MidiPage1 = 145,

        /// <summary>
        /// Midi Page 2
        /// </summary>
        MidiPage2 = 146,

        /// <summary>
        /// Midi Page 3
        /// </summary>
        MidiPage3 = 147,

        /// <summary>
        /// Midi Page 4
        /// </summary>
        MidiPage4 = 148,

        /// <summary>
        /// Midi Page 5
        /// </summary>
        MidiPage5 = 149,

        /// <summary>
        /// Shift function
        /// </summary>
        ShiftFunction = 264,

        /// <summary>
        /// Touchscreen Page 1
        /// </summary>
        TouchscreenPage1 = 499,

        /// <summary>
        /// Touchscreen Page 2
        /// </summary>
        TouchscreenPage2 = 500,

        /// <summary>
        /// Touchscreen Page 3
        /// </summary>
        TouchscreenPage3 = 501,

        /// <summary>
        /// Touchscreen Page 4
        /// </summary>
        TouchscreenPage4 = 502,

        /// <summary>
        /// Touchscreen Page 5
        /// </summary>
        TouchscreenPage5 = 503,

        /// <summary>
        /// Touchscreen Page 6
        /// </summary>
        TouchscreenPage6 = 504,

        /// <summary>
        /// Master 100%
        /// </summary>
        MasterFull = 151,

        /// <summary>
        /// Master 0%
        /// </summary>
        MasterEmpty = 152,

        /// <summary>
        /// Fade In
        /// </summary>
        FadeIn = 153,

        /// <summary>
        /// Fade Out
        /// </summary>
        FadeOut = 154,

        /// <summary>
        /// Master Intensity
        /// </summary>
        MasterIntensity = 155,

        /// <summary>
        /// Previous submaster tab
        /// </summary>
        PreviousSubmasterTab = 302,

        /// <summary>
        /// Next submaster tab
        /// </summary>
        NextSumasterTab = 303,

        /// <summary>
        /// Toggle Submaster 1
        /// </summary>
        ToggleSubmaster1 = 182,

        /// <summary>
        /// Toggle Submaster 2
        /// </summary>
        ToggleSubmaster2 = 183,

        /// <summary>
        /// Toggle Submaster 3
        /// </summary>
        ToggleSubmaster3 = 184,

        /// <summary>
        /// Toggle Submaster 4
        /// </summary>
        ToggleSubmaster4 = 185,

        /// <summary>
        /// Toggle Submaster 5
        /// </summary>
        ToggleSubmaster5 = 186,

        /// <summary>
        /// Submaster Go 1
        /// </summary>
        SubmasterGo1 = 187,

        /// <summary>
        /// Submaster Back 1
        /// </summary>
        SubmasterBack1 = 188,

        /// <summary>
        /// Submaster Go 2
        /// </summary>
        SubmasterGo2 = 189,

        /// <summary>
        /// Submaster Back 2
        /// </summary>
        SubmasteBack2 = 190,

        /// <summary>
        /// Submaster Go 3
        /// </summary>
        SubmasterGo3 = 191,

        /// <summary>
        /// Submaster Back 3
        /// </summary>
        SubmasteBack3 = 192,

        /// <summary>
        /// Submaster Go 4
        /// </summary>
        SubmasterGo4 = 193,

        /// <summary>
        /// Submaster Back 4
        /// </summary>
        SubmasteBack4 = 194,

        /// <summary>
        /// Submaster Go 5
        /// </summary>
        SubmasteGo5 = 195,

        /// <summary>
        /// Submaster Back 5
        /// </summary>
        SubmasteBack5 = 196,

        /// <summary>
        /// Submaster Page 1
        /// </summary>
        SubmasterPage1 = 197,

        /// <summary>
        /// Submaster Page 2
        /// </summary>
        SubmasterPage2 = 198,

        /// <summary>
        /// Submaster Page 3
        /// </summary>
        SubmasterPage3 = 199,

        /// <summary>
        /// Submaster Page 4
        /// </summary>
        SubmasterPage4 = 200,

        /// <summary>
        /// Subm. Intensity 1
        /// </summary>
        SubmasterIntensity1 = 201,

        /// <summary>
        /// Subm. Intensity 2
        /// </summary>
        SubmasterIntensity2 = 202,

        /// <summary>
        /// Subm. Intensity 3
        /// </summary>
        SubmasterIntensity3 = 203,

        /// <summary>
        /// Subm. Intensity 4
        /// </summary>
        SubmasterIntensity4 = 204,

        /// <summary>
        /// Subm. Intensity 5
        /// </summary>
        SubmasterIntensity5 = 205,

        /// <summary>
        /// Submaster Run 1
        /// </summary>
        SubmasterRun1 = 385,

        /// <summary>
        /// Submaster Run 2
        /// </summary>
        SubmasterRun2 = 386,

        /// <summary>
        /// Submaster Run 3
        /// </summary>
        SubmasterRun3 = 387,

        /// <summary>
        /// Submaster Run 4
        /// </summary>
        SubmasterRun4 = 388,

        /// <summary>
        /// Submaster Run 5
        /// </summary>
        SubmasterRun5 = 389,

        /// <summary>
        /// Submaster Run 6
        /// </summary>
        SubmasterRun6 = 390,

        /// <summary>
        /// Submaster Run 7
        /// </summary>
        SubmasterRun7 = 391,

        /// <summary>
        /// Submaster Run 8
        /// </summary>
        SubmasterRun8 = 392,

        /// <summary>
        /// Submaster Run 9
        /// </summary>
        SubmasterRun9 = 393,

        /// <summary>
        /// Submaster Run 10
        /// </summary>
        SubmasterRun10 = 394,

        /// <summary>
        /// Submaster Run 11
        /// </summary>
        SubmasterRun11 = 395,

        /// <summary>
        /// Submaster Run 12
        /// </summary>
        SubmasterRun12 = 396,

        /// <summary>
        /// Submaster Run 13
        /// </summary>
        SubmasterRun13 = 397,

        /// <summary>
        /// Submaster Run 14
        /// </summary>
        SubmasterRun14 = 398,

        /// <summary>
        /// Submaster Run 15
        /// </summary>
        SubmasterRun15 = 399,

        /// <summary>
        /// Submaster Run 16
        /// </summary>
        SubmasterRun16 = 400,

        /// <summary>
        /// Submaster Run 17
        /// </summary>
        SubmasterRun17 = 401,

        /// <summary>
        /// Submaster Run 18
        /// </summary>
        SubmasterRun18 = 402,

        /// <summary>
        /// Submaster Run 19
        /// </summary>
        SubmasterRun19 = 403,

        /// <summary>
        /// Submaster Run 20
        /// </summary>
        SubmasterRun20 = 404,

        /// <summary>
        /// Submaster Stop 1
        /// </summary>
        SubmasterStop1 = 405,

        /// <summary>
        /// Submaster Stop 2
        /// </summary>
        SubmasterStop2 = 406,

        /// <summary>
        /// Submaster Stop 3
        /// </summary>
        SubmasterStop3 = 407,

        /// <summary>
        /// Submaster Stop 4
        /// </summary>
        SubmasterStop4 = 408,

        /// <summary>
        /// Submaster Stop 5
        /// </summary>
        SubmasterStop5 = 409,

        /// <summary>
        /// Submaster Stop 6
        /// </summary>
        SubmasterStop6 = 410,

        /// <summary>
        /// Submaster Stop 7
        /// </summary>
        SubmasterStop7 = 411,

        /// <summary>
        /// Submaster Stop 8
        /// </summary>
        SubmasterStop8 = 412,

        /// <summary>
        /// Submaster Stop 9
        /// </summary>
        SubmasterStop9 = 413,

        /// <summary>
        /// Submaster Stop 10
        /// </summary>
        SubmasterStop10 = 414,

        /// <summary>
        /// Submaster Stop 11
        /// </summary>
        SubmasterStop11 = 415,

        /// <summary>
        /// Submaster Stop 12
        /// </summary>
        SubmasterStop12 = 416,

        /// <summary>
        /// Submaster Stop 13
        /// </summary>
        SubmasterStop13 = 417,

        /// <summary>
        /// Submaster Stop 14
        /// </summary>
        SubmasterStop14 = 418,

        /// <summary>
        /// Submaster Stop 15
        /// </summary>
        SubmasterStop15 = 419,

        /// <summary>
        /// Submaster Stop 16
        /// </summary>
        SubmasterStop16 = 420,

        /// <summary>
        /// Submaster Stop 17
        /// </summary>
        SubmasterStop17 = 421,

        /// <summary>
        /// Submaster Stop 18
        /// </summary>
        SubmasterStop18 = 422,

        /// <summary>
        /// Submaster Stop 19
        /// </summary>
        SubmasterStop19 = 423,

        /// <summary>
        /// Submaster Stop 20
        /// </summary>
        SubmasterStop20 = 424,

        /// <summary>
        /// Submaster Go 1
        /// </summary>
        SubmasterGo1_X = 425,

        /// <summary>
        /// Submaster Go 2
        /// </summary>
        SubmasterGo2_X = 426,

        /// <summary>
        /// Submaster Go 3
        /// </summary>
        SubmasterGo3_X = 427,

        /// <summary>
        /// Submaster Go 4
        /// </summary>
        SubmasterGo4_X = 428,

        /// <summary>
        /// Submaster Go 5
        /// </summary>
        SubmasterGo5_X = 429,

        /// <summary>
        /// Submaster Go 6
        /// </summary>
        SubmasterGo6_X = 430,

        /// <summary>
        /// Submaster Go 7
        /// </summary>
        SubmasterGo7_X = 431,

        /// <summary>
        /// Submaster Go 8
        /// </summary>
        SubmasterGo8_X = 432,

        /// <summary>
        /// Submaster Go 9
        /// </summary>
        SubmasterGo9_X = 433,

        /// <summary>
        /// Submaster Go 10
        /// </summary>
        SubmasterGo10_X = 434,

        /// <summary>
        /// Submaster Go 11
        /// </summary>
        SubmasterGo11_X = 435,

        /// <summary>
        /// Submaster Go 12
        /// </summary>
        SubmasterGo12_X = 436,

        /// <summary>
        /// Submaster Go 13
        /// </summary>
        SubmasterGo13_X = 437,

        /// <summary>
        /// Submaster Go 14
        /// </summary>
        SubmasterGo14_X = 438,

        /// <summary>
        /// Submaster Go 15
        /// </summary>
        SubmasterGo15_X = 439,

        /// <summary>
        /// Submaster Go 16
        /// </summary>
        SubmasterGo16_X = 440,

        /// <summary>
        /// Submaster Go 17
        /// </summary>
        SubmasterGo17_X = 441,

        /// <summary>
        /// Submaster Go 18
        /// </summary>
        SubmasterGo18_X = 442,

        /// <summary>
        /// Submaster Go 19
        /// </summary>
        SubmasterGo19_X = 443,

        /// <summary>
        /// Submaster Go 20
        /// </summary>
        SubmasterGo20_X = 444,

        /// <summary>
        /// Submaster Back 1
        /// </summary>
        SubmasterBack1_X = 445,

        /// <summary>
        /// Submaster Back 2
        /// </summary>
        SubmasterBack2_X = 446,

        /// <summary>
        /// Submaster Back 3
        /// </summary>
        SubmasterBack3_X = 447,

        /// <summary>
        /// Submaster Back 4
        /// </summary>
        SubmasterBack4_X = 448,

        /// <summary>
        /// Submaster Back 5
        /// </summary>
        SubmasterBack5_X = 449,

        /// <summary>
        /// Submaster Back 6
        /// </summary>
        SubmasterBack6_X = 450,

        /// <summary>
        /// Submaster Back 7
        /// </summary>
        SubmasterBack7_X = 451,

        /// <summary>
        /// Submaster Back 8
        /// </summary>
        SubmasterBack8_X = 452,

        /// <summary>
        /// Submaster Back 9
        /// </summary>
        SubmasterBack9_X = 453,

        /// <summary>
        /// Submaster Back 10
        /// </summary>
        SubmasterBack10_X = 454,

        /// <summary>
        /// Submaster Back 11
        /// </summary>
        SubmasterBack11_X = 455,

        /// <summary>
        /// Submaster Back 12
        /// </summary>
        SubmasterBack12_X = 456,

        /// <summary>
        /// Submaster Back 13
        /// </summary>
        SubmasterBack13_X = 457,

        /// <summary>
        /// Submaster Back 14
        /// </summary>
        SubmasterBack14_X = 458,

        /// <summary>
        /// Submaster Back 15
        /// </summary>
        SubmasterBack15_X = 459,

        /// <summary>
        /// Submaster Back 16
        /// </summary>
        SubmasterBack16_X = 460,

        /// <summary>
        /// Submaster Back 17
        /// </summary>
        SubmasterBack17_X = 461,

        /// <summary>
        /// Submaster Back 18
        /// </summary>
        SubmasterBack18_X = 462,

        /// <summary>
        /// Submaster Back 19
        /// </summary>
        SubmasterBack19_X = 463,

        /// <summary>
        /// Submaster Back 20
        /// </summary>
        SubmasterBack20_X = 464,

        /// <summary>
        /// Submaster intens. 1
        /// </summary>
        SubmasterIntensity1_X = 465,

        /// <summary>
        /// Submaster intens. 2
        /// </summary>
        SubmasterIntensity2_X = 466,

        /// <summary>
        /// Submaster intens. 3
        /// </summary>
        SubmasterIntensity3_X = 467,

        /// <summary>
        /// Submaster intens. 4
        /// </summary>
        SubmasterIntensity4_X = 468,

        /// <summary>
        /// Submaster intens. 5
        /// </summary>
        SubmasterIntensity5_X = 469,

        /// <summary>
        /// Submaster intens. 6
        /// </summary>
        SubmasterIntensity6_X = 470,

        /// <summary>
        /// Submaster intens.7
        /// </summary>
        SubmasterIntensity7_X = 471,

        /// <summary>
        /// Submaster intens. 8
        /// </summary>
        SubmasterIntensity8_X = 472,

        /// <summary>
        /// Submaster intens. 9
        /// </summary>
        SubmasterIntensity9_X = 473,

        /// <summary>
        /// Submaster intens. 10
        /// </summary>
        SubmasterIntensity10_X = 474,

        /// <summary>
        /// Submaster intens. 11
        /// </summary>
        SubmasterIntensity11_X = 475,

        /// <summary>
        /// Submaster intens. 12
        /// </summary>
        SubmasterIntensity12_X = 476,

        /// <summary>
        /// Submaster intens. 13
        /// </summary>
        SubmasterIntensity13_X = 477,

        /// <summary>
        /// Submaster intens. 14
        /// </summary>
        SubmasterIntensity14_X = 478,

        /// <summary>
        /// Submaster intens. 15
        /// </summary>
        SubmasterIntensity15_X = 479,

        /// <summary>
        /// Submaster intens. 16
        /// </summary>
        SubmasterIntensity16_X = 480,

        /// <summary>
        /// Submaster intens. 17
        /// </summary>
        SubmasterIntensity17_X = 481,

        /// <summary>
        /// Submaster intens. 18
        /// </summary>
        SubmasterIntensity18_X = 482,

        /// <summary>
        /// Submaster intens. 19
        /// </summary>
        SubmasterIntensity19_X = 483,

        /// <summary>
        /// Submaster intens. 20
        /// </summary>
        SubmasterIntensity20_X = 484,

        /// <summary>
        /// Submaster list change 1
        /// </summary>
        SubmasterListChange1 = 595,

        /// <summary>
        /// Submaster list change 2
        /// </summary>
        SubmasterListChange2 = 596,

        /// <summary>
        /// Submaster list change 3
        /// </summary>
        SubmasterListChange3 = 597,

        /// <summary>
        /// Submaster list change 4
        /// </summary>
        SubmasterListChange4 = 598,

        /// <summary>
        /// Submaster list change 5
        /// </summary>
        SubmasterListChange5 = 599,

        /// <summary>
        /// Submaster list change 6
        /// </summary>
        SubmasterListChange6 = 600,

        /// <summary>
        /// Submaster list change 7
        /// </summary>
        SubmasterListChange7 = 601,

        /// <summary>
        /// Submaster list change 8
        /// </summary>
        SubmasterListChange8 = 602,

        /// <summary>
        /// Submaster list change 9
        /// </summary>
        SubmasterListChange9 = 603,

        /// <summary>
        /// Submaster list change 10
        /// </summary>
        SubmasterListChange10 = 604,

        /// <summary>
        /// Submaster list change 11
        /// </summary>
        SubmasterListChange11 = 605,

        /// <summary>
        /// Submaster list change 12
        /// </summary>
        SubmasterListChange12 = 606,

        /// <summary>
        /// Submaster list change 13
        /// </summary>
        SubmasterListChange13 = 607,

        /// <summary>
        /// Submaster list change 14
        /// </summary>
        SubmasterListChange14 = 608,

        /// <summary>
        /// Submaster list change 15
        /// </summary>
        SubmasterListChange15 = 609,

        /// <summary>
        /// Submaster list change 16
        /// </summary>
        SubmasterListChange16 = 610,

        /// <summary>
        /// Submaster list change 17
        /// </summary>
        SubmasterListChange17 = 611,

        /// <summary>
        /// Submaster list change 18
        /// </summary>
        SubmasterListChange18 = 612,

        /// <summary>
        /// Submaster list change 19
        /// </summary>
        SubmasterListChange19 = 613,

        /// <summary>
        /// Submaster list change 20
        /// </summary>
        SubmasterListChange20 = 614,

        /// <summary>
        /// MIDI to DMX 1
        /// </summary>
        MidiToDmx1 = 208,

        /// <summary>
        /// MIDI to DMX 2
        /// </summary>
        MidiToDmx2 = 209,

        /// <summary>
        /// MIDI to DMX 3
        /// </summary>
        MidiToDmx3 = 210,

        /// <summary>
        /// MIDI to DMX 4
        /// </summary>
        MidiToDmx4 = 211,

        /// <summary>
        /// MIDI to DMX 5
        /// </summary>
        MidiToDmx5 = 212,

        /// <summary>
        /// MIDI to DMX 6
        /// </summary>
        MidiToDmx6 = 213,

        /// <summary>
        /// MIDI to DMX 7
        /// </summary>
        MidiToDmx7 = 214,

        /// <summary>
        /// MIDI to DMX 8
        /// </summary>
        MidiToDmx8 = 215,

        /// <summary>
        /// MIDI to DMX 9
        /// </summary>
        MidiToDmx9 = 216,

        /// <summary>
        /// MIDI to DMX 10
        /// </summary>
        MidiToDmx10 = 217,

        /// <summary>
        /// MIDI to DMX 11
        /// </summary>
        MidiToDmx11 = 218,

        /// <summary>
        /// MIDI to DMX 12
        /// </summary>
        MidiToDmx12 = 219,

        /// <summary>
        /// MIDI to DMX 13
        /// </summary>
        MidiToDmx13 = 220,

        /// <summary>
        /// MIDI to DMX 14
        /// </summary>
        MidiToDmx14 = 221,

        /// <summary>
        /// MIDI to DMX 15
        /// </summary>
        MidiToDmx15 = 222,

        /// <summary>
        /// MIDI to DMX 16
        /// </summary>
        MidiToDmx16 = 223,

        /// <summary>
        /// MIDI to DMX 17
        /// </summary>
        MidiToDmx17 = 224,

        /// <summary>
        /// MIDI to DMX 18
        /// </summary>
        MidiToDmx18 = 225,

        /// <summary>
        /// MIDI to DMX 19
        /// </summary>
        MidiToDmx19 = 226,

        /// <summary>
        /// MIDI to DMX 20
        /// </summary>
        MidiToDmx20 = 227,

        /// <summary>
        /// MIDI to DMX 21
        /// </summary>
        MidiToDmx21 = 228,

        /// <summary>
        /// MIDI to DMX 22
        /// </summary>
        MidiToDmx22 = 229,

        /// <summary>
        /// MIDI to DMX 23
        /// </summary>
        MidiToDmx23 = 230,

        /// <summary>
        /// MIDI to DMX 24
        /// </summary>
        MidiToDmx24 = 231,

        /// <summary>
        /// Cuelist tab 1
        /// </summary>
        CuelistTab1 = 266,

        /// <summary>
        /// Cuelist tab 2
        /// </summary>
        CuelistTab2 = 267,

        /// <summary>
        /// Cuelist tab 3
        /// </summary>
        CuelistTab3 = 268,

        /// <summary>
        /// Cuelist tab 4
        /// </summary>
        CuelistTab4 = 269,

        /// <summary>
        /// Cuelist tab 5
        /// </summary>
        CuelistTab5 = 270,

        /// <summary>
        /// Cuelist tab 6
        /// </summary>
        CuelistTab6 = 271,

        /// <summary>
        /// Previous cuelist tab
        /// </summary>
        PreviousCuelistTab = 300,

        /// <summary>
        /// Next cuelist tab
        /// </summary>
        NextCuelistTab = 301,

        /// <summary>
        /// Toggle Cuelist 1
        /// </summary>
        ToggleCuelist1 = 272,

        /// <summary>
        /// Toggle Cuelist 2
        /// </summary>
        ToggleCuelist2 = 273,

        /// <summary>
        /// Toggle Cuelist 3
        /// </summary>
        ToggleCuelist3 = 274,

        /// <summary>
        /// Toggle Cuelist 4
        /// </summary>
        ToggleCuelist4 = 275,

        /// <summary>
        /// Toggle Cuelist 5
        /// </summary>
        ToggleCuelist5 = 276,

        /// <summary>
        /// Toggle Cuelist 6
        /// </summary>
        ToggleCuelist6 = 277,

        /// <summary>
        /// Toggle Cuelist 7
        /// </summary>
        ToggleCuelist7 = 278,

        /// <summary>
        /// Toggle Cuelist 8
        /// </summary>
        ToggleCuelist8 = 279,

        /// <summary>
        /// Toggle Cuelist 9
        /// </summary>
        ToggleCuelist9 = 280,

        /// <summary>
        /// Toggle Cuelist 10
        /// </summary>
        ToggleCuelist10 = 281,

        /// <summary>
        /// Toggle Cuelist 11
        /// </summary>
        ToggleCuelist11 = 282,

        /// <summary>
        /// Toggle Cuelist 12
        /// </summary>
        ToggleCuelist12 = 203,

        /// <summary>
        /// Toggle Cuelist 13
        /// </summary>
        ToggleCuelist13 = 284,

        /// <summary>
        /// Toggle Cuelist 14
        /// </summary>
        ToggleCuelist14 = 285,

        /// <summary>
        /// Toggle Cuelist 15
        /// </summary>
        ToggleCuelist15 = 286,

        /// <summary>
        /// Toggle Cuelist 16
        /// </summary>
        ToggleCuelist16 = 287,

        /// <summary>
        /// DMX400 Toggle mode
        /// </summary>
        DMX400ToggleMode = 564,

        /// <summary>
        /// DMX400 master
        /// </summary>
        DMX400Master = 306,

        /// <summary>
        /// DMX400 background
        /// </summary>
        DMX400Background = 307,

        /// <summary>
        /// DMX400 Program Select
        /// </summary>
        DMX400ProgramSelect = 308,

        /// <summary>
        /// DMX400 Speed
        /// </summary>
        DMX400Speed = 309,

        /// <summary>
        /// DMX400 Blackout
        /// </summary>
        DMX400Blackout = 310,

        /// <summary>
        /// DMX400 Full On
        /// </summary>
        DMX400FullOn = 311,

        /// <summary>
        /// DMX400 Fade
        /// </summary>
        DMX400Fade = 312,

        /// <summary>
        /// DMX400 FadeTime
        /// </summary>
        DMX400FadeTime = 313,

        /// <summary>
        /// DMX400 Interval
        /// </summary>
        DMX400Interval = 314,

        /// <summary>
        /// DMX400 Auto Change
        /// </summary>
        DMX400AutoChange = 315,

        /// <summary>
        /// DMX400 Color Change
        /// </summary>
        DMX400ColorChange = 316,

        /// <summary>
        /// DMX400 Same Color
        /// </summary>
        DMX400SameColor = 317,

        /// <summary>
        /// DMX400 Vivid Colors
        /// </summary>
        DMX400VividColors = 318,

        /// <summary>
        /// Command 0
        /// </summary>
        Command0 = 319,

        /// <summary>
        /// Command 1
        /// </summary>
        Command1 = 320,

        /// <summary>
        /// Command 2
        /// </summary>
        Command2 = 321,

        /// <summary>
        /// Command 3
        /// </summary>
        Command3 = 322,

        /// <summary>
        /// Command 4
        /// </summary>
        Command4 = 323,

        /// <summary>
        /// Command 5
        /// </summary>
        Command5 = 324,

        /// <summary>
        /// Command 6
        /// </summary>
        Command6 = 325,

        /// <summary>
        /// Command 7
        /// </summary>
        Command7 = 326,

        /// <summary>
        /// Command 8
        /// </summary>
        Command8 = 327,

        /// <summary>
        /// Command 9
        /// </summary>
        Command9 = 328,

        /// <summary>
        /// Command +
        /// </summary>
        CommandPlus = 329,

        /// <summary>
        /// Command -
        /// </summary>
        CommandMinus = 330,

        /// <summary>
        /// Command /
        /// </summary>
        CommandSlash = 331,

        /// <summary>
        /// Command @
        /// </summary>
        CommandAt = 332,

        /// <summary>
        /// Command DMX
        /// </summary>
        CommandDMX = 333,

        /// <summary>
        /// Command SHIFT
        /// </summary>
        CommandShift = 334,

        /// <summary>
        /// Command CLR
        /// </summary>
        CommandClear = 335,

        /// <summary>
        /// Command BS
        /// </summary>
        CommandBackspace = 336,

        /// <summary>
        /// Command ENTER
        /// </summary>
        CommandEnter = 337,

        /// <summary>
        /// Command history up
        /// </summary>
        CommandHistoryUp = 338,

        /// <summary>
        /// Command history down
        /// </summary>
        CommandHistoryDown = 339,

        /// <summary>
        /// Submaster toggle 1
        /// </summary>
        SubmasterToggle1 = 615,

        /// <summary>
        /// Submaster toggle 2
        /// </summary>
        SubmasterToggle2 = 616,

        /// <summary>
        /// Submaster toggle 3
        /// </summary>
        SubmasterToggle3 = 617,

        /// <summary>
        /// Submaster toggle 4
        /// </summary>
        SubmasterToggle4 = 618,

        /// <summary>
        /// Submaster toggle 5
        /// </summary>
        SubmasterToggle5 = 619,

        /// <summary>
        /// Submaster toggle 6
        /// </summary>
        SubmasterToggle6 = 620,

        /// <summary>
        /// Submaster toggle 7
        /// </summary>
        SubmasterToggle7 = 621,

        /// <summary>
        /// Submaster toggle 8
        /// </summary>
        SubmasterToggle8 = 622,

        /// <summary>
        /// Submaster toggle 9
        /// </summary>
        SubmasterToggle9 = 623,

        /// <summary>
        /// Submaster toggle 10
        /// </summary>
        SubmasterToggle10 = 624,

        /// <summary>
        /// Submaster toggle 11
        /// </summary>
        SubmasterToggle11 = 625,

        /// <summary>
        /// Submaster toggle 12
        /// </summary>
        SubmasterToggle12 = 626,

        /// <summary>
        /// Submaster toggle 13
        /// </summary>
        SubmasterToggle13 = 627,

        /// <summary>
        /// Submaster toggle 14
        /// </summary>
        SubmasterToggle14 = 628,

        /// <summary>
        /// Submaster toggle 15
        /// </summary>
        SubmasterToggle15 = 629,

        /// <summary>
        /// Submaster toggle 16
        /// </summary>
        SubmasterToggle16 = 630,

        /// <summary>
        /// Submaster toggle 17
        /// </summary>
        SubmasterToggle17 = 631,

        /// <summary>
        /// Submaster toggle 18
        /// </summary>
        SubmasterToggle18 = 632,

        /// <summary>
        /// Submaster toggle 19
        /// </summary>
        SubmasterToggle19 = 633,

        /// <summary>
        /// Submaster toggle 20
        /// </summary>
        SubmasterToggle20 = 634,

        /// <summary>
        /// Previous MIDI page
        /// </summary>
        PreviousMidiPage = 635,

        /// <summary>
        /// Next MIDI page
        /// </summary>
        NextMidiPage = 636,

        /// <summary>
        /// Release override gobo1
        /// </summary>
        ReleaseOverrideGobo1 = 637,

        /// <summary>
        /// Release override gobo2
        /// </summary>
        ReleaseOverrideGobo2 = 638,

        /// <summary>
        /// Release override gobo3
        /// </summary>
        ReleaseOverrideGobo3 = 639,

        /// <summary>
        /// Release override color1
        /// </summary>
        ReleaseOverrideColor1 = 640,

        /// <summary>
        /// Release override color2
        /// </summary>
        ReleaseOverrideColor2 = 641,

        /// <summary>
        /// Release override gobo1 rot.
        /// </summary>
        ReleaseOverrideGobo1Rotation = 642,

        /// <summary>
        /// Release override gobo2 rot.
        /// </summary>
        ReleaseOverrideGobo2Rotation = 643,

        /// <summary>
        /// Release override red
        /// </summary>
        ReleaseOverrideRed = 644,

        /// <summary>
        /// Release override green
        /// </summary>
        ReleaseOverrideGreen = 645,

        /// <summary>
        /// Release override blue
        /// </summary>
        ReleaseOverrideBlue = 646,

        /// <summary>
        /// Release override amber
        /// </summary>
        ReleaseOverrideAmber = 647,

        /// <summary>
        /// Release override white1
        /// </summary>
        ReleaseOverrideWhite1 = 648,

        /// <summary>
        /// Release override white2
        /// </summary>
        ReleaseOverrideWhite2 = 649,

        /// <summary>
        /// Release override pan
        /// </summary>
        ReleaseOverridePan = 650,

        /// <summary>
        /// Release override tilt
        /// </summary>
        ReleaseOverrideTilt = 651,

        /// <summary>
        /// Release override shutter
        /// </summary>
        ReleaseOverrideShutter = 652,

        /// <summary>
        /// Release override strobe
        /// </summary>
        ReleaseOverrideStrobe = 653,

        /// <summary>
        /// Release override intensity
        /// </summary>
        ReleaseOverrideIntensity = 654,

        /// <summary>
        /// Release override iris
        /// </summary>
        ReleaseOverrideIris = 655,

        /// <summary>
        /// Release override focus
        /// </summary>
        ReleaseOverrideFocus = 656,

        /// <summary>
        /// Release override zoom
        /// </summary>
        ReleaseOverrideZoom = 657,

        /// <summary>
        /// Release override prism
        /// </summary>
        ReleaseOverridePrism = 658,

        /// <summary>
        /// Release override prism rot.
        /// </summary>
        ReleaseOverridePrismRotation = 659,

        /// <summary>
        /// Release override frost
        /// </summary>
        ReleaseOverrideFrost1 = 660,

        /// <summary>
        /// Release override frost2
        /// </summary>
        ReleaseOverrideFrost2 = 661,

        /// <summary>
        /// Cuelistbutton
        /// </summary>
        CuelistButton = 662,

        /// <summary>
        /// Remove from playback
        /// </summary>
        RemoveFromPlayback = 663,

        /// <summary>
        /// Pause sound2light
        /// </summary>
        PauseSoundToLight = 664,

        /// <summary>
        /// Disable fixture
        /// </summary>
        DisableFixture = 665,

        /// <summary>
        /// Master spd +5%
        /// </summary>
        MasterSpeedIncrease5Percent = 666,

        /// <summary>
        /// Master spd 100%
        /// </summary>
        MasterSpeedHundredPercent = 667,

        /// <summary>
        /// Master spd -5%
        /// </summary>
        MasterSpeedDecrease5Percent = 668,

        /// <summary>
        /// One group only
        /// </summary>
        OneGroupOnly = 669,

        /// <summary>
        /// Open cuelist
        /// </summary>
        OpenCuelist = 670,

        /// <summary>
        /// Toggle Cuelist 17
        /// </summary>
        ToggleCuelist17 = 671,

        /// <summary>
        /// Toggle Cuelist 18
        /// </summary>
        ToggleCuelist18 = 672,

        /// <summary>
        /// Toggle Cuelist 19
        /// </summary>
        ToggleCuelist19 = 673,

        /// <summary>
        /// Toggle Cuelist 20
        /// </summary>
        ToggleCuelist20 = 674,

        /// <summary>
        /// Toggle Cuelist 21
        /// </summary>
        ToggleCuelist21 = 675,

        /// <summary>
        /// Toggle Cuelist 22
        /// </summary>
        ToggleCuelist22 = 676,

        /// <summary>
        /// Toggle Cuelist 23
        /// </summary>
        ToggleCuelist23 = 677,

        /// <summary>
        /// Toggle Cuelist 24
        /// </summary>
        ToggleCuelist24 = 678,

        /// <summary>
        /// Toggle Cuelist 25
        /// </summary>
        ToggleCuelist25 = 679,

        /// <summary>
        /// Toggle Cuelist 26
        /// </summary>
        ToggleCuelist26 = 680,

        /// <summary>
        /// Toggle Cuelist 27
        /// </summary>
        ToggleCuelist27 = 681,

        /// <summary>
        /// Toggle Cuelist 28
        /// </summary>
        ToggleCuelist28 = 682,

        /// <summary>
        /// Toggle Cuelist 29
        /// </summary>
        ToggleCuelist29 = 683,

        /// <summary>
        /// Toggle Cuelist 30
        /// </summary>
        ToggleCuelist30 = 684,

        /// <summary>
        /// Toggle Cuelist 31
        /// </summary>
        ToggleCuelist31 = 685,

        /// <summary>
        /// Toggle Cuelist 32
        /// </summary>
        ToggleCuelist32 = 686
    };

    /// <summary>
    /// Mouse Actions
    /// </summary>
    public enum FreeStylerMouse : byte
    {
        /// <summary>
        /// Mouse Click (Mouse Down)
        /// </summary>
        Click = 0xFF,

        /// <summary>
        /// Mouse Release (Mouse Up)
        /// </summary>
        Release = 0x00
    };

    /// <summary>
    /// Request button captions and other data
    /// </summary>
    public enum FreeStylerRequest : uint
    {
        /// <summary>
        /// Cue captions
        /// </summary>
        CueCaptions = 001,

        /// <summary>
        /// Override button captions
        /// </summary>
        OverrideButtonCaptions = 002,

        /// <summary>
        /// Cuelist captions of current page
        /// </summary>
        CuelistCaptionsPage = 003,

        /// <summary>
        /// All cuelist captions
        /// </summary>
        CuelistCaptionsAll = 004,

        /// <summary>
        /// Cue status
        /// </summary>
        CueStatus = 005,

        /// <summary>
        /// Override buttons flash/latch setting
        /// </summary>
        OverrideButtonFlashLatch = 006,

        /// <summary>
        /// Override buttons status
        /// </summary>
        OverrideButtonStatus = 007,

        /// <summary>
        /// Group names
        /// </summary>
        GroupNames = 008,

        /// <summary>
        /// Group status
        /// </summary>
        GroupStatus = 009,

        /// <summary>
        /// FreeStyler version
        /// </summary>
        FreeStylerVersion = 010,

        /// <summary>
        /// Submaster names
        /// </summary>
        SubmasterNames = 011,

        /// <summary>
        /// Submaster status
        /// </summary>
        SubmasterStatus = 012,

        /// <summary>
        /// Submaster intensity
        /// </summary>
        SubmasterIntensity = 013,

        /// <summary>
        /// Blackout, Freeze, Favorite status
        /// </summary>
        BlackoutFreezeFavoriteStatus = 014,

        /// <summary>
        /// Current selected cue in submasters
        /// </summary>
        CurrentSelectedCueInSubmasters = 015,

        /// <summary>
        /// Cuelist status
        /// </summary>
        CuelistStatus = 016,

        /// <summary>
        /// Fixture names
        /// </summary>
        FixtureNames = 017,

        /// <summary>
        /// Fixture address
        /// </summary>
        FixtureAddresses = 018,

        /// <summary>
        /// Cue speed
        /// </summary>
        CueSpeed = 019,

        /// <summary>
        /// Master cue speed
        /// </summary>
        MasterCueSpeed = 020,

        /// <summary>
        /// Master intensity
        /// </summary>
        MasterIntensity = 021,

        /// <summary>
        /// Fog and Fan levels
        /// </summary>
        FogAndFanLevels = 022,

        /// <summary>
        /// Fixture status selected/unselected
        /// </summary>
        FixtureSelectionStatuses = 023
    }
}
