using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeater_gui
{
    public class RecordInfo
    {
        private string _result;
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string availableA { get; set; }
        public string balanceA { get; set; }
        public string availableB { get; set; }
        public string balanceB { get; set; }

        public RecordInfo(string result, string availableA, string balanceA, string availableB, string balanceB)
        {
            this._result = result;
            this.availableA = availableA;
            this.balanceA = balanceA;
            this.availableB = availableB;
            this.balanceB = balanceB;
        }
    }
}
