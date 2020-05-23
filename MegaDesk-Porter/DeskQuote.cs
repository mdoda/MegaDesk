using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Porter
{

    public enum Delivery
    {
        Rush3Days,
        Rush5Days,
        Rush7Days,
        NoRush14Days
    }
    public class DeskQuote
    {
        private int[,] _rushOrderPrices;

        //200 is the starting amount for a desk
        private const decimal BASE_PRICE = 200.00M;

        //Basic Costs
        private const decimal SURFACE_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;

        // Material Costs
        private const decimal OAK_COST = 200.00M;
        private const decimal LAMINATE_COST = 100.00M;
        private const decimal PINE_COST = 50.00M;
        private const decimal ROSEWOOD_COST = 300.00M;
        private const decimal VENEER_COST = 125.00M;

        public DateTime QuoteDate { get; set; }

        public String CustomerName { get; set; }

        public Desk Desk { get; set; }

        public Delivery Shipping { get; set; }

        public decimal Total { get; set; }

        public decimal GetQuote()
        {
            var surfaceArea = this.Desk.Depth * this.Desk.Depth;
            decimal quotePrice = BASE_PRICE;
            var shippingPrice = 0;
            decimal surfacePrice = 0;

            if (surfaceArea > 1000)
            {
                surfacePrice = surfaceArea * SURFACE_AREA_COST;
            }

            decimal drawerPrice = this.Desk.Drawers * DRAWER_COST;

            decimal surfaceMaterialPrice = 0;

            switch (this.Desk.DesktopMaterial)
            {
                case DesktopMaterial.Laminate:
                    surfaceMaterialPrice = LAMINATE_COST;
                    break;
                case DesktopMaterial.Oak:
                    surfaceMaterialPrice = OAK_COST;
                    break;
                case DesktopMaterial.Pine:
                    surfaceMaterialPrice = PINE_COST;
                    break;
                case DesktopMaterial.Rosewood:
                    surfaceMaterialPrice = ROSEWOOD_COST;
                    break;
                case DesktopMaterial.Veneer:
                    surfaceMaterialPrice = VENEER_COST;
                    break;

            }
            getRushOrderPrices();

            switch (this.Shipping)
            {
                case Delivery.Rush3Days:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = _rushOrderPrices[0, 0];
                    }
                    else if (surfaceArea <= 1000)
                    {
                        shippingPrice = _rushOrderPrices[0, 1];
                    }
                    else
                    {
                        shippingPrice = _rushOrderPrices[0, 2];
                    }
                    break;

                case Delivery.Rush5Days:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = _rushOrderPrices[1, 0];
                    }
                    else if (surfaceArea <= 2000)
                    {
                        shippingPrice = _rushOrderPrices[1, 1];
                    }
                    else
                    {
                        shippingPrice = _rushOrderPrices[1, 2];
                    }
                    break;

                case Delivery.Rush7Days:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = _rushOrderPrices[2, 0];
                    }
                    else if (surfaceArea <= 2000)
                    {
                        shippingPrice = _rushOrderPrices[2, 1];
                    }
                    else
                    {
                        shippingPrice = _rushOrderPrices[2, 2];
                    }
                    break;

                    

                    
            }
            quotePrice = quotePrice + surfacePrice + drawerPrice + surfaceMaterialPrice + shippingPrice;

            return quotePrice;
        }
        private void getRushOrderPrices()
        {
            _rushOrderPrices = new int[3, 3];
            var pricesFile = @"_rushOrderPrices.txt";

            string[] prices = File.ReadAllLines(pricesFile);
            int i = 0, j = 0;

            foreach (string price in prices)
            {
                _rushOrderPrices[i, j] = int.Parse(price);

                if (j == 2)
                {
                    i++;
                    j = 0;
                }
                else
                {
                    j++;
                }
            }
        }
    }
}
