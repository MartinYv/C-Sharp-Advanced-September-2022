using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            Fish = new List<Fish>();

            Material = material;
            Capacity = capacity;
        }

        public List<Fish>  Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Fish.Count; } }
        
        public string AddFish(Fish fish)
        {
            if (Capacity > 0)
            {
                if (fish.FishType == null || fish.FishType== " ")
                {
                    return "Invalid fish.";
                }

                else if (fish.Weight <= 0 || fish.Length <= 0)
                {
                    return "Invalid fish.";
                }
                else
                {
                    Fish.Add(fish);
                    Capacity--;
                    return $"Successfully added {fish.FishType} to the fishing net.";
                }


            }
            else
            {
                return "Fishing net is full.";
            }
        }  

        public bool ReleaseFish(double weight)
        {
            var fish = Fish.FirstOrDefault(x => x.Weight == weight);

            if (fish != null)
            {
                Fish.Remove(fish);
                Capacity++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Fish GetFish(string fishType)
        {
            var fish = Fish.FirstOrDefault(x => x.FishType == fishType);

            return fish;

        }

        public Fish GetBiggestFish()
        {
            var theLongestFish = Fish.Max(x => x.Length);
            var fish = Fish.FirstOrDefault(x => x.Length == theLongestFish);
            return fish;
        }
       public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");

            foreach (var item in Fish.OrderByDescending(x=>x.Length))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
