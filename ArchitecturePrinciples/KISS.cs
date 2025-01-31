namespace EjercicioKiss
{
    //Keep
    //it
    //simple
    //stupid
    public class RestaurantBill
    {
        public decimal CalculateTotal(decimal[] prices, decimal? tipPorcentaje = 10)
        {
            if(prices==null || prices.Length==0) return 0;

            decimal totalPrices = prices.Sum();

            decimal tip = totalPrices * (tipPorcentaje.GetValueOrDefault()/100);

            return totalPrices + tip;

        }

    }
}