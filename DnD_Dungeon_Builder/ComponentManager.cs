﻿using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DnD_Dungeon_Builder
{
    public class ComponentManager
    {
        string path = "Components";
        public BindingList<Component> Components { get; private set; }

        public ComponentManager()
        {
            Components = new BindingList<Component>();

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            LoadComponentsFromFile();
        }

        public bool AddNewComponent(string name)
        {
            if (Components.Any(c => c.Name == name))
                return false;

            Components.Add(new Component(name));
            return true;
        }

        public bool RemoveComponent(Component component)
        {
            if(Components.Remove(component))
            {
                return true;
            }
            return false;
        }

        public void LoadComponent(Component component)
        {
            if (Components.Any(c => c.Name == component.Name))
                return;

            Components.Add(component);
        }

        public Component GetComponent(string name)
        {
            foreach (Component c in Components)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }
        
        public void SaveComponentToFile(Component component, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("Components/" + fileName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, component);
            }
        }

        public void SaveComponentToFile(Component component)
        {
            SaveComponentToFile(component, component.Name);
        }

        public void LoadComponentsFromFile()
        {
            Components.Clear();
            Console.WriteLine("Loading Files:");
            IFormatter formatter = new BinaryFormatter();
            foreach (string file in Directory.GetFiles(path))
            {
                if (Path.GetExtension(file) == ".bin")
                {
                    Console.WriteLine(file);
                    Component obj = null;
                    using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        try
                        {
                            obj = (Component)formatter.Deserialize(stream);
                            LoadComponent(obj);
                        }
                        catch (InvalidCastException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (SerializationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    if (obj != null)
                    {
                        obj.UpdateVariantFiles();
                        SaveComponentToFile(obj);
                    }
                }
            }

            Components.Insert(0, new Component("None"));
            Components.First().AddComponent("None");
        }
    }
}
