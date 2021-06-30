using System;
using System.Collections.Generic;
using ETicaret.Domain.Models;

namespace ETicaret.Application.Dto.Comment
{
    public class CommentUpdateDto
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
