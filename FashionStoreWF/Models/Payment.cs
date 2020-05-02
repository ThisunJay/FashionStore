using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStoreWF.Models
{
    public class Payment
    {
		public int p_id { get; set; }
		public string p_invoiceNum { get; set; }
		public float p_amount { get; set; }
		public string p_paidBy { get; set; }
		public string p_paidTo { get; set; }
		public string p_bank { get; set; }
	}
}
