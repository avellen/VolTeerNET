﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolTeer.DomainModels.VT.Vol
{
    public class sp_GroupAddr_DM
    {
        public int GroupID { get; set; }
        public int AddrID { get; set; }
        public Nullable<bool> ActiveFlg { get; set; }
        public bool PrimaryAddrID { get; set; }
    }
}
