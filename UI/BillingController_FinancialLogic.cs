// ============================================================
// ISSUE #35 – BILLING / PAYMENT (Backend)
// Replace / extend the calculation helpers in BillingController.cs
// ============================================================

// 1. Financial Calculation Formulas (NO TAX as required by the issue)
public static decimal ComputeSubtotal(decimal roomCharges, decimal serviceAddOns, decimal others)
{
    // Subtotal = Room Charges + Service Add-ons + Others
    return roomCharges + serviceAddOns + others;
}

public static decimal ComputeTotalDue(decimal subtotal)
{
    // Total Due = Subtotal   (explicitly without tax)
    return subtotal;
}

// 2. Payment Validation & Change Computation
public static decimal ComputeChangeDue(decimal amountPaid, decimal totalDue)
{
    // Change Due = Amount Paid - Total Due
    return amountPaid - totalDue;
}

/// <summary>
/// Full validation + calculation helper used by the Process Payment button.
/// Returns false (and sets message) when payment is insufficient.
/// </summary>
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

    // Underpayment Rule
    if (amountPaid < totalDue)
    {
        message = "Amount paid is insufficient to cover total due.";
        return false;
    }

    // Valid payment
    changeDue = ComputeChangeDue(amountPaid, totalDue);
    return true;
}

// 3. Completion helper – call this after a successful payment is recorded
//    (the actual DB update of stay status / folio balance is done inside the
//     stored procedure; this method just documents the required side-effects)
/*
    Once valid payment is recorded (Amount Paid >= Total Due):
      • update the stay status to "Paid"
      • set the remaining folio balance to 0.00
      • trigger receipt generation
*/
