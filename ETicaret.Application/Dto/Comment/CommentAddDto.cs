using System;
using System.Collections.Generic;
using ETicaret.Application.Dto.Category;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Comment
{
    public class CommentAddDto
    { 
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}