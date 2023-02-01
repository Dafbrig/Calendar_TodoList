﻿using System.ComponentModel.DataAnnotations;

namespace TodoListSofka.Model
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Responsible { get; set; }
        public bool IsCompleted { get; set; }

        //para el borrado lógico implementar bool o int según su preferencia.
        //si es int puedo colcocar un rango entre o y 1
        public bool State { get; set; }

        public TodoItem(Guid id, DateTime fecha, string description, string responsible, 
            bool isCompleted, bool state)
        {
            Id = id;
            Fecha = fecha;
            Description = description;
            Responsible = responsible;
            IsCompleted = isCompleted;
            State = state;
        }

        public TodoItem() { }



    }
}
