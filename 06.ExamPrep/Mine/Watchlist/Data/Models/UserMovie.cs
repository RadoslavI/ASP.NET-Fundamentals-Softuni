﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Watchlist.Data.Models
{
    public class UserMovie
    {
        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        public int MovieId { get; set; }

        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; }
    }
}