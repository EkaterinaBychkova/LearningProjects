using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Diagnostics;
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

        private void SetLoadPlugins(string path, string searchInterface, Dictionary<string, IBasicOperations> plugins)
        {

            _pluginsBasicOperations.Clear();

            foreach (var itemDll in Directory.GetFiles(path, "*.dll"))
            {

                try
                {
                    Assembly assembly = Assembly.LoadFrom(itemDll);

                    foreach (Type type in assembly.GetTypes())
                    {


                        if (type.GetInterface(searchInterface) == typeof(IBasicOperations))
                        {

                            IBasicOperations plugin = Activator.CreateInstance(type) as IBasicOperations;
                            _pluginsBasicOperations[plugin.Name] = plugin;
                        }
                    }
                }
                catch(BadImageFormatException e)
                {

                    //Передача в окно Output информации.
                    Debug.WriteLine(e.Message);
                }
            }
        }

        private void SetLoadPlugins(string path, string searchInterface, Dictionary<string, IOperationsMatrix> plugins)
        {

            _pluginsBasicOperations.Clear();

            foreach (var itemDll in Directory.GetFiles(path, "*.dll"))
            {

                try
                {
                    Assembly assembly = Assembly.LoadFrom(itemDll);

                    foreach (Type type in assembly.GetTypes())
                    {


                        if (type.GetInterface(searchInterface) == typeof(IOperationsMatrix))
                        {

                            IOperationsMatrix plugin = Activator.CreateInstance(type) as IOperationsMatrix;
                            _pluginsOperationsMatrix[plugin.Name] = plugin;
                        }
                    }
                }
                catch (BadImageFormatException e)
                {

                    //Передача в окно Output информации.
                    Debug.WriteLine(e.Message);
                }
            }
        }

        private void SetLoadPlugins(string path, string searchInterface, Dictionary<string, IQueueOperations> plugins)
        {

            _pluginsBasicOperations.Clear();

            foreach (var itemDll in Directory.GetFiles(path, "*.dll"))
            {

                try
                {
                    Assembly assembly = Assembly.LoadFrom(itemDll);

                    foreach (Type type in assembly.GetTypes())
                    {


                        if (type.GetInterface(searchInterface) == typeof(IQueueOperations))
                        {

                            IQueueOperations plugin = Activator.CreateInstance(type) as IQueueOperations;
                            _pluginsQueueOperations[plugin.Name] = plugin;
                        }
                    }
                }
                catch (BadImageFormatException e)
                {

                    //Передача в окно Output информации.
                    Debug.WriteLine(e.Message);
                }
            }
        }

        //ДАЛЕЕ СМ. В МЕТОДИЧКЕ private void CreatePluginMenu()



    }
}
