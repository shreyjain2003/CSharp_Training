using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day6_Scenarios
{
        // ---------------------------------------------------
        // CreatorStats Class
        // ---------------------------------------------------
        public class CreatorStats
        {
            public string CreatorName { get; set; }
            public double[] WeeklyLikes { get; set; }
        }

        // ---------------------------------------------------
        // Program Class
        // ---------------------------------------------------
        public class StreamBuzz
        {
            // Static Collection
            public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

            // Register Creator
            public void RegisterCreator(CreatorStats record)
            {
                EngagementBoard.Add(record);
            }

            // Get Top Post Counts
            public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
            {
                Dictionary<string, int> result = new Dictionary<string, int>();

                foreach (CreatorStats creator in records)
                {
                    int count = creator.WeeklyLikes.Count(like => like >= likeThreshold);

                    if (count > 0)
                    {
                        result.Add(creator.CreatorName, count);
                    }
                }

                return result;
            }

            // Calculate Average Likes
            public double CalculateAverageLikes()
            {
                if (EngagementBoard.Count == 0)
                    return 0;

                double totalLikes = 0;
                int totalWeeks = 0;

                foreach (CreatorStats creator in EngagementBoard)
                {
                    totalLikes += creator.WeeklyLikes.Sum();
                    totalWeeks += creator.WeeklyLikes.Length;
                }

                return totalLikes / totalWeeks;
            }

            // ---------------------------------------------------
            // Main Method
            // ---------------------------------------------------
            static void Main(string[] args)
            {
                StreamBuzz program = new StreamBuzz();

                while (true)
                {
                    Console.WriteLine("1. Register Creator");
                    Console.WriteLine("2. Show Top Posts");
                    Console.WriteLine("3. Calculate Average Likes");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice:");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("Enter Creator Name:");
                        string name = Console.ReadLine();

                        double[] likes = new double[4];
                        Console.WriteLine("Enter weekly likes (Week 1 to 4):");

                        for (int i = 0; i < 4; i++)
                        {
                            likes[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        CreatorStats creator = new CreatorStats
                        {
                            CreatorName = name,
                            WeeklyLikes = likes
                        };

                        program.RegisterCreator(creator);

                        Console.WriteLine("Creator registered successfully");
                        Console.WriteLine();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter like threshold:");
                        double threshold = Convert.ToDouble(Console.ReadLine());

                        Dictionary<string, int> result =
                            program.GetTopPostCounts(EngagementBoard, threshold);

                        if (result.Count == 0)
                        {
                            Console.WriteLine("No top-performing posts this week");
                        }
                        else
                        {
                            foreach (var item in result)
                            {
                                Console.WriteLine(item.Key + " - " + item.Value);
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (choice == 3)
                    {
                        double avg = program.CalculateAverageLikes();
                        Console.WriteLine("Overall average weekly likes: " + avg);
                        Console.WriteLine();
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                        break;
                    }
                }
            }
        }
}

