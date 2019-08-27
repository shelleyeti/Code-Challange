using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShelleyArnold_CodeChallenge.Models
{
    public class Result
    {
        [Display(Name = "Number of Words Beginning with T")]
        public int StartsWithT { get; set; }

        [Display(Name = "Number of Words Ending with E")]
        public int EndsWithE { get; set; }

        [Display(Name = "Number of Words Beginning with T and Ending with E")]
        public int TAndE { get; set; }
    }
}
