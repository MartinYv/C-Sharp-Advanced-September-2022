using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private string name;
        private int neededRenovators;
        private string project;



        public Catalog(string name, int neededRenovators, string project)
        {
            Renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public List<Renovator> Renovators{ get; set; }

        public string  Name
        { get { return name; }
            set { name = value; }
        }
        public int NeededRenovators
        {
            get {return neededRenovators; }
            set {neededRenovators= value; } 
        }
        public string Project 
        {
            get {return project; }
            set { project = value; }
        }
       

        public int Count
        {
            get { return Renovators.Count; }
        }

        public string AddRenovator(Renovator renovator)
        {
            if (NeededRenovators > Count)
            {
                if (Name == null| renovator.Type == null)
                {
                    return "Invalid renovator's information.";
                }

                else if (renovator.Rate > 350)
                {
                    return"Invalid renovator's rate";
                }

                else
                {
                    Renovators.Add(renovator);
                    return $"Successfully added {renovator.Name} to the catalog.";
                }
            }
            else
            {
                return $"Renovators are no more needed.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            if (Renovators.Any(x=>x.Name == name))
            {
               // var currRenovator = Renovators.First(x => x.Name == name);
               // Renovators.Remove(currRenovator);
                return true;
            }
            else
            {
                return false;
            }

        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            bool doesExist = Renovators.Any(x => x.Type == type);
            int renovatorsRemoved = 0;
            if (doesExist == true)
            {
                for (int i = 0; i < Renovators.Count; i++)
                {
                    if (Renovators[i].Type == type)
                    {
                        Renovators.Remove(Renovators[i]);
                        renovatorsRemoved++;
                    }
                }
            }

            return renovatorsRemoved;

        }

        public Renovator HireRenovator(string name)
        {
            bool isHeExist = Renovators.Any(x => x.Name == name);

            if (isHeExist == true)
            {
                var currRenovator = Renovators.Find(x => x.Name == name);
                currRenovator.Hired = true;
                return currRenovator;
            }
            else
            {
                return null;
            }
        }
        public List<Renovator> PayRenovators(int days)
        {
           List<Renovator> sorted = Renovators.Where(x => x.Days >= days).ToList();          
            return sorted;
        }

        public StringBuilder Report()
        {
            StringBuilder sb = new StringBuilder();

           sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in Renovators.Where(x=>x.Hired == false))
            {
             sb.AppendLine(item.ToString());
            }
        return sb;
        }
    }
}
