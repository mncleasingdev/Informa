﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXMNCGUI_INFORMA.Controllers.Registry
{
    public class InternalMemoDeviasiDtlKey : BaseRegistryID
    {
        protected override void Init()
        {
            this.myID = 10080;
            this.myDefaultValue = (object)1;
        }
    }
}