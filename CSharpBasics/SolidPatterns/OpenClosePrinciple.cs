using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns
{
    public class Invoice
    {
        // Bad architecture
        //public double GetInvoiceDiscont(double amount, InvoiceType invoiceType)
        //{
        //    double finalAmount = 0;

        //    if (invoiceType == InvoiceType.FinalInvoice)
        //    {
        //        finalAmount = amount - 100;
        //    }
        //    else if (invoiceType == InvoiceType.ProposedInvoice)
        //    {
        //        finalAmount = amount - 50;
        //    }

        //    return finalAmount;
        //}

        public virtual double GetInvoiceDiscont(double amount)
        {
            return amount - 10;
        }
    }

    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscont(double amount)
        {
            return amount - 100;
        }
    }

    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscont(double amount)
        {
            return amount - 50;
        }
    }

    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    }
}
