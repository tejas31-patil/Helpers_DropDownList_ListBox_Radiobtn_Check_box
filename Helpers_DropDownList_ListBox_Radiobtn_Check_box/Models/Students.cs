using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers_DropDownList_ListBox_Radiobtn_Check_box.Models
{
    
    public class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        
    }
    public class Students:Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}