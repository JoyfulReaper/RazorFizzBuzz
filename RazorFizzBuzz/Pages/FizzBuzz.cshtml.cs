using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorFizzBuzz.Models;

namespace RazorFizzBuzz.Pages
{
    public class FizzBuzzModel : PageModel
    {
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        public void OnGet()
        {
            FizzBuzz = new FizzBuzz
            {
                FizzValue = 3,
                BuzzValue = 5
            };
        }

        public void OnPost()
        {
            List<string> fbItems = new();

            bool isFizz;
            bool isBuzz;

            for (int i = 1; i <= 100; i++)
            {
                isFizz = i % FizzBuzz.FizzValue == 0;
                isBuzz = i % FizzBuzz.BuzzValue == 0;

                if (isBuzz && isFizz)
                {
                    fbItems.Add("FizzBuzz");
                }
                else if (isFizz)
                {
                    fbItems.Add("Fizz");
                }
                else if (isBuzz)
                {
                    fbItems.Add("Buzz");
                }
                else
                {
                    fbItems.Add(i.ToString());
                }
            }

            FizzBuzz.Result = fbItems;
        }
    }
}
