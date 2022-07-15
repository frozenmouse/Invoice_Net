﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EinvoiceIntegration.Models.B2C
{
    public class AllowanceResult : BaseResult
    {
        public string IA_Allow_No { get; set; }
        public string IA_Invoice_No { get; set; }
        public string IA_Date { get; set; }
        public int IA_Remain_Allowance_Amt { get; set; }
    }
}
