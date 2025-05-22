using Notepad.Entities;
using Notepad.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.DataAccess
{
    //Veri erişim Katmanı:
    //Not nesnesini dosyaya kaydetme ve dosyadan okuma işlemlerini yapar.
    public class NoteDal
    {
        //Not nesnesini dosyaya kaydetme işlemi
        public void SavetoFile (Note note)
        {
            File.WriteAllText(note.FilePath, note.Content);
        }

        //Dosyadan not nesnesini okuma işlemi
        public Note LoadFromFile(string path)
        {
           return new Note
           {
               FilePath = path,
               Content = File.ReadAllText(path),
               CreatedDate = File.GetCreationTime(path)
           };
        }
    }
}
