using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad.Entities;
using Notepad.Entities.Concrete;

namespace Notepad.Business.Abstract
{
    //İş katmanı için soyutlama
    //Dosya işlemleri için bir arayüz tanımlanıyor.
    public interface IFileService
    {
        //Not nesnesini dosyaya kaydetme işlemi
        void Save(Note note);
        //Dosyadan not nesnesini okuma işlemi
        Note Load(string filepath);
    }
}
