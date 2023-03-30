using Core.Utilities.IOC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.RandomHelper
{
    public class RandomTool
    {
        public static int GenerateRandomNumberInRange(int min,int max)
        {
            Random random = ServiceTool.ServiceProvider.GetService<Random>();
            return random.Next(min,max);
        }
    }
}