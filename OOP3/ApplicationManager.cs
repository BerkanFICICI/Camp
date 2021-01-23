using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Methot injection.
        public void Application(ICreditManager creditManager, ILoggerService loggerService) 
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditPreliminaryInformation(List<ICreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
