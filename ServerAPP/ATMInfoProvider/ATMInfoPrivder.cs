using System;

namespace ATM.Cacher
{
    [Serializable]
    public class ATMInfoProvider
    {
        private string _cim;
        private string _cdm;
        private string _idc;
        private string _ptr;
        private string _siu;

        public string CIM
        {
            get { return _cim; }
            set { _cim = value; }
        }

        public string CDM
        {
            get { return _cdm; }
            set { _cdm = value; }
        }
        public string IDC
        {
            get { return _idc; }
            set { _idc = value; }
        }
        public string PTR
        {
            get { return _ptr; }
            set { _ptr = value; }
        }
        public string SIU
        {
            get { return _siu; }
            set { _siu = value; }
        }
        public ATMInfoProvider() {
            string status = "Connecting...";
            CIM = status;
            CDM = status;
            IDC = status;
            PTR = status;
            SIU = status;
        }
    }
}
