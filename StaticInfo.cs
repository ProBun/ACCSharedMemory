using System;
using System.Runtime.InteropServices;

namespace AssettoCorsaSharedMemory
{
    public class StaticInfoEventArgs : EventArgs
    {
        public StaticInfoEventArgs (StaticInfo staticInfo)
        {
            this.StaticInfo = staticInfo;
        }

        public StaticInfo StaticInfo { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct StaticInfo
    {
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String SMVersion;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String ACVersion;

        public int NumberOfSessions;
        public int NumCars;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String CarModel;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String Track;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerName;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerSurname;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerNick;

        public int SectorCount;

        public float MaxTorque; //Not used in ACC
        public float MaxPower; //Not used in ACC

        public int MaxRpm;
        public float MaxFuel;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SuspensionMaxTravel; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreRadius; //Not used in ACC

        public float MaxTurboBoost;
        public float Deprecated1; //Not used in ACC
        public float Deprecated2; //Not used in ACC
        
        public int PenaltiesEnabled;
        public float AidFuelRate;
        public float AidTireRate;
        public float AidMechanicalDamage;
        public int AidAllowTyreBlankets;
        public float AidStability;
        public int AidAutoClutch;
        public int AidAutoBlip;
        
        public int HasDRS; //Not used in ACC
        public int HasERS; //Not used in ACC
        public int HasKERS; //Not used in ACC
        public float KersMaxJoules; //Not used in ACC
        public int EngineBrakeSettingsCount; //Not used in ACC
        public int ErsPowerControllerCount; //Not used in ACC
        public float TrackSPlineLength; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public string TrackConfiguration; //Not used in ACC
        public float ErsMaxJ; //Not used in ACC
        public int IsTimedRace; //Not used in ACC
        public int HasExtraLap; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String CarSkin; //Not used in ACC
        public int ReversedGridPositions; //Not used in ACC

        public int PitWindowStart;
        public int PitWindowEnd;
        public int IsOnline;
    }
}