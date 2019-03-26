﻿using System;
using static System.Console;
using ChuckNorrisAPI;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ApiTester
{
    class Program
    {
        static async Task Main()
        {
            //get random joke test
            WriteLine("Getting a single joke**********************");
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            WriteLine($"{j.Id}:{j.JokeText}\n\n{string.Join(", ", j.Categories)}");

            //get categories
            WriteLine("Getting categories****************************");
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                WriteLine(cat);
            }

            //print specific joke
            WriteLine("Getting specific joke***************************");
            Joke j2 = await ChuckNorrisClient.GetJokeById(2);
            WriteLine(j2.JokeText);


            ReadKey();
        }
    }
}