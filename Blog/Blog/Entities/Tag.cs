﻿using System.ComponentModel.DataAnnotations;

namespace Blog.Entities
{
    /// <summary>
    /// Тег
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Идентификатор тега
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Название тега
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Посты
        /// </summary>
        public List<Post> Posts { get; set; }
    }
}
