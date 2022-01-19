using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WordleTrainer.Models;

namespace WordleTrainer.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			//read the word list.
			string incoming = System.IO.File.ReadAllText(@"Words\words2.txt");
			string[] words = incoming.Split("\r\n");
			Console.WriteLine(words.Length);
			Random rnd = new Random();
			int rndIndex = rnd.Next(1, words.Length);
			Console.WriteLine(words[rndIndex]);

			Guess model = new Guess();
			model.ChosenWord = words[rndIndex].Trim().ToUpper();
			model.Error = ".";
			return View(model);
		}

		[HttpPost]
		public IActionResult Index(Guess model)
		{
			//read the word list.
			if (!ModelState.IsValid)
			{
				return View();
			}

			string incoming = System.IO.File.ReadAllText(@"Words\words2.txt");
			string[] words = incoming.Split("\r\n");

			model.Guess1 = model.Guess1.ToUpper();

			bool found = words.Contains(model.Guess1);
			if (!found)
			{
				model.Error = "word not found";
				return View(model);
			}

			if (model.Guess1 == model.ChosenWord)
			{
				return View("Success", model);
			}

			//check letters.
			string chosenWord = model.ChosenWord;
			string guess = model.Guess1;
			string attempt = string.Empty;
			attempt = checkAttempt(model, chosenWord, guess, attempt);
			model.Guess1Attempt = attempt;

			return View("GuessTwo", model);
		}

		private static string checkAttempt(Guess model, string chosenWord, string guess, string attempt)
		{
			for (int i = 0; i < 5; i++)
			{
				if (chosenWord[i] == guess[i])
				{
					attempt += "G";
				}
				else
				{
					attempt += "B";
					model.DeadLetters += guess[i] + " ";
				}
			}

			return attempt;
		}

		[HttpPost]
		public IActionResult GuessTwo(Guess model)
		{
			//read the word list.
			if (!ModelState.IsValid)
			{
				return View();
			}

			string incoming = System.IO.File.ReadAllText(@"Words\words2.txt");
			string[] words = incoming.Split("\r\n");

			model.Guess2 = model.Guess2.ToUpper();

			bool found = words.Contains(model.Guess2);
			if (!found)
			{
				model.Error = "word not found";
				return View(model);
			}

			if (model.Guess2 == model.ChosenWord)
			{
				return View("Success", model);
			}

			//check letters.
			string chosenWord = model.ChosenWord;
			string guess = model.Guess2;
			string attempt = string.Empty;
			attempt = checkAttempt(model, chosenWord, guess, attempt);
			model.Guess2Attempt = attempt;

			return View("GuessThree", model);
		}

		[HttpPost]
		public IActionResult GuessThree(Guess model)
		{
			//read the word list.
			if (!ModelState.IsValid)
			{
				return View();
			}

			string incoming = System.IO.File.ReadAllText(@"Words\words2.txt");
			string[] words = incoming.Split("\r\n");

			model.Guess3 = model.Guess3.ToUpper();

			bool found = words.Contains(model.Guess3);
			if (!found)
			{
				model.Error = "word not found";
				return View(model);
			}

			if (model.Guess3 == model.ChosenWord)
			{
				return View("Success", model);
			}

			//check letters.
			string chosenWord = model.ChosenWord;
			string guess = model.Guess3;
			string attempt = string.Empty;
			attempt = checkAttempt(model, chosenWord, guess, attempt);
			model.Guess3Attempt = attempt;

			return View("GuessFour", model);
		}


		[HttpPost]
		public IActionResult GuessFour(Guess model)
		{
			//read the word list.
			if (!ModelState.IsValid)
			{
				return View();
			}

			string incoming = System.IO.File.ReadAllText(@"Words\words2.txt");
			string[] words = incoming.Split("\r\n");

			model.Guess4 = model.Guess4.ToUpper();

			bool found = words.Contains(model.Guess4);
			if (!found)
			{
				model.Error = "word not found";
				return View(model);
			}

			if (model.Guess4 == model.ChosenWord)
			{
				return View("Success", model);
			}

			//check letters.
			string chosenWord = model.ChosenWord;
			string guess = model.Guess4;
			string attempt = string.Empty;
			attempt = checkAttempt(model, chosenWord, guess, attempt);
			model.Guess4Attempt = attempt;

			return View("GuessFive", model);
		}

		[HttpPost]
		public IActionResult GuessFive(Guess model)
		{
			//read the word list.
			if (!ModelState.IsValid)
			{
				return View();
			}

			string incoming = System.IO.File.ReadAllText(@"Words\words2.txt");
			string[] words = incoming.Split("\r\n");

			model.Guess5 = model.Guess5.ToUpper();

			bool found = words.Contains(model.Guess5);
			if (!found)
			{
				model.Error = "word not found";
				return View(model);
			}

			if (model.Guess5 == model.ChosenWord)
			{
				return View("Success", model);
			}

			//check letters.
			string chosenWord = model.ChosenWord;
			string guess = model.Guess5;
			string attempt = string.Empty;
			attempt = checkAttempt(model, chosenWord, guess, attempt);
			model.Guess5Attempt = attempt;

			return View("GuessSix", model);
		}

		[HttpPost]
		public IActionResult GuessSix(Guess model)
		{
			//read the word list.
			if (!ModelState.IsValid)
			{
				return View();
			}

			string incoming = System.IO.File.ReadAllText(@"Words\words2.txt");
			string[] words = incoming.Split("\r\n");

			model.Guess6 = model.Guess6.ToUpper();

			bool found = words.Contains(model.Guess6);
			if (!found)
			{
				model.Error = "word not found";
				return View(model);
			}

			if (model.Guess6 == model.ChosenWord)
			{
				return View("Success", model);
			}

			//check letters.
			string chosenWord = model.ChosenWord;
			string guess = model.Guess6;
			string attempt = string.Empty;
			attempt = checkAttempt(model, chosenWord, guess, attempt);
			model.Guess6Attempt = attempt;

			return View("Fail", model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
