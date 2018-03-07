namespace Chapter10.PaymentApplication
{
    interface ICreditCardValidator
    {
        bool ValidateNumber(string text);
    }
}
