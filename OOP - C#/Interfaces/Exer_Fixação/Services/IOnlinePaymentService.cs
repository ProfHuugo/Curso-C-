namespace Course.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFree(double amount);

        public double Interest(double amount, int month);
    }
}