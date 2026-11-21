using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class BillingController_FinancialLogic : BillingController
    {
        public static decimal ComputeSubtotal(decimal roomCharges, decimal serviceAddOns, decimal others)
        {

            return roomCharges + serviceAddOns + others;
        }

        public static decimal ComputeTotalDue(decimal subtotal)
        {

            return subtotal;
        }


        public static decimal ComputeChangeDue(decimal amountPaid, decimal totalDue)
        {

            return amountPaid - totalDue;
        }


        public bool ValidateAndComputePayment(
            decimal roomCharges,
            decimal serviceAddOns,
            decimal others,
            decimal amountPaid,
            out decimal subtotal,
            out decimal totalDue,
            out decimal changeDue,
            out string message)
        {
            subtotal = ComputeSubtotal(roomCharges, serviceAddOns, others);
            totalDue = ComputeTotalDue(subtotal);
            changeDue = 0m;
            message = string.Empty;


            if (amountPaid < totalDue)
            {
                message = "Amount paid is insufficient to cover total due.";
                return false;
            }


            changeDue = ComputeChangeDue(amountPaid, totalDue);
            return true;
        }

    }
}

