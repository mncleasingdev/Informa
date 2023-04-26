using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Transaction.InternalMemo
{
    public class DeviasiRecord
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
        public string Action
        {
            get
            {
                return Convert.ToString(this.myRow["Action"]);
            }
            set
            {
                this.myRow["Action"] = (object)(value);
            }
        }
        public DateTime Deadline
        {
            get
            {
                return Convert.ToDateTime(this.myRow["Deadline"]);
            }
            set
            {
                this.myRow["Deadline"] = Convert.ToDateTime(value);
            }
        }
        public string Status
        {
            get
            {
                return Convert.ToString(this.myRow["Status"]);
            }
            set
            {
                this.myRow["Status"] = (object)(value);
            }
        }
        public string UpdateBy
        {
            get
            {
                return Convert.ToString(this.myRow["UpdateBy"]);
            }
            set
            {
                this.myRow["UpdateBy"] = (object)(value);
            }
        }
        public DateTime UpdateDate
        {
            get
            {
                return Convert.ToDateTime(this.myRow["UpdateDate"]);
            }
            set
            {
                this.myRow["UpdateDate"] = Convert.ToDateTime(value);
            }
        }

        internal DeviasiRecord(DataRow row, InternalMemoEntity InternalMemoEntity)
        {
            this.myRow = row;
            this.myInternalMemo = InternalMemoEntity;
        }
    }
}