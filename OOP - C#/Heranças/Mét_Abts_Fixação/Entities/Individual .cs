namespace Course.Entities
{
    class Individual : People
    {
        public double HealthExpenditures { get; set; }
        
        public Individual(string name, double annualIncome, double healthExpenditures) : base (name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double PayTax()
        {
            if ( AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.2 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}