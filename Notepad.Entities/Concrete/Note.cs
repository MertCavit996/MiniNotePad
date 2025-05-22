using Notepad.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Entities.Concrete
{
    // Not nesnesi:
    public class Note : IEntity
    {
        
        public string FilePath { get; set; } //Notun kaydedileceği dosya yolu
        public string Content { get; set; } //Notun içeriği
        public DateTime CreatedDate { get; set; } //Notun oluşturulma tarihi

    }
}
