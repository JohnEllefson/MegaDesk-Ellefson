using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ellefson
{   
    public class DeskQuote
    {
        // Constants
        const int DESK_BASE_COST = 200;
        const int DESK_DRAWER_COST = 50;

        Desk desk;
        string customerName;
        DateTime date;
        ProductionTime productionTime;
        float quoteCost;


        // Constructor
        public DeskQuote(Desk desk, string customerName, DateTime date, ProductionTime productionTime) 
        {
            this.desk = desk;
            this.customerName = customerName;
            this.date = date;
            this.productionTime = productionTime;
            quoteCost = calcTotalCost();
        }


        // Getters/Setters
        public Desk getDesk() { return desk; }
        public string getCustomerName() { return customerName; }
        public DateTime getQuoteDate() { return date; }
        public ProductionTime getProductionTime() { return productionTime; }
        public float getQuoteCost() { return quoteCost; }
        public void setCustomerName(string name) { customerName = name; }
        public void setQuoteDate(DateTime date) { this.date = date; }
        public void setProductionTime(ProductionTime prodTime) { productionTime = prodTime; }
        public void setQuoteCost(float cost) { this.quoteCost = cost;}


        // Calculate the total cost for the quote
        public float calcTotalCost()
        {
            return (DESK_BASE_COST + calcSurfaceAreaCost() + calcDrawersCost() +
                    calcMaterialCost() + calcProductionTimeCost());
        }


        // Worker Methods
        float calcSurfaceAreaCost()
        {
            int cost = 0;
            int surfaceArea = desk.getWidth() * desk.getDepth();

            // Charge $1 per square inch past 1000
            if (surfaceArea > 1000)
                cost = surfaceArea - 1000;

            return cost;
        }

        float calcDrawersCost()
        {
            return (desk.getDrawersNum() * DESK_DRAWER_COST);
        }

        float calcMaterialCost()
        {
            int cost = 0;

            switch (desk.getMaterial())
            {
                case DesktopMaterial.Oak:
                    cost = 200;
                    break;

                case DesktopMaterial.Laminate:
                    cost = 100;
                    break;

                case DesktopMaterial.Pine:
                    cost = 50;
                    break;

                case DesktopMaterial.Rosewood:
                    cost = 300;
                    break;

                case DesktopMaterial.Veneer:
                    cost = 125;
                    break;

            }

            return cost;
        }

        float calcProductionTimeCost()
        {
            int cost = 0;
            int surfaceArea = desk.getWidth() * desk.getDepth();
            string deskSize;

            // Categorize the desk as Small, Medium, or Large
            if (surfaceArea < 1000) { deskSize = "Small"; }
            else if (surfaceArea >= 1000 && surfaceArea <= 2000) { deskSize = "Medium"; }
            else { deskSize = "Large"; }

            // Determine the additional cost based on the rush option and the size of desk
            switch (productionTime)
            {
                case ProductionTime.ThreeDays:
                    if (deskSize == "Small") { cost = 60; }
                    else if (deskSize == "Medium") { cost = 70; }
                    else { cost = 80; }
                    break;

                case ProductionTime.FiveDays:
                    if (deskSize == "Small") { cost = 40; }
                    else if (deskSize == "Medium") { cost = 50; }
                    else { cost = 60; }
                    break;

                case ProductionTime.SevenDays:
                    if (deskSize == "Small") { cost = 30; }
                    else if (deskSize == "Medium") { cost = 35; }
                    else { cost = 40; }
                    break;
            }

            return cost;
        }
    }


    public enum ProductionTime
    {
        ThreeDays,
        FiveDays,
        SevenDays,
        FourteenDays
    }
}
