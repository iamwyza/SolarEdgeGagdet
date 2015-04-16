using System.Collections.Generic;

namespace SolarEdgeGadget
{
    public class SumData
    {
        public string siteName { get; set; }
        public string siteInstallationDate { get; set; }
        public string sitePeakPower { get; set; }
        public string siteAddress { get; set; }
        public string siteCountry { get; set; }
        public string siteState { get; set; }
        public string siteUpdateDate { get; set; }
        public string maxSeverity { get; set; }
        public string status { get; set; }
    }

    public class InstData
    {
        public string installerImage { get; set; }
        public string installerImagePath { get; set; }
        public string installerImageHash { get; set; }
        public bool useDefault { get; set; }
    }

    public class ImgData
    {
        public string fieldId { get; set; }
        public string image { get; set; }
        public string imagePath { get; set; }
        public string imageHash { get; set; }
    }

    public class OverviewData
    {
        public string lastDayEnergy { get; set; }
        public string lastMonthEnergy { get; set; }
        public string currentPower { get; set; }
        public string lifeTimeEnergy { get; set; }
        public string currencyCode { get; set; }
        public string revenue { get; set; }
        public string formatedRevenue { get; set; }
    }

    public class SavingData
    {
        public string CO2EmissionSaved { get; set; }
        public string treesEquivalentSaved { get; set; }
        public string powerSavedInLightBulbs { get; set; }
    }

    public class EnergyChartMonth
    {
        public int name { get; set; }
        public List<double> data { get; set; }
    }

    public class EnergyChartQuarter
    {
        public int name { get; set; }
        public List<double> data { get; set; }
    }

    public class EnergyChartYear
    {
        public int name { get; set; }
        public List<double> data { get; set; }
    }

    public class PowerChartData
    {
        public long start_week { get; set; }
        public List<EnergyChartMonth> energy_chart_month { get; set; }
        public double energy_chart_month_max { get; set; }
        public string month_uom { get; set; }
        public List<EnergyChartQuarter> energy_chart_quarter { get; set; }
        public string quarter_uom { get; set; }
        public List<int> year_categories { get; set; }
        public List<EnergyChartYear> energy_chart_year { get; set; }
        public string year_uom { get; set; }
    }

    public class FieldStartDate
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
    }

    public class FieldEndDate
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
    }

    public class EndWeek
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
    }

    public class Production
    {
        public string total { get; set; }
        public string roundValueTotal { get; set; }
        public List<double> data { get; set; }
    }

    public class EnergyChartMonthByDay
    {
        public Production production { get; set; }
    }

    public class Production2
    {
        public string total { get; set; }
        public string roundValueTotal { get; set; }
        public List<double> data { get; set; }
    }

    public class EnergyChartYearByMonth
    {
        public Production2 production { get; set; }
    }

    public class EnergyChartData
    {
        public FieldStartDate field_start_date { get; set; }
        public FieldEndDate field_end_date { get; set; }
        public List<List<int>> year_range { get; set; }
        public long start_week { get; set; }
        public string GMTOffset { get; set; }
        public EndWeek end_week { get; set; }
        public long end_week_next { get; set; }
        public List<double?> power_chart_week { get; set; }
        public List<object> power_chart_week_c { get; set; }
        public List<object> power_chart_week_sc { get; set; }
        public EnergyChartMonthByDay energy_chart_month_by_day { get; set; }
        public double energy_chart_month_by_day_total { get; set; }
        public double energy_chart_month_by_day_max { get; set; }
        public int energy_chart_month_by_day_total_c { get; set; }
        public int energy_chart_month_by_day_max_c { get; set; }
        public int energy_chart_month_by_day_total_sc { get; set; }
        public int energy_chart_month_by_day_max_sc { get; set; }
        public EnergyChartYearByMonth energy_chart_year_by_month { get; set; }
        public double energy_chart_year_by_month_total { get; set; }
        public double energy_chart_year_by_month_max { get; set; }
        public int energy_chart_year_by_month_total_c { get; set; }
        public int energy_chart_year_by_month_max_c { get; set; }
        public int energy_chart_year_by_month_total_sc { get; set; }
        public int energy_chart_year_by_month_max_sc { get; set; }
        public long prev_month_date { get; set; }
        public long next_month_date { get; set; }
        public long prev_year_date { get; set; }
        public long next_year_date { get; set; }
        public string year_uom { get; set; }
        public string month_uom { get; set; }
    }

    public class PerformanceRatioData
    {
        public bool fieldHasPR { get; set; }
    }

    public class SolarEdgeData
    {
        public SumData sumData { get; set; }
        public InstData instData { get; set; }
        public ImgData imgData { get; set; }
        public OverviewData overviewData { get; set; }
        public SavingData savingData { get; set; }
        public PowerChartData powerChartData { get; set; }
        public EnergyChartData energyChartData { get; set; }
        public PerformanceRatioData performanceRatioData { get; set; }
    }
}
