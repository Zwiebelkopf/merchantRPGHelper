using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant_RPG {
    public class Skill {

        public bool IsActive;
        public string Name;
        public int Duration;

        public double RaisePatk;
        public double RaiseMatk;
        public double RaisePdef;
        public double RaiseMdef;
        public double RaiseHP;

        public double DealPatk;
        public double DealMatk;

        public Skill(string name, bool isactive, double raisepatk = 0, double raisematk = 0, double raisepdef = 0, double raisemdef = 0, double raisehp = 0, 
            double dealpatk = 0, double dealmatk = 0) {
            Name = name;
            IsActive = isactive;
        }
    }
}
