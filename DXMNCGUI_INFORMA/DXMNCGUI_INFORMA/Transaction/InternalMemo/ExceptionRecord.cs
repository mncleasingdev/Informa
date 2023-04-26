using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class ExceptionRecord
    {
        private DataRow myRow;
        private InternalMemoEntity myInternalMemo;

        public DataRow Row
        {
            get
            {
                return this.myRow;
            }
        }
        public int DtlKey
        {
            get
            {
                return Convert.ToInt32(this.myRow["DtlKey"]);
            }
        }
        public int DocKey
        {
            get
            {
                return Convert.ToInt32(this.myRow["DocKey"]);
            }
        }
        public int Seq
        {
            get
            {
                return Convert.ToInt32(this.myRow["Seq"]);
            }
        }
        public string Perihal
        {
            get
            {
                return Convert.ToString(this.myRow["Perihal"]);
            }
            set
            {
                this.myRow["Perihal"] = (object)(value);
            }
        }
        public string Alasan
        {
            get
            {
                return Convert.ToString(this.myRow["Alasan"]);
            }
            set
            {
                this.myRow["Alasan"] = (object)(value);
            }
        }
        public string MitigasiResiko
        {
            get
            {
                return Convert.ToString(this.myRow["MitigasiResiko"]);
            }
            set
            {
                this.myRow["MitigasiResiko"] = (object)(value);
            }
        }

        internal ExceptionRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }
    }
}