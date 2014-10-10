using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using OOP_Prog_Lab_12.Code.Interfaces;

namespace OOP_Prog_Lab_12.Code
{
    class LoadPlugin
    {

        private Dictionary<string, IBasicOperations> _pluginsBasicOperations = new Dictionary<string, IBasicOperations>();
        private Dictionary<string, IOperationsMatrix> _pluginsOperationsMatrix = new Dictionary<string, IOperationsMatrix>();
        private Dictionary<string, IQueueOperations> _pluginsQueueOperations = new Dictionary<string, IQueueOperations>();

        Assembly mainAssembly;

        public LoadPlugin()
        {

            mainAssembly = Assembly.GetExecutingAssembly();
        }

        private void LoadPlugins(string path, string searchInterface, Dictionary<string, IBasicOperations> plugins)
        {

            plugins.Clear();

            foreach (var itemDll in Directory.GetFiles(path, "*.dll"))
            {

                Assembly assembly = Assembly.LoadFrom(itemDll);

                foreach (Type type in assembly.GetTypes())
                {
                    

                    if (type.GetInterface(searchInterface) == typeof(IBasicOperations))
                    {

                        //ДАЛЕЕ ЛОГИКА ЗАГРУЗКИ
                    }
                }
            }
        }

        private void LoadPlugins(string path, string searchInterface, Dictionary<string, IOperationsMatrix> plugins)
        {

            //ПЕРЕГРУЗКА
        }

        private void LoadPlugins(string path, string searchInterface, Dictionary<string, IQueueOperations> plugins)
        {


        }



    }
}
