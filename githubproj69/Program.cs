//                                                       github.com/owersite
using System;
using Discord;

namespace githubproj69
{
    class Program
    {
       

        static void Main()
        {

            string token = ""; // Input your token here.
            try
            { 
                DiscordClient dc = new DiscordClient(token);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Logged in! Wait a sec!");

                ulong server_id = 999999; // Input Server ID here.
                try
                {
                    foreach (var roles in dc.GetGuildRoles(server_id)) 
                    {
                        Console.WriteLine(roles.Name);
                        //Note: It will say "?" for every char that has abnormal font.
                        
                    }
                    Console.Read();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.Read();
                }


            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(e);
                Console.Read();
            }
           

        }
    }
}
