using System;
using System.Runtime.InteropServices;

namespace AssettoCorsaSharedMemory
{
    public class PhysicsEventArgs : EventArgs
    {
        public PhysicsEventArgs (Physics physics)
        {
            this.Physics = physics;
        }

        public Physics Physics { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct Coordinates
    {
        public float X;
        public float Y;
        public float Z;
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Physics
    {
        public int PacketId;
        public float Gas;
        public float Brake;
        public float Fuel;
        public int Gear;
        public int Rpms;
        public float SteerAngle;
        public float SpeedKmh;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] Velocity;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] AccG;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelSlip;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelLoad;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelsPressure;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelAngularSpeed;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreWear; //Nout used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreDirtyLevel; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreCoreTemperature;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] CamberRAD; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SuspensionTravel;

        public float DRS; //Not used in ACC
        public float TC;
        public float Heading;
        public float Pitch;
        public float Roll;
        public float CGHeight; //Not used in ACC

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 5)]
        public float[] CarDamage;

        public int NumberOfTyresOut; //Not used in ACC

        public int PitLimiterOn;
        public float Abs;

        public float KersCharge; //Not used in ACC
        public float KersInput; //Not used in ACC
        
        public int AutoShifterOn;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] RideHeight; //Not used in ACC
        
        public float TurboBoost;

        public float Ballast; //Not used in ACC
        public float AirDensity; //Not used in ACC

        public float AirTemp;
        public float RoadTemp;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] LocalAngularVelocity;
        public float FinalFF;

        public float PerformanceMeter; //Not used in ACC
        public float EngineBrake; //Not used in ACC
        public float ErsRecoveryLevel; //Not used in ACC
        public float ErsPowerLeve; //Not used in ACC
        public float ErsHeatCharging; //Not used in ACC
        public float ErsIsCharging; //Not used in ACC
        public float KersCurrentKJ; //Not used in ACC
        public float DrsAvailable; //Not used in ACC
        public float DrsEnabled; //Not used in ACC

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] BrakeTemp;

        public float Clutch;
        
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempI;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempM;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempO;

        public int IsAIControlled;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactPoint;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactNormal;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactHeading;
        public float BrakeBias;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] LocalVelocity;

        public int P2PActivation; //Not used in ACC
        public int P2PStatus; //Not used in ACC
        public float CurrentMaxRPM; //Not used in ACC
        
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] MZ; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] FZ; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] FY; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SlipRatio; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SlipAngle; //Not used in ACC

        public int TCInAction; //Not used in ACC
        public int ABSInAction; //Not used in ACC

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SuspensionDamage; //Not used in ACC
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTemp; //Not used in ACC
        
        public float WaterTemp;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] brakePressure;

        public int frontBrakeCompound;
        public int rearBrakeCompound;
        
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] padLife;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] discLife;
    }
}