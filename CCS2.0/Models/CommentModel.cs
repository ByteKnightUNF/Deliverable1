﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUpload.Models
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; }

        [Required(ErrorMessage = "Please enter your Comment.")]
        [StringLength(256, ErrorMessage = "The Comment cannot exceed 256 characters.")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50, ErrorMessage = "The Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        public Boolean Flag { get; set; }



        public int ImageId { get; set; }
        public ImageModel ImageModel { get; set; }
    }
}