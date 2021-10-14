using System;

namespace Lab2
{
    public class Weather
    {
        private int _dy;
        private int _mxT;
        private int _mnT;
        private int _avT;
        private int _hDDay;
        private double _avDp;
        private double _tPcpn;
        private char[] _wxType;
        private int _pDir;
        private double _avSp;
        private int _dir;
        private int _mxS;
        private double _skyC;
        private int _mxR;
        private int _mnR;
        private double _avSlp;

        public Weather(int dy, int mxT, int mnT, int avT, int hDDay, double avDp, double tPcpn, char[] wxType, int pDir, double avSp, int dir, int mxS, double skyC, int mxR, int mnR, double avSlp)
        {
            _dy = dy;
            _mxT = mxT;
            _mnT = mnT;
            _avT = avT;
            _hDDay = hDDay;
            _avDp = avDp;
            _tPcpn = tPcpn;
            _wxType = wxType;
            _pDir = pDir;
            _avSp = avSp;
            _dir = dir;
            _mxS = mxS;
            _skyC = skyC;
            _mxR = mxR;
            _mnR = mnR;
            _avSlp = avSlp;
        }
        
        

        public int Dy
        {
            get => _dy;
            set => _dy = value;
        }

        public int MxT
        {
            get => _mxT;
            set => _mxT = value;
        }

        public int MnT
        {
            get => _mnT;
            set => _mnT = value;
        }

        public int AvT
        {
            get => _avT;
            set => _avT = value;
        }

        public int HDDay
        {
            get => _hDDay;
            set => _hDDay = value;
        }

        public double AvDp
        {
            get => _avDp;
            set => _avDp = value;
        }

        public double TPcpn
        {
            get => _tPcpn;
            set => _tPcpn = value;
        }

        public char[] WxType
        {
            get => _wxType;
            set => _wxType = value;
        }

        public int PDir
        {
            get => _pDir;
            set => _pDir = value;
        }

        public double AvSp
        {
            get => _avSp;
            set => _avSp = value;
        }

        public int Dir
        {
            get => _dir;
            set => _dir = value;
        }

        public int MxS
        {
            get => _mxS;
            set => _mxS = value;
        }

        public double SkyC
        {
            get => _skyC;
            set => _skyC = value;
        }

        public int MxR
        {
            get => _mxR;
            set => _mxR = value;
        }

        public int MnR
        {
            get => _mnR;
            set => _mnR = value;
        }

        public double AvSlp
        {
            get => _avSlp;
            set => _avSlp = value;
        }
        
        
    }
}