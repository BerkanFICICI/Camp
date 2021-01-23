using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(needCreditManager, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager, vehicleCreditManager, housingCreditManager };
            //applicationManager.CreditPreliminaryInformation(credits);
        }
    }
}
