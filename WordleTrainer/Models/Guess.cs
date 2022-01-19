using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordleTrainer.Models
{
	public class Guess
	{
		public string ChosenWord { get; set; }
		public string Guess1 { get; set; }

		public string Guess2 { get; set; }
		public string Guess3 { get; set; }
		public string Guess4 { get; set; }
		public string Guess5 { get; set; }
		public string Guess6 { get; set; }
		public string Guess1Attempt { get; set; }
		public string Guess2Attempt { get; set; }
		public string Guess3Attempt { get; set; }
		public string Guess4Attempt { get; set; }
		public string Guess5Attempt { get; set; }
		public string Guess6Attempt { get; set; }
		public string Error { get; set; }
		public string DeadLetters { get; set; }

	}
}
