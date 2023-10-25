using System;

static class AssemblyLine
{
    private static readonly int _baseCarProduction = 221;
    public static double SuccessRate(int speed) => speed switch
        {
            < 1 => 0.0,
            <= 4 => 1.0,
            <= 8 => 0.9,
            <= 9 => 0.8,
            _ => 0.77
    };
    

    public static double ProductionRatePerHour(int speed) => speed * _baseCarProduction * SuccessRate(speed);
    
    public static int WorkingItemsPerMinute(int speed) => (int) ProductionRatePerHour(speed)/60;

}
