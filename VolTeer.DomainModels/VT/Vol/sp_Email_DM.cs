﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolTeer.DomainModels.VT.Vol
{
    using System;
    using System.Collections.Generic;

    public class sp_Email_DM
    {

        public int EmailID { get; set; }
        public string EmailAddr { get; set; }
        public Nullable<bool> ActiveFlg { get; set; }

        public virtual sp_Volunteer_DM sp_Volunteer_DM { get; set; }
    }
}
