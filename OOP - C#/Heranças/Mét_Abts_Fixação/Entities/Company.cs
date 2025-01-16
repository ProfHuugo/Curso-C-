namespace Course.Entities
{
    class Company : People
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmloyees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmloyees;
        }

        public override double PayTax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}