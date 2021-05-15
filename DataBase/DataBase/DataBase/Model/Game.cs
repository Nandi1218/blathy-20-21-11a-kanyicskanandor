using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Model
{
    public class Game : ObservableObject
    {
        [Key]
        public int ID { get => id; set => Set(ref id, value); }
        [Required]
        [StringLength(100)]
        private string gameName;
        public string GameName { get => gameName; set => Set(ref gameName, value); }
        private int id;
    }
}
