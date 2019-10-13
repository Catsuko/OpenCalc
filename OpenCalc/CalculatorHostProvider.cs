using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OpenCalc
{
    public static class CalculatorHostProvider
    {
        private static IEnumerable<CalculatorHost> _calculators;

        public static IEnumerable<CalculatorHost> Calculators
        {
            get
            {
                if (_calculators == null)
                    _calculators = LoadCalculators();
                return _calculators;             
            }
        }

        private static IEnumerable<CalculatorHost> LoadCalculators()
        {
            return FindCalculators().Select(c => new CalculatorHost(c));
        }

        private static IEnumerable<ICalculator> FindCalculators ()
        {
            List<Assembly> plugInAssemblyList = new List<Assembly> { Assembly.Load("OpenCalc") };

            var pluginsPath = Path.Combine(Environment.CurrentDirectory, "Plugins");
            if(Directory.Exists(pluginsPath))
            {
                DirectoryInfo dInfo = new DirectoryInfo(pluginsPath);
                FileInfo[] files = dInfo.GetFiles("*.dll");

                foreach (FileInfo file in files)
                {
                    plugInAssemblyList.Add(Assembly.LoadFile(file.FullName));
                }
            }

            List<Type> assemblyTypes = new List<Type>();

            foreach (Assembly currentAssembly in plugInAssemblyList)
                assemblyTypes.AddRange(currentAssembly.GetTypes());

            var calculatorTypes = assemblyTypes.FindAll(delegate (Type t)
            {
                List<Type> interfaceTypes = new List<Type>(t.GetInterfaces());
                object[] arr = t.GetCustomAttributes(typeof(CalculatorPluginAttribute), true);
                return !(arr == null || arr.Length == 0) && interfaceTypes.Contains(typeof(ICalculator));
            });

            return calculatorTypes.ConvertAll(delegate (Type t) { return Activator.CreateInstance(t) as ICalculator; });
        }
    }
}
