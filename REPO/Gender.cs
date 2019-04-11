using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO
{
    public class Gender : ClassNotify
    {
        private int genderId;
        private string genderName;

        public Gender()
        {
            
        }
        
        public int GenderId
        {
            get { return genderId; }
            set
            {
                if (value != genderId)
                {
                    genderId = value;
                    Notify("GenderId");
                }
            }
        }

        public string GenderName
        {
            get { return genderName; }
            set
            {
                if (value != genderName)
                {
                    genderName = value;
                    Notify("GenderName");
                }
            }
        }
    }
}
